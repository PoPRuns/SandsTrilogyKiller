using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SandsTrilogyKiller
{
    class KeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYUP = 0x0101;
        private readonly LowLevelKeyboardProc proc;
        private readonly IntPtr hookId;
        private static readonly Dictionary<string, Dictionary<string, string>> GameData = new Dictionary<string, Dictionary<string, string>>
        {
            {
                "SoT", new Dictionary<string, string>
                {
                    {"SteamID", "13600"},
                    {"MutexName", "POP_Launcher"}
                }
            },
            {
                "WW", new Dictionary<string, string>
                {
                    {"SteamID", "13500"},
                    {"MutexName", "POP5Launcher"}
                }
            },
            {
                "T2T", new Dictionary<string, string>
                {
                    {"SteamID", "13530"},
                    {"MutexName", "POP3Launcher"}
                }
            }
        };

        public int killerSpeed = 0;
        public string GameLauncherPath { get; set; }
        public string SelectedGame { get; set; }
        public Keys Hotkey { get; set; }
        public bool PriorityAffinity { get; set; }
        public bool HotkeyTextBoxOnFocus = false;
        public bool SteamLaunch { get; set; }
        public ProcessPriorityClass Priority { get; set; }

        public System.IntPtr Affinity { get; set; }

        public KeyboardHook()
        {
            proc = HookCallback;
            hookId = SetHook(proc);
        }

        ~KeyboardHook()
        {
            UnhookWindowsHookEx(hookId);
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                Keys vkCode = (Keys)Marshal.ReadInt32(lParam);
                if (vkCode == Hotkey && !HotkeyTextBoxOnFocus)
                {
                    ForceCloseProcesses(Process.GetProcessesByName("POP"));
                    ForceCloseProcesses(Process.GetProcessesByName("POP2"));
                    ForceCloseProcesses(Process.GetProcessesByName("POP3"));
                    if (SteamLaunch)
                    {
                        ForceCloseProcesses(Process.GetProcessesByName("PrinceOfPersia"));
                        try
                        {
                            Process.Start($"steam://run/{GameData[SelectedGame]["SteamID"]}");
                        }
                        catch
                        {
                            MessageBox.Show($"Could not start steam://run/{GameData[SelectedGame]["SteamID"]}",
                                            "Error staring Steam",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        try
                        {
                            System.Threading.Thread.Sleep(killerSpeed);
                            CreateOrGetMutex(GameData[SelectedGame]["MutexName"]);

                            DeleteCrashLog(GameLauncherPath);

                            Process proc = Process.Start(GameLauncherPath);
                            if (PriorityAffinity)
                            {
                                proc.ProcessorAffinity = Affinity;
                                proc.PriorityClass = Priority;
                            }
                        }
                        catch
                        {
                            MessageBox.Show($"Could not start process \"{GameLauncherPath}\"",
                                            "Error starting Process",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (HotkeyTextBoxOnFocus)
                {
                    HotkeyTextBoxOnFocus = false;
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        public static void ForceCloseProcesses(Process[] processes)
        {
            foreach (var process in processes)
            {
                process.Kill();
            }
        }

        public static void DeleteCrashLog(string GameLauncherPath)
        {
            string filePath = Path.Combine(Path.GetDirectoryName(GameLauncherPath), "PrinceSM");
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public static void CreateOrGetMutex(string mutexName)
        {
            if (!System.Threading.Mutex.TryOpenExisting(mutexName, out _))
            {
                new System.Threading.Mutex(false, mutexName);
            }
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}

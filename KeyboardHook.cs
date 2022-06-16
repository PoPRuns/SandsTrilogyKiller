using System;
using System.Diagnostics;
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

        public int killerSpeed = 0;
        public string GameLauncherPath { get; set; }
        public Keys Hotkey { get; set; }
        public bool PriorityAffinity { get; set; }

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
                if (vkCode == Hotkey)
                {
                    CloseProcesses(Process.GetProcessesByName("POP"));
                    CloseProcesses(Process.GetProcessesByName("POP2"));
                    CloseProcesses(Process.GetProcessesByName("POP3"));
                    try
                    {
                        System.Threading.Thread.Sleep(killerSpeed);
                        Process proc = Process.Start(GameLauncherPath);
                        if (PriorityAffinity)
                        {
                            proc.ProcessorAffinity = Affinity;
                            proc.PriorityClass = Priority;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Could not start process \"" + GameLauncherPath + "\"",
                                        "Error starting Process",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

        public static void CloseProcesses(Process[] processes)
        {
            foreach (var process in processes)
            {
                process.CloseMainWindow();
                process.WaitForExit();
                process.Dispose();
            }
        }

        public static void ForceCloseProcesses(Process[] processes)
        {
            foreach (var process in processes)
            {
                process.Kill();
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

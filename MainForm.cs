using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace SandsTrilogyKiller
{
    public partial class MainForm : Form
    {
        private KeyboardHook hookSoT = new KeyboardHook();
        private KeyboardHook hookWW = new KeyboardHook();
        private KeyboardHook hookT2T = new KeyboardHook();

        private const int SOT_PROCESS_READY_WAIT_TIME = 4000; // ms

        public MainForm()
        {
            InitializeComponent();
            this.ActiveControl = buttonReady;

            checkBoxSoT.Checked = Properties.Settings.Default.checkBoxSoT;
            checkBoxWW.Checked  = Properties.Settings.Default.checkBoxWW;
            checkBoxT2T.Checked = Properties.Settings.Default.checkBoxT2T;

            hookSoT.Hotkey = Properties.Settings.Default.hotkeySoT;
            hookWW.Hotkey  = Properties.Settings.Default.hotkeyWW;
            hookT2T.Hotkey = Properties.Settings.Default.hotkeyT2T;

            hookSoT.GameLauncherPath = txtPathSoT.Text;
            hookWW.GameLauncherPath  = txtPathWW.Text;
            hookT2T.GameLauncherPath = txtPathT2T.Text;

            txtHotkeySoT.Text = hookSoT.Hotkey.ToString();
            txtHotkeyWW.Text  = hookWW.Hotkey.ToString();
            txtHotkeyT2T.Text = hookT2T.Hotkey.ToString();

            txtPathSoT.Text = Properties.Settings.Default.pathSoT;
            txtPathWW.Text  = Properties.Settings.Default.pathWW;
            txtPathT2T.Text = Properties.Settings.Default.pathT2T;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.checkBoxSoT = checkBoxSoT.Checked;
            Properties.Settings.Default.checkBoxWW  = checkBoxWW.Checked;
            Properties.Settings.Default.checkBoxT2T = checkBoxT2T.Checked;

            Properties.Settings.Default.hotkeySoT = hookSoT.Hotkey;
            Properties.Settings.Default.hotkeyWW  = hookWW.Hotkey;
            Properties.Settings.Default.hotkeyT2T = hookT2T.Hotkey;

            Properties.Settings.Default.pathSoT = txtPathSoT.Text;
            Properties.Settings.Default.pathWW  = txtPathWW.Text;
            Properties.Settings.Default.pathT2T = txtPathT2T.Text;

            Properties.Settings.Default.Save();
        }

        void OpenFileDialog(TextBox linkedTextBox)
        {
            var dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                linkedTextBox.Text = openFileDialog.FileName;
            }
        }

        private void BtnChangePathSoT_Click(object sender, EventArgs e)
        {
            OpenFileDialog(txtPathSoT);
        }

        private void BtnChangePathWW_Click(object sender, EventArgs e)
        {
            OpenFileDialog(txtPathWW);
        }

        private void BtnChangePathT2T_Click(object sender, EventArgs e)
        {
            OpenFileDialog(txtPathT2T);
        }

        private void TrackBarKillerDelay_Scroll(object sender, EventArgs e)
        {
            hookSoT.killerSpeed = trackBarKillerDelay.Value;
            hookWW.killerSpeed  = trackBarKillerDelay.Value;
            hookT2T.killerSpeed = trackBarKillerDelay.Value;

            labelKillerDelayMs.Text = trackBarKillerDelay.Value.ToString() + " ms";
        }

        private void ButtonReady_Click(object sender, MouseEventArgs e)
        {
            if(checkBoxSoT.Checked)
            {
                readyPOPGame(hookSoT);
            }
            if(checkBoxWW.Checked)
            {
                readyPOPGame(hookWW);
            }
            if(checkBoxT2T.Checked)
            {
                readyPOPGame(hookT2T);
            }
        }
       
        private void TxtPathSoT_TextChanged(object sender, EventArgs e)
        {
            hookSoT.GameLauncherPath = txtPathSoT.Text;
            txtPathSoT.SelectionStart = txtPathSoT.Text.Length - 1;
        }

        private void TxtPathWW_TextChanged(object sender, EventArgs e)
        {
            hookWW.GameLauncherPath = txtPathWW.Text;
            txtPathWW.SelectionStart = txtPathWW.Text.Length - 1;
        }

        private void TxtPathT2T_TextChanged(object sender, EventArgs e)
        {
            hookT2T.GameLauncherPath = txtPathT2T.Text;
            txtPathT2T.SelectionStart = txtPathT2T.Text.Length - 1;
        }

        private void TxtHotkeySoT_KeyUp(object sender, KeyEventArgs e)
        {
            hookSoT.Hotkey = e.KeyCode;
            txtHotkeySoT.Text = hookSoT.Hotkey.ToString();
        }

        private void TxtHotkeyWW_KeyUp(object sender, KeyEventArgs e)
        {
            hookWW.Hotkey = e.KeyCode;
            txtHotkeyWW.Text = hookWW.Hotkey.ToString();
        }

        private void TxtHotkeyT2T_KeyUp(object sender, KeyEventArgs e)
        {
            hookT2T.Hotkey = e.KeyCode;
            txtHotkeyT2T.Text = hookT2T.Hotkey.ToString();
        }

        public void startSoTProcess(String princeOfPersiaFile)
        {
            int msElapsed = 0;
            try
            {
                Process.Start(princeOfPersiaFile);
                while (Process.GetProcessesByName("POP").Length == 0 && msElapsed < SOT_PROCESS_READY_WAIT_TIME)
                {
                    Thread.Sleep(500);
                    msElapsed += 500;
                }
                Thread.Sleep(500);

                KeyboardHook.ForceCloseProcesses(Process.GetProcessesByName("POP"));
            } catch
            {
            }
        }

        private void readyPOPGame(KeyboardHook hook)
        {
            if (hook.GameLauncherPath == txtPathSoT.Text)
            {
                String princeOfPersiaFile = hook.GameLauncherPath.Substring(0, hook.GameLauncherPath.Length - 7) + "PrinceOfPersia.EXE";
                if (File.Exists(princeOfPersiaFile))
                {
                    // we create new thread so we don't freeze our UI while waiting for process to start.
                    new Thread(() => startSoTProcess(princeOfPersiaFile)).Start();
                }

            } else if(hook.GameLauncherPath == txtPathWW.Text || hook.GameLauncherPath == txtPathT2T.Text)
            {
                String princeOfPersiaFile = hook.GameLauncherPath.Substring(0, hook.GameLauncherPath.Length - 8) + "PrinceOfPersia.EXE";
                try
                {
                    Process.Start(princeOfPersiaFile);
                }
                catch
                {
                    MessageBox.Show("Could not start process \"" + hook.GameLauncherPath + "\"",
                                   "Error starting Process",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

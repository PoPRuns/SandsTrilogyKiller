using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SandsTrilogyKiller
{
    public partial class MainForm : Form
    {
        private KeyboardHook hook = new KeyboardHook();

        public MainForm()
        {
            InitializeComponent();
            cmbActiveGame.SelectedIndex = Properties.Settings.Default.activeGame;
            hook.Hotkey = Properties.Settings.Default.hotkey;
            txtHotkey.Text = hook.Hotkey.ToString();
            txtPathSoT.Text = Properties.Settings.Default.pathSoT;
            txtPathWW.Text = Properties.Settings.Default.pathWW;
            txtPathT2T.Text = Properties.Settings.Default.pathT2T;
            SetGameLauncherPath();
            hook.PriorityAffinity = checkBox1.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.activeGame = cmbActiveGame.SelectedIndex;
            Properties.Settings.Default.hotkey = hook.Hotkey;
            Properties.Settings.Default.pathSoT = txtPathSoT.Text;
            Properties.Settings.Default.pathWW = txtPathWW.Text;
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

        private void TxtHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            hook.Hotkey = e.KeyCode;
            txtHotkey.Text = hook.Hotkey.ToString();
        }

        private void CurrentGameLauncherPathChanged(object sender, EventArgs e)
        {
            SetGameLauncherPath();
        }

        void SetGameLauncherPath()
        {
            switch (cmbActiveGame.SelectedIndex)
            {
                case 0:
                    hook.GameLauncherPath = txtPathSoT.Text;
                    break;
                case 1:
                    hook.GameLauncherPath = txtPathWW.Text;
                    break;
                case 2:
                    hook.GameLauncherPath = txtPathT2T.Text;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (hook.GameLauncherPath == txtPathSoT.Text)
            {
                String princeOfPersiaFile = hook.GameLauncherPath.Substring(0, hook.GameLauncherPath.Length - 7) + "PrinceOfPersia.EXE";
                if (File.Exists(princeOfPersiaFile))
                {
                    try
                    {
                        Process.Start(princeOfPersiaFile);
                        while (Process.GetProcessesByName("POP").Length == 0)
                        {
                            System.Threading.Thread.Sleep(500);
                        }
                        System.Threading.Thread.Sleep(500);
                    } catch
                    {
                        MessageBox.Show("Could not start process \"" + hook.GameLauncherPath + "\"",
                                       "Error starting Process",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    KeyboardHook.ForceCloseProcesses(Process.GetProcessesByName("POP"));
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

        private void trackBarKillerDelay_Scroll(object sender, EventArgs e)
        {
            hook.killerSpeed = trackBarKillerDelay.Value;
            labelKillerDelayMs.Text = trackBarKillerDelay.Value.ToString() + " ms";
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            hook.PriorityAffinity = checkBox1.Checked;
        }
    }
}

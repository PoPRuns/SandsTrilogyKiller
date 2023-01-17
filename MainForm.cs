﻿using System;
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

            int coreCount = Environment.ProcessorCount;
            for (int i = 0;  i < coreCount; i++) affinityComboBox.Items.Add("CPU " + i.ToString());
            hook.Priority = Properties.Settings.Default.priority;
            hook.Affinity = (System.IntPtr)Properties.Settings.Default.affinity;
            switch (Properties.Settings.Default.priority)
            {
                case ProcessPriorityClass.RealTime      : priorityComboBox.SelectedIndex = 0; break;
                case ProcessPriorityClass.High          : priorityComboBox.SelectedIndex = 1; break;
                case ProcessPriorityClass.AboveNormal   : priorityComboBox.SelectedIndex = 2; break;
                case ProcessPriorityClass.Normal        : priorityComboBox.SelectedIndex = 3; break;
                case ProcessPriorityClass.BelowNormal   : priorityComboBox.SelectedIndex = 4; break;
                case ProcessPriorityClass.Idle          : priorityComboBox.SelectedIndex = 5; break;
                default                                 : break;
            }
            affinityComboBox.SelectedIndex = (int)Math.Log(Properties.Settings.Default.affinity, 2);
            hook.PriorityAffinity = cboxPriorityAffinity.Checked;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.activeGame = cmbActiveGame.SelectedIndex;
            Properties.Settings.Default.hotkey = hook.Hotkey;
            Properties.Settings.Default.pathSoT = txtPathSoT.Text;
            Properties.Settings.Default.pathWW = txtPathWW.Text;
            Properties.Settings.Default.pathT2T = txtPathT2T.Text;
            Properties.Settings.Default.priority = hook.Priority;
            Properties.Settings.Default.affinity = (int)hook.Affinity;
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
            hook.HotkeyTextBoxOnFocus = true;
            hook.Hotkey = e.KeyCode;
            txtHotkey.Text = hook.Hotkey.ToString();
            this.ActiveControl = null;
        }

        private void CurrentGameLauncherPathChanged(object sender, EventArgs e)
        {
            SetGameLauncherPath();
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                tb.SelectionStart = tb.Text.Length;
                tb.ScrollToCaret();
            }
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

        private void btnReady_Click(object sender, EventArgs e)
        {
            
            if (hook.GameLauncherPath == txtPathSoT.Text)
            {
                String princeOfPersiaFile = hook.GameLauncherPath.Substring(0, hook.GameLauncherPath.Length - 7) + "PrinceOfPersia.EXE";
                if (File.Exists(princeOfPersiaFile))
                {
                    if (Process.GetProcessesByName("PrinceOfPersia").Length > 0)
                    {
                        foreach (var process in Process.GetProcessesByName("PrinceOfPersia"))
                        {
                            process.Kill();
                        }
                    }
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

        private void cboxPriorityAffinity_CheckStateChanged(object sender, EventArgs e)
        {
            hook.PriorityAffinity = cboxPriorityAffinity.Checked;
        }

        private void priorityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (priorityComboBox.SelectedIndex)
            {
                case 0: hook.Priority = ProcessPriorityClass.RealTime; break;
                case 1: hook.Priority = ProcessPriorityClass.High; break;
                case 2: hook.Priority = ProcessPriorityClass.AboveNormal; break;
                case 3: hook.Priority = ProcessPriorityClass.Normal; break;
                case 4: hook.Priority = ProcessPriorityClass.BelowNormal; break;
                case 5: hook.Priority = ProcessPriorityClass.Idle; break;
                default: break;
            }
        }

        private void affinityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hook.Affinity = (System.IntPtr)Math.Pow(2, affinityComboBox.SelectedIndex);
        }
    }
}

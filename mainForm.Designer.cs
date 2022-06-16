namespace SandsTrilogyKiller
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtPathSoT = new System.Windows.Forms.TextBox();
            this.txtPathWW = new System.Windows.Forms.TextBox();
            this.btnChangePathSoT = new System.Windows.Forms.Button();
            this.btnChangePathWW = new System.Windows.Forms.Button();
            this.txtPathT2T = new System.Windows.Forms.TextBox();
            this.btnChangePathT2T = new System.Windows.Forms.Button();
            this.lblPathSoT = new System.Windows.Forms.Label();
            this.lblPathWW = new System.Windows.Forms.Label();
            this.lblPathT2T = new System.Windows.Forms.Label();
            this.cmbActiveGame = new System.Windows.Forms.ComboBox();
            this.lblHotkey = new System.Windows.Forms.Label();
            this.txtHotkey = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnReady = new System.Windows.Forms.Button();
            this.trackBarKillerDelay = new System.Windows.Forms.TrackBar();
            this.labelKillerDelay = new System.Windows.Forms.Label();
            this.labelKillerDelayMs = new System.Windows.Forms.Label();
            this.cboxPriorityAffinity = new System.Windows.Forms.CheckBox();
            this.contextMenuPriorityAffinity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.affinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affinityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKillerDelay)).BeginInit();
            this.contextMenuPriorityAffinity.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPathSoT
            // 
            this.txtPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathSoT.Location = new System.Drawing.Point(48, 106);
            this.txtPathSoT.Name = "txtPathSoT";
            this.txtPathSoT.Size = new System.Drawing.Size(343, 20);
            this.txtPathSoT.TabIndex = 2;
            this.txtPathSoT.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // txtPathWW
            // 
            this.txtPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathWW.Location = new System.Drawing.Point(48, 132);
            this.txtPathWW.Name = "txtPathWW";
            this.txtPathWW.Size = new System.Drawing.Size(343, 20);
            this.txtPathWW.TabIndex = 3;
            this.txtPathWW.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathSoT
            // 
            this.btnChangePathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathSoT.Location = new System.Drawing.Point(397, 104);
            this.btnChangePathSoT.Name = "btnChangePathSoT";
            this.btnChangePathSoT.Size = new System.Drawing.Size(30, 23);
            this.btnChangePathSoT.TabIndex = 5;
            this.btnChangePathSoT.Text = "...";
            this.btnChangePathSoT.UseVisualStyleBackColor = true;
            this.btnChangePathSoT.Click += new System.EventHandler(this.BtnChangePathSoT_Click);
            // 
            // btnChangePathWW
            // 
            this.btnChangePathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathWW.Location = new System.Drawing.Point(397, 130);
            this.btnChangePathWW.Name = "btnChangePathWW";
            this.btnChangePathWW.Size = new System.Drawing.Size(30, 23);
            this.btnChangePathWW.TabIndex = 6;
            this.btnChangePathWW.Text = "...";
            this.btnChangePathWW.UseVisualStyleBackColor = true;
            this.btnChangePathWW.Click += new System.EventHandler(this.BtnChangePathWW_Click);
            // 
            // txtPathT2T
            // 
            this.txtPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathT2T.Location = new System.Drawing.Point(48, 158);
            this.txtPathT2T.Name = "txtPathT2T";
            this.txtPathT2T.Size = new System.Drawing.Size(343, 20);
            this.txtPathT2T.TabIndex = 4;
            this.txtPathT2T.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathT2T
            // 
            this.btnChangePathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathT2T.Location = new System.Drawing.Point(397, 156);
            this.btnChangePathT2T.Name = "btnChangePathT2T";
            this.btnChangePathT2T.Size = new System.Drawing.Size(30, 23);
            this.btnChangePathT2T.TabIndex = 7;
            this.btnChangePathT2T.Text = "...";
            this.btnChangePathT2T.UseVisualStyleBackColor = true;
            this.btnChangePathT2T.Click += new System.EventHandler(this.BtnChangePathT2T_Click);
            // 
            // lblPathSoT
            // 
            this.lblPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathSoT.AutoSize = true;
            this.lblPathSoT.Location = new System.Drawing.Point(12, 109);
            this.lblPathSoT.Name = "lblPathSoT";
            this.lblPathSoT.Size = new System.Drawing.Size(30, 13);
            this.lblPathSoT.TabIndex = 9;
            this.lblPathSoT.Text = "SoT:";
            // 
            // lblPathWW
            // 
            this.lblPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathWW.AutoSize = true;
            this.lblPathWW.Location = new System.Drawing.Point(12, 135);
            this.lblPathWW.Name = "lblPathWW";
            this.lblPathWW.Size = new System.Drawing.Size(32, 13);
            this.lblPathWW.TabIndex = 10;
            this.lblPathWW.Text = "WW:";
            // 
            // lblPathT2T
            // 
            this.lblPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathT2T.AutoSize = true;
            this.lblPathT2T.Location = new System.Drawing.Point(12, 161);
            this.lblPathT2T.Name = "lblPathT2T";
            this.lblPathT2T.Size = new System.Drawing.Size(30, 13);
            this.lblPathT2T.TabIndex = 11;
            this.lblPathT2T.Text = "T2T:";
            // 
            // cmbActiveGame
            // 
            this.cmbActiveGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActiveGame.FormattingEnabled = true;
            this.cmbActiveGame.Items.AddRange(new object[] {
            "Sands of Time",
            "Warrior Within",
            "The Two Thrones"});
            this.cmbActiveGame.Location = new System.Drawing.Point(12, 12);
            this.cmbActiveGame.Name = "cmbActiveGame";
            this.cmbActiveGame.Size = new System.Drawing.Size(159, 21);
            this.cmbActiveGame.TabIndex = 0;
            this.cmbActiveGame.SelectedIndexChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // lblHotkey
            // 
            this.lblHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHotkey.Location = new System.Drawing.Point(298, 12);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(56, 17);
            this.lblHotkey.TabIndex = 8;
            this.lblHotkey.Text = "Hotkey:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Location = new System.Drawing.Point(360, 12);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.Size = new System.Drawing.Size(67, 20);
            this.txtHotkey.TabIndex = 1;
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PoP Executable|pop.exe;pop2.exe;pop3.exe|All Files (*.*)|*.*";
            // 
            // btnReady
            // 
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(190, 7);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(79, 29);
            this.btnReady.TabIndex = 12;
            this.btnReady.Text = "Ready";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // trackBarKillerDelay
            // 
            this.trackBarKillerDelay.LargeChange = 100;
            this.trackBarKillerDelay.Location = new System.Drawing.Point(37, 70);
            this.trackBarKillerDelay.Maximum = 2000;
            this.trackBarKillerDelay.Name = "trackBarKillerDelay";
            this.trackBarKillerDelay.Size = new System.Drawing.Size(354, 45);
            this.trackBarKillerDelay.SmallChange = 10;
            this.trackBarKillerDelay.TabIndex = 15;
            this.trackBarKillerDelay.TickFrequency = 1000;
            this.trackBarKillerDelay.Scroll += new System.EventHandler(this.trackBarKillerDelay_Scroll);
            // 
            // labelKillerDelay
            // 
            this.labelKillerDelay.AutoSize = true;
            this.labelKillerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelay.Location = new System.Drawing.Point(44, 41);
            this.labelKillerDelay.Name = "labelKillerDelay";
            this.labelKillerDelay.Size = new System.Drawing.Size(87, 20);
            this.labelKillerDelay.TabIndex = 17;
            this.labelKillerDelay.Text = "Killer delay:";
            // 
            // labelKillerDelayMs
            // 
            this.labelKillerDelayMs.AutoSize = true;
            this.labelKillerDelayMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelayMs.Location = new System.Drawing.Point(137, 41);
            this.labelKillerDelayMs.Name = "labelKillerDelayMs";
            this.labelKillerDelayMs.Size = new System.Drawing.Size(50, 24);
            this.labelKillerDelayMs.TabIndex = 18;
            this.labelKillerDelayMs.Text = "0 ms";
            // 
            // cboxPriorityAffinity
            // 
            this.cboxPriorityAffinity.AutoSize = true;
            this.cboxPriorityAffinity.ContextMenuStrip = this.contextMenuPriorityAffinity;
            this.cboxPriorityAffinity.Location = new System.Drawing.Point(301, 41);
            this.cboxPriorityAffinity.Name = "cboxPriorityAffinity";
            this.cboxPriorityAffinity.Size = new System.Drawing.Size(131, 17);
            this.cboxPriorityAffinity.TabIndex = 19;
            this.cboxPriorityAffinity.Text = "Set Priority and Affinity";
            this.toolTip1.SetToolTip(this.cboxPriorityAffinity, "Set custom priority and affinity while launching. Right click for more options.");
            this.cboxPriorityAffinity.UseVisualStyleBackColor = true;
            this.cboxPriorityAffinity.CheckStateChanged += new System.EventHandler(this.cboxPriorityAffinity_CheckStateChanged);
            // 
            // contextMenuPriorityAffinity
            // 
            this.contextMenuPriorityAffinity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priorityToolStripMenuItem,
            this.affinityToolStripMenuItem});
            this.contextMenuPriorityAffinity.Name = "contextMenuStrip1";
            this.contextMenuPriorityAffinity.Size = new System.Drawing.Size(114, 48);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priorityComboBox});
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.priorityToolStripMenuItem.Text = "Priority";
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.Items.AddRange(new object[] {
            "Realtime",
            "High",
            "Above normal",
            "Normal",
            "Below normal",
            "Low"});
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(121, 23);
            this.priorityComboBox.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox_SelectedIndexChanged);
            // 
            // affinityToolStripMenuItem
            // 
            this.affinityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affinityComboBox});
            this.affinityToolStripMenuItem.Name = "affinityToolStripMenuItem";
            this.affinityToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.affinityToolStripMenuItem.Text = "Affinity";
            // 
            // affinityComboBox
            // 
            this.affinityComboBox.Name = "affinityComboBox";
            this.affinityComboBox.Size = new System.Drawing.Size(121, 23);
            this.affinityComboBox.SelectedIndexChanged += new System.EventHandler(this.affinityComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 188);
            this.Controls.Add(this.cboxPriorityAffinity);
            this.Controls.Add(this.btnChangePathSoT);
            this.Controls.Add(this.txtPathSoT);
            this.Controls.Add(this.lblPathSoT);
            this.Controls.Add(this.labelKillerDelay);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.cmbActiveGame);
            this.Controls.Add(this.lblPathT2T);
            this.Controls.Add(this.lblPathWW);
            this.Controls.Add(this.btnChangePathT2T);
            this.Controls.Add(this.txtPathT2T);
            this.Controls.Add(this.btnChangePathWW);
            this.Controls.Add(this.txtPathWW);
            this.Controls.Add(this.trackBarKillerDelay);
            this.Controls.Add(this.labelKillerDelayMs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(18, 168);
            this.Name = "MainForm";
            this.Text = "SandsTrilogyKiller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKillerDelay)).EndInit();
            this.contextMenuPriorityAffinity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPathSoT;
        private System.Windows.Forms.TextBox txtPathWW;
        private System.Windows.Forms.Button btnChangePathSoT;
        private System.Windows.Forms.Button btnChangePathWW;
        private System.Windows.Forms.TextBox txtPathT2T;
        private System.Windows.Forms.Button btnChangePathT2T;
        private System.Windows.Forms.Label lblPathSoT;
        private System.Windows.Forms.Label lblPathWW;
        private System.Windows.Forms.Label lblPathT2T;
        private System.Windows.Forms.ComboBox cmbActiveGame;
        private System.Windows.Forms.Label lblHotkey;
        private System.Windows.Forms.TextBox txtHotkey;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.TrackBar trackBarKillerDelay;
        private System.Windows.Forms.Label labelKillerDelay;
        private System.Windows.Forms.Label labelKillerDelayMs;
        public System.Windows.Forms.CheckBox cboxPriorityAffinity;
        private System.Windows.Forms.ContextMenuStrip contextMenuPriorityAffinity;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affinityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox affinityComboBox;
        private System.Windows.Forms.ToolStripComboBox priorityComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


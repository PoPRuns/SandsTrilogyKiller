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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.labelKillerDelay = new System.Windows.Forms.Label();
            this.labelKillerDelayMs = new System.Windows.Forms.Label();
            this.cboxPriorityAffinity = new System.Windows.Forms.CheckBox();
            this.contextMenuPriorityAffinity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.priorityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priorityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.affinityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affinityComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboxSteam = new System.Windows.Forms.CheckBox();
            this.numericUpDownKillerDelay = new System.Windows.Forms.NumericUpDown();
            this.contextMenuPriorityAffinity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKillerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathSoT
            // 
            this.txtPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathSoT.Location = new System.Drawing.Point(65, 104);
            this.txtPathSoT.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathSoT.Name = "txtPathSoT";
            this.txtPathSoT.ReadOnly = true;
            this.txtPathSoT.Size = new System.Drawing.Size(313, 22);
            this.txtPathSoT.TabIndex = 2;
            this.txtPathSoT.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // txtPathWW
            // 
            this.txtPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathWW.Location = new System.Drawing.Point(65, 136);
            this.txtPathWW.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathWW.Name = "txtPathWW";
            this.txtPathWW.ReadOnly = true;
            this.txtPathWW.Size = new System.Drawing.Size(313, 22);
            this.txtPathWW.TabIndex = 3;
            this.txtPathWW.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathSoT
            // 
            this.btnChangePathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathSoT.Location = new System.Drawing.Point(387, 102);
            this.btnChangePathSoT.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePathSoT.Name = "btnChangePathSoT";
            this.btnChangePathSoT.Size = new System.Drawing.Size(40, 28);
            this.btnChangePathSoT.TabIndex = 5;
            this.btnChangePathSoT.Text = "...";
            this.btnChangePathSoT.UseVisualStyleBackColor = true;
            this.btnChangePathSoT.Click += new System.EventHandler(this.BtnChangePathSoT_Click);
            // 
            // btnChangePathWW
            // 
            this.btnChangePathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathWW.Location = new System.Drawing.Point(387, 134);
            this.btnChangePathWW.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePathWW.Name = "btnChangePathWW";
            this.btnChangePathWW.Size = new System.Drawing.Size(40, 28);
            this.btnChangePathWW.TabIndex = 6;
            this.btnChangePathWW.Text = "...";
            this.btnChangePathWW.UseVisualStyleBackColor = true;
            this.btnChangePathWW.Click += new System.EventHandler(this.BtnChangePathWW_Click);
            // 
            // txtPathT2T
            // 
            this.txtPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathT2T.Location = new System.Drawing.Point(65, 168);
            this.txtPathT2T.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathT2T.Name = "txtPathT2T";
            this.txtPathT2T.ReadOnly = true;
            this.txtPathT2T.Size = new System.Drawing.Size(313, 22);
            this.txtPathT2T.TabIndex = 4;
            this.txtPathT2T.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathT2T
            // 
            this.btnChangePathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathT2T.Location = new System.Drawing.Point(387, 166);
            this.btnChangePathT2T.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangePathT2T.Name = "btnChangePathT2T";
            this.btnChangePathT2T.Size = new System.Drawing.Size(40, 28);
            this.btnChangePathT2T.TabIndex = 7;
            this.btnChangePathT2T.Text = "...";
            this.btnChangePathT2T.UseVisualStyleBackColor = true;
            this.btnChangePathT2T.Click += new System.EventHandler(this.BtnChangePathT2T_Click);
            // 
            // lblPathSoT
            // 
            this.lblPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathSoT.AutoSize = true;
            this.lblPathSoT.Location = new System.Drawing.Point(17, 108);
            this.lblPathSoT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathSoT.Name = "lblPathSoT";
            this.lblPathSoT.Size = new System.Drawing.Size(36, 16);
            this.lblPathSoT.TabIndex = 9;
            this.lblPathSoT.Text = "SoT:";
            // 
            // lblPathWW
            // 
            this.lblPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathWW.AutoSize = true;
            this.lblPathWW.Location = new System.Drawing.Point(17, 140);
            this.lblPathWW.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathWW.Name = "lblPathWW";
            this.lblPathWW.Size = new System.Drawing.Size(36, 16);
            this.lblPathWW.TabIndex = 10;
            this.lblPathWW.Text = "WW:";
            // 
            // lblPathT2T
            // 
            this.lblPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathT2T.AutoSize = true;
            this.lblPathT2T.Location = new System.Drawing.Point(17, 172);
            this.lblPathT2T.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathT2T.Name = "lblPathT2T";
            this.lblPathT2T.Size = new System.Drawing.Size(35, 16);
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
            this.cmbActiveGame.Location = new System.Drawing.Point(16, 15);
            this.cmbActiveGame.Margin = new System.Windows.Forms.Padding(4);
            this.cmbActiveGame.Name = "cmbActiveGame";
            this.cmbActiveGame.Size = new System.Drawing.Size(211, 24);
            this.cmbActiveGame.TabIndex = 0;
            this.cmbActiveGame.SelectedIndexChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // lblHotkey
            // 
            this.lblHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkey.AutoSize = true;
            this.lblHotkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHotkey.Location = new System.Drawing.Point(254, 15);
            this.lblHotkey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(66, 20);
            this.lblHotkey.TabIndex = 8;
            this.lblHotkey.Text = "Hotkey:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Location = new System.Drawing.Point(337, 15);
            this.txtHotkey.Margin = new System.Windows.Forms.Padding(4);
            this.txtHotkey.Name = "txtHotkey";
            this.txtHotkey.ReadOnly = true;
            this.txtHotkey.Size = new System.Drawing.Size(88, 22);
            this.txtHotkey.TabIndex = 1;
            this.txtHotkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtHotkey_KeyDown);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PoP Executable|pop.exe;pop2.exe;pop3.exe";
            // 
            // labelKillerDelay
            // 
            this.labelKillerDelay.AutoSize = true;
            this.labelKillerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelay.Location = new System.Drawing.Point(14, 49);
            this.labelKillerDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKillerDelay.Name = "labelKillerDelay";
            this.labelKillerDelay.Size = new System.Drawing.Size(96, 20);
            this.labelKillerDelay.TabIndex = 17;
            this.labelKillerDelay.Text = "Killer delay:";
            this.toolTip1.SetToolTip(this.labelKillerDelay, "Use only if you are having issues, otherwise leave it at 0.");
            // 
            // labelKillerDelayMs
            // 
            this.labelKillerDelayMs.AutoSize = true;
            this.labelKillerDelayMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelayMs.Location = new System.Drawing.Point(174, 48);
            this.labelKillerDelayMs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKillerDelayMs.Name = "labelKillerDelayMs";
            this.labelKillerDelayMs.Size = new System.Drawing.Size(32, 20);
            this.labelKillerDelayMs.TabIndex = 18;
            this.labelKillerDelayMs.Text = "ms";
            // 
            // cboxPriorityAffinity
            // 
            this.cboxPriorityAffinity.AutoSize = true;
            this.cboxPriorityAffinity.ContextMenuStrip = this.contextMenuPriorityAffinity;
            this.cboxPriorityAffinity.Location = new System.Drawing.Point(260, 50);
            this.cboxPriorityAffinity.Margin = new System.Windows.Forms.Padding(4);
            this.cboxPriorityAffinity.Name = "cboxPriorityAffinity";
            this.cboxPriorityAffinity.Size = new System.Drawing.Size(160, 20);
            this.cboxPriorityAffinity.TabIndex = 19;
            this.cboxPriorityAffinity.Text = "Set Priority and Affinity";
            this.toolTip1.SetToolTip(this.cboxPriorityAffinity, "Set custom priority and affinity while launching. Right click for more options.\nK" +
        "eep this unchecked unless you know what you are doing.");
            this.cboxPriorityAffinity.UseVisualStyleBackColor = true;
            this.cboxPriorityAffinity.CheckStateChanged += new System.EventHandler(this.cboxPriorityAffinity_CheckStateChanged);
            // 
            // contextMenuPriorityAffinity
            // 
            this.contextMenuPriorityAffinity.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuPriorityAffinity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priorityToolStripMenuItem,
            this.affinityToolStripMenuItem});
            this.contextMenuPriorityAffinity.Name = "contextMenuStrip1";
            this.contextMenuPriorityAffinity.Size = new System.Drawing.Size(127, 52);
            // 
            // priorityToolStripMenuItem
            // 
            this.priorityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.priorityComboBox});
            this.priorityToolStripMenuItem.Name = "priorityToolStripMenuItem";
            this.priorityToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
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
            this.priorityComboBox.Size = new System.Drawing.Size(121, 28);
            this.priorityComboBox.SelectedIndexChanged += new System.EventHandler(this.priorityComboBox_SelectedIndexChanged);
            // 
            // affinityToolStripMenuItem
            // 
            this.affinityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affinityComboBox});
            this.affinityToolStripMenuItem.Name = "affinityToolStripMenuItem";
            this.affinityToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.affinityToolStripMenuItem.Text = "Affinity";
            // 
            // affinityComboBox
            // 
            this.affinityComboBox.Name = "affinityComboBox";
            this.affinityComboBox.Size = new System.Drawing.Size(121, 28);
            this.affinityComboBox.SelectedIndexChanged += new System.EventHandler(this.affinityComboBox_SelectedIndexChanged);
            // 
            // cboxSteam
            // 
            this.cboxSteam.AutoSize = true;
            this.cboxSteam.Location = new System.Drawing.Point(260, 71);
            this.cboxSteam.Name = "cboxSteam";
            this.cboxSteam.Size = new System.Drawing.Size(135, 20);
            this.cboxSteam.TabIndex = 20;
            this.cboxSteam.Text = "Launch via Steam";
            this.toolTip1.SetToolTip(this.cboxSteam, "This is not required even if you have the Steam version of the games.\nUse only if" +
        " you want to use certain Steam features like Steam Input. Slower by a few second" +
        "s.");
            this.cboxSteam.UseVisualStyleBackColor = true;
            this.cboxSteam.CheckStateChanged += new System.EventHandler(this.cboxSteam_CheckStateChanged);
            // 
            // numericUpDownKillerDelay
            // 
            this.numericUpDownKillerDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKillerDelay.Location = new System.Drawing.Point(117, 49);
            this.numericUpDownKillerDelay.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownKillerDelay.Name = "numericUpDownKillerDelay";
            this.numericUpDownKillerDelay.Size = new System.Drawing.Size(59, 22);
            this.numericUpDownKillerDelay.TabIndex = 21;
            this.numericUpDownKillerDelay.ValueChanged += new System.EventHandler(this.numericUpDownKillerDelay_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 203);
            this.Controls.Add(this.numericUpDownKillerDelay);
            this.Controls.Add(this.cboxSteam);
            this.Controls.Add(this.cboxPriorityAffinity);
            this.Controls.Add(this.btnChangePathSoT);
            this.Controls.Add(this.txtPathSoT);
            this.Controls.Add(this.lblPathSoT);
            this.Controls.Add(this.labelKillerDelay);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.cmbActiveGame);
            this.Controls.Add(this.lblPathT2T);
            this.Controls.Add(this.lblPathWW);
            this.Controls.Add(this.btnChangePathT2T);
            this.Controls.Add(this.txtPathT2T);
            this.Controls.Add(this.btnChangePathWW);
            this.Controls.Add(this.txtPathWW);
            this.Controls.Add(this.labelKillerDelayMs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1061, 358);
            this.MinimumSize = new System.Drawing.Size(460, 250);
            this.Name = "MainForm";
            this.Text = "SandsTrilogyKiller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuPriorityAffinity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKillerDelay)).EndInit();
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
        private System.Windows.Forms.Label labelKillerDelay;
        private System.Windows.Forms.Label labelKillerDelayMs;
        public System.Windows.Forms.CheckBox cboxPriorityAffinity;
        private System.Windows.Forms.ContextMenuStrip contextMenuPriorityAffinity;
        private System.Windows.Forms.ToolStripMenuItem priorityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affinityToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox affinityComboBox;
        private System.Windows.Forms.ToolStripComboBox priorityComboBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cboxSteam;
        private System.Windows.Forms.NumericUpDown numericUpDownKillerDelay;
    }
}


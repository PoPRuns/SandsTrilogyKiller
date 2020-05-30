namespace SandsTrilogyKiller
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathSoT
            // 
            this.txtPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathSoT.Location = new System.Drawing.Point(48, 58);
            this.txtPathSoT.Name = "txtPathSoT";
            this.txtPathSoT.Size = new System.Drawing.Size(540, 20);
            this.txtPathSoT.TabIndex = 2;
            this.txtPathSoT.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // txtPathWW
            // 
            this.txtPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathWW.Location = new System.Drawing.Point(48, 84);
            this.txtPathWW.Name = "txtPathWW";
            this.txtPathWW.Size = new System.Drawing.Size(540, 20);
            this.txtPathWW.TabIndex = 3;
            this.txtPathWW.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathSoT
            // 
            this.btnChangePathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathSoT.Location = new System.Drawing.Point(594, 56);
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
            this.btnChangePathWW.Location = new System.Drawing.Point(594, 82);
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
            this.txtPathT2T.Location = new System.Drawing.Point(48, 110);
            this.txtPathT2T.Name = "txtPathT2T";
            this.txtPathT2T.Size = new System.Drawing.Size(540, 20);
            this.txtPathT2T.TabIndex = 4;
            this.txtPathT2T.TextChanged += new System.EventHandler(this.CurrentGameLauncherPathChanged);
            // 
            // btnChangePathT2T
            // 
            this.btnChangePathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathT2T.Location = new System.Drawing.Point(594, 108);
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
            this.lblPathSoT.Location = new System.Drawing.Point(12, 61);
            this.lblPathSoT.Name = "lblPathSoT";
            this.lblPathSoT.Size = new System.Drawing.Size(30, 13);
            this.lblPathSoT.TabIndex = 9;
            this.lblPathSoT.Text = "SoT:";
            // 
            // lblPathWW
            // 
            this.lblPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathWW.AutoSize = true;
            this.lblPathWW.Location = new System.Drawing.Point(12, 87);
            this.lblPathWW.Name = "lblPathWW";
            this.lblPathWW.Size = new System.Drawing.Size(32, 13);
            this.lblPathWW.TabIndex = 10;
            this.lblPathWW.Text = "WW:";
            // 
            // lblPathT2T
            // 
            this.lblPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathT2T.AutoSize = true;
            this.lblPathT2T.Location = new System.Drawing.Point(12, 113);
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
            this.lblHotkey.Location = new System.Drawing.Point(495, 12);
            this.lblHotkey.Name = "lblHotkey";
            this.lblHotkey.Size = new System.Drawing.Size(56, 17);
            this.lblHotkey.TabIndex = 8;
            this.lblHotkey.Text = "Hotkey:";
            // 
            // txtHotkey
            // 
            this.txtHotkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkey.Location = new System.Drawing.Point(557, 12);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "ready";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 5000;
            this.trackBar1.Location = new System.Drawing.Point(285, 31);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(207, 45);
            this.trackBar1.SmallChange = 1000;
            this.trackBar1.TabIndex = 13;
            this.trackBar1.TickFrequency = 1000;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "1000";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 140);
            this.Controls.Add(this.txtPathSoT);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHotkey);
            this.Controls.Add(this.lblHotkey);
            this.Controls.Add(this.cmbActiveGame);
            this.Controls.Add(this.lblPathT2T);
            this.Controls.Add(this.lblPathWW);
            this.Controls.Add(this.lblPathSoT);
            this.Controls.Add(this.btnChangePathT2T);
            this.Controls.Add(this.txtPathT2T);
            this.Controls.Add(this.btnChangePathWW);
            this.Controls.Add(this.btnChangePathSoT);
            this.Controls.Add(this.txtPathWW);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(18, 168);
            this.Name = "MainForm";
            this.Text = "SandsTrilogyKiller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
    }
}


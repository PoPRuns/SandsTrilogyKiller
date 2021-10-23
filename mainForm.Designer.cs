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
            this.lblHotkeySoT = new System.Windows.Forms.Label();
            this.txtHotkeySoT = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackBarKillerDelay = new System.Windows.Forms.TrackBar();
            this.labelKillerDelay = new System.Windows.Forms.Label();
            this.labelKillerDelayMs = new System.Windows.Forms.Label();
            this.txtHotkeyWW = new System.Windows.Forms.TextBox();
            this.lblHotkeyWW = new System.Windows.Forms.Label();
            this.txtHotkeyT2T = new System.Windows.Forms.TextBox();
            this.lblHotkeyT2T = new System.Windows.Forms.Label();
            this.checkBoxSoT = new System.Windows.Forms.CheckBox();
            this.checkBoxWW = new System.Windows.Forms.CheckBox();
            this.checkBoxT2T = new System.Windows.Forms.CheckBox();
            this.buttonReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKillerDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathSoT
            // 
            this.txtPathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathSoT.Location = new System.Drawing.Point(48, 121);
            this.txtPathSoT.Name = "txtPathSoT";
            this.txtPathSoT.Size = new System.Drawing.Size(249, 20);
            this.txtPathSoT.TabIndex = 2;
            this.txtPathSoT.TextChanged += new System.EventHandler(this.TxtPathSoT_TextChanged);
            // 
            // txtPathWW
            // 
            this.txtPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPathWW.Location = new System.Drawing.Point(48, 147);
            this.txtPathWW.Name = "txtPathWW";
            this.txtPathWW.Size = new System.Drawing.Size(249, 20);
            this.txtPathWW.TabIndex = 3;
            this.txtPathWW.TextChanged += new System.EventHandler(this.TxtPathWW_TextChanged);
            // 
            // btnChangePathSoT
            // 
            this.btnChangePathSoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathSoT.Location = new System.Drawing.Point(303, 119);
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
            this.btnChangePathWW.Location = new System.Drawing.Point(303, 145);
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
            this.txtPathT2T.Location = new System.Drawing.Point(48, 173);
            this.txtPathT2T.Name = "txtPathT2T";
            this.txtPathT2T.Size = new System.Drawing.Size(249, 20);
            this.txtPathT2T.TabIndex = 4;
            this.txtPathT2T.TextChanged += new System.EventHandler(this.TxtPathT2T_TextChanged);
            // 
            // btnChangePathT2T
            // 
            this.btnChangePathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangePathT2T.Location = new System.Drawing.Point(303, 171);
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
            this.lblPathSoT.Location = new System.Drawing.Point(12, 124);
            this.lblPathSoT.Name = "lblPathSoT";
            this.lblPathSoT.Size = new System.Drawing.Size(30, 13);
            this.lblPathSoT.TabIndex = 9;
            this.lblPathSoT.Text = "SoT:";
            // 
            // lblPathWW
            // 
            this.lblPathWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathWW.AutoSize = true;
            this.lblPathWW.Location = new System.Drawing.Point(12, 150);
            this.lblPathWW.Name = "lblPathWW";
            this.lblPathWW.Size = new System.Drawing.Size(32, 13);
            this.lblPathWW.TabIndex = 10;
            this.lblPathWW.Text = "WW:";
            // 
            // lblPathT2T
            // 
            this.lblPathT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPathT2T.AutoSize = true;
            this.lblPathT2T.Location = new System.Drawing.Point(12, 176);
            this.lblPathT2T.Name = "lblPathT2T";
            this.lblPathT2T.Size = new System.Drawing.Size(30, 13);
            this.lblPathT2T.TabIndex = 11;
            this.lblPathT2T.Text = "T2T:";
            // 
            // lblHotkeySoT
            // 
            this.lblHotkeySoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeySoT.AutoSize = true;
            this.lblHotkeySoT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHotkeySoT.Location = new System.Drawing.Point(198, 11);
            this.lblHotkeySoT.Name = "lblHotkeySoT";
            this.lblHotkeySoT.Size = new System.Drawing.Size(38, 17);
            this.lblHotkeySoT.TabIndex = 8;
            this.lblHotkeySoT.Text = "SoT:";
            // 
            // txtHotkeySoT
            // 
            this.txtHotkeySoT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkeySoT.Location = new System.Drawing.Point(266, 11);
            this.txtHotkeySoT.Name = "txtHotkeySoT";
            this.txtHotkeySoT.ReadOnly = true;
            this.txtHotkeySoT.Size = new System.Drawing.Size(67, 20);
            this.txtHotkeySoT.TabIndex = 1;
            this.txtHotkeySoT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHotkeySoT_KeyUp);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PoP Executable|pop.exe;pop2.exe;pop3.exe|All Files (*.*)|*.*";
            // 
            // trackBarKillerDelay
            // 
            this.trackBarKillerDelay.LargeChange = 100;
            this.trackBarKillerDelay.Location = new System.Drawing.Point(12, 92);
            this.trackBarKillerDelay.Maximum = 2000;
            this.trackBarKillerDelay.Name = "trackBarKillerDelay";
            this.trackBarKillerDelay.Size = new System.Drawing.Size(321, 45);
            this.trackBarKillerDelay.SmallChange = 10;
            this.trackBarKillerDelay.TabIndex = 15;
            this.trackBarKillerDelay.TickFrequency = 1000;
            this.trackBarKillerDelay.Scroll += new System.EventHandler(this.TrackBarKillerDelay_Scroll);
            // 
            // labelKillerDelay
            // 
            this.labelKillerDelay.AutoSize = true;
            this.labelKillerDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelay.Location = new System.Drawing.Point(12, 63);
            this.labelKillerDelay.Name = "labelKillerDelay";
            this.labelKillerDelay.Size = new System.Drawing.Size(87, 20);
            this.labelKillerDelay.TabIndex = 17;
            this.labelKillerDelay.Text = "Killer delay:";
            // 
            // labelKillerDelayMs
            // 
            this.labelKillerDelayMs.AutoSize = true;
            this.labelKillerDelayMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKillerDelayMs.Location = new System.Drawing.Point(105, 63);
            this.labelKillerDelayMs.Name = "labelKillerDelayMs";
            this.labelKillerDelayMs.Size = new System.Drawing.Size(50, 24);
            this.labelKillerDelayMs.TabIndex = 18;
            this.labelKillerDelayMs.Text = "0 ms";
            // 
            // txtHotkeyWW
            // 
            this.txtHotkeyWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkeyWW.Location = new System.Drawing.Point(266, 37);
            this.txtHotkeyWW.Name = "txtHotkeyWW";
            this.txtHotkeyWW.ReadOnly = true;
            this.txtHotkeyWW.Size = new System.Drawing.Size(67, 20);
            this.txtHotkeyWW.TabIndex = 19;
            this.txtHotkeyWW.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHotkeyWW_KeyUp);
            // 
            // lblHotkeyWW
            // 
            this.lblHotkeyWW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyWW.AutoSize = true;
            this.lblHotkeyWW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHotkeyWW.Location = new System.Drawing.Point(198, 37);
            this.lblHotkeyWW.Name = "lblHotkeyWW";
            this.lblHotkeyWW.Size = new System.Drawing.Size(38, 17);
            this.lblHotkeyWW.TabIndex = 20;
            this.lblHotkeyWW.Text = "WW:";
            // 
            // txtHotkeyT2T
            // 
            this.txtHotkeyT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHotkeyT2T.Location = new System.Drawing.Point(266, 63);
            this.txtHotkeyT2T.Name = "txtHotkeyT2T";
            this.txtHotkeyT2T.ReadOnly = true;
            this.txtHotkeyT2T.Size = new System.Drawing.Size(67, 20);
            this.txtHotkeyT2T.TabIndex = 21;
            this.txtHotkeyT2T.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtHotkeyT2T_KeyUp);
            // 
            // lblHotkeyT2T
            // 
            this.lblHotkeyT2T.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyT2T.AutoSize = true;
            this.lblHotkeyT2T.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHotkeyT2T.Location = new System.Drawing.Point(198, 63);
            this.lblHotkeyT2T.Name = "lblHotkeyT2T";
            this.lblHotkeyT2T.Size = new System.Drawing.Size(38, 17);
            this.lblHotkeyT2T.TabIndex = 22;
            this.lblHotkeyT2T.Text = "T2T:";
            // 
            // checkBoxSoT
            // 
            this.checkBoxSoT.AutoSize = true;
            this.checkBoxSoT.Location = new System.Drawing.Point(243, 14);
            this.checkBoxSoT.Name = "checkBoxSoT";
            this.checkBoxSoT.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSoT.TabIndex = 23;
            this.checkBoxSoT.UseVisualStyleBackColor = true;
            // 
            // checkBoxWW
            // 
            this.checkBoxWW.AutoSize = true;
            this.checkBoxWW.Location = new System.Drawing.Point(243, 40);
            this.checkBoxWW.Name = "checkBoxWW";
            this.checkBoxWW.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWW.TabIndex = 24;
            this.checkBoxWW.UseVisualStyleBackColor = true;
            // 
            // checkBoxT2T
            // 
            this.checkBoxT2T.AutoSize = true;
            this.checkBoxT2T.Location = new System.Drawing.Point(243, 66);
            this.checkBoxT2T.Name = "checkBoxT2T";
            this.checkBoxT2T.Size = new System.Drawing.Size(15, 14);
            this.checkBoxT2T.TabIndex = 25;
            this.checkBoxT2T.UseVisualStyleBackColor = true;
            // 
            // buttonReady
            // 
            this.buttonReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReady.Location = new System.Drawing.Point(22, 14);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(77, 31);
            this.buttonReady.TabIndex = 26;
            this.buttonReady.Text = "Ready";
            this.buttonReady.UseVisualStyleBackColor = true;
            this.buttonReady.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonReady_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 203);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.checkBoxT2T);
            this.Controls.Add(this.checkBoxWW);
            this.Controls.Add(this.checkBoxSoT);
            this.Controls.Add(this.txtHotkeyT2T);
            this.Controls.Add(this.lblHotkeyT2T);
            this.Controls.Add(this.txtHotkeyWW);
            this.Controls.Add(this.lblHotkeyWW);
            this.Controls.Add(this.btnChangePathSoT);
            this.Controls.Add(this.txtPathSoT);
            this.Controls.Add(this.lblPathSoT);
            this.Controls.Add(this.labelKillerDelay);
            this.Controls.Add(this.txtHotkeySoT);
            this.Controls.Add(this.lblHotkeySoT);
            this.Controls.Add(this.lblPathT2T);
            this.Controls.Add(this.lblPathWW);
            this.Controls.Add(this.btnChangePathT2T);
            this.Controls.Add(this.txtPathT2T);
            this.Controls.Add(this.btnChangePathWW);
            this.Controls.Add(this.txtPathWW);
            this.Controls.Add(this.trackBarKillerDelay);
            this.Controls.Add(this.labelKillerDelayMs);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 242);
            this.MinimumSize = new System.Drawing.Size(361, 242);
            this.Name = "MainForm";
            this.Text = "SandsTrilogyKiller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarKillerDelay)).EndInit();
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
        private System.Windows.Forms.Label lblHotkeySoT;
        private System.Windows.Forms.TextBox txtHotkeySoT;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar trackBarKillerDelay;
        private System.Windows.Forms.Label labelKillerDelay;
        private System.Windows.Forms.Label labelKillerDelayMs;
        private System.Windows.Forms.TextBox txtHotkeyWW;
        private System.Windows.Forms.Label lblHotkeyWW;
        private System.Windows.Forms.TextBox txtHotkeyT2T;
        private System.Windows.Forms.Label lblHotkeyT2T;
        private System.Windows.Forms.CheckBox checkBoxSoT;
        private System.Windows.Forms.CheckBox checkBoxWW;
        private System.Windows.Forms.CheckBox checkBoxT2T;
        private System.Windows.Forms.Button buttonReady;
    }
}


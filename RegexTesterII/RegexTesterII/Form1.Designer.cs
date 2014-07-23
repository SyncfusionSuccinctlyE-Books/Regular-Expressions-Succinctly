namespace RegexTesterII
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
            this.SS = new System.Windows.Forms.StatusStrip();
            this.SLAB = new System.Windows.Forms.ToolStripStatusLabel();
            this.RGPNL = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB = new System.Windows.Forms.CheckedListBox();
            this.TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RunBtn = new System.Windows.Forms.Button();
            this.GPNL = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RTFPNL = new System.Windows.Forms.Panel();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.clearCache = new System.Windows.Forms.CheckBox();
            this.TV = new System.Windows.Forms.TreeView();
            this.SS.SuspendLayout();
            this.RGPNL.SuspendLayout();
            this.GPNL.SuspendLayout();
            this.RTFPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS
            // 
            this.SS.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLAB});
            this.SS.Location = new System.Drawing.Point(0, 497);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(958, 22);
            this.SS.TabIndex = 4;
            // 
            // SLAB
            // 
            this.SLAB.Name = "SLAB";
            this.SLAB.Size = new System.Drawing.Size(0, 17);
            // 
            // RGPNL
            // 
            this.RGPNL.BackColor = System.Drawing.SystemColors.MenuBar;
            this.RGPNL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RGPNL.Controls.Add(this.clearCache);
            this.RGPNL.Controls.Add(this.TimeLabel);
            this.RGPNL.Controls.Add(this.label3);
            this.RGPNL.Controls.Add(this.CB);
            this.RGPNL.Controls.Add(this.TB);
            this.RGPNL.Controls.Add(this.label1);
            this.RGPNL.Controls.Add(this.RunBtn);
            this.RGPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.RGPNL.Location = new System.Drawing.Point(0, 0);
            this.RGPNL.Name = "RGPNL";
            this.RGPNL.Size = new System.Drawing.Size(958, 98);
            this.RGPNL.TabIndex = 5;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(867, 58);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeLabel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(848, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Process Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB
            // 
            this.CB.ColumnWidth = 110;
            this.CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB.FormattingEnabled = true;
            this.CB.Items.AddRange(new object[] {
            "Global",
            "Ignore Case",
            "Multiline",
            "SingleLine",
            "ExplicitCapture",
            "Compiled",
            "IgnorePatternWhitespace",
            "RightToLeft",
            "EMCAScript",
            "CultureInvariant"});
            this.CB.Location = new System.Drawing.Point(521, 11);
            this.CB.MultiColumn = true;
            this.CB.Name = "CB";
            this.CB.Size = new System.Drawing.Size(305, 79);
            this.CB.TabIndex = 3;
            this.CB.ThreeDCheckBoxes = true;
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB.Location = new System.Drawing.Point(113, 11);
            this.TB.Multiline = true;
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(402, 70);
            this.TB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expression:";
            // 
            // RunBtn
            // 
            this.RunBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RunBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RunBtn.Location = new System.Drawing.Point(847, 10);
            this.RunBtn.Name = "RunBtn";
            this.RunBtn.Size = new System.Drawing.Size(104, 28);
            this.RunBtn.TabIndex = 0;
            this.RunBtn.Text = "&Match";
            this.RunBtn.UseVisualStyleBackColor = false;
            this.RunBtn.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // GPNL
            // 
            this.GPNL.BackColor = System.Drawing.SystemColors.Highlight;
            this.GPNL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPNL.Controls.Add(this.TV);
            this.GPNL.Controls.Add(this.label2);
            this.GPNL.Dock = System.Windows.Forms.DockStyle.Right;
            this.GPNL.Location = new System.Drawing.Point(716, 98);
            this.GPNL.Name = "GPNL";
            this.GPNL.Size = new System.Drawing.Size(242, 399);
            this.GPNL.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Groups";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RTFPNL
            // 
            this.RTFPNL.BackColor = System.Drawing.SystemColors.Info;
            this.RTFPNL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RTFPNL.Controls.Add(this.rtb);
            this.RTFPNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTFPNL.Location = new System.Drawing.Point(0, 98);
            this.RTFPNL.Name = "RTFPNL";
            this.RTFPNL.Size = new System.Drawing.Size(716, 399);
            this.RTFPNL.TabIndex = 7;
            // 
            // rtb
            // 
            this.rtb.BackColor = System.Drawing.SystemColors.Info;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb.Location = new System.Drawing.Point(0, 0);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(712, 395);
            this.rtb.TabIndex = 0;
            this.rtb.Text = "";
            // 
            // clearCache
            // 
            this.clearCache.AutoSize = true;
            this.clearCache.Location = new System.Drawing.Point(847, 75);
            this.clearCache.Name = "clearCache";
            this.clearCache.Size = new System.Drawing.Size(83, 17);
            this.clearCache.TabIndex = 6;
            this.clearCache.Text = "Clear cache";
            this.clearCache.UseVisualStyleBackColor = true;
            // 
            // TV
            // 
            this.TV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV.Location = new System.Drawing.Point(0, 24);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(240, 373);
            this.TV.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 519);
            this.Controls.Add(this.RTFPNL);
            this.Controls.Add(this.GPNL);
            this.Controls.Add(this.RGPNL);
            this.Controls.Add(this.SS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "Regular Expression Tester II";
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.RGPNL.ResumeLayout(false);
            this.RGPNL.PerformLayout();
            this.GPNL.ResumeLayout(false);
            this.RTFPNL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStripStatusLabel SLAB;
        private System.Windows.Forms.Panel RGPNL;
        private System.Windows.Forms.Panel GPNL;
        private System.Windows.Forms.Panel RTFPNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RunBtn;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.CheckBox clearCache;
        private System.Windows.Forms.TreeView TV;
    }
}


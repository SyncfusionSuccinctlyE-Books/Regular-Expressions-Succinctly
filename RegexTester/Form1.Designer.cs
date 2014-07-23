namespace RegexTester
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
            this.SC = new System.Windows.Forms.SplitContainer();
            this.PN = new System.Windows.Forms.Panel();
            this.GBCB = new System.Windows.Forms.CheckBox();
            this.SLCB = new System.Windows.Forms.CheckBox();
            this.MLCB = new System.Windows.Forms.CheckBox();
            this.ICCB = new System.Windows.Forms.CheckBox();
            this.BN = new System.Windows.Forms.Button();
            this.TB = new System.Windows.Forms.TextBox();
            this.LB = new System.Windows.Forms.Label();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.SS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC)).BeginInit();
            this.SC.Panel1.SuspendLayout();
            this.SC.Panel2.SuspendLayout();
            this.SC.SuspendLayout();
            this.PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // SS
            // 
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SLAB});
            this.SS.Location = new System.Drawing.Point(0, 457);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(928, 22);
            this.SS.TabIndex = 0;
            // 
            // SLAB
            // 
            this.SLAB.Name = "SLAB";
            this.SLAB.Size = new System.Drawing.Size(0, 17);
            // 
            // SC
            // 
            this.SC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SC.BackColor = System.Drawing.SystemColors.Info;
            this.SC.Location = new System.Drawing.Point(0, 0);
            this.SC.Name = "SC";
            this.SC.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SC.Panel1
            // 
            this.SC.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.SC.Panel1.Controls.Add(this.PN);
            this.SC.Panel1MinSize = 75;
            // 
            // SC.Panel2
            // 
            this.SC.Panel2.Controls.Add(this.rtb);
            this.SC.Size = new System.Drawing.Size(928, 455);
            this.SC.SplitterDistance = 82;
            this.SC.SplitterWidth = 3;
            this.SC.TabIndex = 3;
            // 
            // PN
            // 
            this.PN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN.BackColor = System.Drawing.Color.DarkGray;
            this.PN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PN.Controls.Add(this.GBCB);
            this.PN.Controls.Add(this.SLCB);
            this.PN.Controls.Add(this.MLCB);
            this.PN.Controls.Add(this.ICCB);
            this.PN.Controls.Add(this.BN);
            this.PN.Controls.Add(this.TB);
            this.PN.Controls.Add(this.LB);
            this.PN.Location = new System.Drawing.Point(1, 2);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(925, 70);
            this.PN.TabIndex = 2;
            // 
            // GBCB
            // 
            this.GBCB.AutoSize = true;
            this.GBCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBCB.Location = new System.Drawing.Point(702, 3);
            this.GBCB.Name = "GBCB";
            this.GBCB.Size = new System.Drawing.Size(67, 20);
            this.GBCB.TabIndex = 6;
            this.GBCB.Text = "Global";
            this.GBCB.UseVisualStyleBackColor = true;
            // 
            // SLCB
            // 
            this.SLCB.AutoSize = true;
            this.SLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLCB.Location = new System.Drawing.Point(575, 33);
            this.SLCB.Name = "SLCB";
            this.SLCB.Size = new System.Drawing.Size(93, 20);
            this.SLCB.TabIndex = 5;
            this.SLCB.Text = "Single Line";
            this.SLCB.UseVisualStyleBackColor = true;
            // 
            // MLCB
            // 
            this.MLCB.AutoSize = true;
            this.MLCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLCB.Location = new System.Drawing.Point(702, 33);
            this.MLCB.Name = "MLCB";
            this.MLCB.Size = new System.Drawing.Size(82, 20);
            this.MLCB.TabIndex = 4;
            this.MLCB.Text = "Multi Line";
            this.MLCB.UseVisualStyleBackColor = true;
            // 
            // ICCB
            // 
            this.ICCB.AutoSize = true;
            this.ICCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ICCB.Location = new System.Drawing.Point(575, 3);
            this.ICCB.Name = "ICCB";
            this.ICCB.Size = new System.Drawing.Size(100, 20);
            this.ICCB.TabIndex = 3;
            this.ICCB.Text = "Ignore Case";
            this.ICCB.UseVisualStyleBackColor = true;
            // 
            // BN
            // 
            this.BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BN.Location = new System.Drawing.Point(817, 3);
            this.BN.Name = "BN";
            this.BN.Size = new System.Drawing.Size(96, 33);
            this.BN.TabIndex = 2;
            this.BN.Text = "Match";
            this.BN.UseVisualStyleBackColor = true;
            this.BN.Click += new System.EventHandler(this.BN_Click);
            // 
            // TB
            // 
            this.TB.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB.Location = new System.Drawing.Point(109, 6);
            this.TB.Multiline = true;
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(449, 46);
            this.TB.TabIndex = 1;
            // 
            // LB
            // 
            this.LB.AutoSize = true;
            this.LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB.Location = new System.Drawing.Point(12, 9);
            this.LB.Name = "LB";
            this.LB.Size = new System.Drawing.Size(91, 20);
            this.LB.TabIndex = 0;
            this.LB.Text = "Expression:";
            // 
            // rtb
            // 
            this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb.BackColor = System.Drawing.SystemColors.Info;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb.Location = new System.Drawing.Point(3, 3);
            this.rtb.Name = "rtb";
            this.rtb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtb.Size = new System.Drawing.Size(920, 365);
            this.rtb.TabIndex = 3;
            this.rtb.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 479);
            this.Controls.Add(this.SC);
            this.Controls.Add(this.SS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(925, 300);
            this.Name = "MainForm";
            this.Text = "Regex Tester";
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.SC.Panel1.ResumeLayout(false);
            this.SC.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC)).EndInit();
            this.SC.ResumeLayout(false);
            this.PN.ResumeLayout(false);
            this.PN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.ToolStripStatusLabel SLAB;
        private System.Windows.Forms.SplitContainer SC;
        private System.Windows.Forms.Panel PN;
        private System.Windows.Forms.CheckBox GBCB;
        private System.Windows.Forms.CheckBox SLCB;
        private System.Windows.Forms.CheckBox MLCB;
        private System.Windows.Forms.CheckBox ICCB;
        private System.Windows.Forms.Button BN;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Label LB;
        private System.Windows.Forms.RichTextBox rtb;
    }
}


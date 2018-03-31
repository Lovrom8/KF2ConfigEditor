namespace KF2ConfigEditor
{
    partial class frmEditMapCycles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditMapCycles));
            this.frmSkinEditMapCycles = new FlatUI.FormSkin();
            this.btnOK = new FlatUI.FlatButton();
            this.tbMapCycle = new FlatUI.FlatTextBox();
            this.btnCancel = new FlatUI.FlatButton();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            this.frmSkinEditMapCycles.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmSkinEditMapCycles
            // 
            this.frmSkinEditMapCycles.BackColor = System.Drawing.Color.White;
            this.frmSkinEditMapCycles.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.frmSkinEditMapCycles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.frmSkinEditMapCycles.Controls.Add(this.flatMini1);
            this.frmSkinEditMapCycles.Controls.Add(this.btnOK);
            this.frmSkinEditMapCycles.Controls.Add(this.tbMapCycle);
            this.frmSkinEditMapCycles.Controls.Add(this.btnCancel);
            this.frmSkinEditMapCycles.Controls.Add(this.flatMax1);
            this.frmSkinEditMapCycles.Controls.Add(this.flatClose1);
            this.frmSkinEditMapCycles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSkinEditMapCycles.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.frmSkinEditMapCycles.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.frmSkinEditMapCycles.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.frmSkinEditMapCycles.HeaderMaximize = false;
            this.frmSkinEditMapCycles.Location = new System.Drawing.Point(0, 0);
            this.frmSkinEditMapCycles.Name = "frmSkinEditMapCycles";
            this.frmSkinEditMapCycles.Size = new System.Drawing.Size(541, 137);
            this.frmSkinEditMapCycles.TabIndex = 0;
            this.frmSkinEditMapCycles.Text = "Edit Map Cycles";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOK.Location = new System.Drawing.Point(162, 98);
            this.btnOK.Name = "btnOK";
            this.btnOK.Rounded = false;
            this.btnOK.Size = new System.Drawing.Size(106, 32);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbMapCycle
            // 
            this.tbMapCycle.BackColor = System.Drawing.Color.Transparent;
            this.tbMapCycle.FocusOnHover = false;
            this.tbMapCycle.Location = new System.Drawing.Point(12, 59);
            this.tbMapCycle.MaxLength = 32767;
            this.tbMapCycle.Multiline = false;
            this.tbMapCycle.Name = "tbMapCycle";
            this.tbMapCycle.ReadOnly = false;
            this.tbMapCycle.Size = new System.Drawing.Size(517, 29);
            this.tbMapCycle.TabIndex = 4;
            this.tbMapCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbMapCycle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbMapCycle.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(294, 98);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Rounded = false;
            this.btnCancel.Size = new System.Drawing.Size(106, 32);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(487, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 1;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(511, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(463, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 6;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // frmEditMapCycles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 137);
            this.Controls.Add(this.frmSkinEditMapCycles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditMapCycles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditMapCycles";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.frmSkinEditMapCycles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin frmSkinEditMapCycles;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton btnOK;
        private FlatUI.FlatTextBox tbMapCycle;
        private FlatUI.FlatButton btnCancel;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatMini flatMini1;
    }
}
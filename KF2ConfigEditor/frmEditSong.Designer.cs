namespace KF2ConfigEditor
{
    partial class frmEditSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditSong));
            this.formSkin1 = new FlatUI.FormSkin();
            this.frmSkinEditSong = new FlatUI.FormSkin();
            this.btnEditSongCancel = new FlatUI.FlatButton();
            this.btnEditSongOK = new FlatUI.FlatButton();
            this.comboMapType = new FlatUI.FlatComboBox();
            this.tbWorkshopKey = new FlatUI.FlatTextBox();
            this.tbSongName = new FlatUI.FlatTextBox();
            this.lblMapType = new FlatUI.FlatLabel();
            this.lblWorkshopNumber = new FlatUI.FlatLabel();
            this.lblMapName = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatMini1 = new FlatUI.FlatMini();
            this.formSkin1.SuspendLayout();
            this.frmSkinEditSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.frmSkinEditSong);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(283, 233);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "formSkin1";
            // 
            // frmSkinEditSong
            // 
            this.frmSkinEditSong.BackColor = System.Drawing.Color.White;
            this.frmSkinEditSong.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.frmSkinEditSong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.frmSkinEditSong.Controls.Add(this.flatMini1);
            this.frmSkinEditSong.Controls.Add(this.flatMax1);
            this.frmSkinEditSong.Controls.Add(this.flatClose1);
            this.frmSkinEditSong.Controls.Add(this.btnEditSongCancel);
            this.frmSkinEditSong.Controls.Add(this.btnEditSongOK);
            this.frmSkinEditSong.Controls.Add(this.comboMapType);
            this.frmSkinEditSong.Controls.Add(this.tbWorkshopKey);
            this.frmSkinEditSong.Controls.Add(this.tbSongName);
            this.frmSkinEditSong.Controls.Add(this.lblMapType);
            this.frmSkinEditSong.Controls.Add(this.lblWorkshopNumber);
            this.frmSkinEditSong.Controls.Add(this.lblMapName);
            this.frmSkinEditSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSkinEditSong.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.frmSkinEditSong.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.frmSkinEditSong.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.frmSkinEditSong.HeaderMaximize = false;
            this.frmSkinEditSong.Location = new System.Drawing.Point(0, 0);
            this.frmSkinEditSong.Name = "frmSkinEditSong";
            this.frmSkinEditSong.Size = new System.Drawing.Size(283, 233);
            this.frmSkinEditSong.TabIndex = 2;
            this.frmSkinEditSong.Text = "Edit Song";
            // 
            // btnEditSongCancel
            // 
            this.btnEditSongCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSongCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEditSongCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSongCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditSongCancel.Location = new System.Drawing.Point(148, 173);
            this.btnEditSongCancel.Name = "btnEditSongCancel";
            this.btnEditSongCancel.Rounded = false;
            this.btnEditSongCancel.Size = new System.Drawing.Size(106, 32);
            this.btnEditSongCancel.TabIndex = 7;
            this.btnEditSongCancel.Text = "Cancel";
            this.btnEditSongCancel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnEditSongCancel.Click += new System.EventHandler(this.btnEditSongCancel_Click);
            // 
            // btnEditSongOK
            // 
            this.btnEditSongOK.BackColor = System.Drawing.Color.Transparent;
            this.btnEditSongOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnEditSongOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSongOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEditSongOK.Location = new System.Drawing.Point(26, 173);
            this.btnEditSongOK.Name = "btnEditSongOK";
            this.btnEditSongOK.Rounded = false;
            this.btnEditSongOK.Size = new System.Drawing.Size(106, 32);
            this.btnEditSongOK.TabIndex = 6;
            this.btnEditSongOK.Text = "OK";
            this.btnEditSongOK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnEditSongOK.Click += new System.EventHandler(this.btnEditSongOK_Click);
            // 
            // comboMapType
            // 
            this.comboMapType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboMapType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMapType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMapType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMapType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboMapType.ForeColor = System.Drawing.Color.White;
            this.comboMapType.FormattingEnabled = true;
            this.comboMapType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboMapType.ItemHeight = 18;
            this.comboMapType.Items.AddRange(new object[] {
            "KF1 Maps",
            "Custom Maps"});
            this.comboMapType.Location = new System.Drawing.Point(75, 131);
            this.comboMapType.Name = "comboMapType";
            this.comboMapType.Size = new System.Drawing.Size(161, 24);
            this.comboMapType.TabIndex = 5;
            // 
            // tbWorkshopKey
            // 
            this.tbWorkshopKey.BackColor = System.Drawing.Color.Transparent;
            this.tbWorkshopKey.FocusOnHover = false;
            this.tbWorkshopKey.Location = new System.Drawing.Point(75, 96);
            this.tbWorkshopKey.MaxLength = 32767;
            this.tbWorkshopKey.Multiline = false;
            this.tbWorkshopKey.Name = "tbWorkshopKey";
            this.tbWorkshopKey.ReadOnly = false;
            this.tbWorkshopKey.Size = new System.Drawing.Size(161, 29);
            this.tbWorkshopKey.TabIndex = 4;
            this.tbWorkshopKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWorkshopKey.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbWorkshopKey.UseSystemPasswordChar = false;
            // 
            // tbSongName
            // 
            this.tbSongName.BackColor = System.Drawing.Color.Transparent;
            this.tbSongName.FocusOnHover = false;
            this.tbSongName.Location = new System.Drawing.Point(75, 61);
            this.tbSongName.MaxLength = 32767;
            this.tbSongName.Multiline = false;
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.ReadOnly = false;
            this.tbSongName.Size = new System.Drawing.Size(161, 29);
            this.tbSongName.TabIndex = 3;
            this.tbSongName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSongName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbSongName.UseSystemPasswordChar = false;
            // 
            // lblMapType
            // 
            this.lblMapType.AutoSize = true;
            this.lblMapType.BackColor = System.Drawing.Color.Transparent;
            this.lblMapType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMapType.ForeColor = System.Drawing.Color.White;
            this.lblMapType.Location = new System.Drawing.Point(12, 131);
            this.lblMapType.Name = "lblMapType";
            this.lblMapType.Size = new System.Drawing.Size(30, 13);
            this.lblMapType.TabIndex = 2;
            this.lblMapType.Text = "Type";
            // 
            // lblWorkshopNumber
            // 
            this.lblWorkshopNumber.AutoSize = true;
            this.lblWorkshopNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblWorkshopNumber.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWorkshopNumber.ForeColor = System.Drawing.Color.White;
            this.lblWorkshopNumber.Location = new System.Drawing.Point(12, 96);
            this.lblWorkshopNumber.Name = "lblWorkshopNumber";
            this.lblWorkshopNumber.Size = new System.Drawing.Size(24, 13);
            this.lblWorkshopNumber.TabIndex = 1;
            this.lblWorkshopNumber.Text = "WS";
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.BackColor = System.Drawing.Color.Transparent;
            this.lblMapName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMapName.ForeColor = System.Drawing.Color.White;
            this.lblMapName.Location = new System.Drawing.Point(12, 61);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(36, 13);
            this.lblMapName.TabIndex = 0;
            this.lblMapName.Text = "Name";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(12, 86);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(57, 13);
            this.flatLabel2.TabIndex = 1;
            this.flatLabel2.Text = "flatLabel2";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(12, 61);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(57, 13);
            this.flatLabel1.TabIndex = 0;
            this.flatLabel1.Text = "flatLabel1";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(253, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 8;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(229, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 9;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(205, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 10;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // frmEditSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 233);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Song";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.frmSkinEditSong.ResumeLayout(false);
            this.frmSkinEditSong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FormSkin frmSkinEditSong;
        private FlatUI.FlatTextBox tbWorkshopKey;
        private FlatUI.FlatTextBox tbSongName;
        private FlatUI.FlatLabel lblMapType;
        private FlatUI.FlatLabel lblWorkshopNumber;
        private FlatUI.FlatLabel lblMapName;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton btnEditSongCancel;
        private FlatUI.FlatButton btnEditSongOK;
        private FlatUI.FlatComboBox comboMapType;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatClose flatClose1;
    }
}
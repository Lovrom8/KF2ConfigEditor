namespace KF2ConfigEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.formSkinMain = new FlatUI.FormSkin();
            this.btnEditSong = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditMapCycles = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flatGroupBox2 = new FlatUI.FlatGroupBox();
            this.comboMapType = new FlatUI.FlatComboBox();
            this.tbWorkshopNumber = new FlatUI.FlatTextBox();
            this.lblWS = new FlatUI.FlatLabel();
            this.tbName = new FlatUI.FlatTextBox();
            this.lblName = new FlatUI.FlatLabel();
            this.btnAdd = new MaterialSkin.Controls.MaterialRaisedButton();
            this.flatBoxDediSettings = new FlatUI.FlatGroupBox();
            this.lblGameType = new FlatUI.FlatLabel();
            this.comboGameType = new FlatUI.FlatComboBox();
            this.lblDifficulty = new FlatUI.FlatLabel();
            this.comboDifficulty = new FlatUI.FlatComboBox();
            this.comboLength = new FlatUI.FlatComboBox();
            this.lblLength = new FlatUI.FlatLabel();
            this.lblMaps = new FlatUI.FlatLabel();
            this.comboAllMaps = new FlatUI.FlatComboBox();
            this.flatMax1 = new FlatUI.FlatMax();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.statusBar = new FlatUI.FlatStatusBar();
            this.comboMapList = new FlatUI.FlatComboBox();
            this.btnRemove = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnStartDedi = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenGame = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnOpenEngine = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnBackup = new MaterialSkin.Controls.MaterialRaisedButton();
            this.formSkinMain.SuspendLayout();
            this.flatGroupBox2.SuspendLayout();
            this.flatBoxDediSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkinMain
            // 
            this.formSkinMain.BackColor = System.Drawing.Color.White;
            this.formSkinMain.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkinMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkinMain.Controls.Add(this.btnEditSong);
            this.formSkinMain.Controls.Add(this.btnEditMapCycles);
            this.formSkinMain.Controls.Add(this.flatGroupBox2);
            this.formSkinMain.Controls.Add(this.flatBoxDediSettings);
            this.formSkinMain.Controls.Add(this.flatMax1);
            this.formSkinMain.Controls.Add(this.flatMini1);
            this.formSkinMain.Controls.Add(this.flatClose1);
            this.formSkinMain.Controls.Add(this.statusBar);
            this.formSkinMain.Controls.Add(this.comboMapList);
            this.formSkinMain.Controls.Add(this.btnRemove);
            this.formSkinMain.Controls.Add(this.btnStartDedi);
            this.formSkinMain.Controls.Add(this.btnOpenGame);
            this.formSkinMain.Controls.Add(this.btnOpenEngine);
            this.formSkinMain.Controls.Add(this.btnBackup);
            this.formSkinMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkinMain.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkinMain.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkinMain.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkinMain.HeaderMaximize = false;
            this.formSkinMain.Location = new System.Drawing.Point(0, 0);
            this.formSkinMain.Name = "formSkinMain";
            this.formSkinMain.Size = new System.Drawing.Size(380, 602);
            this.formSkinMain.TabIndex = 1;
            this.formSkinMain.Text = "KF2 Config Editor";
            // 
            // btnEditSong
            // 
            this.btnEditSong.Depth = 0;
            this.btnEditSong.Location = new System.Drawing.Point(34, 424);
            this.btnEditSong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Primary = true;
            this.btnEditSong.Size = new System.Drawing.Size(148, 23);
            this.btnEditSong.TabIndex = 46;
            this.btnEditSong.Text = "Edit selected song";
            this.btnEditSong.UseVisualStyleBackColor = true;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // btnEditMapCycles
            // 
            this.btnEditMapCycles.Depth = 0;
            this.btnEditMapCycles.Location = new System.Drawing.Point(199, 424);
            this.btnEditMapCycles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditMapCycles.Name = "btnEditMapCycles";
            this.btnEditMapCycles.Primary = true;
            this.btnEditMapCycles.Size = new System.Drawing.Size(148, 23);
            this.btnEditMapCycles.TabIndex = 45;
            this.btnEditMapCycles.Text = "Edit map cycles";
            this.btnEditMapCycles.UseVisualStyleBackColor = true;
            this.btnEditMapCycles.Click += new System.EventHandler(this.btnEditMapCycles_Click);
            // 
            // flatGroupBox2
            // 
            this.flatGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.flatGroupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatGroupBox2.Controls.Add(this.comboMapType);
            this.flatGroupBox2.Controls.Add(this.tbWorkshopNumber);
            this.flatGroupBox2.Controls.Add(this.lblWS);
            this.flatGroupBox2.Controls.Add(this.tbName);
            this.flatGroupBox2.Controls.Add(this.lblName);
            this.flatGroupBox2.Controls.Add(this.btnAdd);
            this.flatGroupBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatGroupBox2.Location = new System.Drawing.Point(20, 245);
            this.flatGroupBox2.Name = "flatGroupBox2";
            this.flatGroupBox2.ShowText = true;
            this.flatGroupBox2.Size = new System.Drawing.Size(338, 173);
            this.flatGroupBox2.TabIndex = 44;
            this.flatGroupBox2.Text = "Add new map";
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
            this.comboMapType.Location = new System.Drawing.Point(73, 108);
            this.comboMapType.Name = "comboMapType";
            this.comboMapType.Size = new System.Drawing.Size(229, 24);
            this.comboMapType.TabIndex = 44;
            // 
            // tbWorkshopNumber
            // 
            this.tbWorkshopNumber.BackColor = System.Drawing.Color.Transparent;
            this.tbWorkshopNumber.FocusOnHover = false;
            this.tbWorkshopNumber.Location = new System.Drawing.Point(73, 73);
            this.tbWorkshopNumber.MaxLength = 32767;
            this.tbWorkshopNumber.Multiline = false;
            this.tbWorkshopNumber.Name = "tbWorkshopNumber";
            this.tbWorkshopNumber.ReadOnly = false;
            this.tbWorkshopNumber.Size = new System.Drawing.Size(229, 29);
            this.tbWorkshopNumber.TabIndex = 47;
            this.tbWorkshopNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbWorkshopNumber.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbWorkshopNumber.UseSystemPasswordChar = false;
            // 
            // lblWS
            // 
            this.lblWS.AutoSize = true;
            this.lblWS.BackColor = System.Drawing.Color.Transparent;
            this.lblWS.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWS.ForeColor = System.Drawing.Color.White;
            this.lblWS.Location = new System.Drawing.Point(15, 73);
            this.lblWS.Name = "lblWS";
            this.lblWS.Size = new System.Drawing.Size(24, 13);
            this.lblWS.TabIndex = 46;
            this.lblWS.Text = "WS";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.FocusOnHover = false;
            this.tbName.Location = new System.Drawing.Point(73, 38);
            this.tbName.MaxLength = 32767;
            this.tbName.Multiline = false;
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = false;
            this.tbName.Size = new System.Drawing.Size(229, 29);
            this.tbName.TabIndex = 45;
            this.tbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbName.UseSystemPasswordChar = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(15, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdd.Depth = 0;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(129, 138);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Primary = true;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // flatBoxDediSettings
            // 
            this.flatBoxDediSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.flatBoxDediSettings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatBoxDediSettings.Controls.Add(this.lblGameType);
            this.flatBoxDediSettings.Controls.Add(this.comboGameType);
            this.flatBoxDediSettings.Controls.Add(this.lblDifficulty);
            this.flatBoxDediSettings.Controls.Add(this.comboDifficulty);
            this.flatBoxDediSettings.Controls.Add(this.comboLength);
            this.flatBoxDediSettings.Controls.Add(this.lblLength);
            this.flatBoxDediSettings.Controls.Add(this.lblMaps);
            this.flatBoxDediSettings.Controls.Add(this.comboAllMaps);
            this.flatBoxDediSettings.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flatBoxDediSettings.Location = new System.Drawing.Point(20, 87);
            this.flatBoxDediSettings.Name = "flatBoxDediSettings";
            this.flatBoxDediSettings.ShowText = true;
            this.flatBoxDediSettings.Size = new System.Drawing.Size(338, 152);
            this.flatBoxDediSettings.TabIndex = 43;
            this.flatBoxDediSettings.Text = "Dedi server settings";
            // 
            // lblGameType
            // 
            this.lblGameType.AutoSize = true;
            this.lblGameType.BackColor = System.Drawing.Color.Transparent;
            this.lblGameType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGameType.ForeColor = System.Drawing.Color.White;
            this.lblGameType.Location = new System.Drawing.Point(219, 82);
            this.lblGameType.Name = "lblGameType";
            this.lblGameType.Size = new System.Drawing.Size(61, 13);
            this.lblGameType.TabIndex = 52;
            this.lblGameType.Text = "Game type";
            // 
            // comboGameType
            // 
            this.comboGameType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboGameType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboGameType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboGameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGameType.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboGameType.ForeColor = System.Drawing.Color.White;
            this.comboGameType.FormattingEnabled = true;
            this.comboGameType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboGameType.ItemHeight = 18;
            this.comboGameType.Items.AddRange(new object[] {
            "Endless",
            "Survival",
            "VersusSurvival",
            "Weekly"});
            this.comboGameType.Location = new System.Drawing.Point(192, 98);
            this.comboGameType.Name = "comboGameType";
            this.comboGameType.Size = new System.Drawing.Size(120, 24);
            this.comboGameType.TabIndex = 51;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.Color.Transparent;
            this.lblDifficulty.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDifficulty.ForeColor = System.Drawing.Color.White;
            this.lblDifficulty.Location = new System.Drawing.Point(63, 82);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(53, 13);
            this.lblDifficulty.TabIndex = 50;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // comboDifficulty
            // 
            this.comboDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboDifficulty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDifficulty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDifficulty.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboDifficulty.ForeColor = System.Drawing.Color.White;
            this.comboDifficulty.FormattingEnabled = true;
            this.comboDifficulty.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboDifficulty.ItemHeight = 18;
            this.comboDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Hard",
            "Suicidal",
            "Hell on earth"});
            this.comboDifficulty.Location = new System.Drawing.Point(18, 98);
            this.comboDifficulty.Name = "comboDifficulty";
            this.comboDifficulty.Size = new System.Drawing.Size(144, 24);
            this.comboDifficulty.TabIndex = 49;
            // 
            // comboLength
            // 
            this.comboLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboLength.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboLength.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLength.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboLength.ForeColor = System.Drawing.Color.White;
            this.comboLength.FormattingEnabled = true;
            this.comboLength.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboLength.ItemHeight = 18;
            this.comboLength.Items.AddRange(new object[] {
            "Short",
            "Normal",
            "Long"});
            this.comboLength.Location = new System.Drawing.Point(192, 54);
            this.comboLength.Name = "comboLength";
            this.comboLength.Size = new System.Drawing.Size(120, 24);
            this.comboLength.TabIndex = 48;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.BackColor = System.Drawing.Color.Transparent;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLength.ForeColor = System.Drawing.Color.White;
            this.lblLength.Location = new System.Drawing.Point(227, 38);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 47;
            this.lblLength.Text = "Length";
            // 
            // lblMaps
            // 
            this.lblMaps.AutoSize = true;
            this.lblMaps.BackColor = System.Drawing.Color.Transparent;
            this.lblMaps.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaps.ForeColor = System.Drawing.Color.White;
            this.lblMaps.Location = new System.Drawing.Point(70, 38);
            this.lblMaps.Name = "lblMaps";
            this.lblMaps.Size = new System.Drawing.Size(35, 13);
            this.lblMaps.TabIndex = 43;
            this.lblMaps.Text = "Maps";
            // 
            // comboAllMaps
            // 
            this.comboAllMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboAllMaps.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboAllMaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboAllMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAllMaps.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboAllMaps.ForeColor = System.Drawing.Color.White;
            this.comboAllMaps.FormattingEnabled = true;
            this.comboAllMaps.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboAllMaps.ItemHeight = 18;
            this.comboAllMaps.Location = new System.Drawing.Point(18, 54);
            this.comboAllMaps.Name = "comboAllMaps";
            this.comboAllMaps.Size = new System.Drawing.Size(144, 24);
            this.comboAllMaps.TabIndex = 42;
            // 
            // flatMax1
            // 
            this.flatMax1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMax1.BackColor = System.Drawing.Color.White;
            this.flatMax1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMax1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMax1.Location = new System.Drawing.Point(326, 12);
            this.flatMax1.Name = "flatMax1";
            this.flatMax1.Size = new System.Drawing.Size(18, 18);
            this.flatMax1.TabIndex = 42;
            this.flatMax1.Text = "flatMax1";
            this.flatMax1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(302, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 41;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(350, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 40;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.flatClose1.Click += new System.EventHandler(this.flatClose1_Click);
            // 
            // statusBar
            // 
            this.statusBar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.statusBar.ForeColor = System.Drawing.Color.White;
            this.statusBar.Location = new System.Drawing.Point(0, 579);
            this.statusBar.Name = "statusBar";
            this.statusBar.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.statusBar.ShowTimeDate = false;
            this.statusBar.Size = new System.Drawing.Size(380, 23);
            this.statusBar.TabIndex = 37;
            this.statusBar.TextColor = System.Drawing.Color.White;
            // 
            // comboMapList
            // 
            this.comboMapList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.comboMapList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboMapList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboMapList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMapList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.comboMapList.ForeColor = System.Drawing.Color.White;
            this.comboMapList.FormattingEnabled = true;
            this.comboMapList.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.comboMapList.ItemHeight = 18;
            this.comboMapList.Location = new System.Drawing.Point(23, 516);
            this.comboMapList.Name = "comboMapList";
            this.comboMapList.Size = new System.Drawing.Size(335, 24);
            this.comboMapList.TabIndex = 36;
            // 
            // btnRemove
            // 
            this.btnRemove.Depth = 0;
            this.btnRemove.Location = new System.Drawing.Point(149, 550);
            this.btnRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Primary = true;
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnStartDedi
            // 
            this.btnStartDedi.Depth = 0;
            this.btnStartDedi.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStartDedi.Location = new System.Drawing.Point(116, 58);
            this.btnStartDedi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartDedi.Name = "btnStartDedi";
            this.btnStartDedi.Primary = true;
            this.btnStartDedi.Size = new System.Drawing.Size(137, 23);
            this.btnStartDedi.TabIndex = 33;
            this.btnStartDedi.Text = "Start KF2 dedi";
            this.btnStartDedi.UseVisualStyleBackColor = true;
            this.btnStartDedi.Click += new System.EventHandler(this.btnStartDedi_Click);
            // 
            // btnOpenGame
            // 
            this.btnOpenGame.Depth = 0;
            this.btnOpenGame.Location = new System.Drawing.Point(199, 453);
            this.btnOpenGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenGame.Name = "btnOpenGame";
            this.btnOpenGame.Primary = true;
            this.btnOpenGame.Size = new System.Drawing.Size(148, 23);
            this.btnOpenGame.TabIndex = 29;
            this.btnOpenGame.Text = "Open game.ini";
            this.btnOpenGame.UseVisualStyleBackColor = true;
            this.btnOpenGame.Click += new System.EventHandler(this.btnOpenGame_Click);
            // 
            // btnOpenEngine
            // 
            this.btnOpenEngine.Depth = 0;
            this.btnOpenEngine.Location = new System.Drawing.Point(34, 453);
            this.btnOpenEngine.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpenEngine.Name = "btnOpenEngine";
            this.btnOpenEngine.Primary = true;
            this.btnOpenEngine.Size = new System.Drawing.Size(148, 23);
            this.btnOpenEngine.TabIndex = 28;
            this.btnOpenEngine.Text = "Open engine.ini";
            this.btnOpenEngine.UseVisualStyleBackColor = true;
            this.btnOpenEngine.Click += new System.EventHandler(this.btnOpenEngine_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Depth = 0;
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBackup.Location = new System.Drawing.Point(116, 487);
            this.btnBackup.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Primary = true;
            this.btnBackup.Size = new System.Drawing.Size(137, 23);
            this.btnBackup.TabIndex = 25;
            this.btnBackup.Text = "Backup settings";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 602);
            this.Controls.Add(this.formSkinMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KF2 Config Editor";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.formSkinMain.ResumeLayout(false);
            this.flatGroupBox2.ResumeLayout(false);
            this.flatGroupBox2.PerformLayout();
            this.flatBoxDediSettings.ResumeLayout(false);
            this.flatBoxDediSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkinMain;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenGame;
        private MaterialSkin.Controls.MaterialRaisedButton btnOpenEngine;
        private MaterialSkin.Controls.MaterialRaisedButton btnBackup;
        private MaterialSkin.Controls.MaterialRaisedButton btnAdd;
        private FlatUI.FlatComboBox comboMapList;
        private MaterialSkin.Controls.MaterialRaisedButton btnRemove;
        private MaterialSkin.Controls.MaterialRaisedButton btnStartDedi;
        private FlatUI.FlatStatusBar statusBar;
        private FlatUI.FlatGroupBox flatGroupBox2;
        private FlatUI.FlatLabel lblName;
        private FlatUI.FlatLabel lblMaps;
        private FlatUI.FlatComboBox comboAllMaps;
        private FlatUI.FlatMax flatMax1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatTextBox tbWorkshopNumber;
        private FlatUI.FlatLabel lblWS;
        private FlatUI.FlatTextBox tbName;
        private FlatUI.FlatComboBox comboMapType;
        private FlatUI.FlatGroupBox flatBoxDediSettings;
        private FlatUI.FlatLabel lblDifficulty;
        private FlatUI.FlatComboBox comboDifficulty;
        private FlatUI.FlatComboBox comboLength;
        private FlatUI.FlatLabel lblLength;
        private FlatUI.FlatLabel lblGameType;
        private FlatUI.FlatComboBox comboGameType;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditSong;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditMapCycles;

    }
}


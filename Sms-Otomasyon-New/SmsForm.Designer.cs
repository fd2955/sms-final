namespace Sms_Otomasyon_New
{
    partial class bos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bos));
            this.tabPlanlananlar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnMesajSil = new System.Windows.Forms.Button();
            this.btnMesajEkle = new System.Windows.Forms.Button();
            this.txtYeniMesaj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHazirMesajlar = new System.Windows.Forms.ListBox();
            this.chkSchedule = new System.Windows.Forms.CheckBox();
            this.dtScheduledTime = new System.Windows.Forms.DateTimePicker();
            this.labelCharCount = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstGecmisSonuc = new System.Windows.Forms.TextBox();
            this.btnGecmisFiltrele = new System.Windows.Forms.Button();
            this.dtGecmisBitis = new System.Windows.Forms.DateTimePicker();
            this.dtGecmisBaslangic = new System.Windows.Forms.DateTimePicker();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.btnSaveContacts = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDeleteContact = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerScheduled = new System.Windows.Forms.Timer(this.components);
            this.dgvPlanlananlar = new System.Windows.Forms.DataGridView();
            this.btnPlanSil = new System.Windows.Forms.Button();
            this.tabYardim = new System.Windows.Forms.TabPage();
            this.lblYardim = new System.Windows.Forms.Label();
            this.txtYardim = new System.Windows.Forms.RichTextBox();
            this.lblGeri = new System.Windows.Forms.Label();
            this.txtGeriBildirim = new System.Windows.Forms.TextBox();
            this.btnGeriBildir = new System.Windows.Forms.Button();
            this.lstGeriBildiriler = new System.Windows.Forms.ListBox();
            this.lblGeriBildirimBaslik = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.tabPlanlananlar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanlananlar)).BeginInit();
            this.tabYardim.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPlanlananlar
            // 
            this.tabPlanlananlar.Controls.Add(this.tabPage1);
            this.tabPlanlananlar.Controls.Add(this.tabPage2);
            this.tabPlanlananlar.Controls.Add(this.tabContacts);
            this.tabPlanlananlar.Controls.Add(this.tabPage3);
            this.tabPlanlananlar.Controls.Add(this.tabYardim);
            this.tabPlanlananlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPlanlananlar.Location = new System.Drawing.Point(0, 0);
            this.tabPlanlananlar.Name = "tabPlanlananlar";
            this.tabPlanlananlar.SelectedIndex = 0;
            this.tabPlanlananlar.Size = new System.Drawing.Size(1230, 470);
            this.tabPlanlananlar.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnMesajSil);
            this.tabPage1.Controls.Add(this.btnMesajEkle);
            this.tabPage1.Controls.Add(this.txtYeniMesaj);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lstHazirMesajlar);
            this.tabPage1.Controls.Add(this.chkSchedule);
            this.tabPage1.Controls.Add(this.dtScheduledTime);
            this.tabPage1.Controls.Add(this.labelCharCount);
            this.tabPage1.Controls.Add(this.btnSend);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "SMS Gönder";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnMesajSil
            // 
            this.btnMesajSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajSil.Location = new System.Drawing.Point(345, 229);
            this.btnMesajSil.Name = "btnMesajSil";
            this.btnMesajSil.Size = new System.Drawing.Size(114, 50);
            this.btnMesajSil.TabIndex = 24;
            this.btnMesajSil.Text = "Hazır Mesajı Sil";
            this.btnMesajSil.UseVisualStyleBackColor = true;
            this.btnMesajSil.Click += new System.EventHandler(this.btnMesajSil_Click);
            // 
            // btnMesajEkle
            // 
            this.btnMesajEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMesajEkle.Location = new System.Drawing.Point(195, 229);
            this.btnMesajEkle.Name = "btnMesajEkle";
            this.btnMesajEkle.Size = new System.Drawing.Size(111, 50);
            this.btnMesajEkle.TabIndex = 23;
            this.btnMesajEkle.Text = "Hazır Mesaj Ekle";
            this.btnMesajEkle.UseVisualStyleBackColor = true;
            this.btnMesajEkle.Click += new System.EventHandler(this.btnMesajEkle_Click);
            // 
            // txtYeniMesaj
            // 
            this.txtYeniMesaj.Location = new System.Drawing.Point(195, 164);
            this.txtYeniMesaj.Multiline = true;
            this.txtYeniMesaj.Name = "txtYeniMesaj";
            this.txtYeniMesaj.Size = new System.Drawing.Size(264, 50);
            this.txtYeniMesaj.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hazır Mesajlar";
            // 
            // lstHazirMesajlar
            // 
            this.lstHazirMesajlar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstHazirMesajlar.FormattingEnabled = true;
            this.lstHazirMesajlar.ItemHeight = 24;
            this.lstHazirMesajlar.Location = new System.Drawing.Point(195, 95);
            this.lstHazirMesajlar.Name = "lstHazirMesajlar";
            this.lstHazirMesajlar.Size = new System.Drawing.Size(264, 52);
            this.lstHazirMesajlar.TabIndex = 20;
            this.lstHazirMesajlar.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstHazirMesajlar_DrawItem);
            this.lstHazirMesajlar.SelectedIndexChanged += new System.EventHandler(this.lstHazirMesajlar_SelectedIndexChanged);
            // 
            // chkSchedule
            // 
            this.chkSchedule.AutoSize = true;
            this.chkSchedule.Location = new System.Drawing.Point(195, 336);
            this.chkSchedule.Name = "chkSchedule";
            this.chkSchedule.Size = new System.Drawing.Size(130, 20);
            this.chkSchedule.TabIndex = 19;
            this.chkSchedule.Text = "Zamanla Gönder";
            this.chkSchedule.UseVisualStyleBackColor = true;
            this.chkSchedule.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dtScheduledTime
            // 
            this.dtScheduledTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtScheduledTime.Location = new System.Drawing.Point(195, 294);
            this.dtScheduledTime.Name = "dtScheduledTime";
            this.dtScheduledTime.ShowCheckBox = true;
            this.dtScheduledTime.ShowUpDown = true;
            this.dtScheduledTime.Size = new System.Drawing.Size(164, 22);
            this.dtScheduledTime.TabIndex = 17;
            // 
            // labelCharCount
            // 
            this.labelCharCount.AutoSize = true;
            this.labelCharCount.ForeColor = System.Drawing.Color.Silver;
            this.labelCharCount.Location = new System.Drawing.Point(52, 336);
            this.labelCharCount.Name = "labelCharCount";
            this.labelCharCount.Size = new System.Drawing.Size(101, 16);
            this.labelCharCount.TabIndex = 16;
            this.labelCharCount.Text = "Karakter: 0 / 300";
            this.labelCharCount.Click += new System.EventHandler(this.labelCharCount_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(43, 277);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 39);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "SMS Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(34, 91);
            this.txtMessage.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtMessage.MaxLength = 1000;
            this.txtMessage.MinimumSize = new System.Drawing.Size(100, 30);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(141, 164);
            this.txtMessage.TabIndex = 14;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mesaj:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(195, 36);
            this.txtPhone.MaximumSize = new System.Drawing.Size(200, 25);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 22);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefon Numarası:  +90";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelStart);
            this.tabPage2.Controls.Add(this.lstGecmisSonuc);
            this.tabPage2.Controls.Add(this.btnGecmisFiltrele);
            this.tabPage2.Controls.Add(this.dtGecmisBitis);
            this.tabPage2.Controls.Add(this.dtGecmisBaslangic);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 441);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Geçmiş Mesajlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstGecmisSonuc
            // 
            this.lstGecmisSonuc.Location = new System.Drawing.Point(31, 101);
            this.lstGecmisSonuc.MinimumSize = new System.Drawing.Size(450, 200);
            this.lstGecmisSonuc.Multiline = true;
            this.lstGecmisSonuc.Name = "lstGecmisSonuc";
            this.lstGecmisSonuc.ReadOnly = true;
            this.lstGecmisSonuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lstGecmisSonuc.Size = new System.Drawing.Size(450, 200);
            this.lstGecmisSonuc.TabIndex = 25;
            // 
            // btnGecmisFiltrele
            // 
            this.btnGecmisFiltrele.Location = new System.Drawing.Point(83, 326);
            this.btnGecmisFiltrele.Name = "btnGecmisFiltrele";
            this.btnGecmisFiltrele.Size = new System.Drawing.Size(120, 27);
            this.btnGecmisFiltrele.TabIndex = 24;
            this.btnGecmisFiltrele.Text = "Mesajları Filtrele";
            this.btnGecmisFiltrele.UseVisualStyleBackColor = true;
            this.btnGecmisFiltrele.Click += new System.EventHandler(this.btnFilterLogs_Click);
            // 
            // dtGecmisBitis
            // 
            this.dtGecmisBitis.Location = new System.Drawing.Point(40, 56);
            this.dtGecmisBitis.Name = "dtGecmisBitis";
            this.dtGecmisBitis.Size = new System.Drawing.Size(200, 22);
            this.dtGecmisBitis.TabIndex = 23;
            // 
            // dtGecmisBaslangic
            // 
            this.dtGecmisBaslangic.Location = new System.Drawing.Point(40, 17);
            this.dtGecmisBaslangic.Name = "dtGecmisBaslangic";
            this.dtGecmisBaslangic.Size = new System.Drawing.Size(200, 22);
            this.dtGecmisBaslangic.TabIndex = 22;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.dgvContacts);
            this.tabContacts.Controls.Add(this.label1);
            this.tabContacts.Controls.Add(this.txtSearch);
            this.tabContacts.Controls.Add(this.txtContactPhone);
            this.tabContacts.Controls.Add(this.btnSaveContacts);
            this.tabContacts.Controls.Add(this.txtName);
            this.tabContacts.Controls.Add(this.btnDeleteContact);
            this.tabContacts.Controls.Add(this.btnAddContact);
            this.tabContacts.Controls.Add(this.lblPhone);
            this.tabContacts.Controls.Add(this.lblName);
            this.tabContacts.Location = new System.Drawing.Point(4, 25);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(1222, 441);
            this.tabContacts.TabIndex = 2;
            this.tabContacts.Text = "Kişi Rehberi";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // dgvContacts
            // 
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.PhoneColumn});
            this.dgvContacts.Location = new System.Drawing.Point(496, 67);
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersWidth = 51;
            this.dgvContacts.RowTemplate.Height = 24;
            this.dgvContacts.Size = new System.Drawing.Size(437, 190);
            this.dgvContacts.TabIndex = 7;
            this.dgvContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = " İsim";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.Width = 125;
            // 
            // PhoneColumn
            // 
            this.PhoneColumn.HeaderText = "Telefon";
            this.PhoneColumn.MinimumWidth = 6;
            this.PhoneColumn.Name = "PhoneColumn";
            this.PhoneColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ara..";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(496, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(437, 22);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.Location = new System.Drawing.Point(139, 115);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(123, 22);
            this.txtContactPhone.TabIndex = 2;
            // 
            // btnSaveContacts
            // 
            this.btnSaveContacts.Location = new System.Drawing.Point(269, 169);
            this.btnSaveContacts.Name = "btnSaveContacts";
            this.btnSaveContacts.Size = new System.Drawing.Size(107, 27);
            this.btnSaveContacts.TabIndex = 5;
            this.btnSaveContacts.Text = "Kişileri Kaydet";
            this.btnSaveContacts.UseVisualStyleBackColor = true;
            this.btnSaveContacts.Click += new System.EventHandler(this.btnSaveContacts_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 22);
            this.txtName.TabIndex = 1;
            // 
            // btnDeleteContact
            // 
            this.btnDeleteContact.Location = new System.Drawing.Point(157, 169);
            this.btnDeleteContact.Name = "btnDeleteContact";
            this.btnDeleteContact.Size = new System.Drawing.Size(74, 27);
            this.btnDeleteContact.TabIndex = 4;
            this.btnDeleteContact.Text = "Sil";
            this.btnDeleteContact.UseVisualStyleBackColor = true;
            this.btnDeleteContact.Click += new System.EventHandler(this.btnDeleteContact_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(48, 169);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(74, 27);
            this.btnAddContact.TabIndex = 3;
            this.btnAddContact.Text = "Ekle";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(45, 118);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 16);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Telefon:  +90";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "İsim Soyisim:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPlanSil);
            this.tabPage3.Controls.Add(this.dgvPlanlananlar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1222, 441);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Planlanan Mesajlar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timerScheduled
            // 
            this.timerScheduled.Interval = 1000;
            this.timerScheduled.Tick += new System.EventHandler(this.timerScheduled_Tick);
            // 
            // dgvPlanlananlar
            // 
            this.dgvPlanlananlar.AllowUserToAddRows = false;
            this.dgvPlanlananlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlanlananlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlanlananlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlanlananlar.Location = new System.Drawing.Point(3, 3);
            this.dgvPlanlananlar.Name = "dgvPlanlananlar";
            this.dgvPlanlananlar.ReadOnly = true;
            this.dgvPlanlananlar.RowHeadersWidth = 51;
            this.dgvPlanlananlar.RowTemplate.Height = 24;
            this.dgvPlanlananlar.Size = new System.Drawing.Size(1216, 435);
            this.dgvPlanlananlar.TabIndex = 0;
            // 
            // btnPlanSil
            // 
            this.btnPlanSil.Location = new System.Drawing.Point(528, 121);
            this.btnPlanSil.Name = "btnPlanSil";
            this.btnPlanSil.Size = new System.Drawing.Size(75, 23);
            this.btnPlanSil.TabIndex = 1;
            this.btnPlanSil.Text = "Planı Sil";
            this.btnPlanSil.UseVisualStyleBackColor = true;
            this.btnPlanSil.Click += new System.EventHandler(this.btnPlanSil_Click);
            // 
            // tabYardim
            // 
            this.tabYardim.Controls.Add(this.lblGeriBildirimBaslik);
            this.tabYardim.Controls.Add(this.lstGeriBildiriler);
            this.tabYardim.Controls.Add(this.btnGeriBildir);
            this.tabYardim.Controls.Add(this.txtGeriBildirim);
            this.tabYardim.Controls.Add(this.lblGeri);
            this.tabYardim.Controls.Add(this.txtYardim);
            this.tabYardim.Controls.Add(this.lblYardim);
            this.tabYardim.Location = new System.Drawing.Point(4, 25);
            this.tabYardim.Name = "tabYardim";
            this.tabYardim.Padding = new System.Windows.Forms.Padding(3);
            this.tabYardim.Size = new System.Drawing.Size(1222, 441);
            this.tabYardim.TabIndex = 4;
            this.tabYardim.Text = "Yardım ve Geri Bildirim";
            this.tabYardim.UseVisualStyleBackColor = true;
            // 
            // lblYardim
            // 
            this.lblYardim.AutoSize = true;
            this.lblYardim.Location = new System.Drawing.Point(64, 33);
            this.lblYardim.Name = "lblYardim";
            this.lblYardim.Size = new System.Drawing.Size(50, 16);
            this.lblYardim.TabIndex = 0;
            this.lblYardim.Text = "Yardım";
            // 
            // txtYardim
            // 
            this.txtYardim.Location = new System.Drawing.Point(40, 61);
            this.txtYardim.Name = "txtYardim";
            this.txtYardim.Size = new System.Drawing.Size(100, 96);
            this.txtYardim.TabIndex = 1;
            this.txtYardim.Text = "SMS göndermek için telefon ve mesajı doldurun";
            // 
            // lblGeri
            // 
            this.lblGeri.AutoSize = true;
            this.lblGeri.Location = new System.Drawing.Point(173, 33);
            this.lblGeri.Name = "lblGeri";
            this.lblGeri.Size = new System.Drawing.Size(79, 16);
            this.lblGeri.TabIndex = 2;
            this.lblGeri.Text = "Geri Bildirim";
            // 
            // txtGeriBildirim
            // 
            this.txtGeriBildirim.Location = new System.Drawing.Point(166, 61);
            this.txtGeriBildirim.Multiline = true;
            this.txtGeriBildirim.Name = "txtGeriBildirim";
            this.txtGeriBildirim.Size = new System.Drawing.Size(100, 96);
            this.txtGeriBildirim.TabIndex = 3;
            // 
            // btnGeriBildir
            // 
            this.btnGeriBildir.Location = new System.Drawing.Point(49, 189);
            this.btnGeriBildir.Name = "btnGeriBildir";
            this.btnGeriBildir.Size = new System.Drawing.Size(75, 23);
            this.btnGeriBildir.TabIndex = 4;
            this.btnGeriBildir.Text = "Gönder";
            this.btnGeriBildir.UseVisualStyleBackColor = true;
            this.btnGeriBildir.Click += new System.EventHandler(this.btnGeriBildir_Click);
            // 
            // lstGeriBildiriler
            // 
            this.lstGeriBildiriler.FormattingEnabled = true;
            this.lstGeriBildiriler.ItemHeight = 16;
            this.lstGeriBildiriler.Location = new System.Drawing.Point(300, 61);
            this.lstGeriBildiriler.Name = "lstGeriBildiriler";
            this.lstGeriBildiriler.Size = new System.Drawing.Size(120, 100);
            this.lstGeriBildiriler.TabIndex = 5;
            // 
            // lblGeriBildirimBaslik
            // 
            this.lblGeriBildirimBaslik.AutoSize = true;
            this.lblGeriBildirimBaslik.Location = new System.Drawing.Point(297, 33);
            this.lblGeriBildirimBaslik.Name = "lblGeriBildirimBaslik";
            this.lblGeriBildirimBaslik.Size = new System.Drawing.Size(142, 16);
            this.lblGeriBildirimBaslik.TabIndex = 6;
            this.lblGeriBildirimBaslik.Text = "Geri Bildirim Zamanları";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(577, 101);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(0, 16);
            this.labelStart.TabIndex = 26;
            // 
            // bos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 470);
            this.Controls.Add(this.tabPlanlananlar);
            this.MaximumSize = new System.Drawing.Size(2000, 1000);
            this.Name = "bos";
            this.Load += new System.EventHandler(this.bos_Load);
            this.tabPlanlananlar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabContacts.ResumeLayout(false);
            this.tabContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlanlananlar)).EndInit();
            this.tabYardim.ResumeLayout(false);
            this.tabYardim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabPlanlananlar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelCharCount;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lstGecmisSonuc;
        private System.Windows.Forms.Button btnGecmisFiltrele;
        private System.Windows.Forms.DateTimePicker dtGecmisBitis;
        private System.Windows.Forms.DateTimePicker dtGecmisBaslangic;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnDeleteContact;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnSaveContacts;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneColumn;
        private System.Windows.Forms.DateTimePicker dtScheduledTime;
        private System.Windows.Forms.CheckBox chkSchedule;
        private System.Windows.Forms.Timer timerScheduled;
        private System.Windows.Forms.ListBox lstHazirMesajlar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYeniMesaj;
        private System.Windows.Forms.Button btnMesajEkle;
        private System.Windows.Forms.Button btnMesajSil;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPlanlananlar;
        private System.Windows.Forms.Button btnPlanSil;
        private System.Windows.Forms.TabPage tabYardim;
        private System.Windows.Forms.Label lblYardim;
        private System.Windows.Forms.RichTextBox txtYardim;
        private System.Windows.Forms.Label lblGeri;
        private System.Windows.Forms.TextBox txtGeriBildirim;
        private System.Windows.Forms.Button btnGeriBildir;
        private System.Windows.Forms.ListBox lstGeriBildiriler;
        private System.Windows.Forms.Label lblGeriBildirimBaslik;
        private System.Windows.Forms.Label labelStart;
    }
}
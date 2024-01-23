namespace yesilcam_cinema_information_system
{
    partial class ActressOpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActressOpf));
            dvgActors = new DataGridView();
            btnActressList = new Button();
            btnActressAdd = new Button();
            btnActressUpdate = new Button();
            txtActressGeName = new TextBox();
            txtActressName = new TextBox();
            lblActressGeName = new Label();
            lblActressName = new Label();
            lblDateTime = new Label();
            lblGender = new Label();
            label1 = new Label();
            nupAwardsCount = new NumericUpDown();
            cmbGender = new ComboBox();
            dtpActressDateTime = new DateTimePicker();
            btnActressRemove = new Button();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgActors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAwardsCount).BeginInit();
            SuspendLayout();
            // 
            // dvgActors
            // 
            dvgActors.BackgroundColor = Color.FromArgb(255, 255, 128);
            dvgActors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgActors.Location = new Point(12, 47);
            dvgActors.Margin = new Padding(3, 2, 3, 2);
            dvgActors.Name = "dvgActors";
            dvgActors.RowHeadersWidth = 51;
            dvgActors.Size = new Size(853, 196);
            dvgActors.TabIndex = 0;
            dvgActors.CellContentClick += dvgActors_CellContentClick;
            // 
            // btnActressList
            // 
            btnActressList.BackColor = Color.FromArgb(255, 128, 128);
            btnActressList.FlatStyle = FlatStyle.Popup;
            btnActressList.Font = new Font("Arial Rounded MT Bold", 12F);
            btnActressList.Image = (Image)resources.GetObject("btnActressList.Image");
            btnActressList.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressList.Location = new Point(556, 274);
            btnActressList.Margin = new Padding(3, 2, 3, 2);
            btnActressList.Name = "btnActressList";
            btnActressList.Size = new Size(309, 41);
            btnActressList.TabIndex = 1;
            btnActressList.Text = "Oyuncuları Listele";
            btnActressList.UseVisualStyleBackColor = false;
            btnActressList.Click += btnActressList_Click;
            // 
            // btnActressAdd
            // 
            btnActressAdd.BackColor = Color.Lime;
            btnActressAdd.FlatStyle = FlatStyle.Popup;
            btnActressAdd.Font = new Font("Arial Rounded MT Bold", 12F);
            btnActressAdd.Image = (Image)resources.GetObject("btnActressAdd.Image");
            btnActressAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressAdd.Location = new Point(12, 416);
            btnActressAdd.Margin = new Padding(3, 2, 3, 2);
            btnActressAdd.Name = "btnActressAdd";
            btnActressAdd.Size = new Size(464, 41);
            btnActressAdd.TabIndex = 2;
            btnActressAdd.Text = "Oyuncu Ekle";
            btnActressAdd.UseVisualStyleBackColor = false;
            btnActressAdd.Click += btnActressAdd_Click;
            // 
            // btnActressUpdate
            // 
            btnActressUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnActressUpdate.FlatStyle = FlatStyle.Popup;
            btnActressUpdate.Font = new Font("Arial Rounded MT Bold", 12F);
            btnActressUpdate.Image = (Image)resources.GetObject("btnActressUpdate.Image");
            btnActressUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressUpdate.Location = new Point(556, 340);
            btnActressUpdate.Margin = new Padding(3, 2, 3, 2);
            btnActressUpdate.Name = "btnActressUpdate";
            btnActressUpdate.Size = new Size(309, 41);
            btnActressUpdate.TabIndex = 3;
            btnActressUpdate.Text = "Oyuncu Güncelle";
            btnActressUpdate.UseVisualStyleBackColor = false;
            btnActressUpdate.Click += btnActressUpdate_Click;
            // 
            // txtActressGeName
            // 
            txtActressGeName.BackColor = Color.FromArgb(255, 255, 128);
            txtActressGeName.Location = new Point(268, 274);
            txtActressGeName.Margin = new Padding(3, 2, 3, 2);
            txtActressGeName.Name = "txtActressGeName";
            txtActressGeName.Size = new Size(208, 23);
            txtActressGeName.TabIndex = 4;
            txtActressGeName.TextChanged += txtActressGeName_TextChanged;
            // 
            // txtActressName
            // 
            txtActressName.BackColor = Color.FromArgb(255, 255, 128);
            txtActressName.Location = new Point(268, 299);
            txtActressName.Margin = new Padding(3, 2, 3, 2);
            txtActressName.Name = "txtActressName";
            txtActressName.Size = new Size(208, 23);
            txtActressName.TabIndex = 5;
            txtActressName.TextChanged += txtActressName_TextChanged;
            // 
            // lblActressGeName
            // 
            lblActressGeName.AutoSize = true;
            lblActressGeName.BackColor = Color.Gray;
            lblActressGeName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblActressGeName.Location = new Point(12, 280);
            lblActressGeName.Name = "lblActressGeName";
            lblActressGeName.Size = new Size(160, 18);
            lblActressGeName.TabIndex = 6;
            lblActressGeName.Text = "Oyuncu Sahne Adı:";
            lblActressGeName.Click += lblActressGeName_Click;
            // 
            // lblActressName
            // 
            lblActressName.AutoSize = true;
            lblActressName.BackColor = Color.Gray;
            lblActressName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblActressName.Location = new Point(12, 304);
            lblActressName.Name = "lblActressName";
            lblActressName.Size = new Size(163, 18);
            lblActressName.TabIndex = 7;
            lblActressName.Text = "Oyuncu Adı Soyadı:";
            lblActressName.Click += lblActressName_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Gray;
            lblDateTime.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDateTime.Location = new Point(12, 330);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(214, 18);
            lblDateTime.TabIndex = 9;
            lblDateTime.Text = "Oyuncunun Dogum Tarihi:";
            lblDateTime.Click += lblDateTime_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Gray;
            lblGender.Font = new Font("Arial Rounded MT Bold", 12F);
            lblGender.Location = new Point(12, 356);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(172, 18);
            lblGender.TabIndex = 11;
            lblGender.Text = "Oyuncunun Cinsiyeti";
            lblGender.Click += lblGender_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(12, 381);
            label1.Name = "label1";
            label1.Size = new Size(245, 18);
            label1.TabIndex = 12;
            label1.Text = "Oyuncunun Aldıgı Ödül Sayısı:";
            label1.Click += label1_Click;
            // 
            // nupAwardsCount
            // 
            nupAwardsCount.BackColor = Color.FromArgb(255, 255, 128);
            nupAwardsCount.Location = new Point(268, 376);
            nupAwardsCount.Margin = new Padding(3, 2, 3, 2);
            nupAwardsCount.Name = "nupAwardsCount";
            nupAwardsCount.Size = new Size(207, 23);
            nupAwardsCount.TabIndex = 13;
            nupAwardsCount.ValueChanged += nupAwardsCount_ValueChanged;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 255, 128);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(268, 351);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(208, 23);
            cmbGender.TabIndex = 14;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // dtpActressDateTime
            // 
            dtpActressDateTime.CalendarMonthBackground = Color.FromArgb(255, 255, 128);
            dtpActressDateTime.CalendarTrailingForeColor = Color.FromArgb(255, 255, 128);
            dtpActressDateTime.Location = new Point(268, 326);
            dtpActressDateTime.Margin = new Padding(3, 2, 3, 2);
            dtpActressDateTime.Name = "dtpActressDateTime";
            dtpActressDateTime.Size = new Size(208, 23);
            dtpActressDateTime.TabIndex = 15;
            dtpActressDateTime.ValueChanged += dtpActressDateTime_ValueChanged;
            // 
            // btnActressRemove
            // 
            btnActressRemove.BackColor = Color.Red;
            btnActressRemove.FlatStyle = FlatStyle.Popup;
            btnActressRemove.Font = new Font("Arial Rounded MT Bold", 12F);
            btnActressRemove.Image = (Image)resources.GetObject("btnActressRemove.Image");
            btnActressRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressRemove.Location = new Point(556, 416);
            btnActressRemove.Margin = new Padding(3, 2, 3, 2);
            btnActressRemove.Name = "btnActressRemove";
            btnActressRemove.Size = new Size(309, 41);
            btnActressRemove.TabIndex = 16;
            btnActressRemove.Text = "Seçili Oyuncuyu Sil";
            btnActressRemove.UseVisualStyleBackColor = false;
            btnActressRemove.Click += btnActressRemove_Click;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Image = (Image)resources.GetObject("lblYesilcamSinemaBilgiSistemi.Image");
            lblYesilcamSinemaBilgiSistemi.ImageAlign = ContentAlignment.MiddleRight;
            lblYesilcamSinemaBilgiSistemi.Location = new Point(12, 9);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(485, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 28;
            lblYesilcamSinemaBilgiSistemi.Text = "OYUNCULAR OPERASYON EKRANI          ";
            // 
            // ActressOpf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(881, 488);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnActressRemove);
            Controls.Add(dtpActressDateTime);
            Controls.Add(cmbGender);
            Controls.Add(nupAwardsCount);
            Controls.Add(label1);
            Controls.Add(lblGender);
            Controls.Add(lblDateTime);
            Controls.Add(lblActressName);
            Controls.Add(lblActressGeName);
            Controls.Add(txtActressName);
            Controls.Add(txtActressGeName);
            Controls.Add(btnActressUpdate);
            Controls.Add(btnActressAdd);
            Controls.Add(btnActressList);
            Controls.Add(dvgActors);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActressOpf";
            Text = "ActressOpf";
            Load += ActressOpf_Load;
            ((System.ComponentModel.ISupportInitialize)dvgActors).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAwardsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgActors;
        private Button btnActressList;
        private Button btnActressAdd;
        private Button btnActressUpdate;
        private TextBox txtActressGeName;
        private TextBox txtActressName;
        private Label lblActressGeName;
        private Label lblActressName;
        private Label lblDateTime;
        private Label lblGender;
        private Label label1;
        private NumericUpDown nupAwardsCount;
        private ComboBox cmbGender;
        private DateTimePicker dtpActressDateTime;
        private Button btnActressRemove;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
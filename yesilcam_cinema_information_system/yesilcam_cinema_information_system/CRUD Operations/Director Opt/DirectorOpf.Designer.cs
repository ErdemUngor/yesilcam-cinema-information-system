namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    partial class DirectorOpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorOpf));
            dgvDirector = new DataGridView();
            btnDirectorList = new Button();
            btnActressAdd = new Button();
            txtDirectorName = new TextBox();
            lblDirectorName = new Label();
            dtpDirectorDateTime = new DateTimePicker();
            lblDirectorDateBirth = new Label();
            cmbGender = new ComboBox();
            lblDirectorGender = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            btnSelectedDirectorRemove = new Button();
            btnSelectedDirectorUpdate = new Button();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDirector).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvDirector
            // 
            dgvDirector.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvDirector.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirector.Location = new Point(18, 63);
            dgvDirector.Margin = new Padding(3, 2, 3, 2);
            dgvDirector.Name = "dgvDirector";
            dgvDirector.RowHeadersWidth = 51;
            dgvDirector.Size = new Size(747, 192);
            dgvDirector.TabIndex = 0;
            dgvDirector.CellContentClick += dgvDirector_CellContentClick;
            // 
            // btnDirectorList
            // 
            btnDirectorList.BackColor = Color.FromArgb(255, 128, 128);
            btnDirectorList.FlatStyle = FlatStyle.Popup;
            btnDirectorList.Font = new Font("Arial Rounded MT Bold", 12F);
            btnDirectorList.Image = (Image)resources.GetObject("btnDirectorList.Image");
            btnDirectorList.ImageAlign = ContentAlignment.MiddleLeft;
            btnDirectorList.Location = new Point(492, 279);
            btnDirectorList.Margin = new Padding(3, 2, 3, 2);
            btnDirectorList.Name = "btnDirectorList";
            btnDirectorList.Size = new Size(273, 40);
            btnDirectorList.TabIndex = 1;
            btnDirectorList.Text = "Yönetmenleri Listele";
            btnDirectorList.UseVisualStyleBackColor = false;
            btnDirectorList.Click += btnDirectorList_Click;
            // 
            // btnActressAdd
            // 
            btnActressAdd.BackColor = Color.Lime;
            btnActressAdd.FlatStyle = FlatStyle.Popup;
            btnActressAdd.Font = new Font("Arial Rounded MT Bold", 12F);
            btnActressAdd.Image = (Image)resources.GetObject("btnActressAdd.Image");
            btnActressAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressAdd.Location = new Point(18, 396);
            btnActressAdd.Margin = new Padding(3, 2, 3, 2);
            btnActressAdd.Name = "btnActressAdd";
            btnActressAdd.Size = new Size(420, 39);
            btnActressAdd.TabIndex = 2;
            btnActressAdd.Text = "Yönetmen Ekle";
            btnActressAdd.UseVisualStyleBackColor = false;
            btnActressAdd.Click += btnActressAdd_Click;
            // 
            // txtDirectorName
            // 
            txtDirectorName.BackColor = Color.FromArgb(255, 255, 128);
            txtDirectorName.Location = new Point(219, 279);
            txtDirectorName.Margin = new Padding(3, 2, 3, 2);
            txtDirectorName.Name = "txtDirectorName";
            txtDirectorName.Size = new Size(219, 23);
            txtDirectorName.TabIndex = 3;
            txtDirectorName.TextChanged += txtDirectorName_TextChanged;
            // 
            // lblDirectorName
            // 
            lblDirectorName.AutoSize = true;
            lblDirectorName.BackColor = Color.Gray;
            lblDirectorName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorName.Location = new Point(18, 284);
            lblDirectorName.Name = "lblDirectorName";
            lblDirectorName.Size = new Size(181, 18);
            lblDirectorName.TabIndex = 4;
            lblDirectorName.Text = "Yönetmen Adı Soyadı:";
            lblDirectorName.Click += lblDirectorName_Click;
            // 
            // dtpDirectorDateTime
            // 
            dtpDirectorDateTime.Location = new Point(219, 306);
            dtpDirectorDateTime.Margin = new Padding(3, 2, 3, 2);
            dtpDirectorDateTime.Name = "dtpDirectorDateTime";
            dtpDirectorDateTime.Size = new Size(219, 23);
            dtpDirectorDateTime.TabIndex = 5;
            dtpDirectorDateTime.ValueChanged += dtpDirectorDateTime_ValueChanged;
            // 
            // lblDirectorDateBirth
            // 
            lblDirectorDateBirth.AutoSize = true;
            lblDirectorDateBirth.BackColor = Color.Gray;
            lblDirectorDateBirth.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorDateBirth.Location = new Point(18, 311);
            lblDirectorDateBirth.Name = "lblDirectorDateBirth";
            lblDirectorDateBirth.Size = new Size(197, 18);
            lblDirectorDateBirth.TabIndex = 6;
            lblDirectorDateBirth.Text = "Yönetmen Dogum Tarihi";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 255, 128);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(219, 331);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(219, 23);
            cmbGender.TabIndex = 7;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // lblDirectorGender
            // 
            lblDirectorGender.AutoSize = true;
            lblDirectorGender.BackColor = Color.Gray;
            lblDirectorGender.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorGender.Location = new Point(18, 336);
            lblDirectorGender.Name = "lblDirectorGender";
            lblDirectorGender.Size = new Size(161, 18);
            lblDirectorGender.TabIndex = 8;
            lblDirectorGender.Text = "Yönetmen Cinsiyet:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(255, 255, 128);
            numericUpDown1.Location = new Point(219, 356);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(18, 361);
            label1.Name = "label1";
            label1.Size = new Size(180, 18);
            label1.TabIndex = 10;
            label1.Text = "Yönetmen Ödül Sayısı";
            label1.Click += label1_Click;
            // 
            // btnSelectedDirectorRemove
            // 
            btnSelectedDirectorRemove.BackColor = Color.Red;
            btnSelectedDirectorRemove.FlatStyle = FlatStyle.Popup;
            btnSelectedDirectorRemove.Font = new Font("Arial Rounded MT Bold", 12F);
            btnSelectedDirectorRemove.Image = (Image)resources.GetObject("btnSelectedDirectorRemove.Image");
            btnSelectedDirectorRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedDirectorRemove.Location = new Point(492, 396);
            btnSelectedDirectorRemove.Margin = new Padding(3, 2, 3, 2);
            btnSelectedDirectorRemove.Name = "btnSelectedDirectorRemove";
            btnSelectedDirectorRemove.Size = new Size(273, 39);
            btnSelectedDirectorRemove.TabIndex = 11;
            btnSelectedDirectorRemove.Text = "Seçili Yönetmeni Sil";
            btnSelectedDirectorRemove.UseVisualStyleBackColor = false;
            btnSelectedDirectorRemove.Click += btnSelectedDirectorRemove_Click;
            // 
            // btnSelectedDirectorUpdate
            // 
            btnSelectedDirectorUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnSelectedDirectorUpdate.FlatStyle = FlatStyle.Popup;
            btnSelectedDirectorUpdate.Font = new Font("Arial Rounded MT Bold", 12F);
            btnSelectedDirectorUpdate.Image = (Image)resources.GetObject("btnSelectedDirectorUpdate.Image");
            btnSelectedDirectorUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedDirectorUpdate.Location = new Point(492, 336);
            btnSelectedDirectorUpdate.Margin = new Padding(3, 2, 3, 2);
            btnSelectedDirectorUpdate.Name = "btnSelectedDirectorUpdate";
            btnSelectedDirectorUpdate.Size = new Size(273, 38);
            btnSelectedDirectorUpdate.TabIndex = 12;
            btnSelectedDirectorUpdate.Text = "Yönetmenleri Güncelle";
            btnSelectedDirectorUpdate.UseVisualStyleBackColor = false;
            btnSelectedDirectorUpdate.Click += btnSelectedDirectorUpdate_Click;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Image = (Image)resources.GetObject("lblYesilcamSinemaBilgiSistemi.Image");
            lblYesilcamSinemaBilgiSistemi.ImageAlign = ContentAlignment.MiddleRight;
            lblYesilcamSinemaBilgiSistemi.Location = new Point(18, 19);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(497, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 29;
            lblYesilcamSinemaBilgiSistemi.Text = "YONETMENLER OPERASYON EKRANI       ";
            // 
            // DirectorOpf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(777, 451);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnSelectedDirectorUpdate);
            Controls.Add(btnSelectedDirectorRemove);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(lblDirectorGender);
            Controls.Add(cmbGender);
            Controls.Add(lblDirectorDateBirth);
            Controls.Add(dtpDirectorDateTime);
            Controls.Add(lblDirectorName);
            Controls.Add(txtDirectorName);
            Controls.Add(btnActressAdd);
            Controls.Add(btnDirectorList);
            Controls.Add(dgvDirector);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DirectorOpf";
            Text = "DirectorOpf";
            Load += DirectorOpf_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDirector).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDirector;
        private Button btnDirectorList;
        private Button btnActressAdd;
        private TextBox txtDirectorName;
        private Label lblDirectorName;
        private DateTimePicker dtpDirectorDateTime;
        private Label lblDirectorDateBirth;
        private ComboBox cmbGender;
        private Label lblDirectorGender;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button btnSelectedDirectorRemove;
        private Button btnSelectedDirectorUpdate;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
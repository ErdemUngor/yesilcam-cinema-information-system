namespace yesilcam_cinema_information_system
{
    partial class ActressUpdates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActressUpdates));
            dtpActressDateTime = new DateTimePicker();
            cmbGender = new ComboBox();
            nupAwardsCount = new NumericUpDown();
            label1 = new Label();
            lblGender = new Label();
            lblDateTime = new Label();
            lblActressName = new Label();
            lblActressGeName = new Label();
            txtActressName = new TextBox();
            txtActressGeName = new TextBox();
            btnSelectedActressUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)nupAwardsCount).BeginInit();
            SuspendLayout();
            // 
            // dtpActressDateTime
            // 
            dtpActressDateTime.Location = new Point(254, 63);
            dtpActressDateTime.Margin = new Padding(3, 2, 3, 2);
            dtpActressDateTime.Name = "dtpActressDateTime";
            dtpActressDateTime.Size = new Size(208, 23);
            dtpActressDateTime.TabIndex = 25;
            dtpActressDateTime.ValueChanged += dtpActressDateTime_ValueChanged;
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 255, 128);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(254, 88);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(208, 23);
            cmbGender.TabIndex = 24;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // nupAwardsCount
            // 
            nupAwardsCount.BackColor = Color.FromArgb(255, 255, 128);
            nupAwardsCount.Location = new Point(254, 113);
            nupAwardsCount.Margin = new Padding(3, 2, 3, 2);
            nupAwardsCount.Name = "nupAwardsCount";
            nupAwardsCount.Size = new Size(207, 23);
            nupAwardsCount.TabIndex = 23;
            nupAwardsCount.ValueChanged += nupAwardsCount_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(5, 118);
            label1.Name = "label1";
            label1.Size = new Size(243, 18);
            label1.TabIndex = 22;
            label1.Text = "Oyuncunun Aldığı Ödül Sayısı:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Gray;
            lblGender.Font = new Font("Arial Rounded MT Bold", 12F);
            lblGender.Location = new Point(6, 93);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(172, 18);
            lblGender.TabIndex = 21;
            lblGender.Text = "Oyuncunun Cinsiyeti";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.BackColor = Color.Gray;
            lblDateTime.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDateTime.Location = new Point(6, 68);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(212, 18);
            lblDateTime.TabIndex = 20;
            lblDateTime.Text = "Oyuncunun Doğum Tarihi:";
            // 
            // lblActressName
            // 
            lblActressName.AutoSize = true;
            lblActressName.BackColor = Color.Gray;
            lblActressName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblActressName.Location = new Point(5, 41);
            lblActressName.Name = "lblActressName";
            lblActressName.Size = new Size(163, 18);
            lblActressName.TabIndex = 19;
            lblActressName.Text = "Oyuncu Adı Soyadı:";
            // 
            // lblActressGeName
            // 
            lblActressGeName.AutoSize = true;
            lblActressGeName.BackColor = Color.Gray;
            lblActressGeName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblActressGeName.Location = new Point(5, 16);
            lblActressGeName.Name = "lblActressGeName";
            lblActressGeName.Size = new Size(160, 18);
            lblActressGeName.TabIndex = 18;
            lblActressGeName.Text = "Oyuncu Sahne Adı:";
            // 
            // txtActressName
            // 
            txtActressName.BackColor = Color.FromArgb(255, 255, 128);
            txtActressName.Location = new Point(254, 36);
            txtActressName.Margin = new Padding(3, 2, 3, 2);
            txtActressName.Name = "txtActressName";
            txtActressName.Size = new Size(208, 23);
            txtActressName.TabIndex = 17;
            txtActressName.TextChanged += txtActressName_TextChanged;
            // 
            // txtActressGeName
            // 
            txtActressGeName.BackColor = Color.FromArgb(255, 255, 128);
            txtActressGeName.Location = new Point(254, 11);
            txtActressGeName.Margin = new Padding(3, 2, 3, 2);
            txtActressGeName.Name = "txtActressGeName";
            txtActressGeName.Size = new Size(208, 23);
            txtActressGeName.TabIndex = 16;
            txtActressGeName.TextChanged += txtActressGeName_TextChanged;
            // 
            // btnSelectedActressUpdate
            // 
            btnSelectedActressUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnSelectedActressUpdate.FlatStyle = FlatStyle.Popup;
            btnSelectedActressUpdate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectedActressUpdate.Image = (Image)resources.GetObject("btnSelectedActressUpdate.Image");
            btnSelectedActressUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedActressUpdate.Location = new Point(6, 172);
            btnSelectedActressUpdate.Margin = new Padding(3, 2, 3, 2);
            btnSelectedActressUpdate.Name = "btnSelectedActressUpdate";
            btnSelectedActressUpdate.Size = new Size(456, 41);
            btnSelectedActressUpdate.TabIndex = 26;
            btnSelectedActressUpdate.Text = "SECILI OYUNCUYU GUNCELLE";
            btnSelectedActressUpdate.UseVisualStyleBackColor = false;
            btnSelectedActressUpdate.Click += btnSelectedActressUpdate_Click;
            // 
            // ActressUpdates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(480, 238);
            Controls.Add(btnSelectedActressUpdate);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "ActressUpdates";
            Text = "Seçili Oyuncuyu Guncelleme";
            Load += ActressUpdates_Load;
            ((System.ComponentModel.ISupportInitialize)nupAwardsCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpActressDateTime;
        private ComboBox cmbGender;
        private NumericUpDown nupAwardsCount;
        private Label label1;
        private Label lblGender;
        private Label lblDateTime;
        private Label lblActressName;
        private Label lblActressGeName;
        private TextBox txtActressName;
        private TextBox txtActressGeName;
        private Button btnSelectedActressUpdate;
    }
}
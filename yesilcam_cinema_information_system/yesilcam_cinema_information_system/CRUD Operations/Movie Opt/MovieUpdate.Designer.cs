namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    partial class MovieUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieUpdate));
            comboBox1 = new ComboBox();
            nudMovieBoxOffice = new NumericUpDown();
            nudMovieRating = new NumericUpDown();
            btnBrowsePath = new Button();
            cmbMovieCategory = new ComboBox();
            dtpMoveDateTime = new DateTimePicker();
            txtMovieName = new TextBox();
            btnSelectedMovieUpdate = new Button();
            label1 = new Label();
            lblMovieDirector = new Label();
            lblPosterPath = new LinkLabel();
            lblMovieCategory = new Label();
            lblMovieBoxOffice = new Label();
            lblMovieRating = new Label();
            lblMovieDateTime = new Label();
            lblMovieName = new Label();
            cmbActress = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)nudMovieBoxOffice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieRating).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 128);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(837, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 38;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // nudMovieBoxOffice
            // 
            nudMovieBoxOffice.BackColor = Color.FromArgb(255, 255, 128);
            nudMovieBoxOffice.Location = new Point(278, 109);
            nudMovieBoxOffice.Name = "nudMovieBoxOffice";
            nudMovieBoxOffice.Size = new Size(199, 23);
            nudMovieBoxOffice.TabIndex = 36;
            nudMovieBoxOffice.ValueChanged += nudMovieBoxOffice_ValueChanged;
            // 
            // nudMovieRating
            // 
            nudMovieRating.BackColor = Color.FromArgb(255, 255, 128);
            nudMovieRating.Location = new Point(277, 81);
            nudMovieRating.Name = "nudMovieRating";
            nudMovieRating.Size = new Size(199, 23);
            nudMovieRating.TabIndex = 35;
            nudMovieRating.ValueChanged += nudMovieRating_ValueChanged;
            // 
            // btnBrowsePath
            // 
            btnBrowsePath.BackColor = Color.FromArgb(192, 255, 255);
            btnBrowsePath.FlatStyle = FlatStyle.Popup;
            btnBrowsePath.Location = new Point(837, 116);
            btnBrowsePath.Name = "btnBrowsePath";
            btnBrowsePath.Size = new Size(121, 23);
            btnBrowsePath.TabIndex = 34;
            btnBrowsePath.Text = "...";
            btnBrowsePath.UseVisualStyleBackColor = false;
            btnBrowsePath.Click += btnBrowsePath_Click;
            // 
            // cmbMovieCategory
            // 
            cmbMovieCategory.BackColor = Color.FromArgb(255, 255, 128);
            cmbMovieCategory.FormattingEnabled = true;
            cmbMovieCategory.Location = new Point(838, 26);
            cmbMovieCategory.Name = "cmbMovieCategory";
            cmbMovieCategory.Size = new Size(121, 23);
            cmbMovieCategory.TabIndex = 31;
            cmbMovieCategory.SelectedIndexChanged += cmbMovieCategory_SelectedIndexChanged;
            // 
            // dtpMoveDateTime
            // 
            dtpMoveDateTime.Location = new Point(277, 53);
            dtpMoveDateTime.Name = "dtpMoveDateTime";
            dtpMoveDateTime.Size = new Size(200, 23);
            dtpMoveDateTime.TabIndex = 25;
            dtpMoveDateTime.ValueChanged += dtpMoveDateTime_ValueChanged;
            // 
            // txtMovieName
            // 
            txtMovieName.BackColor = Color.FromArgb(255, 255, 128);
            txtMovieName.Location = new Point(277, 26);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(200, 23);
            txtMovieName.TabIndex = 24;
            txtMovieName.TextChanged += txtMovieName_TextChanged;
            // 
            // btnSelectedMovieUpdate
            // 
            btnSelectedMovieUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnSelectedMovieUpdate.FlatStyle = FlatStyle.Popup;
            btnSelectedMovieUpdate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectedMovieUpdate.Image = (Image)resources.GetObject("btnSelectedMovieUpdate.Image");
            btnSelectedMovieUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedMovieUpdate.Location = new Point(17, 154);
            btnSelectedMovieUpdate.Name = "btnSelectedMovieUpdate";
            btnSelectedMovieUpdate.Size = new Size(941, 34);
            btnSelectedMovieUpdate.TabIndex = 39;
            btnSelectedMovieUpdate.Text = "FILMI GUNCELLE";
            btnSelectedMovieUpdate.UseVisualStyleBackColor = false;
            btnSelectedMovieUpdate.Click += btnSelectedMovieUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(538, 92);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 47;
            label1.Text = "Film Oyuncuları";
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.BackColor = Color.Gray;
            lblMovieDirector.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieDirector.Location = new Point(538, 63);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(128, 18);
            lblMovieDirector.TabIndex = 46;
            lblMovieDirector.Text = "Film Yönetmeni";
            // 
            // lblPosterPath
            // 
            lblPosterPath.AutoSize = true;
            lblPosterPath.BackColor = Color.Gray;
            lblPosterPath.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPosterPath.LinkColor = Color.Black;
            lblPosterPath.Location = new Point(538, 121);
            lblPosterPath.Name = "lblPosterPath";
            lblPosterPath.Size = new Size(176, 18);
            lblPosterPath.TabIndex = 45;
            lblPosterPath.TabStop = true;
            lblPosterPath.Text = "Film Posterini Seçiniz";
            // 
            // lblMovieCategory
            // 
            lblMovieCategory.AutoSize = true;
            lblMovieCategory.BackColor = Color.Gray;
            lblMovieCategory.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieCategory.Location = new Point(538, 31);
            lblMovieCategory.Name = "lblMovieCategory";
            lblMovieCategory.Size = new Size(126, 18);
            lblMovieCategory.TabIndex = 44;
            lblMovieCategory.Text = "Film Kategorisi";
            // 
            // lblMovieBoxOffice
            // 
            lblMovieBoxOffice.AutoSize = true;
            lblMovieBoxOffice.BackColor = Color.Gray;
            lblMovieBoxOffice.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieBoxOffice.Location = new Point(17, 114);
            lblMovieBoxOffice.Name = "lblMovieBoxOffice";
            lblMovieBoxOffice.Size = new Size(91, 18);
            lblMovieBoxOffice.TabIndex = 43;
            lblMovieBoxOffice.Text = "Film Gişesi";
            // 
            // lblMovieRating
            // 
            lblMovieRating.AutoSize = true;
            lblMovieRating.BackColor = Color.Gray;
            lblMovieRating.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieRating.Location = new Point(17, 86);
            lblMovieRating.Name = "lblMovieRating";
            lblMovieRating.Size = new Size(96, 18);
            lblMovieRating.TabIndex = 42;
            lblMovieRating.Text = "Film Rating";
            // 
            // lblMovieDateTime
            // 
            lblMovieDateTime.AutoSize = true;
            lblMovieDateTime.BackColor = Color.Gray;
            lblMovieDateTime.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieDateTime.Location = new Point(17, 58);
            lblMovieDateTime.Name = "lblMovieDateTime";
            lblMovieDateTime.Size = new Size(209, 18);
            lblMovieDateTime.TabIndex = 41;
            lblMovieDateTime.Text = "Filmin Olusturulma Tarihi:";
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.BackColor = Color.Gray;
            lblMovieName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieName.Location = new Point(17, 31);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(75, 18);
            lblMovieName.TabIndex = 40;
            lblMovieName.Text = "Film Adı:";
            // 
            // cmbActress
            // 
            cmbActress.BackColor = Color.FromArgb(255, 255, 128);
            cmbActress.FormattingEnabled = true;
            cmbActress.Location = new Point(837, 87);
            cmbActress.Name = "cmbActress";
            cmbActress.Size = new Size(121, 23);
            cmbActress.TabIndex = 49;
            cmbActress.SelectedIndexChanged += cmbActress_SelectedIndexChanged;
            // 
            // MovieUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(980, 202);
            Controls.Add(cmbActress);
            Controls.Add(label1);
            Controls.Add(lblMovieDirector);
            Controls.Add(lblPosterPath);
            Controls.Add(lblMovieCategory);
            Controls.Add(lblMovieBoxOffice);
            Controls.Add(lblMovieRating);
            Controls.Add(lblMovieDateTime);
            Controls.Add(lblMovieName);
            Controls.Add(btnSelectedMovieUpdate);
            Controls.Add(comboBox1);
            Controls.Add(nudMovieBoxOffice);
            Controls.Add(nudMovieRating);
            Controls.Add(btnBrowsePath);
            Controls.Add(cmbMovieCategory);
            Controls.Add(dtpMoveDateTime);
            Controls.Add(txtMovieName);
            Name = "MovieUpdate";
            Text = "Seçili Filmi Güncelle";
            Load += MovieUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)nudMovieBoxOffice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private NumericUpDown nudMovieBoxOffice;
        private NumericUpDown nudMovieRating;
        private Button btnBrowsePath;
        private ComboBox cmbMovieCategory;
        private DateTimePicker dtpMoveDateTime;
        private TextBox txtMovieName;
        private Button btnSelectedMovieUpdate;
        private Label label1;
        private Label lblMovieDirector;
        private LinkLabel lblPosterPath;
        private Label lblMovieCategory;
        private Label lblMovieBoxOffice;
        private Label lblMovieRating;
        private Label lblMovieDateTime;
        private Label lblMovieName;
        private ComboBox cmbActress;
    }
}
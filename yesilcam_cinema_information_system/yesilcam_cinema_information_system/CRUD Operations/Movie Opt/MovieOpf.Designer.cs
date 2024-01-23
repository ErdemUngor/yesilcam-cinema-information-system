namespace yesilcam_cinema_information_system.CRUD_Operations.Movie_Opt
{
    partial class MovieOpf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieOpf));
            dgvMovies = new DataGridView();
            pbMoviePoster = new PictureBox();
            btnMovieList = new Button();
            btnMovieAdd = new Button();
            txtMovieName = new TextBox();
            dtpMoveDateTime = new DateTimePicker();
            lblMovieName = new Label();
            lblMovieDateTime = new Label();
            lblMovieRating = new Label();
            lblMovieBoxOffice = new Label();
            cmbMovieCategory = new ComboBox();
            lblMovieCategory = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblPosterPath = new LinkLabel();
            btnBrowsePath = new Button();
            nudMovieRating = new NumericUpDown();
            nudMovieBoxOffice = new NumericUpDown();
            btnSelectedMovieRemove = new Button();
            button1 = new Button();
            lblMovieDirector = new Label();
            comboBox1 = new ComboBox();
            cmbActress = new ComboBox();
            label1 = new Label();
            lblYesilcamSinemaBilgiSistemi = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMoviePoster).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieBoxOffice).BeginInit();
            SuspendLayout();
            // 
            // dgvMovies
            // 
            dgvMovies.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(12, 68);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.Size = new Size(785, 260);
            dgvMovies.TabIndex = 0;
            dgvMovies.CellContentClick += dgvMovies_CellContentClick;
            // 
            // pbMoviePoster
            // 
            pbMoviePoster.Location = new Point(836, 90);
            pbMoviePoster.Name = "pbMoviePoster";
            pbMoviePoster.Size = new Size(307, 238);
            pbMoviePoster.TabIndex = 1;
            pbMoviePoster.TabStop = false;
            pbMoviePoster.Click += pbMoviePoster_Click;
            // 
            // btnMovieList
            // 
            btnMovieList.BackColor = Color.FromArgb(255, 128, 128);
            btnMovieList.FlatStyle = FlatStyle.Popup;
            btnMovieList.Font = new Font("Arial Rounded MT Bold", 12F);
            btnMovieList.Image = (Image)resources.GetObject("btnMovieList.Image");
            btnMovieList.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovieList.Location = new Point(896, 360);
            btnMovieList.Name = "btnMovieList";
            btnMovieList.Size = new Size(247, 37);
            btnMovieList.TabIndex = 2;
            btnMovieList.Text = "Filmleri Listele";
            btnMovieList.UseVisualStyleBackColor = false;
            btnMovieList.Click += btnMovieList_Click;
            // 
            // btnMovieAdd
            // 
            btnMovieAdd.BackColor = Color.Lime;
            btnMovieAdd.FlatStyle = FlatStyle.Popup;
            btnMovieAdd.Font = new Font("Arial Rounded MT Bold", 12F);
            btnMovieAdd.Image = (Image)resources.GetObject("btnMovieAdd.Image");
            btnMovieAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovieAdd.Location = new Point(11, 476);
            btnMovieAdd.Name = "btnMovieAdd";
            btnMovieAdd.Size = new Size(853, 40);
            btnMovieAdd.TabIndex = 3;
            btnMovieAdd.Text = "Film Ekle";
            btnMovieAdd.UseVisualStyleBackColor = false;
            btnMovieAdd.Click += btnMovieAdd_Click;
            // 
            // txtMovieName
            // 
            txtMovieName.BackColor = Color.FromArgb(255, 255, 128);
            txtMovieName.Location = new Point(226, 360);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(200, 23);
            txtMovieName.TabIndex = 4;
            txtMovieName.TextChanged += txtMovieName_TextChanged;
            // 
            // dtpMoveDateTime
            // 
            dtpMoveDateTime.Location = new Point(226, 389);
            dtpMoveDateTime.Name = "dtpMoveDateTime";
            dtpMoveDateTime.Size = new Size(200, 23);
            dtpMoveDateTime.TabIndex = 5;
            dtpMoveDateTime.ValueChanged += dtpMoveDateTime_ValueChanged;
            // 
            // lblMovieName
            // 
            lblMovieName.AutoSize = true;
            lblMovieName.BackColor = Color.Gray;
            lblMovieName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieName.Location = new Point(11, 365);
            lblMovieName.Name = "lblMovieName";
            lblMovieName.Size = new Size(75, 18);
            lblMovieName.TabIndex = 6;
            lblMovieName.Text = "Film Adı:";
            // 
            // lblMovieDateTime
            // 
            lblMovieDateTime.AutoSize = true;
            lblMovieDateTime.BackColor = Color.Gray;
            lblMovieDateTime.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieDateTime.Location = new Point(11, 394);
            lblMovieDateTime.Name = "lblMovieDateTime";
            lblMovieDateTime.Size = new Size(209, 18);
            lblMovieDateTime.TabIndex = 7;
            lblMovieDateTime.Text = "Filmin Olusturulma Tarihi:";
            // 
            // lblMovieRating
            // 
            lblMovieRating.AutoSize = true;
            lblMovieRating.BackColor = Color.Gray;
            lblMovieRating.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieRating.Location = new Point(11, 421);
            lblMovieRating.Name = "lblMovieRating";
            lblMovieRating.Size = new Size(96, 18);
            lblMovieRating.TabIndex = 9;
            lblMovieRating.Text = "Film Rating";
            // 
            // lblMovieBoxOffice
            // 
            lblMovieBoxOffice.AutoSize = true;
            lblMovieBoxOffice.BackColor = Color.Gray;
            lblMovieBoxOffice.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieBoxOffice.Location = new Point(11, 448);
            lblMovieBoxOffice.Name = "lblMovieBoxOffice";
            lblMovieBoxOffice.Size = new Size(91, 18);
            lblMovieBoxOffice.TabIndex = 10;
            lblMovieBoxOffice.Text = "Film Gişesi";
            // 
            // cmbMovieCategory
            // 
            cmbMovieCategory.BackColor = Color.FromArgb(255, 255, 128);
            cmbMovieCategory.FormattingEnabled = true;
            cmbMovieCategory.Location = new Point(743, 361);
            cmbMovieCategory.Name = "cmbMovieCategory";
            cmbMovieCategory.Size = new Size(121, 23);
            cmbMovieCategory.TabIndex = 14;
            cmbMovieCategory.SelectedIndexChanged += cmbMovieCategory_SelectedIndexChanged;
            // 
            // lblMovieCategory
            // 
            lblMovieCategory.AutoSize = true;
            lblMovieCategory.BackColor = Color.Gray;
            lblMovieCategory.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieCategory.Location = new Point(474, 366);
            lblMovieCategory.Name = "lblMovieCategory";
            lblMovieCategory.Size = new Size(126, 18);
            lblMovieCategory.TabIndex = 15;
            lblMovieCategory.Text = "Film Kategorisi";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblPosterPath
            // 
            lblPosterPath.AutoSize = true;
            lblPosterPath.BackColor = Color.Gray;
            lblPosterPath.Font = new Font("Arial Rounded MT Bold", 12F);
            lblPosterPath.LinkColor = Color.Black;
            lblPosterPath.Location = new Point(474, 447);
            lblPosterPath.Name = "lblPosterPath";
            lblPosterPath.Size = new Size(176, 18);
            lblPosterPath.TabIndex = 16;
            lblPosterPath.TabStop = true;
            lblPosterPath.Text = "Film Posterini Seçiniz";
            lblPosterPath.LinkClicked += lblPosterPath_LinkClicked;
            // 
            // btnBrowsePath
            // 
            btnBrowsePath.BackColor = Color.FromArgb(192, 255, 255);
            btnBrowsePath.FlatStyle = FlatStyle.Popup;
            btnBrowsePath.Location = new Point(743, 447);
            btnBrowsePath.Name = "btnBrowsePath";
            btnBrowsePath.Size = new Size(121, 23);
            btnBrowsePath.TabIndex = 17;
            btnBrowsePath.Text = "...";
            btnBrowsePath.UseVisualStyleBackColor = false;
            btnBrowsePath.Click += btnBrowsePath_Click;
            // 
            // nudMovieRating
            // 
            nudMovieRating.BackColor = Color.FromArgb(255, 255, 128);
            nudMovieRating.Location = new Point(226, 416);
            nudMovieRating.Name = "nudMovieRating";
            nudMovieRating.Size = new Size(200, 23);
            nudMovieRating.TabIndex = 18;
            nudMovieRating.ValueChanged += nudMovieRating_ValueChanged;
            // 
            // nudMovieBoxOffice
            // 
            nudMovieBoxOffice.BackColor = Color.FromArgb(255, 255, 128);
            nudMovieBoxOffice.Location = new Point(226, 447);
            nudMovieBoxOffice.Name = "nudMovieBoxOffice";
            nudMovieBoxOffice.Size = new Size(200, 23);
            nudMovieBoxOffice.TabIndex = 19;
            nudMovieBoxOffice.ValueChanged += nudMovieBoxOffice_ValueChanged;
            // 
            // btnSelectedMovieRemove
            // 
            btnSelectedMovieRemove.BackColor = Color.Red;
            btnSelectedMovieRemove.FlatStyle = FlatStyle.Popup;
            btnSelectedMovieRemove.Font = new Font("Arial Rounded MT Bold", 12F);
            btnSelectedMovieRemove.Image = (Image)resources.GetObject("btnSelectedMovieRemove.Image");
            btnSelectedMovieRemove.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedMovieRemove.Location = new Point(896, 476);
            btnSelectedMovieRemove.Name = "btnSelectedMovieRemove";
            btnSelectedMovieRemove.Size = new Size(247, 37);
            btnSelectedMovieRemove.TabIndex = 20;
            btnSelectedMovieRemove.Text = "Seçili Filmi Sİl";
            btnSelectedMovieRemove.UseVisualStyleBackColor = false;
            btnSelectedMovieRemove.Click += btnSelectedMovieRemove_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 255);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 12F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(896, 415);
            button1.Name = "button1";
            button1.Size = new Size(247, 40);
            button1.TabIndex = 21;
            button1.Text = "Seçili Filmi Güncelle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblMovieDirector
            // 
            lblMovieDirector.AutoSize = true;
            lblMovieDirector.BackColor = Color.Gray;
            lblMovieDirector.Font = new Font("Arial Rounded MT Bold", 12F);
            lblMovieDirector.Location = new Point(474, 392);
            lblMovieDirector.Name = "lblMovieDirector";
            lblMovieDirector.Size = new Size(128, 18);
            lblMovieDirector.TabIndex = 22;
            lblMovieDirector.Text = "Film Yönetmeni";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 128);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(743, 392);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 23;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbActress
            // 
            cmbActress.BackColor = Color.FromArgb(255, 255, 128);
            cmbActress.FormattingEnabled = true;
            cmbActress.Location = new Point(743, 421);
            cmbActress.Name = "cmbActress";
            cmbActress.Size = new Size(121, 23);
            cmbActress.TabIndex = 25;
            cmbActress.SelectedIndexChanged += cmbActress_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(474, 421);
            label1.Name = "label1";
            label1.Size = new Size(133, 18);
            label1.TabIndex = 24;
            label1.Text = "Oyuncuları Ekle";
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Image = (Image)resources.GetObject("lblYesilcamSinemaBilgiSistemi.Image");
            lblYesilcamSinemaBilgiSistemi.ImageAlign = ContentAlignment.MiddleRight;
            lblYesilcamSinemaBilgiSistemi.Location = new Point(11, 19);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(554, 37);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 30;
            lblYesilcamSinemaBilgiSistemi.Text = "FILM OPERASYON ISLEMLERI         ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(836, 68);
            label2.Name = "label2";
            label2.Size = new Size(123, 18);
            label2.TabIndex = 31;
            label2.Text = "FILM POSTERI";
            // 
            // MovieOpf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1160, 541);
            Controls.Add(label2);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(cmbActress);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(lblMovieDirector);
            Controls.Add(button1);
            Controls.Add(btnSelectedMovieRemove);
            Controls.Add(nudMovieBoxOffice);
            Controls.Add(nudMovieRating);
            Controls.Add(btnBrowsePath);
            Controls.Add(lblPosterPath);
            Controls.Add(lblMovieCategory);
            Controls.Add(cmbMovieCategory);
            Controls.Add(lblMovieBoxOffice);
            Controls.Add(lblMovieRating);
            Controls.Add(lblMovieDateTime);
            Controls.Add(lblMovieName);
            Controls.Add(dtpMoveDateTime);
            Controls.Add(txtMovieName);
            Controls.Add(btnMovieAdd);
            Controls.Add(btnMovieList);
            Controls.Add(pbMoviePoster);
            Controls.Add(dgvMovies);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MovieOpf";
            Text = "Film Islemleri";
            Load += MovieOpf_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMoviePoster).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMovieBoxOffice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMovies;
        private PictureBox pbMoviePoster;
        private Button btnMovieList;
        private Button btnMovieAdd;
        private TextBox txtMovieName;
        private DateTimePicker dtpMoveDateTime;
        private Label lblMovieName;
        private Label lblMovieDateTime;
        private Label lblMovieRating;
        private Label lblMovieBoxOffice;
        private ComboBox cmbMovieCategory;
        private Label lblMovieCategory;
        private OpenFileDialog openFileDialog1;
        private LinkLabel lblPosterPath;
        private Button btnBrowsePath;
        private NumericUpDown nudMovieRating;
        private NumericUpDown nudMovieBoxOffice;
        private Button btnSelectedMovieRemove;
        private Button button1;
        private Label lblMovieDirector;
        private ComboBox comboBox1;
        private ComboBox cmbActress;
        private Label label1;
        private Label lblYesilcamSinemaBilgiSistemi;
        private Label label2;
    }
}
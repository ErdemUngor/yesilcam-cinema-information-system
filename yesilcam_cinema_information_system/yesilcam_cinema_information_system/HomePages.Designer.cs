namespace yesilcam_cinema_information_system
{
    partial class HomePages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePages));
            dataGridView1 = new DataGridView();
            lblYesilcamSinemaBilgiSistemi = new Label();
            btnMovie = new Button();
            btnDirector = new Button();
            btnActress = new Button();
            btnImdbSırala = new Button();
            pbMoviePoster = new PictureBox();
            btnOneMoreFilm = new Button();
            btnDirectorView = new Button();
            btnActressView = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMoviePoster).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            resources.ApplyResources(lblYesilcamSinemaBilgiSistemi, "lblYesilcamSinemaBilgiSistemi");
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            // 
            // btnMovie
            // 
            btnMovie.BackColor = Color.Lime;
            resources.ApplyResources(btnMovie, "btnMovie");
            btnMovie.Name = "btnMovie";
            btnMovie.UseVisualStyleBackColor = false;
            btnMovie.Click += btnMovie_Click_1;
            // 
            // btnDirector
            // 
            btnDirector.BackColor = Color.Red;
            resources.ApplyResources(btnDirector, "btnDirector");
            btnDirector.Name = "btnDirector";
            btnDirector.UseVisualStyleBackColor = false;
            btnDirector.Click += btnDirector_Click_1;
            // 
            // btnActress
            // 
            btnActress.BackColor = Color.Fuchsia;
            resources.ApplyResources(btnActress, "btnActress");
            btnActress.Name = "btnActress";
            btnActress.UseVisualStyleBackColor = false;
            btnActress.Click += btnActress_Click_1;
            // 
            // btnImdbSırala
            // 
            btnImdbSırala.BackColor = Color.Teal;
            resources.ApplyResources(btnImdbSırala, "btnImdbSırala");
            btnImdbSırala.Name = "btnImdbSırala";
            btnImdbSırala.UseVisualStyleBackColor = false;
            btnImdbSırala.Click += btnImdbSırala_Click;
            // 
            // pbMoviePoster
            // 
            resources.ApplyResources(pbMoviePoster, "pbMoviePoster");
            pbMoviePoster.Name = "pbMoviePoster";
            pbMoviePoster.TabStop = false;
            pbMoviePoster.Click += pbMoviePoster_Click_1;
            // 
            // btnOneMoreFilm
            // 
            btnOneMoreFilm.BackColor = Color.FromArgb(192, 255, 192);
            resources.ApplyResources(btnOneMoreFilm, "btnOneMoreFilm");
            btnOneMoreFilm.Name = "btnOneMoreFilm";
            btnOneMoreFilm.UseVisualStyleBackColor = false;
            btnOneMoreFilm.Click += btnOneMoreFilm_Click;
            // 
            // btnDirectorView
            // 
            btnDirectorView.BackColor = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(btnDirectorView, "btnDirectorView");
            btnDirectorView.Name = "btnDirectorView";
            btnDirectorView.UseVisualStyleBackColor = false;
            btnDirectorView.Click += btnDirectorView_Click;
            // 
            // btnActressView
            // 
            btnActressView.BackColor = Color.FromArgb(255, 192, 192);
            resources.ApplyResources(btnActressView, "btnActressView");
            btnActressView.Name = "btnActressView";
            btnActressView.UseVisualStyleBackColor = false;
            btnActressView.Click += btnActressView_Click_1;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.Name = "label2";
            // 
            // HomePages
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnMovie);
            Controls.Add(btnDirector);
            Controls.Add(btnActress);
            Controls.Add(btnImdbSırala);
            Controls.Add(pbMoviePoster);
            Controls.Add(btnOneMoreFilm);
            Controls.Add(btnDirectorView);
            Controls.Add(btnActressView);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "HomePages";
            Load += HomePages_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMoviePoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblYesilcamSinemaBilgiSistemi;
        private Button btnMovie;
        private Button btnDirector;
        private Button btnActress;
        private Button btnImdbSırala;
        private PictureBox pbMoviePoster;
        private Button btnOneMoreFilm;
        private Button btnDirectorView;
        private Button btnActressView;
        private Label label2;
    }
}
namespace yesilcam_cinema_information_system
{
    partial class Rating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rating));
            cmbCategory = new ComboBox();
            dataGridView1 = new DataGridView();
            btnMovieList = new Button();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(255, 255, 128);
            cmbCategory.FlatStyle = FlatStyle.Popup;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(10, 284);
            cmbCategory.Margin = new Padding(3, 2, 3, 2);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(962, 23);
            cmbCategory.TabIndex = 0;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 50);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(962, 213);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnMovieList
            // 
            btnMovieList.BackColor = Color.FromArgb(255, 255, 128);
            btnMovieList.FlatStyle = FlatStyle.Popup;
            btnMovieList.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMovieList.ForeColor = Color.Black;
            btnMovieList.Image = (Image)resources.GetObject("btnMovieList.Image");
            btnMovieList.ImageAlign = ContentAlignment.MiddleLeft;
            btnMovieList.Location = new Point(10, 311);
            btnMovieList.Margin = new Padding(3, 2, 3, 2);
            btnMovieList.Name = "btnMovieList";
            btnMovieList.Size = new Size(962, 40);
            btnMovieList.TabIndex = 4;
            btnMovieList.Text = "FILMLERI LISTELE";
            btnMovieList.UseVisualStyleBackColor = false;
            btnMovieList.Click += btnMovieList_Click;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Location = new Point(10, 9);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(574, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 28;
            lblYesilcamSinemaBilgiSistemi.Text = "KATEGORIYE GORE RATINGE GORE SIRALAMA";
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(984, 362);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnMovieList);
            Controls.Add(dataGridView1);
            Controls.Add(cmbCategory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Rating";
            Text = "Kategoriye Göre Ratinge Göre Sıralama";
            Load += Rating_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCategory;
        private DataGridView dataGridView1;
        private Button btnMovieList;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
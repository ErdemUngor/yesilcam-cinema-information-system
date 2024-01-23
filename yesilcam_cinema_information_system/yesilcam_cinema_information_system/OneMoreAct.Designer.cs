namespace yesilcam_cinema_information_system
{
    partial class OneMoreAct
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
            dataGridView1 = new DataGridView();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 60);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(672, 363);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Location = new Point(9, 21);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(672, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 27;
            lblYesilcamSinemaBilgiSistemi.Text = "BIRDEN COK FILMDE BERABER OYNUYAN OYUNCULAR";
            // 
            // OneMoreAct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(692, 432);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OneMoreAct";
            Text = "Birden Çok Filmde Beraber Oynuyan Oyuncular";
            Load += OneMoreAct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
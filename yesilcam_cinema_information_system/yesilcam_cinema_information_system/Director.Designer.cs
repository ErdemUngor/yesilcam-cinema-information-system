namespace yesilcam_cinema_information_system
{
    partial class Director
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Director));
            dgvDirectorList = new DataGridView();
            btnDirectorList = new Button();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDirectorList).BeginInit();
            SuspendLayout();
            // 
            // dgvDirectorList
            // 
            dgvDirectorList.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvDirectorList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDirectorList.Location = new Point(9, 50);
            dgvDirectorList.Margin = new Padding(3, 2, 3, 2);
            dgvDirectorList.Name = "dgvDirectorList";
            dgvDirectorList.RowHeadersWidth = 51;
            dgvDirectorList.Size = new Size(679, 185);
            dgvDirectorList.TabIndex = 0;
            dgvDirectorList.CellContentClick += dgvDirectorList_CellContentClick;
            // 
            // btnDirectorList
            // 
            btnDirectorList.BackColor = Color.FromArgb(255, 255, 128);
            btnDirectorList.FlatStyle = FlatStyle.Popup;
            btnDirectorList.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDirectorList.ForeColor = Color.Black;
            btnDirectorList.Image = (Image)resources.GetObject("btnDirectorList.Image");
            btnDirectorList.ImageAlign = ContentAlignment.MiddleLeft;
            btnDirectorList.Location = new Point(9, 240);
            btnDirectorList.Margin = new Padding(3, 2, 3, 2);
            btnDirectorList.Name = "btnDirectorList";
            btnDirectorList.Size = new Size(679, 33);
            btnDirectorList.TabIndex = 1;
            btnDirectorList.Text = "YONETMENLERI LISTELE";
            btnDirectorList.UseVisualStyleBackColor = false;
            btnDirectorList.Click += btnDirectorList_Click;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Location = new Point(12, 9);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(571, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 26;
            lblYesilcamSinemaBilgiSistemi.Text = "YONETMENLER VE CALISTIKLARI OYUNCULAR";
            // 
            // Director
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(700, 293);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnDirectorList);
            Controls.Add(dgvDirectorList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Director";
            Text = "Director";
            Load += Director_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDirectorList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDirectorList;
        private Button btnDirectorList;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
namespace yesilcam_cinema_information_system
{
    partial class Actress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actress));
            dvgActors = new DataGridView();
            btnActressList = new Button();
            lblYesilcamSinemaBilgiSistemi = new Label();
            ((System.ComponentModel.ISupportInitialize)dvgActors).BeginInit();
            SuspendLayout();
            // 
            // dvgActors
            // 
            dvgActors.BackgroundColor = Color.FromArgb(255, 255, 128);
            dvgActors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgActors.Location = new Point(12, 61);
            dvgActors.Margin = new Padding(3, 2, 3, 2);
            dvgActors.Name = "dvgActors";
            dvgActors.RowHeadersWidth = 51;
            dvgActors.Size = new Size(679, 195);
            dvgActors.TabIndex = 0;
            dvgActors.CellContentClick += dvgActors_CellContentClick;
            // 
            // btnActressList
            // 
            btnActressList.BackColor = Color.FromArgb(255, 255, 128);
            btnActressList.FlatStyle = FlatStyle.Popup;
            btnActressList.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnActressList.Image = (Image)resources.GetObject("btnActressList.Image");
            btnActressList.ImageAlign = ContentAlignment.MiddleLeft;
            btnActressList.Location = new Point(12, 268);
            btnActressList.Margin = new Padding(3, 2, 3, 2);
            btnActressList.Name = "btnActressList";
            btnActressList.Size = new Size(679, 36);
            btnActressList.TabIndex = 1;
            btnActressList.Text = "OYUNCULARI LISTELE";
            btnActressList.UseVisualStyleBackColor = false;
            btnActressList.Click += btnActressList_Click;
            // 
            // lblYesilcamSinemaBilgiSistemi
            // 
            lblYesilcamSinemaBilgiSistemi.AutoSize = true;
            lblYesilcamSinemaBilgiSistemi.BackColor = Color.FromArgb(255, 255, 128);
            lblYesilcamSinemaBilgiSistemi.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblYesilcamSinemaBilgiSistemi.Location = new Point(12, 22);
            lblYesilcamSinemaBilgiSistemi.Name = "lblYesilcamSinemaBilgiSistemi";
            lblYesilcamSinemaBilgiSistemi.Size = new Size(429, 28);
            lblYesilcamSinemaBilgiSistemi.TabIndex = 27;
            lblYesilcamSinemaBilgiSistemi.Text = "OYUNCULARIN OYNADIGI FILMLER";
            // 
            // Actress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(700, 334);
            Controls.Add(lblYesilcamSinemaBilgiSistemi);
            Controls.Add(btnActressList);
            Controls.Add(dvgActors);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Actress";
            Text = "Oyuncular";
            Load += Actress_Load;
            ((System.ComponentModel.ISupportInitialize)dvgActors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgActors;
        private Button btnActressList;
        private Label lblYesilcamSinemaBilgiSistemi;
    }
}
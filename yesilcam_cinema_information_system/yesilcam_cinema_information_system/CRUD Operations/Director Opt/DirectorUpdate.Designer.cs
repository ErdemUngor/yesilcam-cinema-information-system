namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    partial class DirectorUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorUpdate));
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            lblDirectorGender = new Label();
            cmbGender = new ComboBox();
            lblDirectorDateBirth = new Label();
            dtpDirectorDateTime = new DateTimePicker();
            lblDirectorName = new Label();
            txtDirectorName = new TextBox();
            btnSelectedDirectorUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Arial Rounded MT Bold", 12F);
            label1.Location = new Point(31, 111);
            label1.Name = "label1";
            label1.Size = new Size(180, 18);
            label1.TabIndex = 18;
            label1.Text = "Yönetmen Ödül Sayısı";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(255, 255, 128);
            numericUpDown1.Location = new Point(252, 106);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(219, 23);
            numericUpDown1.TabIndex = 17;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblDirectorGender
            // 
            lblDirectorGender.AutoSize = true;
            lblDirectorGender.BackColor = Color.Gray;
            lblDirectorGender.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorGender.Location = new Point(31, 82);
            lblDirectorGender.Name = "lblDirectorGender";
            lblDirectorGender.Size = new Size(161, 18);
            lblDirectorGender.TabIndex = 16;
            lblDirectorGender.Text = "Yönetmen Cinsiyet:";
            // 
            // cmbGender
            // 
            cmbGender.BackColor = Color.FromArgb(255, 255, 128);
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(252, 77);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(219, 23);
            cmbGender.TabIndex = 15;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // lblDirectorDateBirth
            // 
            lblDirectorDateBirth.AutoSize = true;
            lblDirectorDateBirth.BackColor = Color.Gray;
            lblDirectorDateBirth.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorDateBirth.Location = new Point(31, 55);
            lblDirectorDateBirth.Name = "lblDirectorDateBirth";
            lblDirectorDateBirth.Size = new Size(195, 18);
            lblDirectorDateBirth.TabIndex = 14;
            lblDirectorDateBirth.Text = "Yönetmen Doğum Tarihi";
            // 
            // dtpDirectorDateTime
            // 
            dtpDirectorDateTime.Location = new Point(252, 50);
            dtpDirectorDateTime.Margin = new Padding(3, 2, 3, 2);
            dtpDirectorDateTime.Name = "dtpDirectorDateTime";
            dtpDirectorDateTime.Size = new Size(219, 23);
            dtpDirectorDateTime.TabIndex = 13;
            dtpDirectorDateTime.ValueChanged += dtpDirectorDateTime_ValueChanged;
            // 
            // lblDirectorName
            // 
            lblDirectorName.AutoSize = true;
            lblDirectorName.BackColor = Color.Gray;
            lblDirectorName.Font = new Font("Arial Rounded MT Bold", 12F);
            lblDirectorName.Location = new Point(31, 28);
            lblDirectorName.Name = "lblDirectorName";
            lblDirectorName.Size = new Size(181, 18);
            lblDirectorName.TabIndex = 12;
            lblDirectorName.Text = "Yönetmen Adı Soyadı:";
            // 
            // txtDirectorName
            // 
            txtDirectorName.BackColor = Color.FromArgb(255, 255, 128);
            txtDirectorName.Location = new Point(252, 23);
            txtDirectorName.Margin = new Padding(3, 2, 3, 2);
            txtDirectorName.Name = "txtDirectorName";
            txtDirectorName.Size = new Size(219, 23);
            txtDirectorName.TabIndex = 11;
            txtDirectorName.TextChanged += txtDirectorName_TextChanged;
            // 
            // btnSelectedDirectorUpdate
            // 
            btnSelectedDirectorUpdate.BackColor = Color.FromArgb(128, 255, 255);
            btnSelectedDirectorUpdate.FlatStyle = FlatStyle.Popup;
            btnSelectedDirectorUpdate.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectedDirectorUpdate.Image = (Image)resources.GetObject("btnSelectedDirectorUpdate.Image");
            btnSelectedDirectorUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectedDirectorUpdate.Location = new Point(31, 144);
            btnSelectedDirectorUpdate.Margin = new Padding(3, 2, 3, 2);
            btnSelectedDirectorUpdate.Name = "btnSelectedDirectorUpdate";
            btnSelectedDirectorUpdate.Size = new Size(440, 41);
            btnSelectedDirectorUpdate.TabIndex = 19;
            btnSelectedDirectorUpdate.Text = "Yönetmeni Güncelle";
            btnSelectedDirectorUpdate.UseVisualStyleBackColor = false;
            btnSelectedDirectorUpdate.Click += btnSelectedDirectorUpdate_Click;
            // 
            // DirectorUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(503, 204);
            Controls.Add(btnSelectedDirectorUpdate);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(lblDirectorGender);
            Controls.Add(cmbGender);
            Controls.Add(lblDirectorDateBirth);
            Controls.Add(dtpDirectorDateTime);
            Controls.Add(lblDirectorName);
            Controls.Add(txtDirectorName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DirectorUpdate";
            RightToLeftLayout = true;
            Text = "Seçili Yönetmeni Güncelle";
            Load += DirectorUpdate_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label lblDirectorGender;
        private ComboBox cmbGender;
        private Label lblDirectorDateBirth;
        private DateTimePicker dtpDirectorDateTime;
        private Label lblDirectorName;
        private TextBox txtDirectorName;
        private Button btnSelectedDirectorUpdate;
    }
}
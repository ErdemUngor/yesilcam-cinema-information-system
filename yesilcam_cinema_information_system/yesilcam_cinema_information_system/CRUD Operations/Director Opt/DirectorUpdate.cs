using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    public partial class DirectorUpdate : Form
    {
        private DirectorUpdate directorUpdate;
        private int selectedDirectorId;

        DataGridView dataGridView = new DataGridView();
        public DirectorUpdate(int directorId, DataGridView dataGridViews)
        {
            InitializeComponent();
            selectedDirectorId = directorId;
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Kadın");

            dataGridView = dataGridViews;
        }

        private void btnSelectedDirectorUpdate_Click(object sender, EventArgs e)
        {
            // Seçili oyuncunun bilgilerini al
            int directorId = selectedDirectorId;
            string directorName = txtDirectorName.Text;
            DateTime birthDate = dtpDirectorDateTime.Value;
            string gender = cmbGender.SelectedItem.ToString();
            int awardsCount = (int)numericUpDown1.Value;

            // ActressUpdate sınıfını kullanarak güncelleme işlemini gerçekleştir
            DirectorUpdates directorUpdate = new DirectorUpdates();
            directorUpdate.UpdateDirector(directorId, directorName, birthDate, gender, awardsCount, dataGridView);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDirectorDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDirectorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DirectorUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}

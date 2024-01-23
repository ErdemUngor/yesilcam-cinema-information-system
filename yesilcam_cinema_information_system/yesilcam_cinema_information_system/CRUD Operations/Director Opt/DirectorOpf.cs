using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yesilcam_cinema_information_system.Get;

namespace yesilcam_cinema_information_system.CRUD_Operations.Director_Opt
{
    public partial class DirectorOpf : Form
    {
        private GetDirector getDirector;

        public DirectorOpf()
        {
            InitializeComponent();
            getDirector = new GetDirector();
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Kadın");
            cmbGender.SelectedIndex = 0;
        }

        private void btnDirectorList_Click(object sender, EventArgs e)
        {
            LoadDirectors();
        }
        private void LoadDirectors()
        {
            dgvDirector.DataSource = getDirector.GetAllDirectors();
        }

        private void dgvDirector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblDirectorName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnActressAdd_Click(object sender, EventArgs e)
        {

            //Eklenicek yönetmen bilgilerini çekme.
            string directorName = txtDirectorName.Text;
            DateTime birthDate = dtpDirectorDateTime.Value;
            string gender = cmbGender.SelectedItem.ToString();
            int awardsCount = (int)numericUpDown1.Value;
            DirectorAdd directorAdd = new DirectorAdd();
            directorAdd.AddDirector(directorName, birthDate, gender, awardsCount);


        }

        private void btnSelectedDirectorRemove_Click(object sender, EventArgs e)
        {
            if (dgvDirector.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDirector.SelectedRows[0];
                int directorId = Convert.ToInt32(row.Cells["directorId"].Value);

                DirectorRemove directorRemove = new DirectorRemove();
                directorRemove.RemoveDirector(directorId);

                // Güncellenmiş yönetmen listesini gönder.
                GetDirector getDirector = new GetDirector();
                dgvDirector.DataSource = getDirector.GetAllDirectors();
            }
            else
            {
                MessageBox.Show("Lütfen bir yönetmen seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DirectorOpf_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectedDirectorUpdate_Click(object sender, EventArgs e)
        {
            // Seçili oyuncunun ID'sini al
            if (dgvDirector.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDirector.SelectedRows[0];
                int directorId = Convert.ToInt32(row.Cells["directorId"].Value);

                // ActressUpdates formunu oluştur ve seçili oyuncunun ID'sini aktar
                DirectorUpdate actressUpdates = new DirectorUpdate(directorId, dgvDirector);
                actressUpdates.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir yönetmen seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

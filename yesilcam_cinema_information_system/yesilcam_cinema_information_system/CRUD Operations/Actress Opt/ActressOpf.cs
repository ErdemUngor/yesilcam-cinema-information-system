using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using yesilcam_cinema_information_system.Get;


namespace yesilcam_cinema_information_system
{
    public partial class ActressOpf : Form
    {
        private DatabaseConnection dbConnection;
        public ActressOpf()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");

        }

        private void ActressOpf_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Kadın");
            cmbGender.SelectedIndex = 0;
        }

        private void btnActressList_Click(object sender, EventArgs e)
        {
            GetActors getActors = new GetActors();
            dvgActors.DataSource = getActors.GetAllActors();
        }

        private void dvgActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgActors.Rows[e.RowIndex];
                int actorId = Convert.ToInt32(row.Cells["actressId"].Value);
                ShowMoviesByActor(actorId);
            }
        }
        private void ShowMoviesByActor(int actorId)
        {
            GetActors getActors = new GetActors();
            dvgActors.DataSource = getActors.GetMoviesByActorId(actorId);
        }

        private void btnActressAdd_Click(object sender, EventArgs e)
        {
            string actressName = txtActressName.Text;
            string actressGeName = txtActressGeName.Text;
            DateTime birthDate = dtpActressDateTime.Value;// Burada uygun bir tarih girişi yapılmalıdır.
            string gender = cmbGender.SelectedItem.ToString(); // Varsayılan bir ComboBox'ı kullanıyorsanız, SelectedItem'i alabilirsiniz.
            int awardsCount = (int)nupAwardsCount.Value;
            ActressAdd actressAdd = new ActressAdd();
            actressAdd.AddActress(actressGeName, actressName, birthDate, gender, awardsCount);
        }


        private void txtActressGeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActressName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActressDateTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void nupAwardsCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblActressGeName_Click(object sender, EventArgs e)
        {

        }

        private void lblActressName_Click(object sender, EventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpActressDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnActressRemove_Click(object sender, EventArgs e)
        {
            if (dvgActors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvgActors.SelectedRows[0];
                int actressId = Convert.ToInt32(row.Cells["actressId"].Value);

                ActressRemove actressRemove = new ActressRemove();
                actressRemove.RemoveActress(actressId);

                // Güncellenmiş oyuncu listesini göster
                GetActors getActors = new GetActors();
                dvgActors.DataSource = getActors.GetAllActors();
            }
            else
            {
                MessageBox.Show("Lütfen bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActressUpdate_Click(object sender, EventArgs e)
        {
            // Seçili oyuncunun ID'sini al
            if (dvgActors.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvgActors.SelectedRows[0];
                int actressId = Convert.ToInt32(row.Cells["actressId"].Value);

                // ActressUpdates formunu oluştur ve seçili oyuncunun ID'sini aktar
                ActressUpdates actressUpdates = new ActressUpdates(actressId,dvgActors);
                actressUpdates.Show();
            }
            else
            {
                MessageBox.Show("Lütfen bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}

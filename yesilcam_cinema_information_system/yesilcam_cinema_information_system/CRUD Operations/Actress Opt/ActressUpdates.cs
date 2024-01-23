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

namespace yesilcam_cinema_information_system
{
    public partial class ActressUpdates : Form
    {
        private ActressUpdate actressUpdate;

        private int selectedActressId;

        DataGridView dataGridView = new DataGridView();
        public ActressUpdates(int actressId,DataGridView dataGridViews)
        {
            InitializeComponent();
            selectedActressId = actressId;
            cmbGender.Items.Add("Erkek");
            cmbGender.Items.Add("Kadın");
            
            dataGridView = dataGridViews;
        }

        private void ActressUpdates_Load(object sender, EventArgs e)
        {

        }

        private void txtActressGeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActressName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpActressDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nupAwardsCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectedActressUpdate_Click(object sender, EventArgs e)
        {
            // Seçili oyuncunun bilgilerini al
            int actressId = selectedActressId;
            string actressName = txtActressName.Text;
            string actressGeName = txtActressGeName.Text;
            DateTime birthDate = dtpActressDateTime.Value;
            string gender = cmbGender.SelectedItem.ToString();
            int awardsCount = (int)nupAwardsCount.Value;

            // ActressUpdate sınıfını kullanarak güncelleme işlemini gerçekleştir
            ActressUpdate actressUpdate = new ActressUpdate();
            actressUpdate.UpdateActress(actressId, actressName, actressGeName, birthDate, gender, awardsCount,dataGridView);
        }

    }
}

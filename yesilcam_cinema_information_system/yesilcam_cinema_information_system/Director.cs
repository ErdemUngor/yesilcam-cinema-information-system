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
    public partial class Director : Form
    {
        private GetDirector getDirector;

        public Director()
        {
            InitializeComponent();
            getDirector = new GetDirector();
            dgvDirectorList.DataSource = getDirector.GetAllDirectors();
        }

        // Director formundaki DataGridView'in yüklenme olayında çağrılacak kısım
        private void Director_Load(object sender, EventArgs e)
        {
            // Director DataGridView'inin verilerini getir
           
        }


        private void dgvDirectorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDirectorList.Rows[e.RowIndex];
                int directorId = Convert.ToInt32(row.Cells["directorId"].Value); // Assumes directorId is the name of the column containing the director ID

                DataTable collaboratedActorsTable = getDirector.GetCollaboratedActorsAndFilmCounts(directorId);

                // Daha sonra collaboratedActorsTable isimli DataTable'ı kullanarak başka bir DataGridView'e verileri aktarabilirsiniz.
                // Örnek olarak:

                dgvDirectorList.DataSource = collaboratedActorsTable;
            }
        }

        private void btnDirectorList_Click(object sender, EventArgs e)
        {
            LoadDirectors();
        }

        private void LoadDirectors()
        {
            dgvDirectorList.DataSource = getDirector.GetAllDirectors();
        }

        private void ShowCollaboratedActors(int directorId)
        {
            dgvDirectorList.DataSource = getDirector.GetCollaboratedActorsAndFilmCounts(directorId);
        }
    }
}

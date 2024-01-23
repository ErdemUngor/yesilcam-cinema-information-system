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
    public partial class Actress : Form
    {
        private DatabaseConnection dbConnection;

        public Actress()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            GetActors getActors = new GetActors();
            dvgActors.DataSource = getActors.GetAllActors();
        }

        private void Actress_Load(object sender, EventArgs e)
        {

        }

        private void dvgActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dvgActors.Rows[e.RowIndex];
                int actorId = Convert.ToInt32(row.Cells["actressId"].Value); // Assumes actressId is the name of the column containing the actress ID

                ShowMoviesByActor(actorId);
            }
           
        }
        private void ShowMoviesByActor(int actorId)
        {
            GetActors getActors = new GetActors();
            dvgActors.DataSource = getActors.GetMoviesByActorId(actorId);          
        }

        private void btnActressList_Click(object sender, EventArgs e)
        {
            GetActors getActors = new GetActors();
            dvgActors.DataSource = getActors.GetAllActors();
        }
    }
}

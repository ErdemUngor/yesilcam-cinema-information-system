using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using yesilcam_cinema_information_system.GetFunction;

namespace yesilcam_cinema_information_system
{
    public partial class Rating : Form
    {
        private DatabaseConnection dbConnection;
        private NpgsqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private RatingList ratingList;

        public Rating()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection("localhost", 5432, "yesilcamCinemaInformationSystem", "postgres", "erdem123");
            dataAdapter = new NpgsqlDataAdapter();
            dataSet = new DataSet();
            ratingList = new RatingList();
            ratingList.FillCategories(cmbCategory);
         
        }

        private void Rating_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex != -1)
            {
                int selectedCategoryId = Convert.ToInt32(cmbCategory.SelectedValue);

                // Veri setini temizle
                dataSet.Clear();

                // Seçilen kategoriye ait filmleri getir ve DataGridView'e yükle
                ratingList.FillDataGridView(dataGridView1, selectedCategoryId);
            }
        }   
    }
}

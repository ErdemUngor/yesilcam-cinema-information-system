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

namespace yesilcam_cinema_information_system
{
    public partial class OneMoreAct : Form
    {
        private OneMoreActress oneMoreActress;

        public OneMoreAct()
        {
            InitializeComponent();
            oneMoreActress = new OneMoreActress();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            DataTable actressesTable = oneMoreActress.GetActressesWithMovieCount();
            dataGridView1.DataSource = actressesTable;
        }

        private void OneMoreAct_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

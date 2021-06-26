using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PHP_SRaPS
{
    public partial class DisplayRecords : Form
    {
        public DisplayRecords()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.DBPATH);
            con.Open();
            DataTable dt = new DataTable();
            string q1 = "SELECT * FROM Sales";
            SqlDataAdapter cmd = new SqlDataAdapter(q1, con);
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;


            con.Close();
        }

        private void DisplayRecords_Load(object sender, EventArgs e)
        {
            // this.salesTableAdapter.Fill(this.pHPDatabaseDataSet.Sales);
        }
    }
}

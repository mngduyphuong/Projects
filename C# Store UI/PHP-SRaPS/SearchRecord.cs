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
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void button_search_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.DBPATH);
            con.Open();
            DataTable dt = new DataTable();
            int id = int.Parse(text_recordID.Text);
            string q1 = "SELECT * FROM Sales WHERE salesid LIKE " + id;
            SqlDataAdapter cmd = new SqlDataAdapter(q1, con);
            cmd.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

 

        private void SearchRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pHPDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            // this.salesTableAdapter.Fill(this.PHPDatabaseDataSet.Sales);
        }
    }
}

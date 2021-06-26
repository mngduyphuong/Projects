using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRaPS
{
    public partial class AddRecord : Form
    {
        public AddRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.DBPATH);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Sales VALUES (@name, @qty, @date)", con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@qty", int.Parse(quantity.Text));
            cmd.Parameters.AddWithValue("@date", salesdate.Value.Date);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("added record");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

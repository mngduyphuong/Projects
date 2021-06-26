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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        #region Labels and Text Boxes
        private void Label_RecordID_Click(object sender, EventArgs e) { /* Do nothing */ }
        private void Label_DeletionError_Click(object sender, EventArgs e) { /* Do nothing */ }
        private void Label_DeletionSuccess_Click(object sender, EventArgs e) { /* Do nothing */ }
        private void TextBox_RecordID_TextChanged(object sender, EventArgs e) { /* Do nothing */ }
        #endregion

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Constants.DBPATH);
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Sales WHERE salesid=@salesid", con);
            cmd.Parameters.AddWithValue("@salesid", TextBox_RecordID.Text);

            //SqlDataReader RecordExists = cmd.ExecuteReader();
            //if (RecordExists.HasRows)
            //{
            //    Label_DeletionError.Text = " ";
            //    Label_DeletionError.Refresh();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted record");
            //}
            //else
            //{
            //    Label_DeletionError.ForeColor = System.Drawing.Color.Red;
            //    Label_DeletionError.Text = "Could not find record.";
            //    Label_DeletionError.Refresh();
            //}
        }
    }
}

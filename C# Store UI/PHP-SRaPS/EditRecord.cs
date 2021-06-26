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
    public partial class EditRecord : Form
    {
        public EditRecord()
        {
            InitializeComponent();
        }

        public string[] GetRecordValues(string recordID)
        {
            string recordNumber, productID, productName, price, quantity, dateBought;

            string[] recordValues = new string[6];

            // Open a connection
            SqlConnection con = new SqlConnection(Constants.DBPATH); 
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Sales WHERE salesid = @salesid", con);

            cmd.Parameters.AddWithValue("@salesid", recordID);

            // Execute query
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();

            List<string> list = new List<string>();

            while (reader.Read())
            {
                string recNumber = reader.GetInt32(0).ToString();
                string proName = reader.GetString(1);
                string quan = reader.GetInt32(2).ToString();
                string date = reader.GetDateTime(3).ToString();

                list.Add(recNumber);
                list.Add(proName);
                list.Add(quan);
                list.Add(date);
            }
            reader.Close();

            // Assign values to variables. Null placeholders at the moment.
            recordNumber = list[0];
            productID = null;
            productName = list[1];
            price = null;
            quantity = list[2];
            dateBought = list[3];

            // Close connection
            con.Close();

            // Put variables in Array
            recordValues[0] = recordNumber;
            recordValues[1] = productID;
            recordValues[2] = productName;
            recordValues[3] = price;
            recordValues[4] = quantity;
            recordValues[5] = dateBought;

            // Return Array
            return recordValues;
        }

        public void PopulateRecord(string[] recordValues)
        {
            // Use recordValues to populate the data fields.
            label_recordNum.Text = recordValues[0];
            text_productName.Text = recordValues[2];
            text_quantity.Text = recordValues[4];
            text_dateBought.Text = recordValues[5];
        }

        private void button_updateRecord_Click(object sender, EventArgs e)
        {
            // Open a connection
            SqlConnection con = new SqlConnection(Constants.DBPATH); 
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Sales SET productname = @name, quantity = @qty, salesdate = @date WHERE salesid = @salesid", con);

            // Get current data in fields
            cmd.Parameters.AddWithValue("@salesid", label_recordNum.Text);
            cmd.Parameters.AddWithValue("@name", text_productName.Text);
            cmd.Parameters.AddWithValue("@qty", int.Parse(text_quantity.Text));
            cmd.Parameters.AddWithValue("@date", text_dateBought.Value.ToString("MM/dd/yyyy"));

            // Send to the database
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Record");
        }

        private void button_searchRecord_Click(object sender, EventArgs e)
        {
            // Get recordID
            string recordID = text_searchRecordID.Text;

            // Get values
            string[] recordValues = GetRecordValues(recordID);

            // Populate record
            PopulateRecord(recordValues);
        }
    }
}

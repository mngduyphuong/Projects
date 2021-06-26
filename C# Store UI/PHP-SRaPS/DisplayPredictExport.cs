using DataTableExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PHP_SRaPS
{
    public partial class DisplayPredictExport : Form
    {
        public DisplayPredictExport()
        {
            InitializeComponent();
        }

        private void DisplayPredictExport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newPHPDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter1.Fill(this.newPHPDatabaseDataSet.Sales);
            // TODO: This line of code loads data into the 'pHPDatabaseDataSet.Sales' table. You can move, or remove it, as needed.
            // this.salesTableAdapter.Fill(this.pHPDatabaseDataSet.Sales);

            label_predictionsNotBought.Text = "";
            label_notBuyProduct1.Text = "";
            label_notBuyProduct2.Text = "";
            label_notBuyProduct3.Text = "";
        }

        private void dataGrid_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_exportToCSV_Click(object sender, EventArgs e)
        {
               SqlConnection con = new SqlConnection(Constants.DBPATH);
                 con.Open();
                 DataTable dt = new DataTable();
            //     int id = int.Parse(text_recordID.Text);
                string q1 = "SELECT * FROM Sales";
              SqlDataAdapter cmd = new SqlDataAdapter(q1, con);
             cmd.Fill(dt);
             



            /*  string datetime = DateTime.Now.ToString("yyyyMddHHmmss");
              string fileName = Constants.CSVFilePath + datetime + ".csv";

            //  string fileName = @"C:\PHPReport\SalesReport" + datetime + ".csv";
              string str = "Prod1, 2, 15/10/2020\nProd2, 3, 15/10/2020\nProd3, 5, 16/10/2020";
              System.IO.File.WriteAllText(fileName, str);
              MessageBox.Show("File" + fileName + " created.");
              */

            string filename = OpenSaveFileDialog();
            dt.ToCSV(filename);
            con.Close();
        }

        private string OpenSaveFileDialog()
        {
            string Filename = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "Excel|*.xls";
            saveFileDialog.Filter = "csv File|*.csv";
            saveFileDialog.Title = "Save Report";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Filename = saveFileDialog.FileName;

            }

            return Filename;

        }

        private void button_predict_Click_1(object sender, EventArgs e)
        {
            // Get Dates
            // DateTime startDate = DateTime.Parse(text_startDate.Text);
            // DateTime endDate = DateTime.Parse(text_endDate.Text);
            

           String startDateStr = date_start.Value.ToString("MM/dd/yyyy");
           String endDateStr = date_end.Value.Date.ToString("MM/dd/yyyy");

            DataTable dataTable = new DataTable();

            // Connect to the Database
            SqlConnection con = new SqlConnection(Constants.DBPATH);
            con.Open();

            // Create the Query
            String query = "SELECT * FROM Sales WHERE salesdate BETWEEN '" + startDateStr + "' and '" + endDateStr +"'";
            //String query = "SELECT * FROM Sales WHERE salesdate BETWEEN '10/16/2020' and '10/21/2020'" ;
            SqlDataAdapter cmd = new SqlDataAdapter(query, con);

            // SqlDataAdapter cmd = new SqlDataAdapter("SELECT * FROM Sales WHERE salesdate BETWEEN @Date1 and @Date2", con);
            //cmd.SelectCommand.Parameters.Add(new SqlParameter("@Date1", date_start.Value.Date.ToShortDateString()));
            //cmd.SelectCommand.Parameters.Add(new SqlParameter("@Date1", date_end.Value.Date.ToShortDateString()));

            // Display the Data

            cmd.Fill(dataTable);
            dataGrid_display.DataSource = dataTable;

            // Prediction algorithm
            string[] labels = new string[3];
            string altQuery = "SELECT productname, SUM(quantity) AS total FROM Sales WHERE salesdate BETWEEN '" + startDateStr + "' and '" + endDateStr + "' GROUP BY productname ORDER BY total";
            SqlCommand command = new SqlCommand(altQuery, con);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    do
                    {
                        int count = reader.FieldCount;
                        while (reader.Read())
                        {
                            for (int i = 0; i < count; i++)
                            {
                                labels[i] = reader.GetValue(i).ToString();
                            }
                        }
                    } while (reader.NextResult());
                    label_buyProduct1.Text = labels[0] + ": " + labels[1];
                    // label_buyProduct2.Text = labels[1];
                    // label_buyProduct3.Text = labels[2];
                    label_buyProduct2.Text = " ";
                    label_buyProduct3.Text = " ";
                }
            }
            con.Close();
        }
    }
}

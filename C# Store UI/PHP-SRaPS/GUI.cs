using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHP_SRaPS
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

     

        private void AddRecord_Click(object sender, EventArgs e)
        {
            AddRecord add = new AddRecord();
            add.Show();
        }

        private void DisplayRecord_Click_1(object sender, EventArgs e)
        {
            DisplayRecords d = new DisplayRecords();
            d.Show();
        }

        private void EditRecord_Click(object sender, EventArgs e)
        {
            EditRecord edit = new EditRecord();
            edit.Show();
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DeleteRecord delete = new DeleteRecord();
            delete.Show();
        }

        private void SearchRecord_Click(object sender, EventArgs e)
        {
            SearchRecord s = new SearchRecord();
            s.Show();
        }

        private void choose_Click(object sender, EventArgs e)
        {

        }

        private void button_predictions_Click(object sender, EventArgs e)
        {
            DisplayPredictExport dpe = new DisplayPredictExport();
            dpe.Show();
        }

        private void displayRecord_Click(object sender, EventArgs e)
        {
            DisplayRecords record = new DisplayRecords();
            record.Show();
        }
    }

    public static class Constants
    {
        //change the db path to the new one :))

        // shana
        //public const string DBPATH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\shana\Documents\year2sem2\dev2\code4\PHP-SRaPS\PHP-SRaPS\newPHPDatabase.mdf;Integrated Security=True";
        //public const string CSVFilePath = @"C:\Users\shana\Documents\year2sem2\dev2\code4\PHP-SRaPS\PHP-SRaPS\SalesReport";
        //change the db path to the new one :))

        // L
        public const string DBPATH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Linden\Source\Repos\PHP-SRaPS-DP2\PHP-SRaPS\PHP-SRaPS\newPHPDatabase.mdf;Integrated Security=True";
        public const string CSVFilePath = @"C:\Users\Linden\Documents";

        // Evan
        //public const string DBPATH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\Y4S2\SWE30010\_PROJECT\PHP-SRaPS-DP2\PHP-SRaPS\PHP-SRaPS\PHPDB.mdf;Integrated Security=True";

        //Phuong
        //public const string DBPATH = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive - Swinburne University\Documents\Study\Third year\Sem 2\DP2\Project2\PHP-SRaPS\PHP-SRaPS\newPHPDatabase.mdf;Integrated Security=True";

    }

    
}

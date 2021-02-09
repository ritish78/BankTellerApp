using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BankTellerApplication
{
    public partial class AllRecords : Form
    {
        public AllRecords()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();
        string filePath = FilePath.DB_PATH;

        private void AllRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDBDataSet.CustomerInfo' table. You can move, or remove it, as needed.
            //this.customerInfoTableAdapter.Fill(this.customerDBDataSet.CustomerInfo);
            //Adding columns to datatable
            table.Columns.Add("Account No", typeof(int));
            table.Columns.Add("Account Name", typeof(string));
            table.Columns.Add("Balance", typeof(Double));

            dataGridView1.DataSource = table;

            
            string[] lines = File.ReadAllLines(filePath);
            string[] pieces;
            foreach(string line in lines)
            {
                pieces = line.Split(',');
                string[] row = new string[pieces.Length];

                for (int i = 0; i < pieces.Length; i++)
                {
                    row[i] = pieces[i];
                }
                table.Rows.Add(row);
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

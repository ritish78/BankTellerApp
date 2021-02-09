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
    public partial class EditRecords : Form
    {
        string filePath;
        List<string> lines;
        public EditRecords()
        {
            InitializeComponent();
            lines = new List<string>();
            filePath = FilePath.DB_PATH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] all = File.ReadAllLines(filePath);
            foreach (string line in all)
            {
                lines.Add(line);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void btn_Search_Click(object sender, EventArgs e)
        {
            btn_SaveChanges.Enabled = false;
            string[] all = File.ReadAllLines(filePath);
            foreach (string line in all)
            {
                lines.Add(line);
            }
           
            string[] pieces;

            foreach(string line in lines)
            {
                pieces = line.Split(',');
                if (pieces[0].Equals(txtBox_AccountNo.Text)){
                    txtBox_AccountName.Text = pieces[1];
                    txtBox_Balance.Text = pieces[2];
                    btn_Edit.Enabled = true;
                    break;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            txtBox_AccountNo.Enabled = false;
            if (txtBox_AccountName.Text.Equals(string.Empty))
            {
                return;
            }
            txtBox_AccountName.Enabled = true;
            txtBox_Balance.Enabled = true;
            btn_SaveChanges.Enabled = true;
            btn_Search.Enabled = false;
        }

        private void btn_SaveChanges_Click(object sender, EventArgs e)
        {
            string[] pieces;
            string newLine;
            List<string> newLines = new List<string>();
            foreach (string line in lines)
            {
                pieces = line.Split(',');
                if (txtBox_AccountNo.Text.Equals(pieces[0]))
                {
                    newLine = txtBox_AccountNo.Text + "," + txtBox_AccountName.Text + "," + txtBox_Balance.Text;
                }
                else
                {
                    newLine = pieces[0] + "," + pieces[1] + "," + pieces[2];
                }
                newLines.Add(newLine);
            }
            File.WriteAllLines(filePath, newLines);
            btn_SaveChanges.Enabled = false;
            txtBox_AccountNo.Enabled = true;
            txtBox_AccountName.Enabled = false;
            txtBox_Balance.Enabled = false;
            btn_Search.Enabled = true;
            btn_Edit.Enabled = false;
        }
    }
}

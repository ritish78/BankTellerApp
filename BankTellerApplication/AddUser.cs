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
    public partial class AddUser : Form
    {
        string filePath = FilePath.DB_PATH;

        public AddUser()
        {
            InitializeComponent();


        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            if (txtBox_AccountName.Text != string.Empty && txtBox_AccountNo.Text != null && txtBox_Balance.Text != null)
            {
                try
                {
                    string details = txtBox_AccountNo.Text + "," + txtBox_AccountName.Text + "," + txtBox_Balance.Text + "\n";
              
                    File.AppendAllText(filePath, details);
                    MessageBox.Show("User added successfully!", "User added!");

                    txtBox_AccountNo.Text = string.Empty;
                    txtBox_AccountName.Text = string.Empty;
                    txtBox_Balance.Text = string.Empty;

                }
                catch(IOException exep)
                {
                    MessageBox.Show("Exception occured while saving the details: {e}", exep.Message);
                }
            }
        }
    }
}

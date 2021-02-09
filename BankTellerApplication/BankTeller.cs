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
    public partial class BankTeller : Form
    {
        private List<String> lines = new List<string>();
        private string filePath;

        public BankTeller()
        {
            InitializeComponent();
            //lines = new List<string>();
            filePath = FilePath.DB_PATH;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string runningPath = AppDomain.CurrentDomain.BaseDirectory;

            if (File.Exists(filePath))
            {
                string[] all = File.ReadAllLines(filePath);
                
                foreach(string line in all)
                {
                    lines.Add(line);
                }
            }
            else
            {
                //txtBox_Balance.Text = "Doesn't Exist";
                MessageBox.Show("File Not found!", "Path Error");
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            string accountNo;
            string accountName;
            double accountBalance;

            //looping around all the lines of the data file
            foreach(string line in lines)
            {
                //separating each lines by comma as our data is in format 
                //(AccountNo,Account Name,AccountBalance)
                string[] pieces = line.Split(',');

                //first element of array is account number, then account name and balance.
                accountNo = pieces[0];
                accountName = pieces[1];
                accountBalance = Convert.ToDouble(pieces[2]);
                
                //Now checking if the account number specified is in our database
                if (accountNo.Equals(txtBox_AccountNo.Text))
                {
                    txtBox_AccountName.Text = accountName;
                    txtBox_Balance.Text = accountBalance.ToString();
                    break;
                }
                else
                {
                    /*
                        If we find an account, the above code shows the balance in the text box
                    However, in next time, if we don't find the account provided, the text box
                    will hold the account name and balance. So, we need to clear account details
                    if we don't find the account.
                    */
                    txtBox_AccountName.Text = string.Empty;
                    txtBox_Balance.Text = string.Empty;
                }

            }
        }

        private void radiobtn_Deposit_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Amount.Visible = true;
            txtBox_Amount.Visible = true;
        }

        private void radiobtn_Withdraw_CheckedChanged(object sender, EventArgs e)
        {
            lbl_Amount.Visible = true;
            txtBox_Amount.Visible = true;
        }

        private void txtBox_Option_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Totals_Click(object sender, EventArgs e)
        {
            if (radiobtn_Deposit.Checked && !txtBox_AccountName.Equals(string.Empty))
            {
                if (!txtBox_Balance.Text.Equals(string.Empty))
                {
                    accountDeposit();
                }
            }else if (radiobtn_Withdraw.Checked && !txtBox_AccountName.Equals(string.Empty))
            {
                if (!txtBox_Balance.Text.Equals(string.Empty))
                {
                    accountWithdraw();
                }
            }
        }


        //A method to deposit money into the account
        public void accountDeposit()
        {
            double depositAmount = Convert.ToDouble(txtBox_Amount.Text);
            double newAmount;
            /*
            foreach (string line in lines)
            {
                string[] pieces = line.Split(',');
                if (txtBox_AccountNo.Equals(pieces[0]))
                {
                    newAmount = Convert.ToDouble(pieces[2]) + depositAmount;
                    lbl_Amount.Text = newAmount.ToString();
                    break;
                }
            }
            */
            newAmount = Convert.ToDouble(txtBox_Balance.Text) + depositAmount;
            txtBox_Balance.Text = newAmount.ToString();

            //Resetting the value of amount textbox so that if we mistakely click on 'Totals'
            //button, we won't add to the amount again
            txtBox_Amount.Text = "0";

            //Now, writing the new balance in the file.
            //First, we create another list and we write it with new amount and then write the file
            List<string> newLines = new List<string>();
            string newLine;
            foreach(string line in lines)
            {
                string[] pieces = line.Split(',');
                if (pieces[0].Equals(txtBox_AccountNo.Text))
                {
                    newLine = pieces[0] + "," + pieces[1] + "," + newAmount;
                }
                else
                {
                    newLine = pieces[0] + "," + pieces[1] + "," + pieces[2];
                }
                newLines.Add(newLine);
            }
            File.WriteAllLines(filePath, newLines);
        }

        public void accountWithdraw()
        {
            double withdrawAmount = Convert.ToDouble(txtBox_Amount.Text);
            double newAmount;

            if (withdrawAmount > Convert.ToDouble(txtBox_Balance.Text))
            {
                txtBox_Amount.Text = "0";
                MessageBox.Show("Can't withdraw money more than the actual balance", "Withdraw error");
                return;
           
            }

            newAmount = Convert.ToDouble(txtBox_Balance.Text) - withdrawAmount;
            txtBox_Balance.Text = newAmount.ToString();

            //Resetting the value of amount textbox so that if we mistakely click on 'Totals'
            //button, we won't withdraw  the amount again
            txtBox_Amount.Text = "0";

            //Now, writing the new balance in the file.
            //First, we create another list and we write it with new amount and then write the file
            List<string> newLines = new List<string>();
            string newLine;
            foreach (string line in lines)
            {
                string[] pieces = line.Split(',');
                if (pieces[0].Equals(txtBox_AccountNo.Text))
                {
                    newLine = pieces[0] + "," + pieces[1] + "," + newAmount;
                }
                else
                {
                    newLine = pieces[0] + "," + pieces[1] + "," + pieces[2];
                }
                newLines.Add(newLine);
            }
            File.WriteAllLines(filePath, newLines);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtBox_AccountNo.Text = string.Empty;
            txtBox_AccountName.Text = string.Empty;
            txtBox_Amount.Text = string.Empty;
            txtBox_Balance.Text = string.Empty;
            radiobtn_Deposit.Checked = false;
            radiobtn_Withdraw.Checked = false;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TotalBalance_Click(object sender, EventArgs e)
        {
            AllRecords allRecords = new AllRecords();
            allRecords.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditRecords editRecords = new EditRecords();
            editRecords.ShowDialog();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.ShowDialog();
        }
    }
}

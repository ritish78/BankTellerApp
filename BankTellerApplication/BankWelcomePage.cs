using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTellerApplication
{
    public partial class BankWelcomePage : Form
    {
        public BankWelcomePage()
        {
            InitializeComponent();
            
        }

        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl_correct.Visible = false;
            if (txtBox_UserName.Text.ToLower().Equals("admin"))
            {
                if (txtBox_Password.Text.ToLower().Equals("root"))
                {
                    BankTeller bankTeller = new BankTeller();
                    bankTeller.ShowDialog();
                }
                else
                {
                    lbl_correct.Visible = true;
                    lbl_correct.Text = "The password is incorrect!";
                }
            }
            else
            {
                lbl_correct.Visible = true;
                lbl_correct.Text = "For demonstration purposes \n user name is admin and  \n password is root.";
         
            }
            
        }
    }
}

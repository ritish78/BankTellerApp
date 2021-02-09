namespace BankTellerApplication
{
    partial class BankTeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankTeller));
            this.lbl_AccountNo = new System.Windows.Forms.Label();
            this.lbl_AccountName = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.txtBox_AccountNo = new System.Windows.Forms.TextBox();
            this.txtBox_AccountName = new System.Windows.Forms.TextBox();
            this.txtBox_Balance = new System.Windows.Forms.TextBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gb_SelectOption = new System.Windows.Forms.GroupBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.txtBox_Amount = new System.Windows.Forms.TextBox();
            this.radiobtn_Withdraw = new System.Windows.Forms.RadioButton();
            this.radiobtn_Deposit = new System.Windows.Forms.RadioButton();
            this.btn_Totals = new System.Windows.Forms.Button();
            this.btn_TotalBalance = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.gb_SelectOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_AccountNo
            // 
            this.lbl_AccountNo.AutoSize = true;
            this.lbl_AccountNo.Location = new System.Drawing.Point(53, 46);
            this.lbl_AccountNo.Name = "lbl_AccountNo";
            this.lbl_AccountNo.Size = new System.Drawing.Size(85, 17);
            this.lbl_AccountNo.TabIndex = 0;
            this.lbl_AccountNo.Text = "Account No:";
            // 
            // lbl_AccountName
            // 
            this.lbl_AccountName.AutoSize = true;
            this.lbl_AccountName.Location = new System.Drawing.Point(56, 82);
            this.lbl_AccountName.Name = "lbl_AccountName";
            this.lbl_AccountName.Size = new System.Drawing.Size(104, 17);
            this.lbl_AccountName.TabIndex = 1;
            this.lbl_AccountName.Text = "Account Name:";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(513, 81);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(63, 17);
            this.lbl_Balance.TabIndex = 2;
            this.lbl_Balance.Text = "Balance:";
            // 
            // txtBox_AccountNo
            // 
            this.txtBox_AccountNo.Location = new System.Drawing.Point(181, 40);
            this.txtBox_AccountNo.Name = "txtBox_AccountNo";
            this.txtBox_AccountNo.Size = new System.Drawing.Size(181, 22);
            this.txtBox_AccountNo.TabIndex = 3;
            // 
            // txtBox_AccountName
            // 
            this.txtBox_AccountName.Enabled = false;
            this.txtBox_AccountName.Location = new System.Drawing.Point(181, 76);
            this.txtBox_AccountName.Name = "txtBox_AccountName";
            this.txtBox_AccountName.Size = new System.Drawing.Size(181, 22);
            this.txtBox_AccountName.TabIndex = 4;
            // 
            // txtBox_Balance
            // 
            this.txtBox_Balance.Enabled = false;
            this.txtBox_Balance.Location = new System.Drawing.Point(582, 77);
            this.txtBox_Balance.Name = "txtBox_Balance";
            this.txtBox_Balance.Size = new System.Drawing.Size(125, 22);
            this.txtBox_Balance.TabIndex = 5;
            // 
            // btn_Find
            // 
            this.btn_Find.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Find.Location = new System.Drawing.Point(489, 26);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(77, 37);
            this.btn_Find.TabIndex = 6;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(582, 26);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(78, 37);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // gb_SelectOption
            // 
            this.gb_SelectOption.Controls.Add(this.lbl_Amount);
            this.gb_SelectOption.Controls.Add(this.txtBox_Amount);
            this.gb_SelectOption.Controls.Add(this.radiobtn_Withdraw);
            this.gb_SelectOption.Controls.Add(this.radiobtn_Deposit);
            this.gb_SelectOption.Location = new System.Drawing.Point(59, 163);
            this.gb_SelectOption.Name = "gb_SelectOption";
            this.gb_SelectOption.Size = new System.Drawing.Size(416, 179);
            this.gb_SelectOption.TabIndex = 8;
            this.gb_SelectOption.TabStop = false;
            this.gb_SelectOption.Text = "Select an option";
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(185, 84);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(60, 17);
            this.lbl_Amount.TabIndex = 3;
            this.lbl_Amount.Text = "Amount:";
            this.lbl_Amount.Visible = false;
            // 
            // txtBox_Amount
            // 
            this.txtBox_Amount.Location = new System.Drawing.Point(251, 81);
            this.txtBox_Amount.Name = "txtBox_Amount";
            this.txtBox_Amount.Size = new System.Drawing.Size(145, 22);
            this.txtBox_Amount.TabIndex = 2;
            this.txtBox_Amount.Visible = false;
            this.txtBox_Amount.TextChanged += new System.EventHandler(this.txtBox_Option_TextChanged);
            // 
            // radiobtn_Withdraw
            // 
            this.radiobtn_Withdraw.AutoSize = true;
            this.radiobtn_Withdraw.Location = new System.Drawing.Point(20, 106);
            this.radiobtn_Withdraw.Name = "radiobtn_Withdraw";
            this.radiobtn_Withdraw.Size = new System.Drawing.Size(87, 21);
            this.radiobtn_Withdraw.TabIndex = 1;
            this.radiobtn_Withdraw.Text = "Withdraw";
            this.radiobtn_Withdraw.UseVisualStyleBackColor = true;
            this.radiobtn_Withdraw.CheckedChanged += new System.EventHandler(this.radiobtn_Withdraw_CheckedChanged);
            // 
            // radiobtn_Deposit
            // 
            this.radiobtn_Deposit.AutoSize = true;
            this.radiobtn_Deposit.Location = new System.Drawing.Point(20, 55);
            this.radiobtn_Deposit.Name = "radiobtn_Deposit";
            this.radiobtn_Deposit.Size = new System.Drawing.Size(77, 21);
            this.radiobtn_Deposit.TabIndex = 0;
            this.radiobtn_Deposit.Text = "Deposit";
            this.radiobtn_Deposit.UseVisualStyleBackColor = true;
            this.radiobtn_Deposit.CheckedChanged += new System.EventHandler(this.radiobtn_Deposit_CheckedChanged);
            // 
            // btn_Totals
            // 
            this.btn_Totals.Location = new System.Drawing.Point(582, 174);
            this.btn_Totals.Name = "btn_Totals";
            this.btn_Totals.Size = new System.Drawing.Size(136, 34);
            this.btn_Totals.TabIndex = 9;
            this.btn_Totals.Text = "Totals";
            this.btn_Totals.UseVisualStyleBackColor = true;
            this.btn_Totals.Click += new System.EventHandler(this.btn_Totals_Click);
            // 
            // btn_TotalBalance
            // 
            this.btn_TotalBalance.Location = new System.Drawing.Point(582, 228);
            this.btn_TotalBalance.Name = "btn_TotalBalance";
            this.btn_TotalBalance.Size = new System.Drawing.Size(136, 36);
            this.btn_TotalBalance.TabIndex = 10;
            this.btn_TotalBalance.Text = "Total Balance";
            this.btn_TotalBalance.UseVisualStyleBackColor = true;
            this.btn_TotalBalance.Click += new System.EventHandler(this.btn_TotalBalance_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(582, 284);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(136, 38);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(678, 25);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(79, 37);
            this.btn_Edit.TabIndex = 12;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(582, 343);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(136, 40);
            this.btn_AddUser.TabIndex = 13;
            this.btn_AddUser.Text = "Add User";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // BankTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AddUser);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_TotalBalance);
            this.Controls.Add(this.btn_Totals);
            this.Controls.Add(this.gb_SelectOption);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.txtBox_Balance);
            this.Controls.Add(this.txtBox_AccountName);
            this.Controls.Add(this.txtBox_AccountNo);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_AccountName);
            this.Controls.Add(this.lbl_AccountNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BankTeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Teller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_SelectOption.ResumeLayout(false);
            this.gb_SelectOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AccountNo;
        private System.Windows.Forms.Label lbl_AccountName;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.TextBox txtBox_AccountNo;
        private System.Windows.Forms.TextBox txtBox_AccountName;
        private System.Windows.Forms.TextBox txtBox_Balance;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.GroupBox gb_SelectOption;
        private System.Windows.Forms.RadioButton radiobtn_Withdraw;
        private System.Windows.Forms.RadioButton radiobtn_Deposit;
        private System.Windows.Forms.Button btn_Totals;
        private System.Windows.Forms.Button btn_TotalBalance;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TextBox txtBox_Amount;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_AddUser;
    }
}


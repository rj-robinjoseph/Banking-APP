using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CD_Account_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GetCDData(CDAccount account)
        {
            decimal _interestRate;
            decimal _balance;

            account.accountNumber = accountNumberTextBox.Text;
            account.maturityDate= maturityDateTextBox.Text;

            if(decimal.TryParse(interestRateTextBox.Text, out _interestRate) )
            {
                account.interestRate = _interestRate;

                if(decimal.TryParse(balanceTextBox.Text, out _balance) )
                {
                    account.balance = _balance;
                }
                else
                {
                    MessageBox.Show("Invalid Balance");
                }
            }
            else
            {
                MessageBox.Show("Invalid Interest Rate");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CDAccount ac1 = new CDAccount();

            GetCDData(ac1);

            accountNumberLabel.Text = ac1.accountNumber;
            interestRateLabel.Text = ac1.interestRate.ToString();
            balanceLabel.Text = ac1.balance.ToString();
            maturityDateLabel.Text = ac1.maturityDate;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

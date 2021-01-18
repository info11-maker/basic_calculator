using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basic_calculator
{
    public partial class Form1 : Form
    {
        String operation = "";
        Double FirstNum, SecondNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (TxtDisplay.Text == "0")
                TxtDisplay.Text = "";
            if(b.Text == ",")
            {
                if (!TxtDisplay.Text.Contains(","))
                    TxtDisplay.Text = TxtDisplay.Text + b.Text;
            }
            else
            {
                TxtDisplay.Text = TxtDisplay.Text + b.Text;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = "0";

            String f, s;

            s = Convert.ToString(SecondNum);
            f = Convert.ToString(FirstNum);

            s = "";
            f = "";
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            FirstNum = Double.Parse(TxtDisplay.Text.ToString());
            operation = b.Text;
            TxtDisplay.Text = "";
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            SecondNum = double.Parse(TxtDisplay.Text);
            switch (operation)
            {
                case "+":
                    TxtDisplay.Text = Convert.ToString(FirstNum + SecondNum);
                    break;
                case "-":
                    TxtDisplay.Text = Convert.ToString(FirstNum - SecondNum);
                    break;
                case "*":
                    TxtDisplay.Text = Convert.ToString(FirstNum * SecondNum);
                    break;
                case "/":
                    TxtDisplay.Text = Convert.ToString(FirstNum / SecondNum);
                    break;
                default:
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

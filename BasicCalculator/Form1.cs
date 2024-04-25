namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        private decimal valueOne = 0.0m;
        private decimal valueTwo = 0.0m;
        private decimal result = 0.0m;

        private string operators = "+";

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text += "0";
            }

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("0"))
            {
                txtDisplay.Text += ".";
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            valueOne = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operators = "-";

        }

        private void btnMinusPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
            {
                txtDisplay.Text = txtDisplay.Text.Trim('-');
            }
            else
            {
                txtDisplay.Text = "-" + txtDisplay.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            valueOne = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operators = "+";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            valueOne = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operators = "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            valueOne = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operators = "*";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            valueOne = decimal.Parse(txtDisplay.Text);
            txtDisplay.Clear();
            operators = "*";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueTwo = decimal.Parse(txtDisplay.Text);
                    result = valueOne - valueTwo;
                    txtDisplay.Text = result.ToString();
                    break;
                case "+":
                    valueTwo = decimal.Parse(txtDisplay.Text);
                    result = valueOne + valueTwo;
                    txtDisplay.Text = result.ToString();
                    break;
                case "/":
                    valueTwo = decimal.Parse(txtDisplay.Text);
                    result = valueOne / valueTwo;
                    txtDisplay.Text = result.ToString();
                    break;
                case "*":
                    valueTwo = decimal.Parse(txtDisplay.Text);
                    result = valueOne * valueTwo;
                    txtDisplay.Text = result.ToString();
                    break;
                case "%":
                    valueTwo = decimal.Parse(txtDisplay.Text);
                    result = valueOne % valueTwo;
                    txtDisplay.Text = result.ToString();
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            valueOne = 0.0m;
            valueTwo = 0.0m;
            result = 0.0m;

            txtDisplay.Text = "0";

        }
    }
}

namespace LastPrttyp
{
    public partial class Form1 : Form
    {
        private void EmptyorNull()
        {
            if(string.IsNullOrWhiteSpace(lblNumber.Text))
    {
                // Handle the case when lblNumber.Text is null or empty
                MessageBox.Show("Please enter a number before clicking the operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                lblNumber.Text = "0";
            }
    }
        private void num1(String num1)
        {
            if (!(num1 == "." && lblNumber.Text.Contains(".")))
            {
                lblNumber.Text = lblNumber.Text + num1;
            }
        }
        private double lblNum2;
        private String functions;

        private void operators(String op)
        {
            lblNumber.Text = string.Empty;
            functions = op;
        }
        private void number(String number)
        {
            lblNumber.Text = lblNumber.Text + number;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            number("0");
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            number("1");
        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
            number("2");
        }

        private void guna2CircleButton10_Click(object sender, EventArgs e)
        {
            number("3");
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            number("4");
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            number("5");
        }

        private void guna2CircleButton11_Click(object sender, EventArgs e)
        {
            number("6");
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            number("7");
        }

        private void guna2CircleButton8_Click(object sender, EventArgs e)
        {
            number("8");
        }

        private void guna2CircleButton12_Click(object sender, EventArgs e)
        {
            number("9");
        }

        private void guna2CircleButton13_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            switch (functions)
            {
                case "+":
                    lblNumber.Text = (double.Parse(lblNumber.Text) + lblNum2).ToString();
                    break;
                case "-":
                    lblNumber.Text = (lblNum2 - double.Parse(lblNumber.Text)).ToString();
                    break;
                case "*":
                    lblNumber.Text = (double.Parse(lblNumber.Text) * lblNum2).ToString();
                    break;
                case "/":
                    if (double.Parse(lblNumber.Text) == 0 && lblNum2 != 0)
                    {
                        lblNumber.Text = "Cannot divide by Zero";
                        break;
                    }
                    else if (double.Parse(lblNumber.Text) == 0 && lblNum2 == 0)
                    {
                        lblNumber.Text = "Undefined";
                    }
                    else
                    {
                        lblNumber.Text = (lblNum2 / double.Parse(lblNumber.Text)).ToString();
                    }
                    break;
            }
        }

        private void guna2CircleButton14_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            lblNum2 = double.Parse(lblNumber.Text);
            operators("+");
        }

        private void guna2CircleButton15_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            lblNum2 = double.Parse(lblNumber.Text);
            operators("-");
        }

        private void guna2CircleButton16_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            lblNum2 = double.Parse(lblNumber.Text);
            operators("*");
        }

        private void guna2CircleButton17_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            lblNum2 = double.Parse(lblNumber.Text);
            operators("/");
        }

        private void guna2CircleButton20_Click(object sender, EventArgs e)
        {
            lblNumber.Text = null;
            lblNum2 = 0;
            functions = "";
        }

        private void guna2CircleButton19_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            if (lblNumber.Text.Contains("-"))
            {
                double num1 = double.Parse(lblNumber.Text);
                num1 = num1 * -1;
                lblNumber.Text = num1.ToString();
            }
            else
            {
                lblNumber.Text = "-" + lblNumber.Text;
            }
        }

        private void guna2CircleButton18_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            double num1 = double.Parse(lblNumber.Text);
            num1 = num1 / 100;
            lblNumber.Text = num1.ToString();
        }

        private void guna2CircleButton9_Click(object sender, EventArgs e)
        {
            EmptyorNull();
            if (!lblNumber.Text.Contains("."))
            {
                lblNumber.Text += ".";
            }
        }
    }
}

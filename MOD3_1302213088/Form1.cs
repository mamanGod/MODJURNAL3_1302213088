namespace MOD3_1302213088
{
    public partial class Form1 : Form
    {

        double FirstNumber;
        String Operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "1";
            }
            else
            {
                output_Box.Text = output_Box.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "2";
            }
            else
            {
                output_Box.Text = output_Box.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "3";
            }
            else
            {
                output_Box.Text = output_Box.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "4";
            }
            else
            {
                output_Box.Text = output_Box.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "5";
            }
            else
            {
                output_Box.Text = output_Box.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "6";
            }
            else
            {
                output_Box.Text = output_Box.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "7";
            }
            else
            {
                output_Box.Text = output_Box.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "8";
            }
            else
            {
                output_Box.Text = output_Box.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "9";
            }
            else
            {
                output_Box.Text = output_Box.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (output_Box.Text == "0" && output_Box != null)
            {
                output_Box.Text = "0";
            }
            else
            {
                output_Box.Text = output_Box.Text + "0";
            }
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble (output_Box.Text);
            output_Box.Text = "";
            Operation = "+";
        }

        private void buttonHasil_Click(object sender, EventArgs e)
        {
            double Secondnumber;
            double Result;

            Secondnumber =Convert.ToDouble (output_Box.Text);

            if(Operation == "+")
            {
                Result = (FirstNumber + Secondnumber);
                output_Box.Text = Result.ToString();
                FirstNumber = Result;
            }

        }

        private void output_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        public Form1()
        {
  
            InitializeComponent();
        }

        //Number
        private void button_Click(object sender, EventArgs e)
        {
            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + button.Text;
            }
            else
                txtDisplay.Text = txtDisplay.Text + button.Text;
        }

        //Clear Enter
        private void button10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";

        }

        // Clear
        private void button9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOp.Text = "";
        }

        //backspace
        private void button8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length >0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text=="")
            {
                txtDisplay.Text="0";
            }
        }

        //division
        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            results = Double.Parse(txtDisplay.Text);
            txtDisplay.Text = "";
            lblShowOp.Text = System.Convert.ToString(results) + "" + operation;

        }
       
        // =
        private void button27_Click(object sender, EventArgs e)
        {
            lblShowOp.Text = "";
            switch(operation)
            {
                case "+":
                    txtDisplay.Text = (results + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (results - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "X":
                    txtDisplay.Text = (results * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (results / Double.Parse(txtDisplay.Text)).ToString();
                    break;
               // case "Mod":
                  //  txtDisplay.Text = (results % Double.Parse(txtDisplay.Text)).ToString();
                   // break;
            }
        }
        
        //PI
        private void button5_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(3.131592653589976323 * Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
           
        }
         
        //sqrt
        private void button1_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")");
            sq = Math.Sqrt(sq);
            txtDisplay.Text = System.Convert.ToString(sq);
        }

        //Log
        private void button26_Click(object sender, EventArgs e)
        {
            double ilog = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")");
            ilog = Math.Log10(ilog);
            txtDisplay.Text = System.Convert.ToString(ilog);
        }

        //Sin
        private void button6_Click(object sender, EventArgs e)
        {
            double qsin = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")");
            qsin = Math.Sin(qsin);
            txtDisplay.Text = System.Convert.ToString(qsin);
        }

        //Cos
        private void button11_Click(object sender, EventArgs e)
        {
            double qcos = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Cos" + "(" + (txtDisplay.Text) + ")");
            qcos = Math.Cos(qcos);
            txtDisplay.Text = System.Convert.ToString(qcos);
        }

        //tan
        private void button16_Click(object sender, EventArgs e)
        {
            double qtan = Double.Parse(txtDisplay.Text);
            lblShowOp.Text = System.Convert.ToString("Tan" + "(" + (txtDisplay.Text) + ")");
            qtan = Math.Tan(qtan);
            txtDisplay.Text = System.Convert.ToString(qtan);
        }

        //x^2
        private void button2_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //x^y
        private void button3_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //1/x
        private void button4_Click(object sender, EventArgs e)
        {
            Double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text));
            txtDisplay.Text = System.Convert.ToString(a);
        }

        //+/-
        private void button30_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains("-"))
                txtDisplay.Text = txtDisplay.Text.Remove(0, 1);
            else
                txtDisplay.Text = "-" + txtDisplay.Text;
        }

        //Binary
        private void button21_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtDisplay.Text);
            txtDisplay.Text = System.Convert.ToString(a, 2);
        }
    }
}

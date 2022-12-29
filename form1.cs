using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "tan(";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sin(";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "cos(";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "log(";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "sqrt(";
        }

        private void button34_Click(object sender, EventArgs e)
        {
            //Equals button
            try
            {
                double value = Evaluate(textBox1.Text);
                textBox1.Text = value.ToString();
            }
            catch
            {
                textBox1.Text = "Error!";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button33_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ln(";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "π";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "e";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "!";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Mod";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "abs(";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "floor(";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "ceiling(";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "round(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "min(";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "max(";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "%";
        }


        // Evaluate Method
        public static double Evaluate(string expression)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("expression", typeof(string), expression);
            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);
            return Convert.ToDouble(dt.Rows[0]["expression"]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Text = "%";
            button12.Text = "max";
            button11.Text = "min";
            button10.Text = "round";
            button9.Text = "ceiling";
            button8.Text = "floor";
            button7.Text = "abs";
            button18.Text = "Mod";
            button17.Text = ")";
            button16.Text = "!";
            button15.Text = "e";
            button14.Text = "π";
            button13.Text = "ln";
            button19.Text = "(";
            button20.Text = "^";
            button21.Text = "+";
            button22.Text = "-";
            button23.Text = "*";
            button28.Text = "/";
            button27.Text = "9";
            button26.Text = "8";
            button25.Text = "7";
            button24.Text = "6";
            button33.Text = "5";
            button32.Text = "4";
            button31.Text = "3";
            button30.Text = "2";
            button29.Text = "1";
            button37.Text = "0";
            button36.Text = ".";
            button34.Text = "=";
            button35.Text = "-";
            button4.Text = "sqrt";
            button3.Text = "log";
            button2.Text = "cos";
            button1.Text = "sin";
            button5.Text = "tan";
            Delete.Text = "Delete";
            Clear.Text = "Clear";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
{
    public partial class CalculatorForm : Form
    {
        Point position;
        string option;
        double NumberOne, NumberTwo;

        public CalculatorForm()
        {
            InitializeComponent();
        }

     

        private void ClearButton_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }
    
        private void OneSymbolButton_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Length > 1)
            {
                TextBox.Text = TextBox.Text.Substring(0, TextBox.Text.Length - 1);
            }
            else if (TextBox.Text.Length == 1)
            {
                TextBox.Text = "0";
            }
        }

        private void CalculatorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - position.X;
                this.Top += e.Y - position.Y;
            }
        }

        private void CalculatorForm_MouseDown(object sender, MouseEventArgs e)
        {
            position = e.Location;
            base.OnMouseMove(e);
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonCover_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void ButtonSin_Click(object sender, EventArgs e)
        {
            double SinDegree = Convert.ToDouble(TextBox.Text);
            SinDegree = Math.Sin(SinDegree);
            TextBox.Text = Convert.ToString(SinDegree);
        }

        private void ButtonCos_Click(object sender, EventArgs e)
        {
            double CosDegree = Convert.ToDouble(TextBox.Text);
            CosDegree = Math.Cos(CosDegree);
            TextBox.Text = Convert.ToString(CosDegree);
        }

        private void ButtonTan_Click(object sender, EventArgs e)
        {
            double TanNumber = Convert.ToDouble(TextBox.Text);
            TanNumber = Math.Tan(TanNumber);
            TextBox.Text = Convert.ToString(TanNumber);
        }

        private void ButtonSinh_Click(object sender, EventArgs e)
        {
            double SinhNumber = Convert.ToDouble(TextBox.Text);
            SinhNumber = Math.Sinh(SinhNumber);
            TextBox.Text = Convert.ToString(SinhNumber);
        }

        private void ButtonCosh_Click(object sender, EventArgs e)
        {
            double CoshNumber = Convert.ToDouble(TextBox.Text);
            CoshNumber = Math.Cosh(CoshNumber);
            TextBox.Text = Convert.ToString(CoshNumber);
        }

        private void ButtonTanh_Click(object sender, EventArgs e)
        {
            double TanhNumber = Convert.ToDouble(TextBox.Text);
            TanhNumber = Math.Tanh(TanhNumber);
            TextBox.Text = Convert.ToString(TanhNumber);
        }

        private void ButtonLn_Click(object sender, EventArgs e)
        {
            double LnNumber = Convert.ToDouble(TextBox.Text);
            LnNumber = Math.Log(LnNumber);
            TextBox.Text = Convert.ToString(LnNumber);
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox.Text);
            double Factorial = 1;
            while (num >= 1)
            {
                Factorial = Factorial * num;
                num--;
            }
            TextBox.Text = Factorial.ToString();
        }

        private void ButtonRound_Click(object sender, EventArgs e)
        {
            double NumRound = Convert.ToDouble(TextBox.Text);
            NumRound = Math.Round(NumRound);
            TextBox.Text = Convert.ToString(NumRound);
        }

        private void ButtonSquareRoot_Click(object sender, EventArgs e)
        {
            double functionSquareRoot = Convert.ToDouble(TextBox.Text);
            functionSquareRoot = Math.Sqrt(functionSquareRoot);
            TextBox.Text = Convert.ToString(functionSquareRoot);
        }

        private void ButtonPi_Click(object sender, EventArgs e)
        {
            TextBox.Text = Convert.ToString(Math.PI);
        }

        private void ButtonPlusMinus_Click(object sender, EventArgs e)
        {
            double function = Convert.ToDouble(TextBox.Text);
            TextBox.Text = Convert.ToString(-1 * function);
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text + ".";
        }

        private void ParametrsNumbers_Click(object sender, EventArgs e)
        {
            Button number = (Button)sender;

            if (TextBox.Text == "0")
                TextBox.Text = "";
            {
                if (number.Text == ".")
                {
                    if (!TextBox.Text.Contains("."))
                        TextBox.Text = TextBox.Text + number.Text;
                }
                else
                {
                    TextBox.Text = TextBox.Text + number.Text;
                }
            }
        }

        private void ValueOperation(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            NumberOne = Convert.ToDouble(TextBox.Text);
            option = number.Text;
            TextBox.Text = "";
        }

        private void ButtonE_Click(object sender, EventArgs e)
        {
            TextBox.Text = Convert.ToString(Math.E);
        }

        private void ButtonAbs_Click(object sender, EventArgs e)
        {
            double AbsNumber = Convert.ToDouble(TextBox.Text);
            AbsNumber = Math.Abs(AbsNumber);
            TextBox.Text = Convert.ToString(AbsNumber);
        }

        private void ButtonExp_Click(object sender, EventArgs e)
        {
            double ExpNumber = Convert.ToDouble(TextBox.Text);
            ExpNumber = Math.Exp(ExpNumber);
            TextBox.Text = Convert.ToString(ExpNumber);
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            NumberTwo = Convert.ToDouble(TextBox.Text);
            switch (option)
            {
                case "+":
                    TextBox.Text = (NumberOne + NumberTwo).ToString();
                    break;
                case "-":
                    TextBox.Text = (NumberOne - NumberTwo).ToString();
                    break;
                case "*":
                    TextBox.Text = (NumberOne * NumberTwo).ToString();
                    break;
                case "/":
                    TextBox.Text = (NumberOne / NumberTwo).ToString();
                    break;
                case "%":
                    TextBox.Text = (NumberOne / NumberTwo * 100 + "%").ToString();
                    break;
                case "log":
                    TextBox.Text = Convert.ToString(Math.Log(NumberOne, NumberTwo));
                    break;
                case "aⁿ":
                    TextBox.Text = Convert.ToString(Math.Pow(NumberOne, NumberTwo));
                    break;
                case "Mod":
                    TextBox.Text = (NumberOne % NumberTwo).ToString();
                    break;             
                default:
                    break;
            }
        }    
    }
}

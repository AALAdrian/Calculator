using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Boolean OperatorUsed = false;
        double finalans, lastinput;
        
        string lastOperatorUsed;
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnText = (Button)sender;
            if (display.Text.TrimEnd('.').Length != 16)
            {
                if(display.Text == "0")
                {
                    display.Text = btnText.Text;
                }
                else
                {
                    display.Text += btnText.Text;
                }

            }
            OperatorUsed = false;
            
        }
        private void Btn_Operator_Click(object sender, EventArgs e)
        {
            if (!OperatorUsed)
            {
                Button btnOperator = (Button)sender;
                //display.Text += btnOperator.Text;
                OperatorUsed = true;

                //convert display text to double remove any nonumeric 
                double input = Convert.ToDouble(Regex.Replace(display.Text, "[^.0-9]", ""));

                Calculate(input, lastOperatorUsed, btnOperator.Text);
                displayHold.Text = display.Text + btnOperator.Text;
                display.Clear();

            }
           
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            //display.Text.Remove(display.Text.LastIndexOf(display.Text));
            //display.Undo();
            display.Text = "0";
        }

        private void BtnClearE_Click(object sender, EventArgs e)
        {
            display.Text ="0";
            displayHold.Clear();
        }
        private void Calculate(double input, string operand, string newOperator)
        {
            double answer;
            try
            {
                answer = Convert.ToDouble(Regex.Replace(displayHold.Text, "[^.0-9]", ""));
            }
            catch(Exception)
            {
                answer = 0;
            }

            //switch statement for opperand
            finalans = operand switch
            {
                "+" => answer + input,
                "-" => answer - input,
                "×" => answer * input,
                "÷" => answer / input,
                _ => input,
            };

            display.Text = Convert.ToString(finalans);
            lastOperatorUsed = newOperator;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(Regex.Replace(display.Text, "[^.0-9]", ""));
            Calculate(input, lastOperatorUsed, "");
            displayHold.Text = Convert.ToString(finalans+lastOperatorUsed+input);
        }

        //KEYBIND
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    btn0.PerformClick();
                    break;
                case Keys.NumPad1:
                    btn1.PerformClick();
                    break;
                case Keys.NumPad2:
                    btn2.PerformClick();
                    break;
                case Keys.NumPad3:
                    btn3.PerformClick();
                    break;
                case Keys.NumPad4:
                    btn4.PerformClick();
                    break;
                case Keys.NumPad5:
                    btn5.PerformClick();
                    break;
                case Keys.NumPad6:
                    btn6.PerformClick();
                    break;
                case Keys.NumPad7:
                    btn7.PerformClick();
                    break;
                case Keys.NumPad8:
                    btn8.PerformClick();
                    break;
                case Keys.NumPad9:
                    btn9.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMult.PerformClick();
                    break;
                case Keys.Add:
                    btnPlus.PerformClick();
                    break;
                case Keys.Subtract:
                    btnMinus.PerformClick();
                    break;
                case Keys.Decimal:
                    btnDot.PerformClick();
                    break;
                case Keys.Divide:
                    btnDiv.PerformClick();
                    break;
                case Keys.Enter:
                    btnEquals.PerformClick();
                    break;
            }
        }
    }
}

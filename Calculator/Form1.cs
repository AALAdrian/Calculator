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
        Boolean OperatorUsed , Answered = false;
        double finalans, lastinput;
        
        string lastOperatorUsed;
        char[] operators = { '+', '-', '×', '÷'};
        public Form1()
        {
            InitializeComponent();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnText = (Button)sender;
            if (!Answered)
            {
                if (display.Text.TrimEnd('.').Length <= 15 || display.Text.TrimStart('0','.').Length <=15)
                {
                    if (display.Text == "0")
                    {
                        if (btnText.Text == ".")
                        {
                            display.Text += btnText.Text;
                        }
                        else
                        {
                            display.Text = btnText.Text;
                        }
                    }
                    else
                    {
                        display.Text += btnText.Text;
                    }

                }
            }
            else
            {
                display.Text = btnText.Text;
                Answered = false;
            }
            OperatorUsed = false;
            
        }
        private void Btn_Operator_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            if (OperatorUsed)
            {
                displayHold.Text = displayHold.Text.Remove(displayHold.Text.Length - 1);
                displayHold.Text += btnOperator.Text;

            }
            else
            {
                //display.Text += btnOperator.Text;
                OperatorUsed = true;
                Answered = true;
                //convert display text to double remove any nonumeric 
                double input = Convert.ToDouble(display.Text.TrimEnd(operators));

                Calculate(input, lastOperatorUsed, btnOperator.Text);
                displayHold.Text = display.Text + btnOperator.Text;
                display.Text = Convert.ToString(finalans);

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
                answer = Convert.ToDouble(displayHold.Text.TrimEnd(operators));
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

        private void delete_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 1)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
            else
            {
                display.Text = "0";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(display.Text.TrimEnd(operators));
            displayHold.Text += display.Text;
            Calculate(input, lastOperatorUsed, "");
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

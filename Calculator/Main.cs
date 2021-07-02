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
    public partial class Main : Form
    {
        // Variables
        Boolean isOperatorUsed,
                isSpecialOperatorsUsed,
                isAnswered,
                isEqualPressed,
                isSqrtBtnUsed,
                isInverseBtnUsed,
                isOperatorUsed1;

        double  finalans, 
                lastinput,
                memory;

        string  lastOperatorUsed;

        char[]  operators = { '+', '-', '×', '÷'};
        //---------------------
        public Main()
        {
            InitializeComponent();
        }
        // COVERTERS

        private double GetDisplayTextDouble()
        {
            return Convert.ToDouble(display.Text);
        }
        //---------------------
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btnText = (Button)sender;
            if (!isAnswered)
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
            else if (isEqualPressed)
            {
                btnClearE.PerformClick();
                display.Text = btnText.Text;
            }
            else
            {
                display.Text = btnText.Text;
                isAnswered = false;
            }
            isOperatorUsed = false;
            isEqualPressed = false;
        }
        private void Btn_Operator_Click(object sender, EventArgs e)
        {
            Button btnOperator = (Button)sender;
            if (isOperatorUsed)
            {
                displayHold.Text = displayHold.Text.Remove(displayHold.Text.Length - 1);
                displayHold.Text += btnOperator.Text;

            }
            else
            {
                isOperatorUsed = isAnswered = isOperatorUsed1 = true;
                isEqualPressed = false;

                //convert display text to double remove any nonumeric 
                double input = Convert.ToDouble(display.Text.TrimEnd(operators));

                display.Text = Calculate(GetDisplayHoldDouble(), input, lastOperatorUsed, btnOperator.Text);
                displayHold.Text = display.Text + btnOperator.Text;
                display.Text = Convert.ToString(finalans);

            }
           
        }

        // MEMORY
        private void Memory_Recall_Click(object sender, EventArgs e)
        {
            display.Text = $"{memory}";
        }

        private void memoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
            memoryClear.Enabled = memoryRecall.Enabled = false;
        }

        private void Memory_Add_Click(object sender, EventArgs e)
        {
            memory += GetDisplayTextDouble();
        }

        private void Memory_Minus_Click(object sender, EventArgs e)
        {
            memory -= GetDisplayTextDouble();
        }
        private void Memory_Save_Click(object sender, EventArgs e)
        {
            memory = GetDisplayTextDouble();
            memoryClear.Enabled = memoryRecall.Enabled = true;
        }
        private void btnNeg_Click(object sender, EventArgs e)
        {
            double negation = GetDisplayTextDouble();
            negation *= -1;
            display.Text = $"{negation}";
        }
        private double GetDisplayHoldDouble()
        {
            double displayHold;
            try
            {
                displayHold = Convert.ToDouble(this.displayHold.Text.TrimEnd(operators));
            }
            catch (Exception)
            {
                displayHold = 0;
            }
            return displayHold;
        }
        private string Calculate(double left, double right,string operand, string newOperator =  "")
        {
                      
            //switch statement for opperand
            finalans = operand switch
            {
                "+" => left + right,
                "-" => left - right,
                "×" => left * right,
                "÷" => left / right,
                _ => right,
            };
            if (!string.IsNullOrEmpty(newOperator))
            {
                lastOperatorUsed = newOperator;
            }
            return Convert.ToString(finalans);
        }
        private void Btn_Special_Operator_Click(object sender, EventArgs e)
        {
            Button SpecialOperator = (Button)sender;
            char specialOperator = Convert.ToChar(SpecialOperator.Tag);
            switch (specialOperator)
            {
                case '√':
                    if (!isSqrtBtnUsed)
                    {
                        displayHold.Text = display.Text;
                    }
                    displayHold.Text = $"√({displayHold.Text})";
                    double sqrtAns = Math.Sqrt(GetDisplayTextDouble());
                    display.Text = $"{sqrtAns}";
                    isSqrtBtnUsed = true;
                    break;
                case '%':
                    displayHold.Text = display.Text;
                    double percentAns = GetDisplayTextDouble() / 100;
                    display.Text = $"{percentAns}";
                    break;
                case 'I':
                    if (!isInverseBtnUsed)
                    {
                        displayHold.Text = display.Text;
                    }
                    displayHold.Text = $"1/({displayHold.Text})";
                    double inverseAns = 1 / GetDisplayTextDouble();
                    display.Text = $"{inverseAns}";
                    isInverseBtnUsed = true;
                    break;

                default:
                    break;
            }
        }
        private void Btn_ClearE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            isOperatorUsed = false;
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            display.Text ="0";
            displayHold.Clear();
            isAnswered = isEqualPressed = isOperatorUsed = isOperatorUsed1 = isSpecialOperatorsUsed = false;
        }
        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                displayHold.Clear();
            }
            else if (display.Text.Length > 1)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1);
            }
            else
            {
                display.Text = "0";
            }
        }
        private void Btn_Equals_Click(object sender, EventArgs e)
        {
            if (isEqualPressed)
            {
                double input = GetDisplayTextDouble();
                display.Text = Calculate(input, lastinput, lastOperatorUsed);
                displayHold.Text = $"{input}{lastOperatorUsed}{lastinput} =";
            }
            else if (isOperatorUsed1)
            {
                double input = Convert.ToDouble(display.Text.TrimEnd(operators));
                lastinput = GetDisplayTextDouble();
                display.Text = Calculate(GetDisplayHoldDouble(), input, lastOperatorUsed);
                displayHold.Text = $"{displayHold.Text}{lastinput} =";
            }
            else if (isSpecialOperatorsUsed)
            {
                displayHold.Text += " =";
                isSpecialOperatorsUsed = false;
            }
            else if (!isEqualPressed)
            {
                displayHold.Text = $"{display.Text} =";
            }
            else
            {
                
            }
            isEqualPressed = true;
            isAnswered = true;
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
                case Keys.Delete:
                    btnClearE.PerformClick();
                    break;
                case Keys.Back:
                    delete.PerformClick();
                    break;
            }
        }
    }
}

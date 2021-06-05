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
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button btntext = (Button)sender;
            //display.Items.Add(btn.Text);
            display.Text += btntext.Text;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //display.Text.Remove(display.Text.LastIndexOf(display.Text));
            display.Undo();
        }

        private void btnClearE_Click(object sender, EventArgs e)
        {
            display.Clear();
        }
    }
}

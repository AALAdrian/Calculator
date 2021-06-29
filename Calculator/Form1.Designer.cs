
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNeg = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnClearE = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.displayHold = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.memoryClear = new System.Windows.Forms.Button();
            this.memoryRecall = new System.Windows.Forms.Button();
            this.memorySave = new System.Windows.Forms.Button();
            this.memoryAdd = new System.Windows.Forms.Button();
            this.memoryMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeg
            // 
            this.btnNeg.AutoSize = true;
            this.btnNeg.Location = new System.Drawing.Point(210, 135);
            this.btnNeg.Name = "btnNeg";
            this.btnNeg.Size = new System.Drawing.Size(60, 60);
            this.btnNeg.TabIndex = 1;
            this.btnNeg.TabStop = false;
            this.btnNeg.Text = "±";
            this.btnNeg.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Location = new System.Drawing.Point(12, 402);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(126, 60);
            this.btn0.TabIndex = 1;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Location = new System.Drawing.Point(144, 402);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(60, 60);
            this.btnDot.TabIndex = 1;
            this.btnDot.TabStop = false;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.AutoSize = true;
            this.btnEquals.Location = new System.Drawing.Point(276, 336);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 126);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.TabStop = false;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(144, 336);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 60);
            this.btn3.TabIndex = 1;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Location = new System.Drawing.Point(210, 402);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(60, 60);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(78, 336);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 60);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(12, 336);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 60);
            this.btn1.TabIndex = 1;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Location = new System.Drawing.Point(12, 268);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 60);
            this.btn4.TabIndex = 1;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Location = new System.Drawing.Point(78, 268);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 60);
            this.btn5.TabIndex = 1;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Location = new System.Drawing.Point(144, 202);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 60);
            this.btn9.TabIndex = 1;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Location = new System.Drawing.Point(78, 202);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 60);
            this.btn8.TabIndex = 1;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Location = new System.Drawing.Point(12, 202);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 60);
            this.btn7.TabIndex = 1;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Location = new System.Drawing.Point(144, 268);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 60);
            this.btn6.TabIndex = 1;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnMult
            // 
            this.btnMult.AutoSize = true;
            this.btnMult.Location = new System.Drawing.Point(210, 268);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(60, 60);
            this.btnMult.TabIndex = 1;
            this.btnMult.TabStop = false;
            this.btnMult.Text = "×";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.Location = new System.Drawing.Point(210, 336);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(60, 60);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.AutoSize = true;
            this.btnDiv.Location = new System.Drawing.Point(210, 202);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(60, 60);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.TabStop = false;
            this.btnDiv.Text = "÷";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // btnClearE
            // 
            this.btnClearE.AutoSize = true;
            this.btnClearE.Location = new System.Drawing.Point(78, 135);
            this.btnClearE.Name = "btnClearE";
            this.btnClearE.Size = new System.Drawing.Size(60, 60);
            this.btnClearE.TabIndex = 1;
            this.btnClearE.TabStop = false;
            this.btnClearE.Text = "CE";
            this.btnClearE.UseVisualStyleBackColor = true;
            this.btnClearE.Click += new System.EventHandler(this.BtnClearE_Click);
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.display.Location = new System.Drawing.Point(12, 45);
            this.display.MaxLength = 16;
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.display.Size = new System.Drawing.Size(324, 54);
            this.display.TabIndex = 3;
            this.display.TabStop = false;
            this.display.Text = "0";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(144, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 60);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // displayHold
            // 
            this.displayHold.BackColor = System.Drawing.SystemColors.Control;
            this.displayHold.Location = new System.Drawing.Point(12, 12);
            this.displayHold.Name = "displayHold";
            this.displayHold.ReadOnly = true;
            this.displayHold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.displayHold.Size = new System.Drawing.Size(324, 27);
            this.displayHold.TabIndex = 3;
            this.displayHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Enabled = false;
            this.delete.Location = new System.Drawing.Point(12, 135);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(60, 60);
            this.delete.TabIndex = 1;
            this.delete.TabStop = false;
            this.delete.Text = "<=";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(276, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "√";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(276, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 1;
            this.button4.TabStop = false;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(276, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 1;
            this.button5.TabStop = false;
            this.button5.Text = "%";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Btn_Operator_Click);
            // 
            // memoryClear
            // 
            this.memoryClear.AutoSize = true;
            this.memoryClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoryClear.Enabled = false;
            this.memoryClear.FlatAppearance.BorderSize = 0;
            this.memoryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryClear.Location = new System.Drawing.Point(12, 102);
            this.memoryClear.Margin = new System.Windows.Forms.Padding(0);
            this.memoryClear.Name = "memoryClear";
            this.memoryClear.Size = new System.Drawing.Size(60, 30);
            this.memoryClear.TabIndex = 1;
            this.memoryClear.TabStop = false;
            this.memoryClear.Text = "MC";
            this.memoryClear.UseVisualStyleBackColor = false;
            this.memoryClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // memoryRecall
            // 
            this.memoryRecall.AutoSize = true;
            this.memoryRecall.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoryRecall.Enabled = false;
            this.memoryRecall.FlatAppearance.BorderSize = 0;
            this.memoryRecall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryRecall.Location = new System.Drawing.Point(78, 102);
            this.memoryRecall.Margin = new System.Windows.Forms.Padding(0);
            this.memoryRecall.Name = "memoryRecall";
            this.memoryRecall.Size = new System.Drawing.Size(60, 30);
            this.memoryRecall.TabIndex = 1;
            this.memoryRecall.TabStop = false;
            this.memoryRecall.Text = "MR";
            this.memoryRecall.UseVisualStyleBackColor = false;
            this.memoryRecall.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // memorySave
            // 
            this.memorySave.AutoSize = true;
            this.memorySave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memorySave.Enabled = false;
            this.memorySave.FlatAppearance.BorderSize = 0;
            this.memorySave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memorySave.Location = new System.Drawing.Point(144, 102);
            this.memorySave.Margin = new System.Windows.Forms.Padding(0);
            this.memorySave.Name = "memorySave";
            this.memorySave.Size = new System.Drawing.Size(60, 30);
            this.memorySave.TabIndex = 1;
            this.memorySave.TabStop = false;
            this.memorySave.Text = "MS";
            this.memorySave.UseVisualStyleBackColor = false;
            this.memorySave.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // memoryAdd
            // 
            this.memoryAdd.AutoSize = true;
            this.memoryAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoryAdd.Enabled = false;
            this.memoryAdd.FlatAppearance.BorderSize = 0;
            this.memoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryAdd.Location = new System.Drawing.Point(210, 102);
            this.memoryAdd.Margin = new System.Windows.Forms.Padding(0);
            this.memoryAdd.Name = "memoryAdd";
            this.memoryAdd.Size = new System.Drawing.Size(60, 30);
            this.memoryAdd.TabIndex = 1;
            this.memoryAdd.TabStop = false;
            this.memoryAdd.Text = "M+";
            this.memoryAdd.UseVisualStyleBackColor = false;
            this.memoryAdd.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // memoryMinus
            // 
            this.memoryMinus.AutoSize = true;
            this.memoryMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.memoryMinus.Enabled = false;
            this.memoryMinus.FlatAppearance.BorderSize = 0;
            this.memoryMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryMinus.Location = new System.Drawing.Point(276, 102);
            this.memoryMinus.Margin = new System.Windows.Forms.Padding(0);
            this.memoryMinus.Name = "memoryMinus";
            this.memoryMinus.Size = new System.Drawing.Size(60, 30);
            this.memoryMinus.TabIndex = 1;
            this.memoryMinus.TabStop = false;
            this.memoryMinus.Text = "M-";
            this.memoryMinus.UseVisualStyleBackColor = false;
            this.memoryMinus.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 470);
            this.Controls.Add(this.displayHold);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.memoryMinus);
            this.Controls.Add(this.memoryAdd);
            this.Controls.Add(this.memorySave);
            this.Controls.Add(this.memoryRecall);
            this.Controls.Add(this.memoryClear);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearE);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnNeg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNeg;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button btnClearE;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox displayHold;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button memoryClear;
        private System.Windows.Forms.Button memoryRecall;
        private System.Windows.Forms.Button memorySave;
        private System.Windows.Forms.Button memoryAdd;
        private System.Windows.Forms.Button memoryMinus;
    }
}


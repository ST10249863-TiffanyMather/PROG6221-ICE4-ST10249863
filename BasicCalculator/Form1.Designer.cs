namespace BasicCalculator
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
            txtDisplay = new TextBox();
            btnSeven = new Button();
            btnFour = new Button();
            btnOne = new Button();
            btnZero = new Button();
            btnEqual = new Button();
            btnThree = new Button();
            btnSix = new Button();
            btnNine = new Button();
            btnDecimal = new Button();
            btnTwo = new Button();
            btnFive = new Button();
            btnEight = new Button();
            btnPercent = new Button();
            btnMultiply = new Button();
            btnPlus = new Button();
            btnMinusPlus = new Button();
            btnDivide = new Button();
            btnMinus = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(22, 22);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(288, 43);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSeven
            // 
            btnSeven.Font = new Font("Segoe UI", 12F);
            btnSeven.Location = new Point(22, 88);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(43, 45);
            btnSeven.TabIndex = 1;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = true;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnFour
            // 
            btnFour.Font = new Font("Segoe UI", 12F);
            btnFour.Location = new Point(22, 148);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(43, 45);
            btnFour.TabIndex = 2;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = true;
            btnFour.Click += btnFour_Click;
            // 
            // btnOne
            // 
            btnOne.Font = new Font("Segoe UI", 12F);
            btnOne.Location = new Point(22, 210);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(43, 45);
            btnOne.TabIndex = 3;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = true;
            btnOne.Click += btnOne_Click;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F);
            btnZero.Location = new Point(22, 270);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(43, 45);
            btnZero.TabIndex = 5;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += button5_Click;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 12F);
            btnEqual.Location = new Point(127, 270);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(43, 45);
            btnEqual.TabIndex = 9;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // btnThree
            // 
            btnThree.Font = new Font("Segoe UI", 12F);
            btnThree.Location = new Point(127, 210);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(43, 45);
            btnThree.TabIndex = 8;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = true;
            btnThree.Click += btnThree_Click;
            // 
            // btnSix
            // 
            btnSix.Font = new Font("Segoe UI", 12F);
            btnSix.Location = new Point(127, 148);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(43, 45);
            btnSix.TabIndex = 7;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = true;
            btnSix.Click += btnSix_Click;
            // 
            // btnNine
            // 
            btnNine.Font = new Font("Segoe UI", 12F);
            btnNine.Location = new Point(127, 88);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(43, 45);
            btnNine.TabIndex = 6;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = true;
            btnNine.Click += btnNine_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.Font = new Font("Segoe UI", 12F);
            btnDecimal.Location = new Point(75, 270);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(43, 45);
            btnDecimal.TabIndex = 13;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = true;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnTwo
            // 
            btnTwo.Font = new Font("Segoe UI", 12F);
            btnTwo.Location = new Point(75, 210);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(43, 45);
            btnTwo.TabIndex = 12;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = true;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnFive
            // 
            btnFive.Font = new Font("Segoe UI", 12F);
            btnFive.Location = new Point(75, 148);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(43, 45);
            btnFive.TabIndex = 11;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = true;
            btnFive.Click += btnFive_Click;
            // 
            // btnEight
            // 
            btnEight.Font = new Font("Segoe UI", 12F);
            btnEight.Location = new Point(75, 88);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(43, 45);
            btnEight.TabIndex = 10;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = true;
            btnEight.Click += btnEight_Click;
            // 
            // btnPercent
            // 
            btnPercent.Font = new Font("Segoe UI", 12F);
            btnPercent.Location = new Point(263, 270);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(43, 45);
            btnPercent.TabIndex = 21;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = true;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F);
            btnMultiply.Location = new Point(263, 210);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(43, 45);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 12F);
            btnPlus.Location = new Point(263, 148);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(43, 45);
            btnPlus.TabIndex = 19;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMinusPlus
            // 
            btnMinusPlus.Font = new Font("Segoe UI", 12F);
            btnMinusPlus.Location = new Point(210, 270);
            btnMinusPlus.Name = "btnMinusPlus";
            btnMinusPlus.Size = new Size(43, 45);
            btnMinusPlus.TabIndex = 17;
            btnMinusPlus.Text = "-/+";
            btnMinusPlus.UseVisualStyleBackColor = true;
            btnMinusPlus.Click += btnMinusPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 12F);
            btnDivide.Location = new Point(210, 210);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(43, 45);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 12F);
            btnMinus.Location = new Point(210, 148);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(43, 45);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(210, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 45);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 333);
            Controls.Add(btnPercent);
            Controls.Add(btnMultiply);
            Controls.Add(btnPlus);
            Controls.Add(btnMinusPlus);
            Controls.Add(btnDivide);
            Controls.Add(btnMinus);
            Controls.Add(btnClear);
            Controls.Add(btnDecimal);
            Controls.Add(btnTwo);
            Controls.Add(btnFive);
            Controls.Add(btnEight);
            Controls.Add(btnEqual);
            Controls.Add(btnThree);
            Controls.Add(btnSix);
            Controls.Add(btnNine);
            Controls.Add(btnZero);
            Controls.Add(btnOne);
            Controls.Add(btnFour);
            Controls.Add(btnSeven);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnSeven;
        private Button btnFour;
        private Button btnOne;
        private Button btnZero;
        private Button btnEqual;
        private Button btnThree;
        private Button btnSix;
        private Button btnNine;
        private Button btnDecimal;
        private Button btnTwo;
        private Button btnFive;
        private Button btnEight;
        private Button btnPercent;
        private Button btnMultiply;
        private Button btnPlus;
        private Button btnMinusPlus;
        private Button btnDivide;
        private Button btnMinus;
        private Button btnClear;
    }
}

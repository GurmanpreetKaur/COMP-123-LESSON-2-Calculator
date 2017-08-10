namespace COMP_123_LESSON_2_Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalculatorButton = new System.Windows.Forms.TableLayoutPanel();
            this.EqualButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.PlusMinusButton = new System.Windows.Forms.Button();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.CalculatorButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.ColumnCount = 4;
            this.CalculatorButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CalculatorButton.Controls.Add(this.EqualButton, 3, 4);
            this.CalculatorButton.Controls.Add(this.DecimalButton, 2, 4);
            this.CalculatorButton.Controls.Add(this.ZeroButton, 1, 4);
            this.CalculatorButton.Controls.Add(this.PlusMinusButton, 0, 4);
            this.CalculatorButton.Controls.Add(this.PlusButton, 3, 3);
            this.CalculatorButton.Controls.Add(this.ThreeButton, 2, 3);
            this.CalculatorButton.Controls.Add(this.TwoButton, 1, 3);
            this.CalculatorButton.Controls.Add(this.OneButton, 0, 3);
            this.CalculatorButton.Controls.Add(this.MinusButton, 3, 2);
            this.CalculatorButton.Controls.Add(this.SixButton, 2, 2);
            this.CalculatorButton.Controls.Add(this.FiveButton, 1, 2);
            this.CalculatorButton.Controls.Add(this.FourButton, 0, 2);
            this.CalculatorButton.Controls.Add(this.MultiplyButton, 3, 1);
            this.CalculatorButton.Controls.Add(this.button7, 2, 1);
            this.CalculatorButton.Controls.Add(this.EightButton, 1, 1);
            this.CalculatorButton.Controls.Add(this.SevenButton, 0, 1);
            this.CalculatorButton.Controls.Add(this.DivideButton, 3, 0);
            this.CalculatorButton.Controls.Add(this.button3, 2, 0);
            this.CalculatorButton.Controls.Add(this.ClearButton, 0, 0);
            this.CalculatorButton.Location = new System.Drawing.Point(12, 223);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.RowCount = 5;
            this.CalculatorButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CalculatorButton.Size = new System.Drawing.Size(280, 206);
            this.CalculatorButton.TabIndex = 0;
            // 
            // EqualButton
            // 
            this.EqualButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EqualButton.Location = new System.Drawing.Point(213, 167);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(64, 35);
            this.EqualButton.TabIndex = 19;
            this.EqualButton.Text = "=";
            this.EqualButton.UseVisualStyleBackColor = false;
            this.EqualButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.BackColor = System.Drawing.Color.Gainsboro;
            this.DecimalButton.Location = new System.Drawing.Point(143, 167);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(64, 35);
            this.DecimalButton.TabIndex = 18;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = false;
            this.DecimalButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ZeroButton.Location = new System.Drawing.Point(73, 167);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(64, 35);
            this.ZeroButton.TabIndex = 17;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = false;
            this.ZeroButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // PlusMinusButton
            // 
            this.PlusMinusButton.Location = new System.Drawing.Point(3, 167);
            this.PlusMinusButton.Name = "PlusMinusButton";
            this.PlusMinusButton.Size = new System.Drawing.Size(64, 35);
            this.PlusMinusButton.TabIndex = 16;
            this.PlusMinusButton.Text = "±";
            this.PlusMinusButton.UseVisualStyleBackColor = true;
            this.PlusMinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlusButton.Location = new System.Drawing.Point(213, 126);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(64, 35);
            this.PlusButton.TabIndex = 15;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ThreeButton.Location = new System.Drawing.Point(143, 126);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(64, 35);
            this.ThreeButton.TabIndex = 14;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = false;
            this.ThreeButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.BackColor = System.Drawing.Color.Gainsboro;
            this.TwoButton.Location = new System.Drawing.Point(73, 126);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(64, 35);
            this.TwoButton.TabIndex = 13;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = false;
            this.TwoButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // OneButton
            // 
            this.OneButton.BackColor = System.Drawing.Color.Gainsboro;
            this.OneButton.Location = new System.Drawing.Point(3, 126);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(64, 35);
            this.OneButton.TabIndex = 12;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = false;
            this.OneButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Location = new System.Drawing.Point(213, 85);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(64, 35);
            this.MinusButton.TabIndex = 11;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SixButton.Location = new System.Drawing.Point(143, 85);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(64, 35);
            this.SixButton.TabIndex = 10;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = false;
            this.SixButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FiveButton.Location = new System.Drawing.Point(73, 85);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(64, 35);
            this.FiveButton.TabIndex = 9;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = false;
            this.FiveButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // FourButton
            // 
            this.FourButton.BackColor = System.Drawing.Color.Gainsboro;
            this.FourButton.Location = new System.Drawing.Point(3, 85);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(64, 35);
            this.FourButton.TabIndex = 8;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = false;
            this.FourButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Location = new System.Drawing.Point(213, 44);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(64, 35);
            this.MultiplyButton.TabIndex = 7;
            this.MultiplyButton.Text = "x";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gainsboro;
            this.button7.Location = new System.Drawing.Point(143, 44);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(64, 35);
            this.button7.TabIndex = 6;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // EightButton
            // 
            this.EightButton.BackColor = System.Drawing.Color.Gainsboro;
            this.EightButton.Location = new System.Drawing.Point(73, 44);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(64, 35);
            this.EightButton.TabIndex = 5;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = false;
            this.EightButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SevenButton.Location = new System.Drawing.Point(3, 44);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(64, 35);
            this.SevenButton.TabIndex = 4;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = false;
            this.SevenButton.Click += new System.EventHandler(this.CalculatorButon_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Location = new System.Drawing.Point(213, 3);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(64, 35);
            this.DivideButton.TabIndex = 3;
            this.DivideButton.Text = "÷";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "Del";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // ClearButton
            // 
            this.CalculatorButton.SetColumnSpan(this.ClearButton, 2);
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 35);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "C";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.OperatorButton_Click);
            // 
            // Result
            // 
            this.Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Result.Enabled = false;
            this.Result.Location = new System.Drawing.Point(1, 138);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(300, 31);
            this.Result.TabIndex = 1;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CalculatorButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.Click += new System.EventHandler(this.OperatorButton_Click);
            this.CalculatorButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CalculatorButton;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button EqualButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button PlusMinusButton;
        private System.Windows.Forms.Button PlusButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button MinusButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DivideButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ClearButton;
    }
}


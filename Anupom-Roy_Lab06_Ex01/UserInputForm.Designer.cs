﻿namespace Anupom_Roy_Lab06_Ex01
{
    partial class UserInputForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEvenOddResult = new System.Windows.Forms.Label();
            this.btnEvenOdd = new System.Windows.Forms.Button();
            this.txtInputNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxLowToHeighValue = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHeighIndex = new System.Windows.Forms.TextBox();
            this.txtLowIndex = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.btnGenerateValues = new System.Windows.Forms.Button();
            this.rbChar = new System.Windows.Forms.RadioButton();
            this.rbDoubles = new System.Windows.Forms.RadioButton();
            this.rbInteger = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblFactorialResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFactorialResult);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtFactorial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(1) Calculate Asynchronously";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(26, 83);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(106, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(124, 36);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(100, 23);
            this.txtFactorial.TabIndex = 1;
            this.txtFactorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEvenOddResult);
            this.groupBox2.Controls.Add(this.btnEvenOdd);
            this.groupBox2.Controls.Add(this.txtInputNum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(2) Check for Even/Odd";
            // 
            // lblEvenOddResult
            // 
            this.lblEvenOddResult.AutoSize = true;
            this.lblEvenOddResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvenOddResult.Location = new System.Drawing.Point(23, 113);
            this.lblEvenOddResult.Name = "lblEvenOddResult";
            this.lblEvenOddResult.Size = new System.Drawing.Size(0, 15);
            this.lblEvenOddResult.TabIndex = 3;
            // 
            // btnEvenOdd
            // 
            this.btnEvenOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvenOdd.Location = new System.Drawing.Point(26, 79);
            this.btnEvenOdd.Name = "btnEvenOdd";
            this.btnEvenOdd.Size = new System.Drawing.Size(142, 23);
            this.btnEvenOdd.TabIndex = 2;
            this.btnEvenOdd.Text = " Check for Even or Odd";
            this.btnEvenOdd.UseVisualStyleBackColor = true;
            this.btnEvenOdd.Click += new System.EventHandler(this.btnEvenOdd_Click);
            // 
            // txtInputNum
            // 
            this.txtInputNum.Location = new System.Drawing.Point(124, 36);
            this.txtInputNum.Name = "txtInputNum";
            this.txtInputNum.Size = new System.Drawing.Size(100, 23);
            this.txtInputNum.TabIndex = 1;
            this.txtInputNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNum_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDisplay);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.listBoxLowToHeighValue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtHeighIndex);
            this.groupBox3.Controls.Add(this.txtLowIndex);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.listBoxDisplay);
            this.groupBox3.Controls.Add(this.btnGenerateValues);
            this.groupBox3.Controls.Add(this.rbChar);
            this.groupBox3.Controls.Add(this.rbDoubles);
            this.groupBox3.Controls.Add(this.rbInteger);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(288, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(3) Display List of Values and Search";
            // 
            // listBoxLowToHeighValue
            // 
            this.listBoxLowToHeighValue.FormattingEnabled = true;
            this.listBoxLowToHeighValue.ItemHeight = 16;
            this.listBoxLowToHeighValue.Location = new System.Drawing.Point(95, 213);
            this.listBoxLowToHeighValue.MultiColumn = true;
            this.listBoxLowToHeighValue.Name = "listBoxLowToHeighValue";
            this.listBoxLowToHeighValue.Size = new System.Drawing.Size(268, 68);
            this.listBoxLowToHeighValue.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Output of values between Low and Heigh";
            // 
            // txtHeighIndex
            // 
            this.txtHeighIndex.Location = new System.Drawing.Point(226, 142);
            this.txtHeighIndex.Name = "txtHeighIndex";
            this.txtHeighIndex.Size = new System.Drawing.Size(89, 23);
            this.txtHeighIndex.TabIndex = 10;
            this.txtHeighIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNum_KeyPress);
            // 
            // txtLowIndex
            // 
            this.txtLowIndex.Location = new System.Drawing.Point(226, 112);
            this.txtLowIndex.Name = "txtLowIndex";
            this.txtLowIndex.Size = new System.Drawing.Size(89, 23);
            this.txtLowIndex.TabIndex = 9;
            this.txtLowIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNum_KeyPress);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(226, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(89, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInputNum_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Input for heigh Index";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input for low Index";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input Value for Search";
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.ItemHeight = 16;
            this.listBoxDisplay.Location = new System.Drawing.Point(17, 69);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(68, 212);
            this.listBoxDisplay.TabIndex = 4;
            // 
            // btnGenerateValues
            // 
            this.btnGenerateValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateValues.Location = new System.Drawing.Point(254, 35);
            this.btnGenerateValues.Name = "btnGenerateValues";
            this.btnGenerateValues.Size = new System.Drawing.Size(112, 23);
            this.btnGenerateValues.TabIndex = 3;
            this.btnGenerateValues.Text = "Generate Values";
            this.btnGenerateValues.UseVisualStyleBackColor = true;
            this.btnGenerateValues.Click += new System.EventHandler(this.btnGenerateValues_Click);
            // 
            // rbChar
            // 
            this.rbChar.AutoSize = true;
            this.rbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChar.Location = new System.Drawing.Point(163, 32);
            this.rbChar.Name = "rbChar";
            this.rbChar.Size = new System.Drawing.Size(51, 19);
            this.rbChar.TabIndex = 2;
            this.rbChar.Text = "Char";
            this.rbChar.UseVisualStyleBackColor = true;
            // 
            // rbDoubles
            // 
            this.rbDoubles.AutoSize = true;
            this.rbDoubles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDoubles.Location = new System.Drawing.Point(86, 32);
            this.rbDoubles.Name = "rbDoubles";
            this.rbDoubles.Size = new System.Drawing.Size(71, 19);
            this.rbDoubles.TabIndex = 1;
            this.rbDoubles.Text = "Doubles";
            this.rbDoubles.UseVisualStyleBackColor = true;
            // 
            // rbInteger
            // 
            this.rbInteger.AutoSize = true;
            this.rbInteger.Checked = true;
            this.rbInteger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInteger.Location = new System.Drawing.Point(17, 32);
            this.rbInteger.Name = "rbInteger";
            this.rbInteger.Size = new System.Drawing.Size(63, 19);
            this.rbInteger.TabIndex = 0;
            this.rbInteger.TabStop = true;
            this.rbInteger.Text = "Integer";
            this.rbInteger.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(321, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(321, 134);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 14;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblFactorialResult
            // 
            this.lblFactorialResult.AutoSize = true;
            this.lblFactorialResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactorialResult.Location = new System.Drawing.Point(23, 120);
            this.lblFactorialResult.Name = "lblFactorialResult";
            this.lblFactorialResult.Size = new System.Drawing.Size(0, 15);
            this.lblFactorialResult.TabIndex = 3;
            // 
            // UserInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 331);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserInputForm";
            this.Text = "Asynchronus Programming";
            this.Load += new System.EventHandler(this.btnGenerateValues_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEvenOdd;
        private System.Windows.Forms.TextBox txtInputNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Button btnGenerateValues;
        private System.Windows.Forms.RadioButton rbChar;
        private System.Windows.Forms.RadioButton rbDoubles;
        private System.Windows.Forms.RadioButton rbInteger;
        private System.Windows.Forms.ListBox listBoxLowToHeighValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHeighIndex;
        private System.Windows.Forms.TextBox txtLowIndex;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEvenOddResult;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblFactorialResult;
    }
}


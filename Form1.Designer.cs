namespace IncompleteApp
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
            components = new System.ComponentModel.Container();
            runTimer = new System.Windows.Forms.Timer(components);
            calcMain = new TextBox();
            buttonZero = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            period = new Button();
            equals = new Button();
            division = new Button();
            subtraction = new Button();
            addition = new Button();
            multiplication = new Button();
            backspace = new Button();
            SuspendLayout();
            // 
            // runTimer
            // 
            runTimer.Interval = 16;
            runTimer.Tick += runTimer_Tick;
            // 
            // calcMain
            // 
            calcMain.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calcMain.Location = new Point(12, 12);
            calcMain.Name = "calcMain";
            calcMain.PlaceholderText = "0";
            calcMain.Size = new Size(554, 80);
            calcMain.TabIndex = 0;
            // 
            // buttonZero
            // 
            buttonZero.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonZero.Location = new Point(143, 421);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(125, 88);
            buttonZero.TabIndex = 1;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonValued_Click;
            // 
            // buttonOne
            // 
            buttonOne.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOne.Location = new Point(12, 139);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(125, 88);
            buttonOne.TabIndex = 2;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonValued_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTwo.Location = new Point(143, 139);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(125, 88);
            buttonTwo.TabIndex = 3;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonValued_Click;
            // 
            // buttonThree
            // 
            buttonThree.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonThree.Location = new Point(274, 139);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(125, 88);
            buttonThree.TabIndex = 4;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonValued_Click;
            // 
            // buttonFour
            // 
            buttonFour.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFour.Location = new Point(12, 233);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(125, 88);
            buttonFour.TabIndex = 5;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonValued_Click;
            // 
            // buttonFive
            // 
            buttonFive.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFive.Location = new Point(143, 233);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(125, 88);
            buttonFive.TabIndex = 6;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonValued_Click;
            // 
            // buttonSix
            // 
            buttonSix.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSix.Location = new Point(274, 233);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(125, 88);
            buttonSix.TabIndex = 7;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonValued_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSeven.Location = new Point(12, 327);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(125, 88);
            buttonSeven.TabIndex = 8;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonValued_Click;
            // 
            // buttonEight
            // 
            buttonEight.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEight.Location = new Point(143, 327);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(125, 88);
            buttonEight.TabIndex = 9;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonValued_Click;
            // 
            // buttonNine
            // 
            buttonNine.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonNine.Location = new Point(274, 327);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(125, 88);
            buttonNine.TabIndex = 10;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonValued_Click;
            // 
            // period
            // 
            period.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            period.Location = new Point(12, 421);
            period.Name = "period";
            period.Size = new Size(125, 88);
            period.TabIndex = 11;
            period.Text = ".";
            period.UseVisualStyleBackColor = true;
            period.Click += buttonValued_Click;
            // 
            // equals
            // 
            equals.BackColor = Color.FromArgb(255, 128, 0);
            equals.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equals.ForeColor = SystemColors.HighlightText;
            equals.Location = new Point(12, 514);
            equals.Name = "equals";
            equals.Size = new Size(554, 88);
            equals.TabIndex = 12;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = false;
            // 
            // division
            // 
            division.BackColor = SystemColors.ControlDarkDark;
            division.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            division.ForeColor = SystemColors.HighlightText;
            division.Location = new Point(441, 421);
            division.Name = "division";
            division.Size = new Size(125, 88);
            division.TabIndex = 13;
            division.Text = "÷";
            division.UseVisualStyleBackColor = false;
            division.Click += buttonValued_Click;
            // 
            // subtraction
            // 
            subtraction.BackColor = SystemColors.ControlDarkDark;
            subtraction.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subtraction.ForeColor = SystemColors.HighlightText;
            subtraction.Location = new Point(441, 233);
            subtraction.Name = "subtraction";
            subtraction.Size = new Size(125, 88);
            subtraction.TabIndex = 14;
            subtraction.Text = "-";
            subtraction.UseVisualStyleBackColor = false;
            subtraction.Click += buttonValued_Click;
            // 
            // addition
            // 
            addition.BackColor = SystemColors.ControlDarkDark;
            addition.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addition.ForeColor = SystemColors.HighlightText;
            addition.Location = new Point(441, 139);
            addition.Name = "addition";
            addition.Size = new Size(125, 88);
            addition.TabIndex = 15;
            addition.Text = "+";
            addition.UseVisualStyleBackColor = false;
            addition.Click += buttonValued_Click;
            // 
            // multiplication
            // 
            multiplication.BackColor = SystemColors.ControlDarkDark;
            multiplication.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multiplication.ForeColor = SystemColors.HighlightText;
            multiplication.Location = new Point(441, 327);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(125, 88);
            multiplication.TabIndex = 16;
            multiplication.Text = "×";
            multiplication.UseVisualStyleBackColor = false;
            multiplication.Click += buttonValued_Click;
            // 
            // backspace
            // 
            backspace.BackColor = SystemColors.ControlDarkDark;
            backspace.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backspace.ForeColor = SystemColors.HighlightText;
            backspace.ImageAlign = ContentAlignment.TopCenter;
            backspace.Location = new Point(274, 421);
            backspace.Name = "backspace";
            backspace.Size = new Size(125, 88);
            backspace.TabIndex = 17;
            backspace.Text = "←";
            backspace.TextAlign = ContentAlignment.TopCenter;
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += buttonValued_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 616);
            Controls.Add(backspace);
            Controls.Add(multiplication);
            Controls.Add(addition);
            Controls.Add(subtraction);
            Controls.Add(division);
            Controls.Add(equals);
            Controls.Add(period);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonZero);
            Controls.Add(calcMain);
            Name = "Form1";
            Text = "Incomplete App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer runTimer;
        private TextBox calcMain;
        private Button buttonZero;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button period;
        private Button equals;
        private Button division;
        private Button subtraction;
        private Button addition;
        private Button multiplication;
        private Button backspace;
    }
}

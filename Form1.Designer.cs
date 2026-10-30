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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
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
            buttonOne.Click += buttonOne_Click;
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
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(143, 233);
            button1.Name = "button1";
            button1.Size = new Size(125, 88);
            button1.TabIndex = 6;
            button1.Text = "5";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(274, 233);
            button2.Name = "button2";
            button2.Size = new Size(125, 88);
            button2.TabIndex = 7;
            button2.Text = "6";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 327);
            button3.Name = "button3";
            button3.Size = new Size(125, 88);
            button3.TabIndex = 8;
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(143, 327);
            button4.Name = "button4";
            button4.Size = new Size(125, 88);
            button4.TabIndex = 9;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(274, 327);
            button5.Name = "button5";
            button5.Size = new Size(125, 88);
            button5.TabIndex = 10;
            button5.Text = "9";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(12, 421);
            button6.Name = "button6";
            button6.Size = new Size(125, 88);
            button6.TabIndex = 11;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 128, 0);
            button7.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.HighlightText;
            button7.Location = new Point(12, 514);
            button7.Name = "button7";
            button7.Size = new Size(554, 88);
            button7.TabIndex = 12;
            button7.Text = "=";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlDarkDark;
            button8.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.HighlightText;
            button8.Location = new Point(441, 327);
            button8.Name = "button8";
            button8.Size = new Size(125, 88);
            button8.TabIndex = 13;
            button8.Text = "÷";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlDarkDark;
            button9.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.HighlightText;
            button9.Location = new Point(441, 233);
            button9.Name = "button9";
            button9.Size = new Size(125, 88);
            button9.TabIndex = 14;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = SystemColors.ControlDarkDark;
            button10.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.ForeColor = SystemColors.HighlightText;
            button10.Location = new Point(441, 139);
            button10.Name = "button10";
            button10.Size = new Size(125, 88);
            button10.TabIndex = 15;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = SystemColors.ControlDarkDark;
            button11.Font = new Font("Courier New", 25.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.ForeColor = SystemColors.HighlightText;
            button11.Location = new Point(441, 421);
            button11.Name = "button11";
            button11.Size = new Size(125, 88);
            button11.TabIndex = 16;
            button11.Text = "×";
            button11.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 616);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}

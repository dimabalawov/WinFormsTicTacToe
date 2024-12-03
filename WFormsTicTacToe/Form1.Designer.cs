using System.Diagnostics.Tracing;

namespace WFormsTicTacToe
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            startButton = new Button();
            isBotFirst = new CheckBox();
            easyMode = new RadioButton();
            hardMode = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 135);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(155, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 135);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(297, 16);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(135, 135);
            button3.TabIndex = 0;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 159);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(135, 135);
            button4.TabIndex = 0;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(155, 159);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(135, 135);
            button5.TabIndex = 0;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(297, 159);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(135, 135);
            button6.TabIndex = 0;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(14, 301);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(135, 135);
            button7.TabIndex = 0;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(155, 301);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(135, 135);
            button8.TabIndex = 0;
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(297, 301);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(135, 135);
            button9.TabIndex = 0;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.Highlight;
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Cambria", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = SystemColors.ButtonHighlight;
            startButton.Location = new Point(454, 360);
            startButton.Margin = new Padding(3, 4, 3, 4);
            startButton.Name = "startButton";
            startButton.Size = new Size(189, 60);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // isBotFirst
            // 
            isBotFirst.AutoSize = true;
            isBotFirst.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            isBotFirst.Location = new Point(454, 247);
            isBotFirst.Margin = new Padding(3, 4, 3, 4);
            isBotFirst.Name = "isBotFirst";
            isBotFirst.Size = new Size(117, 23);
            isBotFirst.TabIndex = 2;
            isBotFirst.Text = "Bot starts first";
            isBotFirst.UseVisualStyleBackColor = true;
            // 
            // easyMode
            // 
            easyMode.AutoSize = true;
            easyMode.Location = new Point(454, 296);
            easyMode.Margin = new Padding(3, 4, 3, 4);
            easyMode.Name = "easyMode";
            easyMode.Size = new Size(102, 24);
            easyMode.TabIndex = 3;
            easyMode.TabStop = true;
            easyMode.Text = "Easy Mode";
            easyMode.UseVisualStyleBackColor = true;
            // 
            // hardMode
            // 
            hardMode.AutoSize = true;
            hardMode.Location = new Point(454, 328);
            hardMode.Margin = new Padding(3, 4, 3, 4);
            hardMode.Name = "hardMode";
            hardMode.Size = new Size(106, 24);
            hardMode.TabIndex = 3;
            hardMode.TabStop = true;
            hardMode.Text = "Hard Mode";
            hardMode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 456);
            Controls.Add(hardMode);
            Controls.Add(easyMode);
            Controls.Add(isBotFirst);
            Controls.Add(startButton);
            Controls.Add(button9);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Tic-Tac-Toe";
            Load += DisableAllButtons;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button startButton;
        private CheckBox isBotFirst;
        private RadioButton easyMode;
        private RadioButton hardMode;


    }

}
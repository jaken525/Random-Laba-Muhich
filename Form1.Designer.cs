﻿namespace WinFormsApp1
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
            CalculateButton = new Button();
            OutputBox = new RichTextBox();
            queueTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(202, 210);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(189, 23);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Вычислить";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // OutputBox
            // 
            OutputBox.Location = new Point(12, 12);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(379, 192);
            OutputBox.TabIndex = 1;
            OutputBox.Text = "";
            // 
            // queueTextBox
            // 
            queueTextBox.Location = new Point(144, 210);
            queueTextBox.MaxLength = 1;
            queueTextBox.Name = "queueTextBox";
            queueTextBox.Size = new Size(25, 23);
            queueTextBox.TabIndex = 2;
            queueTextBox.Text = "0";
            queueTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 213);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 3;
            label1.Text = "Количество мест:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 245);
            Controls.Add(label1);
            Controls.Add(queueTextBox);
            Controls.Add(OutputBox);
            Controls.Add(CalculateButton);
            Name = "Form1";
            Text = "Заправки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private RichTextBox OutputBox;
        private TextBox queueTextBox;
        private Label label1;
    }
}

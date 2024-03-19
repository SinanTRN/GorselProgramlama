namespace hafta4
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
            textBox1 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(169, 23);
            button1.TabIndex = 0;
            button1.Text = "En basit Dialog";
            button1.UseVisualStyleBackColor = true;
            button1.Click += basitDialogOlay;
            // 
            // button2
            // 
            button2.Location = new Point(187, 12);
            button2.Name = "button2";
            button2.Size = new Size(169, 23);
            button2.TabIndex = 1;
            button2.Text = "Başlıklı  Dialog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(372, 12);
            button3.Name = "button3";
            button3.Size = new Size(169, 23);
            button3.TabIndex = 2;
            button3.Text = "Evet/Hayır Dialog";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(558, 12);
            button4.Name = "button4";
            button4.Size = new Size(169, 23);
            button4.TabIndex = 4;
            button4.Text = "İkonlu Dialog";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 41);
            button5.Name = "button5";
            button5.Size = new Size(169, 23);
            button5.TabIndex = 0;
            button5.Text = "Dosya açma Dialog";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(187, 41);
            button6.Name = "button6";
            button6.Size = new Size(169, 23);
            button6.TabIndex = 0;
            button6.Text = "Dosya kaydetme Dialog";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(372, 41);
            button7.Name = "button7";
            button7.Size = new Size(169, 23);
            button7.TabIndex = 0;
            button7.Text = "Klasör açma Dialog";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.Location = new Point(558, 41);
            button9.Name = "button9";
            button9.Size = new Size(169, 23);
            button9.TabIndex = 0;
            button9.Text = "Renk Secme Dialog";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 70);
            button8.Name = "button8";
            button8.Size = new Size(169, 23);
            button8.TabIndex = 0;
            button8.Text = "Font Secme Dialog";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Dialoglar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button8;
    }
}

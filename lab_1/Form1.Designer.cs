namespace lab_1
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(9, 236);
            button1.Name = "button1";
            button1.Size = new Size(957, 48);
            button1.TabIndex = 0;
            button1.Text = "Вычислить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(373, 38);
            label1.TabIndex = 1;
            label1.Text = "Лабораторная работа №1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(954, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "54,4625";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 366);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(954, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(245, 25);
            label2.TabIndex = 4;
            label2.Text = "Число в десятичной системе";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 338);
            label3.Name = "label3";
            label3.Size = new Size(351, 25);
            label3.TabIndex = 5;
            label3.Text = "Представление числа в формате IEEE 754";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(12, 153);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(192, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "32-битный формат";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 188);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "64-битный формат";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 510);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(954, 31);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 586);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(954, 31);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 661);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(954, 31);
            textBox5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 482);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 11;
            label4.Text = "Знак";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 558);
            label5.Name = "label5";
            label5.Size = new Size(203, 25);
            label5.TabIndex = 12;
            label5.Text = "Смещённая экспонента";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 633);
            label6.Name = "label6";
            label6.Size = new Size(243, 25);
            label6.TabIndex = 13;
            label6.Text = "Нормализованная мантисса";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 409);
            label7.Name = "label7";
            label7.Size = new Size(233, 25);
            label7.TabIndex = 14;
            label7.Text = "Число в двоичной системе";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 437);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(954, 31);
            textBox6.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(978, 744);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 800);
            MinimumSize = new Size(1000, 800);
            Name = "Form1";
            Text = "Аникин 24ВП2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
    }
}

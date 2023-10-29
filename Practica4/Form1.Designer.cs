namespace Practica4
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
            label1 = new Label();
            label2 = new Label();
            a = new TextBox();
            label3 = new Label();
            b = new TextBox();
            label4 = new Label();
            c = new TextBox();
            label5 = new Label();
            d = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 11);
            label1.Name = "label1";
            label1.Size = new Size(435, 29);
            label1.TabIndex = 0;
            label1.Text = "Invertir Numeros En Orden Inverso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Numero A";
            // 
            // a
            // 
            a.Location = new Point(121, 97);
            a.Name = "a";
            a.Size = new Size(175, 23);
            a.TabIndex = 2;
            a.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(53, 158);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Numero B";
            // 
            // b
            // 
            b.Location = new Point(123, 146);
            b.Name = "b";
            b.Size = new Size(170, 23);
            b.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 201);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 5;
            label4.Text = "Numero C";
            // 
            // c
            // 
            c.Location = new Point(121, 197);
            c.Name = "c";
            c.Size = new Size(173, 23);
            c.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 243);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 7;
            label5.Text = "Numero D";
            // 
            // d
            // 
            d.Location = new Point(123, 236);
            d.Name = "d";
            d.Size = new Size(174, 23);
            d.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(376, 97);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 9;
            label6.Text = "Numero A";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(444, 89);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(202, 23);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(376, 146);
            label7.Name = "label7";
            label7.Size = new Size(61, 15);
            label7.TabIndex = 11;
            label7.Text = "Numero B";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(443, 143);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(202, 23);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(376, 197);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 13;
            label8.Text = "Numero C";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(443, 193);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(196, 23);
            textBox7.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 236);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 15;
            label9.Text = "Numero D";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(444, 233);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(201, 23);
            textBox8.TabIndex = 16;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(197, 303);
            button1.Name = "button1";
            button1.Size = new Size(326, 99);
            button1.TabIndex = 17;
            button1.Text = "INVERTIR OREN ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(d);
            Controls.Add(label5);
            Controls.Add(c);
            Controls.Add(label4);
            Controls.Add(b);
            Controls.Add(label3);
            Controls.Add(a);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Invertir Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox a;
        private Label label3;
        private TextBox b;
        private Label label4;
        private TextBox c;
        private Label label5;
        private TextBox d;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox8;
        private Button button1;
    }
}
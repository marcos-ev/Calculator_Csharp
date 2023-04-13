namespace Calculadora
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
            txtResultado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonc = new Button();
            buttonless = new Button();
            buttonmult = new Button();
            buttondiv = new Button();
            buttoncomma = new Button();
            buttonequal = new Button();
            buttonplus = new Button();
            txtOperacao = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            txtResultado.Location = new Point(12, 34);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(431, 78);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(10, 118);
            button1.Name = "button1";
            button1.Size = new Size(80, 53);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(96, 118);
            button2.Name = "button2";
            button2.Size = new Size(82, 53);
            button2.TabIndex = 0;
            button2.Text = "2";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(184, 118);
            button3.Name = "button3";
            button3.Size = new Size(82, 53);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(10, 177);
            button4.Name = "button4";
            button4.Size = new Size(80, 53);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(96, 177);
            button5.Name = "button5";
            button5.Size = new Size(82, 53);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(184, 177);
            button6.Name = "button6";
            button6.Size = new Size(82, 53);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(10, 236);
            button7.Name = "button7";
            button7.Size = new Size(80, 53);
            button7.TabIndex = 7;
            button7.Text = "7";
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(96, 236);
            button8.Name = "button8";
            button8.Size = new Size(82, 53);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(184, 236);
            button9.Name = "button9";
            button9.Size = new Size(82, 53);
            button9.TabIndex = 9;
            button9.Text = "9";
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(10, 295);
            button0.Name = "button0";
            button0.Size = new Size(168, 53);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.Click += button0_Click;
            // 
            // buttonc
            // 
            buttonc.Location = new Point(272, 118);
            buttonc.Name = "buttonc";
            buttonc.Size = new Size(171, 53);
            buttonc.TabIndex = 11;
            buttonc.Text = "C";
            buttonc.Click += buttonc_Click;
            // 
            // buttonless
            // 
            buttonless.Location = new Point(359, 177);
            buttonless.Name = "buttonless";
            buttonless.Size = new Size(84, 53);
            buttonless.TabIndex = 13;
            buttonless.Text = "-";
            buttonless.Click += buttonless_Click;
            // 
            // buttonmult
            // 
            buttonmult.Location = new Point(272, 236);
            buttonmult.Name = "buttonmult";
            buttonmult.Size = new Size(81, 53);
            buttonmult.TabIndex = 14;
            buttonmult.Text = "*";
            buttonmult.Click += buttonmult_Click;
            // 
            // buttondiv
            // 
            buttondiv.Location = new Point(359, 236);
            buttondiv.Name = "buttondiv";
            buttondiv.Size = new Size(84, 53);
            buttondiv.TabIndex = 15;
            buttondiv.Text = "/";
            buttondiv.Click += buttondiv_Click;
            // 
            // buttoncomma
            // 
            buttoncomma.Location = new Point(184, 295);
            buttoncomma.Name = "buttoncomma";
            buttoncomma.Size = new Size(82, 53);
            buttoncomma.TabIndex = 16;
            buttoncomma.Text = ",";
            buttoncomma.Click += buttoncomma_Click;
            // 
            // buttonequal
            // 
            buttonequal.Location = new Point(272, 295);
            buttonequal.Name = "buttonequal";
            buttonequal.Size = new Size(171, 53);
            buttonequal.TabIndex = 17;
            buttonequal.Text = "=";
            buttonequal.Click += buttonequal_Click;
            // 
            // buttonplus
            // 
            buttonplus.Location = new Point(272, 177);
            buttonplus.Name = "buttonplus";
            buttonplus.Size = new Size(81, 53);
            buttonplus.TabIndex = 19;
            buttonplus.Text = "+";
            buttonplus.Click += buttonplus_Click;
            // 
            // txtOperacao
            // 
            txtOperacao.BackColor = SystemColors.ScrollBar;
            txtOperacao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtOperacao.Location = new Point(12, 12);
            txtOperacao.Name = "txtOperacao";
            txtOperacao.Size = new Size(431, 25);
            txtOperacao.TabIndex = 20;
            txtOperacao.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 370);
            Controls.Add(txtOperacao);
            Controls.Add(buttonplus);
            Controls.Add(buttonequal);
            Controls.Add(buttoncomma);
            Controls.Add(buttondiv);
            Controls.Add(buttonmult);
            Controls.Add(buttonless);
            Controls.Add(buttonc);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonc;
        private Button buttonless;
        private Button buttonmult;
        private Button buttondiv;
        private Button buttoncomma;
        private Button buttonequal;
        private Button buttonplus;
        private TextBox txtOperacao;
    }
}
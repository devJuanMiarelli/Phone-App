namespace Projeto_Telefone___Felipe
{
    partial class Form3
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
            lblDiscagem = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnLigar = new Button();
            btnApagarDig = new Button();
            SuspendLayout();
            // 
            // lblDiscagem
            // 
            lblDiscagem.AutoSize = true;
            lblDiscagem.BackColor = SystemColors.ControlDarkDark;
            lblDiscagem.Location = new Point(12, 9);
            lblDiscagem.Name = "lblDiscagem";
            lblDiscagem.Size = new Size(0, 15);
            lblDiscagem.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 74);
            btn1.Name = "btn1";
            btn1.Size = new Size(38, 35);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(81, 74);
            btn2.Name = "btn2";
            btn2.Size = new Size(38, 35);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(150, 74);
            btn3.Name = "btn3";
            btn3.Size = new Size(38, 35);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(150, 125);
            btn4.Name = "btn4";
            btn4.Size = new Size(38, 35);
            btn4.TabIndex = 6;
            btn4.Text = "6";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(81, 125);
            btn5.Name = "btn5";
            btn5.Size = new Size(38, 35);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(12, 125);
            btn6.Name = "btn6";
            btn6.Size = new Size(38, 35);
            btn6.TabIndex = 4;
            btn6.Text = "4";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(150, 177);
            btn7.Name = "btn7";
            btn7.Size = new Size(38, 35);
            btn7.TabIndex = 9;
            btn7.Text = "9";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(81, 177);
            btn8.Name = "btn8";
            btn8.Size = new Size(38, 35);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(12, 177);
            btn9.Name = "btn9";
            btn9.Size = new Size(38, 35);
            btn9.TabIndex = 7;
            btn9.Text = "7";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(81, 228);
            btn0.Name = "btn0";
            btn0.Size = new Size(38, 35);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnLigar
            // 
            btnLigar.BackColor = Color.FromArgb(0, 192, 0);
            btnLigar.Location = new Point(72, 280);
            btnLigar.Name = "btnLigar";
            btnLigar.Size = new Size(58, 35);
            btnLigar.TabIndex = 11;
            btnLigar.UseVisualStyleBackColor = false;
            btnLigar.Click += btnLigar_Click;
            // 
            // btnApagarDig
            // 
            btnApagarDig.Location = new Point(130, 228);
            btnApagarDig.Name = "btnApagarDig";
            btnApagarDig.Size = new Size(58, 35);
            btnApagarDig.TabIndex = 12;
            btnApagarDig.Text = "<---";
            btnApagarDig.UseVisualStyleBackColor = true;
            btnApagarDig.Click += btnApagarDig_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 346);
            Controls.Add(btnApagarDig);
            Controls.Add(btnLigar);
            Controls.Add(btn0);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblDiscagem);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDiscagem;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnLigar;
        private Button btnApagarDig;
    }
}
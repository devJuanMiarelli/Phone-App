namespace Projeto_Telefone___Felipe
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnImagem = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            pb1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 68);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Imagem";
            // 
            // btnImagem
            // 
            btnImagem.Location = new Point(66, 64);
            btnImagem.Name = "btnImagem";
            btnImagem.Size = new Size(100, 23);
            btnImagem.TabIndex = 3;
            btnImagem.Text = "Arquivo.png";
            btnImagem.UseVisualStyleBackColor = true;
            btnImagem.Click += btnImagem_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(66, 6);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 4;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(66, 35);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(100, 23);
            txtTelefone.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(12, 107);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(154, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 136);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pb1
            // 
            pb1.Location = new Point(188, 12);
            pb1.Name = "pb1";
            pb1.Size = new Size(186, 183);
            pb1.TabIndex = 8;
            pb1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 207);
            Controls.Add(pb1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(btnImagem);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnImagem;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Button btnSalvar;
        private Button btnCancelar;
        private PictureBox pb1;
    }
}
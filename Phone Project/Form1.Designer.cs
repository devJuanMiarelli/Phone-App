namespace Projeto_Telefone___Felipe
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
            grid = new DataGridView();
            Imagem = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            btnAlterar = new Button();
            btnDelete = new Button();
            btnChamar = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Lista de Contatos";
            // 
            // grid
            // 
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Columns.AddRange(new DataGridViewColumn[] { Imagem, Nome, Telefone });
            grid.Location = new Point(12, 27);
            grid.Name = "grid";
            grid.RowTemplate.Height = 25;
            grid.Size = new Size(343, 411);
            grid.TabIndex = 1;
            // 
            // Imagem
            // 
            Imagem.HeaderText = "Imagem";
            Imagem.Name = "Imagem";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.Name = "Telefone";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(361, 27);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 69);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(361, 139);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(148, 69);
            btnAlterar.TabIndex = 3;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(361, 247);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(148, 69);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChamar
            // 
            btnChamar.Location = new Point(361, 369);
            btnChamar.Name = "btnChamar";
            btnChamar.Size = new Size(148, 69);
            btnChamar.TabIndex = 5;
            btnChamar.Text = "Chamar";
            btnChamar.UseVisualStyleBackColor = true;
            btnChamar.Click += btnChamar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 450);
            Controls.Add(btnChamar);
            Controls.Add(btnDelete);
            Controls.Add(btnAlterar);
            Controls.Add(btnAdd);
            Controls.Add(grid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView grid;
        private Button btnAdd;
        private Button btnAlterar;
        private Button btnDelete;
        private Button btnChamar;
        private DataGridViewTextBoxColumn Imagem;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
    }
}
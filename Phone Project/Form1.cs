using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Projeto_Telefone___Felipe
{
    public partial class Form1 : Form
    {
        private List<Contato> contatos;
        private Contato contatoSelecionado;
        private bool contatoEditado;
        public Form1()
        {
            InitializeComponent();
            contatos = new List<Contato>();
        }

        public List<Contato> ObterContatos()
        {
            return contatos;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

            DialogResult result = form2.DialogResult;

            if (result == DialogResult.OK)
            {
                Contato novoContato = new Contato(form2.FotoContato, form2.Nome, form2.Telefone);
                contatos.Add(novoContato);

                int rowIndex = grid.Rows.Add();
                DataGridViewRow row = grid.Rows[rowIndex];
                row.Cells["Imagem"].Value = novoContato.ImagemMenor;
                row.Cells["Nome"].Value = novoContato.Nome;
                row.Cells["Telefone"].Value = novoContato.Telefone;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (grid.SelectedCells.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                contatoSelecionado = contatos[rowIndex];

                Form2 form2 = new Form2();
                form2.Nome = contatoSelecionado.Nome;
                form2.Telefone = contatoSelecionado.Telefone;
                form2.FotoContato = contatoSelecionado.FotoCerta;

                form2.ShowDialog();

                DialogResult result = form2.DialogResult;

                if (result == DialogResult.OK)
                {
                    contatoSelecionado.Nome = form2.Nome;
                    contatoSelecionado.Telefone = form2.Telefone;

                    if (contatoSelecionado.FotoCerta != form2.FotoContato)
                    {
                        contatoSelecionado.FotoCerta = form2.FotoContato;
                        contatoSelecionado.ImagemMenor = form2.FotoContato.GetThumbnailImage(20, 20, null, IntPtr.Zero);
                    }

                    contatoEditado = true;

                    DataGridViewRow row = grid.Rows[rowIndex];
                    row.Cells["Nome"].Value = contatoSelecionado.Nome;
                    row.Cells["Telefone"].Value = contatoSelecionado.Telefone;
                    row.Cells["Imagem"].Value = contatoSelecionado.ImagemMenor;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grid.SelectedCells.Count > 0)
            {
                int rowIndex = grid.SelectedCells[0].RowIndex;
                grid.Rows.RemoveAt(rowIndex);
                contatos.RemoveAt(rowIndex);
            }
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        public class Contato
        {
            public Image FotoCerta { get; set; }
            public Image ImagemMenor { get; set; }
            public string Nome { get; set; }
            public string Telefone { get; set; }

            public Contato(Image fotoCerta, string nome, string telefone)
            {
                FotoCerta = fotoCerta;
                ImagemMenor = fotoCerta.GetThumbnailImage(20, 20, null, IntPtr.Zero);
                Nome = nome;
                Telefone = telefone;
            }
        }

        public bool VerificarNumeroNoGrid(string telefone)
        {
            foreach (Contato contato in contatos)
            {
                if (contato.Telefone == telefone)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
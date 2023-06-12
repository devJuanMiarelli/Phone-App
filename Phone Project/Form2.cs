using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Projeto_Telefone___Felipe
{
    public partial class Form2 : Form
    {

        public Image FotoContato { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Form2()
        {
            InitializeComponent();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nome = txtNome.Text;
            Telefone = txtTelefone.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;|Todos os Arquivos|*.*";
            openFileDialog.Title = "Selecione uma Foto";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string foto = openFileDialog.FileName;
                FotoContato = Image.FromFile(foto);
                pb1.Image = FotoContato;
            }
        }
    }
}

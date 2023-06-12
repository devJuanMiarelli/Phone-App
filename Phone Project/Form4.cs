using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Telefone___Felipe
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetarNome(string nome)
        {
            lblContatoSalvo.Text = nome;
        }

        public void SetarImagem(Image imagem)
        {
            pb2.Image = imagem;
        }
    }
}

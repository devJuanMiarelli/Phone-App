using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Projeto_Telefone___Felipe.Form1;

namespace Projeto_Telefone___Felipe
{
    public partial class Form3 : Form
    {

        private string numeroDiscado;

        public Form3()
        {
            InitializeComponent();
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            List<Contato> contatos = form1?.ObterContatos();

            if (contatos != null)
            {
                Contato contatoDiscado = contatos.FirstOrDefault(c => c.Telefone == lblDiscagem.Text);

                if (contatoDiscado != null)
                {
                    Form4 form4 = new Form4();
                    form4.SetarNome(contatoDiscado.Nome);
                    form4.SetarImagem(contatoDiscado.ImagemMenor);
                    form4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("O número não corresponde a nenhum contato.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnApagarDig_Click(object sender, EventArgs e)
        {
            if (lblDiscagem.Text.Length > 0)
            {
                lblDiscagem.Text = lblDiscagem.Text.Remove(lblDiscagem.Text.Length - 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            string num = btn.Text;
            lblDiscagem.Text += num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;


namespace Consultado_API_CEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(formCepTxt.Text))
            {
                MessageBox.Show("O campo de CEP está vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {



                    CorreiosApi correiosApi = new CorreiosApi();
                    var retorno = correiosApi.consultaCEP(formCepTxt.Text);

                    if (retorno is null)
                    {
                       
                        //Vai sair do código

                        return;
                    }

                    formTextEstado.Text = retorno.uf;
                    formTextCidade.Text = retorno.cidade;
                    formTextEndereco.Text = retorno.end;
                    formTextComplemento1.Text = retorno.complemento;

                    formTextBairro.Text = retorno.bairro;
                }
                catch(Exception erro)
                {
                    MessageBox.Show("CEP não encontrado : " + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair da aplicação?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void formCepTxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

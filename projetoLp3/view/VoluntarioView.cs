using projetoLp3.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLp3
{
    public partial class VoluntarioView : Form
    {
        public VoluntarioView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cria uma nova pessoa passando parametros para construtor
            PessoaModel pessoaModel = new PessoaModel(txtCpf.Text, txtNome.Text, txtCelular.Text, txtEmail.Text);
            //Imprime objeto pessoa para teste
            Console.WriteLine(pessoaModel.Cpf+pessoaModel.Nome+pessoaModel.Celular+pessoaModel.Email);
            //Cria objeto pessoaDAO responsavel pela persistencia dos dados
            PessoaDAO pessoaDAO = new PessoaDAO();
            //chama metodo criar pessoa passando o modelo criado
            pessoaDAO.createPessoa(pessoaModel);
            //Limpa os campos da interface
            limparCampos();
        }

        private void limparCampos()
        {
            txtCpf.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }
    }
}

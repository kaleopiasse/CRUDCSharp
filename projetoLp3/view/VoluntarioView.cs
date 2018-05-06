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
        //Cria objeto pessoaModel
        PessoaModel pessoaModel = new PessoaModel();
        //Cria objeto pessoaDAO responsavel pela persistencia dos dados
        PessoaDAO pessoaDAO = new PessoaDAO();
        public VoluntarioView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //define valores pessoaModel a partir dos dados da interface
            pessoaModel.Cpf = txtCpf.Text;
            pessoaModel.Nome = txtNome.Text;
            pessoaModel.Celular = txtCelular.Text;
            pessoaModel.Email = txtEmail.Text;
            //Imprime objeto pessoa para teste
            Console.WriteLine(pessoaModel.Cpf+pessoaModel.Nome+pessoaModel.Celular+pessoaModel.Email);
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
            pessoaModel=pessoaDAO.readPessoaPorCpf(txtCpf.Text);
            txtCpf.Text = pessoaModel.Cpf;
            txtNome.Text = pessoaModel.Nome;
            txtCelular.Text = pessoaModel.Celular;
            txtEmail.Text = pessoaModel.Email;
        }
    }
}

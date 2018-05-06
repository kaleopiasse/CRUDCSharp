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

namespace projetoLp3.view
{
    public partial class TesteView : Form
    {
        PessoaDAO pessoaDAO = new PessoaDAO();
        public TesteView()
        {
            InitializeComponent();
            dgvPessoas.DataSource =  pessoaDAO.readPessoasTable();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            VoluntarioView voluntarioView = new VoluntarioView();
            voluntarioView.Show();
        }
    }
}

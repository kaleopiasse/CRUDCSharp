using projetoLp3.view;
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
    public partial class HomeView : Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void btnVoluntario_Click(object sender, EventArgs e)
        {
            /*
            VoluntarioView voluntarioView = new VoluntarioView();
            voluntarioView.TopLevel = false;
            pnHome.Controls.Add(voluntarioView);
            voluntarioView.FormBorderStyle = FormBorderStyle.None;
            voluntarioView.Show();
            */

            TesteView testeView = new TesteView();
            testeView.TopLevel = false;
            pnHome.Controls.Add(testeView);
            testeView.FormBorderStyle = FormBorderStyle.None;
            testeView.Show();

        }
    }
}

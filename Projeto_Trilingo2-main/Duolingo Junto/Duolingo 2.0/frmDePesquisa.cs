using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duolingo_2._0
{
    public partial class frmDePesquisa : Form
    {
        public frmDePesquisa()
        {
            InitializeComponent();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sairOuNao = MessageBox.Show("Deseja voltar ao menu principal?", "Alerta de saída", MessageBoxButtons.OKCancel);
            if (sairOuNao == DialogResult.OK)
            {
                this.Hide();
                new frmPrincipal().ShowDialog();
            }
            else
                return;
        }
    }
}

using SendEmail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        private void frmDePesquisa_Load(object sender, EventArgs e)
        {
            cmbBoxDificuldadesUso.Items.Add("Interface confusa");
            cmbBoxDificuldadesUso.Items.Add("Falta de explicação");
            cmbBoxDificuldadesUso.Items.Add("Falta de conteúdo de aprendizado");
            cmbBoxDificuldadesUso.Items.Add("Falta de estímulo para jogar");
            cmbBoxDificuldadesUso.Items.Add("Simplesmente não gostei");
        }

        private void btnEnviaAvaliacao_Click(object sender, EventArgs e)
        {
            string dificuldadeUso = cmbBoxDificuldadesUso.Text;
            if (txtBoxNome.Text == string.Empty || cmbBoxDificuldadesUso.Text == string.Empty) 
            {
                MessageBox.Show("Preencha os campos obrigatórios para continuar!");
            }
            else
            {
                var emailSender = new Email("smtp.office365.com", "emaila ser enviado", "senha do email");

                string foiDificil = rdBtnFacilUsoSim.Checked ? "Sim" : "Não";

                string avaliacao = $"Meu nome é {txtBoxNome.Text}<br>" +
                    $"Nascido(a) em {dateTimePicker.Value.ToString("dd-MM-yyyy")}<br>" +
                    $"Tive dificuldade em utilizar o app? {foiDificil}<br>" +
                    $"Minha maior dificuldade foi: {dificuldadeUso}<br>" +
                    $"Avaliação: {txtAvaliacao.Text}";
                emailSender.SendEmail(

                            emailsTo: new List<string>
                            {
                                "email que irá receber"
                            },
                            subject: $"Avaliação de {txtBoxNome.Text}",
                            body: avaliacao
                            
                    );
                string email="";
                foreach(var users in Program.listaUser)
                {
                    email = users.Email;
                }
                emailSender.SendEmail(

                            emailsTo: new List<string>
                            {
                                email
                            },
                            subject: "Recebemos sua avaliação!",
                            body: "Olá, aqui é o João da Trilingo. Estou passando aqui apenas para agradecer sua avaliação, ela é muito importante para nós!"

                    ) ;
                MessageBox.Show("Sua avaliação foi enviada!", "Sucesso no envio");
                txtBoxNome.Text = cmbBoxDificuldadesUso.Text = txtAvaliacao.Text = string.Empty;
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sairOuNao = MessageBox.Show("Deseja mesmo deslogar?", "Alerta de saída", MessageBoxButtons.OKCancel);
            if (sairOuNao == DialogResult.OK)
            {
                this.Hide();
                Program.listaUser.Clear();
                new frmLogin().ShowDialog();
            }
            else
                return;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sairOuNao = MessageBox.Show("Deseja mesmo sair?", "Alerta de saída", MessageBoxButtons.OKCancel);
            if (sairOuNao == DialogResult.OK)
                System.Windows.Forms.Application.Exit();
            else
                return;
        }
    }
}

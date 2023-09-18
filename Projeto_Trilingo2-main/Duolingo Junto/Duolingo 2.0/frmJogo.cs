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
    public partial class frmJogo : Form
    {
        public frmJogo()
        {
            InitializeComponent();
        }

        private void frmJogo_Load(object sender, EventArgs e)
        {
            Random P = new Random();
            Random M = new Random();
            pictureBox3.Hide();
            lblF.Hide();

            if (L == 1)
            {
                while (pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = eng.Pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = eng.Pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = eng.Pergunta3[p];
                                    break;
                            }
                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblQ.Text = "Escreva o nome do animal";
                        lblF.Hide();
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    pictureBox3.Image = eng.Imagem1[p];
                                    break;
                                case 2:
                                    pictureBox3.Image = eng.Imagem2[p];
                                    break;
                                case 3:
                                    pictureBox3.Image = eng.Imagem3[p];
                                    break;

                            }
                            pictureBox3.Show();
                            pictureBox3.Location = new Point(496, 125);
                            Q = p;
                        }
                        break;
                    }
                }
            } // Configuração em Ingles
            else if (L == 2)
            {
                while (pgb.Value != 100)
                {
                    int Mg = M.Next(1, 3);
                    int p = P.Next(5);
                    if (Mg == 1)
                    {
                        f = true;
                        lblQ.Text = "Traduza a frase";
                        pictureBox3.Hide();
                        while (jf.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            jf[p] = p + 1;
                            lblF.Show();
                            switch (D)
                            {
                                case 1:
                                    lblF.Text = it.pergunta1[p];
                                    break;
                                case 2:
                                    lblF.Text = it.pergunta2[p];
                                    break;
                                case 3:
                                    lblF.Text = it.pergunta3[p];
                                    break;

                            }

                            Q = p;
                        }
                        break;
                    }
                    if (Mg == 2)
                    {
                        f = false;
                        lblF.Hide();
                        lblQ.Text = "Escreva o nome do animal";
                        while (ji.Contains(p + 1))
                        {
                            p = P.Next(5);
                        }
                        {
                            ji[p] = p + 1;
                            switch (D)
                            {
                                case 1:
                                    pictureBox3.Image = it.Imagem1[p];
                                    break;
                                case 2:
                                    pictureBox3.Image = it.Imagem2[p];
                                    break;
                                case 3:
                                    pictureBox3.Image = it.Imagem3[p];
                                    break;

                            }
                            Q = p;
                        }
                        pictureBox3.Location = new Point(496, 125);
                        pictureBox3.Show();
                        break;
                    }
                }
            } // Configuração em Italiano
        }

        private void txtbR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnE.PerformClick();
        }

    }
}

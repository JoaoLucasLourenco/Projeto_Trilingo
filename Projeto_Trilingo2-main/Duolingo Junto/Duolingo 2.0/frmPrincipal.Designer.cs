namespace Duolingo_2._0
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnhs = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.TextBox();
            this.txtbR = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pgb = new System.Windows.Forms.ProgressBar();
            this.lblQ = new System.Windows.Forms.Label();
            this.hs = new System.Windows.Forms.Timer(this.components);
            this.ex = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuDeAçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioDePesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(224, 239);
            this.btnJ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(157, 44);
            this.btnJ.TabIndex = 0;
            this.btnJ.Text = "Jogar";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnJ_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(224, 342);
            this.btnT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(157, 44);
            this.btnT.TabIndex = 1;
            this.btnT.Text = "Como jogar";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnT_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(224, 290);
            this.btnC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(157, 44);
            this.btnC.TabIndex = 2;
            this.btnC.Text = "Configurações";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(720, 463);
            this.btnE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(157, 44);
            this.btnE.TabIndex = 4;
            this.btnE.Text = "Enviar";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Visible = false;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(224, 507);
            this.btnR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(157, 44);
            this.btnR.TabIndex = 5;
            this.btnR.Text = "Tentar Novamente";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Visible = false;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(224, 559);
            this.btnM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(157, 44);
            this.btnM.TabIndex = 6;
            this.btnM.Text = "Menu";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Visible = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // btnhs
            // 
            this.btnhs.Location = new System.Drawing.Point(224, 610);
            this.btnhs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhs.Name = "btnhs";
            this.btnhs.Size = new System.Drawing.Size(157, 44);
            this.btnhs.TabIndex = 7;
            this.btnhs.Text = "Highcore";
            this.btnhs.UseVisualStyleBackColor = true;
            this.btnhs.Visible = false;
            this.btnhs.Click += new System.EventHandler(this.btnhs_Click);
            // 
            // lblF
            // 
            this.lblF.Location = new System.Drawing.Point(553, 350);
            this.lblF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblF.Name = "lblF";
            this.lblF.ReadOnly = true;
            this.lblF.Size = new System.Drawing.Size(473, 22);
            this.lblF.TabIndex = 8;
            this.lblF.Visible = false;
            // 
            // txtbR
            // 
            this.txtbR.Location = new System.Drawing.Point(553, 431);
            this.txtbR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbR.Name = "txtbR";
            this.txtbR.Size = new System.Drawing.Size(473, 22);
            this.txtbR.TabIndex = 9;
            this.txtbR.Visible = false;
            this.txtbR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbR_KeyPress);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Duolingo_2._0.Properties.Resources.duofeliz;
            this.pictureBox3.Location = new System.Drawing.Point(719, 127);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 215);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Duolingo_2._0.Properties.Resources.trilingo;
            this.pictureBox2.Location = new System.Drawing.Point(553, 498);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(419, 334);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pgb
            // 
            this.pgb.Location = new System.Drawing.Point(-3, 817);
            this.pgb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgb.Name = "pgb";
            this.pgb.Size = new System.Drawing.Size(1689, 28);
            this.pgb.TabIndex = 12;
            this.pgb.Visible = false;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblQ.Location = new System.Drawing.Point(615, 74);
            this.lblQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(336, 50);
            this.lblQ.TabIndex = 13;
            this.lblQ.Text = "Traduza essa frase";
            this.lblQ.Visible = false;
            // 
            // hs
            // 
            this.hs.Interval = 1000;
            this.hs.Tick += new System.EventHandler(this.hs_Tick);
            // 
            // ex
            // 
            this.ex.AutoSize = true;
            this.ex.Location = new System.Drawing.Point(16, 11);
            this.ex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex.Name = "ex";
            this.ex.Size = new System.Drawing.Size(0, 16);
            this.ex.TabIndex = 14;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeAçõesToolStripMenuItem,
            this.menuPrincipalToolStripMenuItem,
            this.sairToolStripMenuItem,
            this.formulárioDePesquisaToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(1121, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(250, 750);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuDeAçõesToolStripMenuItem
            // 
            this.menuDeAçõesToolStripMenuItem.Name = "menuDeAçõesToolStripMenuItem";
            this.menuDeAçõesToolStripMenuItem.Size = new System.Drawing.Size(239, 4);
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuPrincipalToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.menuPrincipalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.menuPrincipalToolStripMenuItem.Text = "LogOut";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.sairToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // formulárioDePesquisaToolStripMenuItem
            // 
            this.formulárioDePesquisaToolStripMenuItem.BackColor = System.Drawing.Color.SkyBlue;
            this.formulárioDePesquisaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.formulárioDePesquisaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.formulárioDePesquisaToolStripMenuItem.Name = "formulárioDePesquisaToolStripMenuItem";
            this.formulárioDePesquisaToolStripMenuItem.Size = new System.Drawing.Size(239, 32);
            this.formulárioDePesquisaToolStripMenuItem.Text = "Formulário de Pesquisa";
            this.formulárioDePesquisaToolStripMenuItem.Click += new System.EventHandler(this.formulárioDePesquisaToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.ex);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.pgb);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtbR);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.btnhs);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnT);
            this.Controls.Add(this.btnJ);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJ;
        private System.Windows.Forms.Button btnT;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnhs;
        private System.Windows.Forms.TextBox lblF;
        private System.Windows.Forms.TextBox txtbR;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ProgressBar pgb;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.Timer hs;
        private System.Windows.Forms.Label ex;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuDeAçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioDePesquisaToolStripMenuItem;
    }
}
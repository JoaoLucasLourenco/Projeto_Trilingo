namespace Duolingo_2._0
{
    partial class frmJogo
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
            this.lblQ = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtbR = new System.Windows.Forms.TextBox();
            this.lblF = new System.Windows.Forms.TextBox();
            this.btnE = new System.Windows.Forms.Button();
            this.btnhs = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold);
            this.lblQ.Location = new System.Drawing.Point(646, 122);
            this.lblQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(336, 50);
            this.lblQ.TabIndex = 18;
            this.lblQ.Text = "Traduza essa frase";
            this.lblQ.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Duolingo_2._0.Properties.Resources.duofeliz;
            this.pictureBox3.Location = new System.Drawing.Point(684, 175);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(265, 215);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // txtbR
            // 
            this.txtbR.Location = new System.Drawing.Point(584, 479);
            this.txtbR.Margin = new System.Windows.Forms.Padding(4);
            this.txtbR.Name = "txtbR";
            this.txtbR.Size = new System.Drawing.Size(473, 22);
            this.txtbR.TabIndex = 16;
            this.txtbR.Visible = false;
            // 
            // lblF
            // 
            this.lblF.Location = new System.Drawing.Point(584, 398);
            this.lblF.Margin = new System.Windows.Forms.Padding(4);
            this.lblF.Name = "lblF";
            this.lblF.ReadOnly = true;
            this.lblF.Size = new System.Drawing.Size(473, 22);
            this.lblF.TabIndex = 15;
            this.lblF.Visible = false;
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(751, 511);
            this.btnE.Margin = new System.Windows.Forms.Padding(4);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(157, 44);
            this.btnE.TabIndex = 14;
            this.btnE.Text = "Enviar";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Visible = false;
            // 
            // btnhs
            // 
            this.btnhs.Location = new System.Drawing.Point(283, 449);
            this.btnhs.Margin = new System.Windows.Forms.Padding(4);
            this.btnhs.Name = "btnhs";
            this.btnhs.Size = new System.Drawing.Size(157, 44);
            this.btnhs.TabIndex = 21;
            this.btnhs.Text = "Highcore";
            this.btnhs.UseVisualStyleBackColor = true;
            this.btnhs.Visible = false;
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(283, 398);
            this.btnM.Margin = new System.Windows.Forms.Padding(4);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(157, 44);
            this.btnM.TabIndex = 20;
            this.btnM.Text = "Menu";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Visible = false;
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(283, 346);
            this.btnR.Margin = new System.Windows.Forms.Padding(4);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(157, 44);
            this.btnR.TabIndex = 19;
            this.btnR.Text = "Tentar Novamente";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Visible = false;
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1688, 836);
            this.Controls.Add(this.btnhs);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnR);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtbR);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.btnE);
            this.Name = "frmJogo";
            this.Text = "frmJogo";
            this.Load += new System.EventHandler(this.frmJogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtbR;
        private System.Windows.Forms.TextBox lblF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnhs;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.Button btnR;
    }
}
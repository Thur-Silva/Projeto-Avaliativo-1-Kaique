namespace Projeto_Avaliativo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTusuario = new System.Windows.Forms.TextBox();
            this.LBLnome = new System.Windows.Forms.Label();
            this.LBLnivel = new System.Windows.Forms.Label();
            this.LBLacesso = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PBfoto = new System.Windows.Forms.PictureBox();
            this.PBsenha = new System.Windows.Forms.PictureBox();
            this.PBusuario = new System.Windows.Forms.PictureBox();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.BTNlogin = new System.Windows.Forms.Button();
            this.PBhome = new System.Windows.Forms.PictureBox();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.LBLsenha = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pageSetupDialog2 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBusuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTusuario
            // 
            this.TXTusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTusuario.Location = new System.Drawing.Point(176, 150);
            this.TXTusuario.Multiline = true;
            this.TXTusuario.Name = "TXTusuario";
            this.TXTusuario.Size = new System.Drawing.Size(147, 36);
            this.TXTusuario.TabIndex = 2;
            this.TXTusuario.TextChanged += new System.EventHandler(this.TXTnome_TextChanged);
            // 
            // LBLnome
            // 
            this.LBLnome.AutoSize = true;
            this.LBLnome.Location = new System.Drawing.Point(369, 244);
            this.LBLnome.Name = "LBLnome";
            this.LBLnome.Size = new System.Drawing.Size(35, 13);
            this.LBLnome.TabIndex = 7;
            this.LBLnome.Text = "Nome";
            this.LBLnome.Click += new System.EventHandler(this.LBLnome_Click);
            // 
            // LBLnivel
            // 
            this.LBLnivel.AutoSize = true;
            this.LBLnivel.Location = new System.Drawing.Point(369, 294);
            this.LBLnivel.Name = "LBLnivel";
            this.LBLnivel.Size = new System.Drawing.Size(33, 13);
            this.LBLnivel.TabIndex = 8;
            this.LBLnivel.Text = "Nível";
            this.LBLnivel.Click += new System.EventHandler(this.LBLnivel_Click);
            // 
            // LBLacesso
            // 
            this.LBLacesso.BackColor = System.Drawing.Color.Transparent;
            this.LBLacesso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBLacesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLacesso.ForeColor = System.Drawing.Color.Turquoise;
            this.LBLacesso.Location = new System.Drawing.Point(0, 418);
            this.LBLacesso.Name = "LBLacesso";
            this.LBLacesso.Size = new System.Drawing.Size(800, 32);
            this.LBLacesso.TabIndex = 9;
            this.LBLacesso.Text = "ACESSO";
            this.LBLacesso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox6.Image = global::Projeto_Avaliativo.Properties.Resources.SENAI_São_Paulo_logo;
            this.pictureBox6.Location = new System.Drawing.Point(21, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(158, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = global::Projeto_Avaliativo.Properties.Resources.caderno__2_;
            this.pictureBox5.Location = new System.Drawing.Point(709, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 51);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.ClickRelatorio);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::Projeto_Avaliativo.Properties.Resources.config__1_;
            this.pictureBox4.Location = new System.Drawing.Point(640, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.ClickConfig);
            // 
            // PBfoto
            // 
            this.PBfoto.Location = new System.Drawing.Point(233, 244);
            this.PBfoto.Name = "PBfoto";
            this.PBfoto.Size = new System.Drawing.Size(113, 92);
            this.PBfoto.TabIndex = 6;
            this.PBfoto.TabStop = false;
            this.PBfoto.Click += new System.EventHandler(this.PBfoto_Click);
            // 
            // PBsenha
            // 
            this.PBsenha.BackColor = System.Drawing.Color.Transparent;
            this.PBsenha.Image = global::Projeto_Avaliativo.Properties.Resources.cadeado;
            this.PBsenha.Location = new System.Drawing.Point(499, 118);
            this.PBsenha.Name = "PBsenha";
            this.PBsenha.Size = new System.Drawing.Size(95, 96);
            this.PBsenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBsenha.TabIndex = 1;
            this.PBsenha.TabStop = false;
            this.PBsenha.Click += new System.EventHandler(this.PBsenha_Click);
            // 
            // PBusuario
            // 
            this.PBusuario.BackColor = System.Drawing.Color.Transparent;
            this.PBusuario.BackgroundImage = global::Projeto_Avaliativo.Properties.Resources.crie_uma_logo_de_usuario_para_login_de_app_;
            this.PBusuario.Image = global::Projeto_Avaliativo.Properties.Resources.crie_uma_logo_de_usuario_para_login_de_app_;
            this.PBusuario.Location = new System.Drawing.Point(74, 118);
            this.PBusuario.Name = "PBusuario";
            this.PBusuario.Size = new System.Drawing.Size(96, 96);
            this.PBusuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBusuario.TabIndex = 0;
            this.PBusuario.TabStop = false;
            this.PBusuario.Click += new System.EventHandler(this.PBusuario_Click);
            // 
            // TXTsenha
            // 
            this.TXTsenha.Location = new System.Drawing.Point(592, 150);
            this.TXTsenha.Multiline = true;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(146, 36);
            this.TXTsenha.TabIndex = 13;
            this.TXTsenha.TextChanged += new System.EventHandler(this.TXTsenha_TextChanged);
            // 
            // BTNlogin
            // 
            this.BTNlogin.BackgroundImage = global::Projeto_Avaliativo.Properties.Resources.istockphoto_1386828570_612x6123;
            this.BTNlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNlogin.ForeColor = System.Drawing.Color.GhostWhite;
            this.BTNlogin.Location = new System.Drawing.Point(362, 134);
            this.BTNlogin.Name = "BTNlogin";
            this.BTNlogin.Size = new System.Drawing.Size(91, 63);
            this.BTNlogin.TabIndex = 14;
            this.BTNlogin.Text = "LOGIN";
            this.BTNlogin.UseVisualStyleBackColor = true;
            this.BTNlogin.Click += new System.EventHandler(this.BTNlogin_Click);
            // 
            // PBhome
            // 
            this.PBhome.BackColor = System.Drawing.Color.Transparent;
            this.PBhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBhome.Image = global::Projeto_Avaliativo.Properties.Resources.mainmenu_Photoroom;
            this.PBhome.Location = new System.Drawing.Point(640, 12);
            this.PBhome.Name = "PBhome";
            this.PBhome.Size = new System.Drawing.Size(47, 51);
            this.PBhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBhome.TabIndex = 15;
            this.PBhome.TabStop = false;
            this.PBhome.Visible = false;
            this.PBhome.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // LBLusuario
            // 
            this.LBLusuario.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLusuario.Location = new System.Drawing.Point(176, 125);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(58, 22);
            this.LBLusuario.TabIndex = 18;
            this.LBLusuario.Text = "Usuário";
            this.LBLusuario.Click += new System.EventHandler(this.LBLusuario_Click);
            // 
            // LBLsenha
            // 
            this.LBLsenha.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsenha.Location = new System.Drawing.Point(597, 125);
            this.LBLsenha.Name = "LBLsenha";
            this.LBLsenha.Size = new System.Drawing.Size(58, 22);
            this.LBLsenha.TabIndex = 19;
            this.LBLsenha.Text = "Senha";
            this.LBLsenha.Click += new System.EventHandler(this.LBLsenha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Avaliativo.Properties.Resources.Copia_do_primeiro2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLsenha);
            this.Controls.Add(this.LBLusuario);
            this.Controls.Add(this.PBhome);
            this.Controls.Add(this.BTNlogin);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LBLacesso);
            this.Controls.Add(this.LBLnivel);
            this.Controls.Add(this.LBLnome);
            this.Controls.Add(this.PBfoto);
            this.Controls.Add(this.TXTusuario);
            this.Controls.Add(this.PBsenha);
            this.Controls.Add(this.PBusuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBfoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBsenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBusuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PBsenha;
        private System.Windows.Forms.TextBox TXTusuario;
        private System.Windows.Forms.PictureBox PBfoto;
        private System.Windows.Forms.Label LBLnome;
        private System.Windows.Forms.Label LBLnivel;
        private System.Windows.Forms.Label LBLacesso;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.PictureBox PBusuario;
        private System.Windows.Forms.Button BTNlogin;
        private System.Windows.Forms.PictureBox PBhome;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.Label LBLsenha;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog2;
    }
}


namespace Projeto_Avaliativo
{
    partial class Form4
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.BTNcadastro = new System.Windows.Forms.Button();
            this.GBnivel = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBavancado = new System.Windows.Forms.RadioButton();
            this.RBbasico = new System.Windows.Forms.RadioButton();
            this.LBLlogin = new System.Windows.Forms.Label();
            this.TXTlogin = new System.Windows.Forms.TextBox();
            this.LBLsenha = new System.Windows.Forms.Label();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.PBhome = new System.Windows.Forms.PictureBox();
            this.PBconfig = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.GBnivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBconfig)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox6.Image = global::Projeto_Avaliativo.Properties.Resources.SENAI_São_Paulo_logo;
            this.pictureBox6.Location = new System.Drawing.Point(23, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(201, 59);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 67;
            this.label1.Text = "Sobrenome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(129, 216);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNLimpar.BackColor = System.Drawing.Color.Coral;
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpar.Location = new System.Drawing.Point(407, 342);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(109, 40);
            this.BTNLimpar.TabIndex = 6;
            this.BTNLimpar.Text = "LIMPA";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            this.BTNLimpar.Click += new System.EventHandler(this.BTNLimpar_Click);
            this.BTNLimpar.MouseLeave += new System.EventHandler(this.BTNLimpar_MouseLeave);
            this.BTNLimpar.MouseHover += new System.EventHandler(this.BTNLimpar_MouseHover);
            // 
            // BTNcadastro
            // 
            this.BTNcadastro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNcadastro.BackColor = System.Drawing.Color.Coral;
            this.BTNcadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcadastro.Location = new System.Drawing.Point(247, 342);
            this.BTNcadastro.Name = "BTNcadastro";
            this.BTNcadastro.Size = new System.Drawing.Size(109, 40);
            this.BTNcadastro.TabIndex = 5;
            this.BTNcadastro.Text = "CADASTRAR";
            this.BTNcadastro.UseVisualStyleBackColor = false;
            this.BTNcadastro.Click += new System.EventHandler(this.BTNcadastro_Click);
            this.BTNcadastro.MouseLeave += new System.EventHandler(this.BTNcadastro_MouseLeave);
            this.BTNcadastro.MouseHover += new System.EventHandler(this.BTNcadastro_MouseHover);
            // 
            // GBnivel
            // 
            this.GBnivel.BackColor = System.Drawing.Color.Transparent;
            this.GBnivel.Controls.Add(this.radioButton1);
            this.GBnivel.Controls.Add(this.RBavancado);
            this.GBnivel.Controls.Add(this.RBbasico);
            this.GBnivel.Cursor = System.Windows.Forms.Cursors.Default;
            this.GBnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBnivel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.GBnivel.Location = new System.Drawing.Point(346, 150);
            this.GBnivel.Name = "GBnivel";
            this.GBnivel.Size = new System.Drawing.Size(125, 102);
            this.GBnivel.TabIndex = 63;
            this.GBnivel.TabStop = false;
            this.GBnivel.Text = "FUNÇÃO";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(6, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 24);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.Text = "TÉCNICO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // RBavancado
            // 
            this.RBavancado.AutoSize = true;
            this.RBavancado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBavancado.Location = new System.Drawing.Point(6, 46);
            this.RBavancado.Name = "RBavancado";
            this.RBavancado.Size = new System.Drawing.Size(76, 24);
            this.RBavancado.TabIndex = 8;
            this.RBavancado.Text = "LÍDER";
            this.RBavancado.UseVisualStyleBackColor = true;
            // 
            // RBbasico
            // 
            this.RBbasico.AutoSize = true;
            this.RBbasico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBbasico.Location = new System.Drawing.Point(3, 16);
            this.RBbasico.Name = "RBbasico";
            this.RBbasico.Size = new System.Drawing.Size(119, 24);
            this.RBbasico.TabIndex = 7;
            this.RBbasico.Text = "OPERADOR";
            this.RBbasico.UseVisualStyleBackColor = true;
            this.RBbasico.CheckedChanged += new System.EventHandler(this.RBbasico_CheckedChanged);
            // 
            // LBLlogin
            // 
            this.LBLlogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLlogin.Location = new System.Drawing.Point(547, 195);
            this.LBLlogin.Name = "LBLlogin";
            this.LBLlogin.Size = new System.Drawing.Size(42, 22);
            this.LBLlogin.TabIndex = 62;
            this.LBLlogin.Text = "User";
            this.LBLlogin.Click += new System.EventHandler(this.LBLlogin_Click);
            // 
            // TXTlogin
            // 
            this.TXTlogin.Location = new System.Drawing.Point(540, 220);
            this.TXTlogin.Multiline = true;
            this.TXTlogin.Name = "TXTlogin";
            this.TXTlogin.Size = new System.Drawing.Size(147, 36);
            this.TXTlogin.TabIndex = 4;
            this.TXTlogin.TextChanged += new System.EventHandler(this.TXTlogin_TextChanged);
            // 
            // LBLsenha
            // 
            this.LBLsenha.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsenha.Location = new System.Drawing.Point(547, 121);
            this.LBLsenha.Name = "LBLsenha";
            this.LBLsenha.Size = new System.Drawing.Size(58, 22);
            this.LBLsenha.TabIndex = 60;
            this.LBLsenha.Text = "Senha";
            this.LBLsenha.Click += new System.EventHandler(this.LBLsenha_Click);
            // 
            // LBLusuario
            // 
            this.LBLusuario.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLusuario.Location = new System.Drawing.Point(138, 121);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(58, 22);
            this.LBLusuario.TabIndex = 59;
            this.LBLusuario.Text = "Nome";
            this.LBLusuario.Click += new System.EventHandler(this.LBLusuario_Click);
            // 
            // TXTsenha
            // 
            this.TXTsenha.Location = new System.Drawing.Point(540, 146);
            this.TXTsenha.Multiline = true;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(147, 36);
            this.TXTsenha.TabIndex = 3;
            this.TXTsenha.TextChanged += new System.EventHandler(this.TXTsenha_TextChanged);
            // 
            // TXTnome
            // 
            this.TXTnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnome.Location = new System.Drawing.Point(129, 146);
            this.TXTnome.Multiline = true;
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(147, 36);
            this.TXTnome.TabIndex = 1;
            this.TXTnome.TextChanged += new System.EventHandler(this.TXTnome_TextChanged);
            // 
            // PBhome
            // 
            this.PBhome.BackColor = System.Drawing.Color.Transparent;
            this.PBhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBhome.Image = global::Projeto_Avaliativo.Properties.Resources.mainmenu_Photoroom;
            this.PBhome.Location = new System.Drawing.Point(665, 12);
            this.PBhome.Name = "PBhome";
            this.PBhome.Size = new System.Drawing.Size(47, 51);
            this.PBhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBhome.TabIndex = 69;
            this.PBhome.TabStop = false;
            this.PBhome.Click += new System.EventHandler(this.PBhome_Click);
            this.PBhome.MouseLeave += new System.EventHandler(this.PBhome_MouseLeave);
            this.PBhome.MouseHover += new System.EventHandler(this.PBhome_MouseHover);
            // 
            // PBconfig
            // 
            this.PBconfig.BackColor = System.Drawing.Color.Transparent;
            this.PBconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBconfig.Image = global::Projeto_Avaliativo.Properties.Resources.config__1_;
            this.PBconfig.Location = new System.Drawing.Point(741, 12);
            this.PBconfig.Name = "PBconfig";
            this.PBconfig.Size = new System.Drawing.Size(47, 51);
            this.PBconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBconfig.TabIndex = 70;
            this.PBconfig.TabStop = false;
            this.PBconfig.Click += new System.EventHandler(this.pictureBox4_Click);
            this.PBconfig.MouseLeave += new System.EventHandler(this.PBconfig_MouseLeave);
            this.PBconfig.MouseHover += new System.EventHandler(this.PBconfig_MouseHover);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Avaliativo.Properties.Resources.Copia_do_primeiro1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBconfig);
            this.Controls.Add(this.PBhome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNcadastro);
            this.Controls.Add(this.GBnivel);
            this.Controls.Add(this.LBLlogin);
            this.Controls.Add(this.TXTlogin);
            this.Controls.Add(this.LBLsenha);
            this.Controls.Add(this.LBLusuario);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.TXTnome);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.GBnivel.ResumeLayout(false);
            this.GBnivel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBconfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Button BTNcadastro;
        private System.Windows.Forms.GroupBox GBnivel;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RBavancado;
        private System.Windows.Forms.RadioButton RBbasico;
        private System.Windows.Forms.Label LBLlogin;
        private System.Windows.Forms.TextBox TXTlogin;
        private System.Windows.Forms.Label LBLsenha;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.PictureBox PBhome;
        private System.Windows.Forms.PictureBox PBconfig;
    }
}
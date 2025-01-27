namespace Projeto_Avaliativo
{
    partial class Form2
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
            this.GBnivel = new System.Windows.Forms.GroupBox();
            this.RBavancado = new System.Windows.Forms.RadioButton();
            this.RBbasico = new System.Windows.Forms.RadioButton();
            this.GBgenero = new System.Windows.Forms.GroupBox();
            this.RBfeminino = new System.Windows.Forms.RadioButton();
            this.RBmasculino = new System.Windows.Forms.RadioButton();
            this.LBLlogin = new System.Windows.Forms.Label();
            this.TXTlogin = new System.Windows.Forms.TextBox();
            this.LBLsenha = new System.Windows.Forms.Label();
            this.LBLusuario = new System.Windows.Forms.Label();
            this.TXTsenha = new System.Windows.Forms.TextBox();
            this.TXTnome = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.BTNcadastro = new System.Windows.Forms.Button();
            this.BTNatualizar = new System.Windows.Forms.Button();
            this.BTNDeletar = new System.Windows.Forms.Button();
            this.BTNLimpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PBconfig = new System.Windows.Forms.PictureBox();
            this.PBhome = new System.Windows.Forms.PictureBox();
            this.GBnivel.SuspendLayout();
            this.GBgenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBconfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).BeginInit();
            this.SuspendLayout();
            // 
            // GBnivel
            // 
            this.GBnivel.BackColor = System.Drawing.Color.Transparent;
            this.GBnivel.Controls.Add(this.radioButton1);
            this.GBnivel.Controls.Add(this.RBavancado);
            this.GBnivel.Controls.Add(this.RBbasico);
            this.GBnivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBnivel.ForeColor = System.Drawing.Color.LavenderBlush;
            this.GBnivel.Location = new System.Drawing.Point(333, 70);
            this.GBnivel.Name = "GBnivel";
            this.GBnivel.Size = new System.Drawing.Size(125, 102);
            this.GBnivel.TabIndex = 46;
            this.GBnivel.TabStop = false;
            this.GBnivel.Text = "FUNÇÃO";
            // 
            // RBavancado
            // 
            this.RBavancado.AutoSize = true;
            this.RBavancado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBavancado.Location = new System.Drawing.Point(6, 46);
            this.RBavancado.Name = "RBavancado";
            this.RBavancado.Size = new System.Drawing.Size(76, 24);
            this.RBavancado.TabIndex = 1;
            this.RBavancado.TabStop = true;
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
            this.RBbasico.TabIndex = 0;
            this.RBbasico.TabStop = true;
            this.RBbasico.Text = "OPERADOR";
            this.RBbasico.UseVisualStyleBackColor = true;
            // 
            // GBgenero
            // 
            this.GBgenero.BackColor = System.Drawing.Color.Transparent;
            this.GBgenero.Controls.Add(this.RBfeminino);
            this.GBgenero.Controls.Add(this.RBmasculino);
            this.GBgenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBgenero.ForeColor = System.Drawing.Color.LavenderBlush;
            this.GBgenero.Location = new System.Drawing.Point(314, 220);
            this.GBgenero.Name = "GBgenero";
            this.GBgenero.Size = new System.Drawing.Size(173, 60);
            this.GBgenero.TabIndex = 45;
            this.GBgenero.TabStop = false;
            this.GBgenero.Text = "PERMISSÃO";
            // 
            // RBfeminino
            // 
            this.RBfeminino.AutoSize = true;
            this.RBfeminino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBfeminino.Location = new System.Drawing.Point(3, 37);
            this.RBfeminino.Name = "RBfeminino";
            this.RBfeminino.Size = new System.Drawing.Size(102, 24);
            this.RBfeminino.TabIndex = 1;
            this.RBfeminino.TabStop = true;
            this.RBfeminino.Text = "USUÁRIO";
            this.RBfeminino.UseVisualStyleBackColor = true;
            // 
            // RBmasculino
            // 
            this.RBmasculino.AutoSize = true;
            this.RBmasculino.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBmasculino.Location = new System.Drawing.Point(3, 16);
            this.RBmasculino.Name = "RBmasculino";
            this.RBmasculino.Size = new System.Drawing.Size(168, 24);
            this.RBmasculino.TabIndex = 0;
            this.RBmasculino.TabStop = true;
            this.RBmasculino.Text = "ADIMINISTRADOR";
            this.RBmasculino.UseVisualStyleBackColor = true;
            // 
            // LBLlogin
            // 
            this.LBLlogin.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLlogin.Enabled = false;
            this.LBLlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLlogin.Location = new System.Drawing.Point(520, 224);
            this.LBLlogin.Name = "LBLlogin";
            this.LBLlogin.Size = new System.Drawing.Size(42, 22);
            this.LBLlogin.TabIndex = 42;
            this.LBLlogin.Text = "User";
            // 
            // TXTlogin
            // 
            this.TXTlogin.Enabled = false;
            this.TXTlogin.Location = new System.Drawing.Point(523, 249);
            this.TXTlogin.Multiline = true;
            this.TXTlogin.Name = "TXTlogin";
            this.TXTlogin.Size = new System.Drawing.Size(147, 36);
            this.TXTlogin.TabIndex = 41;
            // 
            // LBLsenha
            // 
            this.LBLsenha.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsenha.Location = new System.Drawing.Point(520, 150);
            this.LBLsenha.Name = "LBLsenha";
            this.LBLsenha.Size = new System.Drawing.Size(58, 22);
            this.LBLsenha.TabIndex = 40;
            this.LBLsenha.Text = "Senha";
            // 
            // LBLusuario
            // 
            this.LBLusuario.BackColor = System.Drawing.Color.DarkSalmon;
            this.LBLusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLusuario.Location = new System.Drawing.Point(112, 150);
            this.LBLusuario.Name = "LBLusuario";
            this.LBLusuario.Size = new System.Drawing.Size(58, 22);
            this.LBLusuario.TabIndex = 39;
            this.LBLusuario.Text = "Nome";
            this.LBLusuario.Click += new System.EventHandler(this.LBLusuario_Click);
            // 
            // TXTsenha
            // 
            this.TXTsenha.Location = new System.Drawing.Point(523, 175);
            this.TXTsenha.Multiline = true;
            this.TXTsenha.Name = "TXTsenha";
            this.TXTsenha.Size = new System.Drawing.Size(147, 36);
            this.TXTsenha.TabIndex = 34;
            // 
            // TXTnome
            // 
            this.TXTnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTnome.Location = new System.Drawing.Point(112, 175);
            this.TXTnome.Multiline = true;
            this.TXTnome.Name = "TXTnome";
            this.TXTnome.Size = new System.Drawing.Size(147, 36);
            this.TXTnome.TabIndex = 28;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox6.Image = global::Projeto_Avaliativo.Properties.Resources.SENAI_São_Paulo_logo;
            this.pictureBox6.Location = new System.Drawing.Point(21, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(159, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // BTNcadastro
            // 
            this.BTNcadastro.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNcadastro.BackColor = System.Drawing.Color.Coral;
            this.BTNcadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNcadastro.Enabled = false;
            this.BTNcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNcadastro.Location = new System.Drawing.Point(275, 325);
            this.BTNcadastro.Name = "BTNcadastro";
            this.BTNcadastro.Size = new System.Drawing.Size(109, 40);
            this.BTNcadastro.TabIndex = 50;
            this.BTNcadastro.Text = "CADASTRO";
            this.BTNcadastro.UseVisualStyleBackColor = false;
            // 
            // BTNatualizar
            // 
            this.BTNatualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNatualizar.BackColor = System.Drawing.Color.Coral;
            this.BTNatualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNatualizar.Enabled = false;
            this.BTNatualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNatualizar.Location = new System.Drawing.Point(390, 325);
            this.BTNatualizar.Name = "BTNatualizar";
            this.BTNatualizar.Size = new System.Drawing.Size(109, 40);
            this.BTNatualizar.TabIndex = 51;
            this.BTNatualizar.Text = "ATUALIZAR";
            this.BTNatualizar.UseVisualStyleBackColor = false;
            // 
            // BTNDeletar
            // 
            this.BTNDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNDeletar.BackColor = System.Drawing.Color.Red;
            this.BTNDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNDeletar.Enabled = false;
            this.BTNDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeletar.Location = new System.Drawing.Point(275, 371);
            this.BTNDeletar.Name = "BTNDeletar";
            this.BTNDeletar.Size = new System.Drawing.Size(109, 40);
            this.BTNDeletar.TabIndex = 52;
            this.BTNDeletar.Text = "DELETAR";
            this.BTNDeletar.UseVisualStyleBackColor = false;
            this.BTNDeletar.Click += new System.EventHandler(this.BTNDeletar_Click);
            // 
            // BTNLimpar
            // 
            this.BTNLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNLimpar.BackColor = System.Drawing.Color.Coral;
            this.BTNLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLimpar.Enabled = false;
            this.BTNLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLimpar.Location = new System.Drawing.Point(390, 371);
            this.BTNLimpar.Name = "BTNLimpar";
            this.BTNLimpar.Size = new System.Drawing.Size(109, 40);
            this.BTNLimpar.TabIndex = 53;
            this.BTNLimpar.Text = "LIMPA";
            this.BTNLimpar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 55;
            this.label1.Text = "Sobrenome";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Location = new System.Drawing.Point(112, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 36);
            this.textBox1.TabIndex = 54;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.Location = new System.Drawing.Point(6, 76);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 24);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TÉCNICO";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // PBconfig
            // 
            this.PBconfig.BackColor = System.Drawing.Color.Transparent;
            this.PBconfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBconfig.Image = global::Projeto_Avaliativo.Properties.Resources.config__1_;
            this.PBconfig.Location = new System.Drawing.Point(742, 12);
            this.PBconfig.Name = "PBconfig";
            this.PBconfig.Size = new System.Drawing.Size(47, 51);
            this.PBconfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBconfig.TabIndex = 72;
            this.PBconfig.TabStop = false;
            this.PBconfig.Click += new System.EventHandler(this.PBconfig_Click);
            this.PBconfig.MouseLeave += new System.EventHandler(this.PBconfig_MouseLeave);
            this.PBconfig.MouseHover += new System.EventHandler(this.PBconfig_MouseHover);
            // 
            // PBhome
            // 
            this.PBhome.BackColor = System.Drawing.Color.Transparent;
            this.PBhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBhome.Image = global::Projeto_Avaliativo.Properties.Resources.mainmenu_Photoroom;
            this.PBhome.Location = new System.Drawing.Point(666, 12);
            this.PBhome.Name = "PBhome";
            this.PBhome.Size = new System.Drawing.Size(47, 51);
            this.PBhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBhome.TabIndex = 71;
            this.PBhome.TabStop = false;
            this.PBhome.Click += new System.EventHandler(this.PBhome_Click_1);
            this.PBhome.MouseLeave += new System.EventHandler(this.PBhome_MouseLeave);
            this.PBhome.MouseHover += new System.EventHandler(this.PBhome_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Avaliativo.Properties.Resources.istockphoto_1386828570_612x6121;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBconfig);
            this.Controls.Add(this.PBhome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTNLimpar);
            this.Controls.Add(this.BTNDeletar);
            this.Controls.Add(this.BTNatualizar);
            this.Controls.Add(this.BTNcadastro);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.GBnivel);
            this.Controls.Add(this.GBgenero);
            this.Controls.Add(this.LBLlogin);
            this.Controls.Add(this.TXTlogin);
            this.Controls.Add(this.LBLsenha);
            this.Controls.Add(this.LBLusuario);
            this.Controls.Add(this.TXTsenha);
            this.Controls.Add(this.TXTnome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONFIG ADM";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GBnivel.ResumeLayout(false);
            this.GBnivel.PerformLayout();
            this.GBgenero.ResumeLayout(false);
            this.GBgenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBconfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBhome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBnivel;
        private System.Windows.Forms.RadioButton RBavancado;
        private System.Windows.Forms.RadioButton RBbasico;
        private System.Windows.Forms.GroupBox GBgenero;
        private System.Windows.Forms.RadioButton RBfeminino;
        private System.Windows.Forms.RadioButton RBmasculino;
        private System.Windows.Forms.Label LBLlogin;
        private System.Windows.Forms.TextBox TXTlogin;
        private System.Windows.Forms.Label LBLsenha;
        private System.Windows.Forms.Label LBLusuario;
        private System.Windows.Forms.TextBox TXTsenha;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button BTNcadastro;
        private System.Windows.Forms.Button BTNatualizar;
        private System.Windows.Forms.Button BTNDeletar;
        private System.Windows.Forms.Button BTNLimpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.PictureBox PBconfig;
        private System.Windows.Forms.PictureBox PBhome;
    }
}
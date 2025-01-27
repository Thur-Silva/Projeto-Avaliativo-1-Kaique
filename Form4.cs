using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Avaliativo
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void TXTnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLusuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PBfoto_Click(object sender, EventArgs e)
        {

        }

        private void TXTsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLsenha_Click(object sender, EventArgs e)
        {

        }

        private void LBLlogin_Click(object sender, EventArgs e)
        {

        }

        private void TXTlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBbasico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BTNcadastro_Click(object sender, EventArgs e)
        {

        }

        private void BTNLimpar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            form3.Show();

        }

        private void PBhome_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();

        }

        private void BTNLimpar_MouseHover(object sender, EventArgs e)
        {
            BTNLimpar.Size = new Size(120, 50);
            BTNLimpar.Location = new Point(400, 338);
        }

        private void BTNLimpar_MouseLeave(object sender, EventArgs e)
        {
            BTNLimpar.Size = new Size(109, 40);
            BTNLimpar.Location = new Point(407, 342);
        }

        private void BTNcadastro_MouseHover(object sender, EventArgs e)
        {
            BTNcadastro.Size = new Size(120, 50);
            BTNcadastro.Location = new Point(240, 338);
        }

        private void BTNcadastro_MouseLeave(object sender, EventArgs e)
        {
            BTNcadastro.Size = new Size(109, 40);
            BTNcadastro.Location = new Point(247, 342);
        }

  


        private void PBhome_MouseHover(object sender, EventArgs e)
        {
           PBhome.Size = new Size(50, 51);
            PBhome.Location = new Point(665, 12);
        }

        private void PBhome_MouseLeave(object sender, EventArgs e)
        {
            PBhome.Size = new Size(47, 51);
            PBhome.Location = new Point(665, 12);
        }

        private void PBconfig_MouseHover(object sender, EventArgs e)
        {
             PBconfig.Size = new Size(54, 51);
            PBconfig.Location = new Point(740, 12);
        }

        private void PBconfig_MouseLeave(object sender, EventArgs e)
        {
              PBconfig.Size = new Size(47, 51);
            PBconfig.Location = new Point(741, 12);
        }
    }
}

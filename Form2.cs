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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LBLusuario_Click(object sender, EventArgs e)
        {

        }

        private void BTNDeletar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void PBhome_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void PBconfig_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 form3 = new Form3();
            form3.Show();
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

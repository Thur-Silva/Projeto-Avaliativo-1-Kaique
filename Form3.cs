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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PBhome_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void BTNlogin_MouseHover(object sender, EventArgs e)
        {
            BTNlogin.Size = new Size(99, 70);
            BTNlogin.Location = new Point(550, 230);
        }

        private void BTNlogin_MouseLeave(object sender, EventArgs e)
        {
            BTNlogin.Size = new Size(91, 63);
            BTNlogin.Location = new Point(552, 232);
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace Projeto_Avaliativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        string CONFIG_CONEXAO_BD = "server=127.0.0.1;userid=root;password=;database=gordaodopc";
        public void QUERY_MYSQL(string server, string query)
        {
            MySqlConnection conexao = new MySqlConnection(server);
            MySqlCommand Query = new MySqlCommand();
            Query.Connection = conexao;
            conexao.Open();
            Query.CommandText = query;
            Query.ExecuteNonQuery();

            conexao.Close();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        bool mudar = false;
        private void ClickConfig(object sender, EventArgs e)
        {
            mudar = true;
            //"mudar pagina"
            LBLnome.Hide();
            LBLnivel.Hide();
            PBfoto.Hide();
            BTNlogin.Text = "LOGIN ADMIN";
            LBLacesso.Hide();

            PBhome.Show();

            if(mudar == true)
            {
                // pegar os dados do adim e verificar



                // se for adim mudar para pagina de cadastro
                
                LBLdata.Show();
                TXTdata.Show();
                LBLlogin.Show();
                TXTlogin.Show();
                GBnivel.Show();
                RBbasico.Show();
                RBavancado.Show();
                LBLnomeAdm.Show();
                TXTusuarioCadastrados.Show();

                BTNlogin.Hide();
            }
            else
            {
                MessageBox.Show("Erro ao logar como ADIMIN !", "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mudar = false;



        }

        private void ClickRelatorio(object sender, EventArgs e)
        {
            TXTusuario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
       
        private void BTNlogin_Click(object sender, EventArgs e)
        {
            try
            {
                QUERY_MYSQL(CONFIG_CONEXAO_BD, "INSERT INTO usuario (Nome, Senha) values ('" + TXTusuario.Text + "','" + TXTsenha.Text + "')");
                MessageBox.Show("Dados cadastrados com sucesso!", "SENAI", MessageBoxButtons.OK);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro! \n" + ex.Message, "SENAI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TXTnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //"mudar pagina"
            BTNlogin.Text = "LOGIN";
            LBLnome.Show();
            LBLnivel.Show();
            PBfoto.Show();
            BTNlogin.Show();
            LBLacesso.Show();

            PBhome.Hide();


        }

        private void LBLnivel_Click(object sender, EventArgs e)
        {

        }

        private void LBLnome_Click(object sender, EventArgs e)
        {

        }

        private void LBLsenha_Click(object sender, EventArgs e)
        {

        }

        private void PBsenha_Click(object sender, EventArgs e)
        {

        }

        private void TXTlogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLlogin_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LBLdata_Click(object sender, EventArgs e)
        {

        }

        private void PBusuario_Click(object sender, EventArgs e)
        {

        }

        private void LBLusuario_Click(object sender, EventArgs e)
        {

        }

        private void TXTusuarioCadastrados_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBLnomeAdm_Click(object sender, EventArgs e)
        {

        }

        private void TXTsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTdata_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBmasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBfeminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GBnivel_Enter(object sender, EventArgs e)
        {

        }

        private void RBbasico_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBavancado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PBfoto_Click(object sender, EventArgs e)
        {

        }
    }
}

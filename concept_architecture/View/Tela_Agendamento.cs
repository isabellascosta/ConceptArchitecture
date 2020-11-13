using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace concept_architecture
{
    public partial class Tela_Agendamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        public Tela_Agendamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                ExcluirCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        public void ExcluirCliente()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"DELETE FROM AGENDAMENTO WHERE ID_AGENDAMENTO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                IncluirCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }


        }
        public void IncluirCliente()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"INSERT INTO AGENDAMENTO (NOME_AGENDAMENTO,TELEFONE_AGENDAMENTO,EMAIL_AGENDAMENTO,DATA_AGENDAMENTO,ASSUNTO_AGENDAMENTO,MENSAGEM_AGENDAMENTO)  
                        VALUES (@NOME, @TELEFONE, @EMAIL,@DATA,@ASSUNTO,@MENSAGEM)";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtData.Text);
            comando.Parameters.AddWithValue("@ASSUNTO",txtAssunto.Text);
            comando.Parameters.AddWithValue("@MENSAGEM", txtMensagem.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                PesquisarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        public void PesquisarCliente()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"SELECT *  FROM AGENDAMENTO WHERE ID_AGENDAMENTO  = @ID ";
            

            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = Convert.ToString(dr["nome_agendamento"]);
                txtEmail.Text = Convert.ToString(dr["email_agendamento"]);
                txtData.Text = Convert.ToString(dr["data_agendamento"]);
                txtTelefone.Text = Convert.ToString(dr["telefone_agendamento"]);
                txtAssunto.Text = Convert.ToString(dr["assunto_agendamento"]);
                txtMensagem.Text = Convert.ToString(dr["mensagem_agendamento"]);

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {



                EditarCliente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }
        public void EditarCliente()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"UPDATE AGENDAMENTO  SET NOME_AGENDAMENTO = @NOME,  EMAIL_AGENDAMENTO =@EMAIL,DATA_AGENDAMENTO=@DATA ,TELEFONE_AGENDAMENTO =  @TELEFONE, ASSUNTO_AGENDAMENTO = @ASSUNTO, MENSAGEM_AGENDAMENTO = @MENSAGEM  WHERE ID_AGENDAMENTO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtData.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@ASSUNTO", txtAssunto.Text);
            comando.Parameters.AddWithValue("@MENSAGEM", txtMensagem.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exibir_Click(object sender, EventArgs e)
        {
            try
            {

                ExibirAgendamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
        public void ExibirAgendamento()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = "SELECT *  FROM AGENDAMENTO";
            da = new MySqlDataAdapter(strSQl, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tela_Agendamento_Load(object sender, EventArgs e)
        {

        }
    }
}

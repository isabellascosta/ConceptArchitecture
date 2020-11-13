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

    public partial class Tela_funcionarios : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        public Tela_funcionarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Tela_funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void rg_funcLabel_Click(object sender, EventArgs e)
        {

        }

        private void id_funcTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_funcLabel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                IncluirFuncionario();
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

        public void IncluirFuncionario()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"INSERT INTO FUNCIONARIO (NOME_FUNCIONARIO,RG_FUNCIONARIO,DATANASC_FUNCIONARIO,CPF_FUNCIONARIO,TELEFONE_FUNCIONARIO,TITULOELEITOR_FUNCIONARIO,STATUS_FUNCIONARIO )  
                        VALUES (@NOME, @RG, @NASCIMENTO, @CPF, @TELEFONE, @TITULO,@STATUS)";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@RG", txtRg.Text);
            comando.Parameters.AddWithValue("@NASCIMENTO", txtDatanascimento.Text);
            comando.Parameters.AddWithValue("@CPF", txtCpf.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@TITULO", txtTitulo.Text);


            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                PesquisarFuncionario();
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
        public void PesquisarFuncionario()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"SELECT *  FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = Convert.ToString(dr["nome_funcionario"]);
                txtRg.Text = Convert.ToString(dr["RG_cliente"]);
                txtDatanascimento.Text = Convert.ToString(dr["datanasc_funcionario"]);
                txtCpf.Text = Convert.ToString(dr["CpfCnpj_funcioario"]);
                txtTelefone.Text = Convert.ToString(dr["telefone_funcionario"]);
                txtTitulo.Text = Convert.ToString(dr["tituloeleitor_funcionario"]);
                txt_Status.Text = Convert.ToString(dr["status_funcionario"]);

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                ExcluirFuncionario();
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

        public void ExcluirFuncionario()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"DELETE FROM FUNCIONARIO WHERE ID_FUNCIONARIO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {



                EditarFuncionario();
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

        public void EditarFuncionario()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"UPDATE FUNCIONARIO  SET NOME_FUNCIONARIO = @NOME,  RG_FUNCIONARIO =  @RG, DATANASC_FUNCIONARIO = @NASCIMENTO,CPF_FUNCIOARIO = @CPF,  TELEFONE_FUNCIONARIO =  @TELEFONE, TITULOELEITOR_FUNCIONARIO, STATUS_FUNCIONARIO = @STATUS = @TITULO WHERE ID_FUNCIONARIO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@RG", txtRg.Text);
            comando.Parameters.AddWithValue("@NASCIMENTO", txtDatanascimento.Text);
            comando.Parameters.AddWithValue("@CPF", txtCpf.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@ENDERECO", txtTitulo.Text); 
            comando.Parameters.AddWithValue("@STATUS", txt_Status.Text);

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

                ExibirFuncionario();
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

        public void ExibirFuncionario()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = "SELECT *  FROM FUNCIONARIO";
            da = new MySqlDataAdapter(strSQl, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}

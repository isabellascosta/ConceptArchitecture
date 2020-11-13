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
    public partial class Tela_projeto : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        public Tela_projeto()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_projeto_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                IncluirProjeto();
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

        public void IncluirProjeto()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"INSERT INTO PROJETO (DESC_PROJETO,STATUS_PROJETO,FASE_PROJETO,STATUS_PROJETO,CLIENTE_ID_CLIENTE)  
                        VALUES (@DESCRICAO,@STATUS, @FASE, @RESPONSAVEL,@STATUS,@CPF)";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text);
            comando.Parameters.AddWithValue("@FASE", txtFase.Text);
            comando.Parameters.AddWithValue("@STATUS", txtStatus.Text);
            comando.Parameters.AddWithValue("@CPF", Id_Cliente.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
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

            strSQl = @"SELECT *  FROM PROJETO WHERE ID_ORCAMENTO  = @ID ";


            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtDescricao.Text = Convert.ToString(dr["desc_projeto"]);
                txtFase.Text = Convert.ToString(dr["fase_projeto"]);
                txtStatus.Text = Convert.ToString(dr["status_projeto"]);
                txtStatus.Text = Convert.ToString(dr["descricao_status"]);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ExcluirProjeto();
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
        public void ExcluirProjeto()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"DELETE FROM PROJETO WHERE ID_PROJETO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {



                EditarOrcamento();
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

        public void EditarOrcamento()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"UPDATE PROJETO  SET  DESC_PROJETO =@DESCRICAO,FASE_PROJETO = @FASE,RESPONSAVEL_PROJETO = @RESPONSAVEL,DESCRICAO_STATUS = @STATUS, CLIENTE_ID_CLIENTE = @IDCLIENTE WHERE ID_PROJETO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            comando.Parameters.AddWithValue("@DESCRICAO", txtDescricao.Text);
            comando.Parameters.AddWithValue("@FASE", txtFase.Text);
            comando.Parameters.AddWithValue("@STATUS", txtStatus.Text);
            comando.Parameters.AddWithValue("@IDCLIENTE", Id_Cliente.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {

                ExibirProjeto();
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

        public void ExibirProjeto()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = "SELECT *  FROM PROJETO";
            da = new MySqlDataAdapter(strSQl, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if(CpfCliente.Text.Length == 11)
            {
                //Captura o cpf digitado  na tela
                string Cpf = CpfCliente.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

                strSQl = $"SELECT *  FROM CLIENTE WHERE CPFCNPJ_CLIENTE = '{Cpf}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);
                
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    Id_Cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado", "Erro ao consultar cliente");
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (txtNomeAquiteto.Text.Length >= 1)
            {
                //Captura o cpf digitado  na tela
                string Nome = txtNomeAquiteto.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

                strSQl = $"SELECT *  FROM FUNCIONARIO WHERE NOME_FUNCIONARIO = '{Nome}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Id_Funcionario.Text = dt.Rows[0]["id_funcionario"].ToString();
                }
                else
                {
                    MessageBox.Show("Funcionário não cadastrado", "Erro ao consultar funcionario");
                }

            }
        }
    }
}

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
    public partial class Tela_orcamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        public Tela_orcamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
        }

        private void Tela_orcamento_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            try
            {

                IncluirOrcamento();
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
        public void IncluirOrcamento()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"INSERT INTO ORCAMENTO (prazoentr_orcamento, formapagam_orcamento, valorplanta_orcamento,valorprojeto_orcamento, valortotal_orcamento, cliente_id_cliente)  
                        VALUES (@PRAZO, @PAGAMENTO, @PLANTA,@PROJETO,@TOTAL,@IDCLIENTE)";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@PRAZO", txtPrazo.Text);
            comando.Parameters.AddWithValue("@PAGAMENTO", txtPagamento.Text);
            comando.Parameters.AddWithValue("@PLANTA", txtPlanta.Text);
            comando.Parameters.AddWithValue("@PROJETO", txtPlanta.Text);
            comando.Parameters.AddWithValue("@TOTAL", txtTotal.Text);
            comando.Parameters.AddWithValue("@IDCLIENTE", Id_Cliente.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
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

            strSQl = @"SELECT *  FROM ORCAMENTO WHERE ID_ORCAMENTO  = @ID ";


            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtPrazo.Text = Convert.ToString(dr["prazo_orcamento"]);
                txtPagamento.Text = Convert.ToString(dr["formapagam_orcamento"]);
                txtPlanta.Text = Convert.ToString(dr["prestacoes_orcamento"]);
                txtTotal.Text = Convert.ToString(dr["valortotal_orcamento"]);

            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ExcluirOrcamento();
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
        public void ExcluirOrcamento()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = @"DELETE FROM ORCAMENTO WHERE ID_ORCAMENTO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnalterar_Click(object sender, EventArgs e)
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

            strSQl = @"UPDATE ORCAMENTO  SET  = PRAZOENTR_ORCAMENTO = @PRAZO, FORMPAGAM_ORCAMENTO = @PAGAMENTO, VALORPLANTA_ORCAMENTO= @PLANTA,VALORPROJETO_ORCAMENTO = @PROJETO, VALORTOTAL_ORCAMENTO = @TOTAL WHERE ID_ORCAMENTO = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            comando.Parameters.AddWithValue("@PRAZO", txtPrazo.Text);
            comando.Parameters.AddWithValue("@PAGAMENTO", txtPagamento.Text);
            comando.Parameters.AddWithValue("@PLANTA", txtPlanta.Text);
            comando.Parameters.AddWithValue("@PROJETO", txtProjeto.Text);
            comando.Parameters.AddWithValue("@TOTAL", txtTotal.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }

        private void btnExibir_Click(object sender, EventArgs e)
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

            strSQl = "SELECT *  FROM ORCAMENTO";
            da = new MySqlDataAdapter(strSQl, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (CpfCliente.Text.Length == 11)
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

                if (dt.Rows.Count > 0)
                {
                    Id_Cliente.Text = dt.Rows[0]["id_cliente"].ToString();
                }
                else
                {
                    MessageBox.Show("CPF não cadastrado", "Erro ao consultar cliente");
                }
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
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
                    ID_Funcionario.Text = dt.Rows[0]["id_funcionario"].ToString();
                }
                else
                {
                    MessageBox.Show("Nome não cadastrado", "Erro ao consultar Funcionario");
                }
            }

        }
    }
}

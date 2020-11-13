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
    public partial class Tela_cliente : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQl;
        public Tela_cliente()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Tela_cliente_Load(object sender, EventArgs e)
        {

        }

        private void nom_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
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

            strSQl = @"UPDATE CLIENTE  SET NOME_CLIENTE = @NOME,  RG_CLIENTE =  @RG, DATANASC_CLIENTE = @NASCIMENTO,  EMAIL_CLIENTE =@EMAIL,CPFCNPJ_CLIENTE = @CPFCNPJ,  TELEFONE_CLIENTE =  @TELEFONE,  CEP_CLIENTE =  @CEP,ENDERECO_CLIENTE =  @ENDERECO,ESTADO_CLIENTE =  @ESTADO, NUMEROCASA_CLIENTE=   @NUMEROCASA   WHERE ID_CLIENTE = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@RG", txtRg.Text);
            comando.Parameters.AddWithValue("@NASCIMENTO", txtDatanascimento.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@CPFCNPJ", txtCpfcnpj.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@CEP", txtCep.Text);
            comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
            comando.Parameters.AddWithValue("@NUMEROCASA", txtNumerocasa.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }


        private void button2_Click_1(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento;

            try
            {
                if (!DateTime.TryParse(txtDatanascimento.Text, out dataNascimento))
                {
                    throw new Exception("A data de nascimento informada é inválida");
                }


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

            strSQl = @"INSERT INTO CLIENTE (NOME_CLIENTE, RG_CLIENTE, DATANASC_CLIENTE, EMAIL_CLIENTE, CPFCNPJ_CLIENTE, TELEFONE_CLIENTE, CEP_CLIENTE, ENDERECO_CLIENTE, ESTADO_CLIENTE, NUMEROCASA_CLIENTE)  
                        VALUES (@NOME, @RG, @NASCIMENTO, @EMAIL, @CPFCNPJ, @TELEFONE, @CEP, @ENDERECO, @ESTADO, @NUMEROCASA)";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@NOME", txtNome.Text);
            comando.Parameters.AddWithValue("@RG", txtRg.Text);
            comando.Parameters.AddWithValue("@NASCIMENTO", txtDatanascimento.Text);
            comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
            comando.Parameters.AddWithValue("@CPFCNPJ", txtCpfcnpj.Text);
            comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
            comando.Parameters.AddWithValue("@CEP", txtCep.Text);
            comando.Parameters.AddWithValue("@ENDERECO", txtEndereco.Text);
            comando.Parameters.AddWithValue("@ESTADO", txtEstado.Text);
            comando.Parameters.AddWithValue("@NUMEROCASA", txtNumerocasa.Text);

            conexao.Open();
            comando.ExecuteNonQuery();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtnasc_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void dtnasc_clienDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rg_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void rg_clienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cpf_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void cpf_clienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnpj_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void cnpj_clienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_clienLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_clienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void nom_clienTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pesquisar_Click(object sender, EventArgs e)
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

            strSQl = @"SELECT *  FROM CLIENTE WHERE ID_CLIENTE = @ID ";
            comando = new MySqlCommand(strSQl, conexao);
            comando.Parameters.AddWithValue("@ID", txtID.Text);

            conexao.Open();
            dr = comando.ExecuteReader();
            while (dr.Read())
            {
                txtNome.Text = Convert.ToString(dr["nome_cliente"]);
                txtRg.Text = Convert.ToString(dr["RG_cliente"]);
                txtDatanascimento.Text = Convert.ToString(dr["datanasc_cliente"]);
                txtEmail.Text = Convert.ToString(dr["email_cliente"]);
                txtCpfcnpj.Text = Convert.ToString(dr["CpfCnpj_cliente"]);
                txtTelefone.Text = Convert.ToString(dr["telefone_cliente"]);
                txtCep.Text = Convert.ToString(dr["CEP_cliente"]);
                txtEndereco.Text = Convert.ToString(dr["endereco_cliente"]);
                txtEstado.Text = Convert.ToString(dr["estado_cliente"]);
                txtNumerocasa.Text = Convert.ToString(dr["numerocasa_cliente"]);

            }
        }

        private void exibir_Click(object sender, EventArgs e)
        {
            try
            {

                ExibirCliente();
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
        public void ExibirCliente()
        {
            conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

            strSQl = "SELECT *  FROM CLIENTE";
            da = new MySqlDataAdapter(strSQl, conexao);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            //Setiver mais que 11 caracteres
            if (emailCliente.Text.Length >= 1)
            {
                //Captura o cpf digitado  na tela
                string Email = emailCliente.Text;

                //Fazer a consulta no banco de dados

                conexao = new MySqlConnection("Server=localhost;Database=concept_archicteture;Uid=root;Pwd=;");

                strSQl = $"SELECT *  FROM AGENDAMENTO WHERE EMAIL_AGENDAMENTO = '{Email}'";
                comando = new MySqlCommand(strSQl, conexao);
                da = new MySqlDataAdapter(strSQl, conexao);

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Id_Agendamento.Text = dt.Rows[0]["id_agendamento"].ToString();
                }
                else
                {
                    MessageBox.Show("Email não existente", "Erro ao consultar agendamento");
                }
            }
        }
    }
}

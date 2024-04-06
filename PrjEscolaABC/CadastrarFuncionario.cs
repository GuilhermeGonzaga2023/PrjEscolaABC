using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrjEscolaABC
{
    public partial class TelaCadastrarFuncionario : Form
    {


        public TelaPrincipal TelaPrincipal;
        public string cpf;
        public TelaCadastrarFuncionario()
        {
        }

        public TelaCadastrarFuncionario(TelaPrincipal _principal)
        {
       
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }

        private void BuscarFuncionario()
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("cpfFuncionario", cpf);

            //reader
            SqlDataReader reader;

            //abrir conexão com sql e executar o comando
            connection.Open();

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                txtNomeFuncionario.Text = reader.GetString("nomeFuncionario");
                txtDataDeNascimentoFuncionario.Text = reader.GetDateTime("dataDeNascimentoFuncionario").ToString("dd/MM/yyyy");
                txtCPFFuncionario.Text = reader.GetString("cpfFuncionario");
                txtCelularFuncionario.Text = reader.GetString("celularFuncionario");
                txtEnderecoFuncionario.Text = reader.GetString("enderecoFuncionario");
                txtemailFuncionario.Text = reader.GetString("emailFuncionario");
                txtsenhaFuncionario.Text = reader.GetString("senhaFuncionario");
                cmbTipoFuncionario.Text = reader.GetString("tipoFuncionario");
            }
            connection.Close();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            string dataBR = "dd/MM/yyyy";
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text);
            command.Parameters.AddWithValue("dataDeNascimentoFuncionario", txtDataDeNascimentoFuncionario.Text);
            command.Parameters.AddWithValue("cpfFuncionario", txtCPFFuncionario.Text);
            command.Parameters.AddWithValue("celularFuncionario", txtCelularFuncionario.Text);
            command.Parameters.AddWithValue("enderecoFuncionario", txtEnderecoFuncionario.Text);
            command.Parameters.AddWithValue("emailFuncionario", txtemailFuncionario.Text);
            command.Parameters.AddWithValue("senhaFuncionario", txtsenhaFuncionario.Text);
            command.Parameters.AddWithValue("tipoFuncionario", cmbTipoFuncionario.Text);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Funcionario cadastrado!!");

            //limpar os campos de texto
            txtNomeFuncionario.Text = "";
            txtDataDeNascimentoFuncionario.Text = "";
            txtCPFFuncionario.Text = "";
            txtCelularFuncionario.Text = "";
            txtEnderecoFuncionario.Text = "";
            txtCelularFuncionario.Text = "";
            txtemailFuncionario.Text = "";
            txtsenhaFuncionario.Text = "";
            cmbTipoFuncionario.Text = "";


        }

        private void btnBuscarCpfCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            BuscarFuncionario();
        }

        private void TelaCadastrarFuncionario_Load(object sender, EventArgs e)
        {
            if (cpf != null)
            {
                BuscarFuncionario();
            }
        }

        private void btnAtualizarCadastrarFuncionario_Click(object sender, EventArgs e)
        {

            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pu_Funcionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeFuncionario", txtNomeFuncionario.Text);
            command.Parameters.AddWithValue("dataDeNascimentoFuncionario", DateTime.Parse(txtDataDeNascimentoFuncionario.Text));
            command.Parameters.AddWithValue("cpfFuncionario", txtCPFFuncionario.Text);
            command.Parameters.AddWithValue("celularFuncionario", txtCelularFuncionario.Text);
            command.Parameters.AddWithValue("enderecoFuncionario", txtEnderecoFuncionario.Text);
            command.Parameters.AddWithValue("emailFuncionario", txtemailFuncionario.Text);
            command.Parameters.AddWithValue("senhaFuncionario", txtsenhaFuncionario.Text);
            command.Parameters.AddWithValue("tipoFuncionario", cmbTipoFuncionario.Text);
            command.Parameters.AddWithValue("cpfFuncionarioBusca", cpf);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Funcionario Atualizado!!");
            this.Close();

        }
    }
}

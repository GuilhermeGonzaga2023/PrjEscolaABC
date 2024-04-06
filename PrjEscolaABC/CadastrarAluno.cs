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
    public partial class TelaCadastrarAluno : Form
    {
        public string cpf;
        public TelaPrincipal TelaPrincipal;
        public TelaCadastrarAluno(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }

        private void BuscarAluno()
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Aluno";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("cpfAluno", cpf);

            //reader
            SqlDataReader reader;

            //abrir conexão com sql e executar o comando
            connection.Open();

            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();

                txtNomeAluno.Text = reader.GetString("nomeAluno");
                txtDataDeNascimentoAluno.Text = reader.GetDateTime("dataDeNascimentoAluno").ToString("dd/MM/yyyy");
                txtCPFAluno.Text = reader.GetString("cpfAluno");
                txtCelularAluno.Text = reader.GetString("celularAluno");
                txtEnderecoAluno.Text = reader.GetString("enderecoAluno");
                txtEmailAluno.Text = reader.GetString("emailAluno");
            }
            connection.Close();


        }
        private void btnCadastrarAluno_Click(object sender, EventArgs e)
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Aluno";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text);
            command.Parameters.AddWithValue("dataDeNascimentoAluno", txtDataDeNascimentoAluno.Text);
            command.Parameters.AddWithValue("cpfAluno", txtCPFAluno.Text);
            command.Parameters.AddWithValue("celularAluno", txtCelularAluno.Text);
            command.Parameters.AddWithValue("enderecoAluno", txtEnderecoAluno.Text);
            command.Parameters.AddWithValue("emailAluno", txtEmailAluno.Text);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Aluno cadastrado!!");
            this.Hide();
        }

        private void TelaCadastrarAluno_Load(object sender, EventArgs e)
        {
            if (cpf != null)
            {

                BuscarAluno();
                //txtCPFAluno.Enabled = false;
                //btnBuscarAlunoPelocpf.Enabled = false;
            }
        }

        private void btnAlunoCpfBuscar_Click(object sender, EventArgs e)
        {
            BuscarAluno();
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pu_Aluno";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text);
            command.Parameters.AddWithValue("dataDeNascimentoAluno",DateTime.Parse(txtDataDeNascimentoAluno.Text));
            command.Parameters.AddWithValue("cpfAluno", txtCPFAluno.Text);
            command.Parameters.AddWithValue("celularAluno", txtCelularAluno.Text);
            command.Parameters.AddWithValue("enderecoAluno", txtEnderecoAluno.Text);
            command.Parameters.AddWithValue("emailAluno", txtEmailAluno.Text);
            command.Parameters.AddWithValue("cpfAlunoBusca", cpf);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Aluno Atualizado!!");
            this.Close();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os campos de texto
            txtNomeAluno.Text = "";
            txtDataDeNascimentoAluno.Text = "";
            txtCPFAluno.Text = "";
            txtCelularAluno.Text = "";
            txtEnderecoAluno.Text = "";
            txtCelularAluno.Text = "";
            txtEmailAluno.Text = "";

        }
    }
}

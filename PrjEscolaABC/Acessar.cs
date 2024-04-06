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
    public partial class TelaAcessar : Form
    {
        public TelaPrincipal TelaPrincipal;
        //private object cmbTipoFuncionario;
        int email=123;
        int senha = 123;

        public TelaAcessar(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal; 
            InitializeComponent();
         
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            //conecão com sql           
            SqlConnection connection = new SqlConnection("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");
            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_LoginFuncionario";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("emailFuncionario", txtemailAcessar.Text);
            command.Parameters.AddWithValue("senhaFuncionario", txtsenhaAcessar.Text);

            ////armazenar dados que busca no sql
            SqlDataReader reader;

            //abrir conexão com sql e executar o comando
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.HasRows)// se tiver linhas de dados dentro do leitor
            {

                reader.Read(); //ler a prox linha do sql
                txtemailAcessar.Text = reader.GetString("emailFuncionario");
                txtsenhaAcessar.Text = reader.GetString("senhaFuncionario");
                MessageBox.Show("Login realizado com sucesso!");

                TelaPrincipal.MenuAcessar.Visible = false;
                TelaPrincipal.MenuAdministrador.Visible = true;
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login não encontrado");
            }


            connection.Close();

        }
    }
}

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

    public partial class TelaCadastrarCurso : Form
    {
        public TelaPrincipal TelaPrincipal;
        public TelaCadastrarCurso(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }

        private void btnCadastrarCurso_Click(object sender, EventArgs e)
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Curso";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeProfessor", txtProfessor.Text);
            command.Parameters.AddWithValue("periodoCurso", txtPeriodo.Text);
            command.Parameters.AddWithValue("periodoCurso2", txtPeriodo2.Text);
            command.Parameters.AddWithValue("horarioCurso", txtHorario.Text);
            command.Parameters.AddWithValue("salaCurso", txtSala.Text);
            command.Parameters.AddWithValue("idiomaCurso", txtIdioma.Text);
            command.Parameters.AddWithValue("valorCurso", txtValorCurso.Text);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Curso cadastrado!!");
            this.Hide();

        }
    }
}

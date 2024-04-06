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
    public partial class TelaCriarTurma : Form
    {
        public TelaPrincipal TelaPrincipal;
        public TelaCriarTurma(TelaPrincipal _principal)
        {
            InitializeComponent();
            this.TelaPrincipal = _principal;
        }

        private void btnCriarTurma_Click(object sender, EventArgs e)
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_Turma";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("idAluno", txtIdAluno.Text);
            command.Parameters.AddWithValue("idCurso", txtCurso.Text);

            //abrir conexão com sql e executar o comando
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Turma cadastrada!!");
            txtIdAluno.Text="";
            txtCurso.Text="";

            //this.Hide();

        }
    }
}

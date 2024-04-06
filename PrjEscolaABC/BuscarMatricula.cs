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
    public partial class BuscarMatricula : Form
    {
        public TelaPrincipal TelaPrincipal;
        public BuscarMatricula(TelaPrincipal _principal)
        {
            InitializeComponent();
            this.TelaPrincipal = _principal;
        }
        public string idMatricula;
        public string idTurma;
        public string idCurso;
        public string nomeAluno;
        public string idAluno;

        private void Buscar()
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Matricula";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("nomeAluno", txtMatricula.Text);


            //abrir conexão com sql e executar o comando
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            dgvBuscarMatricula.DataSource = ds;
            connection.Close();
        }

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void BuscarMatricula_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvBuscarMatricula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //criando variaveis para cpf, email e nome do Aluno que for clicado dentro da tabela
            nomeAluno = dgvBuscarMatricula.Rows[e.RowIndex].Cells[0].Value.ToString();
            idAluno = dgvBuscarMatricula.Rows[e.RowIndex].Cells[1].Value.ToString();
            idTurma = dgvBuscarMatricula.Rows[e.RowIndex].Cells[2].Value.ToString();
            idCurso = dgvBuscarMatricula.Rows[e.RowIndex].Cells[3].Value.ToString();

            //btnDeletarMatricula.Enabled = true;
        }
    }
}

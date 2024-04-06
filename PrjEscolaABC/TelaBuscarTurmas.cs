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
    public partial class TelaBuscarTurmas : Form
    {
        public TelaPrincipal TelaPrincipal;
        public TelaBuscarTurmas(TelaPrincipal _principal)
        {
            InitializeComponent();
            this.TelaPrincipal = _principal;
        }
        public string nomeAluno;
        public string idMatricula;
        public string idAluno;
        public string idiomaCurso;

        private void Buscar()
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "ps_Turma";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            //if (txtNomeAluno.Text != String.Empty)
            
                command.Parameters.AddWithValue("nomeAluno", txtNomeAluno.Text);
            

            //abrir conexão com sql e executar o comando
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            dgvTurmas.DataSource = ds;
            connection.Close();
        }

        private void btnDeletarTurmas_Click(object sender, EventArgs e)
        {
            //mensagem de confirmação SIM ou NÃO
            DialogResult Result = MessageBox.Show("Deseja realmente deletar o(a) Aluno(a) " +nomeAluno+ "?", "Aviso", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {

                //conecão com sql
                SqlConnection connection = new SqlConnection
                ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

                // criando objeto de configuração do comando sql
                SqlCommand command = new SqlCommand();
                command.CommandText = "pd_Turma";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                // alimentar os parametros
                command.Parameters.AddWithValue("idAluno",idAluno);

                //abrir conexão com sql e executar o comando
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Turma Excluído!!");

                Buscar();
            }
        }
        private void btnBuscarTurmas_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void TelaBuscarTurmas_Load_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvTurmas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //criando variaveis para cpf, email e nome do Aluno que for clicado dentro da tabela
            nomeAluno = dgvTurmas.Rows[e.RowIndex].Cells[0].Value.ToString();
            idAluno = dgvTurmas.Rows[e.RowIndex].Cells[1].Value.ToString();
            idiomaCurso = dgvTurmas.Rows[e.RowIndex].Cells[2].Value.ToString();

            btnDeletarTurmas.Enabled = true;
        }

        private void dgvTurmas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class TelaBuscarAluno : Form
    {
        public string nomeAluno;
        public string dataDeNascimento;
        public string cpf;
        public string celular;
        public string endereco;
        public string email;

        public TelaPrincipal TelaPrincipal;
        public TelaBuscarAluno(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }

        public bool Yes { get; private set; }

        //método de buscar todos os alunos e trazer para a tela dvg
        private void Buscar()
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
            if (txtCpfAlunoBuscar.Text != String.Empty)
            {
                command.Parameters.AddWithValue("cpfAluno", txtCpfAlunoBuscar.Text);
            }

            //abrir conexão com sql e executar o comando
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            dgvAluno.DataSource = ds;
            connection.Close();
        }

        private void btnBuscarAluno_Click(object sender, EventArgs e)
        {

            Buscar();
         
        }
        private void btnDeletarAluno_Click(object sender, EventArgs e)
        {
            //mensagem de confirmação SIM ou NÃO
            DialogResult Result = MessageBox.Show("Deseja realmente deletar o(a) Aluno(a) "+nomeAluno+"?", "Aviso", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {
              
                //conecão com sql
                SqlConnection connection = new SqlConnection
                ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

                // criando objeto de configuração do comando sql
                SqlCommand command = new SqlCommand();
                command.CommandText = "pd_Aluno";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                // alimentar os parametros
                command.Parameters.AddWithValue("cpfAluno", cpf);

                //abrir conexão com sql e executar o comando
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Aluno Excluído!!");

                Buscar();

            }
            
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {

            TelaCadastrarAluno cadastroAluno = new TelaCadastrarAluno(TelaPrincipal);
            cadastroAluno.cpf = cpf;
            cadastroAluno.Show();
            cadastroAluno.MdiParent = TelaPrincipal;

        }

        private void dgvAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //criando variaveis para cpf, email e nome do Aluno que for clicado dentro da tabela
            nomeAluno = dgvAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            dataDeNascimento = dgvAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            cpf = dgvAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            celular = dgvAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
            endereco = dgvAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
            email = dgvAluno.Rows[e.RowIndex].Cells[6].Value.ToString();

            btnEditarAluno.Enabled = true;
            btnDeletarAluno.Enabled = true;
        }

        private void TelaBuscarAluno_Load(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}

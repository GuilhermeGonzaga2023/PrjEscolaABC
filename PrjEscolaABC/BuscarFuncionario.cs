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
    public partial class TelaBuscarFuncionario : Form
    {
       public string cpf, email, nomeFuncionario;
        public TelaPrincipal TelaPrincipal;
        public TelaBuscarFuncionario(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }
        private void Buscar()
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
            if (txtCpfFuncionarioBuscar.Text != String.Empty)
            {
                command.Parameters.AddWithValue("cpfFuncionario", txtCpfFuncionarioBuscar.Text);
            }

            //abrir conexão com sql e executar o comando
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable ds = new DataTable();

            adapter.Fill(ds);
            dgvFuncionario.DataSource = ds;
            connection.Close();
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {

            Buscar();
        }

        private void btnDeletarFuncionario_Click(object sender, EventArgs e)
        {
            //mensagem de confirmação SIM ou NÃO
            DialogResult Result = MessageBox.Show("Deseja realmente deletar o(a) Funcionário(a) " + nomeFuncionario + "?", "Aviso", MessageBoxButtons.YesNo);

            if (Result == DialogResult.Yes)
            {

                //conecão com sql
                SqlConnection connection = new SqlConnection
                ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

                // criando objeto de configuração do comando sql
                SqlCommand command = new SqlCommand();
                command.CommandText = "pd_Funcionario";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                // alimentar os parametros
                command.Parameters.AddWithValue("cpfFuncionario", cpf);

                //abrir conexão com sql e executar o comando
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Funcionário Excluído!!");

                Buscar();
            }
        }
        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeFuncionario = dgvFuncionario.Rows[e.RowIndex].Cells[1].Value.ToString();
            cpf = dgvFuncionario.Rows[e.RowIndex].Cells[3].Value.ToString();
            email = dgvFuncionario.Rows[e.RowIndex].Cells[6].Value.ToString();

            btnEditarFuncionario.Enabled = true;
            btnDeletarFuncionario.Enabled = true;
        }

        private void TelaBuscarFuncionario_Load(object sender, EventArgs e)
        {
            Buscar();
        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario cadastroFuncionario = new TelaCadastrarFuncionario(TelaPrincipal);
            cadastroFuncionario.cpf = cpf;
            this.Hide();
            cadastroFuncionario.Show();
            cadastroFuncionario.MdiParent = TelaPrincipal;

        }
    }
}

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
    public partial class TelaRealizarMatricula : Form
    {
        public int idAluno;
        public TelaPrincipal TelaPrincipal;
        public TelaRealizarMatricula(TelaPrincipal _principal)
        {
            this.TelaPrincipal = _principal;
            InitializeComponent();
        }

        private void TelaRealizarMatricula_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularMensalidade_Click(object sender, EventArgs e)
        {
            double ValorIngles = 1500;
            double ValorChines = 1300;
            double ValorEspanhol = 1000;

            double desconto;

            double VALORTOTAL=0;

            if (numIdCursoMatricula.Value == 1)
            {
                VALORTOTAL += ValorIngles;
            }
            if (numIdCursoMatricula.Value == 3)
            {
                VALORTOTAL += ValorChines;
            }
            if (numIdCursoMatricula.Value == 2)
            {
                VALORTOTAL += ValorEspanhol;
            }
            if (numUpParcelas.Value==1)
            {
                desconto = VALORTOTAL - (VALORTOTAL * 0.10);
                VALORTOTAL = desconto;
                txtValorParcelas.Text = 0.ToString();
            }
            int NroParcelas = Convert.ToInt32(numUpParcelas.Value);             
            double ValorParcela = Math.Round((VALORTOTAL / NroParcelas), 2);               
            txtValorParcelas.Text = ValorParcela.ToString();
            txtValor.Text = VALORTOTAL.ToString();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            //conecão com sql
            SqlConnection connection = new SqlConnection
            ("Server = EscolaABC.mssql.somee.com; Database = EscolaABC; User Id = GuiGonzaga_SQLLogin_1; Password = pv9cg2mtcn; ");

            // criando objeto de configuração do comando sql
            SqlCommand command = new SqlCommand();
            command.CommandText = "pi_ControleTurma";
            command.CommandType = CommandType.StoredProcedure;
            command.Connection = connection;

            // alimentar os parametros
            command.Parameters.AddWithValue("idAluno", txtAlunoMatricula.Text);
            command.Parameters.AddWithValue("idCurso", numIdCursoMatricula.Value);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Matricula Concluida!!");
            this.Hide();
            
        }
    }
}

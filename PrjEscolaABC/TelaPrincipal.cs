using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjEscolaABC
{
    public partial class TelaPrincipal : Form
    {

        public object MenuCadastrar { get; internal set; }

        //public
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }

        private void MenuAcessar_Click(object sender, EventArgs e)
        {
            TelaAcessar Acessar = new TelaAcessar(this);
            Acessar.MdiParent = this;
            Acessar.Show();

        }

        private void MenuCadastrarAluno_Click(object sender, EventArgs e)
        {
            TelaCadastrarAluno AlunoCadastrar = new TelaCadastrarAluno(this);
            AlunoCadastrar.MdiParent = this;
            AlunoCadastrar.Show();
        }

        private void MenuAdministradorBuscarAluno_Click(object sender, EventArgs e)
        {
            TelaBuscarAluno TelaBuscandoAluno = new TelaBuscarAluno(this);
            TelaBuscandoAluno.MdiParent = this;
            TelaBuscandoAluno.Show();
        }

        private void buscarFuncionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarFuncionario TelaBuscandoFuncionario = new TelaBuscarFuncionario(this);
            TelaBuscandoFuncionario.MdiParent = this;
            TelaBuscandoFuncionario.Show();
        }

        private void MenuCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            TelaCadastrarFuncionario TelaCadastrarFuncionario = new TelaCadastrarFuncionario(this);
            TelaCadastrarFuncionario.MdiParent = this;
            TelaCadastrarFuncionario.Show();
        }

        private void MenuCadastrarCurso_Click(object sender, EventArgs e)
        {
            TelaCadastrarCurso TelaCadastrarCurso = new TelaCadastrarCurso(this);
            TelaCadastrarCurso.MdiParent = this;
            TelaCadastrarCurso.Show();
        }

        private void MenuRealizarMatricula_Click(object sender, EventArgs e)
        {
            TelaRealizarMatricula TelaRealizarMatricula = new TelaRealizarMatricula(this);
            TelaRealizarMatricula.MdiParent = this;
            TelaRealizarMatricula.Show();
        }

        private void MenuProfessorBuscarAluno_Click(object sender, EventArgs e)
        {
            TelaBuscarAluno TelaBuscandoAluno = new TelaBuscarAluno(this);
            TelaBuscandoAluno.MdiParent = this;
            TelaBuscandoAluno.Show();
        }
        private void criarTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCriarTurma TelaCriarTurna = new TelaCriarTurma(this);
            TelaCriarTurna.MdiParent = this;
            TelaCriarTurna.Show();

        }

        private void buscarTurmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarTurmas telaBuscarTurmas = new TelaBuscarTurmas(this);
            telaBuscarTurmas.MdiParent = this;
            telaBuscarTurmas.Show();
        }

        private void buscarMatriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarMatricula TelabuscarMatricula = new BuscarMatricula(this);
            TelabuscarMatricula.MdiParent = this;
            TelabuscarMatricula.Show();
        }
    }
}

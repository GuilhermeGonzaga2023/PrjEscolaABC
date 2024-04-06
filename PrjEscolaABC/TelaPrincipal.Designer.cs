
namespace PrjEscolaABC
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuAcessar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastrarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAdministradorBuscarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRealizarMatricula = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarTurmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuAcessar
            // 
            this.MenuAcessar.Name = "MenuAcessar";
            this.MenuAcessar.Size = new System.Drawing.Size(59, 20);
            this.MenuAcessar.Text = "Acessar";
            this.MenuAcessar.Click += new System.EventHandler(this.MenuAcessar_Click);
            // 
            // MenuAdministrador
            // 
            this.MenuAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastrarCurso,
            this.MenuCadastrarFuncionario,
            this.MenuCadastrarAluno,
            this.MenuAdministradorBuscarAluno,
            this.MenuRealizarMatricula,
            this.buscarFuncionáriosToolStripMenuItem,
            this.criarTurmaToolStripMenuItem,
            this.buscarTurmasToolStripMenuItem,
            this.buscarMatriculaToolStripMenuItem});
            this.MenuAdministrador.Name = "MenuAdministrador";
            this.MenuAdministrador.Size = new System.Drawing.Size(95, 20);
            this.MenuAdministrador.Text = "Administrador";
            this.MenuAdministrador.Visible = false;
            // 
            // MenuCadastrarCurso
            // 
            this.MenuCadastrarCurso.BackColor = System.Drawing.Color.Yellow;
            this.MenuCadastrarCurso.Name = "MenuCadastrarCurso";
            this.MenuCadastrarCurso.Size = new System.Drawing.Size(190, 22);
            this.MenuCadastrarCurso.Text = "Cadastrar Curso";
            this.MenuCadastrarCurso.Click += new System.EventHandler(this.MenuCadastrarCurso_Click);
            // 
            // MenuCadastrarFuncionario
            // 
            this.MenuCadastrarFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.MenuCadastrarFuncionario.Name = "MenuCadastrarFuncionario";
            this.MenuCadastrarFuncionario.Size = new System.Drawing.Size(190, 22);
            this.MenuCadastrarFuncionario.Text = "Cadastrar Funcionário";
            this.MenuCadastrarFuncionario.Click += new System.EventHandler(this.MenuCadastrarFuncionario_Click);
            // 
            // MenuCadastrarAluno
            // 
            this.MenuCadastrarAluno.BackColor = System.Drawing.Color.Yellow;
            this.MenuCadastrarAluno.Name = "MenuCadastrarAluno";
            this.MenuCadastrarAluno.Size = new System.Drawing.Size(190, 22);
            this.MenuCadastrarAluno.Text = "Cadastrar Aluno";
            this.MenuCadastrarAluno.Click += new System.EventHandler(this.MenuCadastrarAluno_Click);
            // 
            // MenuAdministradorBuscarAluno
            // 
            this.MenuAdministradorBuscarAluno.BackColor = System.Drawing.Color.Yellow;
            this.MenuAdministradorBuscarAluno.Name = "MenuAdministradorBuscarAluno";
            this.MenuAdministradorBuscarAluno.Size = new System.Drawing.Size(190, 22);
            this.MenuAdministradorBuscarAluno.Text = "Buscar Aluno";
            this.MenuAdministradorBuscarAluno.Click += new System.EventHandler(this.MenuAdministradorBuscarAluno_Click);
            // 
            // MenuRealizarMatricula
            // 
            this.MenuRealizarMatricula.BackColor = System.Drawing.Color.Yellow;
            this.MenuRealizarMatricula.Name = "MenuRealizarMatricula";
            this.MenuRealizarMatricula.Size = new System.Drawing.Size(190, 22);
            this.MenuRealizarMatricula.Text = "Realizar Matrícula";
            this.MenuRealizarMatricula.Click += new System.EventHandler(this.MenuRealizarMatricula_Click);
            // 
            // buscarFuncionáriosToolStripMenuItem
            // 
            this.buscarFuncionáriosToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.buscarFuncionáriosToolStripMenuItem.Name = "buscarFuncionáriosToolStripMenuItem";
            this.buscarFuncionáriosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.buscarFuncionáriosToolStripMenuItem.Text = "Buscar Funcionários";
            this.buscarFuncionáriosToolStripMenuItem.Click += new System.EventHandler(this.buscarFuncionáriosToolStripMenuItem_Click);
            // 
            // criarTurmaToolStripMenuItem
            // 
            this.criarTurmaToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.criarTurmaToolStripMenuItem.Name = "criarTurmaToolStripMenuItem";
            this.criarTurmaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.criarTurmaToolStripMenuItem.Text = "Criar turma";
            this.criarTurmaToolStripMenuItem.Click += new System.EventHandler(this.criarTurmaToolStripMenuItem_Click);
            // 
            // buscarTurmasToolStripMenuItem
            // 
            this.buscarTurmasToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.buscarTurmasToolStripMenuItem.Name = "buscarTurmasToolStripMenuItem";
            this.buscarTurmasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.buscarTurmasToolStripMenuItem.Text = "Buscar turmas";
            this.buscarTurmasToolStripMenuItem.Click += new System.EventHandler(this.buscarTurmasToolStripMenuItem_Click);
            // 
            // buscarMatriculaToolStripMenuItem
            // 
            this.buscarMatriculaToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.buscarMatriculaToolStripMenuItem.Name = "buscarMatriculaToolStripMenuItem";
            this.buscarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.buscarMatriculaToolStripMenuItem.Text = "Buscar matricula";
            this.buscarMatriculaToolStripMenuItem.Click += new System.EventHandler(this.buscarMatriculaToolStripMenuItem_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.BackColor = System.Drawing.Color.Yellow;
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Yellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAcessar,
            this.MenuAdministrador,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(807, 466);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Text = "EscolaABC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStripMenuItem MenuAcessar;
        public System.Windows.Forms.ToolStripMenuItem MenuAdministrador;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarCurso;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastrarAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuAdministradorBuscarAluno;
        private System.Windows.Forms.ToolStripMenuItem MenuRealizarMatricula;
        private System.Windows.Forms.ToolStripMenuItem buscarFuncionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarTurmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarMatriculaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}


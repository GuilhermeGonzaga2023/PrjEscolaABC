
namespace PrjEscolaABC
{
    partial class TelaCriarTurma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.btnCriarTurma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Curso:";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.BackColor = System.Drawing.Color.Yellow;
            this.txtIdAluno.Location = new System.Drawing.Point(107, 28);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(100, 23);
            this.txtIdAluno.TabIndex = 3;
            // 
            // txtCurso
            // 
            this.txtCurso.BackColor = System.Drawing.Color.Yellow;
            this.txtCurso.Location = new System.Drawing.Point(73, 72);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(100, 23);
            this.txtCurso.TabIndex = 4;
            // 
            // btnCriarTurma
            // 
            this.btnCriarTurma.BackColor = System.Drawing.Color.Yellow;
            this.btnCriarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarTurma.Location = new System.Drawing.Point(151, 106);
            this.btnCriarTurma.Name = "btnCriarTurma";
            this.btnCriarTurma.Size = new System.Drawing.Size(91, 38);
            this.btnCriarTurma.TabIndex = 5;
            this.btnCriarTurma.Text = "Criar turma";
            this.btnCriarTurma.UseVisualStyleBackColor = false;
            this.btnCriarTurma.Click += new System.EventHandler(this.btnCriarTurma_Click);
            // 
            // TelaCriarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(254, 156);
            this.Controls.Add(this.btnCriarTurma);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCriarTurma";
            this.Text = "TelaCriarTurma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdAluno;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.Button btnCriarTurma;
    }
}
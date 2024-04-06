
namespace PrjEscolaABC
{
    partial class TelaRealizarMatricula
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlunoMatricula = new System.Windows.Forms.TextBox();
            this.btnCalcularMensalidade = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numUpParcelas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorParcelas = new System.Windows.Forms.TextBox();
            this.btnMatricular = new System.Windows.Forms.Button();
            this.numIdCursoMatricula = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCursoMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(85, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Realizar Matrícula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nº do Curso:";
            // 
            // txtAlunoMatricula
            // 
            this.txtAlunoMatricula.BackColor = System.Drawing.Color.Yellow;
            this.txtAlunoMatricula.Location = new System.Drawing.Point(110, 59);
            this.txtAlunoMatricula.Name = "txtAlunoMatricula";
            this.txtAlunoMatricula.Size = new System.Drawing.Size(45, 23);
            this.txtAlunoMatricula.TabIndex = 14;
            // 
            // btnCalcularMensalidade
            // 
            this.btnCalcularMensalidade.BackColor = System.Drawing.Color.Yellow;
            this.btnCalcularMensalidade.Location = new System.Drawing.Point(142, 293);
            this.btnCalcularMensalidade.Name = "btnCalcularMensalidade";
            this.btnCalcularMensalidade.Size = new System.Drawing.Size(68, 39);
            this.btnCalcularMensalidade.TabIndex = 13;
            this.btnCalcularMensalidade.Text = "Calcular";
            this.btnCalcularMensalidade.UseVisualStyleBackColor = false;
            this.btnCalcularMensalidade.Click += new System.EventHandler(this.btnCalcularMensalidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nº do Aluno:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Valor Total:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.Yellow;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(78, 257);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 23);
            this.txtValor.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Crusos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Parcelas:";
            // 
            // numUpParcelas
            // 
            this.numUpParcelas.BackColor = System.Drawing.Color.Yellow;
            this.numUpParcelas.Location = new System.Drawing.Point(71, 198);
            this.numUpParcelas.Name = "numUpParcelas";
            this.numUpParcelas.Size = new System.Drawing.Size(45, 23);
            this.numUpParcelas.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Á vista tem um desconto de 10% no valor total !!";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 37;
            this.label8.Text = "Valor da Parcela:";
            // 
            // txtValorParcelas
            // 
            this.txtValorParcelas.BackColor = System.Drawing.Color.Yellow;
            this.txtValorParcelas.Enabled = false;
            this.txtValorParcelas.Location = new System.Drawing.Point(110, 225);
            this.txtValorParcelas.Name = "txtValorParcelas";
            this.txtValorParcelas.Size = new System.Drawing.Size(89, 23);
            this.txtValorParcelas.TabIndex = 36;
            // 
            // btnMatricular
            // 
            this.btnMatricular.BackColor = System.Drawing.Color.Yellow;
            this.btnMatricular.Location = new System.Drawing.Point(216, 293);
            this.btnMatricular.Name = "btnMatricular";
            this.btnMatricular.Size = new System.Drawing.Size(77, 39);
            this.btnMatricular.TabIndex = 38;
            this.btnMatricular.Text = "Matricular";
            this.btnMatricular.UseVisualStyleBackColor = false;
            this.btnMatricular.Click += new System.EventHandler(this.btnMatricular_Click);
            // 
            // numIdCursoMatricula
            // 
            this.numIdCursoMatricula.BackColor = System.Drawing.Color.Yellow;
            this.numIdCursoMatricula.Location = new System.Drawing.Point(110, 100);
            this.numIdCursoMatricula.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numIdCursoMatricula.Name = "numIdCursoMatricula";
            this.numIdCursoMatricula.Size = new System.Drawing.Size(45, 23);
            this.numIdCursoMatricula.TabIndex = 39;
            this.numIdCursoMatricula.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(64, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Nº 1: Inglês";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(137, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nº 2: Espanhol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(226, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 42;
            this.label11.Text = "Nº 3: Chinês";
            // 
            // TelaRealizarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(305, 344);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numIdCursoMatricula);
            this.Controls.Add(this.btnMatricular);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtValorParcelas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numUpParcelas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAlunoMatricula);
            this.Controls.Add(this.btnCalcularMensalidade);
            this.Controls.Add(this.label1);
            this.Name = "TelaRealizarMatricula";
            this.Text = "Realizar Matrícula";
            this.Load += new System.EventHandler(this.TelaRealizarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdCursoMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlunoMatricula;
        private System.Windows.Forms.Button btnCalcularMensalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numUpParcelas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorParcelas;
        private System.Windows.Forms.Button btnMatricular;
        private System.Windows.Forms.NumericUpDown numIdCursoMatricula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
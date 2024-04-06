
namespace PrjEscolaABC
{
    partial class TelaBuscarAluno
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
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.txtCpfAlunoBuscar = new System.Windows.Forms.TextBox();
            this.lblEmailalunoBusca = new System.Windows.Forms.Label();
            this.btnBuscarAluno = new System.Windows.Forms.Button();
            this.btnDeletarAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAluno
            // 
            this.dgvAluno.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(3, 111);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.RowTemplate.Height = 25;
            this.dgvAluno.Size = new System.Drawing.Size(604, 251);
            this.dgvAluno.TabIndex = 0;
            this.dgvAluno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluno_CellClick);
            // 
            // txtCpfAlunoBuscar
            // 
            this.txtCpfAlunoBuscar.BackColor = System.Drawing.Color.Yellow;
            this.txtCpfAlunoBuscar.Location = new System.Drawing.Point(134, 24);
            this.txtCpfAlunoBuscar.Name = "txtCpfAlunoBuscar";
            this.txtCpfAlunoBuscar.Size = new System.Drawing.Size(221, 23);
            this.txtCpfAlunoBuscar.TabIndex = 3;
            // 
            // lblEmailalunoBusca
            // 
            this.lblEmailalunoBusca.AutoSize = true;
            this.lblEmailalunoBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailalunoBusca.ForeColor = System.Drawing.Color.Black;
            this.lblEmailalunoBusca.Location = new System.Drawing.Point(12, 22);
            this.lblEmailalunoBusca.Name = "lblEmailalunoBusca";
            this.lblEmailalunoBusca.Size = new System.Drawing.Size(116, 21);
            this.lblEmailalunoBusca.TabIndex = 4;
            this.lblEmailalunoBusca.Text = "CPF do Aluno:";
            // 
            // btnBuscarAluno
            // 
            this.btnBuscarAluno.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarAluno.Location = new System.Drawing.Point(361, 18);
            this.btnBuscarAluno.Name = "btnBuscarAluno";
            this.btnBuscarAluno.Size = new System.Drawing.Size(97, 32);
            this.btnBuscarAluno.TabIndex = 5;
            this.btnBuscarAluno.Text = "Buscar";
            this.btnBuscarAluno.UseVisualStyleBackColor = false;
            this.btnBuscarAluno.Click += new System.EventHandler(this.btnBuscarAluno_Click);
            // 
            // btnDeletarAluno
            // 
            this.btnDeletarAluno.BackColor = System.Drawing.Color.Yellow;
            this.btnDeletarAluno.Enabled = false;
            this.btnDeletarAluno.Location = new System.Drawing.Point(484, 18);
            this.btnDeletarAluno.Name = "btnDeletarAluno";
            this.btnDeletarAluno.Size = new System.Drawing.Size(97, 32);
            this.btnDeletarAluno.TabIndex = 6;
            this.btnDeletarAluno.Text = "Deletar";
            this.btnDeletarAluno.UseVisualStyleBackColor = false;
            this.btnDeletarAluno.Click += new System.EventHandler(this.btnDeletarAluno_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarAluno.Enabled = false;
            this.btnEditarAluno.Location = new System.Drawing.Point(484, 56);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEditarAluno.Size = new System.Drawing.Size(97, 32);
            this.btnEditarAluno.TabIndex = 18;
            this.btnEditarAluno.Text = "Editar";
            this.btnEditarAluno.UseVisualStyleBackColor = false;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // TelaBuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(610, 374);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnDeletarAluno);
            this.Controls.Add(this.btnBuscarAluno);
            this.Controls.Add(this.lblEmailalunoBusca);
            this.Controls.Add(this.txtCpfAlunoBuscar);
            this.Controls.Add(this.dgvAluno);
            this.Name = "TelaBuscarAluno";
            this.Text = "Buscar Aluno";
            this.Load += new System.EventHandler(this.TelaBuscarAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAluno;
        public System.Windows.Forms.TextBox txtCpfAlunoBuscar;
        private System.Windows.Forms.Label lblEmailalunoBusca;
        private System.Windows.Forms.Button btnBuscarAluno;
        private System.Windows.Forms.Button btnDeletarAluno;
        private System.Windows.Forms.Button btnEditarAluno;
    }
}
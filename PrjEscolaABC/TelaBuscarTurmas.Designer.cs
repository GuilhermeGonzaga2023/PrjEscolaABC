
namespace PrjEscolaABC
{
    partial class TelaBuscarTurmas
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
            this.btnDeletarTurmas = new System.Windows.Forms.Button();
            this.btnBuscarTurmas = new System.Windows.Forms.Button();
            this.lblEmailalunoBusca = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.dgvTurmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletarTurmas
            // 
            this.btnDeletarTurmas.BackColor = System.Drawing.Color.Yellow;
            this.btnDeletarTurmas.Enabled = false;
            this.btnDeletarTurmas.Location = new System.Drawing.Point(492, 41);
            this.btnDeletarTurmas.Name = "btnDeletarTurmas";
            this.btnDeletarTurmas.Size = new System.Drawing.Size(97, 32);
            this.btnDeletarTurmas.TabIndex = 23;
            this.btnDeletarTurmas.Text = "Deletar";
            this.btnDeletarTurmas.UseVisualStyleBackColor = false;
            this.btnDeletarTurmas.Click += new System.EventHandler(this.btnDeletarTurmas_Click);
            // 
            // btnBuscarTurmas
            // 
            this.btnBuscarTurmas.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarTurmas.Location = new System.Drawing.Point(376, 41);
            this.btnBuscarTurmas.Name = "btnBuscarTurmas";
            this.btnBuscarTurmas.Size = new System.Drawing.Size(97, 32);
            this.btnBuscarTurmas.TabIndex = 22;
            this.btnBuscarTurmas.Text = "Buscar";
            this.btnBuscarTurmas.UseVisualStyleBackColor = false;
            this.btnBuscarTurmas.Click += new System.EventHandler(this.btnBuscarTurmas_Click);
            // 
            // lblEmailalunoBusca
            // 
            this.lblEmailalunoBusca.AutoSize = true;
            this.lblEmailalunoBusca.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailalunoBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailalunoBusca.ForeColor = System.Drawing.Color.Black;
            this.lblEmailalunoBusca.Location = new System.Drawing.Point(12, 47);
            this.lblEmailalunoBusca.Name = "lblEmailalunoBusca";
            this.lblEmailalunoBusca.Size = new System.Drawing.Size(135, 21);
            this.lblEmailalunoBusca.TabIndex = 21;
            this.lblEmailalunoBusca.Text = "Nome do Aluno:";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.BackColor = System.Drawing.Color.Yellow;
            this.txtNomeAluno.Location = new System.Drawing.Point(149, 47);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(221, 23);
            this.txtNomeAluno.TabIndex = 20;
            // 
            // dgvTurmas
            // 
            this.dgvTurmas.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurmas.Location = new System.Drawing.Point(12, 120);
            this.dgvTurmas.Name = "dgvTurmas";
            this.dgvTurmas.RowTemplate.Height = 25;
            this.dgvTurmas.Size = new System.Drawing.Size(604, 251);
            this.dgvTurmas.TabIndex = 19;
            this.dgvTurmas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellClick);
            this.dgvTurmas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurmas_CellContentClick);
            // 
            // TelaBuscarTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(628, 379);
            this.Controls.Add(this.btnDeletarTurmas);
            this.Controls.Add(this.btnBuscarTurmas);
            this.Controls.Add(this.lblEmailalunoBusca);
            this.Controls.Add(this.txtNomeAluno);
            this.Controls.Add(this.dgvTurmas);
            this.Name = "TelaBuscarTurmas";
            this.Text = "TelaBuscarTurmas";
            this.Load += new System.EventHandler(this.TelaBuscarTurmas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeletarTurmas;
        private System.Windows.Forms.Button btnBuscarTurmas;
        private System.Windows.Forms.Label lblEmailalunoBusca;
        public System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.DataGridView dgvTurmas;
    }
}
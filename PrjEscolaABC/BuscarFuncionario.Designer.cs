
namespace PrjEscolaABC
{
    partial class TelaBuscarFuncionario
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
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.btnEditarFuncionario = new System.Windows.Forms.Button();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.lblCPFFuncionarioBusca = new System.Windows.Forms.Label();
            this.txtCpfFuncionarioBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Location = new System.Drawing.Point(7, 124);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.RowTemplate.Height = 25;
            this.dgvFuncionario.Size = new System.Drawing.Size(605, 251);
            this.dgvFuncionario.TabIndex = 1;
            this.dgvFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionario_CellContentClick);
            // 
            // btnEditarFuncionario
            // 
            this.btnEditarFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.btnEditarFuncionario.Enabled = false;
            this.btnEditarFuncionario.Location = new System.Drawing.Point(515, 78);
            this.btnEditarFuncionario.Name = "btnEditarFuncionario";
            this.btnEditarFuncionario.Size = new System.Drawing.Size(97, 32);
            this.btnEditarFuncionario.TabIndex = 23;
            this.btnEditarFuncionario.Text = "Editar";
            this.btnEditarFuncionario.UseVisualStyleBackColor = false;
            this.btnEditarFuncionario.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.btnDeletarFuncionario.Enabled = false;
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(406, 78);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(97, 32);
            this.btnDeletarFuncionario.TabIndex = 22;
            this.btnDeletarFuncionario.Text = "Deletar";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = false;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(406, 23);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(97, 32);
            this.btnBuscarFuncionario.TabIndex = 21;
            this.btnBuscarFuncionario.Text = "Buscar";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = false;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // lblCPFFuncionarioBusca
            // 
            this.lblCPFFuncionarioBusca.AutoSize = true;
            this.lblCPFFuncionarioBusca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPFFuncionarioBusca.ForeColor = System.Drawing.Color.Silver;
            this.lblCPFFuncionarioBusca.Location = new System.Drawing.Point(12, 27);
            this.lblCPFFuncionarioBusca.Name = "lblCPFFuncionarioBusca";
            this.lblCPFFuncionarioBusca.Size = new System.Drawing.Size(161, 21);
            this.lblCPFFuncionarioBusca.TabIndex = 20;
            this.lblCPFFuncionarioBusca.Text = "CPF do Funcionário:";
            // 
            // txtCpfFuncionarioBuscar
            // 
            this.txtCpfFuncionarioBuscar.BackColor = System.Drawing.Color.Yellow;
            this.txtCpfFuncionarioBuscar.Location = new System.Drawing.Point(179, 29);
            this.txtCpfFuncionarioBuscar.Name = "txtCpfFuncionarioBuscar";
            this.txtCpfFuncionarioBuscar.Size = new System.Drawing.Size(221, 23);
            this.txtCpfFuncionarioBuscar.TabIndex = 19;
            // 
            // TelaBuscarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(618, 382);
            this.Controls.Add(this.btnEditarFuncionario);
            this.Controls.Add(this.btnDeletarFuncionario);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.lblCPFFuncionarioBusca);
            this.Controls.Add(this.txtCpfFuncionarioBuscar);
            this.Controls.Add(this.dgvFuncionario);
            this.Name = "TelaBuscarFuncionario";
            this.Text = "Buscar Funcionario";
            this.Load += new System.EventHandler(this.TelaBuscarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Button btnEditarFuncionario;
        private System.Windows.Forms.Button btnDeletarFuncionario;
        private System.Windows.Forms.Button btnBuscarFuncionario;
        private System.Windows.Forms.Label lblCPFFuncionarioBusca;
        private System.Windows.Forms.TextBox txtCpfFuncionarioBuscar;
    }
}
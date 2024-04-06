
namespace PrjEscolaABC
{
    partial class BuscarMatricula
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
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.dgvBuscarMatricula = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarMatricula
            // 
            this.btnBuscarMatricula.BackColor = System.Drawing.Color.Yellow;
            this.btnBuscarMatricula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarMatricula.Location = new System.Drawing.Point(387, 40);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(97, 32);
            this.btnBuscarMatricula.TabIndex = 27;
            this.btnBuscarMatricula.Text = "Buscar";
            this.btnBuscarMatricula.UseVisualStyleBackColor = false;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Matricula do Aluno:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.BackColor = System.Drawing.Color.Yellow;
            this.txtMatricula.Location = new System.Drawing.Point(190, 46);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(191, 23);
            this.txtMatricula.TabIndex = 25;
            // 
            // dgvBuscarMatricula
            // 
            this.dgvBuscarMatricula.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvBuscarMatricula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMatricula.Location = new System.Drawing.Point(23, 119);
            this.dgvBuscarMatricula.Name = "dgvBuscarMatricula";
            this.dgvBuscarMatricula.RowTemplate.Height = 25;
            this.dgvBuscarMatricula.Size = new System.Drawing.Size(604, 251);
            this.dgvBuscarMatricula.TabIndex = 24;
            this.dgvBuscarMatricula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarMatricula_CellClick);
            // 
            // BuscarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(651, 411);
            this.Controls.Add(this.btnBuscarMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.dgvBuscarMatricula);
            this.Name = "BuscarMatricula";
            this.Text = "BuscarMatricula";
            this.Load += new System.EventHandler(this.BuscarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.DataGridView dgvBuscarMatricula;
    }
}
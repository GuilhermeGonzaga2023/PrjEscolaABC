
namespace PrjEscolaABC
{
    partial class TelaAcessar
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
            this.txtsenhaAcessar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemailAcessar = new System.Windows.Forms.TextBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Login";
            // 
            // txtsenhaAcessar
            // 
            this.txtsenhaAcessar.BackColor = System.Drawing.Color.Yellow;
            this.txtsenhaAcessar.Location = new System.Drawing.Point(60, 97);
            this.txtsenhaAcessar.Name = "txtsenhaAcessar";
            this.txtsenhaAcessar.PasswordChar = '*';
            this.txtsenhaAcessar.Size = new System.Drawing.Size(223, 23);
            this.txtsenhaAcessar.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "senha:";
            // 
            // txtemailAcessar
            // 
            this.txtemailAcessar.BackColor = System.Drawing.Color.Yellow;
            this.txtemailAcessar.Location = new System.Drawing.Point(60, 57);
            this.txtemailAcessar.Name = "txtemailAcessar";
            this.txtemailAcessar.Size = new System.Drawing.Size(223, 23);
            this.txtemailAcessar.TabIndex = 8;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Yellow;
            this.btnAcessar.Location = new System.Drawing.Point(192, 133);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(91, 39);
            this.btnAcessar.TabIndex = 7;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "email:";
            // 
            // TelaAcessar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(316, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsenhaAcessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemailAcessar);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.label1);
            this.Name = "TelaAcessar";
            this.Text = "Acessar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsenhaAcessar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemailAcessar;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label label1;
    }
}
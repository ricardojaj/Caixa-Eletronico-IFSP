namespace frmJogoDaSorte
{
    partial class frmJogoDaSorte
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.txtVerificarNumero = new System.Windows.Forms.TextBox();
            this.txtNumeroDeJogadas = new System.Windows.Forms.TextBox();
            this.txtNumerosJogados = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDesistencia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTitulo.Location = new System.Drawing.Point(210, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(166, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Jogo da Sorte";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.Location = new System.Drawing.Point(12, 80);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(268, 19);
            this.lblInfo1.TabIndex = 1;
            this.lblInfo1.Text = "Digite um numero impar de 0 a 99:";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.Location = new System.Drawing.Point(12, 133);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(173, 19);
            this.lblInfo2.TabIndex = 2;
            this.lblInfo2.Text = "Numero de Jogadas: ";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.Location = new System.Drawing.Point(13, 184);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(156, 19);
            this.lblInfo3.TabIndex = 3;
            this.lblInfo3.Text = "Numeros Jogados:";
            // 
            // txtVerificarNumero
            // 
            this.txtVerificarNumero.Location = new System.Drawing.Point(286, 79);
            this.txtVerificarNumero.Name = "txtVerificarNumero";
            this.txtVerificarNumero.Size = new System.Drawing.Size(77, 20);
            this.txtVerificarNumero.TabIndex = 4;
            this.txtVerificarNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.somenteNumeros);
            // 
            // txtNumeroDeJogadas
            // 
            this.txtNumeroDeJogadas.Location = new System.Drawing.Point(191, 132);
            this.txtNumeroDeJogadas.Name = "txtNumeroDeJogadas";
            this.txtNumeroDeJogadas.Size = new System.Drawing.Size(172, 20);
            this.txtNumeroDeJogadas.TabIndex = 5;
            // 
            // txtNumerosJogados
            // 
            this.txtNumerosJogados.Location = new System.Drawing.Point(175, 183);
            this.txtNumerosJogados.Name = "txtNumerosJogados";
            this.txtNumerosJogados.Size = new System.Drawing.Size(398, 20);
            this.txtNumerosJogados.TabIndex = 6;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Green;
            this.btnVerificar.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(215, 229);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(161, 56);
            this.btnVerificar.TabIndex = 7;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(502, 277);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 36);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDesistencia
            // 
            this.btnDesistencia.BackColor = System.Drawing.Color.Gray;
            this.btnDesistencia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesistencia.Location = new System.Drawing.Point(17, 277);
            this.btnDesistencia.Name = "btnDesistencia";
            this.btnDesistencia.Size = new System.Drawing.Size(82, 31);
            this.btnDesistencia.TabIndex = 9;
            this.btnDesistencia.Text = "DESISTO";
            this.btnDesistencia.UseVisualStyleBackColor = false;
            this.btnDesistencia.Click += new System.EventHandler(this.btnDesistencia_Click);
            // 
            // frmJogoDaSorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(613, 335);
            this.Controls.Add(this.btnDesistencia);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumerosJogados);
            this.Controls.Add(this.txtNumeroDeJogadas);
            this.Controls.Add(this.txtVerificarNumero);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJogoDaSorte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.TextBox txtVerificarNumero;
        private System.Windows.Forms.TextBox txtNumeroDeJogadas;
        private System.Windows.Forms.TextBox txtNumerosJogados;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDesistencia;
    }
}


namespace ChatClientMacoratti
{
    partial class frmCliente
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
            this.labelServidor = new System.Windows.Forms.Label();
            this.txtServidorIP = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelServidor.Location = new System.Drawing.Point(12, 33);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(100, 21);
            this.labelServidor.TabIndex = 0;
            this.labelServidor.Text = "Servidor - IP ";
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.ForeColor = System.Drawing.Color.Black;
            this.txtServidorIP.Location = new System.Drawing.Point(118, 35);
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Size = new System.Drawing.Size(158, 23);
            this.txtServidorIP.TabIndex = 1;
            this.txtServidorIP.TextChanged += new System.EventHandler(this.txtServidorIP_TextChanged);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsuario.Location = new System.Drawing.Point(12, 79);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 20);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(118, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(158, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(295, 80);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(13, 378);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(263, 23);
            this.txtMensagem.TabIndex = 7;
            this.txtMensagem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagem_KeyPress);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(13, 120);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(263, 230);
            this.txtLog.TabIndex = 8;
            this.txtLog.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(295, 378);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(392, 427);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.txtServidorIP);
            this.Controls.Add(this.labelServidor);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCliente";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.TextBox txtServidorIP;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnEnviar;
    }
}

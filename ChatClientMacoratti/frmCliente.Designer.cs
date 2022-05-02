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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtServidorIP = new ChatClientMacoratti.Controles.CustomTextBox();
            this.txtUsuario = new ChatClientMacoratti.Controles.CustomTextBox();
            this.txtLog = new ChatClientMacoratti.Controles.CustomTextBox();
            this.txtMensagem = new ChatClientMacoratti.Controles.CustomTextBox();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConectar.Location = new System.Drawing.Point(206, 69);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(132, 34);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEnviar.Location = new System.Drawing.Point(143, 384);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(104, 31);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtServidorIP
            // 
            this.txtServidorIP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtServidorIP.BoderColor = System.Drawing.Color.Black;
            this.txtServidorIP.BorderFocusColor = System.Drawing.Color.DimGray;
            this.txtServidorIP.BorderRadius = 15;
            this.txtServidorIP.BorderSize = 1;
            this.txtServidorIP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServidorIP.ForeColor = System.Drawing.Color.Black;
            this.txtServidorIP.Location = new System.Drawing.Point(41, 31);
            this.txtServidorIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServidorIP.Multiline = false;
            this.txtServidorIP.Name = "txtServidorIP";
            this.txtServidorIP.Padding = new System.Windows.Forms.Padding(12, 7, 12, 7);
            this.txtServidorIP.PasswordChar = false;
            this.txtServidorIP.PlaceHolderColor = System.Drawing.Color.Black;
            this.txtServidorIP.PlaceHolderText = "Servidor - IP";
            this.txtServidorIP.Size = new System.Drawing.Size(297, 32);
            this.txtServidorIP.TabIndex = 10;
            this.txtServidorIP.Texts = "";
            this.txtServidorIP.UnderlineStyle = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.BoderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsuario.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsuario.BorderRadius = 15;
            this.txtUsuario.BorderSize = 0;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(41, 71);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.PlaceHolderText = "Usuário";
            this.txtUsuario.Size = new System.Drawing.Size(158, 32);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlineStyle = false;
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLog.BoderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtLog.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtLog.BorderRadius = 18;
            this.txtLog.BorderSize = 0;
            this.txtLog.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(41, 109);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLog.PasswordChar = false;
            this.txtLog.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtLog.PlaceHolderText = "";
            this.txtLog.Size = new System.Drawing.Size(297, 230);
            this.txtLog.TabIndex = 12;
            this.txtLog.Texts = "";
            this.txtLog.UnderlineStyle = false;
            // 
            // txtMensagem
            // 
            this.txtMensagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMensagem.BoderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMensagem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMensagem.BorderRadius = 15;
            this.txtMensagem.BorderSize = 0;
            this.txtMensagem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMensagem.Location = new System.Drawing.Point(41, 345);
            this.txtMensagem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMensagem.Multiline = false;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.txtMensagem.PasswordChar = false;
            this.txtMensagem.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.txtMensagem.PlaceHolderText = "";
            this.txtMensagem.Size = new System.Drawing.Size(297, 32);
            this.txtMensagem.TabIndex = 13;
            this.txtMensagem.Texts = "";
            this.txtMensagem.UnderlineStyle = false;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(382, 427);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidorIP);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnConectar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmCliente";
            this.Text = "Chat";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnEnviar;
        private Controles.CustomTextBox txtServidorIP;
        private Controles.CustomTextBox txtUsuario;
        private Controles.CustomTextBox txtLog;
        private Controles.CustomTextBox txtMensagem;
    }
}

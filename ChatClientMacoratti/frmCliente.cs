using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace ChatClientMacoratti
{
    public partial class frmCliente : Form
    {
        private string NomeUsuario = "Desconhecido";
        private StreamWriter stwEnviador;
        private StreamReader strReceptor;
        private TcpClient tcpServidor;
        private delegate void AtualizaLogCallBack(string strMensagem);
        private delegate void FechaConexaoCallBack(string strMotivo);
        private Thread mensagemThread;
        private IPAddress enderecoIP;
        private bool Conectado;        

        public frmCliente()
        {
            Application.ApplicationExit += new EventHandler(OnApplicationExit);
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, System.EventArgs e)
        {
            if (Conectado == false)
            {
                InicializaConexao();
            }
            else
            {
                FechaConexao("Desconectado a pedido do usuário.");
            }
        }        

        private void InicializaConexao()
        {
            try
            {
                enderecoIP = IPAddress.Parse(txtServidorIP.Text);
                tcpServidor = new TcpClient();
                tcpServidor.Connect(enderecoIP, 2502);

                Conectado = true;                

                NomeUsuario = txtUsuario.Text;

                txtServidorIP.Enabled = false;
                txtUsuario.Enabled = false;
                txtMensagem.Enabled = true;
                btnEnviar.Enabled = true;
                btnConectar.Text = "Desconectado";
                txtLog.Text = String.Empty;

                stwEnviador = new StreamWriter(tcpServidor.GetStream());
                stwEnviador.WriteLine(txtUsuario.Text);
                stwEnviador.Flush();

                mensagemThread = new Thread(new ThreadStart(RecebeMensagens));
                mensagemThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message, "Erro na conexão com servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RecebeMensagens()
        {
            strReceptor = new StreamReader(tcpServidor.GetStream());
            string ConResposta = strReceptor.ReadLine();

            if (ConResposta[0] == '1')
            {
                this.Invoke(new AtualizaLogCallBack(this.AtualizaLog), new object[] { "Conectado com sucesso!" });
            }
            else
            {
                string Motivo = "Não Conectado: ";
                Motivo += ConResposta.Substring(2, ConResposta.Length - 2);
                this.Invoke(new FechaConexaoCallBack(FechaConexao), new object[] { "Desconectado" });
                return;
            }

            while (Conectado)
            {
                try
                {
                    string msg = strReceptor.ReadLine();
                    this.Invoke(
                        new AtualizaLogCallBack(this.AtualizaLog), new object[] { msg }
                        );
                }
                catch
                {
                    MessageBox.Show("Conexão encerrada");                    
                }
            }
        }

        private void AtualizaLog(string strMensagem)
        {
            txtLog.AppendText(strMensagem + "\r\n");
        }

        private void btnEnviar_Click(object sender, System.EventArgs e)
        {
            EnviaMensagem();
        }

        private void txtMensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                EnviaMensagem();
            }
        }

        private void EnviaMensagem()
        {
            if (txtMensagem.Lines.Length >= 1)
            {
                stwEnviador.WriteLine(txtMensagem.Text);
                stwEnviador.Flush();
                txtMensagem.Lines = null;
            }
            txtMensagem.Text = "";
        }

        private void FechaConexao(string Motivo)
        {
            txtLog.Text = String.Empty;
            txtLog.AppendText(Motivo + "\r\n");
            txtServidorIP.Enabled = true;
            txtServidorIP.Text = String.Empty;
            txtUsuario.Enabled = true;
            txtUsuario.Text = String.Empty;
            txtMensagem.Enabled = false;
            txtMensagem.Text = String.Empty;
            btnEnviar.Enabled = false;
            btnConectar.Text = "Conectado";
            
            Conectado = false;
            stwEnviador.Close();
            strReceptor.Close();
            tcpServidor.Close();
        }

        public void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado == true)
            {
                Conectado = false;
                tcpServidor.Close();
                stwEnviador.Close();
                strReceptor.Close();                
            }
        }             
    }
}

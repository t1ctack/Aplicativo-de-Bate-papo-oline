using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
namespace AplicativoDeBatePapo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBoxServidor_Enter(object sender, EventArgs e)
        {

        }
        
        private void buttonEnviarMensagem_Click(object sender, EventArgs e)
        {
            try
            {
               //Criar o cliente para se conectar em algum servidor de outra aplicação
               TcpClient tcpClient = new TcpClient(textBoxIPdoContato.Text, Convert.ToInt32(textBoxPortaDoContato.Text));
                NetworkStream ns = tcpClient.GetStream(); 

               //Enviando mensagem
               string mensagem = textBoxMeuNome.Text + ": " + richTextBoxMensagens.Text;
               byte[] mensagemBytes = Encoding.ASCII.GetBytes(mensagem);
               ns.Write(mensagemBytes, 0, mensagemBytes.Length);
                
                //Fechando conexão
                tcpClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Algo deu errado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAplicarConfigServidor_Click(object sender, EventArgs e)
        {

        }
    }
}

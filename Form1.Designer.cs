namespace AplicativoDeBatePapo
{
    partial class Form1
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
            groupBoxMensagens = new GroupBox();
            buttonEnviarMensagem = new Button();
            textBoxPortaDoContato = new TextBox();
            textBoxIPdoContato = new TextBox();
            label4 = new Label();
            label3 = new Label();
            richTextBoxMensagensParaEnviar = new RichTextBox();
            label2 = new Label();
            richTextBoxMensagens = new RichTextBox();
            textBoxMeuNome = new TextBox();
            label1 = new Label();
            groupBoxServidor = new GroupBox();
            label5 = new Label();
            textBoxPortaDoServidor = new TextBox();
            buttonAplicarConfigServidor = new Button();
            groupBoxMensagens.SuspendLayout();
            groupBoxServidor.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMensagens
            // 
            groupBoxMensagens.Controls.Add(buttonEnviarMensagem);
            groupBoxMensagens.Controls.Add(textBoxPortaDoContato);
            groupBoxMensagens.Controls.Add(textBoxIPdoContato);
            groupBoxMensagens.Controls.Add(label4);
            groupBoxMensagens.Controls.Add(label3);
            groupBoxMensagens.Controls.Add(richTextBoxMensagensParaEnviar);
            groupBoxMensagens.Controls.Add(label2);
            groupBoxMensagens.Controls.Add(richTextBoxMensagens);
            groupBoxMensagens.Controls.Add(textBoxMeuNome);
            groupBoxMensagens.Controls.Add(label1);
            groupBoxMensagens.Location = new Point(14, 7);
            groupBoxMensagens.Name = "groupBoxMensagens";
            groupBoxMensagens.Size = new Size(479, 329);
            groupBoxMensagens.TabIndex = 0;
            groupBoxMensagens.TabStop = false;
            groupBoxMensagens.Text = "Mensagens";
            // 
            // buttonEnviarMensagem
            // 
            buttonEnviarMensagem.Location = new Point(16, 292);
            buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            buttonEnviarMensagem.Size = new Size(75, 23);
            buttonEnviarMensagem.TabIndex = 9;
            buttonEnviarMensagem.Text = "Enviar";
            buttonEnviarMensagem.UseVisualStyleBackColor = true;
            // 
            // textBoxPortaDoContato
            // 
            textBoxPortaDoContato.Location = new Point(344, 252);
            textBoxPortaDoContato.Name = "textBoxPortaDoContato";
            textBoxPortaDoContato.Size = new Size(86, 23);
            textBoxPortaDoContato.TabIndex = 8;
            // 
            // textBoxIPdoContato
            // 
            textBoxIPdoContato.Location = new Point(96, 252);
            textBoxIPdoContato.Name = "textBoxIPdoContato";
            textBoxIPdoContato.Size = new Size(137, 23);
            textBoxIPdoContato.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 255);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 6;
            label4.Text = "Porta do contato:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 255);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 5;
            label3.Text = "IP do contato:";
            // 
            // richTextBoxMensagensParaEnviar
            // 
            richTextBoxMensagensParaEnviar.Location = new Point(144, 208);
            richTextBoxMensagensParaEnviar.Name = "richTextBoxMensagensParaEnviar";
            richTextBoxMensagensParaEnviar.Size = new Size(286, 38);
            richTextBoxMensagensParaEnviar.TabIndex = 4;
            richTextBoxMensagensParaEnviar.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 221);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 3;
            label2.Text = "Mensagens para enviar";
            // 
            // richTextBoxMensagens
            // 
            richTextBoxMensagens.Location = new Point(8, 58);
            richTextBoxMensagens.Name = "richTextBoxMensagens";
            richTextBoxMensagens.Size = new Size(422, 134);
            richTextBoxMensagens.TabIndex = 2;
            richTextBoxMensagens.Text = "";
            // 
            // textBoxMeuNome
            // 
            textBoxMeuNome.Location = new Point(80, 25);
            textBoxMeuNome.Name = "textBoxMeuNome";
            textBoxMeuNome.Size = new Size(351, 23);
            textBoxMeuNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 28);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Meu nome:";
            // 
            // groupBoxServidor
            // 
            groupBoxServidor.Controls.Add(buttonAplicarConfigServidor);
            groupBoxServidor.Controls.Add(textBoxPortaDoServidor);
            groupBoxServidor.Controls.Add(label5);
            groupBoxServidor.Location = new Point(14, 342);
            groupBoxServidor.Name = "groupBoxServidor";
            groupBoxServidor.Size = new Size(480, 99);
            groupBoxServidor.TabIndex = 1;
            groupBoxServidor.TabStop = false;
            groupBoxServidor.Text = "Configurações do servidor";
            groupBoxServidor.Enter += groupBoxServidor_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 32);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 0;
            label5.Text = "Porta do servidor: ";
            // 
            // textBoxPortaDoServidor
            // 
            textBoxPortaDoServidor.Location = new Point(133, 24);
            textBoxPortaDoServidor.Name = "textBoxPortaDoServidor";
            textBoxPortaDoServidor.Size = new Size(298, 23);
            textBoxPortaDoServidor.TabIndex = 1;
            // 
            // buttonAplicarConfigServidor
            // 
            buttonAplicarConfigServidor.Location = new Point(16, 60);
            buttonAplicarConfigServidor.Name = "buttonAplicarConfigServidor";
            buttonAplicarConfigServidor.Size = new Size(163, 23);
            buttonAplicarConfigServidor.TabIndex = 2;
            buttonAplicarConfigServidor.Text = "Aplicar configurações";
            buttonAplicarConfigServidor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 464);
            Controls.Add(groupBoxServidor);
            Controls.Add(groupBoxMensagens);
            Name = "Form1";
            Text = "Form1";
            groupBoxMensagens.ResumeLayout(false);
            groupBoxMensagens.PerformLayout();
            groupBoxServidor.ResumeLayout(false);
            groupBoxServidor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMensagens;
        private GroupBox groupBoxServidor;
        private RichTextBox richTextBoxMensagensParaEnviar;
        private Label label2;
        private RichTextBox richTextBoxMensagens;
        private TextBox textBoxMeuNome;
        private Label label1;
        private TextBox textBoxPortaDoContato;
        private TextBox textBoxIPdoContato;
        private Label label4;
        private Label label3;
        private Button buttonEnviarMensagem;
        private Button buttonAplicarConfigServidor;
        private TextBox textBoxPortaDoServidor;
        private Label label5;
    }
}

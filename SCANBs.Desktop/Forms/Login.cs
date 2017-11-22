using SCANBs.ApplicationImplementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCANBs.Desktop
{
    public partial class Login : Form
    {

        PessoaApplication PessoaApplication = new PessoaApplication();

        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string senha = "";
            short idPessoa = 0;
            idPessoa = (short)PessoaApplication.TodosPessoas().Where(y => y.Usuario == textBoxUsuario.Text).Select(x => x.IdPessoa).FirstOrDefault();
            if (textBoxUsuario.Text == null || textBoxUsuario.Text == "")
            {
                MessageBox.Show("Preencha o campo usuário");
            }
            else
            {
                if (idPessoa == 0)
                {
                    MessageBox.Show("Não existe o usuário informado");
                }
                else
                {
                    senha = PessoaApplication.TodosPessoas().Where(y => y.IdPessoa == idPessoa).Select(x => x.Senha).FirstOrDefault().ToString();
                    if (senha == textBoxSenha.Text)
                    {
                        Principal principal = new Principal();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("A senha informada está incorreta");
                    }
                }
            }
        }
    }
}

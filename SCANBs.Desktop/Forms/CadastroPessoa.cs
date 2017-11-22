using SCANBs.ApplicationImplementation;
using SCANBs.Data;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SCANBs.Desktop.Forms
{
    public partial class CadastroPessoa : Form
    {

        private readonly PessoaApplication PessoaApplication = new PessoaApplication();
        private readonly FuncionarioApplication FuncionarioApplication = new FuncionarioApplication();
        private readonly OrganizadorApplication OrganizadorApplication = new OrganizadorApplication();
        private readonly EspectadorApplication EspectadorApplication = new EspectadorApplication();
        private readonly CargoApplication CargoApplication = new CargoApplication();
        private readonly TelefoneApplication TelefoneApplication = new TelefoneApplication();
        private readonly ApresentadorApplication ApresentadorApplication = new ApresentadorApplication();
        private Funcionario funcionario;
        private Telefone telefone;
        private Apresentador apresentador;
        private Organizador organizador;
        private Espectador espectador;

        
        private Pessoa pessoa;
        private string load = "";

        public Image GetDataToImage(byte[] pData)
        {
            try
            {
                ImageConverter imgConverter = new ImageConverter();
                return imgConverter.ConvertFrom(pData) as Image;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

                

        public CadastroPessoa()
        {
            InitializeComponent();
            
        }

        public bool VerificaSenha()
        {
            if (textBoxSenha.Text != textBoxConfirmaSenha.Text)
            {

                MessageBox.Show("As senhas não conferem!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images only. |*.jpg; *.jpeg; *.png; *.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBoxFotoPerfil.Image = Image.FromFile(OpenFd.FileName);
            pictureBoxFotoPerfil.Tag = OpenFd.FileName;


        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (VerificaSenha() == false)
            {
                MessageBox.Show("As senhas não conferem");
            }
            else
            {
                if ((pessoa == null)&&(telefone == null))
                //{
                    pessoa = new Pessoa();
                    telefone = new Telefone();

                pessoa.NomeCompleto = (textBoxNomeCompleto.Text).ToString();
                pessoa.CPF = (textBoxCPF.Text).ToString();
                int numeroTelefone = 0;
                int.TryParse(textBoxTelefone.Text, out numeroTelefone);
                telefone.NumeroTelefone = numeroTelefone;
                    
                pessoa.Usuario = (textBoxUsuario.Text).ToString();
                pessoa.Senha = (textBoxSenha.Text).ToString();
                pessoa.Email = (textBoxEmail.Text).ToString();
                //string imgPath = pictureBoxFotoPerfil.Tag + string.Empty;
                string imgPath = pictureBoxFotoPerfil.Tag + string.Empty;
                string nameImage = imgPath.Substring(imgPath.LastIndexOf('\\') + 1);
                string imagemNoDestino = Path.Combine(@"C:\Users\Cesar Murilo\Desktop\SCANBs\ShowCarsAndBikes\images", nameImage);
                if (pessoa.IdPessoa != 0)
                {
                    pessoa.FotoPessoa = PessoaApplication.TodosPessoas().Where(x => x.IdPessoa == pessoa.IdPessoa).Select(x => x.FotoPessoa).FirstOrDefault();
                    //MessageBox.Show(imagemNoDestino);
                }
                else
                {
                    File.Copy(imgPath, imagemNoDestino);
                    pessoa.FotoPessoa = imagemNoDestino;
                }
                /* ---------------------- Início do Cadastro de Pessoas ---------------------*/
                    
                if (comboBoxPerfil.SelectedItem.ToString() == "Funcionário")
                {
                    pessoa.Perfil = "Funcionário";
                    short idCargo = 0;
                    idCargo = (short)comboBoxCargo.SelectedValue;
                    if(pessoa.Funcionario == null)
                        pessoa.Funcionario = new Funcionario();
                        pessoa.Funcionario.IdCargo = idCargo;
                        
                    var erroFuncionario = PessoaApplication.SalvarPessoa(pessoa);
                    if (String.IsNullOrEmpty(erroFuncionario))
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                        TelefoneApplication.SalvarTelefone(telefone);
                        load = "*";
                        CarregarDados(load);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar funcionário");
                    }

                }

                else if (comboBoxPerfil.SelectedItem.ToString() == "Organizador")
                {
                    pessoa.Perfil = "Organizador";
                    if(pessoa.Organizador == null)
                        pessoa.Organizador = new Organizador();
                    var erroOrganizador = PessoaApplication.SalvarPessoa(pessoa);
                    if (String.IsNullOrEmpty(erroOrganizador))
                    {
                        MessageBox.Show("Organizador cadastrado com sucesso!");
                        short ultimaPessoaCadastrada = 0;
                        ultimaPessoaCadastrada = PessoaApplication.TodosPessoas().Select(x => x.IdPessoa).Last();
                        telefone.IdPessoa = ultimaPessoaCadastrada;
                        TelefoneApplication.SalvarTelefone(telefone);
                        load = "*";
                        CarregarDados(load);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar organizador");
                    }
                }

                else if (comboBoxPerfil.SelectedItem.ToString() == "Espectador")
                {
                    pessoa.Perfil = "Espectador";
                    if(pessoa.Espectador == null)
                        pessoa.Espectador = new Espectador();
                    var erroEspectador = PessoaApplication.SalvarPessoa(pessoa);
                    if (String.IsNullOrEmpty(erroEspectador))
                    {
                        MessageBox.Show("Espectador cadastrado com sucesso!");
                        TelefoneApplication.SalvarTelefone(telefone);
                        load = "*";
                        CarregarDados(load);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar espectador");
                    }
                }

                else if (comboBoxPerfil.SelectedItem.ToString() == "Apresentador")
                {
                    pessoa.Perfil = "Apresentador";
                    if(pessoa.Apresentador == null)
                        pessoa.Apresentador = new Apresentador();
                    var erroApresentador = PessoaApplication.SalvarPessoa(pessoa);
                    if (String.IsNullOrEmpty(erroApresentador))
                    {
                        MessageBox.Show("Apresentador cadastrado com sucesso!");
                        TelefoneApplication.SalvarTelefone(telefone);
                        load = "*";
                        CarregarDados(load);
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar apresentador");
                    }
                }
                //}
                
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewPessoa.SelectedRows.Count > 0)
            {
                short idPessoa = (short)dataGridViewPessoa.CurrentRow.Cells[0].Value;
                pessoa = PessoaApplication.ObterPessoa(x => x.IdPessoa == idPessoa);

                textBoxNomeCompleto.Text = pessoa.NomeCompleto.ToString();
                textBoxCPF.Text = pessoa.CPF.ToString();
                textBoxUsuario.Text = pessoa.Usuario.ToString();
                textBoxSenha.Text = pessoa.Senha.ToString();
                textBoxConfirmaSenha.Text = pessoa.Senha.ToString();
                labelSenha.Visible = false;
                labelConfirmaSenha.Visible = false;
                textBoxSenha.Visible = false;
                textBoxConfirmaSenha.Visible = false;
                textBoxEmail.Text = pessoa.Email.ToString();
                textBoxTelefone.Text = pessoa.Telefone.Select(t => t.NumeroTelefone).FirstOrDefault().ToString();
                comboBoxPerfil.SelectedItem = pessoa.Perfil; 
            }
            else
            {

            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewPessoa.SelectedRows.Count > 0)
            {
                short idPessoa = (short)dataGridViewPessoa.CurrentRow.Cells[0].Value;
                short idTelefone = 0;
                pessoa = PessoaApplication.ObterPessoa(x => x.IdPessoa == idPessoa);
                // tenho que deletar todos os telefones da pessoa primeiro;
                do
                {
                    idTelefone = TelefoneApplication.TodosTelefones().Where(x => x.IdPessoa == idPessoa).Select(x => x.IdTelefone).FirstOrDefault();
                    telefone = TelefoneApplication.ObterTelefone(x => x.IdTelefone == idTelefone);
                    var erroTelefone = TelefoneApplication.ExcluirTelefone(telefone);
                    if (String.IsNullOrEmpty(erroTelefone))
                    {
                        //Mensagem abaixo é somente para testes
                        if (telefone == null)
                        {
                            MessageBox.Show("Essa pessoa não tem mais telefones");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Os telefones desta pessoas estão sendo excluídos... Um telefone excluído com sucesso!");
                        }
                    }
                    else
                    {
                        if (telefone == null)
                        {
                            MessageBox.Show("Essa pessoa não tem telefones");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir telefone de id " + telefone.IdTelefone);
                        }
                    }

                } while (telefone != null);

                if (MessageBox.Show("Deseja realmente excluir " + pessoa.NomeCompleto + "?", "Confirmação Exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    funcionario = FuncionarioApplication.ObterFuncionario(x => x.IdPessoaFuncionario == idPessoa);
                    apresentador = ApresentadorApplication.ObterApresentador(x => x.IdPessoaApresentador == idPessoa);
                    organizador = OrganizadorApplication.ObterOrganizador(x => x.IdPessoaOrganizador == idPessoa);
                    espectador = EspectadorApplication.ObterEspectador(x => x.IdPessoaEspectador == idPessoa);


                    if ((pessoa.Perfil == "Funcionário") || (pessoa.Perfil == "Administrador") || (pessoa.Perfil == "Vendedor"))
                    {
                        var erroFuncionario = FuncionarioApplication.ExcluirFuncionario(funcionario);
                        if (String.IsNullOrEmpty(erroFuncionario))
                        {
                            MessageBox.Show("Funcionário excluido com sucesso!");
                            pessoa.Perfil = null;
                            PessoaApplication.SalvarPessoa(pessoa);
                            
                            var erroPessoa = PessoaApplication.ExcluirPessoa(pessoa);
                            if (String.IsNullOrEmpty(erroPessoa))
                            {
                                MessageBox.Show("Pessoa excluída com sucesso!");
                                load = "*";
                                CarregarDados(load);
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir pessoa!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir funcionário!");
                        }
                    }

                    else if (pessoa.Perfil == "Apresentador")
                    {
                        var erroApresentador = ApresentadorApplication.ExcluirApresentador(apresentador);

                        if (String.IsNullOrEmpty(erroApresentador))
                        {
                            MessageBox.Show("Apresentador excluido com sucesso!");
                            pessoa.Perfil = null;
                            PessoaApplication.SalvarPessoa(pessoa);
                            
                            var erroPessoa = PessoaApplication.ExcluirPessoa(pessoa);
                            if (String.IsNullOrEmpty(erroPessoa))
                            {
                                MessageBox.Show("Pessoa excluída com sucesso!");
                                load = "*";
                                CarregarDados(load);
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir apresentador!");
                            }
                            
                        }
                    }

                    else if (pessoa.Perfil == "Espectador")
                    {
                        var erroEspectador = EspectadorApplication.ExcluirEspectador(espectador);

                        if (String.IsNullOrEmpty(erroEspectador))
                        {
                            MessageBox.Show("Espectador excluido com sucesso!");
                            pessoa.Perfil = null;
                            PessoaApplication.SalvarPessoa(pessoa);
                            
                            var erroPessoa = PessoaApplication.ExcluirPessoa(pessoa);
                            if (String.IsNullOrEmpty(erroPessoa))
                            {
                                MessageBox.Show("Pessoa excluída com sucesso!");
                                load = "*";
                                CarregarDados(load);
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir espectador!");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro ao  excluir!");
                        }
                    }

                    else if (pessoa.Perfil == "Organizador")
                    {
                        var erroOrganizador = OrganizadorApplication.ExcluirOrganizador(organizador);

                        if (String.IsNullOrEmpty(erroOrganizador))
                        {
                            MessageBox.Show("Organizador excluido com sucesso!");
                            pessoa.Perfil = null;
                            PessoaApplication.SalvarPessoa(pessoa);
                            
                            var erroPessoa = PessoaApplication.ExcluirPessoa(pessoa);
                            if (String.IsNullOrEmpty(erroPessoa))
                            {
                                MessageBox.Show("Pessoa excluída com sucesso!");
                                load = "*";
                                CarregarDados(load);
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir!");
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Erro ao  excluir organizador!");
                        }
                    }

                    else if(pessoa.Perfil == null)
                    {
                        var erroPessoa = PessoaApplication.ExcluirPessoa(pessoa);
                        if (String.IsNullOrEmpty(erroPessoa))
                        {
                            MessageBox.Show("Pessoa excluída com sucesso!");
                            load = "*";
                            CarregarDados(load);
                            LimparCampos();
                        }
                        else
                        {
                            MessageBox.Show("Erro ao excluir!");
                        }
                    }
                }
            }
            
        }

        public void LimparCampos()
        {
            textBoxNomeCompleto.Clear();
            textBoxCPF.Clear();
            textBoxUsuario.Clear();
            textBoxSenha.Clear();
            textBoxConfirmaSenha.Clear();
            textBoxEmail.Clear();
            textBoxTelefone.Clear();
            comboBoxPerfil.SelectedIndex = 0;
            comboBoxCargo.SelectedIndex = 0;
            pictureBoxFotoPerfil.Image = SCANBs.Desktop.Properties.Resources.perfil_empty;
            pessoa = null;
            telefone = null;
          
        }

        private void CadastroPessoa_Load(object sender, EventArgs e)
        {
            textBoxPesquisa.Text = "Informe o nome da pessoa que deseja consultar";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            comboBoxCargo.DataSource = CargoApplication.TodosCargos();
            comboBoxCargo.DisplayMember = "DescricaoCargo";
            comboBoxCargo.ValueMember = "IdCargo";

            dataGridViewPessoa.Visible = false;
            textBoxPesquisa.Visible = false;
            pictureBoxFotoMuda.Visible = false;
            button4.Visible = false;
            labelCargo.Visible = false;
            comboBoxCargo.Visible = false;
            
        }

        public void CarregarDados(string load)
        {
           
            //dataGridViewPessoa.ColumnCount = 7;
            //dataGridViewPessoa.AutoGenerateColumns = true;
            dataGridViewPessoa.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridViewPessoa.MultiSelect = false;
            dataGridViewPessoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dataGridViewPessoa.AutoGenerateColumns = true;
            dataGridViewPessoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            /*
            dataGridViewPessoa.Columns[0].HeaderText = "IdPessoa";
            dataGridViewPessoa.Columns[0].DataPropertyName = "IdPessoa";
            dataGridViewPessoa.Columns[0].Name = "IdEtapa";
            dataGridViewPessoa.Columns[0].Width = 100;

            dataGridViewPessoa.Columns[1].HeaderText = "Nome Completo";
            dataGridViewPessoa.Columns[1].DataPropertyName = "NomeCompleto";
            dataGridViewPessoa.Columns[1].Name = "NomeCompleto";
            dataGridViewPessoa.Columns[1].Width = 200;

            dataGridViewPessoa.Columns[2].HeaderText = "CPF";
            dataGridViewPessoa.Columns[2].DataPropertyName = "CPF";
            dataGridViewPessoa.Columns[2].Name = "CPF";
            dataGridViewPessoa.Columns[2].Width = 100;

            dataGridViewPessoa.Columns[3].HeaderText = "Usuario";
            dataGridViewPessoa.Columns[3].DataPropertyName = "Usuario";
            dataGridViewPessoa.Columns[3].Name = "Usuario";
            dataGridViewPessoa.Columns[3].Width = 100;
           
            dataGridViewPessoa.Columns[4].HeaderText = "Email";
            dataGridViewPessoa.Columns[4].DataPropertyName = "Email";
            dataGridViewPessoa.Columns[4].Name = "Email";
            dataGridViewPessoa.Columns[4].Width = 200;

            dataGridViewPessoa.Columns[5].HeaderText = "Telefone";
            dataGridViewPessoa.Columns[5].DataPropertyName = "Telefone";
            dataGridViewPessoa.Columns[5].Name = "Telefone";
            dataGridViewPessoa.Columns[5].Width = 100;

            dataGridViewPessoa.Columns[6].HeaderText = "Perfil";
            dataGridViewPessoa.Columns[6].DataPropertyName = "Perfil";
            dataGridViewPessoa.Columns[6].Name = "Perfil";
            dataGridViewPessoa.Columns[6].Width = 100;
            */
            if (load == "*")
            {

                dataGridViewPessoa.DataSource = PessoaApplication.TodosPessoas().Select(x => new
                {
                    x.IdPessoa,
                    x.NomeCompleto,
                    x.CPF,
                    x.FotoPessoa,
                    x.Usuario,
                    x.Email,
                    Telefone = x.Telefone.Select(t => t.NumeroTelefone).FirstOrDefault(),
                    x.Perfil
                }).ToList();
            }
            else
            {
                dataGridViewPessoa.DataSource = PessoaApplication.TodosPessoas().Select(x => new
                {
                    x.IdPessoa,
                    x.NomeCompleto,
                    x.CPF,
                    x.Usuario,
                    x.Email,
                    Telefone = x.Telefone.Select(t => t.NumeroTelefone).FirstOrDefault(),
                    x.Perfil
                }).Where(x => x.NomeCompleto.Contains(load)).ToList();
            }/**/
             
        }
        /*
        public void CarregarPesquisa(string load)
        {

            //dataGridViewPessoa.ColumnCount = DataGridViewColumn ;
            //CarregarDados();

            dataGridViewPessoa.DataSource = PessoaApplication.TodosPessoas().Select(x => new
            {
                x.IdPessoa,
                x.NomeCompleto,
                x.CPF,
                x.Usuario,
                x.Email,
                Telefone = x.Telefone.Select(t => t.NumeroTelefone).FirstOrDefault(),
                x.Perfil
            }).Where(x => x.NomeCompleto.Contains(load)).ToList();
        }
        */

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxPesquisa_Leave(object sender, EventArgs e)
        {
            if (textBoxPesquisa.Text == "")
            {
                textBoxPesquisa.Text = "Informe o nome da pessoa que deseja consultar";
                textBoxPesquisa.ForeColor = Color.Gray;
                load = "*";
                CarregarDados(load);
            }
        }

        private void textBoxPesquisa_TextChanged(object sender, EventArgs e)
        {
               CarregarDados(textBoxPesquisa.Text);
        }

        private void textBoxPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPesquisa.Text == "Informe o nome da pessoa que deseja consultar")
            {
                textBoxPesquisa.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            load = "*";
            CarregarDados(load);
            dataGridViewPessoa.Visible = true;
            textBoxPesquisa.Visible = true;
            pictureBoxFotoMuda.Visible = true;
            button4.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridViewPessoa.Visible = false;
            textBoxPesquisa.Visible = false;
            pictureBoxFotoMuda.Visible = false;
        }

        private void comboBoxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPerfil.SelectedIndex == 0)
            {
                labelCargo.Visible = true;
                comboBoxCargo.Visible = true;
            }

        }

        private void comboBoxPerfil_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxFotoPerfil_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewPessoa.CurrentRow.Cells[3].Value != null)
            {
                //string picpath = dataGridViewPessoa.CurrentRow.Cells[3].Value.ToString();
                //pictureBoxFotoMuda.ImageLocation = picpath;
                //pictureBoxFotoMuda.BackgroundImageLayout = ImageLayout.Tile;

                string path = dataGridViewPessoa.CurrentRow.Cells[3].Value.ToString();
                pictureBoxFotoMuda.Image = Image.FromFile(path);
                pictureBoxFotoMuda.SizeMode = PictureBoxSizeMode.Zoom;


            }
        }
    }
}

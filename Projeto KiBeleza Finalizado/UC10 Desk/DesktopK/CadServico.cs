using FTP_Upload;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopK
{
    public partial class frmCadServico : Form
    {
        public string funcao;
        string nome, status, desc, texto, empresa, foto, foto1, foto2, foto3, atFoto, atFoto1, atFoto2, atFoto3;
        double valor;
        DateTime dataCad = DateTime.Now;
        DateTime duracao;
        public int codServico;
        int codEmpresa;

        // FOTOS FTP
        string enderecoServidorFTP = "ftp://127.0.0.1/admin/Upload/servico/";
        string usuarioFTP = "ti07";
        string senhaFTP = "123";
        string caminhoFoto, caminhoFoto1, caminhoFoto2, caminhoFoto3;

        // VALIDAÇÃO FTP
        private bool ValidarFTP()
        {
            if (string.IsNullOrEmpty(usuarioFTP) || string.IsNullOrEmpty(senhaFTP) || string.IsNullOrEmpty(enderecoServidorFTP))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public frmCadServico()
        {
            InitializeComponent();
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStreen = new MemoryStream();
            byte[] pData = blob;
            mStreen.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStreen, false);
            mStreen.Dispose();
            return bm;
        }

        public byte[] GetImgByte(string ftpFilePath)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential(usuarioFTP, senhaFTP);
            byte[] imageByte = ftpClient.DownloadData(ftpFilePath);
            return imageByte;
        }

        private void InserirServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO servico(idServico,nomeServico,valorServico,statusServico,dataCadServico,fotoServico,fotoServico1,fotoServico2,fotoServico3,descServico,texto,tempoServico,idEmpresa) VALUES (DEFAULT,@nome,@valor,@status,@dataCad,@foto,@foto1,@foto2,@foto3,@desc,@texto,@tempo,@codigo)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@dataCad", dataCad);
            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@foto1", caminhoFoto1);
            cmd.Parameters.AddWithValue("@foto2", caminhoFoto2);
            cmd.Parameters.AddWithValue("@foto3", caminhoFoto3);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@texto", texto);
            cmd.Parameters.AddWithValue("@tempo", duracao);
            cmd.Parameters.AddWithValue("@codigo", codEmpresa);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!string.IsNullOrEmpty(txtFoto1.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto1.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto1.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!string.IsNullOrEmpty(txtFoto2.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto2.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto2.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!string.IsNullOrEmpty(txtFoto3.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto3.Text);

                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto3.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            MessageBox.Show("Serviço Cadastrado com Sucesso!", "CADASTRO DE SERVIÇO");
        }

        private void CarregarEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idEmpresa, nomeEmp FROM empresa";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbEmpresa.DataSource = dt;

            cmbEmpresa.DisplayMember = "nomeEmp";
            cmbEmpresa.ValueMember = "idEmpresa";
            cmbEmpresa.Text = string.Empty;

            banco.Desconectar();
        }

        private void CarregarEmpresaSelecionada()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idEmpresa, nomeEmp FROM empresa WHERE nomeEmp = @nomeEmpresa";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nomeEmpresa", empresa);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codEmpresa = reader.GetInt32(0);
            }
        }

        private void CarregarDadosServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idServico,nomeServico,valorServico,statusServico,dataCadServico,fotoServico,fotoServico1,fotoServico2,fotoServico3,descServico,texto,tempoServico,servico.idEmpresa,nomeEmp FROM servico INNER JOIN empresa ON servico.idEmpresa = empresa.idEmpresa WHERE idServico = @codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codServico = reader.GetInt32(0);
                nome = reader.GetString(1);
                valor = Convert.ToDouble(reader.GetString(2));
                status = reader.GetString(3);
                dataCad = DateTime.Parse(reader.GetString(4));
                foto = reader.GetString(5);
                foto = foto.Remove(0, 15);
               // MessageBox.Show(foto.ToString());
                foto1 = reader.GetString(6);
                foto1 = foto1.Remove(0, 15);
                //MessageBox.Show(foto1.ToString());
                foto2 = reader.GetString(7);
                foto2 = foto2.Remove(0, 15);
                //MessageBox.Show(foto2.ToString());
                foto3 = reader.GetString(8);
                foto3 = foto3.Remove(0, 15);
               // MessageBox.Show(foto3.ToString());
                desc = reader.GetString(9);
                texto = reader.GetString(10);
                duracao = DateTime.Parse(reader.GetString(11));
                codEmpresa = reader.GetInt32(12);
                empresa = reader.GetString(13);

               // MessageBox.Show(codEmpresa + empresa);

                banco.Desconectar();

                txtCodigo.Text = codServico.ToString();
                txtNomeServico.Text = nome;
                txtValor.Text = "R$ " + valor.ToString("N2");
                cmbStatus.Text = status;
                txtDataCadastro.Text = dataCad.ToShortDateString();
                pctFoto.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                pctFoto1.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto1));
                pctFoto2.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto2));
                pctFoto3.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto3));
                txtFoto.Text = enderecoServidorFTP + foto;
                txtFoto1.Text = enderecoServidorFTP + foto1;
                txtFoto2.Text = enderecoServidorFTP + foto2;
                txtFoto3.Text = enderecoServidorFTP + foto3;
                txtDescricao.Text = desc;
                txtTexto.Text = texto;
                cmbDuracaoServico.Text = duracao.ToShortDateString();
                cmbEmpresa.Text = empresa;
            }
        }

        private void AtualizarServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE servico SET nomeServico=@nome,valorServico=@valor,statusServico=@status,descServico=@desc,texto=@texto,tempoServico=@duracao,idEmpresa=@codEmpresa WHERE idServico = @codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@texto", texto);
            cmd.Parameters.AddWithValue("@duracao", duracao);
            cmd.Parameters.AddWithValue("@codEmpresa", codEmpresa);
            cmd.Parameters.AddWithValue("@codServico", codServico);

            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Serviço Atualizado com Sucesso!", "ATUALIZAÇÃO DE SERVIÇO");
        }

        private void AtualizarFotoServico()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE servico SET fotoServico=@foto WHERE idServico = @codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizarFotoServico1()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE servico SET fotoServico1=@foto1 WHERE idServico = @codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto1", caminhoFoto1);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto1.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto1.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto1.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizarFotoServico2()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE servico SET fotoServico2=@foto2 WHERE idServico = @codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto2", caminhoFoto2);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto2.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto2.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto2.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizarFotoServico3()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE servico SET fotoServico3=@foto3 WHERE idServico =@codServico";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto3", caminhoFoto3);
            cmd.Parameters.AddWithValue("@codServico", codServico);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtFoto3.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtFoto3.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtFoto3.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            txtNomeServico.Select();
            CarregarEmpresa();
            if (funcao == "ALTERAR")
            {
                CarregarDadosServico();
                txtNomeServico.Enabled = true;
                txtValor.Enabled = true;
                cmbStatus.Enabled = true;
                txtDataCadastro.Enabled = true;
                pctFoto.Enabled = true;
                pctFoto1.Enabled = true;
                pctFoto2.Enabled = true;
                pctFoto3.Enabled = true;
                txtDescricao.Enabled = true;
                txtTexto.Enabled = true;
                cmbDuracaoServico.Enabled = true;
                cmbEmpresa.Enabled = true;
                btnSalvar.Enabled = true;
            }
        }

        private void txtNomeServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nome = txtNomeServico.Text;
                txtValor.Enabled = true;
                if (funcao == "ADICIONAR")
                {
                    txtValor.Text = string.Empty;
                }
                else if(funcao == "ALTERAR")
                {
                    txtValor.Text = valor.ToString();
                }
                txtValor.Select();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                valor = Convert.ToDouble(txtValor.Text);
                txtValor.Text = "R$ " + valor.ToString("N2");
                cmbStatus.Enabled = true;
                cmbStatus.Select();
            }
        }

        private void txtDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dataCad = Convert.ToDateTime(txtDataCadastro.Text);
                txtDescricao.Enabled = true;
                txtDescricao.Select();
            }
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                desc = txtDescricao.Text;
                txtTexto.Enabled = true;
                txtTexto.Select();
            }
        }

        private void txtTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                texto = txtTexto.Text;
                cmbDuracaoServico.Enabled = true;
                cmbDuracaoServico.Select();
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            txtDataCadastro.Enabled = true;
            txtDataCadastro.Text = dataCad.ToString();
            txtDataCadastro.Select();
        }

        private void cmbDuracaoServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            duracao = Convert.ToDateTime(cmbDuracaoServico.Text);
            cmbEmpresa.Enabled = true;
            cmbEmpresa.Select();
        }

        private void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            empresa = cmbEmpresa.Text;
            CarregarEmpresaSelecionada();
            pctFoto.Enabled = true;
            pctFoto.Select();
            if (funcao == "ADICIONAR")
            {
                pctFoto.BackgroundImage = Properties.Resources.semimagem;
            }
        }

        private void pctFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();

            ofdFoto.Multiselect = false;
            ofdFoto.FileName = "";
            ofdFoto.InitialDirectory = @"C:\Dados\";
            ofdFoto.Title = "Selecione uma Foto";
            ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto.CheckFileExists = true;
            ofdFoto.CheckPathExists = true;
            ofdFoto.RestoreDirectory = true;

            DialogResult dr = ofdFoto.ShowDialog();

            pctFoto.BackgroundImage = Image.FromFile(ofdFoto.FileName);
            caminhoFoto = "upload/servico/" + System.IO.Path.GetFileName(ofdFoto.FileName); 

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto = "S";
                    txtFoto.Text = ofdFoto.FileName;
                }
                catch (SystemException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Admin \n\n Mensagem: " + ex.Message + "\n\n +  Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você não tem Permissão para ler o Arquivo. \n\n + Detalhe: " + ex.Message);
                }
            }
            if (funcao == "ADICIONAR")
            {
                pctFoto1.Enabled = true;
                pctFoto1.BackgroundImage = Properties.Resources.semimagem;
            }
        }

        private void pctFoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto1 = new OpenFileDialog();

            ofdFoto1.Multiselect = false;
            ofdFoto1.FileName = "";
            ofdFoto1.InitialDirectory = @"C:\Dados\";
            ofdFoto1.Title = "Selecione uma Foto";
            ofdFoto1.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto1.CheckFileExists = true;
            ofdFoto1.CheckPathExists = true;
            ofdFoto1.RestoreDirectory = true;

            DialogResult dr = ofdFoto1.ShowDialog();

            pctFoto1.BackgroundImage = Image.FromFile(ofdFoto1.FileName);
            caminhoFoto1 = "upload/servico/" + System.IO.Path.GetFileName(ofdFoto1.FileName);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto1 = "S";
                    txtFoto1.Text = ofdFoto1.FileName;
                }
                catch (SystemException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Admin \n\n Mensagem: " + ex.Message + "\n\n +  Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você não tem Permissão para ler o Arquivo. \n\n + Detalhe: " + ex.Message);
                }
            }
            if (funcao == "ADICIONAR")
            {
                pctFoto2.Enabled = true;
                pctFoto2.BackgroundImage = Properties.Resources.semimagem;
            }
        }

        private void pctFoto2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto2 = new OpenFileDialog();

            ofdFoto2.Multiselect = false;
            ofdFoto2.FileName = "";
            ofdFoto2.InitialDirectory = @"C:\Dados\";
            ofdFoto2.Title = "Selecione uma Foto";
            ofdFoto2.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto2.CheckFileExists = true;
            ofdFoto2.CheckPathExists = true;
            ofdFoto2.RestoreDirectory = true;

            DialogResult dr = ofdFoto2.ShowDialog();

            pctFoto2.BackgroundImage = Image.FromFile(ofdFoto2.FileName);
            caminhoFoto2 = "upload/servico/" + System.IO.Path.GetFileName(ofdFoto2.FileName);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto2 = "S";
                    txtFoto2.Text = ofdFoto2.FileName;
                }
                catch (SystemException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Admin \n\n Mensagem: " + ex.Message + "\n\n +  Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você não tem Permissão para ler o Arquivo. \n\n + Detalhe: " + ex.Message);
                }
            }
            if (funcao == "ADICIONAR")
            {
                pctFoto3.Enabled = true;
                pctFoto3.BackgroundImage = Properties.Resources.semimagem;
            }

        }

        private void pctFoto3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto3 = new OpenFileDialog();

            ofdFoto3.Multiselect = false;
            ofdFoto3.FileName = "";
            ofdFoto3.InitialDirectory = @"C:\Dados\";
            ofdFoto3.Title = "Selecione uma Foto";
            ofdFoto3.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto3.CheckFileExists = true;
            ofdFoto3.CheckPathExists = true;
            ofdFoto3.RestoreDirectory = true;

            DialogResult dr = ofdFoto3.ShowDialog();

            pctFoto3.BackgroundImage = Image.FromFile(ofdFoto3.FileName);
            caminhoFoto3 = "upload/servico/" + System.IO.Path.GetFileName(ofdFoto3.FileName);

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto3 = "S";
                    txtFoto3.Text = ofdFoto3.FileName;
                }
                catch (SystemException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Admin \n\n Mensagem: " + ex.Message + "\n\n +  Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Você não tem Permissão para ler o Arquivo. \n\n + Detalhe: " + ex.Message);
                }
            }
            if (funcao == "ADICIONAR")
            {
                btnSalvar.Enabled = true;
                btnSalvar.Focus();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR")
            {
                InserirServico();
                btnSalvar.Enabled = false;

                var msg = MessageBox.Show("Deseja Inserir outro Serviço?", "CADASTRAR NOVO SERVIÇO", MessageBoxButtons.YesNo);

                if (msg == DialogResult.Yes)
                {
                    txtValor.Enabled = false;
                    cmbStatus.Enabled = false;
                    txtDataCadastro.Enabled = false;
                    txtTexto.Enabled = false;
                    txtDescricao.Enabled = false;
                    cmbDuracaoServico.Enabled = false;
                    cmbEmpresa.Enabled = false;
                    pctFoto.Enabled = false;
                    pctFoto1.Enabled = false;
                    pctFoto2.Enabled = false;
                    pctFoto3.Enabled = false;

                    txtNomeServico.Text = string.Empty;
                    txtValor.Text = string.Empty;
                    cmbStatus.Text = string.Empty;
                    txtDataCadastro.Text = string.Empty;
                    txtDescricao.Text = string.Empty;
                    txtTexto.Text = string.Empty;
                    cmbDuracaoServico.Text = string.Empty;
                    cmbEmpresa.Text = string.Empty;
                    txtFoto.Text = string.Empty;
                    txtFoto1.Text = string.Empty;
                    txtFoto2.Text = string.Empty;
                    txtFoto3.Text = string.Empty;

                    pctFoto.BackgroundImage = null;
                    pctFoto1.BackgroundImage = null;
                    pctFoto2.BackgroundImage = null;
                    pctFoto3.BackgroundImage = null;

                    txtNomeServico.Select();
                }
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarServico();
                if(atFoto == "S")
                {
                    AtualizarFotoServico();
                }
                if(atFoto1 == "S")
                {
                    AtualizarFotoServico1();
                }
                if(atFoto2 == "S")
                {
                    AtualizarFotoServico2();
                }
                if (atFoto3 == "S")
                {
                    AtualizarFotoServico3();
                }
            }
            btnSalvar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {        
            frmServico servico = new frmServico();
            servico.Show();
            Close();
        }
    }
}

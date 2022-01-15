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
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopK
{
    public partial class frmCadBanner : Form
    {
        public string funcao;
        string nome, foto, atFoto;
        public int codigo;
        int status;

        // FOTOS FTP
        string enderecoServidorFTP = "ftp://127.0.0.1/admin/Upload/banner/";
        string usuarioFTP = "ti07";
        string senhaFTP = "123";
        string caminhoImagem;

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

        public frmCadBanner()
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

        private void InserirBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO banner(idBanner,nomeBanner,caminhoBanner,statusBanner) VALUES (DEFAULT, @nome, @caminho, @status)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@caminho", caminhoImagem);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtCaminhoImagem.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtCaminhoImagem.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtCaminhoImagem.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MessageBox.Show("Banner Cadastrado com Sucesso!", "Cadastro de Banner");
        }

        private void CarregarBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idBanner) FROM banner";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }

            //MessageBox.Show(codigo.ToString());
        }

        private void CarregarDadosBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM banner WHERE idBanner = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
            {
                codigo = reader.GetInt32(0);
                nome = reader.GetString(1);
                foto = reader.GetString(2);
                foto = foto.Remove(0, 14);
                //MessageBox.Show(foto.ToString());
                status = reader.GetInt32(3);

                banco.Desconectar();

                txtCodigo.Text = codigo.ToString();
                txtNomeBanner.Text = nome;
                pctBanner.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                txtCaminhoImagem.Text = enderecoServidorFTP + foto;

                if (status == 1)
                {
                    radAtivo.Checked = true;
                }
                else
                {
                    radInativo.Checked = true;
                }     
            }
        }

        private void AtualizarBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE banner SET caminhoBanner=@foto WHERE idBanner = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@foto", caminhoImagem);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            if (ValidarFTP())
            {
                if (!string.IsNullOrEmpty(txtCaminhoImagem.Text))
                {
                    string urlArquivoEnviar = enderecoServidorFTP + Path.GetFileName(txtCaminhoImagem.Text);
                    try
                    {
                        Ftp.EnviarArquivoFTP(txtCaminhoImagem.Text, urlArquivoEnviar, usuarioFTP, senhaFTP);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AtualizarStatusBanner()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE banner SET nomeBanner=@nome,statusBanner=@status WHERE idBanner = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Banner Atualizado com Sucesso!", "Atualização do Banner");
        }

        private void frmCadBanner_Load(object sender, EventArgs e)
        {
            txtNomeBanner.Select();
            if (funcao == "ALTERAR")
            {
                CarregarDadosBanner();
                txtNomeBanner.Enabled = true;
                pctBanner.Enabled = true;
                radAtivo.Enabled = true;
                radInativo.Enabled = true;
                btnSalvar.Enabled = true;
            }          
        }

        private void txtNomeBanner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                nome = txtNomeBanner.Text;
                pctBanner.Enabled = true;
                pctBanner.Select();
            }
        }

        private void pctBanner_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();
            ofdFoto.Multiselect = false;

            //ofdFoto.FileName = "";
            ofdFoto.InitialDirectory = @"C:\Users\Rg\Xampp\htdocs\ti07k\admin\upload\banner";
            ofdFoto.Title = "Selecione uma Foto";
            ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto.CheckFileExists = true;
            ofdFoto.CheckPathExists = true;
            ofdFoto.RestoreDirectory = true;

            DialogResult dr = ofdFoto.ShowDialog();

            pctBanner.BackgroundImage = Image.FromFile(ofdFoto.FileName);
            caminhoImagem = "upload/banner/" + System.IO.Path.GetFileName(ofdFoto.FileName); //banner/banner.png

            txtCaminhoImagem.Text = caminhoImagem;

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    atFoto = "S";
                    txtCaminhoImagem.Text = ofdFoto.FileName;
                    radAtivo.Enabled = true;
                    radInativo.Enabled = true;
                    lblStatus.Enabled = true;
                }
                catch (SecurityException ex)
                {
                    //Mensagem
                    MessageBox.Show("Erro de Segurança - Fale com o Administrador \n\n Mensagem:" + ex.Message + "\n\n + Detalhe: " + ex.StackTrace);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Voce não tem permissão para ler o arquivo. \n\n" + ex.Message);
                }
            }
        }

        private void radAtivo_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
            btnSalvar.Enabled = true;
        }

        private void radInativo_CheckedChanged(object sender, EventArgs e)
        {
            status = 0;
            btnSalvar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR")
            {
                InserirBanner();
                CarregarBanner();
                btnSalvar.Enabled = true;

                var msg = MessageBox.Show("Deseja Inserir outro Banner?", "BANNER", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    txtNomeBanner.Text = string.Empty;
                    txtCaminhoImagem.Text = string.Empty;
                    pctBanner.BackgroundImage = null;
                    pctBanner.Enabled = false;
                    txtNomeBanner.Select();
                }
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarStatusBanner();
                if (atFoto == "S")
                {
                    AtualizarBanner();
                }
            }
            btnSalvar.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmBanner banner = new frmBanner();
            banner.Show();
            Close();
        }
    }
}

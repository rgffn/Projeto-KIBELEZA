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
    public partial class frmCadCliente : Form
    {
        public string funcao;
        string nome, email, senha, status, foto, numero, tipo, desc, atFoto;
        DateTime dataCad = DateTime.Now;
        public int codigo;
        int codigoFone, linhaAtual;

        // FOTOS FTP
        string enderecoServidorFTP = "ftp://127.0.0.1/admin/Upload/cliente/";
        string usuarioFTP = "ti07";
        string senhaFTP = "123";
        string caminhoFoto; 

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

        public frmCadCliente()
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

        private void InserirCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO cliente (idCliente,nomeCli,emailCli,senhaCli,statusCli,dataCadCli,fotoCli) VALUES (DEFAULT,@nome,@email,@senha,@status,@dataCad,@foto)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@dataCad", dataCad);
            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
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
            }
            MessageBox.Show("Cliente Cadastrado com Sucesso!", "CADASTRO DE CLIENTE");
        }

        private void InserirFoneCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO fonecli(idFoneCli,numeroCliente,tipoFoneCli,descFoneCli,idCliente) VALUE (DEFAULT,@numero,@tipo,@descricao,@codigo)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@descricao", desc);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Cadastrado com Sucesso!", "TELEFONE CLIENTE");
        }

        private void CarregarCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idCliente) FROM cliente";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }
        }

        private void CarregarFoneCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFoneCli,numeroCliente,tipoFoneCli,descFoneCli FROM fonecli WHERE idCliente = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFoneCliente.DataSource = dt;

            dgvFoneCliente.Columns[0].HeaderText = "Cod.Fone";
            dgvFoneCliente.Columns[0].Visible = false;
            dgvFoneCliente.Columns[1].HeaderText = "Nº do Telefone";
            dgvFoneCliente.Columns[2].HeaderText = "Tipo";
            dgvFoneCliente.Columns[3].HeaderText = "Descrição";

            banco.Desconectar();
        }

        private void CarregarDadosCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM cliente WHERE idCliente = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                //MessageBox.Show(codigo.ToString());
                nome = reader.GetString(1);
                email = reader.GetString(2);
                senha = reader.GetString(3);
                status = reader.GetString(4);
                dataCad = DateTime.Parse(reader.GetString(5));
                foto = reader.GetString(6);
                foto = foto.Remove(0, 15);

                banco.Desconectar();

                txtCodigo.Text = codigo.ToString();
                txtNomeDoCliente.Text = nome;
                txtEmail.Text = email;
                txtSenha.Text = senha;
                cmbStatus.Text = status;
                txtDataCadastro.Text = Convert.ToString(dataCad);
                pctFoto.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                txtFoto.Text = enderecoServidorFTP + foto;
            }
        }

        private void ExcluirFoneCliente()
        {
                Banco banco = new Banco();
                banco.Conectar();

                string sql = "DELETE FROM fonecli WHERE idFoneCli=@codigo";
                MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
                cmd.Parameters.AddWithValue("@codigo", codigoFone);
                cmd.ExecuteNonQuery();

                banco.Desconectar();
        }

        private void AtualizarCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE cliente SET nomeCli=@nome,emailCli=@email,senhaCli=@senha,statusCli=@status WHERE idCliente = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Cliente Atualizado com Sucesso!", "ATUALIZAÇÃO CLIENTE");
        }

        private void AtualizarFoneCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE fonecli SET numeroCliente=@numero,tipoFoneCli=@tipo,descFoneCli=@desc WHERE idFoneCli = @codigoFone";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Atualizado com Sucesso!", "TELEFONE CLIENTE");
        }

        private void AtualizarFotoCliente()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE cliente SET fotoCli=@foto WHERE idCliente=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@codigo", codigo);
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
            }
        }

        private void CarregarDadosTelefone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM foneCli WHERE idFoneCli = @codigoFone";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigoFone = reader.GetInt32(0);
                numero = reader.GetString(1);
                tipo = reader.GetString(2);
                desc = reader.GetString(3);
            }

            banco.Desconectar();

            txtCodFone.Text = codigoFone.ToString();
            txtNumFone.Text = numero;
            cmbTipFone.Text = tipo;
            cmbDescFone.Text = desc;
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            txtNomeDoCliente.Select();
            if (funcao == "ALTERAR")
            {
                CarregarFoneCliente();
                CarregarDadosCliente();
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbStatus.Enabled = true;
                txtDataCadastro.Enabled = false;
                pctFoto.Enabled = true;
                btnSalvar.Enabled = true;
                TelefoneCliente.Enabled = true;
            }    
        }

        private void dgvFoneCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigoFone = Convert.ToInt32(dgvFoneCliente[0, linhaAtual].Value);
            }
        }

        private void dgvFoneCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFoneCliente.Sort(dgvFoneCliente.Columns[0], ListSortDirection.Ascending);
            dgvFoneCliente.ClearSelection();
        }

        private void txtNomeDoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                nome = txtNomeDoCliente.Text;
                txtEmail.Enabled = true;
                txtEmail.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                email = txtEmail.Text;
                txtSenha.Enabled = true;
                txtSenha.Select();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                senha = txtSenha.Text;
                cmbStatus.Enabled = true;
                cmbStatus.Select();
            }
        }

        private void txtDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                dataCad = Convert.ToDateTime(txtDataCadastro.Text);
                pctFoto.Enabled = true;
                //pctFoto.BackgroundImage = Properties.Resources.semimagem;
            }
        }

        private void txtNumFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab))
            {
                numero = txtNumFone.Text;
                cmbTipFone.Enabled = true;
                cmbTipFone.Select();
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
            caminhoFoto = "upload/cliente/" + System.IO.Path.GetFileName(ofdFoto.FileName); //cliente/usuario.png
            
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
            btnSalvar.Enabled = true;
            btnSalvar.Focus();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            txtDataCadastro.Enabled = true;
            txtDataCadastro.Text = dataCad.ToString();
            txtDataCadastro.Select();
        }

        private void cmbTipFone_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo = cmbTipFone.Text;
            cmbDescFone.Enabled = true;
            cmbDescFone.Select();
        }

        private void cmbDescFone_SelectedIndexChanged(object sender, EventArgs e)
        {
            desc = cmbDescFone.Text;
            btnSalvarFone.Enabled = true;
            btnSalvarFone.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR")
            {
                InserirCliente();
                CarregarCliente();
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarCliente();
                if (atFoto == "S")
                {
                    AtualizarFotoCliente();
                }
            }
            btnSalvar.Enabled = false;
            TelefoneCliente.Enabled = true;
        }

        private void btnSalvarFone_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR FONE")
            {
                InserirFoneCliente();
                txtNumFone.Text = string.Empty;
                cmbTipFone.Text = string.Empty;
                cmbDescFone.Text = string.Empty;
                txtNumFone.Enabled = true;
                cmbTipFone.Enabled = true;
                cmbDescFone.Enabled = true;

                txtNumFone.Select();
            }
            else if (funcao == "ALTERAR FONE")
            {
                AtualizarFoneCliente();
                btnFecharFone.PerformClick();
            }
            btnSalvarFone.Enabled = false;
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            funcao = "ADICIONAR FONE";
            CadFoneCliente.Visible = true;
            txtNumFone.Select();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {   
            funcao = "ALTERAR FONE";
            //codigoFone = Convert.ToInt32(dgvFoneCliente[0, linhaAtual].Value);
            CadFoneCliente.Visible = true;
            txtNumFone.Enabled = true;
            cmbTipFone.Enabled = true;
            cmbDescFone.Enabled = true;
            btnSalvarFone.Enabled = true;
            CarregarDadosTelefone();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFoneCliente.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Telefone? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR FONE CLIENTE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFoneCliente();
                }
                CarregarFoneCliente();
                CarregarCliente();
                dgvFoneCliente.ClearSelection();
                dgvFoneCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.Show();
            Close();
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            CadFoneCliente.Visible = false;
            CarregarFoneCliente();
        }
    }
}

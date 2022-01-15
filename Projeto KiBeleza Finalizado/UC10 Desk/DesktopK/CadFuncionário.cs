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
    public partial class frmCadFuncionário : Form
    {
        public string funcao;
        string nome, email, senha, nivel, status, empresa, numero, tipo, foto, desc, atFoto;
        DateTime dataCad = DateTime.Now;
        DateTime horario;
        public int codigoFuncionario;
        int codigoEmpresa, codigoFone, linhaAtual;

        // FOTOS FTP
        string enderecoServidorFTP = "ftp://127.0.0.1/admin/Upload/funcionario/";
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

        public frmCadFuncionário()
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

        private void InserirFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO funcionario (idFuncionario,nomeFunc,emailFunc,senhaFunc,nivelFunc,statusFunc,dataCadFunc,horarioTrabalhoFunc,fotoFunc,idEmpresa) VALUE (DEFAULT,@nome,@email,@senha,@nivel,@status,@dataCadastro,@horario,@foto,@codigoEmpresa)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@dataCadastro", dataCad);
            cmd.Parameters.AddWithValue("@horario", horario);
            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@codigoEmpresa", codigoEmpresa);
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

            MessageBox.Show("Funcionário Cadastrado com Sucesso!", "CADASTRO DE FUNCIONÁRIO");
        }

        private void InserirFoneFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO fonefunc (idFoneFunc,numeroFunc,tipoFoneFunc,descFoneFunc,idFuncionario) VALUES (DEFAULT,@numero,@tipo,@desc,@codigoFuncionario)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigoFuncionario", codigoFuncionario);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Cadastrado com Sucesso", "TELEFONE FUNCIONARIO");
        }

        private void CarregarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idFuncionario) FROM funcionario";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigoFuncionario = reader.GetInt32(0);
            }

            banco.Desconectar();
        }

        private void CarregarDadosFoneFunc()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM fonefunc WHERE idFoneFunc = @codigoFone";
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

        private void CarregarDadosFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM funcionario WHERE idFuncionario = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigoFuncionario);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigoFuncionario = reader.GetInt32(0);
                nome = reader.GetString(1);
                email = reader.GetString(2);
                senha = reader.GetString(3);
                nivel = reader.GetString(4);
                status = reader.GetString(5);
                dataCad = DateTime.Parse(reader.GetString(6));
                horario = DateTime.Parse(reader.GetString(7));
                foto = reader.GetString(8);
                //MessageBox.Show(foto.ToString());
                foto = foto.Remove(0, 19);
                empresa = (reader.GetString(9));



                banco.Desconectar();

                txtCodigo.Text = codigoFuncionario.ToString();
                txtNomeFuncionario.Text = nome;
                txtEmail.Text = email;
                txtSenha.Text = senha;
                cmbNivel.Text = nivel;
                cmbStatus.Text = status;
                txtDataCadastro.Text = Convert.ToString(dataCad);
                cmbHorarioTrabalho.Text = Convert.ToString(horario);
                cmbEmpresa.Text = empresa;
                pctFoto.BackgroundImage = ByteToImage(GetImgByte(enderecoServidorFTP + foto));
                txtFoto.Text = enderecoServidorFTP + foto;
            }
        }

        private void CarregarFoneFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFoneFunc,numeroFunc,tipoFoneFunc,descFoneFunc FROM fonefunc WHERE idFuncionario = @codigoFuncionario";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigoFuncionario", codigoFuncionario);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFoneFuncionario.DataSource = dt;
            dgvFoneFuncionario.Columns[0].HeaderText = "Codigo Fone";
            dgvFoneFuncionario.Columns[0].Visible = false;
            dgvFoneFuncionario.Columns[1].HeaderText = "Nº de Telefone";
            dgvFoneFuncionario.Columns[2].HeaderText = "Tipo";
            dgvFoneFuncionario.Columns[3].HeaderText = "Descrição";

            banco.Desconectar();
        }

        private void ExcluirFoneFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "DELETE FROM fonefunc WHERE idFoneFunc=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }

        private void AtualizarFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE funcionario SET nomeFunc=@nome,emailFunc=@email,senhaFunc=@senha,nivelFunc=@nivel,statusFunc=@status,dataCadFunc=@dataCad,horarioTrabalhoFunc=@horario WHERE idFuncionario = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nivel", nivel);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@dataCad", dataCad);
            cmd.Parameters.AddWithValue("@horario", horario);
            //cmd.Parameters.AddWithValue("@codigoEmpresa", codigoEmpresa);
            cmd.Parameters.AddWithValue("@codigo", codigoFuncionario);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Funcionario atualizado com sucesso!", "ATUALIZAÇÃO DE FUNCIONARIO");
        }

        private void AtualizarFotoFuncionario()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE funcionario SET fotoFunc=@foto WHERE idFuncionario=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);

            cmd.Parameters.AddWithValue("@foto", caminhoFoto);
            cmd.Parameters.AddWithValue("@codigo", codigoFuncionario);
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

        private void AtualizarFone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE fonefunc SET numeroFunc = @numero, tipoFoneFunc = @tipo, descFoneFunc = @desc WHERE idFoneFunc = @codigoFone";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Atualizado com SUCESSO!", "Atualização");
        }

        private void CarregarEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idEmpresa,nomeEmp FROM empresa";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbEmpresa.DataSource = dt;

            cmbEmpresa.DisplayMember = "nomeEmp";
            cmbEmpresa.ValueMember = "idEmpresa";
            if (funcao == "ADICIONAR")
            {
                cmbEmpresa.Text = string.Empty;
            }
            banco.Desconectar();
        }

        private void CarregarEmpresaSelecionada()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idEmpresa,nomeEmp FROM empresa WHERE nomeEmp = @nomeEmpresa";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nomeEmpresa", empresa);
            MySqlDataReader reader = cmd.ExecuteReader();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            if (reader.Read())
            {
                codigoEmpresa = reader.GetInt32(0);
            }

            banco.Desconectar();
        }

        private void frmCadFuncionário_Load(object sender, EventArgs e)
        {
            if (funcao == "ALTERAR")
            {
                CarregarEmpresa();
                CarregarDadosFuncionario();
                TelefoneFuncionario.Enabled = true;
                CarregarFoneFuncionario();
                txtNomeFuncionario.Enabled = true;
                txtEmail.Enabled = true;
                txtSenha.Enabled = true;
                cmbNivel.Enabled = true;
                cmbStatus.Enabled = true;
                txtDataCadastro.Enabled = true;
                cmbHorarioTrabalho.Enabled = true;
                cmbEmpresa.Enabled = false;
                btnSalvar.Enabled = true;
                pctFoto.Enabled = true;
            }
           if (funcao == "ADICIONAR")
            {
                txtNomeFuncionario.Select();
                CarregarEmpresa();
                txtDataCadastro.Text = dataCad.ToString();
            }
        }

        private void dgvFoneFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigoFone = Convert.ToInt32(dgvFoneFuncionario[0, linhaAtual].Value);
            }         
        }

        private void dgvFoneFuncionario_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvFoneFuncionario.Sort(dgvFoneFuncionario.Columns[0], ListSortDirection.Ascending);
            dgvFoneFuncionario.ClearSelection();
        }

        private void txtNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nome = txtNomeFuncionario.Text;
                txtEmail.Enabled = true;
                txtEmail.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                email = txtEmail.Text;
                txtSenha.Enabled = true;
                txtSenha.Select();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                senha = txtSenha.Text;
                cmbNivel.Enabled = true;
                cmbNivel.Select();
            }
        }

        private void txtDataCadastro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dataCad = Convert.ToDateTime(txtDataCadastro.Text);
                cmbHorarioTrabalho.Enabled = true;
                cmbHorarioTrabalho.Select();
            }
        }

        private void txtNumFone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                numero = txtNumFone.Text;
                cmbTipFone.Enabled = true;
                cmbTipFone.Select();
            }
        }

        private void cmbNivel_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            nivel = cmbNivel.Text;
            cmbStatus.Enabled = true;
            cmbStatus.Select();
        }

        private void cmbStatus_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            txtDataCadastro.Enabled = true;
            txtDataCadastro.Text = dataCad.ToString();
            txtDataCadastro.Select();
        }

        private void cmbHorarioTrabalho_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            horario = Convert.ToDateTime(cmbHorarioTrabalho.Text);
            cmbEmpresa.Enabled = true;
            cmbEmpresa.Select();
            CarregarEmpresa();
        }

        private void cmbEmpresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEmpresa.Enabled == true)
            {
                empresa = cmbEmpresa.Text;
                CarregarEmpresaSelecionada();
                pctFoto.Enabled = true;
            }
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

        private void pctFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdFoto = new OpenFileDialog();

            ofdFoto.Multiselect = false;
            ofdFoto.FileName = "";
            ofdFoto.InitialDirectory = @"C:\xampp\htdocs\ti07k\ti07k\admin\Upload\funcionario";
            ofdFoto.Title = "Selecione uma Foto";
            ofdFoto.Filter = "JPG ou PNG (*.jpg ou *.png)|*.jpg; *.png";
            ofdFoto.CheckFileExists = true;
            ofdFoto.CheckPathExists = true;
            ofdFoto.RestoreDirectory = true;

            DialogResult dr = ofdFoto.ShowDialog();

            pctFoto.BackgroundImage = Image.FromFile(ofdFoto.FileName);
            caminhoFoto = "upload/funcionario/" + System.IO.Path.GetFileName(ofdFoto.FileName);

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

        private void btnFechar_Click(object sender, EventArgs e)
        {   
            frmFuncionario funcionario = new frmFuncionario();
            funcionario.Show();
            Close();
        }

        private void btnFecharFone_Click_1(object sender, EventArgs e)
        {
            CadFoneFuncionario.Visible = false;
            CarregarFoneFuncionario();
        }

        private void btnAdicionarTelefone_Click_1(object sender, EventArgs e)
        {
            funcao = "ADICIONAR FONE";
            CadFoneFuncionario.Visible = true;
            txtNumFone.Select();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            funcao = "ALTERAR FONE";
            CarregarDadosFoneFunc();
            CadFoneFuncionario.Visible = true;
            txtNumFone.Select();
            cmbTipFone.Enabled = true;
            cmbDescFone.Enabled = true;
            btnSalvarFone.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR")
            {
                InserirFuncionario();
                CarregarFuncionario();
            }
            else if (funcao == "ALTERAR")
            {
                CarregarEmpresaSelecionada();
                AtualizarFuncionario();
                CarregarFuncionario();
                if (atFoto == "S")
                {
                    AtualizarFotoFuncionario();
                }
            }

            TelefoneFuncionario.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void btnSalvarFone_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR FONE")
            {
                InserirFoneFuncionario();
                txtNumFone.Text = string.Empty;
                cmbTipFone.Text = string.Empty;
                cmbDescFone.Text = string.Empty;
                cmbTipFone.Enabled = false;
                cmbDescFone.Enabled = false;
                btnSalvarFone.Enabled = false;
                CarregarFoneFuncionario();

                txtNumFone.Select();
            }
            else if(funcao == "ALTERAR FONE")
            {
                numero = txtNumFone.Text;
                tipo = cmbTipFone.Text;
                desc = cmbDescFone.Text;
                AtualizarFone();
                CarregarFoneFuncionario();
                btnSalvarFone.Enabled = false;
                CarregarFoneFuncionario();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFoneFuncionario.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente excluir esse Telefone? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR FONE FUNCIONÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFoneFuncionario();
                }
                CarregarFoneFuncionario();
                dgvFoneFuncionario.ClearSelection();
                dgvFoneFuncionario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}
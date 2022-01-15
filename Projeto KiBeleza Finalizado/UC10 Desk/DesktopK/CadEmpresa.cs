using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopK
{
    public partial class frmCadEmpresa : Form
    {
        public string funcao;
        string nome, cnpjcpf, razaoSocial, email, status, convHora, numero, tipo, desc;
        DateTime dataCad = DateTime.Now;
        DateTime horario;
        public int codigo,codigoFone;
        int linhaAtual;

        public frmCadEmpresa()
        {
            InitializeComponent();
        }

        private void InserirEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO empresa(idEmpresa,nomeEmp,cnpjCpfEmp,razaoSocialEmp,emailEmp,statusEmp,dataCadEmp,horarioAtendEmp) VALUES (DEFAULT,@nome,@cnpjCpf,@razaoSocial,@email,@status,@dataCad,@horario)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cnpjCpf", cnpjcpf);
            cmd.Parameters.AddWithValue("@razaoSocial", razaoSocial);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@dataCad", dataCad);
            cmd.Parameters.AddWithValue("@horario", horario);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Empresa Cadastrada com Sucesso!", "CADASTRO DE EMPRESA");
        }

        private void InserirFoneEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "INSERT INTO foneemp(idFoneEmp,numeroEmp,tipoFoneEmp,descFoneEmp,idEmpresa) VALUES (DEFAULT,@numero,@tipo,@desc,@codigo)";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Cadastrado com Sucesso!", "CADASTRO DE TELEFONE");
        }

        private void CarregarEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT MAX(idEmpresa) FROM empresa";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
            }

            banco.Desconectar();
        }

        private void CarregarFoneEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT idFoneEmp,numeroEmp,tipoFoneEmp,descFoneEmp FROM foneemp WHERE idEmpresa = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvFoneEmpresa.DataSource = dt;

            dgvFoneEmpresa.Columns[0].HeaderText = "Cod.Fone";
            dgvFoneEmpresa.Columns[0].Visible = false; 
            dgvFoneEmpresa.Columns[1].HeaderText = "Nº do Telefone";
            dgvFoneEmpresa.Columns[2].HeaderText = "Tipo";
            dgvFoneEmpresa.Columns[3].HeaderText = "Descrição";

            banco.Desconectar();
        }

        private void CarregarDadosEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM empresa WHERE idEmpresa = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                codigo = reader.GetInt32(0);
                nome = reader.GetString(1);
                cnpjcpf = reader.GetString(2);
                razaoSocial = reader.GetString(3);
                email = reader.GetString(4);
                status = reader.GetString(5);
                dataCad = DateTime.Parse(reader.GetString(6));
                horario = DateTime.Parse(reader.GetString(7));
            }

            banco.Desconectar();

            txtCodigo.Text = codigo.ToString();
            txtNomeEmpresa.Text = nome;
            txtCnpjCpf.Text = cnpjcpf;
            txtRazaoSocial.Text = razaoSocial;
            txtEmail.Text = email;
            cmbStatus.Text = status;
            txtDataCadastro.Text = Convert.ToString(dataCad);
            cmbHorarioAtendimento.Text = horario.ToShortTimeString();
        }

        private void CarregarDadosTelefone()
        {
            Banco banco = new Banco();
            banco.Conectar();

            var sql = "SELECT * FROM foneEmp WHERE idFoneEmp = @codigoFone";
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

        private void ExcluirFoneEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "DELETE FROM foneemp WHERE idFoneEmp=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@codigo", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();
        }

        private void AtualizarEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE empresa SET nomeEmp=@nome,cnpjCpfEmp=@cnpjCpf,razaoSocialEmp=@razaoSocial,emailEmp=@email,statusEmp=@status,horarioAtendEmp=@horario WHERE idEmpresa = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@cnpjCpf", cnpjcpf);
            cmd.Parameters.AddWithValue("@razaoSocial", razaoSocial);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@horario", horario);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Empresa Atualizada com Sucesso!", "ATUALIZAÇÃO DE EMPRESA");
        }

        private void AtualizarFoneEmpresa()
        {
            Banco banco = new Banco();
            banco.Conectar();

            string sql = "UPDATE foneemp SET numeroEmp=@numero,tipoFoneEmp=@tipo,descFoneEmp=@desc WHERE idFoneEmp = @codigoFone";
            MySqlCommand cmd = new MySqlCommand(sql, banco.conexao);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@tipo", tipo);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@codigoFone", codigoFone);
            cmd.ExecuteNonQuery();

            banco.Desconectar();

            MessageBox.Show("Telefone Atualizado com Sucesso!", "ATUALIZAÇÃO DE TELEFONE");
        }

        private void frmCadEmpresa_Load(object sender, EventArgs e)
        {
            txtNomeEmpresa.Select();

            if(funcao == "ALTERAR")
            {
                CarregarDadosEmpresa();
                CarregarFoneEmpresa();

                txtNomeEmpresa.Enabled = true;
                txtCnpjCpf.Enabled = true;
                txtRazaoSocial.Enabled = true;
                txtEmail.Enabled = true;
                cmbStatus.Enabled = true;
                cmbHorarioAtendimento.Enabled = true;
                TelefoneEmpresa.Enabled = true;
                btnSalvar.Enabled = true;
                radCNPJ.Enabled = true;
                radCPF.Enabled = true;
            }
        }

        private void dgvFoneEmpresa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linhaAtual = int.Parse(e.RowIndex.ToString());
            if (linhaAtual >= 0)
            {
                codigoFone = Convert.ToInt32(dgvFoneEmpresa[0, linhaAtual].Value);
            }
        }

        private void txtNomeEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                nome = txtNomeEmpresa.Text;
                
                if (funcao == "ADICIONAR")
                {
                    radCNPJ.Enabled = true;
                    radCPF.Enabled = true;
                    radCNPJ.Checked = true;
                    txtCnpjCpf.Select();
                }
                //txtCnpjCpf.Enabled = true;
                txtCnpjCpf.Select();
            }
        }

        private void txtCnpjCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                cnpjcpf = txtCnpjCpf.Text;
                txtRazaoSocial.Enabled = true;
                txtRazaoSocial.Select();
            }
        }

        private void txtRazaoSocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                razaoSocial = txtRazaoSocial.Text;
                txtEmail.Enabled = true;
                txtEmail.Select();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                email = txtEmail.Text;
                cmbStatus.Enabled = true;
                cmbStatus.Select();
            }
        }

        private void txtDataCadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dataCad = Convert.ToDateTime(txtDataCadastro.Text);
                cmbHorarioAtendimento.Enabled = true;
                cmbHorarioAtendimento.Select();
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

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = cmbStatus.Text;
            if (funcao == "ADICIONAR")
            {
                txtDataCadastro.Enabled = true;
            }
            txtDataCadastro.Text = dataCad.ToString();
            txtDataCadastro.Select();
        }

        private void cmbHorarioAtendimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            horario = Convert.ToDateTime(cmbHorarioAtendimento.Text);
            btnSalvar.Enabled = true;
            btnSalvar.Focus();
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

        private void radCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpjCpf.Mask = "00,000,000/0000-00";
            txtCnpjCpf.Text = string.Empty;
            txtCnpjCpf.Enabled = true;
            txtCnpjCpf.Select();
        }

        private void radCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtCnpjCpf.Mask = "000.000.000-00";
            txtCnpjCpf.Text = string.Empty;
            txtCnpjCpf.Enabled = true;
            txtCnpjCpf.Select();
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {
            funcao = "ADICIONAR FONE";
            CadFoneEmpresa.Visible = true;
            txtNumFone.Select();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            funcao = "ALTERAR FONE";
            codigoFone = Convert.ToInt32(dgvFoneEmpresa[0, linhaAtual].Value);
            CadFoneEmpresa.Visible = true;
            txtNumFone.Select();
            cmbTipFone.Enabled = true;
            cmbDescFone.Enabled = true;
            btnSalvarFone.Enabled = true;

            CarregarDadosTelefone();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR")
            {
                InserirEmpresa();
                CarregarEmpresa();
                TelefoneEmpresa.Enabled = true;
            }
            else if (funcao == "ALTERAR")
            {
                AtualizarEmpresa();
            }
            btnSalvar.Enabled = false;
        }

        private void btnSalvarFone_Click(object sender, EventArgs e)
        {
            if (funcao == "ADICIONAR FONE")
            {
                InserirFoneEmpresa();
                txtNumFone.Text = string.Empty;
                cmbTipFone.Text = string.Empty;
                cmbDescFone.Text = string.Empty;
                cmbTipFone.Enabled = false;
                cmbDescFone.Enabled = false;
                btnSalvarFone.Enabled = false;
                txtNumFone.Select();
            }
            else if (funcao == "ALTERAR FONE")
            {
                AtualizarFoneEmpresa();
                CarregarFoneEmpresa();
                CadFoneEmpresa.Visible = false;
                btnFechar.Focus();
            }
        }

        private void btnFecharFone_Click(object sender, EventArgs e)
        {
            CadFoneEmpresa.Visible = false;
            CarregarFoneEmpresa();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            frmEmpresa empresa = new frmEmpresa();
            empresa.Show();
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFoneEmpresa.SelectedRows.Count > 0)
            {
                var resultado = MessageBox.Show("Deseja realmente Excluir esse Telefone? \n\n Essa ação não poderá ser desfeita...", "EXCLUIR FONE EMPRESA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ExcluirFoneEmpresa();
                }
                CarregarFoneEmpresa();
                dgvFoneEmpresa.ClearSelection();
                dgvFoneEmpresa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }
    }
}

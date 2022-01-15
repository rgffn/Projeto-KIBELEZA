
namespace DesktopK
{
    partial class frmCadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAdicionarClientes = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNomeDoCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.TelefoneCliente = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.dgvFoneCliente = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.CadFoneCliente = new System.Windows.Forms.Panel();
            this.btnFecharFone = new System.Windows.Forms.Button();
            this.btnSalvarFone = new System.Windows.Forms.Button();
            this.cmbDescFone = new System.Windows.Forms.ComboBox();
            this.cmbTipFone = new System.Windows.Forms.ComboBox();
            this.lblDescFone = new System.Windows.Forms.Label();
            this.lblNumFone = new System.Windows.Forms.Label();
            this.lblTipFone = new System.Windows.Forms.Label();
            this.txtNumFone = new System.Windows.Forms.MaskedTextBox();
            this.txtCodFone = new System.Windows.Forms.TextBox();
            this.lblCodFone = new System.Windows.Forms.Label();
            this.lblAdicionarFoneCliente = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.TelefoneCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).BeginInit();
            this.CadFoneCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdicionarClientes
            // 
            this.lblAdicionarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarClientes.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarClientes.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarClientes.Location = new System.Drawing.Point(149, 0);
            this.lblAdicionarClientes.Name = "lblAdicionarClientes";
            this.lblAdicionarClientes.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarClientes.TabIndex = 0;
            this.lblAdicionarClientes.Text = "ADICIONAR CLIENTES";
            this.lblAdicionarClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(602, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 18;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(761, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 17;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(161, 59);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 16);
            this.lblCodigo.TabIndex = 19;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(164, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 20;
            // 
            // txtNomeDoCliente
            // 
            this.txtNomeDoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeDoCliente.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeDoCliente.Location = new System.Drawing.Point(305, 75);
            this.txtNomeDoCliente.Name = "txtNomeDoCliente";
            this.txtNomeDoCliente.Size = new System.Drawing.Size(564, 24);
            this.txtNomeDoCliente.TabIndex = 22;
            this.txtNomeDoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeDoCliente_KeyPress);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeCliente.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeCliente.Location = new System.Drawing.Point(302, 59);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(133, 16);
            this.lblNomeCliente.TabIndex = 21;
            this.lblNomeCliente.Text = "NOME DO CLIENTE:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmail.Location = new System.Drawing.Point(164, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(417, 24);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(161, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 16);
            this.lblEmail.TabIndex = 23;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtSenha.Location = new System.Drawing.Point(602, 135);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(267, 24);
            this.txtSenha.TabIndex = 26;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSenha.Location = new System.Drawing.Point(599, 116);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 16);
            this.lblSenha.TabIndex = 25;
            this.lblSenha.Text = "SENHA:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCadastro.Location = new System.Drawing.Point(363, 183);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(142, 16);
            this.lblDataCadastro.TabIndex = 27;
            this.lblDataCadastro.Text = "DATA DE CADASTRO:";
            // 
            // txtFoto
            // 
            this.txtFoto.Enabled = false;
            this.txtFoto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto.Location = new System.Drawing.Point(687, 241);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(110, 24);
            this.txtFoto.TabIndex = 30;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFoto.Location = new System.Drawing.Point(714, 183);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(47, 16);
            this.lblFoto.TabIndex = 29;
            this.lblFoto.Text = "FOTO:";
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(366, 202);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(139, 24);
            this.txtDataCadastro.TabIndex = 31;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            this.txtDataCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataCadastro_KeyPress);
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImage = global::DesktopK.Properties.Resources.semimagem;
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto.Enabled = false;
            this.pctFoto.Location = new System.Drawing.Point(666, 211);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(147, 164);
            this.pctFoto.TabIndex = 32;
            this.pctFoto.TabStop = false;
            this.pctFoto.Click += new System.EventHandler(this.pctFoto_Click);
            // 
            // TelefoneCliente
            // 
            this.TelefoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.TelefoneCliente.BackgroundImage = global::DesktopK.Properties.Resources.fonecliente;
            this.TelefoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelefoneCliente.Controls.Add(this.btnExcluir);
            this.TelefoneCliente.Controls.Add(this.btnAlterar);
            this.TelefoneCliente.Controls.Add(this.btnAdicionarTelefone);
            this.TelefoneCliente.Controls.Add(this.dgvFoneCliente);
            this.TelefoneCliente.Enabled = false;
            this.TelefoneCliente.Location = new System.Drawing.Point(164, 241);
            this.TelefoneCliente.Name = "TelefoneCliente";
            this.TelefoneCliente.Size = new System.Drawing.Size(415, 197);
            this.TelefoneCliente.TabIndex = 33;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(303, 168);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(108, 24);
            this.btnExcluir.TabIndex = 36;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(188, 168);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(108, 24);
            this.btnAlterar.TabIndex = 35;
            this.btnAlterar.Text = "ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAdicionarTelefone
            // 
            this.btnAdicionarTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnAdicionarTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarTelefone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarTelefone.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarTelefone.Location = new System.Drawing.Point(72, 168);
            this.btnAdicionarTelefone.Name = "btnAdicionarTelefone";
            this.btnAdicionarTelefone.Size = new System.Drawing.Size(108, 24);
            this.btnAdicionarTelefone.TabIndex = 34;
            this.btnAdicionarTelefone.Text = "ADICIONAR";
            this.btnAdicionarTelefone.UseVisualStyleBackColor = false;
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click);
            // 
            // dgvFoneCliente
            // 
            this.dgvFoneCliente.AllowUserToAddRows = false;
            this.dgvFoneCliente.AllowUserToDeleteRows = false;
            this.dgvFoneCliente.AllowUserToResizeColumns = false;
            this.dgvFoneCliente.AllowUserToResizeRows = false;
            this.dgvFoneCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoneCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFoneCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoneCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFoneCliente.ColumnHeadersHeight = 40;
            this.dgvFoneCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoneCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFoneCliente.EnableHeadersVisualStyles = false;
            this.dgvFoneCliente.Location = new System.Drawing.Point(72, 4);
            this.dgvFoneCliente.MultiSelect = false;
            this.dgvFoneCliente.Name = "dgvFoneCliente";
            this.dgvFoneCliente.ReadOnly = true;
            this.dgvFoneCliente.RowHeadersVisible = false;
            this.dgvFoneCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoneCliente.Size = new System.Drawing.Size(339, 158);
            this.dgvFoneCliente.TabIndex = 0;
            this.dgvFoneCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoneCliente_CellClick);
            this.dgvFoneCliente.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoneCliente_ColumnHeaderMouseClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "AGUARDANDO"});
            this.cmbStatus.Location = new System.Drawing.Point(164, 202);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(151, 21);
            this.cmbStatus.TabIndex = 34;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(161, 183);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 16);
            this.lblStatus.TabIndex = 35;
            this.lblStatus.Text = "STATUS:";
            // 
            // CadFoneCliente
            // 
            this.CadFoneCliente.BackgroundImage = global::DesktopK.Properties.Resources.fonecliente;
            this.CadFoneCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadFoneCliente.Controls.Add(this.btnFecharFone);
            this.CadFoneCliente.Controls.Add(this.btnSalvarFone);
            this.CadFoneCliente.Controls.Add(this.cmbDescFone);
            this.CadFoneCliente.Controls.Add(this.cmbTipFone);
            this.CadFoneCliente.Controls.Add(this.lblDescFone);
            this.CadFoneCliente.Controls.Add(this.lblNumFone);
            this.CadFoneCliente.Controls.Add(this.lblTipFone);
            this.CadFoneCliente.Controls.Add(this.txtNumFone);
            this.CadFoneCliente.Controls.Add(this.txtCodFone);
            this.CadFoneCliente.Controls.Add(this.lblCodFone);
            this.CadFoneCliente.Controls.Add(this.lblAdicionarFoneCliente);
            this.CadFoneCliente.Location = new System.Drawing.Point(157, 59);
            this.CadFoneCliente.Name = "CadFoneCliente";
            this.CadFoneCliente.Size = new System.Drawing.Size(713, 379);
            this.CadFoneCliente.TabIndex = 36;
            this.CadFoneCliente.Visible = false;
            // 
            // btnFecharFone
            // 
            this.btnFecharFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnFecharFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharFone.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharFone.ForeColor = System.Drawing.Color.White;
            this.btnFecharFone.Location = new System.Drawing.Point(424, 324);
            this.btnFecharFone.Name = "btnFecharFone";
            this.btnFecharFone.Size = new System.Drawing.Size(108, 36);
            this.btnFecharFone.TabIndex = 47;
            this.btnFecharFone.Text = "FECHAR";
            this.btnFecharFone.UseVisualStyleBackColor = false;
            this.btnFecharFone.Click += new System.EventHandler(this.btnFecharFone_Click);
            // 
            // btnSalvarFone
            // 
            this.btnSalvarFone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvarFone.Enabled = false;
            this.btnSalvarFone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarFone.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFone.ForeColor = System.Drawing.Color.White;
            this.btnSalvarFone.Location = new System.Drawing.Point(310, 324);
            this.btnSalvarFone.Name = "btnSalvarFone";
            this.btnSalvarFone.Size = new System.Drawing.Size(108, 36);
            this.btnSalvarFone.TabIndex = 46;
            this.btnSalvarFone.Text = "SALVAR";
            this.btnSalvarFone.UseVisualStyleBackColor = false;
            this.btnSalvarFone.Click += new System.EventHandler(this.btnSalvarFone_Click);
            // 
            // cmbDescFone
            // 
            this.cmbDescFone.Enabled = false;
            this.cmbDescFone.FormattingEnabled = true;
            this.cmbDescFone.Items.AddRange(new object[] {
            "CLARO",
            "TIM",
            "VIVO",
            "OI",
            "NEXTEL",
            "OUTROS"});
            this.cmbDescFone.Location = new System.Drawing.Point(345, 274);
            this.cmbDescFone.Name = "cmbDescFone";
            this.cmbDescFone.Size = new System.Drawing.Size(155, 21);
            this.cmbDescFone.TabIndex = 40;
            this.cmbDescFone.SelectedIndexChanged += new System.EventHandler(this.cmbDescFone_SelectedIndexChanged);
            // 
            // cmbTipFone
            // 
            this.cmbTipFone.Enabled = false;
            this.cmbTipFone.FormattingEnabled = true;
            this.cmbTipFone.Items.AddRange(new object[] {
            "FIXO",
            "CELULAR",
            "RECADO"});
            this.cmbTipFone.Location = new System.Drawing.Point(345, 210);
            this.cmbTipFone.Name = "cmbTipFone";
            this.cmbTipFone.Size = new System.Drawing.Size(155, 21);
            this.cmbTipFone.TabIndex = 45;
            this.cmbTipFone.SelectedIndexChanged += new System.EventHandler(this.cmbTipFone_SelectedIndexChanged);
            // 
            // lblDescFone
            // 
            this.lblDescFone.AutoSize = true;
            this.lblDescFone.BackColor = System.Drawing.Color.Transparent;
            this.lblDescFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDescFone.Location = new System.Drawing.Point(342, 255);
            this.lblDescFone.Name = "lblDescFone";
            this.lblDescFone.Size = new System.Drawing.Size(158, 16);
            this.lblDescFone.TabIndex = 44;
            this.lblDescFone.Text = "DESCRIÇÃO TELEFONE:";
            // 
            // lblNumFone
            // 
            this.lblNumFone.AutoSize = true;
            this.lblNumFone.BackColor = System.Drawing.Color.Transparent;
            this.lblNumFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNumFone.Location = new System.Drawing.Point(342, 127);
            this.lblNumFone.Name = "lblNumFone";
            this.lblNumFone.Size = new System.Drawing.Size(138, 16);
            this.lblNumFone.TabIndex = 43;
            this.lblNumFone.Text = "NÚMERO TELEFONE:";
            // 
            // lblTipFone
            // 
            this.lblTipFone.AutoSize = true;
            this.lblTipFone.BackColor = System.Drawing.Color.Transparent;
            this.lblTipFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblTipFone.Location = new System.Drawing.Point(342, 191);
            this.lblTipFone.Name = "lblTipFone";
            this.lblTipFone.Size = new System.Drawing.Size(114, 16);
            this.lblTipFone.TabIndex = 42;
            this.lblTipFone.Text = "TIPO TELEFONE:";
            // 
            // txtNumFone
            // 
            this.txtNumFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNumFone.Location = new System.Drawing.Point(345, 146);
            this.txtNumFone.Mask = "(99) 99000-0000";
            this.txtNumFone.Name = "txtNumFone";
            this.txtNumFone.Size = new System.Drawing.Size(155, 24);
            this.txtNumFone.TabIndex = 41;
            this.txtNumFone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumFone_KeyPress);
            // 
            // txtCodFone
            // 
            this.txtCodFone.Enabled = false;
            this.txtCodFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodFone.Location = new System.Drawing.Point(345, 79);
            this.txtCodFone.Name = "txtCodFone";
            this.txtCodFone.Size = new System.Drawing.Size(155, 24);
            this.txtCodFone.TabIndex = 39;
            // 
            // lblCodFone
            // 
            this.lblCodFone.AutoSize = true;
            this.lblCodFone.BackColor = System.Drawing.Color.Transparent;
            this.lblCodFone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodFone.Location = new System.Drawing.Point(342, 60);
            this.lblCodFone.Name = "lblCodFone";
            this.lblCodFone.Size = new System.Drawing.Size(135, 16);
            this.lblCodFone.TabIndex = 38;
            this.lblCodFone.Text = "CÓDIGO TELEFONE:";
            // 
            // lblAdicionarFoneCliente
            // 
            this.lblAdicionarFoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarFoneCliente.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarFoneCliente.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarFoneCliente.Location = new System.Drawing.Point(117, 1);
            this.lblAdicionarFoneCliente.Name = "lblAdicionarFoneCliente";
            this.lblAdicionarFoneCliente.Size = new System.Drawing.Size(596, 43);
            this.lblAdicionarFoneCliente.TabIndex = 37;
            this.lblAdicionarFoneCliente.Text = "ADICIONAR TELEFONE CLIENTE";
            this.lblAdicionarFoneCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.cliente;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.CadFoneCliente);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.TelefoneCliente);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.txtFoto);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeDoCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblAdicionarClientes);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadCliente";
            this.Load += new System.EventHandler(this.frmCadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.TelefoneCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneCliente)).EndInit();
            this.CadFoneCliente.ResumeLayout(false);
            this.CadFoneCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdicionarClientes;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNomeDoCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.Panel TelefoneCliente;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.DataGridView dgvFoneCliente;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel CadFoneCliente;
        private System.Windows.Forms.Button btnFecharFone;
        private System.Windows.Forms.Button btnSalvarFone;
        private System.Windows.Forms.ComboBox cmbDescFone;
        private System.Windows.Forms.ComboBox cmbTipFone;
        private System.Windows.Forms.Label lblDescFone;
        private System.Windows.Forms.Label lblNumFone;
        private System.Windows.Forms.Label lblTipFone;
        private System.Windows.Forms.MaskedTextBox txtNumFone;
        private System.Windows.Forms.TextBox txtCodFone;
        private System.Windows.Forms.Label lblCodFone;
        private System.Windows.Forms.Label lblAdicionarFoneCliente;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}
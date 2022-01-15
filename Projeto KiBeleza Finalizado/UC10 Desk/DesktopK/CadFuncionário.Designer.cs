
namespace DesktopK
{
    partial class frmCadFuncionário
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAdicionarFuncionario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.TelefoneFuncionario = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdicionarTelefone = new System.Windows.Forms.Button();
            this.dgvFoneFuncionario = new System.Windows.Forms.DataGridView();
            this.CadFoneFuncionario = new System.Windows.Forms.Panel();
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
            this.lblAdicionarFoneFuncionario = new System.Windows.Forms.Label();
            this.txtDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.lblHorarioTrabalho = new System.Windows.Forms.Label();
            this.cmbHorarioTrabalho = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.cmbEmpresa = new System.Windows.Forms.ComboBox();
            this.pctFoto = new System.Windows.Forms.PictureBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.TelefoneFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneFuncionario)).BeginInit();
            this.CadFoneFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(649, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 21;
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
            this.btnFechar.Location = new System.Drawing.Point(763, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 20;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAdicionarFuncionario
            // 
            this.lblAdicionarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarFuncionario.Location = new System.Drawing.Point(149, -3);
            this.lblAdicionarFuncionario.Name = "lblAdicionarFuncionario";
            this.lblAdicionarFuncionario.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarFuncionario.TabIndex = 19;
            this.lblAdicionarFuncionario.Text = "ADICIONAR FUNCIONÁRIO";
            this.lblAdicionarFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(163, 55);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 16);
            this.lblCodigo.TabIndex = 38;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Location = new System.Drawing.Point(163, 177);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 16);
            this.lblStatus.TabIndex = 53;
            this.lblStatus.Text = "STATUS:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO",
            "OCUPADO",
            "LIVRE"});
            this.cmbStatus.Location = new System.Drawing.Point(166, 196);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(123, 21);
            this.cmbStatus.TabIndex = 52;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged_1);
            // 
            // TelefoneFuncionario
            // 
            this.TelefoneFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.TelefoneFuncionario.BackgroundImage = global::DesktopK.Properties.Resources.fonefuncionario;
            this.TelefoneFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TelefoneFuncionario.Controls.Add(this.btnExcluir);
            this.TelefoneFuncionario.Controls.Add(this.btnAlterar);
            this.TelefoneFuncionario.Controls.Add(this.btnAdicionarTelefone);
            this.TelefoneFuncionario.Controls.Add(this.dgvFoneFuncionario);
            this.TelefoneFuncionario.Enabled = false;
            this.TelefoneFuncionario.Location = new System.Drawing.Point(166, 240);
            this.TelefoneFuncionario.Name = "TelefoneFuncionario";
            this.TelefoneFuncionario.Size = new System.Drawing.Size(415, 197);
            this.TelefoneFuncionario.TabIndex = 51;
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
            this.btnAdicionarTelefone.Click += new System.EventHandler(this.btnAdicionarTelefone_Click_1);
            // 
            // dgvFoneFuncionario
            // 
            this.dgvFoneFuncionario.AllowUserToAddRows = false;
            this.dgvFoneFuncionario.AllowUserToDeleteRows = false;
            this.dgvFoneFuncionario.AllowUserToResizeColumns = false;
            this.dgvFoneFuncionario.AllowUserToResizeRows = false;
            this.dgvFoneFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoneFuncionario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.dgvFoneFuncionario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.dgvFoneFuncionario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoneFuncionario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoneFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoneFuncionario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoneFuncionario.EnableHeadersVisualStyles = false;
            this.dgvFoneFuncionario.Location = new System.Drawing.Point(72, 4);
            this.dgvFoneFuncionario.MultiSelect = false;
            this.dgvFoneFuncionario.Name = "dgvFoneFuncionario";
            this.dgvFoneFuncionario.ReadOnly = true;
            this.dgvFoneFuncionario.RowHeadersVisible = false;
            this.dgvFoneFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoneFuncionario.Size = new System.Drawing.Size(339, 158);
            this.dgvFoneFuncionario.TabIndex = 0;
            this.dgvFoneFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoneFuncionario_CellClick);
            this.dgvFoneFuncionario.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFoneFuncionario_ColumnHeaderMouseClick);
            // 
            // CadFoneFuncionario
            // 
            this.CadFoneFuncionario.BackgroundImage = global::DesktopK.Properties.Resources.fonefuncionario;
            this.CadFoneFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CadFoneFuncionario.Controls.Add(this.btnFecharFone);
            this.CadFoneFuncionario.Controls.Add(this.btnSalvarFone);
            this.CadFoneFuncionario.Controls.Add(this.cmbDescFone);
            this.CadFoneFuncionario.Controls.Add(this.cmbTipFone);
            this.CadFoneFuncionario.Controls.Add(this.lblDescFone);
            this.CadFoneFuncionario.Controls.Add(this.lblNumFone);
            this.CadFoneFuncionario.Controls.Add(this.lblTipFone);
            this.CadFoneFuncionario.Controls.Add(this.txtNumFone);
            this.CadFoneFuncionario.Controls.Add(this.txtCodFone);
            this.CadFoneFuncionario.Controls.Add(this.lblCodFone);
            this.CadFoneFuncionario.Controls.Add(this.lblAdicionarFoneFuncionario);
            this.CadFoneFuncionario.Location = new System.Drawing.Point(166, 43);
            this.CadFoneFuncionario.Name = "CadFoneFuncionario";
            this.CadFoneFuncionario.Size = new System.Drawing.Size(705, 395);
            this.CadFoneFuncionario.TabIndex = 62;
            this.CadFoneFuncionario.Visible = false;
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
            this.btnFecharFone.Click += new System.EventHandler(this.btnFecharFone_Click_1);
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
            "OI",
            "TIM",
            "VIVO",
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
            // lblAdicionarFoneFuncionario
            // 
            this.lblAdicionarFoneFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarFoneFuncionario.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarFoneFuncionario.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarFoneFuncionario.Location = new System.Drawing.Point(117, 1);
            this.lblAdicionarFoneFuncionario.Name = "lblAdicionarFoneFuncionario";
            this.lblAdicionarFoneFuncionario.Size = new System.Drawing.Size(596, 43);
            this.lblAdicionarFoneFuncionario.TabIndex = 37;
            this.lblAdicionarFoneFuncionario.Text = "ADICIONAR TELEFONE FUNCIONÁRIO";
            this.lblAdicionarFoneFuncionario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDataCadastro
            // 
            this.txtDataCadastro.Enabled = false;
            this.txtDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtDataCadastro.Location = new System.Drawing.Point(307, 194);
            this.txtDataCadastro.Mask = "00/00/0000";
            this.txtDataCadastro.Name = "txtDataCadastro";
            this.txtDataCadastro.Size = new System.Drawing.Size(142, 24);
            this.txtDataCadastro.TabIndex = 49;
            this.txtDataCadastro.ValidatingType = typeof(System.DateTime);
            this.txtDataCadastro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataCadastro_KeyPress_1);
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblDataCadastro.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblDataCadastro.Location = new System.Drawing.Point(305, 176);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(142, 16);
            this.lblDataCadastro.TabIndex = 46;
            this.lblDataCadastro.Text = "DATA DE CADASTRO:";
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtSenha.Location = new System.Drawing.Point(546, 134);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(177, 24);
            this.txtSenha.TabIndex = 45;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblSenha.Location = new System.Drawing.Point(543, 115);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(55, 16);
            this.lblSenha.TabIndex = 44;
            this.lblSenha.Text = "SENHA:";
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtEmail.Location = new System.Drawing.Point(166, 134);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(367, 24);
            this.txtEmail.TabIndex = 43;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmail.Location = new System.Drawing.Point(163, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 16);
            this.lblEmail.TabIndex = 42;
            this.lblEmail.Text = "EMAIL:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(307, 74);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(564, 24);
            this.txtNomeFuncionario.TabIndex = 41;
            this.txtNomeFuncionario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeFuncionario_KeyPress);
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(304, 55);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(168, 16);
            this.lblNomeFuncionario.TabIndex = 40;
            this.lblNomeFuncionario.Text = "NOME DO FUNCIONÁRIO:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(166, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 39;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNivel.Location = new System.Drawing.Point(733, 117);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(50, 16);
            this.lblNivel.TabIndex = 55;
            this.lblNivel.Text = "NÍVEL:";
            // 
            // cmbNivel
            // 
            this.cmbNivel.Enabled = false;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "ATENDENTE"});
            this.cmbNivel.Location = new System.Drawing.Point(736, 136);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(135, 21);
            this.cmbNivel.TabIndex = 54;
            this.cmbNivel.SelectedIndexChanged += new System.EventHandler(this.cmbNivel_SelectedIndexChanged_1);
            // 
            // lblHorarioTrabalho
            // 
            this.lblHorarioTrabalho.AutoSize = true;
            this.lblHorarioTrabalho.BackColor = System.Drawing.Color.Transparent;
            this.lblHorarioTrabalho.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarioTrabalho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblHorarioTrabalho.Location = new System.Drawing.Point(477, 180);
            this.lblHorarioTrabalho.Name = "lblHorarioTrabalho";
            this.lblHorarioTrabalho.Size = new System.Drawing.Size(169, 16);
            this.lblHorarioTrabalho.TabIndex = 57;
            this.lblHorarioTrabalho.Text = "HORÁRIO DE TRABALHO:";
            // 
            // cmbHorarioTrabalho
            // 
            this.cmbHorarioTrabalho.Enabled = false;
            this.cmbHorarioTrabalho.FormattingEnabled = true;
            this.cmbHorarioTrabalho.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00"});
            this.cmbHorarioTrabalho.Location = new System.Drawing.Point(479, 197);
            this.cmbHorarioTrabalho.Name = "cmbHorarioTrabalho";
            this.cmbHorarioTrabalho.Size = new System.Drawing.Size(168, 21);
            this.cmbHorarioTrabalho.TabIndex = 56;
            this.cmbHorarioTrabalho.SelectedIndexChanged += new System.EventHandler(this.cmbHorarioTrabalho_SelectedIndexChanged_1);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpresa.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblEmpresa.Location = new System.Drawing.Point(675, 178);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(73, 16);
            this.lblEmpresa.TabIndex = 59;
            this.lblEmpresa.Text = "EMPRESA:";
            // 
            // cmbEmpresa
            // 
            this.cmbEmpresa.Enabled = false;
            this.cmbEmpresa.FormattingEnabled = true;
            this.cmbEmpresa.Location = new System.Drawing.Point(677, 197);
            this.cmbEmpresa.Name = "cmbEmpresa";
            this.cmbEmpresa.Size = new System.Drawing.Size(194, 21);
            this.cmbEmpresa.TabIndex = 58;
            this.cmbEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbEmpresa_SelectedIndexChanged_1);
            // 
            // pctFoto
            // 
            this.pctFoto.BackgroundImage = global::DesktopK.Properties.Resources.semimagem;
            this.pctFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctFoto.Enabled = false;
            this.pctFoto.Location = new System.Drawing.Point(678, 240);
            this.pctFoto.Name = "pctFoto";
            this.pctFoto.Size = new System.Drawing.Size(173, 152);
            this.pctFoto.TabIndex = 65;
            this.pctFoto.TabStop = false;
            this.pctFoto.Click += new System.EventHandler(this.pctFoto_Click);
            // 
            // txtFoto
            // 
            this.txtFoto.Enabled = false;
            this.txtFoto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtFoto.Location = new System.Drawing.Point(709, 290);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(112, 24);
            this.txtFoto.TabIndex = 64;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.BackColor = System.Drawing.Color.Transparent;
            this.lblFoto.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblFoto.Location = new System.Drawing.Point(621, 298);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(47, 16);
            this.lblFoto.TabIndex = 63;
            this.lblFoto.Text = "FOTO:";
            // 
            // frmCadFuncionário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.funcionario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.CadFoneFuncionario);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.cmbEmpresa);
            this.Controls.Add(this.lblHorarioTrabalho);
            this.Controls.Add(this.cmbHorarioTrabalho);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.TelefoneFuncionario);
            this.Controls.Add(this.txtDataCadastro);
            this.Controls.Add(this.lblDataCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblAdicionarFuncionario);
            this.Controls.Add(this.lblFoto);
            this.Controls.Add(this.pctFoto);
            this.Controls.Add(this.txtFoto);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadFuncionário";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadFuncionário";
            this.Load += new System.EventHandler(this.frmCadFuncionário_Load);
            this.TelefoneFuncionario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoneFuncionario)).EndInit();
            this.CadFoneFuncionario.ResumeLayout(false);
            this.CadFoneFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAdicionarFuncionario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel TelefoneFuncionario;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdicionarTelefone;
        private System.Windows.Forms.DataGridView dgvFoneFuncionario;
        private System.Windows.Forms.MaskedTextBox txtDataCadastro;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label lblHorarioTrabalho;
        private System.Windows.Forms.ComboBox cmbHorarioTrabalho;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cmbEmpresa;
        private System.Windows.Forms.Panel CadFoneFuncionario;
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
        private System.Windows.Forms.Label lblAdicionarFoneFuncionario;
        private System.Windows.Forms.PictureBox pctFoto;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label lblFoto;
    }
}
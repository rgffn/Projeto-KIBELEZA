
namespace DesktopK
{
    partial class frmCadBanner
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtNomeBanner = new System.Windows.Forms.TextBox();
            this.lblNomeBanner = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.lblCaminhoImagem = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblAdicionarBanner = new System.Windows.Forms.Label();
            this.pctBanner = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.radInativo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCodigo.Location = new System.Drawing.Point(164, 54);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 16);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "CÓDIGO:";
            // 
            // txtNomeBanner
            // 
            this.txtNomeBanner.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeBanner.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtNomeBanner.Location = new System.Drawing.Point(298, 73);
            this.txtNomeBanner.Name = "txtNomeBanner";
            this.txtNomeBanner.Size = new System.Drawing.Size(576, 24);
            this.txtNomeBanner.TabIndex = 26;
            this.txtNomeBanner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeBanner_KeyPress);
            // 
            // lblNomeBanner
            // 
            this.lblNomeBanner.AutoSize = true;
            this.lblNomeBanner.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeBanner.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblNomeBanner.Location = new System.Drawing.Point(295, 54);
            this.lblNomeBanner.Name = "lblNomeBanner";
            this.lblNomeBanner.Size = new System.Drawing.Size(130, 16);
            this.lblNomeBanner.TabIndex = 25;
            this.lblNomeBanner.Text = "NOME DO BANNER:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCodigo.Location = new System.Drawing.Point(167, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 24;
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCaminhoImagem.Enabled = false;
            this.txtCaminhoImagem.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaminhoImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtCaminhoImagem.Location = new System.Drawing.Point(185, 172);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(676, 24);
            this.txtCaminhoImagem.TabIndex = 28;
            // 
            // lblCaminhoImagem
            // 
            this.lblCaminhoImagem.AutoSize = true;
            this.lblCaminhoImagem.BackColor = System.Drawing.Color.Transparent;
            this.lblCaminhoImagem.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaminhoImagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblCaminhoImagem.Location = new System.Drawing.Point(427, 114);
            this.lblCaminhoImagem.Name = "lblCaminhoImagem";
            this.lblCaminhoImagem.Size = new System.Drawing.Size(152, 16);
            this.lblCaminhoImagem.TabIndex = 27;
            this.lblCaminhoImagem.Text = "CAMINHO DA IMAGEM:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Location = new System.Drawing.Point(633, 402);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 36);
            this.btnSalvar.TabIndex = 30;
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
            this.btnFechar.Location = new System.Drawing.Point(766, 402);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(108, 36);
            this.btnFechar.TabIndex = 29;
            this.btnFechar.Text = "FECHAR";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblAdicionarBanner
            // 
            this.lblAdicionarBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblAdicionarBanner.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarBanner.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarBanner.Location = new System.Drawing.Point(150, -2);
            this.lblAdicionarBanner.Name = "lblAdicionarBanner";
            this.lblAdicionarBanner.Size = new System.Drawing.Size(751, 43);
            this.lblAdicionarBanner.TabIndex = 31;
            this.lblAdicionarBanner.Text = "ADICIONAR BANNER";
            this.lblAdicionarBanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pctBanner
            // 
            this.pctBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctBanner.Enabled = false;
            this.pctBanner.Location = new System.Drawing.Point(167, 133);
            this.pctBanner.Name = "pctBanner";
            this.pctBanner.Size = new System.Drawing.Size(707, 214);
            this.pctBanner.TabIndex = 32;
            this.pctBanner.TabStop = false;
            this.pctBanner.Click += new System.EventHandler(this.pctBanner_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.lblStatus.Enabled = false;
            this.lblStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(634, 360);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(240, 39);
            this.lblStatus.TabIndex = 64;
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.Location = new System.Drawing.Point(639, 372);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 17);
            this.txtStatus.TabIndex = 65;
            this.txtStatus.Text = "STATUS:";
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.radAtivo.Enabled = false;
            this.radAtivo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAtivo.ForeColor = System.Drawing.Color.White;
            this.radAtivo.Location = new System.Drawing.Point(709, 370);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(65, 20);
            this.radAtivo.TabIndex = 66;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "ATIVO";
            this.radAtivo.UseVisualStyleBackColor = false;
            this.radAtivo.CheckedChanged += new System.EventHandler(this.radAtivo_CheckedChanged);
            // 
            // radInativo
            // 
            this.radInativo.AutoSize = true;
            this.radInativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(10)))), ((int)(((byte)(45)))));
            this.radInativo.Enabled = false;
            this.radInativo.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInativo.ForeColor = System.Drawing.Color.White;
            this.radInativo.Location = new System.Drawing.Point(782, 370);
            this.radInativo.Name = "radInativo";
            this.radInativo.Size = new System.Drawing.Size(79, 20);
            this.radInativo.TabIndex = 67;
            this.radInativo.TabStop = true;
            this.radInativo.Text = "INATIVO";
            this.radInativo.UseVisualStyleBackColor = false;
            this.radInativo.CheckedChanged += new System.EventHandler(this.radInativo_CheckedChanged);
            // 
            // frmCadBanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DesktopK.Properties.Resources.banner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.radInativo);
            this.Controls.Add(this.radAtivo);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pctBanner);
            this.Controls.Add(this.lblAdicionarBanner);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Controls.Add(this.lblCaminhoImagem);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtNomeBanner);
            this.Controls.Add(this.lblNomeBanner);
            this.Controls.Add(this.txtCodigo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadBanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadBanner";
            this.Load += new System.EventHandler(this.frmCadBanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNomeBanner;
        private System.Windows.Forms.Label lblNomeBanner;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.Label lblCaminhoImagem;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblAdicionarBanner;
        private System.Windows.Forms.PictureBox pctBanner;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.RadioButton radInativo;
    }
}
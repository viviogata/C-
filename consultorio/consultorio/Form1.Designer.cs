namespace consultorio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbReduzir = new System.Windows.Forms.PictureBox();
            this.ptbAmpliar = new System.Windows.Forms.PictureBox();
            this.ptbFechar = new System.Windows.Forms.PictureBox();
            this.pnlInicio = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlCadastro = new System.Windows.Forms.Panel();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.txbDataHora = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mktPlaca = new System.Windows.Forms.MaskedTextBox();
            this.rbtMoto = new System.Windows.Forms.RadioButton();
            this.rbtCarro = new System.Windows.Forms.RadioButton();
            this.pnlLocalizar = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLocal = new System.Windows.Forms.Button();
            this.mktPlaca1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.mkbPassword = new System.Windows.Forms.MaskedTextBox();
            this.mkbUser = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstGeral = new System.Windows.Forms.ListBox();
            this.btnCobrança = new System.Windows.Forms.Button();
            this.MenuVertical.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReduzir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmpliar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).BeginInit();
            this.pnlInicio.SuspendLayout();
            this.pnlCadastro.SuspendLayout();
            this.pnlLocalizar.SuspendLayout();
            this.pnlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Maroon;
            this.MenuVertical.Controls.Add(this.SidePanel);
            this.MenuVertical.Controls.Add(this.btnInicio);
            this.MenuVertical.Controls.Add(this.btnCadastrar);
            this.MenuVertical.Controls.Add(this.btnLocalizar);
            this.MenuVertical.Controls.Add(this.btnUsuario);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(167, 482);
            this.MenuVertical.TabIndex = 5;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SidePanel.Location = new System.Drawing.Point(0, 85);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 47);
            this.SidePanel.TabIndex = 7;
            // 
            // btnInicio
            // 
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicio.Image = global::consultorio.Properties.Resources.time_is_money;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(12, 85);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(155, 47);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Image = global::consultorio.Properties.Resources.plus;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(12, 150);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(155, 47);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_1);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.FlatAppearance.BorderSize = 0;
            this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLocalizar.Image = global::consultorio.Properties.Resources.search;
            this.btnLocalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocalizar.Location = new System.Drawing.Point(12, 217);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(155, 47);
            this.btnLocalizar.TabIndex = 9;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuario.Image = global::consultorio.Properties.Resources.user;
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(12, 283);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(155, 47);
            this.btnUsuario.TabIndex = 10;
            this.btnUsuario.Text = "Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.ptbReduzir);
            this.panel2.Controls.Add(this.ptbAmpliar);
            this.panel2.Controls.Add(this.ptbFechar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 35);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::consultorio.Properties.Resources.menu;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ptbReduzir
            // 
            this.ptbReduzir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbReduzir.Image = global::consultorio.Properties.Resources.circular_shape_silhouette__2_;
            this.ptbReduzir.Location = new System.Drawing.Point(497, 12);
            this.ptbReduzir.Name = "ptbReduzir";
            this.ptbReduzir.Size = new System.Drawing.Size(20, 20);
            this.ptbReduzir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbReduzir.TabIndex = 8;
            this.ptbReduzir.TabStop = false;
            this.ptbReduzir.Click += new System.EventHandler(this.ptbReduzir_Click);
            // 
            // ptbAmpliar
            // 
            this.ptbAmpliar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbAmpliar.Image = global::consultorio.Properties.Resources.circular_shape_silhouette;
            this.ptbAmpliar.Location = new System.Drawing.Point(471, 12);
            this.ptbAmpliar.Name = "ptbAmpliar";
            this.ptbAmpliar.Size = new System.Drawing.Size(20, 20);
            this.ptbAmpliar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAmpliar.TabIndex = 8;
            this.ptbAmpliar.TabStop = false;
            this.ptbAmpliar.Click += new System.EventHandler(this.ptbAmpliar_Click);
            // 
            // ptbFechar
            // 
            this.ptbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbFechar.Image = global::consultorio.Properties.Resources.circular_shape_silhouette__1_;
            this.ptbFechar.Location = new System.Drawing.Point(523, 12);
            this.ptbFechar.Name = "ptbFechar";
            this.ptbFechar.Size = new System.Drawing.Size(20, 20);
            this.ptbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbFechar.TabIndex = 7;
            this.ptbFechar.TabStop = false;
            this.ptbFechar.Click += new System.EventHandler(this.ptbFechar_Click);
            // 
            // pnlInicio
            // 
            this.pnlInicio.Controls.Add(this.label1);
            this.pnlInicio.Location = new System.Drawing.Point(173, 41);
            this.pnlInicio.Name = "pnlInicio";
            this.pnlInicio.Size = new System.Drawing.Size(537, 352);
            this.pnlInicio.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(86, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bem vindo";
            // 
            // pnlCadastro
            // 
            this.pnlCadastro.Controls.Add(this.lblPlaca);
            this.pnlCadastro.Controls.Add(this.btnCadastro);
            this.pnlCadastro.Controls.Add(this.txbDataHora);
            this.pnlCadastro.Controls.Add(this.btnAtualizar);
            this.pnlCadastro.Controls.Add(this.label3);
            this.pnlCadastro.Controls.Add(this.mktPlaca);
            this.pnlCadastro.Controls.Add(this.rbtMoto);
            this.pnlCadastro.Controls.Add(this.rbtCarro);
            this.pnlCadastro.Location = new System.Drawing.Point(173, 41);
            this.pnlCadastro.Name = "pnlCadastro";
            this.pnlCadastro.Size = new System.Drawing.Size(537, 352);
            this.pnlCadastro.TabIndex = 1;
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPlaca.Location = new System.Drawing.Point(118, 42);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(74, 24);
            this.lblPlaca.TabIndex = 0;
            this.lblPlaca.Text = "Placa:";
            this.lblPlaca.Click += new System.EventHandler(this.lblPlaca_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(216, 280);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(97, 38);
            this.btnCadastro.TabIndex = 11;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // txbDataHora
            // 
            this.txbDataHora.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDataHora.Location = new System.Drawing.Point(164, 106);
            this.txbDataHora.Name = "txbDataHora";
            this.txbDataHora.Size = new System.Drawing.Size(347, 26);
            this.txbDataHora.TabIndex = 10;
            this.txbDataHora.TextChanged += new System.EventHandler(this.txbDataHora_TextChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnAtualizar.Location = new System.Drawing.Point(216, 162);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 36);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data e hora:";
            // 
            // mktPlaca
            // 
            this.mktPlaca.Font = new System.Drawing.Font("Century Gothic", 16.75F);
            this.mktPlaca.Location = new System.Drawing.Point(216, 31);
            this.mktPlaca.Mask = "AAA-0000";
            this.mktPlaca.Name = "mktPlaca";
            this.mktPlaca.Size = new System.Drawing.Size(97, 35);
            this.mktPlaca.TabIndex = 5;
            this.mktPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktPlaca_MaskInputRejected);
            // 
            // rbtMoto
            // 
            this.rbtMoto.AutoSize = true;
            this.rbtMoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtMoto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtMoto.Image = global::consultorio.Properties.Resources.motor_sports;
            this.rbtMoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtMoto.Location = new System.Drawing.Point(279, 225);
            this.rbtMoto.Name = "rbtMoto";
            this.rbtMoto.Size = new System.Drawing.Size(100, 26);
            this.rbtMoto.TabIndex = 4;
            this.rbtMoto.Text = "Moto";
            this.rbtMoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtMoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtMoto.UseVisualStyleBackColor = true;
            this.rbtMoto.CheckedChanged += new System.EventHandler(this.rbtMoto_CheckedChanged);
            // 
            // rbtCarro
            // 
            this.rbtCarro.AutoSize = true;
            this.rbtCarro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtCarro.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtCarro.Image = global::consultorio.Properties.Resources.car;
            this.rbtCarro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbtCarro.Location = new System.Drawing.Point(137, 225);
            this.rbtCarro.Name = "rbtCarro";
            this.rbtCarro.Size = new System.Drawing.Size(104, 26);
            this.rbtCarro.TabIndex = 3;
            this.rbtCarro.Text = "Carro";
            this.rbtCarro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbtCarro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rbtCarro.UseVisualStyleBackColor = true;
            this.rbtCarro.CheckedChanged += new System.EventHandler(this.rbtCarro_CheckedChanged);
            // 
            // pnlLocalizar
            // 
            this.pnlLocalizar.Controls.Add(this.btnCobrança);
            this.pnlLocalizar.Controls.Add(this.lblStatus);
            this.pnlLocalizar.Controls.Add(this.btnLocal);
            this.pnlLocalizar.Controls.Add(this.mktPlaca1);
            this.pnlLocalizar.Controls.Add(this.label2);
            this.pnlLocalizar.Location = new System.Drawing.Point(170, 41);
            this.pnlLocalizar.Name = "pnlLocalizar";
            this.pnlLocalizar.Size = new System.Drawing.Size(537, 355);
            this.pnlLocalizar.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 319);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 13);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "0";
            // 
            // btnLocal
            // 
            this.btnLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLocal.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnLocal.Image = global::consultorio.Properties.Resources.search;
            this.btnLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLocal.Location = new System.Drawing.Point(131, 255);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(100, 36);
            this.btnLocal.TabIndex = 17;
            this.btnLocal.Text = "Localizar";
            this.btnLocal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // mktPlaca1
            // 
            this.mktPlaca1.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.mktPlaca1.Location = new System.Drawing.Point(267, 131);
            this.mktPlaca1.Mask = "AAA-0000";
            this.mktPlaca1.Name = "mktPlaca1";
            this.mktPlaca1.Size = new System.Drawing.Size(100, 34);
            this.mktPlaca1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Placa:";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.Controls.Add(this.btnLimpar);
            this.pnlUsuario.Controls.Add(this.btnLogin);
            this.pnlUsuario.Controls.Add(this.mkbPassword);
            this.pnlUsuario.Controls.Add(this.mkbUser);
            this.pnlUsuario.Controls.Add(this.lblPassword);
            this.pnlUsuario.Controls.Add(this.lblLogin);
            this.pnlUsuario.Controls.Add(this.lblUser);
            this.pnlUsuario.Controls.Add(this.pictureBox2);
            this.pnlUsuario.Location = new System.Drawing.Point(170, 41);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(537, 349);
            this.pnlUsuario.TabIndex = 16;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(307, 291);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 30);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(147, 291);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 30);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // mkbPassword
            // 
            this.mkbPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Insert;
            this.mkbPassword.Location = new System.Drawing.Point(219, 232);
            this.mkbPassword.Mask = "00000";
            this.mkbPassword.Name = "mkbPassword";
            this.mkbPassword.Size = new System.Drawing.Size(100, 27);
            this.mkbPassword.TabIndex = 5;
            this.mkbPassword.UseSystemPasswordChar = true;
            this.mkbPassword.ValidatingType = typeof(int);
            // 
            // mkbUser
            // 
            this.mkbUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mkbUser.Location = new System.Drawing.Point(219, 171);
            this.mkbUser.Name = "mkbUser";
            this.mkbUser.Size = new System.Drawing.Size(100, 27);
            this.mkbUser.TabIndex = 4;
            this.mkbUser.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkbUser_MaskInputRejected);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(127, 228);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 24);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(212, 5);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(109, 42);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(127, 169);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 24);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuário:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::consultorio.Properties.Resources.user1;
            this.pictureBox2.Location = new System.Drawing.Point(219, 66);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lstGeral
            // 
            this.lstGeral.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGeral.FormattingEnabled = true;
            this.lstGeral.ItemHeight = 16;
            this.lstGeral.Location = new System.Drawing.Point(173, 402);
            this.lstGeral.Name = "lstGeral";
            this.lstGeral.Size = new System.Drawing.Size(537, 68);
            this.lstGeral.TabIndex = 17;
            // 
            // btnCobrança
            // 
            this.btnCobrança.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCobrança.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnCobrança.Image = global::consultorio.Properties.Resources.time_is_money;
            this.btnCobrança.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrança.Location = new System.Drawing.Point(294, 257);
            this.btnCobrança.Name = "btnCobrança";
            this.btnCobrança.Size = new System.Drawing.Size(97, 34);
            this.btnCobrança.TabIndex = 19;
            this.btnCobrança.Text = "Cobrar";
            this.btnCobrança.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrança.UseVisualStyleBackColor = true;
            this.btnCobrança.Click += new System.EventHandler(this.btnCobrança_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 482);
            this.Controls.Add(this.lstGeral);
            this.Controls.Add(this.pnlLocalizar);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.pnlCadastro);
            this.Controls.Add(this.pnlInicio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Estacionamento";
            this.MenuVertical.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReduzir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmpliar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFechar)).EndInit();
            this.pnlInicio.ResumeLayout(false);
            this.pnlInicio.PerformLayout();
            this.pnlCadastro.ResumeLayout(false);
            this.pnlCadastro.PerformLayout();
            this.pnlLocalizar.ResumeLayout(false);
            this.pnlLocalizar.PerformLayout();
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox ptbReduzir;
        private System.Windows.Forms.PictureBox ptbAmpliar;
        private System.Windows.Forms.PictureBox ptbFechar;
        private System.Windows.Forms.Panel pnlInicio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCadastro;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.RadioButton rbtMoto;
        private System.Windows.Forms.RadioButton rbtCarro;
        private System.Windows.Forms.MaskedTextBox mktPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txbDataHora;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Panel pnlLocalizar;
        private System.Windows.Forms.MaskedTextBox mktPlaca1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MaskedTextBox mkbPassword;
        private System.Windows.Forms.MaskedTextBox mkbUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.ListBox lstGeral;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCobrança;
    }
}


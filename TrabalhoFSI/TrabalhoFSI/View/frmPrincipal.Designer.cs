namespace TrabalhoFSI.View
{
    partial class frmPrincipal
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
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpMedicamentos = new System.Windows.Forms.TabPage();
            this.btnEncomenda = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnEditarMed = new System.Windows.Forms.Button();
            this.btnCadastrarMed = new System.Windows.Forms.Button();
            this.dgvMedicamentos = new System.Windows.Forms.DataGridView();
            this.tbpFuncionarios = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.tbpFornecedor = new System.Windows.Forms.TabPage();
            this.btnEditarFornecedor = new System.Windows.Forms.Button();
            this.btnCadastrarForne = new System.Windows.Forms.Button();
            this.dgvFornecedores = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnMedRetirados = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbFuncionario = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.mskAdmissao = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mskCelular = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskNasc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tbcPrincipal.SuspendLayout();
            this.tbpMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).BeginInit();
            this.tbpFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.tbpFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbcPrincipal.Controls.Add(this.tbpMedicamentos);
            this.tbcPrincipal.Controls.Add(this.tbpFuncionarios);
            this.tbcPrincipal.Controls.Add(this.tbpFornecedor);
            this.tbcPrincipal.Controls.Add(this.tabPage3);
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Multiline = true;
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(587, 337);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tbpMedicamentos
            // 
            this.tbpMedicamentos.Controls.Add(this.btnEncomenda);
            this.tbpMedicamentos.Controls.Add(this.btnRetirar);
            this.tbpMedicamentos.Controls.Add(this.btnEditarMed);
            this.tbpMedicamentos.Controls.Add(this.btnCadastrarMed);
            this.tbpMedicamentos.Controls.Add(this.dgvMedicamentos);
            this.tbpMedicamentos.Location = new System.Drawing.Point(4, 30);
            this.tbpMedicamentos.Name = "tbpMedicamentos";
            this.tbpMedicamentos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpMedicamentos.Size = new System.Drawing.Size(579, 303);
            this.tbpMedicamentos.TabIndex = 0;
            this.tbpMedicamentos.Text = "Medicamentos";
            this.tbpMedicamentos.UseVisualStyleBackColor = true;
            // 
            // btnEncomenda
            // 
            this.btnEncomenda.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncomenda.Location = new System.Drawing.Point(397, 249);
            this.btnEncomenda.Name = "btnEncomenda";
            this.btnEncomenda.Size = new System.Drawing.Size(174, 23);
            this.btnEncomenda.TabIndex = 5;
            this.btnEncomenda.Text = "Encomendar Medicamento";
            this.btnEncomenda.UseVisualStyleBackColor = true;
            this.btnEncomenda.Click += new System.EventHandler(this.btnEncomenda_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(239, 249);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(131, 23);
            this.btnRetirar.TabIndex = 4;
            this.btnRetirar.Text = "Retirar Medicamento";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnEditarMed
            // 
            this.btnEditarMed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMed.Location = new System.Drawing.Point(126, 249);
            this.btnEditarMed.Name = "btnEditarMed";
            this.btnEditarMed.Size = new System.Drawing.Size(88, 23);
            this.btnEditarMed.TabIndex = 2;
            this.btnEditarMed.Text = "Editar";
            this.btnEditarMed.UseVisualStyleBackColor = true;
            this.btnEditarMed.Click += new System.EventHandler(this.btnEditarMed_Click);
            // 
            // btnCadastrarMed
            // 
            this.btnCadastrarMed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMed.Location = new System.Drawing.Point(8, 249);
            this.btnCadastrarMed.Name = "btnCadastrarMed";
            this.btnCadastrarMed.Size = new System.Drawing.Size(95, 23);
            this.btnCadastrarMed.TabIndex = 1;
            this.btnCadastrarMed.Text = "Cadastrar";
            this.btnCadastrarMed.UseVisualStyleBackColor = true;
            this.btnCadastrarMed.Click += new System.EventHandler(this.btnCadastrarMed_Click);
            // 
            // dgvMedicamentos
            // 
            this.dgvMedicamentos.AllowUserToAddRows = false;
            this.dgvMedicamentos.AllowUserToDeleteRows = false;
            this.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicamentos.Location = new System.Drawing.Point(8, 6);
            this.dgvMedicamentos.Name = "dgvMedicamentos";
            this.dgvMedicamentos.ReadOnly = true;
            this.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMedicamentos.Size = new System.Drawing.Size(563, 217);
            this.dgvMedicamentos.TabIndex = 0;
            this.dgvMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentos_CellContentClick);
            // 
            // tbpFuncionarios
            // 
            this.tbpFuncionarios.Controls.Add(this.btnListar);
            this.tbpFuncionarios.Controls.Add(this.btnAlterar);
            this.tbpFuncionarios.Controls.Add(this.btnCadastrar);
            this.tbpFuncionarios.Controls.Add(this.dgvUsuarios);
            this.tbpFuncionarios.Location = new System.Drawing.Point(4, 30);
            this.tbpFuncionarios.Name = "tbpFuncionarios";
            this.tbpFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFuncionarios.Size = new System.Drawing.Size(579, 303);
            this.tbpFuncionarios.TabIndex = 1;
            this.tbpFuncionarios.Text = "Funcionários";
            this.tbpFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnListar.Location = new System.Drawing.Point(291, 249);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(198, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Medicamentos Retirados";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAlterar.Location = new System.Drawing.Point(155, 249);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar Cadastro";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCadastrar.Location = new System.Drawing.Point(8, 249);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(109, 23);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvUsuarios.Location = new System.Drawing.Point(8, 6);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(563, 217);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // tbpFornecedor
            // 
            this.tbpFornecedor.Controls.Add(this.btnEditarFornecedor);
            this.tbpFornecedor.Controls.Add(this.btnCadastrarForne);
            this.tbpFornecedor.Controls.Add(this.dgvFornecedores);
            this.tbpFornecedor.Location = new System.Drawing.Point(4, 30);
            this.tbpFornecedor.Name = "tbpFornecedor";
            this.tbpFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFornecedor.Size = new System.Drawing.Size(579, 303);
            this.tbpFornecedor.TabIndex = 3;
            this.tbpFornecedor.Text = "Fornecedores";
            this.tbpFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnEditarFornecedor
            // 
            this.btnEditarFornecedor.Font = new System.Drawing.Font("Arial", 9F);
            this.btnEditarFornecedor.Location = new System.Drawing.Point(180, 249);
            this.btnEditarFornecedor.Name = "btnEditarFornecedor";
            this.btnEditarFornecedor.Size = new System.Drawing.Size(105, 23);
            this.btnEditarFornecedor.TabIndex = 2;
            this.btnEditarFornecedor.Text = "Editar Fornecedor";
            this.btnEditarFornecedor.UseVisualStyleBackColor = true;
            this.btnEditarFornecedor.Click += new System.EventHandler(this.btnEditarFornecedor_Click);
            // 
            // btnCadastrarForne
            // 
            this.btnCadastrarForne.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCadastrarForne.Location = new System.Drawing.Point(8, 249);
            this.btnCadastrarForne.Name = "btnCadastrarForne";
            this.btnCadastrarForne.Size = new System.Drawing.Size(132, 23);
            this.btnCadastrarForne.TabIndex = 1;
            this.btnCadastrarForne.Text = "Cadastrar Fornecedor";
            this.btnCadastrarForne.UseVisualStyleBackColor = true;
            this.btnCadastrarForne.Click += new System.EventHandler(this.btnCadastrarForne_Click);
            // 
            // dgvFornecedores
            // 
            this.dgvFornecedores.AllowUserToAddRows = false;
            this.dgvFornecedores.AllowUserToDeleteRows = false;
            this.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFornecedores.Location = new System.Drawing.Point(8, 6);
            this.dgvFornecedores.MultiSelect = false;
            this.dgvFornecedores.Name = "dgvFornecedores";
            this.dgvFornecedores.ReadOnly = true;
            this.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFornecedores.Size = new System.Drawing.Size(563, 217);
            this.dgvFornecedores.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnMedRetirados);
            this.tabPage3.Controls.Add(this.btnEditar);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.rdbFuncionario);
            this.tabPage3.Controls.Add(this.rdbAdmin);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.mskAdmissao);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.mskCelular);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.mskTelefone);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.mskCpf);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.txtEmail);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.mskNasc);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.txtSenha);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.txtLogin);
            this.tabPage3.Controls.Add(this.lblNome);
            this.tabPage3.Controls.Add(this.txtNome);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(579, 303);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dados do Usuário";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnMedRetirados
            // 
            this.btnMedRetirados.Font = new System.Drawing.Font("Arial", 9F);
            this.btnMedRetirados.Location = new System.Drawing.Point(151, 257);
            this.btnMedRetirados.Name = "btnMedRetirados";
            this.btnMedRetirados.Size = new System.Drawing.Size(202, 23);
            this.btnMedRetirados.TabIndex = 13;
            this.btnMedRetirados.Text = "Medicamentos Retirados";
            this.btnMedRetirados.UseVisualStyleBackColor = true;
            this.btnMedRetirados.Click += new System.EventHandler(this.btnMedRetirados_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnEditar.Location = new System.Drawing.Point(13, 257);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.Location = new System.Drawing.Point(10, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 15);
            this.label9.TabIndex = 34;
            this.label9.Text = "Permissão";
            // 
            // rdbFuncionario
            // 
            this.rdbFuncionario.AutoSize = true;
            this.rdbFuncionario.Font = new System.Drawing.Font("Arial", 9F);
            this.rdbFuncionario.Location = new System.Drawing.Point(121, 222);
            this.rdbFuncionario.Name = "rdbFuncionario";
            this.rdbFuncionario.Size = new System.Drawing.Size(90, 19);
            this.rdbFuncionario.TabIndex = 11;
            this.rdbFuncionario.Text = "Funcionário";
            this.rdbFuncionario.UseVisualStyleBackColor = true;
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Checked = true;
            this.rdbAdmin.Font = new System.Drawing.Font("Arial", 9F);
            this.rdbAdmin.Location = new System.Drawing.Point(13, 222);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(102, 19);
            this.rdbAdmin.TabIndex = 10;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Administrador";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.Location = new System.Drawing.Point(391, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Data de admissão";
            // 
            // mskAdmissao
            // 
            this.mskAdmissao.Font = new System.Drawing.Font("Arial", 10F);
            this.mskAdmissao.Location = new System.Drawing.Point(394, 156);
            this.mskAdmissao.Mask = "##/##/####";
            this.mskAdmissao.Name = "mskAdmissao";
            this.mskAdmissao.Size = new System.Drawing.Size(75, 23);
            this.mskAdmissao.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.Location = new System.Drawing.Point(123, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Celular";
            // 
            // mskCelular
            // 
            this.mskCelular.Font = new System.Drawing.Font("Arial", 10F);
            this.mskCelular.Location = new System.Drawing.Point(126, 156);
            this.mskCelular.Mask = "(##)#####-####";
            this.mskCelular.Name = "mskCelular";
            this.mskCelular.Size = new System.Drawing.Size(97, 23);
            this.mskCelular.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F);
            this.label6.Location = new System.Drawing.Point(10, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Arial", 10F);
            this.mskTelefone.Location = new System.Drawing.Point(13, 156);
            this.mskTelefone.Mask = "(##)####-####";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(87, 23);
            this.mskTelefone.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.Location = new System.Drawing.Point(358, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "CPF";
            // 
            // mskCpf
            // 
            this.mskCpf.Culture = new System.Globalization.CultureInfo("en-US");
            this.mskCpf.Font = new System.Drawing.Font("Arial", 10F);
            this.mskCpf.Location = new System.Drawing.Point(361, 86);
            this.mskCpf.Mask = "999.999.999-99";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(97, 23);
            this.mskCpf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.Location = new System.Drawing.Point(247, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10F);
            this.txtEmail.Location = new System.Drawing.Point(250, 156);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(120, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.Location = new System.Drawing.Point(211, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de Nascimento";
            // 
            // mskNasc
            // 
            this.mskNasc.Font = new System.Drawing.Font("Arial", 10F);
            this.mskNasc.Location = new System.Drawing.Point(214, 86);
            this.mskNasc.Mask = "##/##/####";
            this.mskNasc.Name = "mskNasc";
            this.mskNasc.Size = new System.Drawing.Size(72, 23);
            this.mskNasc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.Location = new System.Drawing.Point(123, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSenha.Location = new System.Drawing.Point(126, 29);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(97, 23);
            this.txtSenha.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Arial", 10F);
            this.txtLogin.Location = new System.Drawing.Point(13, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(97, 23);
            this.txtLogin.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9F);
            this.lblNome.Location = new System.Drawing.Point(10, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNome.Location = new System.Drawing.Point(13, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(145, 23);
            this.txtNome.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 337);
            this.Controls.Add(this.tbcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentos)).EndInit();
            this.tbpFuncionarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.tbpFornecedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFornecedores)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpMedicamentos;
        private System.Windows.Forms.TabPage tbpFuncionarios;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dgvMedicamentos;
        private System.Windows.Forms.Button btnEditarMed;
        private System.Windows.Forms.Button btnCadastrarMed;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnEncomenda;
        private System.Windows.Forms.TabPage tbpFornecedor;
        private System.Windows.Forms.Button btnEditarFornecedor;
        private System.Windows.Forms.Button btnCadastrarForne;
        private System.Windows.Forms.DataGridView dgvFornecedores;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskNasc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskAdmissao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mskCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbFuncionario;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnMedRetirados;
    }
}
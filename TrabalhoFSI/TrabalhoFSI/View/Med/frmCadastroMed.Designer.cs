namespace TrabalhoFSI.View
{
    partial class frmCadastroMed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMed));
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.lblNomeMed = new System.Windows.Forms.Label();
            this.txtDiluicaoMed = new System.Windows.Forms.TextBox();
            this.lblDiluicaoMed = new System.Windows.Forms.Label();
            this.lblDoseMed = new System.Windows.Forms.Label();
            this.txtDoseMed = new System.Windows.Forms.TextBox();
            this.lblArmazenaMed = new System.Windows.Forms.Label();
            this.txtArmazenaMed = new System.Windows.Forms.TextBox();
            this.lblnfusaoMed = new System.Windows.Forms.Label();
            this.txtInfusaoMed = new System.Windows.Forms.TextBox();
            this.lblIncompaMed = new System.Windows.Forms.Label();
            this.txtIncompaMed = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblQtdeMed = new System.Windows.Forms.Label();
            this.txtQtdeMed = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblIdFornecedor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNomeMed
            // 
            resources.ApplyResources(this.txtNomeMed, "txtNomeMed");
            this.txtNomeMed.Name = "txtNomeMed";
            // 
            // lblNomeMed
            // 
            resources.ApplyResources(this.lblNomeMed, "lblNomeMed");
            this.lblNomeMed.Name = "lblNomeMed";
            // 
            // txtDiluicaoMed
            // 
            resources.ApplyResources(this.txtDiluicaoMed, "txtDiluicaoMed");
            this.txtDiluicaoMed.Name = "txtDiluicaoMed";
            // 
            // lblDiluicaoMed
            // 
            resources.ApplyResources(this.lblDiluicaoMed, "lblDiluicaoMed");
            this.lblDiluicaoMed.Name = "lblDiluicaoMed";
            // 
            // lblDoseMed
            // 
            resources.ApplyResources(this.lblDoseMed, "lblDoseMed");
            this.lblDoseMed.Name = "lblDoseMed";
            // 
            // txtDoseMed
            // 
            resources.ApplyResources(this.txtDoseMed, "txtDoseMed");
            this.txtDoseMed.Name = "txtDoseMed";
            // 
            // lblArmazenaMed
            // 
            resources.ApplyResources(this.lblArmazenaMed, "lblArmazenaMed");
            this.lblArmazenaMed.Name = "lblArmazenaMed";
            // 
            // txtArmazenaMed
            // 
            resources.ApplyResources(this.txtArmazenaMed, "txtArmazenaMed");
            this.txtArmazenaMed.Name = "txtArmazenaMed";
            // 
            // lblnfusaoMed
            // 
            resources.ApplyResources(this.lblnfusaoMed, "lblnfusaoMed");
            this.lblnfusaoMed.Name = "lblnfusaoMed";
            // 
            // txtInfusaoMed
            // 
            resources.ApplyResources(this.txtInfusaoMed, "txtInfusaoMed");
            this.txtInfusaoMed.Name = "txtInfusaoMed";
            // 
            // lblIncompaMed
            // 
            resources.ApplyResources(this.lblIncompaMed, "lblIncompaMed");
            this.lblIncompaMed.Name = "lblIncompaMed";
            // 
            // txtIncompaMed
            // 
            resources.ApplyResources(this.txtIncompaMed, "txtIncompaMed");
            this.txtIncompaMed.Name = "txtIncompaMed";
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(this.btnCadastrar, "btnCadastrar");
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblQtdeMed
            // 
            resources.ApplyResources(this.lblQtdeMed, "lblQtdeMed");
            this.lblQtdeMed.Name = "lblQtdeMed";
            // 
            // txtQtdeMed
            // 
            resources.ApplyResources(this.txtQtdeMed, "txtQtdeMed");
            this.txtQtdeMed.Name = "txtQtdeMed";
            this.txtQtdeMed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeMed_KeyPress);
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.Name = "lblId";
            // 
            // txtId
            // 
            resources.ApplyResources(this.txtId, "txtId");
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbFornecedor, "cmbFornecedor");
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedor_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            resources.ApplyResources(this.lblFornecedor, "lblFornecedor");
            this.lblFornecedor.Name = "lblFornecedor";
            // 
            // lblIdFornecedor
            // 
            resources.ApplyResources(this.lblIdFornecedor, "lblIdFornecedor");
            this.lblIdFornecedor.Name = "lblIdFornecedor";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtPreco
            // 
            resources.ApplyResources(this.txtPreco, "txtPreco");
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // frmCadastroMed
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblIdFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblQtdeMed);
            this.Controls.Add(this.txtQtdeMed);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblIncompaMed);
            this.Controls.Add(this.txtIncompaMed);
            this.Controls.Add(this.lblnfusaoMed);
            this.Controls.Add(this.txtInfusaoMed);
            this.Controls.Add(this.lblArmazenaMed);
            this.Controls.Add(this.txtArmazenaMed);
            this.Controls.Add(this.lblDoseMed);
            this.Controls.Add(this.txtDoseMed);
            this.Controls.Add(this.lblDiluicaoMed);
            this.Controls.Add(this.txtDiluicaoMed);
            this.Controls.Add(this.lblNomeMed);
            this.Controls.Add(this.txtNomeMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCadastroMed";
            this.Load += new System.EventHandler(this.frmCadastroMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.Label lblNomeMed;
        private System.Windows.Forms.TextBox txtDiluicaoMed;
        private System.Windows.Forms.Label lblDiluicaoMed;
        private System.Windows.Forms.Label lblDoseMed;
        private System.Windows.Forms.TextBox txtDoseMed;
        private System.Windows.Forms.Label lblArmazenaMed;
        private System.Windows.Forms.TextBox txtArmazenaMed;
        private System.Windows.Forms.Label lblnfusaoMed;
        private System.Windows.Forms.TextBox txtInfusaoMed;
        private System.Windows.Forms.Label lblIncompaMed;
        private System.Windows.Forms.TextBox txtIncompaMed;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblQtdeMed;
        private System.Windows.Forms.TextBox txtQtdeMed;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblIdFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
    }
}
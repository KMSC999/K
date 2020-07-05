namespace TrabalhoFSI.View.Med
{
    partial class frmRetiradaMed
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
            this.lblNomeMed = new System.Windows.Forms.Label();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.lblQtde = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomeMed
            // 
            this.lblNomeMed.AutoSize = true;
            this.lblNomeMed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeMed.Location = new System.Drawing.Point(9, 18);
            this.lblNomeMed.Name = "lblNomeMed";
            this.lblNomeMed.Size = new System.Drawing.Size(135, 15);
            this.lblNomeMed.TabIndex = 1;
            this.lblNomeMed.Text = "Nome do Medicamento";
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMed.Location = new System.Drawing.Point(12, 34);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.ReadOnly = true;
            this.txtNomeMed.Size = new System.Drawing.Size(100, 21);
            this.txtNomeMed.TabIndex = 2;
            // 
            // txtQtde
            // 
            this.txtQtde.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(151, 34);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(86, 21);
            this.txtQtde.TabIndex = 4;
            this.txtQtde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtde_KeyPress);
            // 
            // lblQtde
            // 
            this.lblQtde.AutoSize = true;
            this.lblQtde.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtde.Location = new System.Drawing.Point(148, 18);
            this.lblQtde.Name = "lblQtde";
            this.lblQtde.Size = new System.Drawing.Size(147, 15);
            this.lblQtde.TabIndex = 3;
            this.lblQtde.Text = "Quantidade a ser retirada";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(12, 72);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(100, 23);
            this.btnRetirar.TabIndex = 5;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // frmRetiradaMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 107);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.txtQtde);
            this.Controls.Add(this.lblQtde);
            this.Controls.Add(this.txtNomeMed);
            this.Controls.Add(this.lblNomeMed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRetiradaMed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRetiradaMed_FormClosed);
            this.Load += new System.EventHandler(this.frmRetiradaMed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeMed;
        private System.Windows.Forms.TextBox txtNomeMed;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label lblQtde;
        private System.Windows.Forms.Button btnRetirar;
    }
}
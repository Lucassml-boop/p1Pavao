namespace P1
{
    partial class CadEmpregados
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCodEmpregado = new System.Windows.Forms.TextBox();
            this.txtEmpregado = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.cboCodSetor = new System.Windows.Forms.ComboBox();
            this.lblcodsetor = new System.Windows.Forms.Label();
            this.btgravar = new System.Windows.Forms.Button();
            this.btSetores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cód Empregado:";

            // txtCodEmpregado
            this.txtCodEmpregado.Location = new System.Drawing.Point(140, 27);
            this.txtCodEmpregado.Name = "txtCodEmpregado";
            this.txtCodEmpregado.Size = new System.Drawing.Size(100, 23);
            this.txtCodEmpregado.TabIndex = 1;
            this.txtCodEmpregado.ReadOnly = true;

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";

            // txtEmpregado
            this.txtEmpregado.Location = new System.Drawing.Point(140, 62);
            this.txtEmpregado.Name = "txtEmpregado";
            this.txtEmpregado.Size = new System.Drawing.Size(200, 23);
            this.txtEmpregado.TabIndex = 3;

            // labelEndereco
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(30, 100);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(60, 15);
            this.labelEndereco.TabIndex = 13;
            this.labelEndereco.Text = "Endereço:";

            // txtEndereco
            this.txtEndereco.Location = new System.Drawing.Point(140, 97);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(200, 23);
            this.txtEndereco.TabIndex = 14;

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bairro:";

            // txtBairro
            this.txtBairro.Location = new System.Drawing.Point(140, 132);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 23);
            this.txtBairro.TabIndex = 5;

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cidade:";

            // txtCidade
            this.txtCidade.Location = new System.Drawing.Point(140, 167);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 23);
            this.txtCidade.TabIndex = 7;

            // labelCargo
            this.labelCargo.AutoSize = true;
            this.labelCargo.Location = new System.Drawing.Point(30, 205);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(42, 15);
            this.labelCargo.TabIndex = 15;
            this.labelCargo.Text = "Cargo:";

            // txtCargo
            this.txtCargo.Location = new System.Drawing.Point(140, 202);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(200, 23);
            this.txtCargo.TabIndex = 16;

            // labelSalario
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(30, 240);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(46, 15);
            this.labelSalario.TabIndex = 17;
            this.labelSalario.Text = "Salário:";

            // txtSalario
            this.txtSalario.Location = new System.Drawing.Point(140, 237);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(200, 23);
            this.txtSalario.TabIndex = 18;

            // label5
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Setor:";

            // cboCodSetor
            this.cboCodSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCodSetor.FormattingEnabled = true;
            this.cboCodSetor.Location = new System.Drawing.Point(140, 272);
            this.cboCodSetor.Name = "cboCodSetor";
            this.cboCodSetor.Size = new System.Drawing.Size(150, 23);
            this.cboCodSetor.TabIndex = 9;
            this.cboCodSetor.SelectedIndexChanged += new System.EventHandler(this.CboCodSetor_SelectedIndexChanged);

            // lblcodsetor
            this.lblcodsetor.AutoSize = true;
            this.lblcodsetor.Location = new System.Drawing.Point(300, 275);
            this.lblcodsetor.Name = "lblcodsetor";
            this.lblcodsetor.Size = new System.Drawing.Size(16, 15);
            this.lblcodsetor.TabIndex = 10;
            this.lblcodsetor.Text = "...";

            // btgravar
            this.btgravar.Location = new System.Drawing.Point(140, 315);
            this.btgravar.Name = "btgravar";
            this.btgravar.Size = new System.Drawing.Size(75, 40);
            this.btgravar.TabIndex = 11;
            this.btgravar.Text = "Gravar";
            this.btgravar.UseVisualStyleBackColor = true;
            this.btgravar.Click += new System.EventHandler(this.Btgravar_Click);

            // btSetores
            this.btSetores.Location = new System.Drawing.Point(265, 315);
            this.btSetores.Name = "btSetores";
            this.btSetores.Size = new System.Drawing.Size(95, 40);
            this.btSetores.TabIndex = 12;
            this.btSetores.Text = "Ir para Setores";
            this.btSetores.UseVisualStyleBackColor = true;
            this.btSetores.Click += new System.EventHandler(this.BtSetores_Click);

            // CadEmpregados
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.btSetores);
            this.Controls.Add(this.btgravar);
            this.Controls.Add(this.lblcodsetor);
            this.Controls.Add(this.cboCodSetor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.labelCargo);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.txtEmpregado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodEmpregado);
            this.Controls.Add(this.label1);
            this.Name = "CadEmpregados";
            this.Text = "Cadastro de Empregados";
            this.Load += new System.EventHandler(this.CadEmpregados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCodEmpregado;
        private System.Windows.Forms.TextBox txtEmpregado;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox cboCodSetor;
        private System.Windows.Forms.Label lblcodsetor;
        private System.Windows.Forms.Button btgravar;
        private System.Windows.Forms.Button btSetores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCargo;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label label5;
    }
}
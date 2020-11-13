namespace concept_architecture
{
    partial class Tela_funcionarios
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label id_funcLabel;
            System.Windows.Forms.Label nome_funcLabel;
            System.Windows.Forms.Label dtnasc_funcLabel;
            System.Windows.Forms.Label rg_funcLabel;
            System.Windows.Forms.Label cpf_funcLabel;
            System.Windows.Forms.Label tel_funcLabel;
            System.Windows.Forms.Label label1;
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtDatanascimento = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exibir = new System.Windows.Forms.Button();
            this.txt_Status = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            id_funcLabel = new System.Windows.Forms.Label();
            nome_funcLabel = new System.Windows.Forms.Label();
            dtnasc_funcLabel = new System.Windows.Forms.Label();
            rg_funcLabel = new System.Windows.Forms.Label();
            cpf_funcLabel = new System.Windows.Forms.Label();
            tel_funcLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 332);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 18);
            label2.TabIndex = 66;
            label2.Text = "Título de eleitor";
            // 
            // id_funcLabel
            // 
            id_funcLabel.AutoSize = true;
            id_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_funcLabel.Location = new System.Drawing.Point(12, 105);
            id_funcLabel.Name = "id_funcLabel";
            id_funcLabel.Size = new System.Drawing.Size(22, 18);
            id_funcLabel.TabIndex = 47;
            id_funcLabel.Text = "ID";
            // 
            // nome_funcLabel
            // 
            nome_funcLabel.AutoSize = true;
            nome_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nome_funcLabel.Location = new System.Drawing.Point(12, 143);
            nome_funcLabel.Name = "nome_funcLabel";
            nome_funcLabel.Size = new System.Drawing.Size(48, 18);
            nome_funcLabel.TabIndex = 49;
            nome_funcLabel.Text = "Nome";
            // 
            // dtnasc_funcLabel
            // 
            dtnasc_funcLabel.AutoSize = true;
            dtnasc_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtnasc_funcLabel.Location = new System.Drawing.Point(12, 180);
            dtnasc_funcLabel.Name = "dtnasc_funcLabel";
            dtnasc_funcLabel.Size = new System.Drawing.Size(88, 18);
            dtnasc_funcLabel.TabIndex = 51;
            dtnasc_funcLabel.Text = "Nascimento";
            // 
            // rg_funcLabel
            // 
            rg_funcLabel.AutoSize = true;
            rg_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rg_funcLabel.Location = new System.Drawing.Point(12, 218);
            rg_funcLabel.Name = "rg_funcLabel";
            rg_funcLabel.Size = new System.Drawing.Size(28, 18);
            rg_funcLabel.TabIndex = 53;
            rg_funcLabel.Text = "RG";
            rg_funcLabel.Click += new System.EventHandler(this.rg_funcLabel_Click);
            // 
            // cpf_funcLabel
            // 
            cpf_funcLabel.AutoSize = true;
            cpf_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_funcLabel.Location = new System.Drawing.Point(12, 256);
            cpf_funcLabel.Name = "cpf_funcLabel";
            cpf_funcLabel.Size = new System.Drawing.Size(34, 18);
            cpf_funcLabel.TabIndex = 54;
            cpf_funcLabel.Text = "CPF";
            cpf_funcLabel.Click += new System.EventHandler(this.cpf_funcLabel_Click);
            // 
            // tel_funcLabel
            // 
            tel_funcLabel.AutoSize = true;
            tel_funcLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tel_funcLabel.Location = new System.Drawing.Point(12, 294);
            tel_funcLabel.Name = "tel_funcLabel";
            tel_funcLabel.Size = new System.Drawing.Size(63, 18);
            tel_funcLabel.TabIndex = 55;
            tel_funcLabel.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 35);
            this.label3.TabIndex = 67;
            this.label3.Text = "Cadastro de funcionários";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(141, 330);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(328, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // txtCpf
            // 
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(141, 254);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(328, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(141, 216);
            this.txtRg.Mask = "000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(328, 20);
            this.txtRg.TabIndex = 4;
            this.txtRg.ValidatingType = typeof(System.DateTime);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(141, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(143, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.id_funcTextBox_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(141, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(328, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(141, 292);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(328, 20);
            this.txtTelefone.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::concept_architecture.Properties.Resources.search;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(689, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 74);
            this.button5.TabIndex = 71;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Location = new System.Drawing.Point(689, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 74);
            this.button3.TabIndex = 70;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::concept_architecture.Properties.Resources.lixo;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(579, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 74);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(579, 123);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 72);
            this.btnAdicionar.TabIndex = 68;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatanascimento.Font = new System.Drawing.Font("Bahnschrift Light SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatanascimento.Location = new System.Drawing.Point(141, 179);
            this.txtDatanascimento.Mask = "0000/00/00";
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(328, 19);
            this.txtDatanascimento.TabIndex = 3;
            this.txtDatanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(27, 410);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 153);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exibir
            // 
            this.exibir.BackColor = System.Drawing.Color.Transparent;
            this.exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibir.ForeColor = System.Drawing.Color.Gray;
            this.exibir.Location = new System.Drawing.Point(686, 350);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(78, 39);
            this.exibir.TabIndex = 80;
            this.exibir.Text = "exibir";
            this.exibir.UseVisualStyleBackColor = false;
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // txt_Status
            // 
            this.txt_Status.BackColor = System.Drawing.Color.White;
            this.txt_Status.Enabled = false;
            this.txt_Status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_Status.FormattingEnabled = true;
            this.txt_Status.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txt_Status.Location = new System.Drawing.Point(141, 368);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(328, 21);
            this.txt_Status.TabIndex = 81;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 371);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 18);
            label1.TabIndex = 82;
            label1.Text = "Status";
            // 
            // Tela_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(label1);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(id_funcLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(nome_funcLabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(dtnasc_funcLabel);
            this.Controls.Add(rg_funcLabel);
            this.Controls.Add(cpf_funcLabel);
            this.Controls.Add(tel_funcLabel);
            this.Controls.Add(this.txtTelefone);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_funcionarios";
            this.Text = "tela_func";
            this.Load += new System.EventHandler(this.Tela_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.MaskedTextBox txtDatanascimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exibir;
        private System.Windows.Forms.ComboBox txt_Status;
    }
}
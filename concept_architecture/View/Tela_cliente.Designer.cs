namespace concept_architecture
{
    partial class Tela_cliente
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
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label dtnasc_clienLabel;
            System.Windows.Forms.Label rg_clienLabel;
            System.Windows.Forms.Label cpf_clienLabel;
            System.Windows.Forms.Label cnpj_clienLabel;
            System.Windows.Forms.Label email_clienLabel;
            System.Windows.Forms.Label nom_clienLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label idAgendamento;
            this.editar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfcnpj = new System.Windows.Forms.TextBox();
            this.txtNumerocasa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pesquisar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.entityCommand2 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.txtEstado = new System.Windows.Forms.ComboBox();
            this.exibir = new System.Windows.Forms.Button();
            this.txtDatanascimento = new System.Windows.Forms.DateTimePicker();
            this.Id_Agendamento = new System.Windows.Forms.TextBox();
            this.emailCliente = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dtnasc_clienLabel = new System.Windows.Forms.Label();
            rg_clienLabel = new System.Windows.Forms.Label();
            cpf_clienLabel = new System.Windows.Forms.Label();
            cnpj_clienLabel = new System.Windows.Forms.Label();
            email_clienLabel = new System.Windows.Forms.Label();
            nom_clienLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            idAgendamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(40, 343);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(54, 18);
            label6.TabIndex = 50;
            label6.Text = "Estado";
            label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(40, 314);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(70, 18);
            label5.TabIndex = 47;
            label5.Text = "Endereço";
            label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(40, 288);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 18);
            label3.TabIndex = 45;
            label3.Text = "CEP";
            label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(39, 262);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 18);
            label2.TabIndex = 43;
            label2.Text = "Telefone";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtnasc_clienLabel
            // 
            dtnasc_clienLabel.AutoSize = true;
            dtnasc_clienLabel.BackColor = System.Drawing.Color.Transparent;
            dtnasc_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtnasc_clienLabel.Location = new System.Drawing.Point(40, 181);
            dtnasc_clienLabel.Name = "dtnasc_clienLabel";
            dtnasc_clienLabel.Size = new System.Drawing.Size(88, 18);
            dtnasc_clienLabel.TabIndex = 30;
            dtnasc_clienLabel.Text = "Nascimento";
            dtnasc_clienLabel.Click += new System.EventHandler(this.dtnasc_clienLabel_Click);
            // 
            // rg_clienLabel
            // 
            rg_clienLabel.AutoSize = true;
            rg_clienLabel.BackColor = System.Drawing.Color.Transparent;
            rg_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rg_clienLabel.Location = new System.Drawing.Point(40, 154);
            rg_clienLabel.Name = "rg_clienLabel";
            rg_clienLabel.Size = new System.Drawing.Size(41, 18);
            rg_clienLabel.TabIndex = 32;
            rg_clienLabel.Text = "RG: *";
            rg_clienLabel.Click += new System.EventHandler(this.rg_clienLabel_Click);
            // 
            // cpf_clienLabel
            // 
            cpf_clienLabel.AutoSize = true;
            cpf_clienLabel.BackColor = System.Drawing.Color.Transparent;
            cpf_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cpf_clienLabel.Location = new System.Drawing.Point(40, 234);
            cpf_clienLabel.Name = "cpf_clienLabel";
            cpf_clienLabel.Size = new System.Drawing.Size(84, 18);
            cpf_clienLabel.TabIndex = 34;
            cpf_clienLabel.Text = "CPF/CNPJ: ";
            cpf_clienLabel.Click += new System.EventHandler(this.cpf_clienLabel_Click);
            // 
            // cnpj_clienLabel
            // 
            cnpj_clienLabel.AutoSize = true;
            cnpj_clienLabel.BackColor = System.Drawing.Color.Transparent;
            cnpj_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cnpj_clienLabel.Location = new System.Drawing.Point(40, 371);
            cnpj_clienLabel.Name = "cnpj_clienLabel";
            cnpj_clienLabel.Size = new System.Drawing.Size(99, 18);
            cnpj_clienLabel.TabIndex = 36;
            cnpj_clienLabel.Text = "Número Casa";
            cnpj_clienLabel.Click += new System.EventHandler(this.cnpj_clienLabel_Click);
            // 
            // email_clienLabel
            // 
            email_clienLabel.AutoSize = true;
            email_clienLabel.BackColor = System.Drawing.Color.Transparent;
            email_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_clienLabel.Location = new System.Drawing.Point(40, 208);
            email_clienLabel.Name = "email_clienLabel";
            email_clienLabel.Size = new System.Drawing.Size(66, 18);
            email_clienLabel.TabIndex = 38;
            email_clienLabel.Text = "E-mail: *";
            email_clienLabel.Click += new System.EventHandler(this.email_clienLabel_Click);
            // 
            // nom_clienLabel
            // 
            nom_clienLabel.AutoSize = true;
            nom_clienLabel.BackColor = System.Drawing.Color.Transparent;
            nom_clienLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nom_clienLabel.Location = new System.Drawing.Point(40, 127);
            nom_clienLabel.Name = "nom_clienLabel";
            nom_clienLabel.Size = new System.Drawing.Size(61, 18);
            nom_clienLabel.TabIndex = 40;
            nom_clienLabel.Text = "Nome: *";
            nom_clienLabel.Click += new System.EventHandler(this.nom_clienLabel_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(40, 78);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(22, 18);
            label4.TabIndex = 57;
            label4.Text = "ID";
            label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // editar
            // 
            this.editar.BackColor = System.Drawing.Color.White;
            this.editar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editar.Location = new System.Drawing.Point(655, 234);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 74);
            this.editar.TabIndex = 53;
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.button3_Click);
            // 
            // excluir
            // 
            this.excluir.BackColor = System.Drawing.Color.White;
            this.excluir.BackgroundImage = global::concept_architecture.Properties.Resources.lixo;
            this.excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.excluir.Location = new System.Drawing.Point(545, 234);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 74);
            this.excluir.TabIndex = 52;
            this.excluir.UseVisualStyleBackColor = false;
            this.excluir.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(545, 131);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 72);
            this.btnAdicionar.TabIndex = 51;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEndereco.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(154, 313);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(293, 20);
            this.txtEndereco.TabIndex = 9;
            this.txtEndereco.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCep
            // 
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCep.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(154, 287);
            this.txtCep.Mask = "00000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(293, 20);
            this.txtCep.TabIndex = 8;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(154, 261);
            this.txtTelefone.Mask = "(00)000000000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(293, 20);
            this.txtTelefone.TabIndex = 7;
            this.txtTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 35);
            this.label1.TabIndex = 42;
            this.label1.Text = "Agendamento de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCpfcnpj
            // 
            this.txtCpfcnpj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpfcnpj.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpfcnpj.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfcnpj.Location = new System.Drawing.Point(154, 233);
            this.txtCpfcnpj.Name = "txtCpfcnpj";
            this.txtCpfcnpj.Size = new System.Drawing.Size(293, 20);
            this.txtCpfcnpj.TabIndex = 6;
            this.txtCpfcnpj.TextChanged += new System.EventHandler(this.cpf_clienTextBox_TextChanged);
            // 
            // txtNumerocasa
            // 
            this.txtNumerocasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumerocasa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumerocasa.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumerocasa.Location = new System.Drawing.Point(155, 370);
            this.txtNumerocasa.Name = "txtNumerocasa";
            this.txtNumerocasa.Size = new System.Drawing.Size(293, 20);
            this.txtNumerocasa.TabIndex = 11;
            this.txtNumerocasa.TextChanged += new System.EventHandler(this.cnpj_clienTextBox_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(154, 207);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(293, 20);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextChanged += new System.EventHandler(this.email_clienTextBox_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNome.Location = new System.Drawing.Point(154, 130);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(293, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.nom_clienTextBox_TextChanged);
            // 
            // pesquisar
            // 
            this.pesquisar.BackColor = System.Drawing.Color.White;
            this.pesquisar.BackgroundImage = global::concept_architecture.Properties.Resources.search;
            this.pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pesquisar.Location = new System.Drawing.Point(655, 131);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(75, 74);
            this.pesquisar.TabIndex = 55;
            this.pesquisar.UseVisualStyleBackColor = false;
            this.pesquisar.Click += new System.EventHandler(this.pesquisar_Click);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtID.Location = new System.Drawing.Point(154, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtRg
            // 
            this.txtRg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRg.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRg.Location = new System.Drawing.Point(154, 155);
            this.txtRg.Mask = "000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(293, 20);
            this.txtRg.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(72, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 115);
            this.dataGridView1.TabIndex = 59;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // entityCommand2
            // 
            this.entityCommand2.CommandTimeout = 0;
            this.entityCommand2.CommandTree = null;
            this.entityCommand2.Connection = null;
            this.entityCommand2.EnablePlanCaching = true;
            this.entityCommand2.Transaction = null;
            // 
            // txtEstado
            // 
            this.txtEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtEstado.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.FormattingEnabled = true;
            this.txtEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá",
            "Amazonas",
            "Bahia",
            "Ceará",
            "Distrito Federal",
            "Espírito Santo",
            "Goiás",
            "Maranhão",
            "Mato Grosso",
            "Mato Grosso do Sul",
            "Minas Gerais",
            "Pará",
            "Paraíba",
            "Paraná",
            "Pernambuco",
            "Piauí",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.txtEstado.Location = new System.Drawing.Point(154, 338);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(293, 27);
            this.txtEstado.TabIndex = 10;
            // 
            // exibir
            // 
            this.exibir.BackColor = System.Drawing.Color.Transparent;
            this.exibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exibir.ForeColor = System.Drawing.Color.Gray;
            this.exibir.Location = new System.Drawing.Point(652, 409);
            this.exibir.Name = "exibir";
            this.exibir.Size = new System.Drawing.Size(78, 39);
            this.exibir.TabIndex = 79;
            this.exibir.Text = "exibir";
            this.exibir.UseVisualStyleBackColor = false;
            this.exibir.Click += new System.EventHandler(this.exibir_Click);
            // 
            // txtDatanascimento
            // 
            this.txtDatanascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDatanascimento.Location = new System.Drawing.Point(155, 181);
            this.txtDatanascimento.Name = "txtDatanascimento";
            this.txtDatanascimento.Size = new System.Drawing.Size(292, 20);
            this.txtDatanascimento.TabIndex = 80;
            // 
            // idAgendamento
            // 
            idAgendamento.AutoSize = true;
            idAgendamento.BackColor = System.Drawing.Color.Transparent;
            idAgendamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAgendamento.Location = new System.Drawing.Point(41, 104);
            idAgendamento.Name = "idAgendamento";
            idAgendamento.Size = new System.Drawing.Size(118, 18);
            idAgendamento.TabIndex = 84;
            idAgendamento.Text = "Agendamento ID";
            // 
            // Id_Agendamento
            // 
            this.Id_Agendamento.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_Agendamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Agendamento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Agendamento.Enabled = false;
            this.Id_Agendamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Agendamento.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Id_Agendamento.Location = new System.Drawing.Point(366, 101);
            this.Id_Agendamento.Name = "Id_Agendamento";
            this.Id_Agendamento.Size = new System.Drawing.Size(82, 20);
            this.Id_Agendamento.TabIndex = 83;
            this.Id_Agendamento.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // emailCliente
            // 
            this.emailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailCliente.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCliente.ForeColor = System.Drawing.SystemColors.MenuText;
            this.emailCliente.Location = new System.Drawing.Point(154, 101);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(206, 20);
            this.emailCliente.TabIndex = 85;
            this.emailCliente.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Tela_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(idAgendamento);
            this.Controls.Add(this.Id_Agendamento);
            this.Controls.Add(this.txtDatanascimento);
            this.Controls.Add(this.exibir);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pesquisar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(label6);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(label5);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(dtnasc_clienLabel);
            this.Controls.Add(rg_clienLabel);
            this.Controls.Add(cpf_clienLabel);
            this.Controls.Add(this.txtCpfcnpj);
            this.Controls.Add(cnpj_clienLabel);
            this.Controls.Add(this.txtNumerocasa);
            this.Controls.Add(email_clienLabel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(nom_clienLabel);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_cliente";
            this.Text = "tela_Cliente";
            this.Load += new System.EventHandler(this.Tela_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCpfcnpj;
        private System.Windows.Forms.TextBox txtNumerocasa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button pesquisar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand2;
        private System.Windows.Forms.ComboBox txtEstado;
        private System.Windows.Forms.Button exibir;
        private System.Windows.Forms.DateTimePicker txtDatanascimento;
        private System.Windows.Forms.TextBox Id_Agendamento;
        private System.Windows.Forms.TextBox emailCliente;
    }
}
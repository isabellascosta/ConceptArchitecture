namespace concept_architecture
{
    partial class Tela_orcamento
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label val_orcLabel;
            System.Windows.Forms.Label formp_orcLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPlanta = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExibir = new System.Windows.Forms.Button();
            this.CpfCliente = new System.Windows.Forms.TextBox();
            this.Id_Cliente = new System.Windows.Forms.TextBox();
            this.txtProjeto = new System.Windows.Forms.TextBox();
            this.ID_Funcionario = new System.Windows.Forms.TextBox();
            this.txtNomeAquiteto = new System.Windows.Forms.TextBox();
            this.txtPrazo = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            val_orcLabel = new System.Windows.Forms.Label();
            formp_orcLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(12, 192);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 18);
            label3.TabIndex = 20;
            label3.Text = "Prazo de entrega";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(12, 270);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 18);
            label2.TabIndex = 19;
            label2.Text = "Valor da Planta";
            // 
            // val_orcLabel
            // 
            val_orcLabel.AutoSize = true;
            val_orcLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            val_orcLabel.Location = new System.Drawing.Point(12, 344);
            val_orcLabel.Name = "val_orcLabel";
            val_orcLabel.Size = new System.Drawing.Size(74, 18);
            val_orcLabel.TabIndex = 17;
            val_orcLabel.Text = "ValorTotal";
            // 
            // formp_orcLabel
            // 
            formp_orcLabel.AutoSize = true;
            formp_orcLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            formp_orcLabel.Location = new System.Drawing.Point(12, 237);
            formp_orcLabel.Name = "formp_orcLabel";
            formp_orcLabel.Size = new System.Drawing.Size(149, 18);
            formp_orcLabel.TabIndex = 18;
            formp_orcLabel.Text = "Forma de pagamento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(12, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(22, 18);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(12, 123);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(84, 18);
            label5.TabIndex = 105;
            label5.Text = "CPF Cliente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(12, 308);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(115, 18);
            label6.TabIndex = 107;
            label6.Text = "Valor do Projeto";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(157, 343);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(293, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPlanta
            // 
            this.txtPlanta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlanta.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlanta.Location = new System.Drawing.Point(157, 268);
            this.txtPlanta.Name = "txtPlanta";
            this.txtPlanta.Size = new System.Drawing.Size(293, 20);
            this.txtPlanta.TabIndex = 4;
            this.txtPlanta.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(157, 89);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.BackColor = System.Drawing.Color.White;
            this.btnpesquisar.BackgroundImage = global::concept_architecture.Properties.Resources.search;
            this.btnpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnpesquisar.Location = new System.Drawing.Point(635, 151);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 74);
            this.btnpesquisar.TabIndex = 75;
            this.btnpesquisar.UseVisualStyleBackColor = false;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.BackColor = System.Drawing.Color.White;
            this.btnalterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnalterar.Location = new System.Drawing.Point(635, 254);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 74);
            this.btnalterar.TabIndex = 74;
            this.btnalterar.UseVisualStyleBackColor = false;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.White;
            this.btnexcluir.BackgroundImage = global::concept_architecture.Properties.Resources.lixo;
            this.btnexcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnexcluir.Location = new System.Drawing.Point(525, 254);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 74);
            this.btnexcluir.TabIndex = 73;
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnadicionar
            // 
            this.btnadicionar.BackColor = System.Drawing.Color.White;
            this.btnadicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnadicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadicionar.Location = new System.Drawing.Point(525, 151);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(75, 72);
            this.btnadicionar.TabIndex = 72;
            this.btnadicionar.UseVisualStyleBackColor = false;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 35);
            this.label4.TabIndex = 76;
            this.label4.Text = "Orçamento";
            // 
            // txtPagamento
            // 
            this.txtPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtPagamento.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagamento.FormattingEnabled = true;
            this.txtPagamento.Items.AddRange(new object[] {
            "À vista",
            "Parcelas no carne"});
            this.txtPagamento.Location = new System.Drawing.Point(157, 228);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(293, 27);
            this.txtPagamento.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(36, 446);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 148);
            this.dataGridView1.TabIndex = 102;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.Gray;
            this.btnExibir.Location = new System.Drawing.Point(635, 391);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(78, 40);
            this.btnExibir.TabIndex = 101;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // CpfCliente
            // 
            this.CpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CpfCliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfCliente.Location = new System.Drawing.Point(157, 121);
            this.CpfCliente.Name = "CpfCliente";
            this.CpfCliente.Size = new System.Drawing.Size(197, 20);
            this.CpfCliente.TabIndex = 2;
            this.CpfCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Id_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Cliente.Enabled = false;
            this.Id_Cliente.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Cliente.Location = new System.Drawing.Point(360, 121);
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Size = new System.Drawing.Size(90, 20);
            this.Id_Cliente.TabIndex = 104;
            // 
            // txtProjeto
            // 
            this.txtProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProjeto.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjeto.Location = new System.Drawing.Point(157, 308);
            this.txtProjeto.Name = "txtProjeto";
            this.txtProjeto.Size = new System.Drawing.Size(293, 20);
            this.txtProjeto.TabIndex = 106;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(12, 154);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(70, 18);
            label7.TabIndex = 110;
            label7.Text = "Arquiteto";
            // 
            // ID_Funcionario
            // 
            this.ID_Funcionario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ID_Funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ID_Funcionario.Enabled = false;
            this.ID_Funcionario.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Funcionario.Location = new System.Drawing.Point(360, 152);
            this.ID_Funcionario.Name = "ID_Funcionario";
            this.ID_Funcionario.Size = new System.Drawing.Size(90, 20);
            this.ID_Funcionario.TabIndex = 109;
            // 
            // txtNomeAquiteto
            // 
            this.txtNomeAquiteto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAquiteto.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAquiteto.Location = new System.Drawing.Point(157, 152);
            this.txtNomeAquiteto.Name = "txtNomeAquiteto";
            this.txtNomeAquiteto.Size = new System.Drawing.Size(197, 20);
            this.txtNomeAquiteto.TabIndex = 108;
            this.txtNomeAquiteto.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // txtPrazo
            // 
            this.txtPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtPrazo.Location = new System.Drawing.Point(157, 190);
            this.txtPrazo.Name = "txtPrazo";
            this.txtPrazo.Size = new System.Drawing.Size(293, 20);
            this.txtPrazo.TabIndex = 111;
            // 
            // Tela_orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.txtPrazo);
            this.Controls.Add(label7);
            this.Controls.Add(this.ID_Funcionario);
            this.Controls.Add(this.txtNomeAquiteto);
            this.Controls.Add(this.txtProjeto);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(this.Id_Cliente);
            this.Controls.Add(this.CpfCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtPlanta);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(val_orcLabel);
            this.Controls.Add(formp_orcLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_orcamento";
            this.Text = "tela_orcam";
            this.Load += new System.EventHandler(this.Tela_orcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPlanta;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtPagamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox CpfCliente;
        private System.Windows.Forms.TextBox Id_Cliente;
        private System.Windows.Forms.TextBox txtProjeto;
        private System.Windows.Forms.TextBox ID_Funcionario;
        private System.Windows.Forms.TextBox txtNomeAquiteto;
        private System.Windows.Forms.DateTimePicker txtPrazo;
    }
}
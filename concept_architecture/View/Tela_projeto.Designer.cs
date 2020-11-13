namespace concept_architecture
{
    partial class Tela_projeto
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
            System.Windows.Forms.Label desc_pedLabel;
            System.Windows.Forms.Label data_pedLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label4;
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtFase = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CpfCliente = new System.Windows.Forms.TextBox();
            this.Id_Cliente = new System.Windows.Forms.TextBox();
            this.Id_Funcionario = new System.Windows.Forms.TextBox();
            this.txtNomeAquiteto = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            desc_pedLabel = new System.Windows.Forms.Label();
            data_pedLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(218, 271);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 35);
            label3.TabIndex = 56;
            // 
            // desc_pedLabel
            // 
            desc_pedLabel.AutoSize = true;
            desc_pedLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            desc_pedLabel.Location = new System.Drawing.Point(42, 119);
            desc_pedLabel.Name = "desc_pedLabel";
            desc_pedLabel.Size = new System.Drawing.Size(26, 18);
            desc_pedLabel.TabIndex = 48;
            desc_pedLabel.Text = "ID ";
            // 
            // data_pedLabel
            // 
            data_pedLabel.AutoSize = true;
            data_pedLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_pedLabel.Location = new System.Drawing.Point(37, 228);
            data_pedLabel.Name = "data_pedLabel";
            data_pedLabel.Size = new System.Drawing.Size(74, 18);
            data_pedLabel.TabIndex = 49;
            data_pedLabel.Text = "Descrição";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(37, 313);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 18);
            label2.TabIndex = 84;
            label2.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(37, 270);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 18);
            label5.TabIndex = 86;
            label5.Text = "Fase";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(40, 155);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(102, 18);
            label6.TabIndex = 91;
            label6.Text = "CPF do cliente";
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(168, 117);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 20);
            this.txtID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Projetos";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescricao.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(168, 228);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(293, 20);
            this.txtDescricao.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.BackgroundImage = global::concept_architecture.Properties.Resources.search;
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPesquisar.Location = new System.Drawing.Point(621, 147);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 74);
            this.btnPesquisar.TabIndex = 79;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.White;
            this.btnAlterar.BackgroundImage = global::concept_architecture.Properties.Resources.alterar;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAlterar.Location = new System.Drawing.Point(621, 250);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 74);
            this.btnAlterar.TabIndex = 78;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.White;
            this.btnExcluir.BackgroundImage = global::concept_architecture.Properties.Resources.lixo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExcluir.Location = new System.Drawing.Point(511, 250);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 74);
            this.btnExcluir.TabIndex = 77;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.BackgroundImage = global::concept_architecture.Properties.Resources.add;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionar.Location = new System.Drawing.Point(511, 147);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 72);
            this.btnAdicionar.TabIndex = 76;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtFase
            // 
            this.txtFase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFase.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFase.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFase.Location = new System.Drawing.Point(168, 265);
            this.txtFase.Name = "txtFase";
            this.txtFase.Size = new System.Drawing.Size(293, 20);
            this.txtFase.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtStatus.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.txtStatus.Location = new System.Drawing.Point(168, 309);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(293, 27);
            this.txtStatus.TabIndex = 6;
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.Transparent;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibir.ForeColor = System.Drawing.Color.Gray;
            this.btnExibir.Location = new System.Drawing.Point(621, 368);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(78, 39);
            this.btnExibir.TabIndex = 89;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(41, 450);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(658, 133);
            this.dataGridView1.TabIndex = 88;
            // 
            // CpfCliente
            // 
            this.CpfCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CpfCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CpfCliente.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfCliente.Location = new System.Drawing.Point(169, 155);
            this.CpfCliente.Name = "CpfCliente";
            this.CpfCliente.Size = new System.Drawing.Size(192, 20);
            this.CpfCliente.TabIndex = 1;
            this.CpfCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CpfCliente.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.textBox1_ChangeUICues);
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Cliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Cliente.Enabled = false;
            this.Id_Cliente.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Cliente.Location = new System.Drawing.Point(376, 155);
            this.Id_Cliente.Name = "Id_Cliente";
            this.Id_Cliente.Size = new System.Drawing.Size(85, 20);
            this.Id_Cliente.TabIndex = 92;
            // 
            // Id_Funcionario
            // 
            this.Id_Funcionario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Id_Funcionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Id_Funcionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Id_Funcionario.Enabled = false;
            this.Id_Funcionario.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_Funcionario.Location = new System.Drawing.Point(376, 190);
            this.Id_Funcionario.Name = "Id_Funcionario";
            this.Id_Funcionario.Size = new System.Drawing.Size(85, 20);
            this.Id_Funcionario.TabIndex = 95;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(40, 190);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 18);
            label4.TabIndex = 94;
            label4.Text = "Arquiteto";
            // 
            // txtNomeAquiteto
            // 
            this.txtNomeAquiteto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeAquiteto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeAquiteto.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeAquiteto.Location = new System.Drawing.Point(169, 190);
            this.txtNomeAquiteto.Name = "txtNomeAquiteto";
            this.txtNomeAquiteto.Size = new System.Drawing.Size(192, 20);
            this.txtNomeAquiteto.TabIndex = 93;
            this.txtNomeAquiteto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Tela_projeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.Id_Funcionario);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtNomeAquiteto);
            this.Controls.Add(this.Id_Cliente);
            this.Controls.Add(label6);
            this.Controls.Add(this.CpfCliente);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(label5);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtFase);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(desc_pedLabel);
            this.Controls.Add(data_pedLabel);
            this.Controls.Add(this.txtDescricao);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tela_projeto";
            this.Text = "tela_pedidos";
            this.Load += new System.EventHandler(this.Tela_projeto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtFase;
        private System.Windows.Forms.ComboBox txtStatus;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox CpfCliente;
        private System.Windows.Forms.TextBox Id_Cliente;
        private System.Windows.Forms.TextBox Id_Funcionario;
        private System.Windows.Forms.TextBox txtNomeAquiteto;
    }
}
namespace ProjetoBiblioteca
{
    partial class Alunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblVoltar = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSala = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSala = new MaterialSkin.Controls.MaterialLabel();
            this.txtSerie = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblSerie = new MaterialSkin.Controls.MaterialLabel();
            this.lblAluno = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnDeletar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.mgAlunos = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVAÇÕES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lblVoltar);
            this.groupBox6.Controls.Add(this.materialDivider3);
            this.groupBox6.Controls.Add(this.lblSair);
            this.groupBox6.Location = new System.Drawing.Point(529, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 44);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Depth = 0;
            this.lblVoltar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVoltar.Location = new System.Drawing.Point(10, 16);
            this.lblVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(50, 19);
            this.lblVoltar.TabIndex = 4;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            // 
            // materialDivider3
            // 
            this.materialDivider3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider3.Depth = 0;
            this.materialDivider3.Location = new System.Drawing.Point(66, 12);
            this.materialDivider3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider3.Name = "materialDivider3";
            this.materialDivider3.Size = new System.Drawing.Size(2, 23);
            this.materialDivider3.TabIndex = 3;
            this.materialDivider3.Text = "materialDivider1";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Depth = 0;
            this.lblSair.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSair.Location = new System.Drawing.Point(89, 16);
            this.lblSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 19);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 115);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightCoral;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtSala);
            this.groupBox2.Controls.Add(this.lblSala);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Controls.Add(this.lblSerie);
            this.groupBox2.Controls.Add(this.lblAluno);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(356, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Observações";
            // 
            // txtSala
            // 
            this.txtSala.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSala.Depth = 0;
            this.txtSala.Hint = "\"A\"";
            this.txtSala.Location = new System.Drawing.Point(316, 41);
            this.txtSala.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSala.Name = "txtSala";
            this.txtSala.PasswordChar = '\0';
            this.txtSala.SelectedText = "";
            this.txtSala.SelectionLength = 0;
            this.txtSala.SelectionStart = 0;
            this.txtSala.Size = new System.Drawing.Size(34, 23);
            this.txtSala.TabIndex = 6;
            this.txtSala.UseSystemPasswordChar = false;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Depth = 0;
            this.lblSala.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSala.Location = new System.Drawing.Point(268, 42);
            this.lblSala.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(42, 19);
            this.lblSala.TabIndex = 5;
            this.lblSala.Text = "Sala:";
            // 
            // txtSerie
            // 
            this.txtSerie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerie.Depth = 0;
            this.txtSerie.Hint = "\"3º\"";
            this.txtSerie.Location = new System.Drawing.Point(64, 41);
            this.txtSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.PasswordChar = '\0';
            this.txtSerie.SelectedText = "";
            this.txtSerie.SelectionLength = 0;
            this.txtSerie.SelectionStart = 0;
            this.txtSerie.Size = new System.Drawing.Size(34, 23);
            this.txtSerie.TabIndex = 4;
            this.txtSerie.UseSystemPasswordChar = false;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Depth = 0;
            this.lblSerie.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSerie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSerie.Location = new System.Drawing.Point(6, 42);
            this.lblSerie.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(47, 19);
            this.lblSerie.TabIndex = 3;
            this.lblSerie.Text = "Série:";
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Depth = 0;
            this.lblAluno.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAluno.Location = new System.Drawing.Point(6, 12);
            this.lblAluno.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(52, 19);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "Aluno:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "\"Renato Alves da Silva\"";
            this.txtNome.Location = new System.Drawing.Point(64, 12);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(286, 23);
            this.txtNome.TabIndex = 0;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btnAtualizar);
            this.groupBox4.Location = new System.Drawing.Point(26, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 53);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.AutoSize = true;
            this.btnAtualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAtualizar.Depth = 0;
            this.btnAtualizar.Location = new System.Drawing.Point(47, 10);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAtualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Primary = false;
            this.btnAtualizar.Size = new System.Drawing.Size(85, 36);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.AutoSize = true;
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Depth = 0;
            this.btnNovo.Location = new System.Drawing.Point(7, 10);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = false;
            this.btnNovo.Size = new System.Drawing.Size(50, 36);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.btnLimpar);
            this.groupBox5.Location = new System.Drawing.Point(503, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 53);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpar.Depth = 0;
            this.btnLimpar.Location = new System.Drawing.Point(19, 10);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(100);
            this.btnLimpar.Primary = false;
            this.btnLimpar.Size = new System.Drawing.Size(122, 36);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "LIMPAR CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox7.Controls.Add(this.materialDivider2);
            this.groupBox7.Controls.Add(this.materialDivider1);
            this.groupBox7.Controls.Add(this.btnDeletar);
            this.groupBox7.Controls.Add(this.btnSalvar);
            this.groupBox7.Controls.Add(this.btnNovo);
            this.groupBox7.Location = new System.Drawing.Point(219, 178);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(262, 53);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(175, 14);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(2, 28);
            this.materialDivider2.TabIndex = 3;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(68, 14);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 28);
            this.materialDivider1.TabIndex = 2;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletar.AutoSize = true;
            this.btnDeletar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeletar.Depth = 0;
            this.btnDeletar.Location = new System.Drawing.Point(87, 10);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDeletar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Primary = false;
            this.btnDeletar.Size = new System.Drawing.Size(70, 36);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Location = new System.Drawing.Point(191, 10);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = false;
            this.btnSalvar.Size = new System.Drawing.Size(64, 36);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Update";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // mgAlunos
            // 
            this.mgAlunos.AllowUserToAddRows = false;
            this.mgAlunos.AllowUserToDeleteRows = false;
            this.mgAlunos.AllowUserToResizeRows = false;
            this.mgAlunos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.SERIE,
            this.SALA,
            this.OBSERVAÇÕES});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgAlunos.EnableHeadersVisualStyles = false;
            this.mgAlunos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.Location = new System.Drawing.Point(26, 237);
            this.mgAlunos.Name = "mgAlunos";
            this.mgAlunos.ReadOnly = true;
            this.mgAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAlunos.Size = new System.Drawing.Size(641, 150);
            this.mgAlunos.TabIndex = 9;
            this.mgAlunos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mgAlunos_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 61.6727F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "Nome";
            this.NOME.FillWeight = 240.2455F;
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            // 
            // SERIE
            // 
            this.SERIE.DataPropertyName = "Serie";
            this.SERIE.FillWeight = 38.07106F;
            this.SERIE.HeaderText = "SÉRIE";
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            // 
            // SALA
            // 
            this.SALA.DataPropertyName = "Sala";
            this.SALA.FillWeight = 37.33865F;
            this.SALA.HeaderText = "SALA";
            this.SALA.Name = "SALA";
            this.SALA.ReadOnly = true;
            // 
            // OBSERVAÇÕES
            // 
            this.OBSERVAÇÕES.DataPropertyName = "Observacoes";
            this.OBSERVAÇÕES.FillWeight = 122.672F;
            this.OBSERVAÇÕES.HeaderText = "OBSERVAÇÕES";
            this.OBSERVAÇÕES.Name = "OBSERVAÇÕES";
            this.OBSERVAÇÕES.ReadOnly = true;
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.mgAlunos);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Load += new System.EventHandler(this.Alunos_Load);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialLabel lblVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private MaterialSkin.Controls.MaterialLabel lblSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel lblAluno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSala;
        private MaterialSkin.Controls.MaterialLabel lblSala;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSerie;
        private MaterialSkin.Controls.MaterialLabel lblSerie;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialFlatButton btnAtualizar;
        private MaterialSkin.Controls.MaterialFlatButton btnNovo;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpar;
        private System.Windows.Forms.GroupBox groupBox7;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton btnDeletar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MetroFramework.Controls.MetroGrid mgAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVAÇÕES;
    }
}
namespace ProjetoBiblioteca
{
    partial class Livros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtExemplares = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblExemplares = new MaterialSkin.Controls.MaterialLabel();
            this.txtLancamento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblLancamento = new MaterialSkin.Controls.MaterialLabel();
            this.txtCategoria = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblAutor = new MaterialSkin.Controls.MaterialLabel();
            this.lblTitulo = new MaterialSkin.Controls.MaterialLabel();
            this.txtAutor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtTitulo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnDeletar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialFlatButton();
            this.mgLivros = new MetroFramework.Controls.MetroGrid();
            this.lblVoltar = new MaterialSkin.Controls.MaterialLabel();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.materialDivider3 = new MaterialSkin.Controls.MaterialDivider();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANÇAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXEMPLARES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox2.Controls.Add(this.txtExemplares);
            this.groupBox2.Controls.Add(this.lblExemplares);
            this.groupBox2.Controls.Add(this.txtLancamento);
            this.groupBox2.Controls.Add(this.lblLancamento);
            this.groupBox2.Controls.Add(this.txtCategoria);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.lblAutor);
            this.groupBox2.Controls.Add(this.lblTitulo);
            this.groupBox2.Controls.Add(this.txtAutor);
            this.groupBox2.Controls.Add(this.txtTitulo);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(635, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtExemplares
            // 
            this.txtExemplares.Depth = 0;
            this.txtExemplares.Hint = "\"20\"";
            this.txtExemplares.Location = new System.Drawing.Point(103, 67);
            this.txtExemplares.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtExemplares.Name = "txtExemplares";
            this.txtExemplares.PasswordChar = '\0';
            this.txtExemplares.SelectedText = "";
            this.txtExemplares.SelectionLength = 0;
            this.txtExemplares.SelectionStart = 0;
            this.txtExemplares.Size = new System.Drawing.Size(48, 23);
            this.txtExemplares.TabIndex = 11;
            this.txtExemplares.UseSystemPasswordChar = false;
            // 
            // lblExemplares
            // 
            this.lblExemplares.AutoSize = true;
            this.lblExemplares.Depth = 0;
            this.lblExemplares.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblExemplares.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblExemplares.Location = new System.Drawing.Point(6, 67);
            this.lblExemplares.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblExemplares.Name = "lblExemplares";
            this.lblExemplares.Size = new System.Drawing.Size(91, 19);
            this.lblExemplares.TabIndex = 10;
            this.lblExemplares.Text = "Exemplares:";
            // 
            // txtLancamento
            // 
            this.txtLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLancamento.Depth = 0;
            this.txtLancamento.Hint = "\"2005\"";
            this.txtLancamento.Location = new System.Drawing.Point(396, 41);
            this.txtLancamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.PasswordChar = '\0';
            this.txtLancamento.SelectedText = "";
            this.txtLancamento.SelectionLength = 0;
            this.txtLancamento.SelectionStart = 0;
            this.txtLancamento.Size = new System.Drawing.Size(206, 23);
            this.txtLancamento.TabIndex = 9;
            this.txtLancamento.UseSystemPasswordChar = false;
            // 
            // lblLancamento
            // 
            this.lblLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLancamento.AutoSize = true;
            this.lblLancamento.Depth = 0;
            this.lblLancamento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLancamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLancamento.Location = new System.Drawing.Point(300, 41);
            this.lblLancamento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLancamento.Name = "lblLancamento";
            this.lblLancamento.Size = new System.Drawing.Size(96, 19);
            this.lblLancamento.TabIndex = 8;
            this.lblLancamento.Text = "Lançamento:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Depth = 0;
            this.txtCategoria.Hint = "\"Drama\"";
            this.txtCategoria.Location = new System.Drawing.Point(384, 12);
            this.txtCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.PasswordChar = '\0';
            this.txtCategoria.SelectedText = "";
            this.txtCategoria.SelectionLength = 0;
            this.txtCategoria.SelectionStart = 0;
            this.txtCategoria.Size = new System.Drawing.Size(218, 23);
            this.txtCategoria.TabIndex = 5;
            this.txtCategoria.UseSystemPasswordChar = false;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(300, 12);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 19);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Depth = 0;
            this.lblAutor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAutor.Location = new System.Drawing.Point(3, 41);
            this.lblAutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(68, 19);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor(a):";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Depth = 0;
            this.lblTitulo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTitulo.Location = new System.Drawing.Point(6, 12);
            this.lblTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(52, 19);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título:";
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Depth = 0;
            this.txtAutor.Hint = "\"Markus Suzaki\"";
            this.txtAutor.Location = new System.Drawing.Point(77, 41);
            this.txtAutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PasswordChar = '\0';
            this.txtAutor.SelectedText = "";
            this.txtAutor.SelectionLength = 0;
            this.txtAutor.SelectionStart = 0;
            this.txtAutor.Size = new System.Drawing.Size(217, 23);
            this.txtAutor.TabIndex = 1;
            this.txtAutor.UseSystemPasswordChar = false;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.Depth = 0;
            this.txtTitulo.Hint = "\"A menina que roubava livros\"";
            this.txtTitulo.Location = new System.Drawing.Point(64, 12);
            this.txtTitulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PasswordChar = '\0';
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.SelectionLength = 0;
            this.txtTitulo.SelectionStart = 0;
            this.txtTitulo.Size = new System.Drawing.Size(230, 23);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.UseSystemPasswordChar = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.btnLimpar);
            this.groupBox5.Location = new System.Drawing.Point(501, 178);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 53);
            this.groupBox5.TabIndex = 5;
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
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btnAtualizar);
            this.groupBox4.Location = new System.Drawing.Point(24, 178);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(170, 53);
            this.groupBox4.TabIndex = 4;
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
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.materialDivider2);
            this.groupBox3.Controls.Add(this.materialDivider1);
            this.groupBox3.Controls.Add(this.btnDeletar);
            this.groupBox3.Controls.Add(this.btnSalvar);
            this.groupBox3.Controls.Add(this.btnNovo);
            this.groupBox3.Location = new System.Drawing.Point(214, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 53);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
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
            // mgLivros
            // 
            this.mgLivros.AllowUserToAddRows = false;
            this.mgLivros.AllowUserToDeleteRows = false;
            this.mgLivros.AllowUserToResizeRows = false;
            this.mgLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgLivros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TITULO,
            this.AUTOR,
            this.CATEGORIA,
            this.LANÇAMENTO,
            this.EXEMPLARES});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgLivros.EnableHeadersVisualStyles = false;
            this.mgLivros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgLivros.Location = new System.Drawing.Point(23, 243);
            this.mgLivros.Name = "mgLivros";
            this.mgLivros.ReadOnly = true;
            this.mgLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgLivros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgLivros.Size = new System.Drawing.Size(644, 145);
            this.mgLivros.TabIndex = 1;
            this.mgLivros.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.mgLivros_CellMouseDoubleClick);
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
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lblVoltar);
            this.groupBox6.Controls.Add(this.materialDivider3);
            this.groupBox6.Controls.Add(this.lblSair);
            this.groupBox6.Location = new System.Drawing.Point(529, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 44);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
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
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.FillWeight = 37.38597F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "Titulo";
            this.TITULO.FillWeight = 152.2843F;
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            // 
            // AUTOR
            // 
            this.AUTOR.DataPropertyName = "Autor";
            this.AUTOR.FillWeight = 126.6901F;
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            this.AUTOR.ReadOnly = true;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "Categoria";
            this.CATEGORIA.FillWeight = 107.5918F;
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // LANÇAMENTO
            // 
            this.LANÇAMENTO.DataPropertyName = "Lancamento";
            this.LANÇAMENTO.FillWeight = 93.34091F;
            this.LANÇAMENTO.HeaderText = "LANÇAMENTO";
            this.LANÇAMENTO.Name = "LANÇAMENTO";
            this.LANÇAMENTO.ReadOnly = true;
            // 
            // EXEMPLARES
            // 
            this.EXEMPLARES.DataPropertyName = "Exemplares";
            this.EXEMPLARES.FillWeight = 82.70695F;
            this.EXEMPLARES.HeaderText = "EXEMPLARES";
            this.EXEMPLARES.Name = "EXEMPLARES";
            this.EXEMPLARES.ReadOnly = true;
            // 
            // Livros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.mgLivros);
            this.Controls.Add(this.groupBox1);
            this.Name = "Livros";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.Livros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel lblAutor;
        private MaterialSkin.Controls.MaterialLabel lblTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAutor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTitulo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCategoria;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtExemplares;
        private MaterialSkin.Controls.MaterialLabel lblExemplares;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLancamento;
        private MaterialSkin.Controls.MaterialLabel lblLancamento;
        private MaterialSkin.Controls.MaterialFlatButton btnDeletar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnNovo;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialFlatButton btnAtualizar;
        private System.Windows.Forms.GroupBox groupBox5;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpar;
        private MetroFramework.Controls.MetroGrid mgLivros;
        private MaterialSkin.Controls.MaterialLabel lblVoltar;
        private MaterialSkin.Controls.MaterialLabel lblSair;
        private System.Windows.Forms.GroupBox groupBox6;
        private MaterialSkin.Controls.MaterialDivider materialDivider3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANÇAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXEMPLARES;
    }
}
namespace ProjetoBiblioteca
{
    partial class Gestao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mgLivros = new MetroFramework.Controls.MetroGrid();
            this.IDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TÍTULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgAlunos = new MetroFramework.Controls.MetroGrid();
            this.IDL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgGestao = new MetroFramework.Controls.MetroGrid();
            this.LIVRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALUNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETIRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLivro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtAluno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rbEntregue = new System.Windows.Forms.RadioButton();
            this.rbRetirado = new System.Windows.Forms.RadioButton();
            this.btnInserir = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscaAluno = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtBuscaLivro = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVoltar = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgGestao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mgLivros
            // 
            this.mgLivros.AllowUserToAddRows = false;
            this.mgLivros.AllowUserToDeleteRows = false;
            this.mgLivros.AllowUserToResizeRows = false;
            this.mgLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
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
            this.IDA,
            this.TÍTULO});
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
            this.mgLivros.Location = new System.Drawing.Point(21, 121);
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
            this.mgLivros.Size = new System.Drawing.Size(220, 245);
            this.mgLivros.TabIndex = 0;
            this.mgLivros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgLivros_CellDoubleClick);
            // 
            // IDA
            // 
            this.IDA.DataPropertyName = "Id";
            this.IDA.HeaderText = "IDA";
            this.IDA.Name = "IDA";
            this.IDA.ReadOnly = true;
            this.IDA.Width = 25;
            // 
            // TÍTULO
            // 
            this.TÍTULO.DataPropertyName = "Titulo";
            this.TÍTULO.HeaderText = "TÍTULO";
            this.TÍTULO.Name = "TÍTULO";
            this.TÍTULO.ReadOnly = true;
            this.TÍTULO.Width = 154;
            // 
            // mgAlunos
            // 
            this.mgAlunos.AllowUserToAddRows = false;
            this.mgAlunos.AllowUserToDeleteRows = false;
            this.mgAlunos.AllowUserToResizeRows = false;
            this.mgAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mgAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDL,
            this.NOME});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlunos.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgAlunos.EnableHeadersVisualStyles = false;
            this.mgAlunos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.Location = new System.Drawing.Point(247, 122);
            this.mgAlunos.Name = "mgAlunos";
            this.mgAlunos.ReadOnly = true;
            this.mgAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAlunos.Size = new System.Drawing.Size(211, 245);
            this.mgAlunos.TabIndex = 1;
            this.mgAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mgAlunos_CellDoubleClick);
            // 
            // IDL
            // 
            this.IDL.DataPropertyName = "Id";
            this.IDL.HeaderText = "IDL";
            this.IDL.MaxInputLength = 50;
            this.IDL.Name = "IDL";
            this.IDL.ReadOnly = true;
            this.IDL.Width = 25;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "Nome";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 145;
            // 
            // mgGestao
            // 
            this.mgGestao.AllowUserToAddRows = false;
            this.mgGestao.AllowUserToDeleteRows = false;
            this.mgGestao.AllowUserToResizeRows = false;
            this.mgGestao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgGestao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mgGestao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mgGestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgGestao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgGestao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgGestao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.mgGestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgGestao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LIVRO,
            this.ALUNO,
            this.RETIRADA,
            this.STATUS});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgGestao.DefaultCellStyle = dataGridViewCellStyle8;
            this.mgGestao.EnableHeadersVisualStyles = false;
            this.mgGestao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgGestao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgGestao.Location = new System.Drawing.Point(464, 122);
            this.mgGestao.Name = "mgGestao";
            this.mgGestao.ReadOnly = true;
            this.mgGestao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgGestao.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.mgGestao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgGestao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgGestao.Size = new System.Drawing.Size(442, 244);
            this.mgGestao.TabIndex = 2;
            // 
            // LIVRO
            // 
            this.LIVRO.HeaderText = "LIVRO";
            this.LIVRO.Name = "LIVRO";
            this.LIVRO.ReadOnly = true;
            // 
            // ALUNO
            // 
            this.ALUNO.HeaderText = "ALUNO";
            this.ALUNO.Name = "ALUNO";
            this.ALUNO.ReadOnly = true;
            // 
            // RETIRADA
            // 
            this.RETIRADA.HeaderText = "RETIRADA";
            this.RETIRADA.Name = "RETIRADA";
            this.RETIRADA.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "Status";
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // txtLivro
            // 
            this.txtLivro.Depth = 0;
            this.txtLivro.Hint = "\"Livro\"";
            this.txtLivro.Location = new System.Drawing.Point(21, 56);
            this.txtLivro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLivro.Name = "txtLivro";
            this.txtLivro.PasswordChar = '\0';
            this.txtLivro.SelectedText = "";
            this.txtLivro.SelectionLength = 0;
            this.txtLivro.SelectionStart = 0;
            this.txtLivro.Size = new System.Drawing.Size(358, 23);
            this.txtLivro.TabIndex = 3;
            this.txtLivro.UseSystemPasswordChar = false;
            // 
            // txtAluno
            // 
            this.txtAluno.Depth = 0;
            this.txtAluno.Hint = "\"Aluno\"";
            this.txtAluno.Location = new System.Drawing.Point(21, 85);
            this.txtAluno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtAluno.Name = "txtAluno";
            this.txtAluno.PasswordChar = '\0';
            this.txtAluno.SelectedText = "";
            this.txtAluno.SelectionLength = 0;
            this.txtAluno.SelectionStart = 0;
            this.txtAluno.Size = new System.Drawing.Size(174, 23);
            this.txtAluno.TabIndex = 4;
            this.txtAluno.UseSystemPasswordChar = false;
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "\"Retirada\"";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(205, 85);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(174, 23);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // rbEntregue
            // 
            this.rbEntregue.AutoSize = true;
            this.rbEntregue.Location = new System.Drawing.Point(6, 42);
            this.rbEntregue.Name = "rbEntregue";
            this.rbEntregue.Size = new System.Drawing.Size(68, 17);
            this.rbEntregue.TabIndex = 7;
            this.rbEntregue.TabStop = true;
            this.rbEntregue.Text = "Entregue";
            this.rbEntregue.UseVisualStyleBackColor = true;
            // 
            // rbRetirado
            // 
            this.rbRetirado.AutoSize = true;
            this.rbRetirado.Location = new System.Drawing.Point(6, 19);
            this.rbRetirado.Name = "rbRetirado";
            this.rbRetirado.Size = new System.Drawing.Size(65, 17);
            this.rbRetirado.TabIndex = 8;
            this.rbRetirado.TabStop = true;
            this.rbRetirado.Text = "Retirado";
            this.rbRetirado.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInserir.AutoSize = true;
            this.btnInserir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserir.Depth = 0;
            this.btnInserir.Location = new System.Drawing.Point(697, 43);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInserir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Primary = false;
            this.btnInserir.Size = new System.Drawing.Size(63, 36);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(690, 80);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(70, 36);
            this.materialFlatButton2.TabIndex = 10;
            this.materialFlatButton2.Text = "Deletar";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEntregue);
            this.groupBox1.Controls.Add(this.rbRetirado);
            this.groupBox1.Location = new System.Drawing.Point(565, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // txtBuscaAluno
            // 
            this.txtBuscaAluno.Depth = 0;
            this.txtBuscaAluno.Hint = "Busca ID Aluno";
            this.txtBuscaAluno.Location = new System.Drawing.Point(401, 85);
            this.txtBuscaAluno.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscaAluno.Name = "txtBuscaAluno";
            this.txtBuscaAluno.PasswordChar = '\0';
            this.txtBuscaAluno.SelectedText = "";
            this.txtBuscaAluno.SelectionLength = 0;
            this.txtBuscaAluno.SelectionStart = 0;
            this.txtBuscaAluno.Size = new System.Drawing.Size(158, 23);
            this.txtBuscaAluno.TabIndex = 12;
            this.txtBuscaAluno.UseSystemPasswordChar = false;
            this.txtBuscaAluno.TextChanged += new System.EventHandler(this.txtBuscaAluno_TextChanged);
            // 
            // txtBuscaLivro
            // 
            this.txtBuscaLivro.Depth = 0;
            this.txtBuscaLivro.Hint = "Busca ID Livro";
            this.txtBuscaLivro.Location = new System.Drawing.Point(401, 56);
            this.txtBuscaLivro.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtBuscaLivro.Name = "txtBuscaLivro";
            this.txtBuscaLivro.PasswordChar = '\0';
            this.txtBuscaLivro.SelectedText = "";
            this.txtBuscaLivro.SelectionLength = 0;
            this.txtBuscaLivro.SelectionStart = 0;
            this.txtBuscaLivro.Size = new System.Drawing.Size(158, 23);
            this.txtBuscaLivro.TabIndex = 13;
            this.txtBuscaLivro.UseSystemPasswordChar = false;
            this.txtBuscaLivro.TextChanged += new System.EventHandler(this.txtBuscaLivro_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblVoltar);
            this.groupBox4.Controls.Add(this.materialDivider1);
            this.groupBox4.Controls.Add(this.lblSair);
            this.groupBox4.Location = new System.Drawing.Point(791, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 44);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // lblVoltar
            // 
            this.lblVoltar.AutoSize = true;
            this.lblVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVoltar.Depth = 0;
            this.lblVoltar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVoltar.Location = new System.Drawing.Point(6, 16);
            this.lblVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVoltar.Name = "lblVoltar";
            this.lblVoltar.Size = new System.Drawing.Size(50, 19);
            this.lblVoltar.TabIndex = 4;
            this.lblVoltar.Text = "Voltar";
            this.lblVoltar.Click += new System.EventHandler(this.lblVoltar_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(62, 12);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(2, 23);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // lblSair
            // 
            this.lblSair.AutoSize = true;
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.Depth = 0;
            this.lblSair.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSair.Location = new System.Drawing.Point(70, 16);
            this.lblSair.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(35, 19);
            this.lblSair.TabIndex = 0;
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 378);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtBuscaLivro);
            this.Controls.Add(this.txtBuscaAluno);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.materialSingleLineTextField1);
            this.Controls.Add(this.txtAluno);
            this.Controls.Add(this.txtLivro);
            this.Controls.Add(this.mgGestao);
            this.Controls.Add(this.mgAlunos);
            this.Controls.Add(this.mgLivros);
            this.Name = "Gestao";
            this.Text = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mgGestao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid mgLivros;
        private MetroFramework.Controls.MetroGrid mgAlunos;
        private MetroFramework.Controls.MetroGrid mgGestao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLivro;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtAluno;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.RadioButton rbEntregue;
        private System.Windows.Forms.RadioButton rbRetirado;
        private MaterialSkin.Controls.MaterialFlatButton btnInserir;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TÍTULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LIVRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALUNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETIRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscaAluno;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtBuscaLivro;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel lblVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblSair;

    }
}
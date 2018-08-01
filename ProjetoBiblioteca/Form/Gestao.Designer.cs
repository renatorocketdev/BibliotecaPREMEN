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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.mgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDA,
            this.TÍTULO});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgLivros.DefaultCellStyle = dataGridViewCellStyle11;
            this.mgLivros.EnableHeadersVisualStyles = false;
            this.mgLivros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgLivros.Location = new System.Drawing.Point(21, 121);
            this.mgLivros.Name = "mgLivros";
            this.mgLivros.ReadOnly = true;
            this.mgLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.mgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDL,
            this.NOME});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlunos.DefaultCellStyle = dataGridViewCellStyle14;
            this.mgAlunos.EnableHeadersVisualStyles = false;
            this.mgAlunos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.Location = new System.Drawing.Point(247, 122);
            this.mgAlunos.Name = "mgAlunos";
            this.mgAlunos.ReadOnly = true;
            this.mgAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
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
            this.mgGestao.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mgGestao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgGestao.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgGestao.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgGestao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.mgGestao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgGestao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LIVRO,
            this.ALUNO,
            this.RETIRADA,
            this.STATUS});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgGestao.DefaultCellStyle = dataGridViewCellStyle17;
            this.mgGestao.EnableHeadersVisualStyles = false;
            this.mgGestao.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgGestao.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgGestao.Location = new System.Drawing.Point(464, 122);
            this.mgGestao.Name = "mgGestao";
            this.mgGestao.ReadOnly = true;
            this.mgGestao.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgGestao.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            this.btnInserir.AutoSize = true;
            this.btnInserir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInserir.Depth = 0;
            this.btnInserir.Location = new System.Drawing.Point(661, 43);
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
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(661, 85);
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
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
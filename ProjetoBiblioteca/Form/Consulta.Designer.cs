namespace ProjetoBiblioteca
{
    partial class Consulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.lblBuscaTitulo = new MetroFramework.Controls.MetroLabel();
            this.txtPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.mgLivros = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LANÇAMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXEMPLARES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAlunos = new System.Windows.Forms.TabPage();
            this.lblBuscaNome = new MetroFramework.Controls.MetroLabel();
            this.txtPesquisa2 = new MetroFramework.Controls.MetroTextBox();
            this.mgAlunos = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVAÇÕES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblVoltar = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.lblSair = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1.SuspendLayout();
            this.tabLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).BeginInit();
            this.tabAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Controls.Add(this.tabAlunos);
            this.tabControl1.Location = new System.Drawing.Point(23, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(661, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.lblBuscaTitulo);
            this.tabLivros.Controls.Add(this.txtPesquisa);
            this.tabLivros.Controls.Add(this.mgLivros);
            this.tabLivros.Location = new System.Drawing.Point(4, 22);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivros.Size = new System.Drawing.Size(653, 327);
            this.tabLivros.TabIndex = 0;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // lblBuscaTitulo
            // 
            this.lblBuscaTitulo.AutoSize = true;
            this.lblBuscaTitulo.Location = new System.Drawing.Point(6, 6);
            this.lblBuscaTitulo.Name = "lblBuscaTitulo";
            this.lblBuscaTitulo.Size = new System.Drawing.Size(108, 19);
            this.lblBuscaTitulo.TabIndex = 4;
            this.lblBuscaTitulo.Text = "Buscar Por Título";
            // 
            // txtPesquisa
            // 
            // 
            // 
            // 
            this.txtPesquisa.CustomButton.Image = null;
            this.txtPesquisa.CustomButton.Location = new System.Drawing.Point(132, 1);
            this.txtPesquisa.CustomButton.Name = "";
            this.txtPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa.CustomButton.TabIndex = 1;
            this.txtPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa.CustomButton.UseSelectable = true;
            this.txtPesquisa.CustomButton.Visible = false;
            this.txtPesquisa.Lines = new string[0];
            this.txtPesquisa.Location = new System.Drawing.Point(125, 6);
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.ShortcutsEnabled = true;
            this.txtPesquisa.Size = new System.Drawing.Size(154, 23);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.UseSelectable = true;
            this.txtPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // mgLivros
            // 
            this.mgLivros.AllowUserToAddRows = false;
            this.mgLivros.AllowUserToDeleteRows = false;
            this.mgLivros.AllowUserToResizeRows = false;
            this.mgLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mgLivros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgLivros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.mgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TITULO,
            this.AUTOR,
            this.CATEGORIA,
            this.LANÇAMENTO,
            this.EXEMPLARES});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgLivros.DefaultCellStyle = dataGridViewCellStyle14;
            this.mgLivros.EnableHeadersVisualStyles = false;
            this.mgLivros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgLivros.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgLivros.Location = new System.Drawing.Point(6, 35);
            this.mgLivros.Name = "mgLivros";
            this.mgLivros.ReadOnly = true;
            this.mgLivros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.mgLivros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgLivros.Size = new System.Drawing.Size(641, 289);
            this.mgLivros.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 25;
            // 
            // TITULO
            // 
            this.TITULO.DataPropertyName = "Titulo";
            this.TITULO.HeaderText = "TITULO";
            this.TITULO.Name = "TITULO";
            this.TITULO.ReadOnly = true;
            this.TITULO.Width = 175;
            // 
            // AUTOR
            // 
            this.AUTOR.DataPropertyName = "Autor";
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.Name = "AUTOR";
            this.AUTOR.ReadOnly = true;
            this.AUTOR.Width = 125;
            // 
            // CATEGORIA
            // 
            this.CATEGORIA.DataPropertyName = "Categoria";
            this.CATEGORIA.HeaderText = "CATEGORIA";
            this.CATEGORIA.Name = "CATEGORIA";
            this.CATEGORIA.ReadOnly = true;
            // 
            // LANÇAMENTO
            // 
            this.LANÇAMENTO.DataPropertyName = "Lancamento";
            this.LANÇAMENTO.HeaderText = "LANÇAMENTO";
            this.LANÇAMENTO.Name = "LANÇAMENTO";
            this.LANÇAMENTO.ReadOnly = true;
            // 
            // EXEMPLARES
            // 
            this.EXEMPLARES.DataPropertyName = "Exemplares";
            this.EXEMPLARES.HeaderText = "EXEMPLARES";
            this.EXEMPLARES.Name = "EXEMPLARES";
            this.EXEMPLARES.ReadOnly = true;
            this.EXEMPLARES.Width = 75;
            // 
            // tabAlunos
            // 
            this.tabAlunos.Controls.Add(this.lblBuscaNome);
            this.tabAlunos.Controls.Add(this.txtPesquisa2);
            this.tabAlunos.Controls.Add(this.mgAlunos);
            this.tabAlunos.Location = new System.Drawing.Point(4, 22);
            this.tabAlunos.Name = "tabAlunos";
            this.tabAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlunos.Size = new System.Drawing.Size(653, 327);
            this.tabAlunos.TabIndex = 1;
            this.tabAlunos.Text = "Alunos";
            this.tabAlunos.UseVisualStyleBackColor = true;
            // 
            // lblBuscaNome
            // 
            this.lblBuscaNome.AutoSize = true;
            this.lblBuscaNome.Location = new System.Drawing.Point(6, 6);
            this.lblBuscaNome.Name = "lblBuscaNome";
            this.lblBuscaNome.Size = new System.Drawing.Size(113, 19);
            this.lblBuscaNome.TabIndex = 12;
            this.lblBuscaNome.Text = "Buscar Por Nome";
            // 
            // txtPesquisa2
            // 
            // 
            // 
            // 
            this.txtPesquisa2.CustomButton.Image = null;
            this.txtPesquisa2.CustomButton.Location = new System.Drawing.Point(117, 1);
            this.txtPesquisa2.CustomButton.Name = "";
            this.txtPesquisa2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPesquisa2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPesquisa2.CustomButton.TabIndex = 1;
            this.txtPesquisa2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPesquisa2.CustomButton.UseSelectable = true;
            this.txtPesquisa2.CustomButton.Visible = false;
            this.txtPesquisa2.Lines = new string[0];
            this.txtPesquisa2.Location = new System.Drawing.Point(125, 6);
            this.txtPesquisa2.MaxLength = 32767;
            this.txtPesquisa2.Name = "txtPesquisa2";
            this.txtPesquisa2.PasswordChar = '\0';
            this.txtPesquisa2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPesquisa2.SelectedText = "";
            this.txtPesquisa2.SelectionLength = 0;
            this.txtPesquisa2.SelectionStart = 0;
            this.txtPesquisa2.ShortcutsEnabled = true;
            this.txtPesquisa2.Size = new System.Drawing.Size(139, 23);
            this.txtPesquisa2.TabIndex = 11;
            this.txtPesquisa2.UseSelectable = true;
            this.txtPesquisa2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPesquisa2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPesquisa2.TextChanged += new System.EventHandler(this.txtPesquisa2_TextChanged);
            // 
            // mgAlunos
            // 
            this.mgAlunos.AllowUserToAddRows = false;
            this.mgAlunos.AllowUserToDeleteRows = false;
            this.mgAlunos.AllowUserToResizeRows = false;
            this.mgAlunos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgAlunos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgAlunos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.mgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.NOME,
            this.SERIE,
            this.SALA,
            this.OBSERVAÇÕES});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgAlunos.DefaultCellStyle = dataGridViewCellStyle17;
            this.mgAlunos.EnableHeadersVisualStyles = false;
            this.mgAlunos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgAlunos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgAlunos.Location = new System.Drawing.Point(3, 35);
            this.mgAlunos.Name = "mgAlunos";
            this.mgAlunos.ReadOnly = true;
            this.mgAlunos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.mgAlunos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgAlunos.Size = new System.Drawing.Size(641, 286);
            this.mgAlunos.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "Nome";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 325;
            // 
            // SERIE
            // 
            this.SERIE.DataPropertyName = "Serie";
            this.SERIE.HeaderText = "SÉRIE";
            this.SERIE.Name = "SERIE";
            this.SERIE.ReadOnly = true;
            this.SERIE.Width = 50;
            // 
            // SALA
            // 
            this.SALA.DataPropertyName = "Sala";
            this.SALA.HeaderText = "SALA";
            this.SALA.Name = "SALA";
            this.SALA.ReadOnly = true;
            this.SALA.Width = 50;
            // 
            // OBSERVAÇÕES
            // 
            this.OBSERVAÇÕES.DataPropertyName = "Observacoes";
            this.OBSERVAÇÕES.HeaderText = "OBSERVAÇÕES";
            this.OBSERVAÇÕES.Name = "OBSERVAÇÕES";
            this.OBSERVAÇÕES.ReadOnly = true;
            this.OBSERVAÇÕES.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.lblVoltar);
            this.groupBox4.Controls.Add(this.materialDivider1);
            this.groupBox4.Controls.Add(this.lblSair);
            this.groupBox4.Location = new System.Drawing.Point(565, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(115, 44);
            this.groupBox4.TabIndex = 3;
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
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 439);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgLivros)).EndInit();
            this.tabAlunos.ResumeLayout(false);
            this.tabAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgAlunos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.TabPage tabAlunos;
        private MetroFramework.Controls.MetroGrid mgLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LANÇAMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXEMPLARES;
        private MetroFramework.Controls.MetroGrid mgAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVAÇÕES;
        private MetroFramework.Controls.MetroTextBox txtPesquisa;
        private MetroFramework.Controls.MetroTextBox txtPesquisa2;
        private MetroFramework.Controls.MetroLabel lblBuscaTitulo;
        private MetroFramework.Controls.MetroLabel lblBuscaNome;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialLabel lblVoltar;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel lblSair;
    }
}
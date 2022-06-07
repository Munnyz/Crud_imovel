namespace Imovel
{
    partial class Imoveis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imoveis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.timovel = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vvimovel = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.vlimovel = new System.Windows.Forms.TextBox();
            this.ImoveisDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vvimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlimovelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netimovelDataSet = new Imovel.NetimovelDataSet();
            this.imoveisTableAdapter = new Imovel.NetimovelDataSetTableAdapters.imoveisTableAdapter();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tenantTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImoveisDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netimovelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cadastro de endereços";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cadastro Imóveis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 48);
            this.label2.TabIndex = 18;
            this.label2.Text = "Netimoveis";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2CustomGradientPanel1.Controls.Add(this.label4);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label2);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.DarkOrchid;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.DarkOrchid;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Black;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(284, 670);
            this.guna2CustomGradientPanel1.TabIndex = 71;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2ImageButton1.IndicateFocus = true;
            this.guna2ImageButton1.Location = new System.Drawing.Point(1171, 15);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 58);
            this.guna2ImageButton1.TabIndex = 73;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(902, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(187, 33);
            this.label12.TabIndex = 70;
            this.label12.Text = "Valor de locação:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // timovel
            // 
            this.timovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timovel.FormattingEnabled = true;
            this.timovel.Items.AddRange(new object[] {
            "Apartamento",
            "Flat",
            "Casa",
            "Kitnet"});
            this.timovel.Location = new System.Drawing.Point(296, 205);
            this.timovel.Name = "timovel";
            this.timovel.Size = new System.Drawing.Size(197, 37);
            this.timovel.TabIndex = 69;
            this.timovel.SelectedIndexChanged += new System.EventHandler(this.timovel_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(584, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 33);
            this.label10.TabIndex = 64;
            this.label10.Text = "Valor do imóvel:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // vvimovel
            // 
            this.vvimovel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.vvimovel.Location = new System.Drawing.Point(540, 205);
            this.vvimovel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vvimovel.Name = "vvimovel";
            this.vvimovel.Size = new System.Drawing.Size(268, 38);
            this.vvimovel.TabIndex = 63;
            this.vvimovel.TextChanged += new System.EventHandler(this.vvimovel_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(305, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 33);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tipo do Imóvel:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // vlimovel
            // 
            this.vlimovel.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.vlimovel.Location = new System.Drawing.Point(858, 205);
            this.vlimovel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vlimovel.Name = "vlimovel";
            this.vlimovel.Size = new System.Drawing.Size(268, 38);
            this.vlimovel.TabIndex = 61;
            this.vlimovel.TextChanged += new System.EventHandler(this.Tname_TextChanged);
            // 
            // ImoveisDGV
            // 
            this.ImoveisDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImoveisDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ImoveisDGV.AutoGenerateColumns = false;
            this.ImoveisDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ImoveisDGV.BackgroundColor = System.Drawing.Color.White;
            this.ImoveisDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ImoveisDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ImoveisDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ImoveisDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ImoveisDGV.ColumnHeadersHeight = 4;
            this.ImoveisDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timovelDataGridViewTextBoxColumn,
            this.vvimovelDataGridViewTextBoxColumn,
            this.vlimovelDataGridViewTextBoxColumn});
            this.ImoveisDGV.DataSource = this.imoveisBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ImoveisDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.ImoveisDGV.EnableHeadersVisualStyles = false;
            this.ImoveisDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ImoveisDGV.Location = new System.Drawing.Point(290, 355);
            this.ImoveisDGV.Name = "ImoveisDGV";
            this.ImoveisDGV.RowHeadersVisible = false;
            this.ImoveisDGV.RowHeadersWidth = 51;
            this.ImoveisDGV.RowTemplate.Height = 24;
            this.ImoveisDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ImoveisDGV.Size = new System.Drawing.Size(933, 303);
            this.ImoveisDGV.TabIndex = 75;
            this.ImoveisDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ImoveisDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ImoveisDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ImoveisDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ImoveisDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ImoveisDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ImoveisDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ImoveisDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ImoveisDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.ImoveisDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ImoveisDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ImoveisDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ImoveisDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ImoveisDGV.ThemeStyle.ReadOnly = false;
            this.ImoveisDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ImoveisDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ImoveisDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ImoveisDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ImoveisDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ImoveisDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ImoveisDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ImoveisDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ImoveisDGV_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // timovelDataGridViewTextBoxColumn
            // 
            this.timovelDataGridViewTextBoxColumn.DataPropertyName = "timovel";
            this.timovelDataGridViewTextBoxColumn.HeaderText = "timovel";
            this.timovelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timovelDataGridViewTextBoxColumn.Name = "timovelDataGridViewTextBoxColumn";
            // 
            // vvimovelDataGridViewTextBoxColumn
            // 
            this.vvimovelDataGridViewTextBoxColumn.DataPropertyName = "vvimovel";
            this.vvimovelDataGridViewTextBoxColumn.HeaderText = "vvimovel";
            this.vvimovelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vvimovelDataGridViewTextBoxColumn.Name = "vvimovelDataGridViewTextBoxColumn";
            // 
            // vlimovelDataGridViewTextBoxColumn
            // 
            this.vlimovelDataGridViewTextBoxColumn.DataPropertyName = "vlimovel";
            this.vlimovelDataGridViewTextBoxColumn.HeaderText = "vlimovel";
            this.vlimovelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vlimovelDataGridViewTextBoxColumn.Name = "vlimovelDataGridViewTextBoxColumn";
            // 
            // imoveisBindingSource
            // 
            this.imoveisBindingSource.DataMember = "imoveis";
            this.imoveisBindingSource.DataSource = this.netimovelDataSet;
            this.imoveisBindingSource.CurrentChanged += new System.EventHandler(this.imoveisBindingSource_CurrentChanged);
            // 
            // netimovelDataSet
            // 
            this.netimovelDataSet.DataSetName = "NetimovelDataSet";
            this.netimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imoveisTableAdapter
            // 
            this.imoveisTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteBtn.BackColor = System.Drawing.Color.White;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Deletar";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Red;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.Azure;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Red;
            this.DeleteBtn.Location = new System.Drawing.Point(1075, 308);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 41);
            this.DeleteBtn.TabIndex = 77;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EditBtn.ActiveForecolor = System.Drawing.Color.White;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EditBtn.BackColor = System.Drawing.Color.White;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Editar";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.EditBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.Red;
            this.EditBtn.IdleForecolor = System.Drawing.Color.Azure;
            this.EditBtn.IdleLineColor = System.Drawing.Color.Red;
            this.EditBtn.Location = new System.Drawing.Point(290, 307);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(148, 41);
            this.EditBtn.TabIndex = 76;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Salvar";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.LawnGreen;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkOliveGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(672, 308);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(148, 41);
            this.bunifuThinButton21.TabIndex = 78;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // tenantTblBindingSource
            // 
            this.tenantTblBindingSource.DataMember = "TenantTbl";
            this.tenantTblBindingSource.CurrentChanged += new System.EventHandler(this.tenantTblBindingSource_CurrentChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(7, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cadastro de Imóvel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(290, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 55);
            this.panel2.TabIndex = 87;
            // 
            // Imoveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ImoveisDGV);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.timovel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.vvimovel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.vlimovel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Imoveis";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imoveis";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImoveisDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netimovelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox timovel;
        private System.Windows.Forms.BindingSource tenantTblBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox vvimovel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox vlimovel;
        private Guna.UI2.WinForms.Guna2DataGridView ImoveisDGV;
        private NetimovelDataSet netimovelDataSet;
        private System.Windows.Forms.BindingSource imoveisBindingSource;
        private NetimovelDataSetTableAdapters.imoveisTableAdapter imoveisTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vvimovelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlimovelDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
    }
}
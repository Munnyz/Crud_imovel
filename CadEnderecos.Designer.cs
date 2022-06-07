namespace Imovel
{
    partial class CadEnderecos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadEnderecos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imoveisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netimovelDataSet = new Imovel.NetimovelDataSet();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.TextBox();
            this.imoveisTableAdapter = new Imovel.NetimovelDataSetTableAdapters.imoveisTableAdapter();
            this.timovel = new System.Windows.Forms.ComboBox();
            this.tenantTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.comp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ba = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.es = new System.Windows.Forms.TextBox();
            this.ApartDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netimovelDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // imoveisBindingSource
            // 
            this.imoveisBindingSource.DataMember = "imoveis";
            this.imoveisBindingSource.DataSource = this.netimovelDataSet;
            // 
            // netimovelDataSet
            // 
            this.netimovelDataSet.DataSetName = "NetimovelDataSet";
            this.netimovelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(290, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(853, 55);
            this.panel2.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.AliceBlue;
            this.label8.Location = new System.Drawing.Point(7, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(289, 43);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cadastro de Endereços";
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
            this.bunifuThinButton21.Location = new System.Drawing.Point(972, 324);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(148, 41);
            this.bunifuThinButton21.TabIndex = 91;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
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
            this.guna2CustomGradientPanel1.TabIndex = 85;
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
            this.guna2ImageButton1.Location = new System.Drawing.Point(1193, 14);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(52, 58);
            this.guna2ImageButton1.TabIndex = 87;
            this.guna2ImageButton1.UseTransparentBackground = true;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(863, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 33);
            this.label12.TabIndex = 84;
            this.label12.Text = "Complemento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(544, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 33);
            this.label10.TabIndex = 82;
            this.label10.Text = "Endereço:";
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.end.Location = new System.Drawing.Point(534, 112);
            this.end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(268, 38);
            this.end.TabIndex = 81;
            // 
            // imoveisTableAdapter
            // 
            this.imoveisTableAdapter.ClearBeforeFill = true;
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
            this.timovel.Location = new System.Drawing.Point(290, 112);
            this.timovel.Name = "timovel";
            this.timovel.Size = new System.Drawing.Size(197, 37);
            this.timovel.TabIndex = 83;
            // 
            // tenantTblBindingSource
            // 
            this.tenantTblBindingSource.DataMember = "TenantTbl";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(299, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 33);
            this.label9.TabIndex = 80;
            this.label9.Text = "Imóvel:";
            // 
            // comp
            // 
            this.comp.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.comp.Location = new System.Drawing.Point(852, 112);
            this.comp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comp.Name = "comp";
            this.comp.Size = new System.Drawing.Size(268, 38);
            this.comp.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(301, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 33);
            this.label3.TabIndex = 93;
            this.label3.Text = "Numero:";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.num.Location = new System.Drawing.Point(290, 219);
            this.num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(197, 38);
            this.num.TabIndex = 92;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(545, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 33);
            this.label5.TabIndex = 95;
            this.label5.Text = "Bairro:";
            // 
            // ba
            // 
            this.ba.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.ba.Location = new System.Drawing.Point(534, 219);
            this.ba.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ba.Name = "ba";
            this.ba.Size = new System.Drawing.Size(268, 38);
            this.ba.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(863, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 33);
            this.label6.TabIndex = 97;
            this.label6.Text = "Cidade:";
            // 
            // cd
            // 
            this.cd.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cd.Location = new System.Drawing.Point(852, 219);
            this.cd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cd.Name = "cd";
            this.cd.Size = new System.Drawing.Size(268, 38);
            this.cd.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(545, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 33);
            this.label11.TabIndex = 99;
            this.label11.Text = "CEP:";
            // 
            // cep
            // 
            this.cep.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.cep.Location = new System.Drawing.Point(534, 327);
            this.cep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(268, 38);
            this.cep.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Sitka Subheading", 13.8F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(301, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 33);
            this.label13.TabIndex = 101;
            this.label13.Text = "Estado:";
            // 
            // es
            // 
            this.es.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.es.Location = new System.Drawing.Point(290, 327);
            this.es.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(197, 38);
            this.es.TabIndex = 100;
            // 
            // ApartDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ApartDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ApartDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ApartDGV.BackgroundColor = System.Drawing.Color.White;
            this.ApartDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ApartDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ApartDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ApartDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ApartDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ApartDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ApartDGV.EnableHeadersVisualStyles = false;
            this.ApartDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApartDGV.Location = new System.Drawing.Point(290, 419);
            this.ApartDGV.Name = "ApartDGV";
            this.ApartDGV.RowHeadersVisible = false;
            this.ApartDGV.RowHeadersWidth = 51;
            this.ApartDGV.RowTemplate.Height = 24;
            this.ApartDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ApartDGV.Size = new System.Drawing.Size(955, 190);
            this.ApartDGV.TabIndex = 103;
            this.ApartDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ApartDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ApartDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ApartDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ApartDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ApartDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ApartDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApartDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ApartDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ApartDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ApartDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ApartDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ApartDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.ApartDGV.ThemeStyle.ReadOnly = false;
            this.ApartDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ApartDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ApartDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ApartDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ApartDGV.ThemeStyle.RowsStyle.Height = 24;
            this.ApartDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ApartDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ApartDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ApartDGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(297, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 43);
            this.label7.TabIndex = 102;
            this.label7.Text = "Lista:";
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
            this.EditBtn.Location = new System.Drawing.Point(574, 616);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(148, 41);
            this.EditBtn.TabIndex = 104;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
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
            this.DeleteBtn.Location = new System.Drawing.Point(819, 616);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(148, 41);
            this.DeleteBtn.TabIndex = 105;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CadEnderecos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1250, 670);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ApartDGV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.es);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.end);
            this.Controls.Add(this.timovel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadEnderecos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadEnderecos";
            this.Load += new System.EventHandler(this.CadEnderecos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imoveisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netimovelDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenantTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApartDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource imoveisBindingSource;
        private NetimovelDataSet netimovelDataSet;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox end;
        private NetimovelDataSetTableAdapters.imoveisTableAdapter imoveisTableAdapter;
        private System.Windows.Forms.ComboBox timovel;
        private System.Windows.Forms.BindingSource tenantTblBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox comp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ba;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox es;
        private Guna.UI2.WinForms.Guna2DataGridView ApartDGV;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
    }
}
namespace teste_WFA_SQL
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tab_VISUALIZAÇÃO = new System.Windows.Forms.TabControl();
            this.tab_VISUAL = new System.Windows.Forms.TabPage();
            this.panel_PESQUISA_BLOCO = new System.Windows.Forms.Panel();
            this.button_FECHAR_PESQUISA_BLOCO = new System.Windows.Forms.Button();
            this.dataGridView_PESQUISA_BLOCO = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pesquisa = new System.Windows.Forms.Button();
            this.Seleção = new System.Windows.Forms.Button();
            this.Regua = new System.Windows.Forms.Button();
            this.Pan_zoom = new System.Windows.Forms.Button();
            this.Zoom_OUT = new System.Windows.Forms.Button();
            this.zoom_in = new System.Windows.Forms.Button();
            this.axMap1 = new AxMapWinGIS.AxMap();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pesquisa_Interior_PROF = new System.Windows.Forms.ToolStripMenuItem();
            this.Pesquisa_Interior_Alunos = new System.Windows.Forms.ToolStripMenuItem();
            this.logDoBlocoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_CADASTRO = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.TAGbox = new System.Windows.Forms.TextBox();
            this.RespBox = new System.Windows.Forms.TextBox();
            this.BirthBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.NomeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_CONSULTA = new System.Windows.Forms.TabPage();
            this.TagGrid = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.RegBox2 = new System.Windows.Forms.TextBox();
            this.Registro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tab_VISUALIZAÇÃO.SuspendLayout();
            this.tab_VISUAL.SuspendLayout();
            this.panel_PESQUISA_BLOCO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PESQUISA_BLOCO)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.tab_CADASTRO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab_CONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_VISUALIZAÇÃO
            // 
            this.tab_VISUALIZAÇÃO.Controls.Add(this.tab_VISUAL);
            this.tab_VISUALIZAÇÃO.Controls.Add(this.tab_CADASTRO);
            this.tab_VISUALIZAÇÃO.Controls.Add(this.tab_CONSULTA);
            this.tab_VISUALIZAÇÃO.Location = new System.Drawing.Point(26, 12);
            this.tab_VISUALIZAÇÃO.Name = "tab_VISUALIZAÇÃO";
            this.tab_VISUALIZAÇÃO.SelectedIndex = 0;
            this.tab_VISUALIZAÇÃO.Size = new System.Drawing.Size(1980, 1000);
            this.tab_VISUALIZAÇÃO.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tab_VISUALIZAÇÃO.TabIndex = 23;
            // 
            // tab_VISUAL
            // 
            this.tab_VISUAL.Controls.Add(this.panel_PESQUISA_BLOCO);
            this.tab_VISUAL.Controls.Add(this.panel1);
            this.tab_VISUAL.Controls.Add(this.axMap1);
            this.tab_VISUAL.Location = new System.Drawing.Point(4, 22);
            this.tab_VISUAL.Name = "tab_VISUAL";
            this.tab_VISUAL.Padding = new System.Windows.Forms.Padding(3);
            this.tab_VISUAL.Size = new System.Drawing.Size(1972, 974);
            this.tab_VISUAL.TabIndex = 0;
            this.tab_VISUAL.Text = "VISUALIZAÇÃO";
            this.tab_VISUAL.UseVisualStyleBackColor = true;
            this.tab_VISUAL.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel_PESQUISA_BLOCO
            // 
            this.panel_PESQUISA_BLOCO.Controls.Add(this.button_FECHAR_PESQUISA_BLOCO);
            this.panel_PESQUISA_BLOCO.Controls.Add(this.dataGridView_PESQUISA_BLOCO);
            this.panel_PESQUISA_BLOCO.Location = new System.Drawing.Point(29, 159);
            this.panel_PESQUISA_BLOCO.Name = "panel_PESQUISA_BLOCO";
            this.panel_PESQUISA_BLOCO.Size = new System.Drawing.Size(585, 547);
            this.panel_PESQUISA_BLOCO.TabIndex = 26;
            this.panel_PESQUISA_BLOCO.Visible = false;
            // 
            // button_FECHAR_PESQUISA_BLOCO
            // 
            this.button_FECHAR_PESQUISA_BLOCO.Location = new System.Drawing.Point(218, 501);
            this.button_FECHAR_PESQUISA_BLOCO.Name = "button_FECHAR_PESQUISA_BLOCO";
            this.button_FECHAR_PESQUISA_BLOCO.Size = new System.Drawing.Size(136, 26);
            this.button_FECHAR_PESQUISA_BLOCO.TabIndex = 1;
            this.button_FECHAR_PESQUISA_BLOCO.Text = "FECHAR";
            this.button_FECHAR_PESQUISA_BLOCO.UseVisualStyleBackColor = true;
            this.button_FECHAR_PESQUISA_BLOCO.Click += new System.EventHandler(this.button_FECHAR_PESQUISA_BLOCO_Click);
            // 
            // dataGridView_PESQUISA_BLOCO
            // 
            this.dataGridView_PESQUISA_BLOCO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PESQUISA_BLOCO.Location = new System.Drawing.Point(18, 23);
            this.dataGridView_PESQUISA_BLOCO.Name = "dataGridView_PESQUISA_BLOCO";
            this.dataGridView_PESQUISA_BLOCO.Size = new System.Drawing.Size(548, 461);
            this.dataGridView_PESQUISA_BLOCO.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.Pesquisa);
            this.panel1.Controls.Add(this.Seleção);
            this.panel1.Controls.Add(this.Regua);
            this.panel1.Controls.Add(this.Pan_zoom);
            this.panel1.Controls.Add(this.Zoom_OUT);
            this.panel1.Controls.Add(this.zoom_in);
            this.panel1.Location = new System.Drawing.Point(547, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 52);
            this.panel1.TabIndex = 25;
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(402, 9);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(71, 33);
            this.Pesquisa.TabIndex = 5;
            this.Pesquisa.Text = "Pesquisa";
            this.Pesquisa.UseVisualStyleBackColor = true;
            this.Pesquisa.Click += new System.EventHandler(this.Pesquisa_Click);
            // 
            // Seleção
            // 
            this.Seleção.Location = new System.Drawing.Point(325, 9);
            this.Seleção.Name = "Seleção";
            this.Seleção.Size = new System.Drawing.Size(71, 33);
            this.Seleção.TabIndex = 4;
            this.Seleção.Text = "Seleção";
            this.Seleção.UseVisualStyleBackColor = true;
            this.Seleção.Click += new System.EventHandler(this.Seleção_Click);
            // 
            // Regua
            // 
            this.Regua.Location = new System.Drawing.Point(248, 9);
            this.Regua.Name = "Regua";
            this.Regua.Size = new System.Drawing.Size(71, 33);
            this.Regua.TabIndex = 3;
            this.Regua.Text = "Régua";
            this.Regua.UseVisualStyleBackColor = true;
            this.Regua.Click += new System.EventHandler(this.Regua_Click);
            // 
            // Pan_zoom
            // 
            this.Pan_zoom.Location = new System.Drawing.Point(171, 9);
            this.Pan_zoom.Name = "Pan_zoom";
            this.Pan_zoom.Size = new System.Drawing.Size(71, 33);
            this.Pan_zoom.TabIndex = 2;
            this.Pan_zoom.Text = "Pan_Zoom";
            this.Pan_zoom.UseVisualStyleBackColor = true;
            this.Pan_zoom.Click += new System.EventHandler(this.Pan_zoom_Click);
            // 
            // Zoom_OUT
            // 
            this.Zoom_OUT.Location = new System.Drawing.Point(94, 9);
            this.Zoom_OUT.Name = "Zoom_OUT";
            this.Zoom_OUT.Size = new System.Drawing.Size(71, 33);
            this.Zoom_OUT.TabIndex = 1;
            this.Zoom_OUT.Text = "Zoom_Out";
            this.Zoom_OUT.UseVisualStyleBackColor = true;
            this.Zoom_OUT.Click += new System.EventHandler(this.Zoom_OUT_Click);
            // 
            // zoom_in
            // 
            this.zoom_in.Location = new System.Drawing.Point(17, 9);
            this.zoom_in.Name = "zoom_in";
            this.zoom_in.Size = new System.Drawing.Size(71, 33);
            this.zoom_in.TabIndex = 0;
            this.zoom_in.Text = "Zoom_In";
            this.zoom_in.UseVisualStyleBackColor = true;
            this.zoom_in.Click += new System.EventHandler(this.zoom_in_Click);
            // 
            // axMap1
            // 
            this.axMap1.ContextMenuStrip = this.contextMenuStrip1;
            this.axMap1.Enabled = true;
            this.axMap1.Location = new System.Drawing.Point(29, 21);
            this.axMap1.Name = "axMap1";
            this.axMap1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMap1.OcxState")));
            this.axMap1.Size = new System.Drawing.Size(1846, 914);
            this.axMap1.TabIndex = 0;
            this.axMap1.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.axMap1_MouseDownEvent);
            this.axMap1.MouseUpEvent += new AxMapWinGIS._DMapEvents_MouseUpEventHandler(this.axMap1_MouseUpEvent);
            this.axMap1.ShapeIdentified += new AxMapWinGIS._DMapEvents_ShapeIdentifiedEventHandler(this.axMap1_ShapeIdentified);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pesquisa_Interior_PROF,
            this.Pesquisa_Interior_Alunos,
            this.logDoBlocoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 70);
            // 
            // Pesquisa_Interior_PROF
            // 
            this.Pesquisa_Interior_PROF.Name = "Pesquisa_Interior_PROF";
            this.Pesquisa_Interior_PROF.Size = new System.Drawing.Size(183, 22);
            this.Pesquisa_Interior_PROF.Text = "Pesquisa Professores";
            this.Pesquisa_Interior_PROF.Click += new System.EventHandler(this.Pesquisa_Interior_PROF_Click);
            // 
            // Pesquisa_Interior_Alunos
            // 
            this.Pesquisa_Interior_Alunos.Name = "Pesquisa_Interior_Alunos";
            this.Pesquisa_Interior_Alunos.Size = new System.Drawing.Size(183, 22);
            this.Pesquisa_Interior_Alunos.Text = "Pesquisa Alunos";
            this.Pesquisa_Interior_Alunos.Click += new System.EventHandler(this.Pesquisa_Interior_ALUNOS_Click);
            // 
            // logDoBlocoToolStripMenuItem
            // 
            this.logDoBlocoToolStripMenuItem.Name = "logDoBlocoToolStripMenuItem";
            this.logDoBlocoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.logDoBlocoToolStripMenuItem.Text = "Log do Bloco";
            this.logDoBlocoToolStripMenuItem.Click += new System.EventHandler(this.logDoBlocoToolStripMenuItem_Click);
            // 
            // tab_CADASTRO
            // 
            this.tab_CADASTRO.Controls.Add(this.label1);
            this.tab_CADASTRO.Controls.Add(this.dataGridView1);
            this.tab_CADASTRO.Controls.Add(this.label6);
            this.tab_CADASTRO.Controls.Add(this.button5);
            this.tab_CADASTRO.Controls.Add(this.button4);
            this.tab_CADASTRO.Controls.Add(this.button3);
            this.tab_CADASTRO.Controls.Add(this.label3);
            this.tab_CADASTRO.Controls.Add(this.GenderBox);
            this.tab_CADASTRO.Controls.Add(this.TAGbox);
            this.tab_CADASTRO.Controls.Add(this.RespBox);
            this.tab_CADASTRO.Controls.Add(this.BirthBox);
            this.tab_CADASTRO.Controls.Add(this.label5);
            this.tab_CADASTRO.Controls.Add(this.label4);
            this.tab_CADASTRO.Controls.Add(this.Nascimento);
            this.tab_CADASTRO.Controls.Add(this.label2);
            this.tab_CADASTRO.Controls.Add(this.dateTimePicker1);
            this.tab_CADASTRO.Controls.Add(this.button2);
            this.tab_CADASTRO.Controls.Add(this.NomeBox);
            this.tab_CADASTRO.Controls.Add(this.button1);
            this.tab_CADASTRO.Location = new System.Drawing.Point(4, 22);
            this.tab_CADASTRO.Name = "tab_CADASTRO";
            this.tab_CADASTRO.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CADASTRO.Size = new System.Drawing.Size(1972, 974);
            this.tab_CADASTRO.TabIndex = 1;
            this.tab_CADASTRO.Text = "CADASTRO";
            this.tab_CADASTRO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Não Conectado";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 442);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "a2222222 ou p2222222";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(413, 314);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 36;
            this.button5.Text = "Pega TAG";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(393, 46);
            this.button4.TabIndex = 35;
            this.button4.Text = "Limpa Formulário";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 37);
            this.button3.TabIndex = 34;
            this.button3.Text = "Pesquisa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "TAG:";
            // 
            // GenderBox
            // 
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Aluno",
            "Professor",
            "Técnico ADM"});
            this.GenderBox.Location = new System.Drawing.Point(104, 196);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(393, 21);
            this.GenderBox.TabIndex = 32;
            this.GenderBox.SelectedIndexChanged += new System.EventHandler(this.GenderBox_SelectedIndexChanged_1);
            // 
            // TAGbox
            // 
            this.TAGbox.Location = new System.Drawing.Point(104, 314);
            this.TAGbox.Name = "TAGbox";
            this.TAGbox.Size = new System.Drawing.Size(210, 20);
            this.TAGbox.TabIndex = 31;
            this.TAGbox.TextChanged += new System.EventHandler(this.TAGbox_TextChanged_1);
            // 
            // RespBox
            // 
            this.RespBox.Location = new System.Drawing.Point(104, 253);
            this.RespBox.Name = "RespBox";
            this.RespBox.Size = new System.Drawing.Size(393, 20);
            this.RespBox.TabIndex = 30;
            this.RespBox.TextChanged += new System.EventHandler(this.RespBox_TextChanged_1);
            // 
            // BirthBox
            // 
            this.BirthBox.Location = new System.Drawing.Point(104, 148);
            this.BirthBox.Name = "BirthBox";
            this.BirthBox.Size = new System.Drawing.Size(100, 20);
            this.BirthBox.TabIndex = 29;
            this.BirthBox.TextChanged += new System.EventHandler(this.BirthBox_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Função:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Cargo:";
            // 
            // Nascimento
            // 
            this.Nascimento.AutoSize = true;
            this.Nascimento.Location = new System.Drawing.Point(32, 151);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(49, 13);
            this.Nascimento.TabIndex = 26;
            this.Nascimento.Text = "Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nome:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(624, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(226, 20);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "Inserir Cadastro";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // NomeBox
            // 
            this.NomeBox.Location = new System.Drawing.Point(104, 95);
            this.NomeBox.Name = "NomeBox";
            this.NomeBox.Size = new System.Drawing.Size(393, 20);
            this.NomeBox.TabIndex = 21;
            this.NomeBox.TextChanged += new System.EventHandler(this.NomeBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Testar conexão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tab_CONSULTA
            // 
            this.tab_CONSULTA.Controls.Add(this.TagGrid);
            this.tab_CONSULTA.Controls.Add(this.dataGridView2);
            this.tab_CONSULTA.Controls.Add(this.RegBox2);
            this.tab_CONSULTA.Controls.Add(this.Registro);
            this.tab_CONSULTA.Controls.Add(this.label7);
            this.tab_CONSULTA.Controls.Add(this.textBox1);
            this.tab_CONSULTA.Location = new System.Drawing.Point(4, 22);
            this.tab_CONSULTA.Name = "tab_CONSULTA";
            this.tab_CONSULTA.Size = new System.Drawing.Size(1972, 974);
            this.tab_CONSULTA.TabIndex = 2;
            this.tab_CONSULTA.Text = "CONSULTA";
            this.tab_CONSULTA.UseVisualStyleBackColor = true;
            // 
            // TagGrid
            // 
            this.TagGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TagGrid.Location = new System.Drawing.Point(3, 127);
            this.TagGrid.Name = "TagGrid";
            this.TagGrid.Size = new System.Drawing.Size(292, 133);
            this.TagGrid.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(312, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(955, 346);
            this.dataGridView2.TabIndex = 4;
            // 
            // RegBox2
            // 
            this.RegBox2.Location = new System.Drawing.Point(90, 64);
            this.RegBox2.MaxLength = 7;
            this.RegBox2.Name = "RegBox2";
            this.RegBox2.Size = new System.Drawing.Size(157, 20);
            this.RegBox2.TabIndex = 3;
            this.RegBox2.TextChanged += new System.EventHandler(this.RegBox2_TextChanged);
            // 
            // Registro
            // 
            this.Registro.AutoSize = true;
            this.Registro.Location = new System.Drawing.Point(14, 67);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(49, 13);
            this.Registro.TabIndex = 2;
            this.Registro.Text = "Registro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Aluno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tab_VISUALIZAÇÃO);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RF_MAP_LOCATOR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_VISUALIZAÇÃO.ResumeLayout(false);
            this.tab_VISUAL.ResumeLayout(false);
            this.panel_PESQUISA_BLOCO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PESQUISA_BLOCO)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axMap1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.tab_CADASTRO.ResumeLayout(false);
            this.tab_CADASTRO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab_CONSULTA.ResumeLayout(false);
            this.tab_CONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tab_VISUALIZAÇÃO;
        private System.Windows.Forms.TabPage tab_VISUAL;
        private System.Windows.Forms.TabPage tab_CADASTRO;
        private System.Windows.Forms.TabPage tab_CONSULTA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.TextBox TAGbox;
        private System.Windows.Forms.TextBox RespBox;
        private System.Windows.Forms.TextBox BirthBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Nascimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NomeBox;
        private System.Windows.Forms.Button button1;
        private AxMapWinGIS.AxMap axMap1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button zoom_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zoom_OUT;
        private System.Windows.Forms.Button Pan_zoom;
        private System.Windows.Forms.Button Regua;
        private System.Windows.Forms.Button Seleção;
        private System.Windows.Forms.Button Pesquisa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Pesquisa_Interior_PROF;
        private System.Windows.Forms.ToolStripMenuItem Pesquisa_Interior_Alunos;
        private System.Windows.Forms.Panel panel_PESQUISA_BLOCO;
        private System.Windows.Forms.DataGridView dataGridView_PESQUISA_BLOCO;
        private System.Windows.Forms.Button button_FECHAR_PESQUISA_BLOCO;
        private System.Windows.Forms.ToolStripMenuItem logDoBlocoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox RegBox2;
        private System.Windows.Forms.Label Registro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView TagGrid;
    }
}


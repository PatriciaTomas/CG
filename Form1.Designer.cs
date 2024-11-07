namespace desenhaFaces_v1
{
    partial class Form1
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
            this.pb_desenho = new System.Windows.Forms.PictureBox();
            this.CorStroke_pb = new System.Windows.Forms.PictureBox();
            this.CorStroke_btn = new System.Windows.Forms.Button();
            this.CorFill_btn = new System.Windows.Forms.Button();
            this.CorFill_pb = new System.Windows.Forms.PictureBox();
            this.cb_wireframe = new System.Windows.Forms.CheckBox();
            this.Espessura_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ficheiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirâmideQuadrangularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirâmideHexagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prismaPentagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_camara = new System.Windows.Forms.GroupBox();
            this.tb_dist = new System.Windows.Forms.TrackBar();
            this.pb_desenho2 = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rb_persp = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_total_esq = new System.Windows.Forms.Label();
            this.lb_total_dt = new System.Windows.Forms.Label();
            this.bt_reset = new System.Windows.Forms.Button();
            this.gb_cilindro = new System.Windows.Forms.GroupBox();
            this.bt_criaCilindro = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.facesCilindro = new System.Windows.Forms.NumericUpDown();
            this.alturaCilindro = new System.Windows.Forms.NumericUpDown();
            this.rCilindro = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.fdesenhadas_dt = new System.Windows.Forms.Label();
            this.fdesenhadas_esq = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lb_nomeModelo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Roty_tb = new System.Windows.Forms.TrackBar();
            this.Rotx_tb = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Rotz_tb = new System.Windows.Forms.TrackBar();
            this.tb_transz = new System.Windows.Forms.TrackBar();
            this.tb_transy = new System.Windows.Forms.TrackBar();
            this.tb_transx = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_pic2 = new System.Windows.Forms.Label();
            this.lb_pic1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gb_camara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho2)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.gb_cilindro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facesCilindro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCilindro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCilindro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_desenho
            // 
            this.pb_desenho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenho.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenho.Location = new System.Drawing.Point(12, 89);
            this.pb_desenho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_desenho.Name = "pb_desenho";
            this.pb_desenho.Size = new System.Drawing.Size(489, 432);
            this.pb_desenho.TabIndex = 0;
            this.pb_desenho.TabStop = false;
            this.pb_desenho.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_desenho_Paint);
            // 
            // CorStroke_pb
            // 
            this.CorStroke_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_pb.BackColor = System.Drawing.Color.Blue;
            this.CorStroke_pb.Location = new System.Drawing.Point(546, 635);
            this.CorStroke_pb.Margin = new System.Windows.Forms.Padding(4);
            this.CorStroke_pb.Name = "CorStroke_pb";
            this.CorStroke_pb.Size = new System.Drawing.Size(99, 40);
            this.CorStroke_pb.TabIndex = 6;
            this.CorStroke_pb.TabStop = false;
            // 
            // CorStroke_btn
            // 
            this.CorStroke_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorStroke_btn.Location = new System.Drawing.Point(396, 635);
            this.CorStroke_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CorStroke_btn.Name = "CorStroke_btn";
            this.CorStroke_btn.Size = new System.Drawing.Size(142, 40);
            this.CorStroke_btn.TabIndex = 7;
            this.CorStroke_btn.Text = "Cor Contorno";
            this.CorStroke_btn.UseVisualStyleBackColor = true;
            this.CorStroke_btn.Click += new System.EventHandler(this.CorStroke_btn_Click);
            // 
            // CorFill_btn
            // 
            this.CorFill_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_btn.Location = new System.Drawing.Point(396, 683);
            this.CorFill_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CorFill_btn.Name = "CorFill_btn";
            this.CorFill_btn.Size = new System.Drawing.Size(142, 38);
            this.CorFill_btn.TabIndex = 9;
            this.CorFill_btn.Text = "Cor Preenchimento";
            this.CorFill_btn.UseVisualStyleBackColor = true;
            this.CorFill_btn.Click += new System.EventHandler(this.CorFill_btn_Click);
            // 
            // CorFill_pb
            // 
            this.CorFill_pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CorFill_pb.BackColor = System.Drawing.Color.OrangeRed;
            this.CorFill_pb.Location = new System.Drawing.Point(546, 683);
            this.CorFill_pb.Margin = new System.Windows.Forms.Padding(4);
            this.CorFill_pb.Name = "CorFill_pb";
            this.CorFill_pb.Size = new System.Drawing.Size(99, 38);
            this.CorFill_pb.TabIndex = 8;
            this.CorFill_pb.TabStop = false;
            // 
            // cb_wireframe
            // 
            this.cb_wireframe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_wireframe.AutoSize = true;
            this.cb_wireframe.Location = new System.Drawing.Point(667, 541);
            this.cb_wireframe.Margin = new System.Windows.Forms.Padding(4);
            this.cb_wireframe.Name = "cb_wireframe";
            this.cb_wireframe.Size = new System.Drawing.Size(91, 20);
            this.cb_wireframe.TabIndex = 10;
            this.cb_wireframe.Text = "Wireframe";
            this.cb_wireframe.UseVisualStyleBackColor = true;
            this.cb_wireframe.CheckedChanged += new System.EventHandler(this.cb_wireframe_CheckedChanged);
            // 
            // Espessura_nud
            // 
            this.Espessura_nud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Espessura_nud.Location = new System.Drawing.Point(739, 570);
            this.Espessura_nud.Margin = new System.Windows.Forms.Padding(4);
            this.Espessura_nud.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Espessura_nud.Name = "Espessura_nud";
            this.Espessura_nud.Size = new System.Drawing.Size(65, 22);
            this.Espessura_nud.TabIndex = 11;
            this.Espessura_nud.ValueChanged += new System.EventHandler(this.Espessura_nud_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Espessura";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ficheiroToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.formasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1300, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ficheiroToolStripMenuItem
            // 
            this.ficheiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.ficheiroToolStripMenuItem.Name = "ficheiroToolStripMenuItem";
            this.ficheiroToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.ficheiroToolStripMenuItem.Text = "Ficheiro";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtToolStripMenuItem,
            this.objToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.txtToolStripMenuItem.Text = ".txt";
            this.txtToolStripMenuItem.Click += new System.EventHandler(this.txtToolStripMenuItem_Click);
            // 
            // objToolStripMenuItem
            // 
            this.objToolStripMenuItem.Name = "objToolStripMenuItem";
            this.objToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.objToolStripMenuItem.Text = ".obj";
            this.objToolStripMenuItem.Click += new System.EventHandler(this.objToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // formasToolStripMenuItem
            // 
            this.formasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuboToolStripMenuItem,
            this.pirâmideQuadrangularToolStripMenuItem,
            this.pirâmideHexagonalToolStripMenuItem,
            this.prismaPentagonalToolStripMenuItem});
            this.formasToolStripMenuItem.Name = "formasToolStripMenuItem";
            this.formasToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.formasToolStripMenuItem.Text = "Formas";
            // 
            // cuboToolStripMenuItem
            // 
            this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
            this.cuboToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.cuboToolStripMenuItem.Text = "Cubo";
            this.cuboToolStripMenuItem.Click += new System.EventHandler(this.cuboToolStripMenuItem_Click);
            // 
            // pirâmideQuadrangularToolStripMenuItem
            // 
            this.pirâmideQuadrangularToolStripMenuItem.Name = "pirâmideQuadrangularToolStripMenuItem";
            this.pirâmideQuadrangularToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.pirâmideQuadrangularToolStripMenuItem.Text = "Pirâmide Quadrangular";
            this.pirâmideQuadrangularToolStripMenuItem.Click += new System.EventHandler(this.pirâmideQuadrangularToolStripMenuItem_Click);
            // 
            // pirâmideHexagonalToolStripMenuItem
            // 
            this.pirâmideHexagonalToolStripMenuItem.Name = "pirâmideHexagonalToolStripMenuItem";
            this.pirâmideHexagonalToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.pirâmideHexagonalToolStripMenuItem.Text = "Pirâmide Hexagonal";
            this.pirâmideHexagonalToolStripMenuItem.Click += new System.EventHandler(this.pirâmideHexagonalToolStripMenuItem_Click);
            // 
            // prismaPentagonalToolStripMenuItem
            // 
            this.prismaPentagonalToolStripMenuItem.Name = "prismaPentagonalToolStripMenuItem";
            this.prismaPentagonalToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.prismaPentagonalToolStripMenuItem.Text = "Prisma Pentagonal";
            this.prismaPentagonalToolStripMenuItem.Click += new System.EventHandler(this.prismaPentagonalToolStripMenuItem_Click);
            // 
            // gb_camara
            // 
            this.gb_camara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_camara.Controls.Add(this.tb_dist);
            this.gb_camara.Location = new System.Drawing.Point(13, 527);
            this.gb_camara.Margin = new System.Windows.Forms.Padding(4);
            this.gb_camara.Name = "gb_camara";
            this.gb_camara.Padding = new System.Windows.Forms.Padding(4);
            this.gb_camara.Size = new System.Drawing.Size(367, 93);
            this.gb_camara.TabIndex = 20;
            this.gb_camara.TabStop = false;
            this.gb_camara.Text = "Distância à Câmara";
            // 
            // tb_dist
            // 
            this.tb_dist.Location = new System.Drawing.Point(29, 30);
            this.tb_dist.Minimum = 1;
            this.tb_dist.Name = "tb_dist";
            this.tb_dist.Size = new System.Drawing.Size(320, 56);
            this.tb_dist.TabIndex = 0;
            this.tb_dist.Value = 1;
            this.tb_dist.ValueChanged += new System.EventHandler(this.tb_escala_ValueChanged);
            // 
            // pb_desenho2
            // 
            this.pb_desenho2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_desenho2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pb_desenho2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_desenho2.Location = new System.Drawing.Point(831, 89);
            this.pb_desenho2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pb_desenho2.Name = "pb_desenho2";
            this.pb_desenho2.Size = new System.Drawing.Size(457, 432);
            this.pb_desenho2.TabIndex = 27;
            this.pb_desenho2.TabStop = false;
            this.pb_desenho2.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_desenho2_Paint);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.rb_persp);
            this.groupBox7.Controls.Add(this.radioButton1);
            this.groupBox7.Location = new System.Drawing.Point(396, 527);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(249, 93);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tipo de Projeção";
            // 
            // rb_persp
            // 
            this.rb_persp.AutoSize = true;
            this.rb_persp.Checked = true;
            this.rb_persp.Location = new System.Drawing.Point(137, 39);
            this.rb_persp.Name = "rb_persp";
            this.rb_persp.Size = new System.Drawing.Size(93, 20);
            this.rb_persp.TabIndex = 1;
            this.rb_persp.TabStop = true;
            this.rb_persp.Text = "Perspetiva";
            this.rb_persp.UseVisualStyleBackColor = true;
            this.rb_persp.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(26, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(79, 20);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Paralela";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 16);
            this.label14.TabIndex = 28;
            // 
            // lb_total_esq
            // 
            this.lb_total_esq.AutoSize = true;
            this.lb_total_esq.Location = new System.Drawing.Point(28, 101);
            this.lb_total_esq.Name = "lb_total_esq";
            this.lb_total_esq.Size = new System.Drawing.Size(48, 16);
            this.lb_total_esq.TabIndex = 29;
            this.lb_total_esq.Text = "lb_esq";
            // 
            // lb_total_dt
            // 
            this.lb_total_dt.AutoSize = true;
            this.lb_total_dt.Location = new System.Drawing.Point(842, 101);
            this.lb_total_dt.Name = "lb_total_dt";
            this.lb_total_dt.Size = new System.Drawing.Size(51, 16);
            this.lb_total_dt.TabIndex = 30;
            this.lb_total_dt.Text = "label16";
            // 
            // bt_reset
            // 
            this.bt_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_reset.Location = new System.Drawing.Point(701, 625);
            this.bt_reset.Margin = new System.Windows.Forms.Padding(4);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(80, 50);
            this.bt_reset.TabIndex = 31;
            this.bt_reset.Text = "Reset de Valores";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // gb_cilindro
            // 
            this.gb_cilindro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_cilindro.Controls.Add(this.bt_criaCilindro);
            this.gb_cilindro.Controls.Add(this.label19);
            this.gb_cilindro.Controls.Add(this.label18);
            this.gb_cilindro.Controls.Add(this.label17);
            this.gb_cilindro.Controls.Add(this.facesCilindro);
            this.gb_cilindro.Controls.Add(this.alturaCilindro);
            this.gb_cilindro.Controls.Add(this.rCilindro);
            this.gb_cilindro.Location = new System.Drawing.Point(831, 541);
            this.gb_cilindro.Margin = new System.Windows.Forms.Padding(4);
            this.gb_cilindro.Name = "gb_cilindro";
            this.gb_cilindro.Padding = new System.Windows.Forms.Padding(4);
            this.gb_cilindro.Size = new System.Drawing.Size(456, 192);
            this.gb_cilindro.TabIndex = 27;
            this.gb_cilindro.TabStop = false;
            this.gb_cilindro.Text = "Criar um cilindro";
            // 
            // bt_criaCilindro
            // 
            this.bt_criaCilindro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_criaCilindro.Location = new System.Drawing.Point(170, 136);
            this.bt_criaCilindro.Margin = new System.Windows.Forms.Padding(4);
            this.bt_criaCilindro.Name = "bt_criaCilindro";
            this.bt_criaCilindro.Size = new System.Drawing.Size(126, 29);
            this.bt_criaCilindro.TabIndex = 32;
            this.bt_criaCilindro.Text = "Criar";
            this.bt_criaCilindro.UseVisualStyleBackColor = true;
            this.bt_criaCilindro.Click += new System.EventHandler(this.bt_criaCilindro_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(337, 56);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "Nº de Faces";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(202, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Altura";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 16);
            this.label17.TabIndex = 3;
            this.label17.Text = "Raio";
            // 
            // facesCilindro
            // 
            this.facesCilindro.Location = new System.Drawing.Point(320, 88);
            this.facesCilindro.Name = "facesCilindro";
            this.facesCilindro.Size = new System.Drawing.Size(120, 22);
            this.facesCilindro.TabIndex = 2;
            this.facesCilindro.ValueChanged += new System.EventHandler(this.facesCilindro_ValueChanged);
            // 
            // alturaCilindro
            // 
            this.alturaCilindro.Location = new System.Drawing.Point(170, 88);
            this.alturaCilindro.Name = "alturaCilindro";
            this.alturaCilindro.Size = new System.Drawing.Size(120, 22);
            this.alturaCilindro.TabIndex = 1;
            this.alturaCilindro.ValueChanged += new System.EventHandler(this.alturaCilindro_ValueChanged);
            // 
            // rCilindro
            // 
            this.rCilindro.Location = new System.Drawing.Point(24, 88);
            this.rCilindro.Name = "rCilindro";
            this.rCilindro.Size = new System.Drawing.Size(120, 22);
            this.rCilindro.TabIndex = 0;
            this.rCilindro.ValueChanged += new System.EventHandler(this.rCilindro_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(200, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(831, 25);
            this.label15.TabIndex = 32;
            this.label15.Text = "Proposta 5 – Demonstração do efeito da ordem das transformações aplicadas a um mo" +
    "delo";
            // 
            // fdesenhadas_dt
            // 
            this.fdesenhadas_dt.AutoSize = true;
            this.fdesenhadas_dt.Location = new System.Drawing.Point(842, 128);
            this.fdesenhadas_dt.Name = "fdesenhadas_dt";
            this.fdesenhadas_dt.Size = new System.Drawing.Size(48, 16);
            this.fdesenhadas_dt.TabIndex = 34;
            this.fdesenhadas_dt.Text = "lb_esq";
            // 
            // fdesenhadas_esq
            // 
            this.fdesenhadas_esq.AutoSize = true;
            this.fdesenhadas_esq.Location = new System.Drawing.Point(28, 128);
            this.fdesenhadas_esq.Name = "fdesenhadas_esq";
            this.fdesenhadas_esq.Size = new System.Drawing.Size(48, 16);
            this.fdesenhadas_esq.TabIndex = 35;
            this.fdesenhadas_esq.Text = "lb_esq";
            // 
            // lb_nomeModelo
            // 
            this.lb_nomeModelo.AutoSize = true;
            this.lb_nomeModelo.Location = new System.Drawing.Point(31, 154);
            this.lb_nomeModelo.Name = "lb_nomeModelo";
            this.lb_nomeModelo.Size = new System.Drawing.Size(51, 16);
            this.lb_nomeModelo.TabIndex = 36;
            this.lb_nomeModelo.Text = "label16";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Roty_tb
            // 
            this.Roty_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Roty_tb.Location = new System.Drawing.Point(51, 81);
            this.Roty_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Roty_tb.Maximum = 180;
            this.Roty_tb.Minimum = -180;
            this.Roty_tb.Name = "Roty_tb";
            this.Roty_tb.Size = new System.Drawing.Size(185, 56);
            this.Roty_tb.TabIndex = 45;
            // 
            // Rotx_tb
            // 
            this.Rotx_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotx_tb.Location = new System.Drawing.Point(51, 21);
            this.Rotx_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rotx_tb.Maximum = 180;
            this.Rotx_tb.Minimum = -180;
            this.Rotx_tb.Name = "Rotx_tb";
            this.Rotx_tb.Size = new System.Drawing.Size(185, 56);
            this.Rotx_tb.TabIndex = 44;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Roty_tb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Rotx_tb);
            this.groupBox2.Controls.Add(this.Rotz_tb);
            this.groupBox2.Location = new System.Drawing.Point(546, 310);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(249, 199);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rotação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // Rotz_tb
            // 
            this.Rotz_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rotz_tb.Location = new System.Drawing.Point(51, 135);
            this.Rotz_tb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Rotz_tb.Maximum = 180;
            this.Rotz_tb.Minimum = -180;
            this.Rotz_tb.Name = "Rotz_tb";
            this.Rotz_tb.Size = new System.Drawing.Size(185, 56);
            this.Rotz_tb.TabIndex = 4;
            // 
            // tb_transz
            // 
            this.tb_transz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transz.Location = new System.Drawing.Point(51, 138);
            this.tb_transz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_transz.Maximum = 0;
            this.tb_transz.Minimum = -50;
            this.tb_transz.Name = "tb_transz";
            this.tb_transz.Size = new System.Drawing.Size(185, 56);
            this.tb_transz.TabIndex = 4;
            // 
            // tb_transy
            // 
            this.tb_transy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transy.Location = new System.Drawing.Point(51, 86);
            this.tb_transy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_transy.Maximum = 50;
            this.tb_transy.Minimum = -50;
            this.tb_transy.Name = "tb_transy";
            this.tb_transy.Size = new System.Drawing.Size(185, 56);
            this.tb_transy.TabIndex = 42;
            // 
            // tb_transx
            // 
            this.tb_transx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_transx.Location = new System.Drawing.Point(597, 125);
            this.tb_transx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_transx.Maximum = 50;
            this.tb_transx.Minimum = -50;
            this.tb_transx.Name = "tb_transx";
            this.tb_transx.Size = new System.Drawing.Size(185, 56);
            this.tb_transx.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_transz);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_transy);
            this.groupBox1.Location = new System.Drawing.Point(546, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(249, 203);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translação";
            // 
            // lb_pic2
            // 
            this.lb_pic2.AutoSize = true;
            this.lb_pic2.Location = new System.Drawing.Point(1071, 99);
            this.lb_pic2.Name = "lb_pic2";
            this.lb_pic2.Size = new System.Drawing.Size(50, 16);
            this.lb_pic2.TabIndex = 47;
            this.lb_pic2.Text = "lb_pic2";
            this.lb_pic2.Click += new System.EventHandler(this.lb_pic2_Click);
            // 
            // lb_pic1
            // 
            this.lb_pic1.AutoSize = true;
            this.lb_pic1.Location = new System.Drawing.Point(277, 101);
            this.lb_pic1.Name = "lb_pic1";
            this.lb_pic1.Size = new System.Drawing.Size(50, 16);
            this.lb_pic1.TabIndex = 48;
            this.lb_pic1.Text = "lb_pic1";
            this.lb_pic1.Click += new System.EventHandler(this.lb_pic1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 797);
            this.Controls.Add(this.lb_pic1);
            this.Controls.Add(this.lb_pic2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tb_transx);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lb_nomeModelo);
            this.Controls.Add(this.fdesenhadas_esq);
            this.Controls.Add(this.fdesenhadas_dt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.gb_cilindro);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.lb_total_dt);
            this.Controls.Add(this.lb_total_esq);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.pb_desenho2);
            this.Controls.Add(this.gb_camara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Espessura_nud);
            this.Controls.Add(this.cb_wireframe);
            this.Controls.Add(this.CorFill_btn);
            this.Controls.Add(this.CorFill_pb);
            this.Controls.Add(this.CorStroke_btn);
            this.Controls.Add(this.CorStroke_pb);
            this.Controls.Add(this.pb_desenho);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1281, 776);
            this.Name = "Form1";
            this.Text = "Desenho de Faces Poligonais";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorStroke_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorFill_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Espessura_nud)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_camara.ResumeLayout(false);
            this.gb_camara.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_dist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_desenho2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gb_cilindro.ResumeLayout(false);
            this.gb_cilindro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facesCilindro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaCilindro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rCilindro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Roty_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rotx_tb)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rotz_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_transx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_desenho;
        private System.Windows.Forms.PictureBox CorStroke_pb;
        private System.Windows.Forms.Button CorStroke_btn;
        private System.Windows.Forms.Button CorFill_btn;
        private System.Windows.Forms.PictureBox CorFill_pb;
        private System.Windows.Forms.CheckBox cb_wireframe;
        private System.Windows.Forms.NumericUpDown Espessura_nud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ficheiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirâmideQuadrangularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirâmideHexagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prismaPentagonalToolStripMenuItem;
        private System.Windows.Forms.GroupBox gb_camara;
        private System.Windows.Forms.PictureBox pb_desenho2;
        private System.Windows.Forms.TrackBar tb_dist;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rb_persp;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_total_esq;
        private System.Windows.Forms.Label lb_total_dt;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.GroupBox gb_cilindro;
        private System.Windows.Forms.Button bt_criaCilindro;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown facesCilindro;
        private System.Windows.Forms.NumericUpDown alturaCilindro;
        private System.Windows.Forms.NumericUpDown rCilindro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label fdesenhadas_dt;
        private System.Windows.Forms.Label fdesenhadas_esq;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lb_nomeModelo;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TrackBar Roty_tb;
        private System.Windows.Forms.TrackBar Rotx_tb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar Rotz_tb;
        private System.Windows.Forms.TrackBar tb_transz;
        private System.Windows.Forms.TrackBar tb_transy;
        private System.Windows.Forms.TrackBar tb_transx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_pic2;
        private System.Windows.Forms.Label lb_pic1;
    }
}


namespace XTBS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.lblku = new System.Windows.Forms.Label();
            this.lbltu = new System.Windows.Forms.Label();
            this.txtku = new System.Windows.Forms.TextBox();
            this.txtwu = new System.Windows.Forms.TextBox();
            this.lblT = new System.Windows.Forms.Label();
            this.txtt = new System.Windows.Forms.TextBox();
            this.lbljd = new System.Windows.Forms.Label();
            this.txth = new System.Windows.Forms.TextBox();
            this.lblyk = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.btnwct = new System.Windows.Forms.Button();
            this.btnsdct = new System.Windows.Forms.Button();
            this.btnsypi = new System.Windows.Forms.Button();
            this.btntlpi = new System.Windows.Forms.Button();
            this.btnznpi = new System.Windows.Forms.Button();
            this.btnzn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.lblgain = new System.Windows.Forms.Label();
            this.lbldelay = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.txtkp = new System.Windows.Forms.TextBox();
            this.txtdelay = new System.Windows.Forms.TextBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.lblsample = new System.Windows.Forms.Label();
            this.txtsample = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(800, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "继电反馈PID参数整定";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblku
            // 
            this.lblku.AutoSize = true;
            this.lblku.Location = new System.Drawing.Point(1690, 190);
            this.lblku.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblku.Name = "lblku";
            this.lblku.Size = new System.Drawing.Size(133, 30);
            this.lblku.TabIndex = 3;
            this.lblku.Text = "临界幅值";
            // 
            // lbltu
            // 
            this.lbltu.AutoSize = true;
            this.lbltu.Location = new System.Drawing.Point(1690, 268);
            this.lbltu.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltu.Name = "lbltu";
            this.lbltu.Size = new System.Drawing.Size(133, 30);
            this.lbltu.TabIndex = 4;
            this.lbltu.Text = "临界频率";
            // 
            // txtku
            // 
            this.txtku.AllowDrop = true;
            this.txtku.Location = new System.Drawing.Point(1838, 182);
            this.txtku.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtku.Multiline = true;
            this.txtku.Name = "txtku";
            this.txtku.ReadOnly = true;
            this.txtku.Size = new System.Drawing.Size(162, 46);
            this.txtku.TabIndex = 5;
            this.txtku.TextChanged += new System.EventHandler(this.txtku_TextChanged);
            // 
            // txtwu
            // 
            this.txtwu.Location = new System.Drawing.Point(1838, 260);
            this.txtwu.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtwu.Name = "txtwu";
            this.txtwu.ReadOnly = true;
            this.txtwu.Size = new System.Drawing.Size(162, 42);
            this.txtwu.TabIndex = 6;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT.Location = new System.Drawing.Point(68, 268);
            this.lblT.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(147, 33);
            this.lblT.TabIndex = 7;
            this.lblT.Text = "振荡周期";
            // 
            // txtt
            // 
            this.txtt.Location = new System.Drawing.Point(230, 255);
            this.txtt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtt.Name = "txtt";
            this.txtt.Size = new System.Drawing.Size(176, 42);
            this.txtt.TabIndex = 8;
            this.txtt.TextChanged += new System.EventHandler(this.txtt_TextChanged);
            // 
            // lbljd
            // 
            this.lbljd.AutoSize = true;
            this.lbljd.Location = new System.Drawing.Point(52, 330);
            this.lbljd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbljd.Name = "lbljd";
            this.lbljd.Size = new System.Drawing.Size(163, 30);
            this.lbljd.TabIndex = 9;
            this.lbljd.Text = "继电器幅值";
            // 
            // txth
            // 
            this.txth.Location = new System.Drawing.Point(230, 330);
            this.txth.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txth.Name = "txth";
            this.txth.Size = new System.Drawing.Size(176, 42);
            this.txth.TabIndex = 8;
            // 
            // lblyk
            // 
            this.lblyk.AutoSize = true;
            this.lblyk.Location = new System.Drawing.Point(72, 402);
            this.lblyk.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblyk.Name = "lblyk";
            this.lblyk.Size = new System.Drawing.Size(133, 30);
            this.lblyk.TabIndex = 9;
            this.lblyk.Text = "振荡幅值";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(230, 395);
            this.txta.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(176, 42);
            this.txta.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtD);
            this.groupBox1.Controls.Add(this.txtI);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.txtP);
            this.groupBox1.Controls.Add(this.btnwct);
            this.groupBox1.Controls.Add(this.btnsdct);
            this.groupBox1.Controls.Add(this.btnsypi);
            this.groupBox1.Controls.Add(this.btntlpi);
            this.groupBox1.Controls.Add(this.btnznpi);
            this.groupBox1.Controls.Add(this.btnzn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(102, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(1930, 475);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "整定";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(1705, 275);
            this.txtD.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(192, 74);
            this.txtD.TabIndex = 4;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(1705, 182);
            this.txtI.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtI.Multiline = true;
            this.txtI.Name = "txtI";
            this.txtI.ReadOnly = true;
            this.txtI.Size = new System.Drawing.Size(192, 74);
            this.txtI.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(972, 258);
            this.textBox4.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(486, 189);
            this.textBox4.TabIndex = 4;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(1705, 88);
            this.txtP.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(192, 74);
            this.txtP.TabIndex = 4;
            // 
            // btnwct
            // 
            this.btnwct.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnwct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnwct.Location = new System.Drawing.Point(70, 362);
            this.btnwct.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnwct.Name = "btnwct";
            this.btnwct.Size = new System.Drawing.Size(322, 90);
            this.btnwct.TabIndex = 3;
            this.btnwct.Text = "无超调";
            this.btnwct.UseVisualStyleBackColor = true;
            this.btnwct.Click += new System.EventHandler(this.btnwct_Click);
            // 
            // btnsdct
            // 
            this.btnsdct.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnsdct.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsdct.Location = new System.Drawing.Point(70, 258);
            this.btnsdct.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnsdct.Name = "btnsdct";
            this.btnsdct.Size = new System.Drawing.Size(322, 90);
            this.btnsdct.TabIndex = 3;
            this.btnsdct.Text = "适度超调";
            this.btnsdct.UseVisualStyleBackColor = true;
            this.btnsdct.Click += new System.EventHandler(this.btnsdct_Click);
            // 
            // btnsypi
            // 
            this.btnsypi.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnsypi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnsypi.Location = new System.Drawing.Point(480, 362);
            this.btnsypi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnsypi.Name = "btnsypi";
            this.btnsypi.Size = new System.Drawing.Size(322, 90);
            this.btnsypi.TabIndex = 3;
            this.btnsypi.Text = "Shen-Yu";
            this.btnsypi.UseVisualStyleBackColor = true;
            this.btnsypi.Click += new System.EventHandler(this.btnsypi_Click);
            // 
            // btntlpi
            // 
            this.btntlpi.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btntlpi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btntlpi.Location = new System.Drawing.Point(480, 258);
            this.btntlpi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btntlpi.Name = "btntlpi";
            this.btntlpi.Size = new System.Drawing.Size(322, 90);
            this.btntlpi.TabIndex = 3;
            this.btntlpi.Text = "Tyreus-Luben";
            this.btntlpi.UseVisualStyleBackColor = true;
            this.btntlpi.Click += new System.EventHandler(this.btntlpi_Click);
            // 
            // btnznpi
            // 
            this.btnznpi.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnznpi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnznpi.Location = new System.Drawing.Point(480, 152);
            this.btnznpi.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnznpi.Name = "btnznpi";
            this.btnznpi.Size = new System.Drawing.Size(322, 90);
            this.btnznpi.TabIndex = 3;
            this.btnznpi.Text = "Z-N";
            this.btnznpi.UseVisualStyleBackColor = true;
            this.btnznpi.Click += new System.EventHandler(this.btnznpi_Click);
            // 
            // btnzn
            // 
            this.btnzn.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnzn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnzn.Location = new System.Drawing.Point(70, 152);
            this.btnzn.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnzn.Name = "btnzn";
            this.btnzn.Size = new System.Drawing.Size(322, 90);
            this.btnzn.TabIndex = 3;
            this.btnzn.Text = "Z-N";
            this.btnzn.UseVisualStyleBackColor = true;
            this.btnzn.Click += new System.EventHandler(this.btnzn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1642, 278);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 48);
            this.label5.TabIndex = 2;
            this.label5.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1642, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 48);
            this.label4.TabIndex = 2;
            this.label4.Text = "I";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1642, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(950, 158);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 70);
            this.label7.TabIndex = 1;
            this.label7.Text = "辨识模型";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(490, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(295, 70);
            this.label6.TabIndex = 1;
            this.label6.Text = "PI整定规则";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(58, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 70);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID整定规则";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(2050, 53);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.返回ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(190, 46);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 返回ToolStripMenuItem
            // 
            this.返回ToolStripMenuItem.Name = "返回ToolStripMenuItem";
            this.返回ToolStripMenuItem.Size = new System.Drawing.Size(190, 46);
            this.返回ToolStripMenuItem.Text = "返回";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(190, 46);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.编辑ToolStripMenuItem.Text = "数据";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(190, 46);
            this.导出ToolStripMenuItem.Text = "导出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 35, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2050, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 100);
            this.button1.TabIndex = 14;
            this.button1.Text = "数据导入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblgain
            // 
            this.lblgain.AutoSize = true;
            this.lblgain.Location = new System.Drawing.Point(1690, 352);
            this.lblgain.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblgain.Name = "lblgain";
            this.lblgain.Size = new System.Drawing.Size(133, 30);
            this.lblgain.TabIndex = 4;
            this.lblgain.Text = "模型增益";
            // 
            // lbldelay
            // 
            this.lbldelay.AutoSize = true;
            this.lbldelay.Location = new System.Drawing.Point(1690, 430);
            this.lbldelay.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbldelay.Name = "lbldelay";
            this.lbldelay.Size = new System.Drawing.Size(133, 30);
            this.lbldelay.TabIndex = 4;
            this.lbldelay.Text = "模型延时";
            this.lbldelay.Click += new System.EventHandler(this.label9_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(1690, 500);
            this.lbltime.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(133, 30);
            this.lbltime.TabIndex = 4;
            this.lbltime.Text = "时间常数";
            // 
            // txtkp
            // 
            this.txtkp.Location = new System.Drawing.Point(1838, 338);
            this.txtkp.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtkp.Name = "txtkp";
            this.txtkp.ReadOnly = true;
            this.txtkp.Size = new System.Drawing.Size(162, 42);
            this.txtkp.TabIndex = 6;
            // 
            // txtdelay
            // 
            this.txtdelay.Location = new System.Drawing.Point(1838, 415);
            this.txtdelay.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtdelay.Name = "txtdelay";
            this.txtdelay.ReadOnly = true;
            this.txtdelay.Size = new System.Drawing.Size(162, 42);
            this.txtdelay.TabIndex = 6;
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(1838, 488);
            this.txttime.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(162, 42);
            this.txttime.TabIndex = 6;
            // 
            // lblsample
            // 
            this.lblsample.AutoSize = true;
            this.lblsample.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblsample.Location = new System.Drawing.Point(68, 202);
            this.lblsample.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblsample.Name = "lblsample";
            this.lblsample.Size = new System.Drawing.Size(147, 33);
            this.lblsample.TabIndex = 7;
            this.lblsample.Text = "采样时间";
            // 
            // txtsample
            // 
            this.txtsample.Location = new System.Drawing.Point(230, 188);
            this.txtsample.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtsample.Name = "txtsample";
            this.txtsample.Size = new System.Drawing.Size(176, 42);
            this.txtsample.TabIndex = 8;
            this.txtsample.TextChanged += new System.EventHandler(this.txtt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1178, 110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 148);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XTBS.Properties.Resources.继电反馈辨识;
            this.pictureBox1.Location = new System.Drawing.Point(445, 195);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1230, 362);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2050, 1182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblyk);
            this.Controls.Add(this.lbljd);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.txth);
            this.Controls.Add(this.txtsample);
            this.Controls.Add(this.txtt);
            this.Controls.Add(this.lblsample);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.txtdelay);
            this.Controls.Add(this.txtkp);
            this.Controls.Add(this.txtwu);
            this.Controls.Add(this.txtku);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldelay);
            this.Controls.Add(this.lblgain);
            this.Controls.Add(this.lbltu);
            this.Controls.Add(this.lblku);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form4";
            this.Text = "继电反馈";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblku;
        private System.Windows.Forms.Label lbltu;
        private System.Windows.Forms.TextBox txtku;
        private System.Windows.Forms.TextBox txtwu;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.TextBox txtt;
        private System.Windows.Forms.Label lbljd;
        private System.Windows.Forms.TextBox txth;
        private System.Windows.Forms.Label lblyk;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnzn;
        private System.Windows.Forms.Button btnsdct;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Button btnwct;
        private System.Windows.Forms.Button btnsypi;
        private System.Windows.Forms.Button btntlpi;
        private System.Windows.Forms.Button btnznpi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ToolStripMenuItem 返回ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblgain;
        private System.Windows.Forms.Label lbldelay;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.TextBox txtkp;
        private System.Windows.Forms.TextBox txtdelay;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.Label lblsample;
        private System.Windows.Forms.TextBox txtsample;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
    }
}
namespace XTBS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.参数辨识ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.一般最小二乘法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.递推最小二乘法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.阻尼最小二乘法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增广最小二乘法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.继电反馈辨识ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统辨识ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制器参数整定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.性能评估ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btncszd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnxnpg = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnOPC = new System.Windows.Forms.Button();
            this.lblcs = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.参数辨识ToolStripMenuItem1,
            this.继电反馈辨识ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.系统辨识ToolStripMenuItem;
            this.contextMenuStrip1.Size = new System.Drawing.Size(275, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 参数辨识ToolStripMenuItem1
            // 
            this.参数辨识ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一般最小二乘法ToolStripMenuItem,
            this.递推最小二乘法ToolStripMenuItem,
            this.阻尼最小二乘法ToolStripMenuItem,
            this.增广最小二乘法ToolStripMenuItem});
            this.参数辨识ToolStripMenuItem1.Name = "参数辨识ToolStripMenuItem1";
            this.参数辨识ToolStripMenuItem1.Size = new System.Drawing.Size(274, 44);
            this.参数辨识ToolStripMenuItem1.Text = "参数辨识";
            // 
            // 一般最小二乘法ToolStripMenuItem
            // 
            this.一般最小二乘法ToolStripMenuItem.Name = "一般最小二乘法ToolStripMenuItem";
            this.一般最小二乘法ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.一般最小二乘法ToolStripMenuItem.Text = "一般最小二乘法";
            this.一般最小二乘法ToolStripMenuItem.Click += new System.EventHandler(this.一般最小二乘法ToolStripMenuItem_Click);
            // 
            // 递推最小二乘法ToolStripMenuItem
            // 
            this.递推最小二乘法ToolStripMenuItem.Name = "递推最小二乘法ToolStripMenuItem";
            this.递推最小二乘法ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.递推最小二乘法ToolStripMenuItem.Text = "递推最小二乘法";
            // 
            // 阻尼最小二乘法ToolStripMenuItem
            // 
            this.阻尼最小二乘法ToolStripMenuItem.Name = "阻尼最小二乘法ToolStripMenuItem";
            this.阻尼最小二乘法ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.阻尼最小二乘法ToolStripMenuItem.Text = "阻尼最小二乘法";
            // 
            // 增广最小二乘法ToolStripMenuItem
            // 
            this.增广最小二乘法ToolStripMenuItem.Name = "增广最小二乘法ToolStripMenuItem";
            this.增广最小二乘法ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.增广最小二乘法ToolStripMenuItem.Text = "增广最小二乘法";
            // 
            // 继电反馈辨识ToolStripMenuItem1
            // 
            this.继电反馈辨识ToolStripMenuItem1.Name = "继电反馈辨识ToolStripMenuItem1";
            this.继电反馈辨识ToolStripMenuItem1.Size = new System.Drawing.Size(274, 44);
            this.继电反馈辨识ToolStripMenuItem1.Text = "继电反馈辨识";
            this.继电反馈辨识ToolStripMenuItem1.Click += new System.EventHandler(this.继电反馈辨识ToolStripMenuItem1_Click);
            // 
            // 系统辨识ToolStripMenuItem
            // 
            this.系统辨识ToolStripMenuItem.DropDown = this.contextMenuStrip1;
            this.系统辨识ToolStripMenuItem.Name = "系统辨识ToolStripMenuItem";
            this.系统辨识ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.系统辨识ToolStripMenuItem.Text = "系统辨识";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 53);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(190, 46);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统辨识ToolStripMenuItem,
            this.控制器参数整定ToolStripMenuItem,
            this.性能评估ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 控制器参数整定ToolStripMenuItem
            // 
            this.控制器参数整定ToolStripMenuItem.Name = "控制器参数整定ToolStripMenuItem";
            this.控制器参数整定ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.控制器参数整定ToolStripMenuItem.Text = "控制器参数整定";
            // 
            // 性能评估ToolStripMenuItem
            // 
            this.性能评估ToolStripMenuItem.Name = "性能评估ToolStripMenuItem";
            this.性能评估ToolStripMenuItem.Size = new System.Drawing.Size(340, 46);
            this.性能评估ToolStripMenuItem.Text = "性能评估";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(89, 43);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnbs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btncszd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnxnpg);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.btnOPC);
            this.panel1.Controls.Add(this.lblcs);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(109, 92);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 703);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(616, 660);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "OPC数据处理";
            // 
            // btnbs
            // 
            this.btnbs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnbs.ContextMenuStrip = this.contextMenuStrip1;
            this.btnbs.FlatAppearance.BorderSize = 0;
            this.btnbs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbs.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnbs.ForeColor = System.Drawing.Color.Transparent;
            this.btnbs.Image = global::XTBS.Properties.Resources.xtbs_3;
            this.btnbs.Location = new System.Drawing.Point(623, 27);
            this.btnbs.Margin = new System.Windows.Forms.Padding(0);
            this.btnbs.Name = "btnbs";
            this.btnbs.Size = new System.Drawing.Size(218, 124);
            this.btnbs.TabIndex = 0;
            this.btnbs.UseVisualStyleBackColor = true;
            this.btnbs.Click += new System.EventHandler(this.button1_Click);
            this.btnbs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbs_MouseClick);
            this.btnbs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnbs_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(601, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "控制回路性能评估";
            // 
            // btncszd
            // 
            this.btncszd.BackgroundImage = global::XTBS.Properties.Resources._1570603839_2_;
            this.btncszd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btncszd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncszd.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btncszd.ForeColor = System.Drawing.Color.Transparent;
            this.btncszd.Location = new System.Drawing.Point(618, 190);
            this.btncszd.Margin = new System.Windows.Forms.Padding(0);
            this.btncszd.Name = "btncszd";
            this.btncszd.Size = new System.Drawing.Size(218, 124);
            this.btncszd.TabIndex = 4;
            this.btncszd.UseVisualStyleBackColor = true;
            this.btncszd.Click += new System.EventHandler(this.btncszd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(616, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "控制器参数整定";
            // 
            // btnxnpg
            // 
            this.btnxnpg.BackgroundImage = global::XTBS.Properties.Resources._1570610979_1_1;
            this.btnxnpg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnxnpg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnxnpg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnxnpg.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnxnpg.Location = new System.Drawing.Point(618, 364);
            this.btnxnpg.Margin = new System.Windows.Forms.Padding(8);
            this.btnxnpg.Name = "btnxnpg";
            this.btnxnpg.Size = new System.Drawing.Size(218, 124);
            this.btnxnpg.TabIndex = 4;
            this.btnxnpg.UseVisualStyleBackColor = true;
            this.btnxnpg.Click += new System.EventHandler(this.btnxnpg_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl1.Location = new System.Drawing.Point(663, 151);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(137, 39);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "辨识方法";
            // 
            // btnOPC
            // 
            this.btnOPC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOPC.BackgroundImage")));
            this.btnOPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOPC.FlatAppearance.BorderSize = 0;
            this.btnOPC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOPC.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOPC.ForeColor = System.Drawing.Color.Transparent;
            this.btnOPC.Location = new System.Drawing.Point(618, 530);
            this.btnOPC.Margin = new System.Windows.Forms.Padding(0);
            this.btnOPC.Name = "btnOPC";
            this.btnOPC.Size = new System.Drawing.Size(213, 123);
            this.btnOPC.TabIndex = 0;
            this.btnOPC.UseVisualStyleBackColor = true;
            this.btnOPC.Click += new System.EventHandler(this.btnOPC_Click);
            this.btnOPC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnbs_MouseClick);
            this.btnOPC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnbs_MouseDown);
            // 
            // lblcs
            // 
            this.lblcs.AutoSize = true;
            this.lblcs.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblcs.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblcs.Location = new System.Drawing.Point(129, 581);
            this.lblcs.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcs.Name = "lblcs";
            this.lblcs.Size = new System.Drawing.Size(307, 73);
            this.lblcs.TabIndex = 3;
            this.lblcs.Text = "控制工作台";
            this.lblcs.Click += new System.EventHandler(this.lblcs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::XTBS.Properties.Resources._1570518647_1_;
            this.pictureBox1.Location = new System.Drawing.Point(72, 38);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(492, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 867);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "控制工作台";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 参数辨识ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 继电反馈辨识ToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统辨识ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制器参数整定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 性能评估ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一般最小二乘法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 递推最小二乘法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 阻尼最小二乘法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增广最小二乘法ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncszd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxnpg;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnOPC;
        private System.Windows.Forms.Label lblcs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


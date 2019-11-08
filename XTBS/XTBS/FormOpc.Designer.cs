namespace XTBS
{
    partial class FormOpc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbServer = new System.Windows.Forms.ComboBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnOPC = new System.Windows.Forms.Button();
            this.btnSetItem = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnGetGrps = new System.Windows.Forms.Button();
            this.btnConIP = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtMyValue = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbServer);
            this.groupBox1.Controls.Add(this.lstItems);
            this.groupBox1.Controls.Add(this.btnOPC);
            this.groupBox1.Controls.Add(this.btnSetItem);
            this.groupBox1.Controls.Add(this.btnWrite);
            this.groupBox1.Controls.Add(this.btnGetGrps);
            this.groupBox1.Controls.Add(this.btnConIP);
            this.groupBox1.Controls.Add(this.txtValue);
            this.groupBox1.Controls.Add(this.txtMyValue);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Location = new System.Drawing.Point(51, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "获取服务器OPC服务，并显示所有OPC标签";
            // 
            // cmbServer
            // 
            this.cmbServer.FormattingEnabled = true;
            this.cmbServer.Location = new System.Drawing.Point(100, 88);
            this.cmbServer.Name = "cmbServer";
            this.cmbServer.Size = new System.Drawing.Size(133, 20);
            this.cmbServer.TabIndex = 3;
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 12;
            this.lstItems.Location = new System.Drawing.Point(100, 132);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(133, 100);
            this.lstItems.TabIndex = 2;
            // 
            // btnOPC
            // 
            this.btnOPC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOPC.Location = new System.Drawing.Point(259, 88);
            this.btnOPC.Name = "btnOPC";
            this.btnOPC.Size = new System.Drawing.Size(75, 23);
            this.btnOPC.TabIndex = 1;
            this.btnOPC.Text = "连接OPC";
            this.btnOPC.UseVisualStyleBackColor = true;
            this.btnOPC.Click += new System.EventHandler(this.btnOPC_Click);
            // 
            // btnSetItem
            // 
            this.btnSetItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSetItem.Location = new System.Drawing.Point(259, 161);
            this.btnSetItem.Name = "btnSetItem";
            this.btnSetItem.Size = new System.Drawing.Size(75, 23);
            this.btnSetItem.TabIndex = 1;
            this.btnSetItem.Text = "定位标签";
            this.btnSetItem.UseVisualStyleBackColor = true;
            this.btnSetItem.Click += new System.EventHandler(this.btnSetItem_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnWrite.Location = new System.Drawing.Point(259, 273);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "发送参数";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnGetGrps
            // 
            this.btnGetGrps.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGetGrps.Location = new System.Drawing.Point(259, 132);
            this.btnGetGrps.Name = "btnGetGrps";
            this.btnGetGrps.Size = new System.Drawing.Size(75, 23);
            this.btnGetGrps.TabIndex = 1;
            this.btnGetGrps.Text = "获取标签";
            this.btnGetGrps.UseVisualStyleBackColor = true;
            this.btnGetGrps.Click += new System.EventHandler(this.btnGetGrps_Click);
            // 
            // btnConIP
            // 
            this.btnConIP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConIP.Location = new System.Drawing.Point(259, 49);
            this.btnConIP.Name = "btnConIP";
            this.btnConIP.Size = new System.Drawing.Size(75, 23);
            this.btnConIP.TabIndex = 1;
            this.btnConIP.Text = "连接服务器";
            this.btnConIP.UseVisualStyleBackColor = true;
            this.btnConIP.Click += new System.EventHandler(this.btnConIP_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(98, 243);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(133, 21);
            this.txtValue.TabIndex = 1;
            this.txtValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMyValue
            // 
            this.txtMyValue.Location = new System.Drawing.Point(98, 275);
            this.txtMyValue.Name = "txtMyValue";
            this.txtMyValue.Size = new System.Drawing.Size(133, 21);
            this.txtMyValue.TabIndex = 1;
            this.txtMyValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(100, 49);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(133, 21);
            this.txtIP.TabIndex = 1;
            this.txtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(36, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "发送值：";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(36, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "标签值：";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(38, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "所有标签：";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPC服务：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblIP.Location = new System.Drawing.Point(37, 49);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(67, 17);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "服务器IP：";
            this.lblIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblState.Location = new System.Drawing.Point(3, 406);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(50, 17);
            this.lblState.TabIndex = 0;
            this.lblState.Text = "lblstate";
            this.lblState.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormOpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblState);
            this.Name = "FormOpc";
            this.Text = "FormOpc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOpc_FormClosing);
            this.Load += new System.EventHandler(this.FormOpc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOPC;
        private System.Windows.Forms.Button btnConIP;
        private System.Windows.Forms.ComboBox cmbServer;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetItem;
        private System.Windows.Forms.Button btnGetGrps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtMyValue;
        private System.Windows.Forms.Label lblState;
    }
}
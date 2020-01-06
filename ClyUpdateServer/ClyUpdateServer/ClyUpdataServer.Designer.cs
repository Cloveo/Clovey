namespace ClyUpdateServer
{
    partial class ClyUpdateServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClyUpdateServer));
            this.label1 = new System.Windows.Forms.Label();
            this.txtClyVersion = new System.Windows.Forms.TextBox();
            this.dgv_Files = new System.Windows.Forms.DataGridView();
            this.col_Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_Del = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.fb_SeletFile = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Files)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "最新版本号：";
            // 
            // txtClyVersion
            // 
            this.txtClyVersion.Location = new System.Drawing.Point(117, 44);
            this.txtClyVersion.Name = "txtClyVersion";
            this.txtClyVersion.Size = new System.Drawing.Size(312, 35);
            this.txtClyVersion.TabIndex = 1;
            // 
            // dgv_Files
            // 
            this.dgv_Files.AllowUserToAddRows = false;
            this.dgv_Files.AllowUserToDeleteRows = false;
            this.dgv_Files.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_Files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Sel,
            this.col_Del,
            this.col_FileName,
            this.Column5,
            this.Column7});
            this.dgv_Files.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_Files.Location = new System.Drawing.Point(28, 106);
            this.dgv_Files.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Files.Name = "dgv_Files";
            this.dgv_Files.RowHeadersVisible = false;
            this.dgv_Files.RowTemplate.Height = 23;
            this.dgv_Files.Size = new System.Drawing.Size(402, 174);
            this.dgv_Files.TabIndex = 38;
            this.dgv_Files.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Files_CellContentClick);
            // 
            // col_Sel
            // 
            this.col_Sel.HeaderText = "选择";
            this.col_Sel.Name = "col_Sel";
            this.col_Sel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Sel.Width = 65;
            // 
            // col_Del
            // 
            this.col_Del.HeaderText = "操作";
            this.col_Del.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.col_Del.Name = "col_Del";
            this.col_Del.ReadOnly = true;
            this.col_Del.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_Del.Text = "移除";
            this.col_Del.UseColumnTextForLinkValue = true;
            this.col_Del.VisitedLinkColor = System.Drawing.Color.Blue;
            this.col_Del.Width = 65;
            // 
            // col_FileName
            // 
            this.col_FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_FileName.DataPropertyName = "Name";
            this.col_FileName.HeaderText = "文件名";
            this.col_FileName.Name = "col_FileName";
            this.col_FileName.ReadOnly = true;
            this.col_FileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Version";
            this.Column5.HeaderText = "版本号";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column5.Width = 90;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SIZE";
            this.Column7.HeaderText = "大小";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDelet,
            this.menuAdd});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(189, 60);
            // 
            // menuDelet
            // 
            this.menuDelet.Image = ((System.Drawing.Image)(resources.GetObject("menuDelet.Image")));
            this.menuDelet.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuDelet.Name = "menuDelet";
            this.menuDelet.Size = new System.Drawing.Size(188, 28);
            this.menuDelet.Text = "删除选择项";
            this.menuDelet.Click += new System.EventHandler(this.menuDelet_Click);
            // 
            // menuAdd
            // 
            this.menuAdd.Image = ((System.Drawing.Image)(resources.GetObject("menuAdd.Image")));
            this.menuAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.Size = new System.Drawing.Size(188, 28);
            this.menuAdd.Text = "添加文件路径";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnApply.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnApply.Location = new System.Drawing.Point(27, 501);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(403, 44);
            this.btnApply.TabIndex = 41;
            this.btnApply.Text = "保存配置文件";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 285);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 40;
            this.label2.Text = "更新说明：";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(29, 311);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(401, 177);
            this.txtDescription.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "添加文件";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // ClyUpdateServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CanResize = false;
            this.CaptionHeight = 30;
            this.ClientSize = new System.Drawing.Size(455, 557);
            this.CloseDownBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseDownBack")));
            this.CloseMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseMouseBack")));
            this.CloseNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.CloseNormlBack")));
            this.ControlBoxOffset = new System.Drawing.Point(2, 0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dgv_Files);
            this.Controls.Add(this.txtClyVersion);
            this.Controls.Add(this.label1);
            this.EffectWidth = 1;
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MdiBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MiniDownBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniDownBack")));
            this.MiniMouseBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniMouseBack")));
            this.MiniNormlBack = ((System.Drawing.Image)(resources.GetObject("$this.MiniNormlBack")));
            this.Name = "ClyUpdateServer";
            this.Radius = 1;
            this.RoundStyle = CCWin.SkinClass.RoundStyle.None;
            this.Shadow = false;
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShadowWidth = 1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cly更新-配置服务端";
            this.TitleOffset = new System.Drawing.Point(0, 5);
            this.TitleSuitColor = true;
            this.Load += new System.EventHandler(this.ClyUpdateServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Files)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClyVersion;
        private System.Windows.Forms.DataGridView dgv_Files;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDelet;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.FolderBrowserDialog fb_SeletFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_Sel;
        private System.Windows.Forms.DataGridViewLinkColumn col_Del;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace SuperMarketManager.AdminFrm
{
    partial class FrmMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMember));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.butSouSuoAdmin = new System.Windows.Forms.Button();
            this.superText1 = new SuperMarketCommon.SuperText(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.butClose = new System.Windows.Forms.Button();
            this.butJhAdmin = new System.Windows.Forms.Button();
            this.butCoodAdmin = new System.Windows.Forms.Button();
            this.butZhuXiao = new System.Windows.Forms.Button();
            this.butPenAdmin = new System.Windows.Forms.Button();
            this.butAddAdmin = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // butSouSuoAdmin
            // 
            this.butSouSuoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("butSouSuoAdmin.Image")));
            this.butSouSuoAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butSouSuoAdmin.Location = new System.Drawing.Point(664, 18);
            this.butSouSuoAdmin.Name = "butSouSuoAdmin";
            this.butSouSuoAdmin.Size = new System.Drawing.Size(82, 23);
            this.butSouSuoAdmin.TabIndex = 35;
            this.butSouSuoAdmin.Text = "提交查询";
            this.butSouSuoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butSouSuoAdmin.UseVisualStyleBackColor = true;
            this.butSouSuoAdmin.Click += new System.EventHandler(this.butSouSuoAdmin_Click);
            // 
            // superText1
            // 
            this.superText1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.superText1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.superText1.Location = new System.Drawing.Point(420, 17);
            this.superText1.Name = "superText1";
            this.superText1.Size = new System.Drawing.Size(239, 25);
            this.superText1.TabIndex = 34;
            this.superText1.Text = "会员卡号、姓名、手机号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(352, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "查询条件：";
            // 
            // butClose
            // 
            this.butClose.Image = ((System.Drawing.Image)(resources.GetObject("butClose.Image")));
            this.butClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butClose.Location = new System.Drawing.Point(1000, 17);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(82, 23);
            this.butClose.TabIndex = 32;
            this.butClose.Text = "关闭窗口";
            this.butClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // butJhAdmin
            // 
            this.butJhAdmin.Image = ((System.Drawing.Image)(resources.GetObject("butJhAdmin.Image")));
            this.butJhAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butJhAdmin.Location = new System.Drawing.Point(982, 564);
            this.butJhAdmin.Name = "butJhAdmin";
            this.butJhAdmin.Size = new System.Drawing.Size(82, 23);
            this.butJhAdmin.TabIndex = 31;
            this.butJhAdmin.Text = "会员激活";
            this.butJhAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butJhAdmin.UseVisualStyleBackColor = true;
            this.butJhAdmin.Click += new System.EventHandler(this.butJhAdmin_Click);
            // 
            // butCoodAdmin
            // 
            this.butCoodAdmin.Image = ((System.Drawing.Image)(resources.GetObject("butCoodAdmin.Image")));
            this.butCoodAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butCoodAdmin.Location = new System.Drawing.Point(894, 564);
            this.butCoodAdmin.Name = "butCoodAdmin";
            this.butCoodAdmin.Size = new System.Drawing.Size(82, 23);
            this.butCoodAdmin.TabIndex = 30;
            this.butCoodAdmin.Text = "会员冻结";
            this.butCoodAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butCoodAdmin.UseVisualStyleBackColor = true;
            this.butCoodAdmin.Click += new System.EventHandler(this.butCoodAdmin_Click);
            // 
            // butZhuXiao
            // 
            this.butZhuXiao.Image = ((System.Drawing.Image)(resources.GetObject("butZhuXiao.Image")));
            this.butZhuXiao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butZhuXiao.Location = new System.Drawing.Point(806, 564);
            this.butZhuXiao.Name = "butZhuXiao";
            this.butZhuXiao.Size = new System.Drawing.Size(82, 23);
            this.butZhuXiao.TabIndex = 29;
            this.butZhuXiao.Text = "会员注销";
            this.butZhuXiao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butZhuXiao.UseVisualStyleBackColor = true;
            this.butZhuXiao.Click += new System.EventHandler(this.butZhuXiao_Click);
            // 
            // butPenAdmin
            // 
            this.butPenAdmin.Image = ((System.Drawing.Image)(resources.GetObject("butPenAdmin.Image")));
            this.butPenAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butPenAdmin.Location = new System.Drawing.Point(97, 17);
            this.butPenAdmin.Name = "butPenAdmin";
            this.butPenAdmin.Size = new System.Drawing.Size(82, 23);
            this.butPenAdmin.TabIndex = 28;
            this.butPenAdmin.Text = "修改信息";
            this.butPenAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butPenAdmin.UseVisualStyleBackColor = true;
            this.butPenAdmin.Click += new System.EventHandler(this.butPenAdmin_Click);
            // 
            // butAddAdmin
            // 
            this.butAddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("butAddAdmin.Image")));
            this.butAddAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butAddAdmin.Location = new System.Drawing.Point(9, 17);
            this.butAddAdmin.Name = "butAddAdmin";
            this.butAddAdmin.Size = new System.Drawing.Size(82, 23);
            this.butAddAdmin.TabIndex = 27;
            this.butAddAdmin.Text = "会员注册";
            this.butAddAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.butAddAdmin.UseVisualStyleBackColor = true;
            this.butAddAdmin.Click += new System.EventHandler(this.butAddAdmin_Click);
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvProductList.ColumnHeadersHeight = 30;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Unit,
            this.Type,
            this.Count,
            this.Column1,
            this.MemberStatus});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.Location = new System.Drawing.Point(12, 48);
            this.dgvProductList.MultiSelect = false;
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowTemplate.Height = 23;
            this.dgvProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1073, 503);
            this.dgvProductList.TabIndex = 26;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "SalesPersonId";
            this.ProductId.HeaderText = "会员卡号";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductId.Width = 140;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "SPName";
            this.ProductName.HeaderText = "会员姓名";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductName.Width = 120;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "会员积分";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unit.Width = 120;
            // 
            // Type
            // 
            this.Type.FillWeight = 80F;
            this.Type.HeaderText = "联系电话";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Type.Width = 160;
            // 
            // Count
            // 
            this.Count.FillWeight = 80F;
            this.Count.HeaderText = "联系地址";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Count.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "开户时间";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 140;
            // 
            // MemberStatus
            // 
            this.MemberStatus.HeaderText = "会员状态";
            this.MemberStatus.Name = "MemberStatus";
            this.MemberStatus.ReadOnly = true;
            this.MemberStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MemberStatus.Width = 80;
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 600);
            this.Controls.Add(this.butSouSuoAdmin);
            this.Controls.Add(this.superText1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butJhAdmin);
            this.Controls.Add(this.butCoodAdmin);
            this.Controls.Add(this.butZhuXiao);
            this.Controls.Add(this.butPenAdmin);
            this.Controls.Add(this.butAddAdmin);
            this.Controls.Add(this.dgvProductList);
            this.Name = "FrmMember";
            this.Text = "会员信息维护";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSouSuoAdmin;
        private SuperMarketCommon.SuperText superText1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.Button butJhAdmin;
        private System.Windows.Forms.Button butCoodAdmin;
        private System.Windows.Forms.Button butZhuXiao;
        private System.Windows.Forms.Button butPenAdmin;
        private System.Windows.Forms.Button butAddAdmin;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberStatus;
    }
}
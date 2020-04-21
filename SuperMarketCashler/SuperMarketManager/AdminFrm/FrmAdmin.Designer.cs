namespace SuperMarketManager.AdminFrm
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartSysAdm = new System.Windows.Forms.Button();
            this.btnStopSysAdm = new System.Windows.Forms.Button();
            this.btnUpdateSysAdm = new System.Windows.Forms.Button();
            this.btnAddSysAdm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(496, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(98, 27);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartSysAdm
            // 
            this.btnStartSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartSysAdm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStartSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnStartSysAdm.Image")));
            this.btnStartSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartSysAdm.Location = new System.Drawing.Point(282, 25);
            this.btnStartSysAdm.Name = "btnStartSysAdm";
            this.btnStartSysAdm.Size = new System.Drawing.Size(72, 27);
            this.btnStartSysAdm.TabIndex = 10;
            this.btnStartSysAdm.Text = "启用";
            this.btnStartSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartSysAdm.UseVisualStyleBackColor = true;
            this.btnStartSysAdm.Click += new System.EventHandler(this.btnStartSysAdm_Click);
            // 
            // btnStopSysAdm
            // 
            this.btnStopSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopSysAdm.ForeColor = System.Drawing.Color.Red;
            this.btnStopSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnStopSysAdm.Image")));
            this.btnStopSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopSysAdm.Location = new System.Drawing.Point(194, 25);
            this.btnStopSysAdm.Name = "btnStopSysAdm";
            this.btnStopSysAdm.Size = new System.Drawing.Size(72, 27);
            this.btnStopSysAdm.TabIndex = 9;
            this.btnStopSysAdm.Text = "禁用";
            this.btnStopSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopSysAdm.UseVisualStyleBackColor = true;
            this.btnStopSysAdm.Click += new System.EventHandler(this.btnStopSysAdm_Click);
            // 
            // btnUpdateSysAdm
            // 
            this.btnUpdateSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSysAdm.Image")));
            this.btnUpdateSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSysAdm.Location = new System.Drawing.Point(107, 25);
            this.btnUpdateSysAdm.Name = "btnUpdateSysAdm";
            this.btnUpdateSysAdm.Size = new System.Drawing.Size(72, 27);
            this.btnUpdateSysAdm.TabIndex = 8;
            this.btnUpdateSysAdm.Text = "修改";
            this.btnUpdateSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSysAdm.UseVisualStyleBackColor = true;
            this.btnUpdateSysAdm.Click += new System.EventHandler(this.btnUpdateSysAdm_Click);
            // 
            // btnAddSysAdm
            // 
            this.btnAddSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSysAdm.Image")));
            this.btnAddSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSysAdm.Location = new System.Drawing.Point(20, 25);
            this.btnAddSysAdm.Name = "btnAddSysAdm";
            this.btnAddSysAdm.Size = new System.Drawing.Size(72, 27);
            this.btnAddSysAdm.TabIndex = 7;
            this.btnAddSysAdm.Text = "添加";
            this.btnAddSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSysAdm.UseVisualStyleBackColor = true;
            this.btnAddSysAdm.Click += new System.EventHandler(this.btnAddSysAdm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.AdminName,
            this.AdminType,
            this.AdminStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(46, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(523, 375);
            this.dataGridView1.TabIndex = 12;
            // 
            // AdminId
            // 
            this.AdminId.DataPropertyName = "LoginId";
            this.AdminId.HeaderText = "登录账号";
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            this.AdminId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AdminId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AdminId.Width = 140;
            // 
            // AdminName
            // 
            this.AdminName.DataPropertyName = "AdminName";
            this.AdminName.HeaderText = "用户名称";
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            this.AdminName.Width = 140;
            // 
            // AdminType
            // 
            this.AdminType.DataPropertyName = "RoleName";
            this.AdminType.HeaderText = "用户类型";
            this.AdminType.Name = "AdminType";
            this.AdminType.ReadOnly = true;
            this.AdminType.Width = 140;
            // 
            // AdminStatus
            // 
            this.AdminStatus.DataPropertyName = "StatusName";
            this.AdminStatus.HeaderText = "当前状态";
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.ReadOnly = true;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStartSysAdm);
            this.Controls.Add(this.btnStopSysAdm);
            this.Controls.Add(this.btnUpdateSysAdm);
            this.Controls.Add(this.btnAddSysAdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStartSysAdm;
        private System.Windows.Forms.Button btnStopSysAdm;
        private System.Windows.Forms.Button btnUpdateSysAdm;
        private System.Windows.Forms.Button btnAddSysAdm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminStatus;
    }
}
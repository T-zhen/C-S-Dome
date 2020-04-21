namespace SuperMarketManager
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuUserManager = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuUpdatePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuCheckLog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuExitSys = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuIntoProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuUpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuSaleCount = new System.Windows.Forms.ToolStripMenuItem();
            this.会员管理VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuAddMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMenuCancelMember = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolMenuProtectMember = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toollblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toollblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toollblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnProtectMember = new System.Windows.Forms.Button();
            this.btnCancelMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnAbuotme = new System.Windows.Forms.Button();
            this.btnSalerManager = new System.Windows.Forms.Button();
            this.btnExitSys = new System.Windows.Forms.Button();
            this.btnCheckLog = new System.Windows.Forms.Button();
            this.btnSalesCount = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnIntoProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.商品管理HToolStripMenuItem,
            this.销售管理XToolStripMenuItem,
            this.会员管理VToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1904, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuUserManager,
            this.toolMenuUpdatePwd,
            this.toolMenuCheckLog,
            this.toolMenuExitSys});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // toolMenuUserManager
            // 
            this.toolMenuUserManager.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuUserManager.Image")));
            this.toolMenuUserManager.Name = "toolMenuUserManager";
            this.toolMenuUserManager.Size = new System.Drawing.Size(141, 22);
            this.toolMenuUserManager.Text = "用户管理(&U)";
            this.toolMenuUserManager.Click += new System.EventHandler(this.toolMenuUserManager_Click);
            // 
            // toolMenuUpdatePwd
            // 
            this.toolMenuUpdatePwd.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuUpdatePwd.Image")));
            this.toolMenuUpdatePwd.Name = "toolMenuUpdatePwd";
            this.toolMenuUpdatePwd.Size = new System.Drawing.Size(141, 22);
            this.toolMenuUpdatePwd.Text = "修改密码(&P)";
            this.toolMenuUpdatePwd.Click += new System.EventHandler(this.toolMenuUpdatePwd_Click);
            // 
            // toolMenuCheckLog
            // 
            this.toolMenuCheckLog.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuCheckLog.Image")));
            this.toolMenuCheckLog.Name = "toolMenuCheckLog";
            this.toolMenuCheckLog.Size = new System.Drawing.Size(141, 22);
            this.toolMenuCheckLog.Text = "日志查询(&L)";
            // 
            // toolMenuExitSys
            // 
            this.toolMenuExitSys.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuExitSys.Image")));
            this.toolMenuExitSys.Name = "toolMenuExitSys";
            this.toolMenuExitSys.Size = new System.Drawing.Size(141, 22);
            this.toolMenuExitSys.Text = "退出系统(&E)";
            this.toolMenuExitSys.Click += new System.EventHandler(this.toolMenuExitSys_Click);
            // 
            // 商品管理HToolStripMenuItem
            // 
            this.商品管理HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAddProduct,
            this.toolMenuIntoProduct,
            this.toolMenuUpdateProduct,
            this.toolMenuInventory});
            this.商品管理HToolStripMenuItem.Name = "商品管理HToolStripMenuItem";
            this.商品管理HToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
            this.商品管理HToolStripMenuItem.Text = "商品管理(&H)";
            // 
            // toolMenuAddProduct
            // 
            this.toolMenuAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuAddProduct.Image")));
            this.toolMenuAddProduct.Name = "toolMenuAddProduct";
            this.toolMenuAddProduct.Size = new System.Drawing.Size(144, 22);
            this.toolMenuAddProduct.Text = "添加商品(&A)";
            this.toolMenuAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // toolMenuIntoProduct
            // 
            this.toolMenuIntoProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuIntoProduct.Image")));
            this.toolMenuIntoProduct.Name = "toolMenuIntoProduct";
            this.toolMenuIntoProduct.Size = new System.Drawing.Size(144, 22);
            this.toolMenuIntoProduct.Text = "商品入库(&I)";
            this.toolMenuIntoProduct.Click += new System.EventHandler(this.btnIntoProduct_Click);
            // 
            // toolMenuUpdateProduct
            // 
            this.toolMenuUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuUpdateProduct.Image")));
            this.toolMenuUpdateProduct.Name = "toolMenuUpdateProduct";
            this.toolMenuUpdateProduct.Size = new System.Drawing.Size(144, 22);
            this.toolMenuUpdateProduct.Text = "商品维护(&M)";
            // 
            // toolMenuInventory
            // 
            this.toolMenuInventory.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuInventory.Image")));
            this.toolMenuInventory.Name = "toolMenuInventory";
            this.toolMenuInventory.Size = new System.Drawing.Size(144, 22);
            this.toolMenuInventory.Text = "库存管理(&K)";
            // 
            // 销售管理XToolStripMenuItem
            // 
            this.销售管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuSaleCount});
            this.销售管理XToolStripMenuItem.Name = "销售管理XToolStripMenuItem";
            this.销售管理XToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.销售管理XToolStripMenuItem.Text = "销售管理(&X)";
            // 
            // toolMenuSaleCount
            // 
            this.toolMenuSaleCount.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuSaleCount.Image")));
            this.toolMenuSaleCount.Name = "toolMenuSaleCount";
            this.toolMenuSaleCount.Size = new System.Drawing.Size(140, 22);
            this.toolMenuSaleCount.Text = "销售统计(&C)";
            // 
            // 会员管理VToolStripMenuItem
            // 
            this.会员管理VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolMenuAddMember,
            this.toolMenuCancelMember,
            this.toolStripMenuItem2,
            this.toolMenuProtectMember});
            this.会员管理VToolStripMenuItem.Name = "会员管理VToolStripMenuItem";
            this.会员管理VToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.会员管理VToolStripMenuItem.Text = "会员管理(&V)";
            // 
            // toolMenuAddMember
            // 
            this.toolMenuAddMember.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuAddMember.Image")));
            this.toolMenuAddMember.Name = "toolMenuAddMember";
            this.toolMenuAddMember.Size = new System.Drawing.Size(142, 22);
            this.toolMenuAddMember.Text = "添加会员(&V)";
            this.toolMenuAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // toolMenuCancelMember
            // 
            this.toolMenuCancelMember.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuCancelMember.Image")));
            this.toolMenuCancelMember.Name = "toolMenuCancelMember";
            this.toolMenuCancelMember.Size = new System.Drawing.Size(142, 22);
            this.toolMenuCancelMember.Text = "注销会员(&T)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 6);
            // 
            // toolMenuProtectMember
            // 
            this.toolMenuProtectMember.Image = ((System.Drawing.Image)(resources.GetObject("toolMenuProtectMember.Image")));
            this.toolMenuProtectMember.Name = "toolMenuProtectMember";
            this.toolMenuProtectMember.Size = new System.Drawing.Size(142, 22);
            this.toolMenuProtectMember.Text = "会员维护(&Q)";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toollblVersion,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toollblUser,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toollblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1019);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1904, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "超市管理系统";
            // 
            // toollblVersion
            // 
            this.toollblVersion.Name = "toollblVersion";
            this.toollblVersion.Size = new System.Drawing.Size(33, 17);
            this.toollblVersion.Text = "V1.0";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "      |      ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusLabel4.Text = "管理员：";
            // 
            // toollblUser
            // 
            this.toollblUser.Name = "toollblUser";
            this.toollblUser.Size = new System.Drawing.Size(56, 17);
            this.toollblUser.Text = "【张三】";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel6.Text = "      |      ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(1356, 17);
            this.toolStripStatusLabel7.Spring = true;
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel8.Text = "      |      ";
            // 
            // toollblTime
            // 
            this.toollblTime.Name = "toollblTime";
            this.toollblTime.Size = new System.Drawing.Size(131, 17);
            this.toollblTime.Text = "toolStripStatusLabel9";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnProtectMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddMember);
            this.splitContainer1.Panel1.Controls.Add(this.btnAbuotme);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalerManager);
            this.splitContainer1.Panel1.Controls.Add(this.btnExitSys);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckLog);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesCount);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdateProduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnInventory);
            this.splitContainer1.Panel1.Controls.Add(this.btnIntoProduct);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddProduct);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 994);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 5;
            // 
            // btnProtectMember
            // 
            this.btnProtectMember.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnProtectMember.Image = ((System.Drawing.Image)(resources.GetObject("btnProtectMember.Image")));
            this.btnProtectMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProtectMember.Location = new System.Drawing.Point(146, 357);
            this.btnProtectMember.Name = "btnProtectMember";
            this.btnProtectMember.Size = new System.Drawing.Size(101, 35);
            this.btnProtectMember.TabIndex = 38;
            this.btnProtectMember.Text = "会员维护";
            this.btnProtectMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProtectMember.UseVisualStyleBackColor = true;
            // 
            // btnCancelMember
            // 
            this.btnCancelMember.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancelMember.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelMember.Image")));
            this.btnCancelMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelMember.Location = new System.Drawing.Point(146, 423);
            this.btnCancelMember.Name = "btnCancelMember";
            this.btnCancelMember.Size = new System.Drawing.Size(101, 35);
            this.btnCancelMember.TabIndex = 37;
            this.btnCancelMember.Text = "注销会员";
            this.btnCancelMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelMember.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddMember.Location = new System.Drawing.Point(24, 423);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(101, 35);
            this.btnAddMember.TabIndex = 36;
            this.btnAddMember.Text = "添加会员";
            this.btnAddMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnAbuotme
            // 
            this.btnAbuotme.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbuotme.Image = ((System.Drawing.Image)(resources.GetObject("btnAbuotme.Image")));
            this.btnAbuotme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbuotme.Location = new System.Drawing.Point(146, 684);
            this.btnAbuotme.Name = "btnAbuotme";
            this.btnAbuotme.Size = new System.Drawing.Size(101, 35);
            this.btnAbuotme.TabIndex = 35;
            this.btnAbuotme.Text = "关于我们";
            this.btnAbuotme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbuotme.UseVisualStyleBackColor = true;
            // 
            // btnSalerManager
            // 
            this.btnSalerManager.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSalerManager.Image = ((System.Drawing.Image)(resources.GetObject("btnSalerManager.Image")));
            this.btnSalerManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalerManager.Location = new System.Drawing.Point(24, 748);
            this.btnSalerManager.Name = "btnSalerManager";
            this.btnSalerManager.Size = new System.Drawing.Size(101, 35);
            this.btnSalerManager.TabIndex = 34;
            this.btnSalerManager.Text = "用户管理";
            this.btnSalerManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalerManager.UseVisualStyleBackColor = true;
            // 
            // btnExitSys
            // 
            this.btnExitSys.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExitSys.Image = ((System.Drawing.Image)(resources.GetObject("btnExitSys.Image")));
            this.btnExitSys.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExitSys.Location = new System.Drawing.Point(146, 748);
            this.btnExitSys.Name = "btnExitSys";
            this.btnExitSys.Size = new System.Drawing.Size(101, 35);
            this.btnExitSys.TabIndex = 33;
            this.btnExitSys.Text = "退出系统";
            this.btnExitSys.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExitSys.UseVisualStyleBackColor = true;
            // 
            // btnCheckLog
            // 
            this.btnCheckLog.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckLog.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckLog.Image")));
            this.btnCheckLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckLog.Location = new System.Drawing.Point(22, 684);
            this.btnCheckLog.Name = "btnCheckLog";
            this.btnCheckLog.Size = new System.Drawing.Size(101, 35);
            this.btnCheckLog.TabIndex = 32;
            this.btnCheckLog.Text = "日志查询";
            this.btnCheckLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckLog.UseVisualStyleBackColor = true;
            this.btnCheckLog.Click += new System.EventHandler(this.btnCheckLog_Click);
            // 
            // btnSalesCount
            // 
            this.btnSalesCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSalesCount.Image = ((System.Drawing.Image)(resources.GetObject("btnSalesCount.Image")));
            this.btnSalesCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesCount.Location = new System.Drawing.Point(24, 357);
            this.btnSalesCount.Name = "btnSalesCount";
            this.btnSalesCount.Size = new System.Drawing.Size(101, 35);
            this.btnSalesCount.TabIndex = 31;
            this.btnSalesCount.Text = "销售统计";
            this.btnSalesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalesCount.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.Image")));
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.Location = new System.Drawing.Point(146, 293);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(101, 35);
            this.btnUpdateProduct.TabIndex = 30;
            this.btnUpdateProduct.Text = "商品维护";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(24, 293);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(101, 35);
            this.btnInventory.TabIndex = 29;
            this.btnInventory.Text = "库存管理";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInventory.UseVisualStyleBackColor = true;
            // 
            // btnIntoProduct
            // 
            this.btnIntoProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIntoProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnIntoProduct.Image")));
            this.btnIntoProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntoProduct.Location = new System.Drawing.Point(146, 235);
            this.btnIntoProduct.Name = "btnIntoProduct";
            this.btnIntoProduct.Size = new System.Drawing.Size(101, 35);
            this.btnIntoProduct.TabIndex = 28;
            this.btnIntoProduct.Text = "商品入库";
            this.btnIntoProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIntoProduct.UseVisualStyleBackColor = true;
            this.btnIntoProduct.Click += new System.EventHandler(this.btnIntoProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(23, 238);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(101, 35);
            this.btnAddProduct.TabIndex = 27;
            this.btnAddProduct.Text = "添加商品";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 31);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(3, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1616, 892);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(999, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎使用超市后台管理系统";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuUserManager;
        private System.Windows.Forms.ToolStripMenuItem toolMenuUpdatePwd;
        private System.Windows.Forms.ToolStripMenuItem toolMenuCheckLog;
        private System.Windows.Forms.ToolStripMenuItem toolMenuExitSys;
        private System.Windows.Forms.ToolStripMenuItem 商品管理HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuAddProduct;
        private System.Windows.Forms.ToolStripMenuItem toolMenuIntoProduct;
        private System.Windows.Forms.ToolStripMenuItem toolMenuUpdateProduct;
        private System.Windows.Forms.ToolStripMenuItem toolMenuInventory;
        private System.Windows.Forms.ToolStripMenuItem 销售管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuSaleCount;
        private System.Windows.Forms.ToolStripMenuItem 会员管理VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolMenuAddMember;
        private System.Windows.Forms.ToolStripMenuItem toolMenuCancelMember;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolMenuProtectMember;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toollblVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toollblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toollblTime;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnProtectMember;
        private System.Windows.Forms.Button btnCancelMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAbuotme;
        private System.Windows.Forms.Button btnSalerManager;
        private System.Windows.Forms.Button btnExitSys;
        private System.Windows.Forms.Button btnCheckLog;
        private System.Windows.Forms.Button btnSalesCount;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnIntoProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}
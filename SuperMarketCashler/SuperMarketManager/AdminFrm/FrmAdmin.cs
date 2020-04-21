using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketBLL.SuperMarketManager;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmAdmin : Form
    {
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        public FrmAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dataGridView1.AutoGenerateColumns = false;//不可自动调整列
            InitializeUser();
            source.CurrentChanged += Source_CurrentChanged;

        }

        private void InitializeUser()
        {
            adminList = adminManager.GetAdmins();
            source.DataSource = adminList;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }

        //窗体绑定发生更改时
        private void Source_CurrentChanged(object sender, EventArgs e)
        {
            currentAdm = source.Current as SysAdmins;//把选定的转换为一个实体类
        }
        SysAdmins currentAdm = null;
        List<SysAdmins> adminList = null;
        BindingSource source = new BindingSource();
        //添加
        private void btnAddSysAdm_Click(object sender, EventArgs e)
        {
            FrmAddAdmin addAdmin = new FrmAddAdmin();
            addAdmin.ShowDialog();
            InitializeUser();
        }
        //修改
        private void btnUpdateSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount==0||currentAdm==null)
            {
                MessageBox.Show("请选择要修改的用户！");
                return;
            }
            FrmUpdateAdmin updateAdmin = new FrmUpdateAdmin(currentAdm);
            if (updateAdmin.ShowDialog() == DialogResult.OK)
            {
                InitializeUser();
            }
        }
        //禁用
        private void btnStopSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0 || currentAdm == null||currentAdm.RoleId==1)
            {
                return;
            }
            currentAdm.AdminStatus = 0;
            if (adminManager.SetSysStatus(currentAdm) )
            {
                InitializeUser();
            }
        }
        //启用
        private void btnStartSysAdm_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount==0||currentAdm==null||currentAdm.RoleId==1)
            {
                return;
            }

            currentAdm.AdminStatus = 1;
            if (adminManager.SetSysStatus(currentAdm))
            {
                InitializeUser();
            }
        }
        //关闭窗口
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

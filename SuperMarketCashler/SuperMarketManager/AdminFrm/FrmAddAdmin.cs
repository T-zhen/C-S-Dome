﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketModel;
using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketManager;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmAddAdmin : Form
    {
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        public FrmAddAdmin()
        {
            InitializeComponent();
            txtAdmName.Focus();
            cmbAdminRole.SelectedIndex = 0;
            txtAdmPwd.GotFocus += TxtAdmPwd_GotFocus;
        }

        private void TxtAdmPwd_GotFocus(object sender, EventArgs e)
        {
            txtAdmPwd.SelectAll();//选中所有内容
        }

        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtAdmName.CheckNullOrEmpty()*txtAdmPwd.CheckData(@"^\w{6,}$","密码必须是6位字母、数字、下划线组成")==0)
            {
                return;
            }
            else
            {
                SysAdmins admin = new SysAdmins()
                {
                    AdminName = txtAdmName.Text.Trim(),
                    AdminStatus = -1,
                    LoginPwd = txtAdmPwd.Text.Trim(),
                    RoleId = cmbAdminRole.SelectedIndex + 1
                };
                admin = adminManager.InsertAdmin(admin);
                if (admin==null)
                {
                    MessageBox.Show("用户添加失败！","提示");
                    return;
                }
                else
                {
                    if (MessageBox.Show($"添加成功！登录账号为{admin.LoginId}\r\n是否继续添加","提示",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        txtAdmName.Text = "";
                        txtAdmPwd.Text = "123456";
                        cmbAdminRole.SelectedIndex = 0;
                        return;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否确认取消添加？","提示！",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
           
        }
    }
}

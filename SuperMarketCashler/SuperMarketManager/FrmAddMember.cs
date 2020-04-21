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
using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketManager;

namespace SuperMarketManager
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
            txtMemberName.Focus();
        }
        ISuperMarketMemberManager manager = new SuperMarketMemberManager();
        private void btnSure_Click(object sender, EventArgs e)
        {
            if (txtMemberName.CheckNullOrEmpty()*txtMemberTel.CheckData(@"^1\d{10}","手机号格式有误！")==1)
            {
                if (manager.GetMMemberByIdOrPhone(txtMemberTel.Text.Trim())!=null)
                {
                    MessageBox.Show("该手机号已被注册！");
                }
                SMMembers members = new SMMembers()
                {
                    MemberName = txtMemberName.Text.Trim(),
                    PhoneNumber = txtMemberTel.Text.Trim(),
                    MemberAddress = string.IsNullOrEmpty(txtAddress.Text.Trim()) ? "地址不详！":txtAddress.Text.Trim()
                };
                members = manager.AddMember(members);
                if (members!=null)
                {
                    if (MessageBox.Show($"注册成功！会员账号为{members.MemberId}\r\n是否继续注册？","提示",MessageBoxButtons.YesNo)== DialogResult.Yes)
                    {
                        txtMemberName.Text = "";
                        txtMemberTel.Text = "";
                        txtAddress.Text = "";
                        txtMemberName.Focus();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("注册失败！请稍后重试......");
                }
            }
        }
    }
}

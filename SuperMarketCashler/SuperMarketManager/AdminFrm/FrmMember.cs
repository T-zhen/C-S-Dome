using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketCommon;
using SuperMarketModel;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketCashier;
using SuperMarketBLL.SuperMarketCashier;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmMember : Form
    {
        SuperMarketIBLL.SuperMarketCashier.ISuperMarketMemberManager manager = new SuperMarketBLL.SuperMarketCashier.SuperMarketMemberManager();
        public FrmMember()
        {
            InitializeComponent();

        }
        private void ShowSource(string id)
        {
          
        }
        List<SMMembers> members = null;
        BindingSource source = new BindingSource();
        SMMembers member = null;
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAddAdmin_Click(object sender, EventArgs e)
        {
            FrmAddMember frmAddMembe = new FrmAddMember();
            frmAddMembe.ShowDialog();
        }
        /// <summary>
        /// 修改信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butPenAdmin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSouSuoAdmin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 会员注销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butZhuXiao_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 会员冻结
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butCoodAdmin_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 会员激活
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butJhAdmin_Click(object sender, EventArgs e)
        {

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

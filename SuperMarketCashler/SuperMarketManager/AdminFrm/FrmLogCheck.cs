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

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmLogCheck : Form
    {
        /// <summary>
        /// 登录日志
        /// </summary>
        ISuperMarketLoginLogManager logManager = new SuperMarketLoginLogManager();
        public FrmLogCheck()
        {
            InitializeComponent();
            startTime.Focus();
            txtWhere.GotFocus += TxtWhere_GotFocus;
            txtWhere.LostFocus += TxtWhere_LostFocus;
            logList = logManager.GetLoginLog();
            InitializePage();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void TxtWhere_GotFocus(object sender, EventArgs e)
        {
            txtWhere.SelectAll();
            txtWhere.ForeColor = Color.Black;
        }

        private void InitializePage()
        {
            if (logList == null)
            {
                MessageBox.Show("暂无任何登录信息！");
                return;
            }
            else
            {
                pageNav.RecordCount = logList.Count;
                pageNav.CurrentPage = 1;
                pageNav.PageSize = 15;
                pageNav.SortType = SortType.ASC;
                pageNav.ExceuteSetPageEvent += PageNav_ExceuteSetPageEvent;
                pageNav.FirstSearh();
            }
        }

        private void PageNav_ExceuteSetPageEvent(int currentPage)
        {

            if (logList!=null)
            {
                currentPageList = logList.Skip((pageNav.CurrentPage - 1) * pageNav.PageSize).Take(pageNav.PageSize).ToList();
                //绑定数据
                source.DataSource = currentPageList;
                dataGridView1.DataSource = source;
                pageNav.SetButtonEnable();
            }
        }
        BindingSource source = new BindingSource();
        List<LoginLogs> logList = null;
        List<LoginLogs> currentPageList = null;
        private void TxtWhere_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWhere.Text))
            {
                txtWhere.Text = "姓名、账号、服务器名";
                txtWhere.Tag = "1";
                txtWhere.ForeColor = Color.FromArgb(100, 100, 100);
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //条件框未输入内容 全部查询
            if (checkBox1.Checked==false && txtWhere.Tag.ToString()=="1")
            {
                logList = logManager.GetLoginLog();
                pageNav.RecordCount = logList.Count;
                pageNav.FirstSearh();
            }
            else
            {
                DateTime start = DateTime.Now;
                DateTime end = DateTime.Now;
                string where = "";
                int check = 0;
                //按照区间进行查询
                if (checkBox1.Checked==true)
                {
                    check = 1;
                    if (startTime.Value == endTime.Value)//等于
                    {
                        check = 2;
                        start = end = Convert.ToDateTime(startTime.Value.ToShortDateString());
                    }
                    else if (startTime.Value < endTime.Value)//小于
                    {
                        start = Convert.ToDateTime(startTime.Value.ToShortDateString());
                        //'2020-04-14 0:00:00'
                        end = Convert.ToDateTime(endTime.Value.ToShortDateString()).AddDays(1);
                    }
                    else if (startTime.Value > endTime.Value)//大于
                    {
                        check = -1;
                        start = end = Convert.ToDateTime(startTime.Value.ToShortDateString());
                    }
                    if (txtWhere.Tag.ToString() == "1")//不带条件的查询
                    {
                        where = "";
                    }
                    else
                    {
                        where = txtWhere.Text.Trim();
                    }
                }
                else//正常查询
                {
                    check = 0;
                    where = txtWhere.Text.Trim();
                }
                logList = logManager.GetLoginLogBy(start, end, where, check);
                pageNav.RecordCount = logList.Count;
                pageNav.FirstSearh();
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void txtWhere_TextChanged(object sender, EventArgs e)
        {
            txtWhere.Tag = "0";
        }
    }
}

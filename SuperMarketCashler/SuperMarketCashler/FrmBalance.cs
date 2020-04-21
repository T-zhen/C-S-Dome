using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketIBLL.SuperMarketCashier;
using SuperMarketBLL.SuperMarketCashier;
using SuperMarketModel;
using SuperMarketCommon;

namespace SuperMarketCashler
{
    public partial class FrmBalance : Form
    {
        ISuperMarketMemberManager memberManager = new SuperMarketMemberManager();
        /// <summary>
        /// 结算界面
        /// </summary>
        /// <param name="totalMoney">应付金额</param>
        public FrmBalance(string totalMoney)
        {
            InitializeComponent();
            txtPay.Text = totalMoney;
            this.StartPosition = FormStartPosition.CenterScreen;
            txtVip.GotFocus += TxtVip_GotFocus;
            txtVip.LostFocus += TxtVip_LostFocus;
            txtAmount.GotFocus += TxtVip_GotFocus;
            txtAmount.LostFocus += TxtVip_LostFocus;
        }

      

        //当失去焦点时
        private void TxtVip_LostFocus(object sender, EventArgs e)
        {
            SuperText txt = sender as SuperText;
            txt.BackColor = Color.White;
            //实际收款格式判断
            if (txtAmount.Text.Contains(",") && txtAmount.Text.IndexOf(".") == txtAmount.Text.Length)
            {
                txtAmount.Text += "00";
            }
            else if (!txtAmount.Text.Contains("."))
            {
                txtAmount.Text += ".00";
            }
            txtAmount.Text = Convert.ToDecimal(txtAmount.Text).ToString("F2");
        }
        //当获取焦点时
        private void TxtVip_GotFocus(object sender, EventArgs e)
        {
            SuperText txt = sender as SuperText;
            txt.BackColor = Color.Cyan;
            txt.SelectAll();//选中所有文本
        }
        //键盘事件
        private void txtVip_KeyDown(object sender, KeyEventArgs e)
        {
            txtAmount.Text = txtAmount.Text.Replace("\r\n", "");
            txtVip.Text = txtVip.Text.Replace("\r\n", "");
            if (e.KeyCode==Keys.F1)
            {
                radMoney.Checked = true;//确定选中
            }
            else if (e.KeyCode==Keys.F2)
            {
                radCard.Checked = true;
            }
            else if (e.KeyCode==Keys.F3)
            {
                radQRCode.Checked = true;
            }
            else if (e.KeyCode==Keys.Enter)
            {
                if (txtAmount.CheckData(@"^(([1-9]\d*)|(\d*.\d{0,2}))$","输入金额有误！")!=0)
                {
                    if (txtAmount.Text.Contains(".")&&txtAmount.Text.IndexOf(".")==txtAmount.Text.Length)
                    {
                        txtAmount.Text += "00";
                    }
                    else if (!txtAmount.Text.Contains("."))
                    {
                        txtAmount.Text += ".00";
                    }
                    txtAmount.Text = Convert.ToDecimal(txtAmount.Text).ToString("F2");
                    if (txtVip.Text.Length==0)//如果不是会员
                    {
                        this.Tag = txtAmount.Text.Trim();
                    }
                    else//有会员
                    {
                        if (txtVip.CheckData(@"^[1-9]\d*$","会员卡号有误！或手机号有误！")!=0)
                        {
                            //进一步判断会员卡号是否正常
                            SMMembers members = memberManager.GetMembersById(txtVip.Text.Trim());
                            if (members==null)
                            {
                                this.Tag = $"{txtAmount.Text.Trim()}${txtVip.Text.Trim()}";
                            }
                            else
                            {
                                this.Tag = txtAmount.Text.Trim();
                            }
                        }
                        //卡号无误则
                        else
                        {
                            this.Tag = txtAmount.Text.Trim();
                        }
                    }
                    if (Convert.ToDecimal(txtPay.Text)<=Convert.ToDecimal(txtAmount.Text))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("客户所付金额不足！","注意！");
                    }
                }

            }
            else if (e.KeyCode==Keys.Escape)
            {
                this.Tag = "Esc";
                this.Close();
            }
            else if (e.KeyCode==Keys.Tab)
            {
                SuperText txt = sender as SuperText;
                if (txt.Tag.ToString()=="Vip")
                {
                    txtAmount.Focus();
                }
                else if (txt.Tag.ToString()=="pay")
                {
                    txtVip.Focus();
                }
            }
        }
    }
}

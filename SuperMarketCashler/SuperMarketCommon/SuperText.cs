using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SuperMarketCommon
{
    public partial class SuperText : TextBox
    {
        public SuperText()
        {
            InitializeComponent();
        }

        public SuperText(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        /// <summary>
        /// 是否为空验证
        /// </summary>
        /// <returns></returns>
        public int CheckNullOrEmpty()
        {
            Text.Replace("\r\n","");
            if (string.IsNullOrEmpty(this.Text))
            {
                this.errorProvider1.SetError(this,"必填项不能为空！");
                return 0;
            }
            else
            {
                errorProvider1.SetError(this,string.Empty);
                return 1;
            }
        }
        /// <summary>
        /// 正则验证
        /// </summary>
        /// <param name="pattern"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public int CheckData(string pattern, string msg)
        {
            if (CheckNullOrEmpty()==0)
            {
                return 0;
            }

            Regex regex = new Regex(pattern);
            this.Text.Replace("\r\n", "");
            if (regex.IsMatch(this.Text))
            {
                errorProvider1.SetError(this, string.Empty);
                return 1;
            }
            else
            {
                errorProvider1.SetError(this,msg);

                return 0;
            }
        }

        /// <summary>
        /// 格式错误描述
        /// </summary>
        /// <param name="msg"></param>
        public void SetError(string msg)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                errorProvider1.SetError(this,msg);
                return;
            }
        }
    }
}

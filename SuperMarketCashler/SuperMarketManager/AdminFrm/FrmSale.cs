using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMarketBLL.SuperMarketManager;
using SuperMarketIBLL.SuperMarketManager;
using SuperMarketModel;

namespace SuperMarketManager.AdminFrm
{
    public partial class FrmSale : Form
    {
        ISuperMarkeAdminManager adminManager = new SuperMarketAdminManager();
        public FrmSale()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            InitializeSale();
            source.CurrentChanged += Source_CurrentChanged;
        }
        public SalesPerson Person { get; set; }
        private void Source_CurrentChanged(object sender, EventArgs e)
        {
            Person = source.Current as SalesPerson;//获取选中项
        }

        List<SalesPerson> list = null;
        BindingSource source = new BindingSource();
        private void InitializeSale()
        {
            list = adminManager.GetSales();
            source.DataSource = list;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = source;
        }
        private void btnAddSysAdm_Click(object sender, EventArgs e)
        {
            FrmAddSale addSale = new FrmAddSale();
            addSale.ShowDialog();
            InitializeSale();
        }

        private void btnUpdateSysAdm_Click(object sender, EventArgs e)
        {
            FrmUpdateSale updateSale = new FrmUpdateSale(Person);
            if (updateSale.ShowDialog() == DialogResult.OK)
            {
                InitializeSale();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

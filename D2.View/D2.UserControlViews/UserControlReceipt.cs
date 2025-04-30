using _3_13_25.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlReceipt : UserControl
    {
        public UserControlReceipt()
        {
            InitializeComponent();
        }

        private void UserControlReceipt_Load(object sender, EventArgs e)
        {

        }

        //private void buttonPaid_Click(object sender, EventArgs e)
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is DataGridView datagrid && datagrid.SelectedRows.Count < 0)
        //        {
        //            MessageBox.Show("Select a single row before proceeding payment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //            return;
        //        }
        //    }
        //    if (string.IsNullOrEmpty(textBoxPayment.Text))
        //    {
        //        return;
        //    }

        //    BillingObj.Pay = decimal.Parse(textBoxPayment.Text);

        //    if (OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay) <= BillingObj.TotalFee)
        //    {
        //        BillingClass.UpdatePayment();
        //        refresh();
        //    }
        //    else { MessageBox.Show("Excess Pay Fee!\nPay for the appropriate remaining amount left only", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

        //    ReceiptReportClass.ReceiptSetup(reportViewerReceipt);
        //}

        //private void DataGridViewPendingPayment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    //BillingClass.SelectedValue(DataGridViewPendingPayment);
        //}
    }
}

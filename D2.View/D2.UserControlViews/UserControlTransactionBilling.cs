using _3_13_25.D2.Classes;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
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
    public partial class UserControlTransactionBilling : UserControl, IRefreshableControl
    {
        CapsuleBase capsule;
        private long _id;
        private decimal _total;

        public void RefreshControl()
        {
            Data_Load();
            DisplayData(string.Empty, string.Empty, string.Empty, string.Empty);
            numericUpDownPayAmount.Value = 1;
        }

        public UserControlTransactionBilling()
        {
            InitializeComponent();
        }

        private void UserControlTransactionBilling_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void Data_Load()
        {
            dataGridViewBillingList.DataSource = null;
            dataGridViewBillingList.DataSource = DataLoadCast.FetchBillingRecord();
            SetColumnHeaders(dataGridViewBillingList);
            dataGridViewBillingList.Refresh();
        }

        private void dataGridViewBillingList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _id = Convert.ToInt64(dataGridViewBillingList.SelectedRows[0].Cells["Transaction_Id"].Value);
            BillingLogics.FetchBillingInformation(_id);

            DisplayData(_id.ToString(), TemporalData.StudentUserN, TemporalData.Status, TemporalData.SessionScheduleDate.ToString());

            _total = Convert.ToDecimal(dataGridViewBillingList.SelectedRows[0].Cells[1].Value);
            textBoxTotal.Text = _total.ToString();
        }

        private void DisplayData(string transactionId, string name, string status, string bookDate)
        {
            labelTransactionIdInfo.Text = transactionId.ToString();
            labelNameInfo.Text = name;
            labelStatusInfo.Text = status;
            labelBookDateInfo.Text = bookDate.ToString();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (numericUpDownPayAmount.Value < 1) return;

            if (dataGridViewBillingList.SelectedRows.Count < 1) return;

            decimal total = Convert.ToDecimal(dataGridViewBillingList.SelectedRows[0].Cells[2].Value) + numericUpDownPayAmount.Value;

            if (total <= _total)
            {
                BillingLogics.PaymentRegistration(_id, total);
                BillingLogics.RecordHistory(_id, _total, total);    

                UserControlReceipt receipt = new UserControlReceipt();
                capsule = new CapsuleBase(receipt);
                ReceiptReport._Id = _id;
                capsule.ShowDialog();
                RefreshControl();
            }
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Transaction_Id"))
            {
                dgv.Columns["Transaction_Id"].HeaderText = "Transaction ID";
                //dgv.Columns["Transaction_Id"].Visible = false;
            }

            if (dgv.Columns.Contains("Total_Value"))
                dgv.Columns["Total_Value"].HeaderText = "Total";
            
            if (dgv.Columns.Contains("Payment_Amount"))
                dgv.Columns["Payment_Amount"].HeaderText = "Paid";

            if (dgv.Columns.Contains("Bill_Status"))
                dgv.Columns["Bill_Status"].HeaderText = "Status";
        }

        private void dataGridViewBillingList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

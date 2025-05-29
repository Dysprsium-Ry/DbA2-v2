using _3_13_25.D2.Classes;
using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.View.D2.UserControlViews;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    public partial class UserControlBillHistory : UserControl
    {
        private CapsuleBase capsule;
        private long _id;
        public UserControlBillHistory()
        {
            InitializeComponent();
        }

        private void UserControlBillHistory_Load(object sender, EventArgs e)
        {
            DataGrid_Load();
        }

        private void DataGrid_Load()
        {
            dataGridViewBillHistory.DataSource = null;
            dataGridViewBillHistory.DataSource = BillingLogics.FetchBillingHistory(_id);
        }

        private void buttonSearchHistory_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt64(numericUpDownTransactionId.Value);
            DataGrid_Load();
        }

        private void dataGridViewBillHistory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewBillHistory.Rows.Count < 0) return;
            if (e.RowIndex < 0) return;
            long id = Convert.ToInt64(dataGridViewBillHistory.SelectedRows[0].Cells["transactionId"].Value);
            UserControlReceipt receipt = new UserControlReceipt();
            ReceiptReport._Id = id;
            capsule = new CapsuleBase(receipt);
            capsule.ShowDialog();
        }
    }
}

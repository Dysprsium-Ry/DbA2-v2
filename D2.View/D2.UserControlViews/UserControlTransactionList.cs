using _3_13_25.D2.DbConn;
using _3_13_25.D2.View.D2.MainFormV;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_;
using BienvenidoOnlineTutorServices.D2.Objects;
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
    public partial class UserControlTransactionList : System.Windows.Forms.UserControl
    {
        TransactionForm form = new TransactionForm();

        public UserControlTransactionList()
        {
            InitializeComponent();
            form.FormClosing += (s, e) => { DataLoadCast.TransactionList(DataGridViewTransactionList); };
        }

        private void UserControlTransactionList_Load(object sender, EventArgs e)
        {
            DataLoadCast.TransactionList(DataGridViewTransactionList);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            TemporalData.TransactionId = DbItemFetcher.NewTransactionIdFetcher();
            form.ShowDialog();
        }

        private void DataGridViewTransactionList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridViewTransactionList.SelectedRows.Count > 0)
            {
                TemporalData.TransactionId = Convert.ToInt64(DataGridViewTransactionList.SelectedRows[0].Cells["Transaction Id"].Value ?? 0);
                TemporalData.StudentUserN = Convert.ToString(DataGridViewTransactionList.SelectedRows[0].Cells["Student"].Value ?? string.Empty);
                TemporalData.Status = Convert.ToString(DataGridViewTransactionList.SelectedRows[0].Cells["Status"].Value ?? string.Empty);
                TemporalData.TotalFee = Convert.ToDecimal(DataGridViewTransactionList.SelectedRows[0].Cells["Total"].Value ?? 0);
            }

            var editItemList = EditClass.FetchClientData();
            TransactionItemList.BindingList.AddRange(editItemList);
            form.ShowDialog();
        }
    }
}

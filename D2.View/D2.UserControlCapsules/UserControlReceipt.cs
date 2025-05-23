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
            ReceiptReport.ReceiptSetup(reportViewerReceipt);
        }
    }
}

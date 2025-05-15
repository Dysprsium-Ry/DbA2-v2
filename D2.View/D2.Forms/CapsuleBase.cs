using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_13_25.D2.View.D2.Forms
{
    public partial class CapsuleBase : Form
    {
        private Control _control;

        public CapsuleBase(Control control)
        {
            InitializeComponent();

            this.FormClosing += (s, e) => { this.Controls.Clear(); };
            _control = control;
        }

        private void CapsuleBase_Load(object sender, EventArgs e)
        {
            this.Size = _control.Size;
            _control.Dock = DockStyle.Fill;
            this.Controls.Add(_control);
        }

        private void CapsuleBase_ControlRemoved(object sender, ControlEventArgs e)
        {
            this.Close();
        }

        private void CapsuleBase_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }
    }
}

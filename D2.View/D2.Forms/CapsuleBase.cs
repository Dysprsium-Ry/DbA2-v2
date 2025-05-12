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
        public CapsuleBase()
        {
            InitializeComponent();

            this.FormClosing += (s, e) => { this.Controls.Clear(); };
        }
    }
}

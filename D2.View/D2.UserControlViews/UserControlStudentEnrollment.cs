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
    public partial class UserControlStudentEnrollment : UserControl
    {
        public UserControlStudentEnrollment()
        {
            InitializeComponent();
        }

        private void UserControlStudentEnrollment_Load(object sender, EventArgs e)
        {
            TemporalData.StudentLUserN = textBoxUsername.Text;
            TemporalData.StudentFirstName = textBoxFname.Text;
            TemporalData.StudentLastName = textBoxLname.Text;
            TemporalData.StudentEmail = textBoxEmail.Text;
            TemporalData.StudentLevel = textBoxLevel.Text;

            if (!StudEnrollmentLogics.IsStudentExist())
            {

            }
            else { MessageBox.Show("Username already used please select another.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);}
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }
    }
}

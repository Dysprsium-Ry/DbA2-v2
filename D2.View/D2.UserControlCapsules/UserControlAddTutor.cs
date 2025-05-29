using _3_13_25.D2.DbConn;
using _3_13_25.D2.Model;
using _3_13_25.D2.QueryStorage;
using _3_13_25.D2.View.D2.Forms;
using BienvenidoOnlineTutorServices.D2.Classes;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    public partial class UserControlAddTutor : UserControl
    {
        CapsuleBase _capsule;
        private BindingList<ExpertiseList> _list;

        public UserControlAddTutor()
        {
            InitializeComponent();
        }

        private void UserControlAddTutor_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Empty Field/s", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            TemporalData.TutorName = textBoxTutorName.Text;
            TemporalData.TutorEmail = textBoxTutorEmail.Text;

            if (TutorClass.CheckTutor())
            {
                MessageBox.Show("Tutor already exists", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TutorClass.ManageTutor();
            TemporalData.TutorId = TutorClass.FetchTutorId();

            if (_list != null)
            {
                foreach (var item in _list)
                {
                    TutorClass.registerExpertise(TemporalData.TutorId, item.SubjectId, item.HourlyRate, item.InTime, item.OutTime);
                }
            }

            this.Dispose();
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                }

                if (control is DateTimePicker picker)
                {
                    picker.Value = DateTime.Today;
                }
            }
        }

        private void buttonAddExpertise_Click(object sender, EventArgs e)
        {
            UserControlSelectExpertise _open = new UserControlSelectExpertise(long.MinValue, _list);
            _capsule = new CapsuleBase(_open);
            _capsule.ShowDialog();
            _list = Expertise.expertiseLists;
        }

        private void UserControlAddTutor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) buttonAddExpertise_Click(sender, e);
        }

        private void Register_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonRegisterTutor_Click(sender, e);
            else if (e.KeyCode == Keys.Escape) CapsuleBase.ActiveForm.Close();
            else return;
        }
    }
}

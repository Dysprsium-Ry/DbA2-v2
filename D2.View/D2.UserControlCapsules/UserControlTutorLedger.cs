using _3_13_25.D2.DbConn;
using _3_13_25.D2.Model;
using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.View.D2.UserControlCapsules;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlTutorLedger : UserControl
    {
        private long _tutorId;
        private long _subjectId;
        private CapsuleBase _capsule;
        private BindingList<WeeklyScheduleSource> _source = new BindingList<WeeklyScheduleSource>();
        private BindingList<ExpertiseList> _list = new BindingList<ExpertiseList>();

        public UserControlTutorLedger(long tutorId, string tutorname, string email)
        {
            InitializeComponent();
            _tutorId = tutorId;
            textBoxTutorName.Text = tutorname;
            textBoxEmail.Text = email;
        }

        private void UserControlTutorLedger_Load(object sender, EventArgs e)
        {
            _source = DataLoadCast.WeekSchedule(_tutorId);
            _list = DataLoadCast.TutorExpertise(_tutorId);
            DataGrid_Load(dataGridViewWeekSchedule, _source);
            DataGrid_Load(dataGridViewSubjectList, _list);
            SetColumnHeaders(dataGridViewSubjectList);
        }

        private void DataGrid_Load(DataGridView view, object source)
        {
            view.DataSource = null;
            view.DataSource = source;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm changes?", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TutorClass.PendingDelete.Count > 0)
                {
                    foreach (var item in TutorClass.PendingDelete)
                    {
                        if (TutorClass.IsExpertiseExist(_tutorId, item))
                        {
                            TutorClass.DeleteExpertise(_tutorId, item);
                        }
                    }
                }

                foreach (var item in _list)
                {
                    if (TutorClass.IsExpertiseExist(_tutorId, item.SubjectId))
                    {
                        TutorClass.UpdateDetails(_tutorId, textBoxTutorName.Text, textBoxEmail.Text);
                    }
                    else
                    {
                        TutorClass.registerExpertise(_tutorId, item.SubjectId, item.HourlyRate, item.InTime, item.OutTime);
                    }
                }

                TutorClass.UpdateDetails(_tutorId, textBoxTutorName.Text, textBoxEmail.Text);
                this.ParentForm.Close();
            }
        }

        private void buttonModifySubjects_Click(object sender, EventArgs e)
        {
            UserControlSelectExpertise _open = new UserControlSelectExpertise(_tutorId, _list);
            _capsule = new CapsuleBase(_open);
            _capsule.ShowDialog();
            _list = Expertise.expertiseLists;
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("SubjectId"))
            {
                dgv.Columns["SubjectId"].HeaderText = "Transaction ID";
                dgv.Columns["SubjectId"].Visible = false;
            }

            if (dgv.Columns.Contains("HourlyRate"))
                dgv.Columns["HourlyRate"].HeaderText = "Hourly Rate";

            if (dgv.Columns.Contains("InTime"))
                dgv.Columns["InTime"].HeaderText = "In Time";

            if (dgv.Columns.Contains("OutTime"))
                dgv.Columns["OutTime"].HeaderText = "Out Time";
        }
    }
}

using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using System;
using System.Windows.Forms;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlSubjectLibControls : UserControl
    {
        public enum RegistrationType { Save, Update }
        private RegistrationType _registrationType;
        private readonly long _subjectId;

        public UserControlSubjectLibControls(RegistrationType registrationType, long subjectId)
        {
            InitializeComponent();
            buttonSave.Text = registrationType == RegistrationType.Save ? RegistrationType.Save.ToString() : RegistrationType.Update.ToString();
            _registrationType = registrationType;
            _subjectId = subjectId;
        }

        private void UserControlSubjectLibControls_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_registrationType == RegistrationType.Save)
            {
                if (!string.IsNullOrWhiteSpace(textBoxSubject.Text))
                {
                    SubjectLogics.RegisterSubject(textBoxSubject.Text);
                    CapsuleBase.ActiveForm.Close();
                }
            }
            else if (_registrationType == RegistrationType.Update)
            {
                if (!string.IsNullOrWhiteSpace(textBoxSubject.Text))
                {
                    SubjectLogics.UpdateSubject(_subjectId, textBoxSubject.Text);  
                    CapsuleBase.ActiveForm.Close();
                }
            }
            else { }
        }
    }
}

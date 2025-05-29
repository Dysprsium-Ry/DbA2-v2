namespace _3_13_25.D2.View.D2.UserControlViews
{
    partial class UserControlTutorLedger
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.labelWeekValue = new System.Windows.Forms.Label();
            this.labelTotalIncome = new System.Windows.Forms.Label();
            this.labelThisWeekIncome = new System.Windows.Forms.Label();
            this.textBoxTutorName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonModifySubjects = new System.Windows.Forms.Button();
            this.dataGridViewSubjectList = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelWeekSchedule = new System.Windows.Forms.Panel();
            this.dataGridViewWeekSchedule = new System.Windows.Forms.DataGridView();
            this.transactionIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourlyRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionScheduleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endScheduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeklyScheduleSourceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectList)).BeginInit();
            this.panelWeekSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeekSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyScheduleSourceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalValue.Location = new System.Drawing.Point(415, 249);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(41, 21);
            this.labelTotalValue.TabIndex = 4;
            this.labelTotalValue.Text = "0.00";
            this.labelTotalValue.Visible = false;
            // 
            // labelWeekValue
            // 
            this.labelWeekValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWeekValue.AutoSize = true;
            this.labelWeekValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeekValue.Location = new System.Drawing.Point(154, 249);
            this.labelWeekValue.Name = "labelWeekValue";
            this.labelWeekValue.Size = new System.Drawing.Size(41, 21);
            this.labelWeekValue.TabIndex = 3;
            this.labelWeekValue.Text = "0.00";
            this.labelWeekValue.Visible = false;
            // 
            // labelTotalIncome
            // 
            this.labelTotalIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalIncome.AutoSize = true;
            this.labelTotalIncome.Location = new System.Drawing.Point(305, 249);
            this.labelTotalIncome.Name = "labelTotalIncome";
            this.labelTotalIncome.Size = new System.Drawing.Size(104, 21);
            this.labelTotalIncome.TabIndex = 2;
            this.labelTotalIncome.Text = "Total Income :";
            this.labelTotalIncome.Visible = false;
            // 
            // labelThisWeekIncome
            // 
            this.labelThisWeekIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelThisWeekIncome.AutoSize = true;
            this.labelThisWeekIncome.Location = new System.Drawing.Point(8, 249);
            this.labelThisWeekIncome.Name = "labelThisWeekIncome";
            this.labelThisWeekIncome.Size = new System.Drawing.Size(140, 21);
            this.labelThisWeekIncome.TabIndex = 1;
            this.labelThisWeekIncome.Text = "This week Income :";
            this.labelThisWeekIncome.Visible = false;
            // 
            // textBoxTutorName
            // 
            this.textBoxTutorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxTutorName.Location = new System.Drawing.Point(92, 87);
            this.textBoxTutorName.Name = "textBoxTutorName";
            this.textBoxTutorName.Size = new System.Drawing.Size(213, 29);
            this.textBoxTutorName.TabIndex = 0;
            this.textBoxTutorName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSave_KeyUp);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 90);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name :";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(19, 158);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 21);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxEmail.Location = new System.Drawing.Point(92, 155);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(213, 29);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSave_KeyUp);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelTop.Controls.Add(this.buttonModifySubjects);
            this.panelTop.Controls.Add(this.dataGridViewSubjectList);
            this.panelTop.Controls.Add(this.buttonSave);
            this.panelTop.Controls.Add(this.textBoxTutorName);
            this.panelTop.Controls.Add(this.labelName);
            this.panelTop.Controls.Add(this.labelEmail);
            this.panelTop.Controls.Add(this.textBoxEmail);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(5);
            this.panelTop.Size = new System.Drawing.Size(986, 280);
            this.panelTop.TabIndex = 1;
            // 
            // buttonModifySubjects
            // 
            this.buttonModifySubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonModifySubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifySubjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifySubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonModifySubjects.Location = new System.Drawing.Point(23, 226);
            this.buttonModifySubjects.Name = "buttonModifySubjects";
            this.buttonModifySubjects.Size = new System.Drawing.Size(135, 35);
            this.buttonModifySubjects.TabIndex = 17;
            this.buttonModifySubjects.Text = "Modify";
            this.buttonModifySubjects.UseVisualStyleBackColor = false;
            this.buttonModifySubjects.Click += new System.EventHandler(this.buttonModifySubjects_Click);
            // 
            // dataGridViewSubjectList
            // 
            this.dataGridViewSubjectList.AllowUserToAddRows = false;
            this.dataGridViewSubjectList.AllowUserToDeleteRows = false;
            this.dataGridViewSubjectList.AllowUserToResizeColumns = false;
            this.dataGridViewSubjectList.AllowUserToResizeRows = false;
            this.dataGridViewSubjectList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSubjectList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubjectList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewSubjectList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubjectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSubjectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubjectList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSubjectList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewSubjectList.EnableHeadersVisualStyles = false;
            this.dataGridViewSubjectList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSubjectList.Location = new System.Drawing.Point(322, 8);
            this.dataGridViewSubjectList.Name = "dataGridViewSubjectList";
            this.dataGridViewSubjectList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewSubjectList.RowHeadersVisible = false;
            this.dataGridViewSubjectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSubjectList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSubjectList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridViewSubjectList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewSubjectList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewSubjectList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewSubjectList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubjectList.Size = new System.Drawing.Size(652, 253);
            this.dataGridViewSubjectList.TabIndex = 16;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonSave.Location = new System.Drawing.Point(170, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 35);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonSave_KeyUp);
            // 
            // panelWeekSchedule
            // 
            this.panelWeekSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelWeekSchedule.Controls.Add(this.labelTotalValue);
            this.panelWeekSchedule.Controls.Add(this.dataGridViewWeekSchedule);
            this.panelWeekSchedule.Controls.Add(this.labelThisWeekIncome);
            this.panelWeekSchedule.Controls.Add(this.labelWeekValue);
            this.panelWeekSchedule.Controls.Add(this.labelTotalIncome);
            this.panelWeekSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWeekSchedule.Location = new System.Drawing.Point(3, 283);
            this.panelWeekSchedule.Name = "panelWeekSchedule";
            this.panelWeekSchedule.Padding = new System.Windows.Forms.Padding(12);
            this.panelWeekSchedule.Size = new System.Drawing.Size(986, 282);
            this.panelWeekSchedule.TabIndex = 2;
            // 
            // dataGridViewWeekSchedule
            // 
            this.dataGridViewWeekSchedule.AllowUserToAddRows = false;
            this.dataGridViewWeekSchedule.AllowUserToDeleteRows = false;
            this.dataGridViewWeekSchedule.AllowUserToResizeColumns = false;
            this.dataGridViewWeekSchedule.AllowUserToResizeRows = false;
            this.dataGridViewWeekSchedule.AutoGenerateColumns = false;
            this.dataGridViewWeekSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWeekSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewWeekSchedule.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewWeekSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewWeekSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeekSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIdDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.tutorIdDataGridViewTextBoxColumn,
            this.tutorNameDataGridViewTextBoxColumn,
            this.hourlyRateDataGridViewTextBoxColumn,
            this.sessionScheduleDateDataGridViewTextBoxColumn,
            this.startScheduleDataGridViewTextBoxColumn,
            this.endScheduleDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridViewWeekSchedule.DataSource = this.weeklyScheduleSourceBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewWeekSchedule.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewWeekSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewWeekSchedule.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewWeekSchedule.EnableHeadersVisualStyles = false;
            this.dataGridViewWeekSchedule.GridColor = System.Drawing.Color.Black;
            this.dataGridViewWeekSchedule.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewWeekSchedule.Name = "dataGridViewWeekSchedule";
            this.dataGridViewWeekSchedule.ReadOnly = true;
            this.dataGridViewWeekSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewWeekSchedule.RowHeadersVisible = false;
            this.dataGridViewWeekSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewWeekSchedule.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewWeekSchedule.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridViewWeekSchedule.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewWeekSchedule.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewWeekSchedule.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dataGridViewWeekSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWeekSchedule.Size = new System.Drawing.Size(962, 221);
            this.dataGridViewWeekSchedule.TabIndex = 17;
            // 
            // transactionIdDataGridViewTextBoxColumn
            // 
            this.transactionIdDataGridViewTextBoxColumn.DataPropertyName = "TransactionId";
            this.transactionIdDataGridViewTextBoxColumn.HeaderText = "Transaction Id";
            this.transactionIdDataGridViewTextBoxColumn.Name = "transactionIdDataGridViewTextBoxColumn";
            this.transactionIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorIdDataGridViewTextBoxColumn
            // 
            this.tutorIdDataGridViewTextBoxColumn.DataPropertyName = "TutorId";
            this.tutorIdDataGridViewTextBoxColumn.HeaderText = "TutorId";
            this.tutorIdDataGridViewTextBoxColumn.Name = "tutorIdDataGridViewTextBoxColumn";
            this.tutorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.tutorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // tutorNameDataGridViewTextBoxColumn
            // 
            this.tutorNameDataGridViewTextBoxColumn.DataPropertyName = "TutorName";
            this.tutorNameDataGridViewTextBoxColumn.HeaderText = "Tutor Name";
            this.tutorNameDataGridViewTextBoxColumn.Name = "tutorNameDataGridViewTextBoxColumn";
            this.tutorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourlyRateDataGridViewTextBoxColumn
            // 
            this.hourlyRateDataGridViewTextBoxColumn.DataPropertyName = "HourlyRate";
            this.hourlyRateDataGridViewTextBoxColumn.HeaderText = "Hourly Rate";
            this.hourlyRateDataGridViewTextBoxColumn.Name = "hourlyRateDataGridViewTextBoxColumn";
            this.hourlyRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionScheduleDateDataGridViewTextBoxColumn
            // 
            this.sessionScheduleDateDataGridViewTextBoxColumn.DataPropertyName = "SessionScheduleDate";
            this.sessionScheduleDateDataGridViewTextBoxColumn.HeaderText = "Schedule Date";
            this.sessionScheduleDateDataGridViewTextBoxColumn.Name = "sessionScheduleDateDataGridViewTextBoxColumn";
            this.sessionScheduleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startScheduleDataGridViewTextBoxColumn
            // 
            this.startScheduleDataGridViewTextBoxColumn.DataPropertyName = "StartSchedule";
            this.startScheduleDataGridViewTextBoxColumn.HeaderText = "In Time";
            this.startScheduleDataGridViewTextBoxColumn.Name = "startScheduleDataGridViewTextBoxColumn";
            this.startScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endScheduleDataGridViewTextBoxColumn
            // 
            this.endScheduleDataGridViewTextBoxColumn.DataPropertyName = "EndSchedule";
            this.endScheduleDataGridViewTextBoxColumn.HeaderText = "Out Time";
            this.endScheduleDataGridViewTextBoxColumn.Name = "endScheduleDataGridViewTextBoxColumn";
            this.endScheduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weeklyScheduleSourceBindingSource
            // 
            this.weeklyScheduleSourceBindingSource.DataSource = typeof(_3_13_25.D2.Model.WeeklyScheduleSource);
            // 
            // UserControlTutorLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelWeekSchedule);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserControlTutorLedger";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(992, 568);
            this.Load += new System.EventHandler(this.UserControlTutorLedger_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubjectList)).EndInit();
            this.panelWeekSchedule.ResumeLayout(false);
            this.panelWeekSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeekSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeklyScheduleSourceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTutorName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelThisWeekIncome;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Label labelWeekValue;
        private System.Windows.Forms.Label labelTotalIncome;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelWeekSchedule;
        private System.Windows.Forms.DataGridView dataGridViewSubjectList;
        private System.Windows.Forms.DataGridView dataGridViewWeekSchedule;
        private System.Windows.Forms.BindingSource weeklyScheduleSourceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourlyRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionScheduleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endScheduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonModifySubjects;
    }
}

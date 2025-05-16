namespace _3_13_25.D2.View.D2.UserControlViews
{
    partial class UserControlStudentEnrollment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxFname = new System.Windows.Forms.TextBox();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonEnroll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.dataGridViewStudentList = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(140, 387);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(255, 33);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxFname
            // 
            this.textBoxFname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFname.Location = new System.Drawing.Point(140, 426);
            this.textBoxFname.Name = "textBoxFname";
            this.textBoxFname.Size = new System.Drawing.Size(255, 33);
            this.textBoxFname.TabIndex = 1;
            this.textBoxFname.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxLname
            // 
            this.textBoxLname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLname.Location = new System.Drawing.Point(140, 465);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(255, 33);
            this.textBoxLname.TabIndex = 2;
            this.textBoxLname.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(583, 387);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(255, 33);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // buttonEnroll
            // 
            this.buttonEnroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonEnroll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonEnroll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonEnroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonEnroll.Location = new System.Drawing.Point(719, 517);
            this.buttonEnroll.Name = "buttonEnroll";
            this.buttonEnroll.Size = new System.Drawing.Size(119, 34);
            this.buttonEnroll.TabIndex = 5;
            this.buttonEnroll.Text = "Enroll";
            this.buttonEnroll.UseVisualStyleBackColor = false;
            this.buttonEnroll.Click += new System.EventHandler(this.buttonEnroll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonClear.Location = new System.Drawing.Point(594, 517);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(119, 34);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(46, 393);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUsername.Size = new System.Drawing.Size(88, 21);
            this.labelUsername.TabIndex = 10;
            this.labelUsername.Text = "Username :";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(41, 432);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFirstName.Size = new System.Drawing.Size(93, 21);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "First Name :";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(43, 471);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLastName.Size = new System.Drawing.Size(91, 21);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name :";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(522, 393);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEmail.Size = new System.Drawing.Size(55, 21);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email :";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(478, 431);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLevel.Size = new System.Drawing.Size(99, 21);
            this.labelLevel.TabIndex = 14;
            this.labelLevel.Text = "Grade Level :";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLevel.Location = new System.Drawing.Point(583, 425);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(255, 33);
            this.textBoxLevel.TabIndex = 4;
            this.textBoxLevel.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // dataGridViewStudentList
            // 
            this.dataGridViewStudentList.AllowUserToAddRows = false;
            this.dataGridViewStudentList.AllowUserToDeleteRows = false;
            this.dataGridViewStudentList.AllowUserToResizeColumns = false;
            this.dataGridViewStudentList.AllowUserToResizeRows = false;
            this.dataGridViewStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewStudentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.dataGridViewStudentList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStudentList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStudentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewStudentList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewStudentList.Location = new System.Drawing.Point(45, 24);
            this.dataGridViewStudentList.MultiSelect = false;
            this.dataGridViewStudentList.Name = "dataGridViewStudentList";
            this.dataGridViewStudentList.ReadOnly = true;
            this.dataGridViewStudentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStudentList.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewStudentList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudentList.ShowCellErrors = false;
            this.dataGridViewStudentList.ShowCellToolTips = false;
            this.dataGridViewStudentList.ShowEditingIcon = false;
            this.dataGridViewStudentList.ShowRowErrors = false;
            this.dataGridViewStudentList.Size = new System.Drawing.Size(793, 348);
            this.dataGridViewStudentList.TabIndex = 9;
            this.dataGridViewStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellClick);
            this.dataGridViewStudentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudentList_CellDoubleClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonUpdate.Location = new System.Drawing.Point(469, 517);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 34);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonDelete.Location = new System.Drawing.Point(344, 517);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(119, 34);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UserControlStudentEnrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewStudentList);
            this.Controls.Add(this.labelLevel);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEnroll);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLname);
            this.Controls.Add(this.textBoxFname);
            this.Controls.Add(this.textBoxUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlStudentEnrollment";
            this.Size = new System.Drawing.Size(884, 568);
            this.Load += new System.EventHandler(this.UserControlStudentEnrollment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxFname;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonEnroll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.DataGridView dataGridViewStudentList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

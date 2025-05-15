namespace _3_13_25.D2.View.D2.MainFormV
{
    partial class CapsuleForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ComboBoxSubjectSelection = new System.Windows.Forms.ComboBox();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.labelSessionSchedule = new System.Windows.Forms.Label();
            this.DateTimePickerDateSelection = new System.Windows.Forms.DateTimePicker();
            this.ComboBoxTutorSelection = new System.Windows.Forms.ComboBox();
            this.labelTutor = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelTimeSchedule = new System.Windows.Forms.Label();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxTimeSchedule = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxSubjectSelection
            // 
            this.ComboBoxSubjectSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSubjectSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSubjectSelection.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSubjectSelection.FormattingEnabled = true;
            this.ComboBoxSubjectSelection.Location = new System.Drawing.Point(167, 59);
            this.ComboBoxSubjectSelection.Name = "ComboBoxSubjectSelection";
            this.ComboBoxSubjectSelection.Size = new System.Drawing.Size(308, 31);
            this.ComboBoxSubjectSelection.TabIndex = 0;
            this.ComboBoxSubjectSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSubjectSelection_SelectedIndexChanged);
            // 
            // labelSubjects
            // 
            this.labelSubjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubjects.ForeColor = System.Drawing.Color.Black;
            this.labelSubjects.Location = new System.Drawing.Point(91, 62);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(70, 23);
            this.labelSubjects.TabIndex = 4;
            this.labelSubjects.Text = "Subject:";
            // 
            // labelSessionSchedule
            // 
            this.labelSessionSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSessionSchedule.AutoSize = true;
            this.labelSessionSchedule.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSessionSchedule.ForeColor = System.Drawing.Color.Black;
            this.labelSessionSchedule.Location = new System.Drawing.Point(17, 268);
            this.labelSessionSchedule.Name = "labelSessionSchedule";
            this.labelSessionSchedule.Size = new System.Drawing.Size(144, 23);
            this.labelSessionSchedule.TabIndex = 6;
            this.labelSessionSchedule.Text = "Session Schedule:";
            // 
            // DateTimePickerDateSelection
            // 
            this.DateTimePickerDateSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerDateSelection.CustomFormat = "MMM  dd,  yyyy  ||  hh:mm tt";
            this.DateTimePickerDateSelection.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDateSelection.Location = new System.Drawing.Point(167, 265);
            this.DateTimePickerDateSelection.Name = "DateTimePickerDateSelection";
            this.DateTimePickerDateSelection.Size = new System.Drawing.Size(308, 30);
            this.DateTimePickerDateSelection.TabIndex = 2;
            // 
            // ComboBoxTutorSelection
            // 
            this.ComboBoxTutorSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxTutorSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTutorSelection.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxTutorSelection.FormattingEnabled = true;
            this.ComboBoxTutorSelection.Location = new System.Drawing.Point(167, 111);
            this.ComboBoxTutorSelection.Name = "ComboBoxTutorSelection";
            this.ComboBoxTutorSelection.Size = new System.Drawing.Size(308, 31);
            this.ComboBoxTutorSelection.TabIndex = 1;
            this.ComboBoxTutorSelection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTutorSelection_SelectedIndexChanged);
            // 
            // labelTutor
            // 
            this.labelTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTutor.AutoSize = true;
            this.labelTutor.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTutor.ForeColor = System.Drawing.Color.Black;
            this.labelTutor.Location = new System.Drawing.Point(106, 114);
            this.labelTutor.Name = "labelTutor";
            this.labelTutor.Size = new System.Drawing.Size(55, 23);
            this.labelTutor.TabIndex = 5;
            this.labelTutor.Text = "Tutor:";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyRate.ForeColor = System.Drawing.Color.Black;
            this.labelHourlyRate.Location = new System.Drawing.Point(63, 166);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(98, 23);
            this.labelHourlyRate.TabIndex = 8;
            this.labelHourlyRate.Text = "HourlyRate:";
            // 
            // labelTimeSchedule
            // 
            this.labelTimeSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimeSchedule.AutoSize = true;
            this.labelTimeSchedule.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeSchedule.ForeColor = System.Drawing.Color.Black;
            this.labelTimeSchedule.Location = new System.Drawing.Point(36, 217);
            this.labelTimeSchedule.Name = "labelTimeSchedule";
            this.labelTimeSchedule.Size = new System.Drawing.Size(125, 23);
            this.labelTimeSchedule.TabIndex = 9;
            this.labelTimeSchedule.Text = "Time Schedule:";
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHourlyRate.Enabled = false;
            this.textBoxHourlyRate.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHourlyRate.Location = new System.Drawing.Point(167, 163);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(308, 30);
            this.textBoxHourlyRate.TabIndex = 10;
            // 
            // textBoxTimeSchedule
            // 
            this.textBoxTimeSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimeSchedule.Enabled = false;
            this.textBoxTimeSchedule.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimeSchedule.Location = new System.Drawing.Point(167, 214);
            this.textBoxTimeSchedule.Name = "textBoxTimeSchedule";
            this.textBoxTimeSchedule.Size = new System.Drawing.Size(308, 30);
            this.textBoxTimeSchedule.TabIndex = 11;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(12, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 37);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirm.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonConfirm.ForeColor = System.Drawing.Color.White;
            this.buttonConfirm.Location = new System.Drawing.Point(402, 330);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(112, 37);
            this.buttonConfirm.TabIndex = 13;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = false;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // CapsuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(526, 379);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxTimeSchedule);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.labelTimeSchedule);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.ComboBoxTutorSelection);
            this.Controls.Add(this.labelTutor);
            this.Controls.Add(this.DateTimePickerDateSelection);
            this.Controls.Add(this.ComboBoxSubjectSelection);
            this.Controls.Add(this.labelSubjects);
            this.Controls.Add(this.labelSessionSchedule);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CapsuleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "__";
            this.Load += new System.EventHandler(this.CapsuleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxSubjectSelection;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.Label labelSessionSchedule;
        private System.Windows.Forms.DateTimePicker DateTimePickerDateSelection;
        private System.Windows.Forms.ComboBox ComboBoxTutorSelection;
        private System.Windows.Forms.Label labelTutor;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.Label labelTimeSchedule;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.TextBox textBoxTimeSchedule;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
    }
}
namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    partial class UserControlSelectExpertise
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
            this.dataGridViewExpertiseList = new System.Windows.Forms.DataGridView();
            this.comboBoxExpertise = new System.Windows.Forms.ComboBox();
            this.labelExpertise = new System.Windows.Forms.Label();
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.numericUpDownHourlyRate = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBeginTime = new System.Windows.Forms.DateTimePicker();
            this.labelOutTime = new System.Windows.Forms.Label();
            this.labelInTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpertiseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourlyRate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExpertiseList
            // 
            this.dataGridViewExpertiseList.AllowUserToAddRows = false;
            this.dataGridViewExpertiseList.AllowUserToDeleteRows = false;
            this.dataGridViewExpertiseList.AllowUserToResizeColumns = false;
            this.dataGridViewExpertiseList.AllowUserToResizeRows = false;
            this.dataGridViewExpertiseList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExpertiseList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpertiseList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewExpertiseList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewExpertiseList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewExpertiseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewExpertiseList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewExpertiseList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewExpertiseList.EnableHeadersVisualStyles = false;
            this.dataGridViewExpertiseList.Location = new System.Drawing.Point(10, 124);
            this.dataGridViewExpertiseList.MultiSelect = false;
            this.dataGridViewExpertiseList.Name = "dataGridViewExpertiseList";
            this.dataGridViewExpertiseList.ReadOnly = true;
            this.dataGridViewExpertiseList.RowHeadersVisible = false;
            this.dataGridViewExpertiseList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewExpertiseList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExpertiseList.Size = new System.Drawing.Size(620, 206);
            this.dataGridViewExpertiseList.TabIndex = 0;
            // 
            // comboBoxExpertise
            // 
            this.comboBoxExpertise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxExpertise.FormattingEnabled = true;
            this.comboBoxExpertise.Location = new System.Drawing.Point(118, 33);
            this.comboBoxExpertise.Name = "comboBoxExpertise";
            this.comboBoxExpertise.Size = new System.Drawing.Size(168, 29);
            this.comboBoxExpertise.TabIndex = 1;
            this.comboBoxExpertise.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // labelExpertise
            // 
            this.labelExpertise.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelExpertise.AutoSize = true;
            this.labelExpertise.Location = new System.Drawing.Point(33, 36);
            this.labelExpertise.Name = "labelExpertise";
            this.labelExpertise.Size = new System.Drawing.Size(79, 21);
            this.labelExpertise.TabIndex = 2;
            this.labelExpertise.Text = "Expertise :";
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(13, 77);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(99, 21);
            this.labelHourlyRate.TabIndex = 3;
            this.labelHourlyRate.Text = "Hourly Rate :";
            // 
            // numericUpDownHourlyRate
            // 
            this.numericUpDownHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownHourlyRate.DecimalPlaces = 2;
            this.numericUpDownHourlyRate.Location = new System.Drawing.Point(118, 75);
            this.numericUpDownHourlyRate.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownHourlyRate.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHourlyRate.Name = "numericUpDownHourlyRate";
            this.numericUpDownHourlyRate.Size = new System.Drawing.Size(168, 29);
            this.numericUpDownHourlyRate.TabIndex = 4;
            this.numericUpDownHourlyRate.ThousandsSeparator = true;
            this.numericUpDownHourlyRate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownHourlyRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(503, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(127, 29);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            this.buttonAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.ForeColor = System.Drawing.Color.White;
            this.buttonRemove.Location = new System.Drawing.Point(370, 336);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(127, 29);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(237, 336);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(127, 29);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Clear";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(404, 75);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerEndTime.TabIndex = 18;
            this.dateTimePickerEndTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // dateTimePickerBeginTime
            // 
            this.dateTimePickerBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBeginTime.Location = new System.Drawing.Point(404, 33);
            this.dateTimePickerBeginTime.Name = "dateTimePickerBeginTime";
            this.dateTimePickerBeginTime.ShowUpDown = true;
            this.dateTimePickerBeginTime.Size = new System.Drawing.Size(200, 29);
            this.dateTimePickerBeginTime.TabIndex = 17;
            this.dateTimePickerBeginTime.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            // 
            // labelOutTime
            // 
            this.labelOutTime.AutoSize = true;
            this.labelOutTime.Location = new System.Drawing.Point(317, 78);
            this.labelOutTime.Name = "labelOutTime";
            this.labelOutTime.Size = new System.Drawing.Size(81, 21);
            this.labelOutTime.TabIndex = 16;
            this.labelOutTime.Text = "Out Time :";
            // 
            // labelInTime
            // 
            this.labelInTime.AutoSize = true;
            this.labelInTime.Location = new System.Drawing.Point(330, 34);
            this.labelInTime.Name = "labelInTime";
            this.labelInTime.Size = new System.Drawing.Size(68, 21);
            this.labelInTime.TabIndex = 15;
            this.labelInTime.Text = "In Time :";
            // 
            // UserControlSelectExpertise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerBeginTime);
            this.Controls.Add(this.labelOutTime);
            this.Controls.Add(this.labelInTime);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownHourlyRate);
            this.Controls.Add(this.labelHourlyRate);
            this.Controls.Add(this.labelExpertise);
            this.Controls.Add(this.comboBoxExpertise);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewExpertiseList);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9);
            this.Name = "UserControlSelectExpertise";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(640, 391);
            this.Load += new System.EventHandler(this.UserControlSelectExpertise_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Register_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpertiseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHourlyRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExpertiseList;
        private System.Windows.Forms.ComboBox comboBoxExpertise;
        private System.Windows.Forms.Label labelExpertise;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.NumericUpDown numericUpDownHourlyRate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginTime;
        private System.Windows.Forms.Label labelOutTime;
        private System.Windows.Forms.Label labelInTime;
    }
}

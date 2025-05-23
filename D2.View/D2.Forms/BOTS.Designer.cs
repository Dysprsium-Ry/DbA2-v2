namespace BienvenidoOnlineTutorServices.D2.Forms
{
    partial class MainForm
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panelMainField = new System.Windows.Forms.Panel();
            this.buttonBillHistory = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonReceiptPage = new System.Windows.Forms.Button();
            this.buttonTransactionBillingPage = new System.Windows.Forms.Button();
            this.buttonSubjectLibraryPage = new System.Windows.Forms.Button();
            this.buttonTutorRegistrationPage = new System.Windows.Forms.Button();
            this.buttonStudentEnrollmentPage = new System.Windows.Forms.Button();
            this.buttonTransactionListPage = new System.Windows.Forms.Button();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.SidePanel.Controls.Add(this.buttonBillHistory);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.buttonReceiptPage);
            this.SidePanel.Controls.Add(this.buttonTransactionBillingPage);
            this.SidePanel.Controls.Add(this.buttonSubjectLibraryPage);
            this.SidePanel.Controls.Add(this.buttonTutorRegistrationPage);
            this.SidePanel.Controls.Add(this.buttonStudentEnrollmentPage);
            this.SidePanel.Controls.Add(this.buttonTransactionListPage);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Padding = new System.Windows.Forms.Padding(10);
            this.SidePanel.Size = new System.Drawing.Size(226, 568);
            this.SidePanel.TabIndex = 1;
            // 
            // panelMainField
            // 
            this.panelMainField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.panelMainField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainField.Location = new System.Drawing.Point(226, 0);
            this.panelMainField.Name = "panelMainField";
            this.panelMainField.Padding = new System.Windows.Forms.Padding(10);
            this.panelMainField.Size = new System.Drawing.Size(884, 568);
            this.panelMainField.TabIndex = 2;
            this.panelMainField.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panelMainField_ControlRemoved);
            // 
            // buttonBillHistory
            // 
            this.buttonBillHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonBillHistory.FlatAppearance.BorderSize = 0;
            this.buttonBillHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonBillHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonBillHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBillHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBillHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonBillHistory.Image = global::_3_13_25.Properties.Resources.icons8_activity_history_30;
            this.buttonBillHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBillHistory.Location = new System.Drawing.Point(7, 432);
            this.buttonBillHistory.Name = "buttonBillHistory";
            this.buttonBillHistory.Size = new System.Drawing.Size(211, 41);
            this.buttonBillHistory.TabIndex = 7;
            this.buttonBillHistory.Text = "          Billing History";
            this.buttonBillHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBillHistory.UseVisualStyleBackColor = false;
            this.buttonBillHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::_3_13_25.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonReceiptPage
            // 
            this.buttonReceiptPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonReceiptPage.FlatAppearance.BorderSize = 0;
            this.buttonReceiptPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonReceiptPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonReceiptPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReceiptPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReceiptPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonReceiptPage.Image = global::_3_13_25.Properties.Resources.icons8_invoice_30;
            this.buttonReceiptPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceiptPage.Location = new System.Drawing.Point(7, 514);
            this.buttonReceiptPage.Name = "buttonReceiptPage";
            this.buttonReceiptPage.Size = new System.Drawing.Size(211, 41);
            this.buttonReceiptPage.TabIndex = 6;
            this.buttonReceiptPage.Text = "          Receipt";
            this.buttonReceiptPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReceiptPage.UseVisualStyleBackColor = false;
            this.buttonReceiptPage.Visible = false;
            this.buttonReceiptPage.Click += new System.EventHandler(this.buttonReceiptPage_Click);
            // 
            // buttonTransactionBillingPage
            // 
            this.buttonTransactionBillingPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonTransactionBillingPage.FlatAppearance.BorderSize = 0;
            this.buttonTransactionBillingPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTransactionBillingPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTransactionBillingPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionBillingPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionBillingPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonTransactionBillingPage.Image = global::_3_13_25.Properties.Resources.icons8_cash_register_30;
            this.buttonTransactionBillingPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactionBillingPage.Location = new System.Drawing.Point(7, 385);
            this.buttonTransactionBillingPage.Name = "buttonTransactionBillingPage";
            this.buttonTransactionBillingPage.Size = new System.Drawing.Size(211, 41);
            this.buttonTransactionBillingPage.TabIndex = 5;
            this.buttonTransactionBillingPage.Text = "       Transaction Billing";
            this.buttonTransactionBillingPage.UseVisualStyleBackColor = false;
            this.buttonTransactionBillingPage.Click += new System.EventHandler(this.buttonTransactionBillingPage_Click);
            // 
            // buttonSubjectLibraryPage
            // 
            this.buttonSubjectLibraryPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonSubjectLibraryPage.FlatAppearance.BorderSize = 0;
            this.buttonSubjectLibraryPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonSubjectLibraryPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonSubjectLibraryPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubjectLibraryPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubjectLibraryPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonSubjectLibraryPage.Image = global::_3_13_25.Properties.Resources.icons8_books_30;
            this.buttonSubjectLibraryPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubjectLibraryPage.Location = new System.Drawing.Point(7, 339);
            this.buttonSubjectLibraryPage.Name = "buttonSubjectLibraryPage";
            this.buttonSubjectLibraryPage.Size = new System.Drawing.Size(211, 41);
            this.buttonSubjectLibraryPage.TabIndex = 4;
            this.buttonSubjectLibraryPage.Text = "Subject Library";
            this.buttonSubjectLibraryPage.UseVisualStyleBackColor = false;
            this.buttonSubjectLibraryPage.Click += new System.EventHandler(this.buttonSubjectLibraryPage_Click);
            // 
            // buttonTutorRegistrationPage
            // 
            this.buttonTutorRegistrationPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonTutorRegistrationPage.FlatAppearance.BorderSize = 0;
            this.buttonTutorRegistrationPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTutorRegistrationPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTutorRegistrationPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTutorRegistrationPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTutorRegistrationPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonTutorRegistrationPage.Image = global::_3_13_25.Properties.Resources.icons8_teacher_30;
            this.buttonTutorRegistrationPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTutorRegistrationPage.Location = new System.Drawing.Point(7, 293);
            this.buttonTutorRegistrationPage.Name = "buttonTutorRegistrationPage";
            this.buttonTutorRegistrationPage.Size = new System.Drawing.Size(211, 41);
            this.buttonTutorRegistrationPage.TabIndex = 2;
            this.buttonTutorRegistrationPage.Text = "        Tutor Management";
            this.buttonTutorRegistrationPage.UseVisualStyleBackColor = false;
            this.buttonTutorRegistrationPage.Click += new System.EventHandler(this.buttonTutorRegistrationPage_Click);
            // 
            // buttonStudentEnrollmentPage
            // 
            this.buttonStudentEnrollmentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonStudentEnrollmentPage.FlatAppearance.BorderSize = 0;
            this.buttonStudentEnrollmentPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonStudentEnrollmentPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonStudentEnrollmentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentEnrollmentPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentEnrollmentPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonStudentEnrollmentPage.Image = global::_3_13_25.Properties.Resources.icons8_student_registration_30;
            this.buttonStudentEnrollmentPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStudentEnrollmentPage.Location = new System.Drawing.Point(7, 247);
            this.buttonStudentEnrollmentPage.Name = "buttonStudentEnrollmentPage";
            this.buttonStudentEnrollmentPage.Size = new System.Drawing.Size(211, 41);
            this.buttonStudentEnrollmentPage.TabIndex = 1;
            this.buttonStudentEnrollmentPage.Text = "         Student Enrollment";
            this.buttonStudentEnrollmentPage.UseVisualStyleBackColor = false;
            this.buttonStudentEnrollmentPage.Click += new System.EventHandler(this.buttonStudentEnrollmentPage_Click);
            // 
            // buttonTransactionListPage
            // 
            this.buttonTransactionListPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.buttonTransactionListPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTransactionListPage.FlatAppearance.BorderSize = 0;
            this.buttonTransactionListPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTransactionListPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(184)))), ((int)(((byte)(139)))));
            this.buttonTransactionListPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionListPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionListPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.buttonTransactionListPage.Image = global::_3_13_25.Properties.Resources.icons8_transaction_list_30_2_;
            this.buttonTransactionListPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransactionListPage.Location = new System.Drawing.Point(7, 201);
            this.buttonTransactionListPage.Name = "buttonTransactionListPage";
            this.buttonTransactionListPage.Size = new System.Drawing.Size(211, 41);
            this.buttonTransactionListPage.TabIndex = 0;
            this.buttonTransactionListPage.Text = " Transaction List";
            this.buttonTransactionListPage.UseVisualStyleBackColor = false;
            this.buttonTransactionListPage.Click += new System.EventHandler(this.TransactionListPage_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1110, 568);
            this.Controls.Add(this.panelMainField);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button buttonTutorRegistrationPage;
        private System.Windows.Forms.Button buttonStudentEnrollmentPage;
        private System.Windows.Forms.Button buttonTransactionListPage;
        private System.Windows.Forms.Button buttonReceiptPage;
        private System.Windows.Forms.Button buttonTransactionBillingPage;
        private System.Windows.Forms.Button buttonSubjectLibraryPage;
        private System.Windows.Forms.Panel panelMainField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonBillHistory;
    }
}
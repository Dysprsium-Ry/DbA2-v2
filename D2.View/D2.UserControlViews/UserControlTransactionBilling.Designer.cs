namespace _3_13_25.D2.View.D2.UserControlViews
{
    partial class UserControlTransactionBilling
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
            this.dataGridViewBillingList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelBookDate = new System.Windows.Forms.Label();
            this.labelTransactionIdInfo = new System.Windows.Forms.Label();
            this.labelNameInfo = new System.Windows.Forms.Label();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.labelBookDateInfo = new System.Windows.Forms.Label();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelPayAmount = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.numericUpDownPayAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillingList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBillingList
            // 
            this.dataGridViewBillingList.AllowUserToAddRows = false;
            this.dataGridViewBillingList.AllowUserToDeleteRows = false;
            this.dataGridViewBillingList.AllowUserToResizeColumns = false;
            this.dataGridViewBillingList.AllowUserToResizeRows = false;
            this.dataGridViewBillingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillingList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBillingList.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillingList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBillingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBillingList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewBillingList.Location = new System.Drawing.Point(21, 20);
            this.dataGridViewBillingList.MultiSelect = false;
            this.dataGridViewBillingList.Name = "dataGridViewBillingList";
            this.dataGridViewBillingList.ReadOnly = true;
            this.dataGridViewBillingList.RowHeadersVisible = false;
            this.dataGridViewBillingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillingList.Size = new System.Drawing.Size(436, 517);
            this.dataGridViewBillingList.TabIndex = 0;
            this.dataGridViewBillingList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillingList_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.labelBookDateInfo);
            this.panel1.Controls.Add(this.labelStatusInfo);
            this.panel1.Controls.Add(this.labelNameInfo);
            this.panel1.Controls.Add(this.labelTransactionIdInfo);
            this.panel1.Controls.Add(this.labelBookDate);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Controls.Add(this.labelTransactionId);
            this.panel1.Location = new System.Drawing.Point(480, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 267);
            this.panel1.TabIndex = 1;
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.AutoSize = true;
            this.labelTransactionId.Location = new System.Drawing.Point(30, 44);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(113, 21);
            this.labelTransactionId.TabIndex = 0;
            this.labelTransactionId.Text = "Transaction Id :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(84, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(84, 138);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(59, 21);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status :";
            // 
            // labelBookDate
            // 
            this.labelBookDate.AutoSize = true;
            this.labelBookDate.Location = new System.Drawing.Point(55, 185);
            this.labelBookDate.Name = "labelBookDate";
            this.labelBookDate.Size = new System.Drawing.Size(88, 21);
            this.labelBookDate.TabIndex = 3;
            this.labelBookDate.Text = "Book Date :";
            // 
            // labelTransactionIdInfo
            // 
            this.labelTransactionIdInfo.AutoSize = true;
            this.labelTransactionIdInfo.BackColor = System.Drawing.Color.Gray;
            this.labelTransactionIdInfo.ForeColor = System.Drawing.Color.White;
            this.labelTransactionIdInfo.Location = new System.Drawing.Point(159, 44);
            this.labelTransactionIdInfo.Name = "labelTransactionIdInfo";
            this.labelTransactionIdInfo.Size = new System.Drawing.Size(102, 21);
            this.labelTransactionIdInfo.TabIndex = 4;
            this.labelTransactionIdInfo.Text = "TransactionId";
            // 
            // labelNameInfo
            // 
            this.labelNameInfo.AutoSize = true;
            this.labelNameInfo.BackColor = System.Drawing.Color.Gray;
            this.labelNameInfo.ForeColor = System.Drawing.Color.White;
            this.labelNameInfo.Location = new System.Drawing.Point(159, 91);
            this.labelNameInfo.Name = "labelNameInfo";
            this.labelNameInfo.Size = new System.Drawing.Size(52, 21);
            this.labelNameInfo.TabIndex = 5;
            this.labelNameInfo.Text = "Name";
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.BackColor = System.Drawing.Color.Gray;
            this.labelStatusInfo.ForeColor = System.Drawing.Color.White;
            this.labelStatusInfo.Location = new System.Drawing.Point(159, 138);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(52, 21);
            this.labelStatusInfo.TabIndex = 6;
            this.labelStatusInfo.Text = "Status";
            // 
            // labelBookDateInfo
            // 
            this.labelBookDateInfo.AutoSize = true;
            this.labelBookDateInfo.BackColor = System.Drawing.Color.Gray;
            this.labelBookDateInfo.ForeColor = System.Drawing.Color.White;
            this.labelBookDateInfo.Location = new System.Drawing.Point(159, 185);
            this.labelBookDateInfo.Name = "labelBookDateInfo";
            this.labelBookDateInfo.Size = new System.Drawing.Size(81, 21);
            this.labelBookDateInfo.TabIndex = 7;
            this.labelBookDateInfo.Text = "Book Date";
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Location = new System.Drawing.Point(500, 344);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(77, 21);
            this.labelTotalFee.TabIndex = 3;
            this.labelTotalFee.Text = "Total Fee :";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(587, 341);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(268, 29);
            this.textBoxTotal.TabIndex = 4;
            // 
            // labelPayAmount
            // 
            this.labelPayAmount.AutoSize = true;
            this.labelPayAmount.Location = new System.Drawing.Point(476, 404);
            this.labelPayAmount.Name = "labelPayAmount";
            this.labelPayAmount.Size = new System.Drawing.Size(101, 21);
            this.labelPayAmount.TabIndex = 5;
            this.labelPayAmount.Text = "Pay Amount :";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(720, 501);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(135, 36);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // numericUpDownPayAmount
            // 
            this.numericUpDownPayAmount.DecimalPlaces = 2;
            this.numericUpDownPayAmount.Location = new System.Drawing.Point(587, 402);
            this.numericUpDownPayAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDownPayAmount.Name = "numericUpDownPayAmount";
            this.numericUpDownPayAmount.Size = new System.Drawing.Size(268, 29);
            this.numericUpDownPayAmount.TabIndex = 2;
            this.numericUpDownPayAmount.ThousandsSeparator = true;
            // 
            // UserControlTransactionBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelPayAmount);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotalFee);
            this.Controls.Add(this.numericUpDownPayAmount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewBillingList);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlTransactionBilling";
            this.Size = new System.Drawing.Size(882, 568);
            this.Load += new System.EventHandler(this.UserControlTransactionBilling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillingList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPayAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBillingList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBookDate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.Label labelNameInfo;
        private System.Windows.Forms.Label labelTransactionIdInfo;
        private System.Windows.Forms.Label labelBookDateInfo;
        private System.Windows.Forms.Label labelStatusInfo;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelPayAmount;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.NumericUpDown numericUpDownPayAmount;
    }
}

﻿namespace _3_13_25.D2.View.D2.UserControlViews
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
            this.labelBookDateInfo = new System.Windows.Forms.Label();
            this.labelStatusInfo = new System.Windows.Forms.Label();
            this.labelNameInfo = new System.Windows.Forms.Label();
            this.labelTransactionIdInfo = new System.Windows.Forms.Label();
            this.labelBookDate = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelPayAmount = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxTotalAmountPaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericTextBoxPayAmount = new _3_13_25.D2._0_Misc.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillingList)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dataGridViewBillingList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillingList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBillingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBillingList.EnableHeadersVisualStyles = false;
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
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
            // labelBookDateInfo
            // 
            this.labelBookDateInfo.AutoSize = true;
            this.labelBookDateInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelBookDateInfo.ForeColor = System.Drawing.Color.White;
            this.labelBookDateInfo.Location = new System.Drawing.Point(159, 185);
            this.labelBookDateInfo.Name = "labelBookDateInfo";
            this.labelBookDateInfo.Size = new System.Drawing.Size(81, 21);
            this.labelBookDateInfo.TabIndex = 7;
            this.labelBookDateInfo.Text = "Book Date";
            // 
            // labelStatusInfo
            // 
            this.labelStatusInfo.AutoSize = true;
            this.labelStatusInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelStatusInfo.ForeColor = System.Drawing.Color.White;
            this.labelStatusInfo.Location = new System.Drawing.Point(159, 138);
            this.labelStatusInfo.Name = "labelStatusInfo";
            this.labelStatusInfo.Size = new System.Drawing.Size(52, 21);
            this.labelStatusInfo.TabIndex = 6;
            this.labelStatusInfo.Text = "Status";
            // 
            // labelNameInfo
            // 
            this.labelNameInfo.AutoSize = true;
            this.labelNameInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelNameInfo.ForeColor = System.Drawing.Color.White;
            this.labelNameInfo.Location = new System.Drawing.Point(159, 91);
            this.labelNameInfo.Name = "labelNameInfo";
            this.labelNameInfo.Size = new System.Drawing.Size(52, 21);
            this.labelNameInfo.TabIndex = 5;
            this.labelNameInfo.Text = "Name";
            // 
            // labelTransactionIdInfo
            // 
            this.labelTransactionIdInfo.AutoSize = true;
            this.labelTransactionIdInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelTransactionIdInfo.ForeColor = System.Drawing.Color.White;
            this.labelTransactionIdInfo.Location = new System.Drawing.Point(159, 44);
            this.labelTransactionIdInfo.Name = "labelTransactionIdInfo";
            this.labelTransactionIdInfo.Size = new System.Drawing.Size(102, 21);
            this.labelTransactionIdInfo.TabIndex = 4;
            this.labelTransactionIdInfo.Text = "TransactionId";
            // 
            // labelBookDate
            // 
            this.labelBookDate.AutoSize = true;
            this.labelBookDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelBookDate.Location = new System.Drawing.Point(55, 185);
            this.labelBookDate.Name = "labelBookDate";
            this.labelBookDate.Size = new System.Drawing.Size(88, 21);
            this.labelBookDate.TabIndex = 3;
            this.labelBookDate.Text = "Book Date :";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelStatus.Location = new System.Drawing.Point(84, 138);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(59, 21);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelName.Location = new System.Drawing.Point(84, 91);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name :";
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.AutoSize = true;
            this.labelTransactionId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelTransactionId.Location = new System.Drawing.Point(30, 44);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(113, 21);
            this.labelTransactionId.TabIndex = 0;
            this.labelTransactionId.Text = "Transaction Id :";
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Location = new System.Drawing.Point(546, 344);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(77, 21);
            this.labelTotalFee.TabIndex = 3;
            this.labelTotalFee.Text = "Total Fee :";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxTotal.Location = new System.Drawing.Point(629, 341);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(207, 29);
            this.textBoxTotal.TabIndex = 4;
            // 
            // labelPayAmount
            // 
            this.labelPayAmount.AutoSize = true;
            this.labelPayAmount.Location = new System.Drawing.Point(522, 378);
            this.labelPayAmount.Name = "labelPayAmount";
            this.labelPayAmount.Size = new System.Drawing.Size(101, 21);
            this.labelPayAmount.TabIndex = 5;
            this.labelPayAmount.Text = "Pay Amount :";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonPay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(61)))), ((int)(((byte)(81)))));
            this.buttonPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPay.ForeColor = System.Drawing.Color.White;
            this.buttonPay.Location = new System.Drawing.Point(720, 501);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(135, 36);
            this.buttonPay.TabIndex = 6;
            this.buttonPay.Text = "Pay";
            this.buttonPay.UseVisualStyleBackColor = false;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxTotalAmountPaid
            // 
            this.textBoxTotalAmountPaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.textBoxTotalAmountPaid.Enabled = false;
            this.textBoxTotalAmountPaid.Location = new System.Drawing.Point(629, 411);
            this.textBoxTotalAmountPaid.Name = "textBoxTotalAmountPaid";
            this.textBoxTotalAmountPaid.ReadOnly = true;
            this.textBoxTotalAmountPaid.Size = new System.Drawing.Size(207, 29);
            this.textBoxTotalAmountPaid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total Amount Paid :";
            // 
            // numericTextBoxPayAmount
            // 
            this.numericTextBoxPayAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.numericTextBoxPayAmount.Location = new System.Drawing.Point(629, 375);
            this.numericTextBoxPayAmount.Name = "numericTextBoxPayAmount";
            this.numericTextBoxPayAmount.NumericValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.numericTextBoxPayAmount.Size = new System.Drawing.Size(207, 29);
            this.numericTextBoxPayAmount.TabIndex = 10;
            this.numericTextBoxPayAmount.Text = "0.00";
            this.numericTextBoxPayAmount.TextChanged += new System.EventHandler(this.numericTextBoxPayAmount_TextChanged);
            // 
            // UserControlTransactionBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.numericTextBoxPayAmount);
            this.Controls.Add(this.textBoxTotalAmountPaid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.labelPayAmount);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotalFee);
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
        private System.Windows.Forms.TextBox textBoxTotalAmountPaid;
        private System.Windows.Forms.Label label1;
        private _0_Misc.NumericTextBox numericTextBoxPayAmount;
    }
}

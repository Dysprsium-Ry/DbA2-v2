namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    partial class UserControlBillHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewBillHistory = new System.Windows.Forms.DataGridView();
            this.labelTransactionId = new System.Windows.Forms.Label();
            this.numericUpDownTransactionId = new System.Windows.Forms.NumericUpDown();
            this.buttonSearchHistory = new System.Windows.Forms.Button();
            this.billingHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transactionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBillHistory
            // 
            this.dataGridViewBillHistory.AllowUserToAddRows = false;
            this.dataGridViewBillHistory.AllowUserToDeleteRows = false;
            this.dataGridViewBillHistory.AutoGenerateColumns = false;
            this.dataGridViewBillHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBillHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewBillHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBillHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBillHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBillHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionId,
            this.totalValue,
            this.amount,
            this.transactionDate});
            this.dataGridViewBillHistory.DataSource = this.billingHistoryBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBillHistory.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBillHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewBillHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewBillHistory.Location = new System.Drawing.Point(9, 65);
            this.dataGridViewBillHistory.Name = "dataGridViewBillHistory";
            this.dataGridViewBillHistory.ReadOnly = true;
            this.dataGridViewBillHistory.RowHeadersVisible = false;
            this.dataGridViewBillHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBillHistory.Size = new System.Drawing.Size(828, 409);
            this.dataGridViewBillHistory.TabIndex = 0;
            this.dataGridViewBillHistory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBillHistory_CellDoubleClick);
            // 
            // labelTransactionId
            // 
            this.labelTransactionId.AutoSize = true;
            this.labelTransactionId.Location = new System.Drawing.Point(13, 28);
            this.labelTransactionId.Name = "labelTransactionId";
            this.labelTransactionId.Size = new System.Drawing.Size(113, 21);
            this.labelTransactionId.TabIndex = 1;
            this.labelTransactionId.Text = "Transaction Id :";
            // 
            // numericUpDownTransactionId
            // 
            this.numericUpDownTransactionId.Location = new System.Drawing.Point(132, 26);
            this.numericUpDownTransactionId.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownTransactionId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTransactionId.Name = "numericUpDownTransactionId";
            this.numericUpDownTransactionId.Size = new System.Drawing.Size(186, 29);
            this.numericUpDownTransactionId.TabIndex = 2;
            this.numericUpDownTransactionId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSearchHistory
            // 
            this.buttonSearchHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.buttonSearchHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchHistory.ForeColor = System.Drawing.Color.White;
            this.buttonSearchHistory.Location = new System.Drawing.Point(324, 26);
            this.buttonSearchHistory.Name = "buttonSearchHistory";
            this.buttonSearchHistory.Size = new System.Drawing.Size(89, 29);
            this.buttonSearchHistory.TabIndex = 3;
            this.buttonSearchHistory.Text = "Search";
            this.buttonSearchHistory.UseVisualStyleBackColor = false;
            this.buttonSearchHistory.Click += new System.EventHandler(this.buttonSearchHistory_Click);
            // 
            // billingHistoryBindingSource
            // 
            this.billingHistoryBindingSource.DataSource = typeof(_3_13_25.D2.DataModels.BillingHistory);
            // 
            // transactionId
            // 
            this.transactionId.DataPropertyName = "TransactionId";
            this.transactionId.HeaderText = "Transaction Id";
            this.transactionId.Name = "transactionId";
            this.transactionId.ReadOnly = true;
            // 
            // totalValue
            // 
            this.totalValue.DataPropertyName = "TotalValue";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.totalValue.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalValue.HeaderText = "Total Value";
            this.totalValue.Name = "totalValue";
            this.totalValue.ReadOnly = true;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "0";
            this.amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.amount.HeaderText = "Amount";
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // transactionDate
            // 
            this.transactionDate.DataPropertyName = "TransactionDate";
            this.transactionDate.HeaderText = "Transaction Date";
            this.transactionDate.Name = "transactionDate";
            this.transactionDate.ReadOnly = true;
            // 
            // UserControlBillHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.Controls.Add(this.buttonSearchHistory);
            this.Controls.Add(this.numericUpDownTransactionId);
            this.Controls.Add(this.labelTransactionId);
            this.Controls.Add(this.dataGridViewBillHistory);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlBillHistory";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.Size = new System.Drawing.Size(846, 483);
            this.Load += new System.EventHandler(this.UserControlBillHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBillHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTransactionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBillHistory;
        private System.Windows.Forms.BindingSource billingHistoryBindingSource;
        private System.Windows.Forms.Label labelTransactionId;
        private System.Windows.Forms.NumericUpDown numericUpDownTransactionId;
        private System.Windows.Forms.Button buttonSearchHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDate;
    }
}

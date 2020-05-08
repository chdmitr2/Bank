namespace Bank
{
    partial class NewCredit
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
            this.gpbxDebitorDetails = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpCreditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.ltbxDebitorName = new System.Windows.Forms.ListBox();
            this.ltbxDebitorId = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbxCreditBalance = new System.Windows.Forms.TextBox();
            this.btnSaveNewCredit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxCreditAmount = new System.Windows.Forms.TextBox();
            this.txbxCreditId = new System.Windows.Forms.TextBox();
            this.gpbxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDebitorDetails
            // 
            this.gpbxDebitorDetails.Controls.Add(this.label3);
            this.gpbxDebitorDetails.Controls.Add(this.dtpCreditOpenDate);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxDebitorName);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxDebitorId);
            this.gpbxDebitorDetails.Controls.Add(this.label5);
            this.gpbxDebitorDetails.Controls.Add(this.txbxCreditBalance);
            this.gpbxDebitorDetails.Controls.Add(this.btnSaveNewCredit);
            this.gpbxDebitorDetails.Controls.Add(this.label4);
            this.gpbxDebitorDetails.Controls.Add(this.label2);
            this.gpbxDebitorDetails.Controls.Add(this.label1);
            this.gpbxDebitorDetails.Controls.Add(this.txbxCreditAmount);
            this.gpbxDebitorDetails.Controls.Add(this.txbxCreditId);
            this.gpbxDebitorDetails.Location = new System.Drawing.Point(2, 3);
            this.gpbxDebitorDetails.Name = "gpbxDebitorDetails";
            this.gpbxDebitorDetails.Size = new System.Drawing.Size(563, 278);
            this.gpbxDebitorDetails.TabIndex = 3;
            this.gpbxDebitorDetails.TabStop = false;
            this.gpbxDebitorDetails.Text = "Debitor details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
           
            // 
            // dtpCreditOpenDate
            // 
            this.dtpCreditOpenDate.Location = new System.Drawing.Point(109, 203);
            this.dtpCreditOpenDate.Name = "dtpCreditOpenDate";
            this.dtpCreditOpenDate.Size = new System.Drawing.Size(259, 20);
            this.dtpCreditOpenDate.TabIndex = 13;
            // 
            // ltbxDebitorName
            // 
            this.ltbxDebitorName.FormattingEnabled = true;
            this.ltbxDebitorName.Location = new System.Drawing.Point(334, 53);
            this.ltbxDebitorName.Name = "ltbxDebitorName";
            this.ltbxDebitorName.Size = new System.Drawing.Size(218, 82);
            this.ltbxDebitorName.TabIndex = 12;
            // 
            // ltbxDebitorId
            // 
            this.ltbxDebitorId.FormattingEnabled = true;
            this.ltbxDebitorId.Location = new System.Drawing.Point(109, 53);
            this.ltbxDebitorId.Name = "ltbxDebitorId";
            this.ltbxDebitorId.Size = new System.Drawing.Size(210, 82);
            this.ltbxDebitorId.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Credit Balance";
            // 
            // txbxCreditBalance
            // 
            this.txbxCreditBalance.BackColor = System.Drawing.SystemColors.Info;
            this.txbxCreditBalance.Location = new System.Drawing.Point(109, 177);
            this.txbxCreditBalance.Name = "txbxCreditBalance";
            this.txbxCreditBalance.ReadOnly = true;
            this.txbxCreditBalance.Size = new System.Drawing.Size(443, 20);
            this.txbxCreditBalance.TabIndex = 9;
            // 
            // btnSaveNewCredit
            // 
            this.btnSaveNewCredit.Location = new System.Drawing.Point(17, 238);
            this.btnSaveNewCredit.Name = "btnSaveNewCredit";
            this.btnSaveNewCredit.Size = new System.Drawing.Size(546, 23);
            this.btnSaveNewCredit.TabIndex = 8;
            this.btnSaveNewCredit.Text = "Open New Credit";
            this.btnSaveNewCredit.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Credit Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Credit ID";
            // 
            // txbxCreditAmount
            // 
            this.txbxCreditAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txbxCreditAmount.Location = new System.Drawing.Point(109, 151);
            this.txbxCreditAmount.Name = "txbxCreditAmount";
            this.txbxCreditAmount.Size = new System.Drawing.Size(443, 20);
            this.txbxCreditAmount.TabIndex = 3;
            // 
            // txbxCreditId
            // 
            this.txbxCreditId.BackColor = System.Drawing.SystemColors.Info;
            this.txbxCreditId.Location = new System.Drawing.Point(109, 20);
            this.txbxCreditId.Name = "txbxCreditId";
            this.txbxCreditId.ReadOnly = true;
            this.txbxCreditId.Size = new System.Drawing.Size(443, 20);
            this.txbxCreditId.TabIndex = 0;
            // 
            // NewCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 284);
            this.Controls.Add(this.gpbxDebitorDetails);
            this.Name = "NewCredit";
            this.Text = "NewCredit";
          
            this.gpbxDebitorDetails.ResumeLayout(false);
            this.gpbxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDebitorDetails;
        private System.Windows.Forms.Button btnSaveNewCredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxCreditId;
        private System.Windows.Forms.ListBox ltbxDebitorName;
        private System.Windows.Forms.ListBox ltbxDebitorId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbxCreditBalance;
        private System.Windows.Forms.TextBox txbxCreditAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpCreditOpenDate;
    }
}
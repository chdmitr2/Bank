namespace Bank
{
    partial class NewPayment
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.ltbxCreditBalance = new System.Windows.Forms.ListBox();
            this.ltbxCreditAmount = new System.Windows.Forms.ListBox();
            this.ltbxCreditId = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMessageCreditAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpPaymentPassDate = new System.Windows.Forms.DateTimePicker();
            this.ltbxDebitorName = new System.Windows.Forms.ListBox();
            this.ltbxDebitorId = new System.Windows.Forms.ListBox();
            this.btnSaveNewPayment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxPaymentAmount = new System.Windows.Forms.TextBox();
            this.txbxPaymentId = new System.Windows.Forms.TextBox();
            this.gpbxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDebitorDetails
            // 
            this.gpbxDebitorDetails.Controls.Add(this.btnRefresh);
            this.gpbxDebitorDetails.Controls.Add(this.lblMessage);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxCreditBalance);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxCreditAmount);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxCreditId);
            this.gpbxDebitorDetails.Controls.Add(this.label6);
            this.gpbxDebitorDetails.Controls.Add(this.lblMessageCreditAmount);
            this.gpbxDebitorDetails.Controls.Add(this.label3);
            this.gpbxDebitorDetails.Controls.Add(this.dtpPaymentPassDate);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxDebitorName);
            this.gpbxDebitorDetails.Controls.Add(this.ltbxDebitorId);
            this.gpbxDebitorDetails.Controls.Add(this.btnSaveNewPayment);
            this.gpbxDebitorDetails.Controls.Add(this.label4);
            this.gpbxDebitorDetails.Controls.Add(this.label2);
            this.gpbxDebitorDetails.Controls.Add(this.label1);
            this.gpbxDebitorDetails.Controls.Add(this.txbxPaymentAmount);
            this.gpbxDebitorDetails.Controls.Add(this.txbxPaymentId);
            this.gpbxDebitorDetails.Location = new System.Drawing.Point(12, 12);
            this.gpbxDebitorDetails.Name = "gpbxDebitorDetails";
            this.gpbxDebitorDetails.Size = new System.Drawing.Size(563, 351);
            this.gpbxDebitorDetails.TabIndex = 4;
            this.gpbxDebitorDetails.TabStop = false;
            this.gpbxDebitorDetails.Text = "Debitor details";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(374, 247);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 21;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(464, 252);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 20;
            // 
            // ltbxCreditBalance
            // 
            this.ltbxCreditBalance.DisplayMember = "Balance";
            this.ltbxCreditBalance.FormattingEnabled = true;
            this.ltbxCreditBalance.Location = new System.Drawing.Point(417, 150);
            this.ltbxCreditBalance.Name = "ltbxCreditBalance";
            this.ltbxCreditBalance.Size = new System.Drawing.Size(140, 82);
            this.ltbxCreditBalance.TabIndex = 19;
            this.ltbxCreditBalance.ValueMember = "Balance";
            // 
            // ltbxCreditAmount
            // 
            this.ltbxCreditAmount.DisplayMember = "Amount";
            this.ltbxCreditAmount.FormattingEnabled = true;
            this.ltbxCreditAmount.Location = new System.Drawing.Point(260, 150);
            this.ltbxCreditAmount.Name = "ltbxCreditAmount";
            this.ltbxCreditAmount.Size = new System.Drawing.Size(140, 82);
            this.ltbxCreditAmount.TabIndex = 18;
            this.ltbxCreditAmount.ValueMember = "ID";
            // 
            // ltbxCreditId
            // 
            this.ltbxCreditId.DisplayMember = "ID";
            this.ltbxCreditId.FormattingEnabled = true;
            this.ltbxCreditId.Location = new System.Drawing.Point(109, 150);
            this.ltbxCreditId.Name = "ltbxCreditId";
            this.ltbxCreditId.Size = new System.Drawing.Size(132, 82);
            this.ltbxCreditId.TabIndex = 17;
            this.ltbxCreditId.ValueMember = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Credit";
            // 
            // lblMessageCreditAmount
            // 
            this.lblMessageCreditAmount.AutoSize = true;
            this.lblMessageCreditAmount.Location = new System.Drawing.Point(385, 267);
            this.lblMessageCreditAmount.Name = "lblMessageCreditAmount";
            this.lblMessageCreditAmount.Size = new System.Drawing.Size(0, 13);
            this.lblMessageCreditAmount.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date";
            // 
            // dtpPaymentPassDate
            // 
            this.dtpPaymentPassDate.Location = new System.Drawing.Point(109, 286);
            this.dtpPaymentPassDate.Name = "dtpPaymentPassDate";
            this.dtpPaymentPassDate.Size = new System.Drawing.Size(259, 20);
            this.dtpPaymentPassDate.TabIndex = 13;
            // 
            // ltbxDebitorName
            // 
            this.ltbxDebitorName.DisplayMember = "Name";
            this.ltbxDebitorName.FormattingEnabled = true;
            this.ltbxDebitorName.Location = new System.Drawing.Point(334, 53);
            this.ltbxDebitorName.Name = "ltbxDebitorName";
            this.ltbxDebitorName.Size = new System.Drawing.Size(218, 82);
            this.ltbxDebitorName.TabIndex = 12;
            this.ltbxDebitorName.ValueMember = "ID";
            this.ltbxDebitorName.SelectedIndexChanged += new System.EventHandler(this.ltbxDebitor_SelectedIndexChanged);
            // 
            // ltbxDebitorId
            // 
            this.ltbxDebitorId.DisplayMember = "ID";
            this.ltbxDebitorId.FormattingEnabled = true;
            this.ltbxDebitorId.Location = new System.Drawing.Point(109, 53);
            this.ltbxDebitorId.Name = "ltbxDebitorId";
            this.ltbxDebitorId.Size = new System.Drawing.Size(210, 82);
            this.ltbxDebitorId.TabIndex = 11;
            this.ltbxDebitorId.ValueMember = "ID";
            this.ltbxDebitorId.SelectedIndexChanged += new System.EventHandler(this.ltbxDebitor_SelectedIndexChanged);
            // 
            // btnSaveNewPayment
            // 
            this.btnSaveNewPayment.Location = new System.Drawing.Point(17, 325);
            this.btnSaveNewPayment.Name = "btnSaveNewPayment";
            this.btnSaveNewPayment.Size = new System.Drawing.Size(546, 23);
            this.btnSaveNewPayment.TabIndex = 8;
            this.btnSaveNewPayment.Text = "Pass New Payment";
            this.btnSaveNewPayment.UseVisualStyleBackColor = true;
            this.btnSaveNewPayment.Click += new System.EventHandler(this.btnSaveNewPayment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Payment Amount";
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
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Payment ID";
            // 
            // txbxPaymentAmount
            // 
            this.txbxPaymentAmount.BackColor = System.Drawing.SystemColors.Info;
            this.txbxPaymentAmount.Location = new System.Drawing.Point(109, 249);
            this.txbxPaymentAmount.MaxLength = 12;
            this.txbxPaymentAmount.Name = "txbxPaymentAmount";
            this.txbxPaymentAmount.Size = new System.Drawing.Size(259, 20);
            this.txbxPaymentAmount.TabIndex = 3;
            this.txbxPaymentAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbxPaymentAmount_KeyPress);
            this.txbxPaymentAmount.Leave += new System.EventHandler(this.txbxPaymentAmount_Leave);
            // 
            // txbxPaymentId
            // 
            this.txbxPaymentId.BackColor = System.Drawing.SystemColors.Info;
            this.txbxPaymentId.Location = new System.Drawing.Point(109, 20);
            this.txbxPaymentId.Name = "txbxPaymentId";
            this.txbxPaymentId.ReadOnly = true;
            this.txbxPaymentId.Size = new System.Drawing.Size(443, 20);
            this.txbxPaymentId.TabIndex = 0;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 375);
            this.Controls.Add(this.gpbxDebitorDetails);
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.gpbxDebitorDetails.ResumeLayout(false);
            this.gpbxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDebitorDetails;
        private System.Windows.Forms.Label lblMessageCreditAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpPaymentPassDate;
        private System.Windows.Forms.ListBox ltbxDebitorName;
        private System.Windows.Forms.ListBox ltbxDebitorId;
        private System.Windows.Forms.Button btnSaveNewPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxPaymentAmount;
        private System.Windows.Forms.TextBox txbxPaymentId;
        private System.Windows.Forms.ListBox ltbxCreditBalance;
        private System.Windows.Forms.ListBox ltbxCreditAmount;
        private System.Windows.Forms.ListBox ltbxCreditId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnRefresh;
    }
}
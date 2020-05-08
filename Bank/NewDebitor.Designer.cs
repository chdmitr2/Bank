namespace Bank
{
    partial class NewDebitor
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbxDebitorPostNumber = new System.Windows.Forms.TextBox();
            this.txbxDebitorName = new System.Windows.Forms.TextBox();
            this.txbxDebitorId = new System.Windows.Forms.TextBox();
            this.btnSaveNewDebitor = new System.Windows.Forms.Button();
            this.gpbxDebitorDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDebitorDetails
            // 
            this.gpbxDebitorDetails.Controls.Add(this.btnSaveNewDebitor);
            this.gpbxDebitorDetails.Controls.Add(this.label4);
            this.gpbxDebitorDetails.Controls.Add(this.label3);
            this.gpbxDebitorDetails.Controls.Add(this.label2);
            this.gpbxDebitorDetails.Controls.Add(this.label1);
            this.gpbxDebitorDetails.Controls.Add(this.txbxPhoneNumber);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorPostNumber);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorName);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorId);
            this.gpbxDebitorDetails.Location = new System.Drawing.Point(12, 12);
            this.gpbxDebitorDetails.Name = "gpbxDebitorDetails";
            this.gpbxDebitorDetails.Size = new System.Drawing.Size(563, 179);
            this.gpbxDebitorDetails.TabIndex = 2;
            this.gpbxDebitorDetails.TabStop = false;
            this.gpbxDebitorDetails.Text = "Debitor details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Debitor Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Debitor Post Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Debitor Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Debitor ID";
            // 
            // txbxPhoneNumber
            // 
            this.txbxPhoneNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbxPhoneNumber.Location = new System.Drawing.Point(168, 98);
            this.txbxPhoneNumber.Name = "txbxPhoneNumber";
            this.txbxPhoneNumber.Size = new System.Drawing.Size(384, 20);
            this.txbxPhoneNumber.TabIndex = 3;
            // 
            // txbxDebitorPostNumber
            // 
            this.txbxDebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbxDebitorPostNumber.Location = new System.Drawing.Point(168, 72);
            this.txbxDebitorPostNumber.Name = "txbxDebitorPostNumber";
            this.txbxDebitorPostNumber.Size = new System.Drawing.Size(384, 20);
            this.txbxDebitorPostNumber.TabIndex = 2;
            // 
            // txbxDebitorName
            // 
            this.txbxDebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txbxDebitorName.Location = new System.Drawing.Point(168, 46);
            this.txbxDebitorName.Name = "txbxDebitorName";
            this.txbxDebitorName.Size = new System.Drawing.Size(384, 20);
            this.txbxDebitorName.TabIndex = 1;
            // 
            // txbxDebitorId
            // 
            this.txbxDebitorId.BackColor = System.Drawing.SystemColors.Info;
            this.txbxDebitorId.Location = new System.Drawing.Point(168, 20);
            this.txbxDebitorId.Name = "txbxDebitorId";
            this.txbxDebitorId.ReadOnly = true;
            this.txbxDebitorId.Size = new System.Drawing.Size(384, 20);
            this.txbxDebitorId.TabIndex = 0;
            // 
            // btnSaveNewDebitor
            // 
            this.btnSaveNewDebitor.Location = new System.Drawing.Point(6, 143);
            this.btnSaveNewDebitor.Name = "btnSaveNewDebitor";
            this.btnSaveNewDebitor.Size = new System.Drawing.Size(546, 23);
            this.btnSaveNewDebitor.TabIndex = 8;
            this.btnSaveNewDebitor.Text = "Save New Debitor";
            this.btnSaveNewDebitor.UseVisualStyleBackColor = true;
            this.btnSaveNewDebitor.Click += new System.EventHandler(this.btnSaveNewDebitor_Click);
            // 
            // NewDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 202);
            this.Controls.Add(this.gpbxDebitorDetails);
            this.Name = "NewDebitor";
            this.Text = "NewDebitor";
            this.gpbxDebitorDetails.ResumeLayout(false);
            this.gpbxDebitorDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDebitorDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxPhoneNumber;
        private System.Windows.Forms.TextBox txbxDebitorPostNumber;
        private System.Windows.Forms.TextBox txbxDebitorName;
        private System.Windows.Forms.TextBox txbxDebitorId;
        private System.Windows.Forms.Button btnSaveNewDebitor;
    }
}
﻿namespace Bank
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
            this.gpbxDebitors = new System.Windows.Forms.GroupBox();
            this.dgvDebitors = new System.Windows.Forms.DataGridView();
            this.gpbxDebitorDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.txbxDebitorPostNumber = new System.Windows.Forms.TextBox();
            this.txbxDebitorName = new System.Windows.Forms.TextBox();
            this.txbxDebitorId = new System.Windows.Forms.TextBox();
            this.gpbxCredits = new System.Windows.Forms.GroupBox();
            this.dgvCredits = new System.Windows.Forms.DataGridView();
            this.gpbxPayments = new System.Windows.Forms.GroupBox();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.grbxSearch = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbxDebitors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).BeginInit();
            this.gpbxDebitorDetails.SuspendLayout();
            this.gpbxCredits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).BeginInit();
            this.gpbxPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxDebitors
            // 
            this.gpbxDebitors.Controls.Add(this.dgvDebitors);
            this.gpbxDebitors.Location = new System.Drawing.Point(28, 156);
            this.gpbxDebitors.Name = "gpbxDebitors";
            this.gpbxDebitors.Size = new System.Drawing.Size(390, 137);
            this.gpbxDebitors.TabIndex = 0;
            this.gpbxDebitors.TabStop = false;
            this.gpbxDebitors.Text = "Debitors";
            // 
            // dgvDebitors
            // 
            this.dgvDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebitors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDebitors.Location = new System.Drawing.Point(3, 16);
            this.dgvDebitors.Name = "dgvDebitors";
            this.dgvDebitors.Size = new System.Drawing.Size(384, 118);
            this.dgvDebitors.TabIndex = 0;
            this.dgvDebitors.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitors_CellEnter);
            // 
            // gpbxDebitorDetails
            // 
            this.gpbxDebitorDetails.Controls.Add(this.label4);
            this.gpbxDebitorDetails.Controls.Add(this.label3);
            this.gpbxDebitorDetails.Controls.Add(this.label2);
            this.gpbxDebitorDetails.Controls.Add(this.label1);
            this.gpbxDebitorDetails.Controls.Add(this.txbxPhoneNumber);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorPostNumber);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorName);
            this.gpbxDebitorDetails.Controls.Add(this.txbxDebitorId);
            this.gpbxDebitorDetails.Location = new System.Drawing.Point(433, 156);
            this.gpbxDebitorDetails.Name = "gpbxDebitorDetails";
            this.gpbxDebitorDetails.Size = new System.Drawing.Size(558, 137);
            this.gpbxDebitorDetails.TabIndex = 1;
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
            this.txbxPhoneNumber.ReadOnly = true;
            this.txbxPhoneNumber.Size = new System.Drawing.Size(384, 20);
            this.txbxPhoneNumber.TabIndex = 3;
            // 
            // txbxDebitorPostNumber
            // 
            this.txbxDebitorPostNumber.BackColor = System.Drawing.SystemColors.Info;
            this.txbxDebitorPostNumber.Location = new System.Drawing.Point(168, 72);
            this.txbxDebitorPostNumber.Name = "txbxDebitorPostNumber";
            this.txbxDebitorPostNumber.ReadOnly = true;
            this.txbxDebitorPostNumber.Size = new System.Drawing.Size(384, 20);
            this.txbxDebitorPostNumber.TabIndex = 2;
            // 
            // txbxDebitorName
            // 
            this.txbxDebitorName.BackColor = System.Drawing.SystemColors.Info;
            this.txbxDebitorName.Location = new System.Drawing.Point(168, 46);
            this.txbxDebitorName.Name = "txbxDebitorName";
            this.txbxDebitorName.ReadOnly = true;
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
            // gpbxCredits
            // 
            this.gpbxCredits.Controls.Add(this.dgvCredits);
            this.gpbxCredits.Location = new System.Drawing.Point(28, 298);
            this.gpbxCredits.Name = "gpbxCredits";
            this.gpbxCredits.Size = new System.Drawing.Size(963, 155);
            this.gpbxCredits.TabIndex = 2;
            this.gpbxCredits.TabStop = false;
            this.gpbxCredits.Text = "Credits";
            // 
            // dgvCredits
            // 
            this.dgvCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredits.Location = new System.Drawing.Point(3, 16);
            this.dgvCredits.Name = "dgvCredits";
            this.dgvCredits.Size = new System.Drawing.Size(957, 136);
            this.dgvCredits.TabIndex = 1;
            // 
            // gpbxPayments
            // 
            this.gpbxPayments.Controls.Add(this.dgvPayments);
            this.gpbxPayments.Location = new System.Drawing.Point(28, 459);
            this.gpbxPayments.Name = "gpbxPayments";
            this.gpbxPayments.Size = new System.Drawing.Size(963, 156);
            this.gpbxPayments.TabIndex = 3;
            this.gpbxPayments.TabStop = false;
            this.gpbxPayments.Text = "Payments";
            // 
            // dgvPayments
            // 
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPayments.Location = new System.Drawing.Point(3, 16);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.Size = new System.Drawing.Size(957, 137);
            this.dgvPayments.TabIndex = 1;
            // 
            // grbxSearch
            // 
            this.grbxSearch.Location = new System.Drawing.Point(31, 44);
            this.grbxSearch.Name = "grbxSearch";
            this.grbxSearch.Size = new System.Drawing.Size(960, 106);
            this.grbxSearch.TabIndex = 2;
            this.grbxSearch.TabStop = false;
            this.grbxSearch.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorToolStripMenuItem,
            this.creditToolStripMenuItem,
            this.paymentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1028, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save data to CSV";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // debitorToolStripMenuItem
            // 
            this.debitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.debitorToolStripMenuItem.Name = "debitorToolStripMenuItem";
            this.debitorToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.debitorToolStripMenuItem.Text = "Debitor";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new credit";
            // 
            // paymentToolStripMenuItem
            // 
            this.paymentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentToolStripMenuItem.Name = "paymentToolStripMenuItem";
            this.paymentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.paymentToolStripMenuItem.Text = "Payment";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 616);
            this.Controls.Add(this.grbxSearch);
            this.Controls.Add(this.gpbxPayments);
            this.Controls.Add(this.gpbxCredits);
            this.Controls.Add(this.gpbxDebitorDetails);
            this.Controls.Add(this.gpbxDebitors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Bank Manager";
            this.gpbxDebitors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).EndInit();
            this.gpbxDebitorDetails.ResumeLayout(false);
            this.gpbxDebitorDetails.PerformLayout();
            this.gpbxCredits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).EndInit();
            this.gpbxPayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxDebitors;
        private System.Windows.Forms.DataGridView dgvDebitors;
        private System.Windows.Forms.GroupBox gpbxDebitorDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbxPhoneNumber;
        private System.Windows.Forms.TextBox txbxDebitorPostNumber;
        private System.Windows.Forms.TextBox txbxDebitorName;
        private System.Windows.Forms.TextBox txbxDebitorId;
        private System.Windows.Forms.GroupBox gpbxCredits;
        private System.Windows.Forms.DataGridView dgvCredits;
        private System.Windows.Forms.GroupBox gpbxPayments;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.GroupBox grbxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
    }
}

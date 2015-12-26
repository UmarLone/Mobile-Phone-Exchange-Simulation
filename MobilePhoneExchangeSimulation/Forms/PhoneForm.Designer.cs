namespace PBXEmulator.Forms {
    partial class PhoneForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhoneForm));
            this.lblOwnNumber = new System.Windows.Forms.Label();
            this.lblDialNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCloseMsg = new System.Windows.Forms.Button();
            this.btnSMS = new System.Windows.Forms.Button();
            this.pbCall = new PBXEmulator.Controls.PhoneButton();
            this.pbRedial = new PBXEmulator.Controls.PhoneButton();
            this.pbBook = new PBXEmulator.Controls.PhoneButton();
            this.pb0 = new PBXEmulator.Controls.PhoneButton();
            this.pbDash = new PBXEmulator.Controls.PhoneButton();
            this.pbAst = new PBXEmulator.Controls.PhoneButton();
            this.pb8 = new PBXEmulator.Controls.PhoneButton();
            this.pb9 = new PBXEmulator.Controls.PhoneButton();
            this.pb7 = new PBXEmulator.Controls.PhoneButton();
            this.pb5 = new PBXEmulator.Controls.PhoneButton();
            this.pb6 = new PBXEmulator.Controls.PhoneButton();
            this.pb4 = new PBXEmulator.Controls.PhoneButton();
            this.pb2 = new PBXEmulator.Controls.PhoneButton();
            this.pb3 = new PBXEmulator.Controls.PhoneButton();
            this.pb1 = new PBXEmulator.Controls.PhoneButton();
            this.SuspendLayout();
            // 
            // lblOwnNumber
            // 
            this.lblOwnNumber.AutoSize = true;
            this.lblOwnNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblOwnNumber.ForeColor = System.Drawing.Color.White;
            this.lblOwnNumber.Location = new System.Drawing.Point(43, 133);
            this.lblOwnNumber.Name = "lblOwnNumber";
            this.lblOwnNumber.Size = new System.Drawing.Size(35, 13);
            this.lblOwnNumber.TabIndex = 13;
            this.lblOwnNumber.Text = "# 123";
            // 
            // lblDialNumber
            // 
            this.lblDialNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblDialNumber.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDialNumber.ForeColor = System.Drawing.Color.White;
            this.lblDialNumber.Location = new System.Drawing.Point(43, 156);
            this.lblDialNumber.Name = "lblDialNumber";
            this.lblDialNumber.Size = new System.Drawing.Size(277, 52);
            this.lblDialNumber.TabIndex = 14;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(47, 222);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(273, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Ready";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(43, 156);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(277, 66);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Visible = false;
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // btnCloseMsg
            // 
            this.btnCloseMsg.BackColor = System.Drawing.Color.Gray;
            this.btnCloseMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseMsg.ForeColor = System.Drawing.Color.White;
            this.btnCloseMsg.Location = new System.Drawing.Point(36, 238);
            this.btnCloseMsg.Name = "btnCloseMsg";
            this.btnCloseMsg.Size = new System.Drawing.Size(75, 23);
            this.btnCloseMsg.TabIndex = 17;
            this.btnCloseMsg.Text = "Close";
            this.btnCloseMsg.UseVisualStyleBackColor = false;
            this.btnCloseMsg.Visible = false;
            this.btnCloseMsg.Click += new System.EventHandler(this.btnCloseMsg_Click);
            // 
            // btnSMS
            // 
            this.btnSMS.BackColor = System.Drawing.Color.Gray;
            this.btnSMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMS.ForeColor = System.Drawing.Color.White;
            this.btnSMS.Location = new System.Drawing.Point(245, 238);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(75, 23);
            this.btnSMS.TabIndex = 17;
            this.btnSMS.Text = "SMS";
            this.btnSMS.UseVisualStyleBackColor = false;
            this.btnSMS.Visible = false;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // pbCall
            // 
            this.pbCall.BackColor = System.Drawing.Color.Transparent;
            this.pbCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCall.BackgroundImage")));
            this.pbCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCall.ButtonImage = global::PBXEmulator.Properties.Resources.call;
            this.pbCall.ButtonText = "";
            this.pbCall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCall.Location = new System.Drawing.Point(132, 494);
            this.pbCall.Name = "pbCall";
            this.pbCall.Size = new System.Drawing.Size(92, 45);
            this.pbCall.TabIndex = 10;
            this.pbCall.Load += new System.EventHandler(this.pbCall_Load);
            this.pbCall.Click += new System.EventHandler(this.pbCall_Click);
            // 
            // pbRedial
            // 
            this.pbRedial.BackColor = System.Drawing.Color.Transparent;
            this.pbRedial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRedial.BackgroundImage")));
            this.pbRedial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRedial.ButtonImage = null;
            this.pbRedial.ButtonText = "REDIAL";
            this.pbRedial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbRedial.Location = new System.Drawing.Point(228, 494);
            this.pbRedial.Name = "pbRedial";
            this.pbRedial.Size = new System.Drawing.Size(92, 45);
            this.pbRedial.TabIndex = 11;
            this.pbRedial.Click += new System.EventHandler(this.pbRedial_Click);
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBook.BackgroundImage")));
            this.pbBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBook.ButtonImage = null;
            this.pbBook.ButtonText = "Clear";
            this.pbBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBook.Location = new System.Drawing.Point(36, 494);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(92, 45);
            this.pbBook.TabIndex = 12;
            this.pbBook.Load += new System.EventHandler(this.pbBook_Load);
            this.pbBook.Click += new System.EventHandler(this.pbBook_Click);
            // 
            // pb0
            // 
            this.pb0.BackColor = System.Drawing.Color.Transparent;
            this.pb0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb0.BackgroundImage")));
            this.pb0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb0.ButtonImage = null;
            this.pb0.ButtonText = "0\r\n+";
            this.pb0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb0.Location = new System.Drawing.Point(132, 443);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(92, 45);
            this.pb0.TabIndex = 7;
            this.pb0.Tag = "0";
            this.pb0.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pbDash
            // 
            this.pbDash.BackColor = System.Drawing.Color.Transparent;
            this.pbDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDash.BackgroundImage")));
            this.pbDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDash.ButtonImage = null;
            this.pbDash.ButtonText = "#";
            this.pbDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDash.Location = new System.Drawing.Point(228, 443);
            this.pbDash.Name = "pbDash";
            this.pbDash.Size = new System.Drawing.Size(92, 45);
            this.pbDash.TabIndex = 8;
            this.pbDash.Tag = "#";
            this.pbDash.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pbAst
            // 
            this.pbAst.BackColor = System.Drawing.Color.Transparent;
            this.pbAst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAst.BackgroundImage")));
            this.pbAst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAst.ButtonImage = null;
            this.pbAst.ButtonText = "*";
            this.pbAst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAst.Location = new System.Drawing.Point(36, 443);
            this.pbAst.Name = "pbAst";
            this.pbAst.Size = new System.Drawing.Size(92, 45);
            this.pbAst.TabIndex = 9;
            this.pbAst.Tag = "*";
            this.pbAst.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb8
            // 
            this.pb8.BackColor = System.Drawing.Color.Transparent;
            this.pb8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb8.BackgroundImage")));
            this.pb8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb8.ButtonImage = null;
            this.pb8.ButtonText = "8\r\nTUV";
            this.pb8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb8.Location = new System.Drawing.Point(132, 392);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(92, 45);
            this.pb8.TabIndex = 4;
            this.pb8.Tag = "8";
            this.pb8.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb9
            // 
            this.pb9.BackColor = System.Drawing.Color.Transparent;
            this.pb9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb9.BackgroundImage")));
            this.pb9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb9.ButtonImage = null;
            this.pb9.ButtonText = "9\r\nWXYZ";
            this.pb9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb9.Location = new System.Drawing.Point(228, 392);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(92, 45);
            this.pb9.TabIndex = 5;
            this.pb9.Tag = "9";
            this.pb9.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb7
            // 
            this.pb7.BackColor = System.Drawing.Color.Transparent;
            this.pb7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb7.BackgroundImage")));
            this.pb7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb7.ButtonImage = null;
            this.pb7.ButtonText = "7\r\nPQRS";
            this.pb7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb7.Location = new System.Drawing.Point(36, 392);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(92, 45);
            this.pb7.TabIndex = 6;
            this.pb7.Tag = "7";
            this.pb7.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Transparent;
            this.pb5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb5.BackgroundImage")));
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.ButtonImage = null;
            this.pb5.ButtonText = "5\r\nJKL";
            this.pb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5.Location = new System.Drawing.Point(132, 341);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(92, 45);
            this.pb5.TabIndex = 1;
            this.pb5.Tag = "5";
            this.pb5.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.Transparent;
            this.pb6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb6.BackgroundImage")));
            this.pb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb6.ButtonImage = null;
            this.pb6.ButtonText = "6\r\nMNO";
            this.pb6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb6.Location = new System.Drawing.Point(228, 341);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(92, 45);
            this.pb6.TabIndex = 2;
            this.pb6.Tag = "6";
            this.pb6.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Transparent;
            this.pb4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb4.BackgroundImage")));
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.ButtonImage = null;
            this.pb4.ButtonText = "4\r\nGHI";
            this.pb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb4.Location = new System.Drawing.Point(36, 341);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(92, 45);
            this.pb4.TabIndex = 3;
            this.pb4.Tag = "4";
            this.pb4.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Transparent;
            this.pb2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb2.BackgroundImage")));
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.ButtonImage = null;
            this.pb2.ButtonText = "2\r\nABC";
            this.pb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb2.Location = new System.Drawing.Point(134, 290);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(92, 45);
            this.pb2.TabIndex = 0;
            this.pb2.Tag = "2";
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Transparent;
            this.pb3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb3.BackgroundImage")));
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.ButtonImage = null;
            this.pb3.ButtonText = "3\r\nDEF";
            this.pb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb3.Location = new System.Drawing.Point(228, 290);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(92, 45);
            this.pb3.TabIndex = 0;
            this.pb3.Tag = "3";
            this.pb3.Click += new System.EventHandler(this.pb1_Click);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Transparent;
            this.pb1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb1.BackgroundImage")));
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.ButtonImage = null;
            this.pb1.ButtonText = "1\r\n";
            this.pb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb1.Location = new System.Drawing.Point(36, 290);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(92, 45);
            this.pb1.TabIndex = 0;
            this.pb1.Tag = "1";
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::PBXEmulator.Properties.Resources.phone_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 648);
            this.Controls.Add(this.btnSMS);
            this.Controls.Add(this.btnCloseMsg);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblDialNumber);
            this.Controls.Add(this.lblOwnNumber);
            this.Controls.Add(this.pbCall);
            this.Controls.Add(this.pbRedial);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.pb0);
            this.Controls.Add(this.pbDash);
            this.Controls.Add(this.pbAst);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhoneForm";
            this.Text = "PhoneForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PhoneButton pb1;
        private Controls.PhoneButton pb3;
        private Controls.PhoneButton pb2;
        private Controls.PhoneButton pb5;
        private Controls.PhoneButton pb6;
        private Controls.PhoneButton pb4;
        private Controls.PhoneButton pb8;
        private Controls.PhoneButton pb9;
        private Controls.PhoneButton pb7;
        private Controls.PhoneButton pb0;
        private Controls.PhoneButton pbDash;
        private Controls.PhoneButton pbAst;
        private Controls.PhoneButton pbCall;
        private Controls.PhoneButton pbRedial;
        private Controls.PhoneButton pbBook;
        private System.Windows.Forms.Label lblOwnNumber;
        private System.Windows.Forms.Label lblDialNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCloseMsg;
        private System.Windows.Forms.Button btnSMS;
    }
}
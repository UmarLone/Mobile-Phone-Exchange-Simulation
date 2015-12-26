namespace PBXEmulator.Forms {
    partial class ExchangeForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeForm));
            this.phonesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddPhone = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.statusTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbPhones = new System.Windows.Forms.ComboBox();
            this.btnAddAdvanced = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phonesPanel
            // 
            this.phonesPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("phonesPanel.BackgroundImage")));
            this.phonesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phonesPanel.Location = new System.Drawing.Point(12, 46);
            this.phonesPanel.Name = "phonesPanel";
            this.phonesPanel.Size = new System.Drawing.Size(716, 327);
            this.phonesPanel.TabIndex = 0;
            // 
            // btnAddPhone
            // 
            this.btnAddPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPhone.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddPhone.Location = new System.Drawing.Point(12, 425);
            this.btnAddPhone.Name = "btnAddPhone";
            this.btnAddPhone.Size = new System.Drawing.Size(117, 86);
            this.btnAddPhone.TabIndex = 1;
            this.btnAddPhone.Text = "Add Phone";
            this.btnAddPhone.UseVisualStyleBackColor = false;
            this.btnAddPhone.Click += new System.EventHandler(this.btnAddPhone_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Indigo;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(14, 389);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 22);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Ready";
            // 
            // statusTimer
            // 
            this.statusTimer.Interval = 1000;
            this.statusTimer.Tick += new System.EventHandler(this.statusTimer_Tick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Location = new System.Drawing.Point(287, 425);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 86);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Phone";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbPhones
            // 
            this.cbPhones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbPhones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPhones.ForeColor = System.Drawing.Color.White;
            this.cbPhones.FormattingEnabled = true;
            this.cbPhones.IntegralHeight = false;
            this.cbPhones.Location = new System.Drawing.Point(446, 426);
            this.cbPhones.Name = "cbPhones";
            this.cbPhones.Size = new System.Drawing.Size(266, 28);
            this.cbPhones.TabIndex = 4;
            // 
            // btnAddAdvanced
            // 
            this.btnAddAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdvanced.ForeColor = System.Drawing.SystemColors.Info;
            this.btnAddAdvanced.Location = new System.Drawing.Point(135, 425);
            this.btnAddAdvanced.Name = "btnAddAdvanced";
            this.btnAddAdvanced.Size = new System.Drawing.Size(146, 86);
            this.btnAddAdvanced.TabIndex = 5;
            this.btnAddAdvanced.Text = "Add Advanced Phone";
            this.btnAddAdvanced.UseVisualStyleBackColor = false;
            this.btnAddAdvanced.Click += new System.EventHandler(this.btnAddAdvanced_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phone Exchange";
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(740, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAdvanced);
            this.Controls.Add(this.cbPhones);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnAddPhone);
            this.Controls.Add(this.phonesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ExchangeForm";
            this.Text = "ExchangeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExchangeForm_FormClosed);
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel phonesPanel;
        private System.Windows.Forms.Button btnAddPhone;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer statusTimer;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbPhones;
        private System.Windows.Forms.Button btnAddAdvanced;
        private System.Windows.Forms.Label label1;
    }
}
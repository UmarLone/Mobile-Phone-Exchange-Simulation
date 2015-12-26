using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBXEmulator.Forms {
    /// <summary>
    /// Form to enter SMS text
    /// </summary>
    public partial class SMSForm : Form {
        public SMSForm() {
            InitializeComponent();
        }

        /// <summary>
        /// SMS text
        /// </summary>
        public string SMSText {
            get {
                return txtSMS.Text;
            }
            set {
                txtSMS.Text = value;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }
    }
}

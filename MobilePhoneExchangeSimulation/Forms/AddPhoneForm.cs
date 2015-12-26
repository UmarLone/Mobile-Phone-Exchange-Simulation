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
    /// Form to allow edit added phone properties
    /// </summary>
    public partial class AddPhoneForm : Form {
        public AddPhoneForm() {
            InitializeComponent();
        }

        /// <summary>
        /// Phone number
        /// </summary>
        public string Number {
            get {
                return txtPhoneNumber.Text;
            }
            set {
                txtPhoneNumber.Text = value;
            }
        }

        /// <summary>
        /// Phone name
        /// </summary>
        public string PhoneName {
            get {
                return txtName.Text;
            }
            set {
                txtName.Text = value;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBXEmulator.Model;

namespace PBXEmulator.Controls {

    /// <summary>
    /// This is a user control to display phone status on PBX panel
    /// </summary>
    public partial class PhoneControl : UserControl {
        public PhoneControl() {
            InitializeComponent();
        }

        /// <summary>
        /// Phone which is represented by this control
        /// </summary>
        public Phone Phone { get; set; }

        /// <summary>
        /// Updates visual status of phone
        /// </summary>
        public void UpdateStatus() {
            lblNumber.Text = "# " + Phone;
            if (Phone.CurrentCall != null) {
                if (Phone.CurrentCall.Accepted) {
                    lblStatus.Text = "Talking to " +
                                     (Phone.CurrentCall.Source == Phone
                                         ? Phone.CurrentCall.Dest
                                         : Phone.CurrentCall.Source) + ", duration = " + Phone.CurrentCall.Duration;
                }
                else {
                    if (Phone.CurrentCall.Source == Phone) {
                        lblStatus.Text = "-> outgoing call to " + Phone.CurrentCall.Dest.Number;
                    }
                    else {
                        lblStatus.Text = "<- incoming call from " + Phone.CurrentCall.Source.Number;
                    }
                }                
            }
            else {
                lblStatus.Text = "Ready";
            }
        }

        private void PhoneControl_Load(object sender, EventArgs e)
        {

        }
    }
}

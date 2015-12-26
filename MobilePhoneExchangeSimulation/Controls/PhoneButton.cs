using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBXEmulator.Controls {
    /// <summary>
    /// This is a user control to draw phone buttons 0-9. Can draw image or text on button surface
    /// </summary>
    public partial class PhoneButton : UserControl {
        public PhoneButton() {
            InitializeComponent();
        }

        /// <summary>
        /// Button text. Multiline allowed
        /// </summary>
        [EditorAttribute("System.ComponentModel.Design.MultilineStringEditor, System.Design", "System.Drawing.Design.UITypeEditor")]
        public string ButtonText {
            get {
                return lblLine1.Text;
            }
            set {
                lblLine1.Text = value;
            }
        }

        /// <summary>
        /// Image on button. If it is set - ButtonText is not visible
        /// </summary>
        public Image ButtonImage {
            get {
                return pbImage.Image;
            }
            set {
                pbImage.Image = value;
                lblLine1.Visible = value == null;
            }
        }

        private void pbImage_Click(object sender, EventArgs e) {
            this.OnClick(e);
        }

        private void lblLine1_Click(object sender, EventArgs e) {
            this.OnClick(e);
        }
    }
}

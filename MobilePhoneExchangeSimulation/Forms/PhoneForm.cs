using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using PBXEmulator.Controls;
using PBXEmulator.Model;
using PBXEmulator.Properties;

namespace PBXEmulator.Forms {
    /// <summary>
    /// This is a form for phone, to make and answer calls
    /// </summary>
    public partial class PhoneForm : Form {
        /// <summary>
        /// Audio player for ring and different tones (except for buttons)
        /// </summary>
        private SoundPlayer player;
        /// <summary>
        /// Flag for incoming call
        /// </summary>
        private bool incoming = false;
        /// <summary>
        /// Last dialed/rejected call/missed call phone number
        /// </summary>
        private string missedCallNumber = null;

        public PhoneForm() {
            InitializeComponent();

            player = new SoundPlayer();
        }

        /// <summary>
        /// Assigned phone object
        /// </summary>
        public Phone Phone { get; set; }

        /// <summary>
        /// Initialize form after assigning phone object
        /// </summary>
        public void Init() {
            lblOwnNumber.Text = "# " + Phone;
            lblStatus.Text = "Ready";
            lblDialNumber.Text = "";

            Phone.OnCallConnected += Phone_OnCallConnected;
            Phone.OnCallFinished += Phone_OnCallFinished;
            Phone.OnCallRejected += Phone_OnCallRejected;
            Phone.OnIncomingCall += Phone_OnIncomingCall;
            Phone.OnSMSReceived += Phone_OnSMSReceived;
        }

        /// <summary>
        /// SMS received event handler
        /// </summary>
        /// <param name="source">sender</param>
        /// <param name="text">message text</param>
        private void Phone_OnSMSReceived(Phone source, string text) {
            lblDialNumber.Visible = false;
            lblMessage.Visible = true;
            lblMessage.Text = text;
            lblStatus.Text = "SMS from " + source;
            btnCloseMsg.Visible = true;
        }

        /// <summary>
        /// Incoming call received event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Phone_OnIncomingCall(object sender, EventArgs e) {
            lblStatus.Text = "<- Incoming call from " + Phone.CurrentCall.Source;
            missedCallNumber = Phone.CurrentCall.Source.Number;

            lblDialNumber.Text = "";

            player.Stop();
            player.Stream = Resources.telephone_ring_04;
            player.PlayLooping();

            pbCall.ButtonImage = Resources.call;
        }

        /// <summary>
        /// Rejected call event handler
        /// </summary>
        /// <param name="reason"></param>
        private void Phone_OnCallRejected(string reason) {
            lblStatus.Text = "-> " + reason;
            pbCall.ButtonImage = Resources.call;

            player.Stop();
            player.Stream = Resources.phone_disconnect_1;
            player.Play();
        }

        /// <summary>
        /// Finished call event handler
        /// </summary>
        /// <param name="c"></param>
        private void Phone_OnCallFinished(Conversation c) {
            if (c.Accepted) {
                if (c.Source == Phone) {
                    lblStatus.Text = "Finished call to " + c.Dest + ", duration = " + c.Duration;
                }
                else {
                    lblStatus.Text = "Finished call from " + c.Source + ", duration = " + c.Duration;
                }
            }
            else {
                if (c.Source == Phone) {
                    lblStatus.Text = "Ready";
                }
                else {
                    lblStatus.Text = "Missed call from " + c.Source;
                    missedCallNumber = c.Source.Number;
                }
            }

            pbCall.ButtonImage = Resources.call;

            player.Stop();
            player.Stream = Resources.phone_disconnect_1;
            player.Play();
        }

        /// <summary>
        /// Call accepted event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Phone_OnCallConnected(object sender, EventArgs e) {
            // Stop playing dialing tone
            player.Stop();

            pbCall.ButtonImage = Resources.hang;
            lblStatus.Text = "-> Outgoing call to " + Phone.CurrentCall.Source;
        }

        /// <summary>
        /// Digit button pressed handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pb1_Click(object sender, EventArgs e) {
            var btn = (PhoneButton) sender;
            lblDialNumber.Text += btn.Tag.ToString();
            switch (btn.Tag.ToString()) {
                case "0":
                    new SoundPlayer(Resources.cell_phone_1_nr0).Play();
                    break;
                case "1":
                    new SoundPlayer(Resources.cell_phone_1_nr1).Play();
                    break;
                case "2":
                    new SoundPlayer(Resources.cell_phone_1_nr2).Play();
                    break;
                case "3":
                    new SoundPlayer(Resources.cell_phone_1_nr3).Play();
                    break;
                case "4":
                    new SoundPlayer(Resources.cell_phone_1_nr4).Play();
                    break;
                case "5":
                    new SoundPlayer(Resources.cell_phone_1_nr5).Play();
                    break;
                case "6":
                    new SoundPlayer(Resources.cell_phone_1_nr6).Play();
                    break;
                case "7":
                    new SoundPlayer(Resources.cell_phone_1_nr7).Play();
                    break;
                case "8":
                    new SoundPlayer(Resources.cell_phone_1_nr8).Play();
                    break;
                case "9":
                    new SoundPlayer(Resources.cell_phone_1_nr9).Play();
                    break;
            }

            btnSMS.Visible = Phone.Advanced && !String.IsNullOrEmpty(lblDialNumber.Text);
        }

        /// <summary>
        /// Override window procedure to allow dragging window by any point (it's borderless)
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m) {
            base.WndProc(ref m);

            int WM_NCHITTEST = 0x84;
            if (m.Msg == WM_NCHITTEST) {
                int HTCLIENT = 1;
                int HTCAPTION = 2;
                if (m.Result.ToInt32() == HTCLIENT)
                    m.Result = (IntPtr)HTCAPTION;
            }
        }

        /// <summary>
        /// Call button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbCall_Click(object sender, EventArgs e) {
            if (Phone.CurrentCall == null) {
                if (String.IsNullOrEmpty(lblDialNumber.Text)) {
                    return;
                }

                pbCall.ButtonImage = Resources.hang;
                var number = lblDialNumber.Text;
                player.Stop();
                player.Stream = Resources.phone_calling_1;
                player.PlayLooping();

                lblStatus.Text = "Calling " + number + "...";

                missedCallNumber = number;

                lblDialNumber.Text = "";

                Phone.MakeCall(number);
            }
            else {
                if (Phone.CurrentCall.Source != Phone && !Phone.CurrentCall.Accepted) {
                    Phone.AcceptCall();

                    pbCall.ButtonImage = Resources.hang;
                }
                else {
                    Phone.FinishCall();

                    pbCall.ButtonImage = Resources.call;
                }

                player.Stop();
            }
        }

        /// <summary>
        /// Redial button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbRedial_Click(object sender, EventArgs e) {
            if (Phone.CurrentCall == null && !String.IsNullOrEmpty(missedCallNumber)) {
                lblDialNumber.Text = missedCallNumber;

                pbCall_Click(sender, e);
            }
        }

        /// <summary>
        /// SMS button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSMS_Click(object sender, EventArgs e) {
            var frm = new SMSForm();
            if (frm.ShowDialog() == DialogResult.OK && !String.IsNullOrEmpty(frm.SMSText)) {
                Phone.Exchange.SendSMS(Phone, lblDialNumber.Text, frm.SMSText);
            }
        }

        /// <summary>
        /// Close received sms button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseMsg_Click(object sender, EventArgs e) {
            btnCloseMsg.Visible = false;
            lblMessage.Text = "";
            lblMessage.Visible = false;
            lblDialNumber.Visible = true;
        }

        private void pbCall_Load(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Backspace button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbBook_Click(object sender, EventArgs e) {
            if (lblDialNumber.Text.Length > 0) {
                lblDialNumber.Text = lblDialNumber.Text.Substring(0, lblDialNumber.Text.Length - 1);
            }
        }

        private void pbBook_Load(object sender, EventArgs e)
        {

        }
    }
}

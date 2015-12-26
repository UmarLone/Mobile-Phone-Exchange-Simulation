using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PBXEmulator.Controls;
using PBXEmulator.Model;

namespace PBXEmulator.Forms {
    /// <summary>
    /// PBX Panel form
    /// </summary>
    public partial class ExchangeForm : Form {
        /// <summary>
        /// Exchange instance
        /// </summary>
        private Exchange exchange;

        /// <summary>
        /// List of phone forms
        /// </summary>
        private List<PhoneForm> forms = new List<PhoneForm>(); 

        public ExchangeForm() {
            InitializeComponent();

            exchange = new Exchange();

            exchange.SystemError += exchange_SystemError;
            exchange.CallConnected += exchange_CallConnected;
            exchange.CallFinished += exchange_CallFinished;
            exchange.CallRejected += exchange_CallRejected;
            exchange.PhoneCalling += exchange_PhoneCalling;
        }

        private void exchange_PhoneCalling(string srcNumber, string dstNumber) {
            UpdatePhones();
        }

        private void exchange_CallRejected(string srcNumber, string dstNumber) {
            UpdatePhones();
        }

        private void exchange_CallFinished(string srcNumber, string dstNumber) {
            UpdatePhones();
        }

        private void exchange_CallConnected(string srcNumber, string dstNumber) {
            UpdatePhones();
        }

        private void exchange_SystemError(string text) {
            lblStatus.Text = text;
        }

        private void ExchangeForm_FormClosed(object sender, FormClosedEventArgs e) {
            // When form is closed - exit application
            Application.Exit();
        }

        private void statusTimer_Tick(object sender, EventArgs e) {
            UpdatePhones();
        }

        private void UpdatePhones() {
            foreach (var control in phonesPanel.Controls) {
                ((PhoneControl)control).UpdateStatus();
            }
        }

        private void addPhone(bool advanced) {
            var dlg = new AddPhoneForm();
            dlg.Number = (phonesPanel.Controls.Count + 1).ToString("#000");
            dlg.PhoneName = "Phone" + dlg.Number;

            if (dlg.ShowDialog() == DialogResult.OK) {
                var phone = exchange.AddPhone(dlg.PhoneName, dlg.Number);
                if (phone != null) {
                    phone.Advanced = advanced;

                    var ctrl = new PhoneControl();
                    ctrl.Phone = phone;
                    ctrl.UpdateStatus();

                    cbPhones.Items.Add(phone);

                    phonesPanel.Controls.Add(ctrl);

                    var frm = new PhoneForm();
                    frm.Phone = phone;
                    frm.Init();
                    frm.Show();

                    forms.Add(frm);
                }
            }
        }

        private void btnAddPhone_Click(object sender, EventArgs e) {
            addPhone(false);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (cbPhones.SelectedItem != null) {
                var phone = (Phone) cbPhones.SelectedItem;

                exchange.RemovePhone(phone);

                cbPhones.Items.Remove(phone);

                foreach (var control in phonesPanel.Controls) {
                    if (((PhoneControl) control).Phone == phone) {
                        phonesPanel.Controls.Remove((Control)control);
                        break;
                    }
                }

                var frm = forms.Find(x => x.Phone == phone);
                if (frm != null) {
                    frm.Close();
                }
            }
        }

        private void btnAddAdvanced_Click(object sender, EventArgs e) {
            addPhone(true);
        }

        private void ExchangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

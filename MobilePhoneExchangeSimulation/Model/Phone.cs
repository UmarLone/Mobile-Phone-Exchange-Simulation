using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBXEmulator.Model {
    public delegate void CallRejectedDelegate(string reason);

    public delegate void CallFinishedDelegate(Conversation c);

    public delegate void SMSReceivedDelegate(Phone source, string text);

    /// <summary>
    /// Phone class
    /// </summary>
    public class Phone {
        /// <summary>
        /// Advanced phone can send and receive SMS
        /// </summary>
        public bool Advanced { get; set; }
        /// <summary>
        /// Contact name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Phone number
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// Link to Exchange instance
        /// </summary>
        public Exchange Exchange { get; set; }

        /// <summary>
        /// Current conversation
        /// </summary>
        public Conversation CurrentCall { get; set; }

        /// <summary>
        /// Event - incoming call received. Must reject or accept
        /// </summary>
        public event EventHandler OnIncomingCall;
        /// <summary>
        /// Event - outgoing call is accepted. Must start sending voice
        /// </summary>
        public event EventHandler OnCallConnected;
        /// <summary>
        /// Event - outgoing call is rejected.
        /// </summary>
        public event CallRejectedDelegate OnCallRejected;
        /// <summary>
        /// Event - current call is finished
        /// </summary>
        public event CallFinishedDelegate OnCallFinished;
        /// <summary>
        /// Event - SMS received
        /// </summary>
        public event SMSReceivedDelegate OnSMSReceived;

        /// <summary>
        /// Notification from Exchange when incoming call is received
        /// </summary>
        /// <param name="c">Conversation</param>
        public void IncomingCall(Conversation c) {
            // If already talking to someone else - send "Busy" reject
            if (CurrentCall != null) {
                Exchange.RejectIncomingCall(this, "Busy");
                return;
            }

            // Assign current call
            CurrentCall = c;

            // Send event
            if (OnIncomingCall != null) {
                OnIncomingCall(this, new EventArgs());
            }
        }

        /// <summary>
        /// Notification from Exchange when outgoing call is rejected
        /// </summary>
        /// <param name="reason">reject reason</param>
        public void CallRejected(string reason) {
            // Send event
            if (OnCallRejected != null) {
                OnCallRejected(reason);
            }

            // Clear current call
            CurrentCall = null;
        }

        /// <summary>
        /// Notification from Exchange when outgoing call is connected
        /// </summary>
        public void CallConnected() {
            if (OnCallConnected != null) {
                OnCallConnected(this, new EventArgs());
            }
        }

        /// <summary>
        /// Notification from Exchange when current call is finished
        /// </summary>
        /// <param name="c">conversation</param>
        public void CallFinished(Conversation c) {
            // Send event
            if (OnCallFinished != null && CurrentCall!=null) {
                OnCallFinished(c);
            }

            // Clear current call
            CurrentCall = null;
        }

        /// <summary>
        /// Notification from Exchange when SMS is received
        /// </summary>
        /// <param name="source">source phone</param>
        /// <param name="text">SMS text</param>
        public void SendSMS(Phone source, string text) {
            if (OnSMSReceived != null) {
                OnSMSReceived(source, text);
            }
        }

        /// <summary>
        /// Make a call to specified number
        /// </summary>
        /// <param name="number">destination phone number</param>
        public void MakeCall(string number) {
            CurrentCall = Exchange.Call(this, number);
        }

        /// <summary>
        /// Accept incoming call
        /// </summary>
        public void AcceptCall() {
            Exchange.AcceptIncomingCall(this);
        }

        /// <summary>
        /// Finish current call
        /// </summary>
        public void FinishCall() {
            if (CurrentCall != null) {
                if (CurrentCall.Source == this) {
                    Exchange.FinishOutgoingCall(this);
                }
                else {
                    Exchange.FinishIncomingCall(this);
                }
                CurrentCall = null;
            }
        }

        public override string ToString() {
            return Number + " / " + Name;
        }
    }
}

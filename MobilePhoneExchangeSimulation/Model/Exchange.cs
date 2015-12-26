using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBXEmulator.Model {
    public delegate void SystemErrorDelegate(string text);

    public delegate void CallEventDelegate(string srcNumber, string dstNumber);

    /// <summary>
    /// Exchange class
    /// </summary>
    public class Exchange {
        /// <summary>
        /// Registered phones list
        /// </summary>
        private List<Phone> phones = new List<Phone>();
        /// <summary>
        /// Current conversations
        /// </summary>
        private List<Conversation> conversations = new List<Conversation>(); 

        /// <summary>
        /// General system error event
        /// </summary>
        public event SystemErrorDelegate SystemError;
        /// <summary>
        /// Call initiated event
        /// </summary>
        public event CallEventDelegate PhoneCalling;
        /// <summary>
        /// Call accepted event
        /// </summary>
        public event CallEventDelegate CallConnected;
        /// <summary>
        /// Call rejected event
        /// </summary>
        public event CallEventDelegate CallRejected;
        /// <summary>
        /// Call finished event
        /// </summary>
        public event CallEventDelegate CallFinished;

        private void FireSystemError(string text) {
            if (SystemError != null) {
                SystemError(text);
            }
        }

        private void FirePhoneCalling(string from, string to) {
            if (PhoneCalling != null) {
                PhoneCalling(from, to);
            }
        }
        private void FireCallConnected(string from, string to) {
            if (CallConnected != null) {
                CallConnected(from, to);
            }
        }
        private void FireCallRejected(string from, string to) {
            if (CallRejected != null) {
                CallRejected(from, to);
            }
        }
        private void FireCallFinished(string from, string to) {
            if (CallFinished != null) {
                CallFinished(from, to);
            }
        }

        /// <summary>
        /// Registers phone
        /// </summary>
        /// <param name="name">Contact name</param>
        /// <param name="number">phone number</param>
        /// <returns>registered phone, or null in case of error</returns>
        public Phone AddPhone(string name, string number) {
            // Find duplicate phone number
            Phone p = phones.Find(x => x.Number.Equals(number));
            if (p != null) {
                FireSystemError("Duplicate phone number!");

                return null;
            }

            // Create and register phone
            var phone = new Phone() {Name = name, Number = number, Exchange = this};
            phones.Add(phone);

            return phone;
        }

        /// <summary>
        /// Removes phone
        /// </summary>
        /// <param name="phone"></param>
        public void RemovePhone(Phone phone) {
            //Find all active conversations where specified phone is either source or destination
            List<Conversation> convs = conversations.FindAll(x => x.Source == phone || x.Dest == phone);

            // Finish all conversations
            foreach (var conv in convs) {
                conv.Source.CallFinished(conv);
                conv.Dest.CallFinished(conv);

                conversations.Remove(conv);
            }

            // Unregister phone
            phones.Remove(phone);
        }

        /// <summary>
        /// Make a call
        /// </summary>
        /// <param name="source">Source phone</param>
        /// <param name="destNumber">Destination phone number</param>
        /// <returns>conversation instance or null if call cannot be made</returns>
        public Conversation Call(Phone source, string destNumber) {
            // Raise event
            FirePhoneCalling(source.Number, destNumber);

            // Find destination phone
            Phone dest = phones.Find(x => x.Number.Equals(destNumber));

            // If calling itself, send "Busy" reject to source
            if (source == dest) {
                FireCallRejected(source.Number, destNumber);
                source.CallRejected("Busy");
            }

            Conversation c = null;

            // If destination phone is found, create and register conversation
            if (dest != null) {
                c = new Conversation() {
                    Source = source,
                    Dest = dest,
                    InitTime = DateTime.Now,
                    AcceptTime = DateTime.MinValue,
                    Accepted = false
                };

                conversations.Add(c);

                // Notify destination phone about incoming call
                dest.IncomingCall(c);
            }
            else {
                // Destination phone not found - send "Unknown" reject back to source
                FireCallRejected(source.Number, destNumber);

                source.CallRejected("Unknown phone number");
            }

            return c;
        }

        /// <summary>
        /// Send SMS to specified phone number
        /// </summary>
        /// <param name="source">source phone</param>
        /// <param name="number">destination phone number</param>
        /// <param name="text">SMS text</param>
        /// <returns>true if message sent, false otherwise</returns>
        public bool SendSMS(Phone source, string number, string text) {
            //Find destination phone
            Phone dest = phones.Find(x => x.Number.Equals(number));
            if (dest == null) { // Phone not found
                return false;
            }
            if (!dest.Advanced) { // Phone doesn't accept SMS
                return false;
            }

            // Notify destination phone, pass SMS text
            dest.SendSMS(source, text);

            return true;
        }

        /// <summary>
        /// Callback from phone - if it rejects incoming call
        /// </summary>
        /// <param name="phone">destination phone</param>
        /// <param name="reason">reject reason</param>
        public void RejectIncomingCall(Phone phone, string reason) {
            // Find conversation with specified destination phone
            Conversation c = conversations.Find(x => x.Dest.Number.Equals(phone.Number) && x.Accepted == false);
            if (c != null) {
                // Notify source phone about rejected call
                c.Source.CallRejected(reason);

                // Send system event
                FireCallRejected(c.Source.Number, c.Dest.Number);

                // Unregister conversation
                conversations.Remove(c);
            }
            else { // System error - call rejected but there's no active conversation
                FireSystemError("Incoming call to " + phone.Number + " is not found!");
            }
        }

        /// <summary>
        /// Callback from phone - if it accepts incoming call
        /// </summary>
        /// <param name="phone">destination phone</param>
        public void AcceptIncomingCall(Phone phone) {
            // Find conversation with specified destination phone
            Conversation c = conversations.Find(x => x.Dest.Number.Equals(phone.Number));
            if (c != null) {
                // Notify source phone about accepted call
                c.Source.CallConnected();
                // Mark conversation as accepted
                c.AcceptTime = DateTime.Now;
                c.Accepted = true;

                // Send system event
                FireCallConnected(c.Source.Number, c.Dest.Number);
            } else {// System error - call accepted but there's no active conversation
                FireSystemError("Incoming call to " + phone.Number + " is not found!");
            }
        }

        /// <summary>
        /// Callback from phone - if it finishes incoming call
        /// </summary>
        /// <param name="phone">destination phone</param>
        public void FinishIncomingCall(Phone phone) {
            // Find conversation with specified destination phone
            Conversation c = conversations.Find(x => x.Dest.Number.Equals(phone.Number));
            if (c != null) {
                // Notify both phones about finished call
                c.Source.CallFinished(c);
                c.Dest.CallFinished(c);

                // Send system event
                FireCallFinished(c.Source.Number, c.Dest.Number);

                // Unregister conversation
                conversations.Remove(c);
            }
            else {
                FireSystemError("Incoming call to " + phone.Number + " is not found!");
            }
        }

        /// <summary>
        /// Callback from phone - if it finishes outgoing call
        /// </summary>
        /// <param name="phone">source phone</param>
        public void FinishOutgoingCall(Phone phone) {
            // Find conversation with specified source phone
            Conversation c = conversations.Find(x => x.Source.Number.Equals(phone.Number));
            if (c != null) {
                // Notify both phones about finished call
                c.Source.CallFinished(c);
                c.Dest.CallFinished(c);

                // Send system event
                FireCallFinished(c.Source.Number, c.Dest.Number);

                // Unregister conversation
                conversations.Remove(c);
            } else {
                FireSystemError("Outgoing call from " + phone.Number + " is not found!");
            }
        }


    }
}

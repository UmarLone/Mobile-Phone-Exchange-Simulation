using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PBXEmulator.Model {
    /// <summary>
    /// Conversation
    /// </summary>
    public class Conversation {
        /// <summary>
        /// Source phone
        /// </summary>
        public Phone Source { get; set; }
        /// <summary>
        /// Destination phone
        /// </summary>
        public Phone Dest { get; set; }
        /// <summary>
        /// Time when call was initiated
        /// </summary>
        public DateTime InitTime { get; set; }
        /// <summary>
        /// Time when call was accepted by remote party
        /// </summary>
        public DateTime AcceptTime { get; set; }
        /// <summary>
        /// Flag if call is accepted
        /// </summary>
        public bool Accepted { get; set; }

        /// <summary>
        /// Call duration
        /// </summary>
        public TimeSpan Duration {
            get {
                if (Accepted) {
                    return DateTime.Now.Subtract(AcceptTime);
                }
                return TimeSpan.Zero;
            }
        }
    }
}

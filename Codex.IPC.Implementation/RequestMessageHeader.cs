﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Codex.IPC.Implementation
{
    /// <summary>
    /// Header information for the request packet.
    /// </summary>
    [DataContract]
    public class RequestMessageHeader
    {
        /// <summary>
        /// Identifier for the process on the machine.
        /// </summary>
        [DataMember]
        public string ProcessID { get; set; }

        /// <summary>
        /// Type of message that is being transmitted in the body.
        /// </summary>
        /// <remarks>
        /// This can be used to distinguish between the actions
        /// that need to be performed on receipt of the message.
        /// </remarks>
        [DataMember]
        public int MessageType { get; set; }
    }
}

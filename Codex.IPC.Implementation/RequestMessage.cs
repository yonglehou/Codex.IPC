﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Codex.IPC.Implementation
{
    /// <summary>
    /// Message sent from the client to the server.
    /// </summary>
    [DataContract]
    public class RequestMessage:MessageBase
    {
        /// <summary>
        /// Header information of the message packet.
        /// </summary>
        [DataMember]
        public RequestMessageHeader Header { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public RequestMessage()
        {
            Header = new RequestMessageHeader();
            Header.ProcessID = System.Diagnostics.Process.GetCurrentProcess().Id.ToString();
        }
    }
}

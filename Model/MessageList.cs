using System;
using System.Collections.Generic;

namespace ZohoAPIProjectsInActive.Model
{
    public partial class MessageList
    {
        public int MessageId { get; set; }
        public string MessageType { get; set; }
        public string MessageContent { get; set; }
        public string MessageStatus { get; set; }
        public DateTime? MessageCreatedDate { get; set; }
        public DateTime? MessageProcessedDate { get; set; }
    }
}

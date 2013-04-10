﻿using System;
using System.Diagnostics;
using System.Linq;

namespace NServiceBus.Profiler.Common.Models
{
    [DebuggerDisplay("Id={Id}, RelatedToMessageId={RelatedToMessageId}")]
    public class StoredMessage : MessageBody
    {
        public MessageStatus Status { get; set; }
        public FailureDetails FailureDetails { get; set; }
        public Endpoint OriginatingEndpoint { get; set; }
        public Endpoint ReceivingEndpoint { get; set; }
        //public SagaDetails OriginatingSaga { get; set; }
        public MessageStatistics Statistics { get; set; }
        public bool IsDeferredMessage { get; set; }
        public string RelatedToMessageId { get; set; }
        public string ConversationId { get; set; }

        public string ShortMessageId
        {
            get
            {
                return String.Format("{0}...", Id.Substring(0, 7));
            }
        }
    }
}
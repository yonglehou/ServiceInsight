﻿namespace Particular.ServiceInsight.Desktop.Models
{
    using System;
    using RestSharp.Deserializers;

    [Serializable]
    public class MessageBody : MessageInfo
    {
        public MessageBody()
        {
            HeaderRaw = new byte[0];
        }

        public int BodySize { get; set; }
        public string BodyUrl { get; set; }

        [DeserializeAs(Name = "Headers")]
        public byte[] HeaderRaw { get; set; }
        public string Body { get; set; }
    }
}
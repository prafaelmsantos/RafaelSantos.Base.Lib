﻿namespace Base.Lib.Kafka.Contracts
{
    public class MessageBase
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("content")]
        public required string Content { get; set; }
    }
}

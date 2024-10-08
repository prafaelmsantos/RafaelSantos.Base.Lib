﻿namespace Base.Lib.Kafka.Config
{
    public class KafkaConfig
    {
        public string Producers { get; set; } = null!;
        public string Consumers { get; set; } = null!;
        public bool Enable { get; set; } = false;
        public bool UseSSL_TLS { get; set; }
        public string Server { get; set; } = null!;
        public int Port { get; set; }
        public int RetryAttempts { get; set; }
        public string GroupId { get; set; } = null!;

        public KafkaConfig(
            string producers,
            string consumers,
            bool enable,
            bool useSSL_TLS,
            string server,
            int port,
            int retryAttempts,
            string groupId)
        {
            Producers = producers;
            Consumers = consumers;
            Enable = enable;
            UseSSL_TLS = useSSL_TLS;
            Server = server;
            Port = port;
            RetryAttempts = retryAttempts;
            GroupId = groupId;
        }
    }
}

﻿using System;
using System.Threading.Tasks;
using KoalaKit.Messaging.Queuing;

namespace KoalaKit.Messaging.Test.Models
{
    public class TestQueuingMessage : IQueuingMessage
    {
        public string QueueName { get; }
        public DateTime PublishingTimeUtc { get; set; }
    }

    public class TestQueuingMessageHandler : IMessagingHandler<TestQueuingMessage>
    {
        public Task<bool> HandleAsync(TestQueuingMessage message)
        {
            throw new NotImplementedException();
        }
    }
}

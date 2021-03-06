using System;
using MassTransit;

namespace TelusHeathPack.Messages
{
    public class OrderSubmitted : CorrelatedBy<string>
    {
        public string CorrelationId => Alias;
        public string Alias { get; set; }
        
        public Guid OrderId { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
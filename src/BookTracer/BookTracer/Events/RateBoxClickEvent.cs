using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracer.Events
{
    public class RateBoxClickEvent
    {
        public RateBox RateBox { get; set; }
        public object? Sender { get; set; }
        public RateBoxClickEvent(RateBox rateBox, object? sender)
        {
            RateBox = rateBox;
            Sender = sender;
        }
    }
    public enum RateBox
    {
        First = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5
    }
}

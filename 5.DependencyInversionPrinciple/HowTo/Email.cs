using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DependencyInversionPrinciple.HowTo
{
    public class Email : IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }

        public void SendMessage()
        {
            //Send email
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DependencyInversionPrinciple.HowTo
{
    public class SMS : IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }

        public void SendMessage()
        {
            //Send sms
        }
    }
}

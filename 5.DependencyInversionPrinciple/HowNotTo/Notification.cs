using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DependencyInversionPrinciple.HowNotTo
{
    public class Notification
    {
        private Email _email;
        private SMS _sms;

        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}

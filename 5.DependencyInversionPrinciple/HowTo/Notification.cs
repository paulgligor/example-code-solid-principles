﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DependencyInversionPrinciple.HowTo
{
    public class Notification
    {
        private ICollection<IMessage> _messages;

        public Notification(ICollection<IMessage> messages)
        {
            this._messages = messages;
        }
        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}

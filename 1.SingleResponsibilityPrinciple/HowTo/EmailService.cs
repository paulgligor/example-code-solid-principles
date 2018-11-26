using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SingleResponsibilityPrinciple.HowTo
{
    public class EmailService
    {
        public void Validate(string email)
        {
            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }
        }
    }
}

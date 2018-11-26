using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SingleResponsibilityPrinciple.HowNotTo
{
    public class InvitationService
    {
        public void SendInvite(string email, string firstName, string lastName)
        {
            if (String.IsNullOrWhiteSpace(firstName) || String.IsNullOrWhiteSpace(lastName))
            {
                throw new Exception("Name is not valid!");
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                throw new Exception("Email is not valid!!");
            }

            // sending email code
            Console.WriteLine($"How NOT to send an email to {firstName} {lastName} at {email}");
        }
    }
}

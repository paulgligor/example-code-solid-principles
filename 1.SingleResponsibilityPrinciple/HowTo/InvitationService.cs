using System;
using System.Collections.Generic;
using System.Text;

namespace _1.SingleResponsibilityPrinciple.HowTo
{
    public class InvitationService
    {
        UserNameService _userNameService;
        EmailService _emailService;

        public InvitationService(UserNameService userNameService, EmailService emailService)
        {
            _userNameService = userNameService;
            _emailService = emailService;
        }

        public void SendInvite(string email, string firstName, string lastName)
        {
            _userNameService.Validate(firstName, lastName);
            _emailService.Validate(email);

            // sending email code
            Console.WriteLine($"How to send an email to {firstName} {lastName} at {email}");
        }
    }
}

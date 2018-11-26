using System;

namespace _1.SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = "hi@paulgligor.com";
            var firstName = "Paul";
            var lastName = "Gligor";

            var howNotToInvitationService = new HowNotTo.InvitationService();
            howNotToInvitationService.SendInvite(email, firstName, lastName);


            var howToInvitationService = new HowTo.InvitationService(new HowTo.UserNameService(), new HowTo.EmailService());
            howToInvitationService.SendInvite(email, firstName, lastName);

            Console.ReadLine();
        }
    }
}

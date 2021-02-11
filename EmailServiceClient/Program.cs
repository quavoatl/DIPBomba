using System;
using UniversityEmailProcessor;

namespace EmailServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailService emailService = new UniversityEmailService();
            emailService.SendRequest("cacat");

        }
    }
}

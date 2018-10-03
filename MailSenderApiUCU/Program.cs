using System;

namespace MailSenderApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            MailSender mailSender = new MailSender("sender@domain.com", "<pasword>");
            bool sent = mailSender.EnviarMail("sender@domain", "<name>", "receiver@domain.com", "<Subject>", "<Body>");
            Console.WriteLine(sent ? "Enviado." : "No enviado.");
        }
    }
}

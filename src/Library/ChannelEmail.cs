using System;
using MailSenderApiUCU;

namespace Library
{
    public class ChannelEmail : IMessageChannel {
        MailSender mailSender = new MailSender ("<<Ingresar email>>","<<Ingresar contraseña>>");
        
        
        public void Send(Message message) 
        {
            mailSender.EnviarMail(message.From, "Mensaje de difusión", message.To, "Texto alternativo",  message.Text);
        }

        public Message CreateMessage(Contact fromPerson, Contact toPerson, string text)
        {
            return new MessageWhatsApp(fromPerson.Email, toPerson.Email, text);
        }
    }
}
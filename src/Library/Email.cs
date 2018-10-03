using System;
using MailSenderApiUCU;

namespace Library
{
    public class Email : IMessageChannel {
        MailSender mailSender = new MailSender ("<<Insetar dirección de email del remitente>>","<<Insertar contraseña de la cuenta de correo>>!");
        public void Send (Message message) 
        {
            mailSender.EnviarMail (message.From, "Mensaje de difusión", message.To, "Texto alternativo",  message.Text);
        }
        
    }
}
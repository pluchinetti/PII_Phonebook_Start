using System;
using WhatsAppApiUCU;

namespace Library
{
    public class ChannelWhatsApp : IMessageChannel {
        private const string accountSid = "ACfbd57f50e199a28eac49de4cc4acfb8a";
        private const string authToken = "81795970808380267013bf04070a5936";
        private WhatsAppApi whatsApp = new WhatsAppApi(accountSid, authToken);
        public void Send(Message message) 
        {
            this.whatsApp.Send(message.To, message.Text);
        }

        public Message CreateMessage(Contact fromPerson, Contact toPerson, string text)
        {
            return new MessageWhatsApp(fromPerson.Phone, toPerson.Phone, text);
        }

    }

}
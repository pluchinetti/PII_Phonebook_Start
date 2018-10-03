using System;
using WhatsAppApiUCU;

namespace Library
{
    public class WhatsApp : IMessageChannel {
        const string accountSid = "ACfbd57f50e199a28eac49de4cc4acfb8a";
        const string authToken = "81795970808380267013bf04070a5936";
        WhatsAppApi whatsApp = new WhatsAppApi(accountSid, authToken);
        public void Send(Message message) 
        {
            whatsApp.Send(message.To, message.Text);
        }

    }

}
using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace WhatsAppApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            const string accountSid = "";
            const string authToken = "";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send("+5989999999", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine(sid);
        }
    }
}

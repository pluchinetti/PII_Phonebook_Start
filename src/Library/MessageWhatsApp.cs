using System;
using System.Collections.Generic;

namespace Library
{
    public class MessageWhatsApp : Message
    {
        public MessageWhatsApp(string from, string to, string text)
        : base(from, to)
        {
            this.Text = text;
        }

    }
}
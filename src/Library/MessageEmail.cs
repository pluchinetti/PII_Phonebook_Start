using System;
using System.Collections.Generic;

namespace Library
{
    public class MessageEmail : Message
    {
        public MessageEmail(string from, string to, string text)
        : base(from, to)
        {
            this.Text = text;
        }

    }
}
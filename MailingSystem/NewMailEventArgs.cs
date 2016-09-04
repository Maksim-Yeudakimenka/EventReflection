using System;

namespace MailingSystem
{
    public class NewMailEventArgs : EventArgs
    {
        public NewMailEventArgs(string from, string to, string subject)
        {
            From = from;
            To = to;
            Subject = subject;
        }

        public string From { get; }

        public string To { get; }

        public string Subject { get; }
    }
}
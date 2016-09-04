using System;

namespace MailingSystem
{
    public class MailManager
    {
        public event EventHandler<NewMailEventArgs> NewMail;

        protected virtual void OnNewMail(NewMailEventArgs e)
        {
            NewMail?.Invoke(this, e);
        }

        public void SimulateNewMail(string from, string to, string subject)
        {
            OnNewMail(new NewMailEventArgs(from, to, subject));
        }
    }
}
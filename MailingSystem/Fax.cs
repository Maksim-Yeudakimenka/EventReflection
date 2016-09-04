using System;

namespace MailingSystem
{
    public class Fax
    {
        private void FaxMsg(object sender, NewMailEventArgs eventArgs)
        {
            Console.WriteLine("Faxing mail message:");
            Console.WriteLine($"From = {eventArgs.From}, To = {eventArgs.To}, Subject = {eventArgs.Subject}");
        }
    }
}
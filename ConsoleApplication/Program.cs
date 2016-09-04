using System;
using EventReflection;
using MailingSystem;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new MailManager();
            var fax = new Fax();

            EventRegistrar.RegisterEvent(manager, "NewMail", fax, "FaxMsg");

            manager.SimulateNewMail("Minsk", "Riga", "Letter");

            Console.ReadKey();
        }
    }
}
using System;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Large systems should not depend on small systems, small systems should depend on large systems.
             */

            Report report = new Report(new MailSender());
            Report wsReport = new Report(new WhatsappSender());
        }

    }

    public class Report
    {
        private ISender sender;
        public Report(ISender sender)
        {
            this.sender = sender;
        }
        public void Send()
        {
            sender.Send();
        }
    }

    public interface ISender
    {
        void Send();
    }

    public class MailSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Email Sended!");
        }
    }

    public class WhatsappSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Whatsapp Message Sended!");
        }
    }
}

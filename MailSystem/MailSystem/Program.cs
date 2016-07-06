using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //  7. Create an instance of MailManager and connect to the MailArrived event. 
            MailManager mailManager = new MailManager();
            
            mailManager.MailArrived += MailArrived;

            mailManager.SimulateMailArrived("First calling", "This is the first call to the event.");
            mailManager.SimulateMailArrived("London calling", "The Clash (1979).");

            // 10. (*)Create a System.Threading.Timer:
            Console.WriteLine("\nUsing the \"Timer\" for events:\n");
            Timer timer = new Timer((o) => {
                mailManager.SimulateMailArrived("Scheduled Message", "This is a scheduledm message");
            }, null, TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));

            Console.ReadLine();
        }

        static void MailArrived(object sender, MailArrivedEventArgs e)
        {
            Console.Write("({0:HH:mm:ss}):\t", DateTime.Now);
            Console.WriteLine("Message title: {0};\t Message body: {1}", e.Title, e.Body);
        }
    }
}

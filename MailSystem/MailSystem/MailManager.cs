using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSystem
{
    class MailManager
    {
        public event EventHandler<MailArrivedEventArgs> MailArrived;

        protected virtual void OnMailArrived(MailArrivedEventArgs e)
        {
            if (MailArrived != null)
            {
                MailArrived(this, e);
            }
        }

        public void SimulateMailArrived(string title, string body)
        {
            OnMailArrived(new MailArrivedEventArgs(title, body));
        }
    }

    public class MailArrivedEventArgs
    {
        public string Title { get; private set; }
        public string Body { get; private set; }

        public MailArrivedEventArgs(string title, string body)
        {
            Title = title;
            Body = body;
        }
    }
}

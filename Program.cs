using System;
using System.Threading;
using Microsoft.Toolkit.Uwp.Notifications;

namespace MyToastNofify
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 4)
                return;

            string title = string.Empty;
            string message = string.Empty;

            for (int i = 0, max = args.Length; i < max; i++)
            {
                if (args[i].Equals("--title"))
                {
                    title = args[i + 1];
                }
                if (args[i].Equals("--message"))
                {
                    message = args[i + 1];
                }
            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(message))
                return;

            new MyNotification().Run(title, message);
            Thread.Sleep(1);
        }
    }

    public class MyNotification
    {
        public void Run(string title, string message)
        {
            var toast = new ToastContentBuilder();
            toast.AddText(title);
            toast.AddText(message);
            toast.Show();
        }
    }
}

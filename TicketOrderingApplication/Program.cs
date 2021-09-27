using System;

namespace TicketOrderingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            AppManager manager = new AppManager();
            manager.MainMenuLoop();
        }
    }
}

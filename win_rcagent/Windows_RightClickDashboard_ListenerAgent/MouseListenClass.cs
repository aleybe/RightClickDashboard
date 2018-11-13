using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_RightClickDashboard_ListenerAgent
{
    class MouseListenClass
    {

        public static void ListenForMouseClicks()
        {
            Console.WriteLine("listening...");

            Hook.GlobalEvents().MouseDown += async (sender, e) =>
            {
                Console.WriteLine($"Mouse {e.Button} down");
            };
        }

    }
}

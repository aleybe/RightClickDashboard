using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_RightClickDashboard_ListenerAgent
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            MouseListenClass.ListenForMouseClicks();

            Application.Run(new ApplicationContext());
            
        }


    }
}

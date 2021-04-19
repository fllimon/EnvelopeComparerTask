using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvelopeView
{
    class Menu
    {
        public UserAction GetUserChoise()
        {
            UserAction result = UserAction.NoAction;

            switch (Console.ReadKey(true).Key)
            {  
                case ConsoleKey.Enter:
                    result = UserAction.Enter;
                    break;
                case ConsoleKey.Escape:
                    result = UserAction.Exit;
                    break;
              
                default:
                    break;
            }

            return result;
        }
    }
}

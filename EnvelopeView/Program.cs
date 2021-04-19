using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EnvelopeComparerLib; 

namespace EnvelopeView
{
    class Program
    {
        static void Main(string[] args)
        {
            Envelope firstEnvelope = new Envelope(10, 15);
            Envelope secondEnvelope = new Envelope(12, 18);
            UserAction action = UserAction.NoAction;
            Menu uiMenu = new Menu();
            EnvelopeComparer comparer = new EnvelopeComparer();

            int result = comparer.Compare(firstEnvelope, secondEnvelope);

            do
            {
                action = uiMenu.GetUserChoise();

                switch (action)
                {
                    case UserAction.Enter:
                        break;
                    default:
                        break;
                }
            } while (action != UserAction.Exit);
        }
    }
}

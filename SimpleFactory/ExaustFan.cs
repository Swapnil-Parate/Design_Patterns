using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    class ExaustFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("ExaustFan SwtichOff");
        }

        public void SwitchOn()
        {
            Console.WriteLine("ExaustFan SwitchOn");
        }
    }
}

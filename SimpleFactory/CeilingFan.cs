using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    class CeilingFan : IFan
    {
        public void SwitchOff()
        {
            Console.WriteLine("CeilingFan SwitchOff");
        }

        public void SwitchOn()
        {
            Console.WriteLine("CeilingFan SwitchOn");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    class TableFan : IFan
    {
       
        public void SwitchOff()
        {
            Console.WriteLine("TableFan Switch Off");
        }

        public void SwitchOn()
        {
            Console.WriteLine("TableFan Switch On");
        }
    }
}

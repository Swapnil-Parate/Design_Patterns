using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    class FanFactory : IFanFactory
    {
        public IFan CreateFan(FanType type)
        {
            switch (type)
            {

                case FanType.tableFan:
                    return new TableFan();
                case FanType.ceilingFan:
                    return new CeilingFan();
                case FanType.exaustFan:
                    return new ExaustFan();
                default:
                    return new TableFan();

            }

            
        }
    }
}

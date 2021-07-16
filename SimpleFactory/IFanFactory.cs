using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SimpleFactory
{
    interface IFanFactory
    {
        IFan CreateFan(FanType type);
    }
}

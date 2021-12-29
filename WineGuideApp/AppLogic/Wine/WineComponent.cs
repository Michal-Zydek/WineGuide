using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic
{
    public abstract class WineComponent
    {
        public WineComponent() { }

        public virtual string TestWine()
        {
            return "Test Component Wine";
        }

    }
}

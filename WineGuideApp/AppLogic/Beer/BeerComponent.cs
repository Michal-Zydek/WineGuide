using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic.Beer
{
    public abstract class BeerComponent
    {
        public virtual string TestBeer()
        {
            return "Test Component Beer";
        }

    }
}

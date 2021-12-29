using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic.Beer
{
    public class PorterBeer :BeerComponent
    {
        public override string TestBeer()
        {
            return "Super PorterBeer";
        }
    }
}

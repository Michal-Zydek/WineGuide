using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic.Beer
{
    public class LagerBeer :BeerComponent
    {
        public override string TestBeer()
        {
            return "Super LagerBeer";
        }
    }
}

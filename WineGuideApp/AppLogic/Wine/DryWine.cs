using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic
{
    public class DryWine : WineComponent
    {
        public override string TestWine()
        {
            return "Super DryWine";
        }
    }
}

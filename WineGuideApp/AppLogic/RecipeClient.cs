using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineGuideApp.AppLogic
{
    public class RecipeClient
    {
        public SweetWine CreateWine (SweetWine sweetWine)
        {
            return new SweetWine();
        }

        public MediumSweetWine CreateWine(MediumSweetWine sweetWine)
        {
            return new MediumSweetWine();
        }
    }
}

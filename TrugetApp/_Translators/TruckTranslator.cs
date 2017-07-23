using System;
using Truget.Data.Models;
using Truget.Infrastructure.Library.EntityTranslator;
using Truget.Infrastructure.Library.EntityTranslator.Interfaces;
using TrugetApp.Models;

namespace TrugetApp.Translators
{
    public class TruckTranslator : EntityMapperTranslator<TruckModel, Truck>
    {
        protected override Truck BusinessToService(TruckModel from)
        {
            var to = new Truck();
            if (from != null)
            {

            }
            return to;
        }

        protected override TruckModel ServiceToBusiness(Truck from)
        {
            var to = new TruckModel();
            if (from != null)
            {

            }
            return to;
        }
    }

}

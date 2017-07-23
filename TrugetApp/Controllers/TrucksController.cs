using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Truget.Data;
using TrugetApp.Models;
using Truget.Data.Models;
using Truget.Infrastructure.Library.Services;
using Truget.Infrastructure.Library.EntityTranslator.Interfaces;

namespace TrugetApp.Controllers
{
    public class TrucksController : Controller
    {
        private ITrucksContext _trucksContext;
        private readonly IEntityTranslatorService _translator;

        public TrucksController(ITrucksContext trucksContext, IEntityTranslatorService translator)
        {
            _translator = translator;
            _trucksContext = trucksContext;
        }

        private void InitData()
        {
            #region Trucks types
            var types = new List<TruckType>
            {
                new TruckType { TypeName = "Close" },
                new TruckType { TypeName = "Pickup" },
                new TruckType { TypeName = "Box" },
                new TruckType { TypeName = "Flatbed" },
                new TruckType { TypeName = "MobileCrane" },
                new TruckType { TypeName = "Dump" },
                new TruckType { TypeName = "LogCarrier" },
                new TruckType { TypeName = "Refrigerator" },
                new TruckType { TypeName = "TractorUnit" },
                new TruckType { TypeName = "Tank" },
                new TruckType { TypeName = "BallastTractor" },
                new TruckType { TypeName = "Haul" }
            };
            #endregion
            #region Trucks sizes
            var sizes = new List<TruckSize>
            {
                new TruckSize { SizeName = "Light" },
                new TruckSize { SizeName = "Medium" },
                new TruckSize { SizeName = "Heavy" },
                new TruckSize { SizeName = "VeryHeavy" }
            };

            #endregion

            _trucksContext.AddManyTruckType(types);
            _trucksContext.AddManyTruckSize(sizes);
        }

        public IActionResult Index()
        {
            TruckModel tm = new TruckModel();
            Truck t = new Truck();
            t = _translator.Translate<Truck>(tm);
            tm = _translator.Translate<TruckModel>(t);
            ViewData["TruckTypes"] = _trucksContext.GetAllTruckTypes();
            ViewData["TruckSizes"] = _trucksContext.GetAllTruckSizes();
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Truget.Data.Models;

namespace Truget.Data
{
    public interface ITrucksContext
    {
        Truck GetTrackById(long id);
        List<Truck> GetAllTrucks();
        List<TruckType> GetAllTruckTypes();
        List<TruckSize> GetAllTruckSizes();
        List<Truck> GetCompanyTrucks(int companyId);

        void Add(Truck model);
        void AddMany(List<Truck> model);

        void AddTruckType(TruckType model);
        void AddTruckSize(TruckSize model);

        void AddManyTruckType(List<TruckType> model);
        void AddManyTruckSize(List<TruckSize> model);
    }
}

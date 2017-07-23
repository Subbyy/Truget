using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Truget.Data;
using Truget.Data.Models;

namespace Truget.Services
{
    public interface ITrucksService : ITrucksContext
    {
    }

    public class TrucksService : ITrucksService
    {
        private TrucksContext _context;

        public TrucksService(TrucksContext context)
        {
            _context = context;
        }

        public void Add(Truck model)
        {
            _context.Trucks.Add(model);
            _context.SaveChangesAsync();
        }

        public void AddMany(List<Truck> model)
        {
            _context.Trucks.AddRange(model);
            _context.SaveChanges();
        }

        public void AddManyTruckSize(List<TruckSize> model)
        {
            _context.TruckSizes.AddRange(model);
            _context.SaveChanges();

        }

        public void AddManyTruckType(List<TruckType> model)
        {
            _context.TruckTypes.AddRange(model);
            _context.SaveChanges();
        }

        public void AddTruckSize(TruckSize model)
        {
            _context.TruckSizes.Add(model);
            _context.SaveChanges();
        }

        public void AddTruckType(TruckType model)
        {
            _context.TruckTypes.Add(model);
            _context.SaveChanges();
        }

        public List<Truck> GetAllTrucks()
        {
            return _context.Trucks
                           .Include(ctx => ctx.Company)
                           .ToList();
        }

        public List<TruckSize> GetAllTruckSizes()
        {
            return _context.TruckSizes.ToList();
        }

        public List<TruckType> GetAllTruckTypes()
        {
            return _context.TruckTypes.ToList();
        }

        public List<Truck> GetCompanyTrucks(int companyId)
        {
            return _context.Trucks
                           .Include(ctx => ctx.Company)
                           .Where(x => x.Company.Id == companyId).ToList();
        }

        public Truck GetTrackById(long id)
        {
            return _context.Trucks
                           .FirstOrDefault(x => x.Id == id);
        }
    }
}

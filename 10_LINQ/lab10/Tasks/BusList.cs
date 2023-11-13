using System.Collections.Generic;
using System.Linq;

namespace lab10.Tasks
{
    internal class BusList
    {
        public List<Bus> Buses { get; private set; }

        public BusList()
        {
            Buses = new List<Bus>();
        }

        public void AddBus(Bus bus)
        {
            Buses.Add(bus);
        }
        
        public List<Bus> GetBusesByRouteNum(string route) => Buses.Where(bus => bus.RouteNum == route).ToList();

        public List<Bus> GetBusesUsedMorePeriod(int yearExploitation) => Buses.Where(bus => bus.YearExploitation > yearExploitation).ToList();

        public Bus GetBusByMinMileage() => Buses.OrderBy(bus => bus.Mileage).First();

        public List<Bus> GetLatestBusesWithMaxMileage() => (List<Bus>)Buses.OrderByDescending(bus => bus.Mileage).Take(2).ToList();

        public List<Bus> GetBusesOrderedByNum() => Buses.OrderBy(bus => bus.BusNumber).ToList();
    }
}

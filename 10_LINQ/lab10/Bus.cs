using System;

namespace lab10
{
    public class Bus
    {
        private string _brandBus;
        private int _busNumber;
        private string _driverFullName;
        private double _mileage;
        private string _routeNum;
        private int _yearExploitation;
        private readonly int _id;
        private static int _count;
        private const int _myConst = 1;
        
        public string BrandBus
        {
            get { return _brandBus; }
            private set { _brandBus = value; }
        }
        
        public int BusNumber
        {
            get { return _busNumber; }
            set { _busNumber = value; }
        }

        public string DriverFullName
        {
            get { return _driverFullName; }
            set { _driverFullName = value; }
        }

        public double Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }

        public string RouteNum
        {
            get { return _routeNum; }
            set { _routeNum = value; }
        }

        public int YearExploitation
        {
            get { return _yearExploitation; }
            set { _yearExploitation = value; }
        }

        private static int Count
        {
            get { return _count; }
        }

        public int Id
        {
            get { return _id; }
        }

        public Bus()    
        {
            BrandBus = "";
            BusNumber = 0;
            DriverFullName = "";
            Mileage = 0;
            RouteNum = "";
            YearExploitation = 0;
        }
        
        public Bus(string driverFullName, int busNumber, string routeNum, string brandBus, int yearExploitation,
            double mileage)
        {
            DriverFullName = driverFullName;
            BusNumber = busNumber;
            RouteNum = routeNum;
            BrandBus = brandBus;
            YearExploitation = yearExploitation;
            Mileage = mileage;
            _id = GetHashCode();
        }
        
        public Bus(string brandBus, int yearExploitation = 10, double mileage = 13477.5)
        {
            BrandBus = brandBus;
            YearExploitation = yearExploitation;
            Mileage = mileage;
        }
        
        static Bus()
        {
            _count++;
        }
        
        public void ShowCount()
        {
            Console.WriteLine(Count);
        }

        public string GetBusInfo(ref string driverName, ref int busNumber, out string result)
        {
            result = driverName + Convert.ToString(busNumber);
            return result;
        }

        public override string ToString()
        {
            return $"Марка: {BrandBus}, Номер: {BusNumber}, ФИО водителя: {DriverFullName}," +
                $" Пробег: {Mileage}, Номер маршрута: {RouteNum}, Срок эксплуатации: {YearExploitation}";
        }
    }
}
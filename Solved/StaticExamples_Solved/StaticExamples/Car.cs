using System;

namespace StaticExamples
{
    public class Car
    {
        private static int _noOfCarsObjectsCreated = 0;
        private static int _noOfCallsToLicensePlate = 0;
        private static int _noOfCallsToPrice = 0;

        private string _licensePlate;
        private int _price;

        public string LicensePlate
        {
            get
            {
                _noOfCallsToLicensePlate++;
                return _licensePlate;
            }
            set
            {
                _noOfCallsToLicensePlate++;
                _licensePlate = value;
            }
        }

        public int Price
        {
            get
            {
                _noOfCallsToPrice++;
                return _price;
            }
            set
            {
                _noOfCallsToPrice++;
                _price = value;
            }
        }

        public static void PrintUsageStatistics()
        {
            Console.WriteLine("Cars objects created : {0}", _noOfCarsObjectsCreated);
            Console.WriteLine("Use of LicensePlate property: {0}", _noOfCallsToLicensePlate);
            Console.WriteLine("Use of Price property: {0}", _noOfCallsToPrice);
        }


        public Car(string licensePlate, int price)
        {
            _noOfCarsObjectsCreated++;
            _licensePlate = licensePlate;
            _price = price;
        }
    }
}
using System;

namespace WeatherStationV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Barometer theBarometer = new Barometer();

            theBarometer.Pressure = 975;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 985;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 995;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 1005;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 1015;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 1025;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 1035;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            theBarometer.Pressure = 1045;
            Console.WriteLine("Pressure is {0} : {1}", theBarometer.Pressure, theBarometer.WeatherDescription);

            // The LAST line of code should be ABOVE this line
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uber
{
    internal class UberSystem
    {
        private static int RideCounter;
        private static double TotalEarning;
        private static double Surge;
        private static double BaseFare;

        public string RideId {  get; private set; }
        public string DriverName { get; set; }
        public string PassengerName { get; set; }
        public double DistanceKm { get; set; }
        public double Fare { get; set; }



        static UberSystem()
        {
            Console.WriteLine("Uber System Initialized. Ready to book rides...\n");
            RideCounter = 1000;
            TotalEarning = 0;
            Surge = 1;
            BaseFare = 50;

        }

        public double FareCalculator(double distance)
        {
            return BaseFare + (distance * 15 * Surge);
        }

        public UberSystem(string driverName,string passengerName,double distance) {

            RideId = $"Ride_{RideCounter++}";
            DriverName = driverName;
            PassengerName = passengerName;
            DistanceKm = distance;
            Fare = FareCalculator(distance);
            TotalEarning += Fare;
        }

        public static void SurgeMultiplier(double surge)
        {
            Surge = surge;
            Console.WriteLine($"surge increased by {surge}");
        }

        public static void RideSummary()
        {
            Console.WriteLine($"Total Rides: {RideCounter-1000}\nTotal Earnings: {TotalEarning}");
        }


        public void RideDetails()
        {
            Console.WriteLine($"Ride ID: {RideId}\nPassenger Name: {PassengerName}\nDriver Name: {DriverName}\nDistance Traveled: {DistanceKm}\nFare: {Fare}\n\n");
        }
    }
}

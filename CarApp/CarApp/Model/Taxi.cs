using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model;

    class Taxi : Car
    {
        public double StartPrice { get; set; }
        public double PricePerKm { get; set; }
        public double PricePerMinute { get; set; }
        public bool MeterStarted { get; set; }

        public void StartMeter()
        {
            MeterStarted = true;
        }

        public void StopMeter()
        {
            MeterStarted = false;
        }

        public double CalculateFare(double distance, double time)
        {
            if (MeterStarted)
            {
                return StartPrice + (PricePerKm * distance) + (PricePerMinute * time);
            }
            else
            {
                return 0;
            }
        }

        public override bool CanDrive()
        {
            return IsEngineOn && (MeterStarted || Odometer > 0);
        }

        public override void UpdateEnergyLevel(double distance)
        {
        
        }

        public override double CalculateConsumption(double distance)
        {
            return 0;
        }
    }




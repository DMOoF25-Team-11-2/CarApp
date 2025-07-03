using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary.Models;

public class Car : IDrivable
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public string LicensePlate { get; set; }

    public int Odometer { get; set; }

    public bool IsEngineRunning { get; set; }


    public void Drive(double km) 
    {
        
    }

    public bool CanDrive(double km) 
    {
        return true;
    }


    public void StartEngine() => IsEngineRunning = true;

    public void StopEngine() => IsEngineRunning = false;


    public override string ToString()

    {

        return $"{Brand},{Model},{LicensePlate},{Odometer}";

    }
}

using System;

namespace VantageClass
{
    public class Vantage
    {
        public int HorsePower { get; }
        public int Weight { get; }
        public int MaxSpeed { get; }
        public int NowSpeed { get; private set; } = 0;
        public int NowTransmission { get; private set; } = 0;
        public string Color { get; set; } = "White";
        public string ModelName { get; set; } = "Vantage";
        public bool DoesEngeneWorks { get; private set; } = false;
        public Vantage(int HorsePower, int Weight, int MaxSpeed)
        {
            HorsePower = HorsePower;
            Weight = Weight;
            MaxSpeed = MaxSpeed;
        }
        public void EngeneTurnsOn()
        {
            NowTransmission = 0;
            if (NowTransmission > 0)
            {
                Console.WriteLine("Car stalled");
                throw new Exception("Car stalled");
            }
            DoesEngeneWorks = true;
            Console.WriteLine("The car is on");
        }
        public void ChangeTransmission(var SelectableGear)
        {
            if ((SelectableGear + 1 = NowTransmission) || (SelectableGear - 1 = NowTransmission))
            {
                NowTransmission = SelectableGear;
                Console.WriteLine($"The gear has changed, now it is{NowTransmission}");
                return;
            }
            throw new Exception("Car stalled");
        }
        public void TurnOffTheCar()
        {
            DoesEngeneWorks = false;
            Console.WriteLine("The car is off");
        }
        public void StepOnTheGas()
        {
            NowSpeed += 10;
            Console.WriteLine($"The car has increased speed: now it is {NowSpeed} km/h");
        }
        public void SlowDown()
        {
            NowSpeed -= 10;
            Console.WriteLine($"The car has slow down: now her speed is {NowSpeed} km/h");
        }
    }
}
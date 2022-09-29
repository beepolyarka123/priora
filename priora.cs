using System;

namespace priora
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine();
            Priora priora1;
            priora1 = new Priora();
            priora1.Horselevels = 100;
            priora1.level = 0;
            priora1.IsStarted = false;
            priora1.Rotate = 0;
            priora1.Speed = priora1.Rotate;
        }
    }
    class Priora
    {
        public int Horselevels = 100;
        public int SeatsCount = 4;
        public int YearOut = 2010;
        public string Color = "Red";
        public bool IsStarted = true;
        public int level = 5;
        public int Rotate = 2000;
        public int Speed = 100;  
    }
    public void Start()
    {
        Console.WriteLine("Wrumm");
    }
    
}

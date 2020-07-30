using System;

namespace Chapter3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
         
            var transfomer = new Transfomer() {Type ="Boat" };

            if (transfomer.Type == "Air")
            {
                transfomer = new Jet()
                {
                    Wheels = 8,
                    Speed = 400
                };
                Console.WriteLine(string.Format("When transformer is on air Wheels :{0} Max Speed: {1}", transfomer.Wheels, transfomer.Speed));
            }
            else if(transfomer.Type == "Car")
            {
                transfomer = new Jet()
                {
                    Wheels = 4,
                    Speed = 100
                };
                Console.WriteLine(string.Format("When transformer is on road :{0} Max Speed: {1}", transfomer.Wheels, transfomer.Speed));
            }
            else if (transfomer.Type == "Boat")
            {
                transfomer = new Jet()
                {
                    Wheels = 0,
                    Speed = 200
                };
                Console.WriteLine(string.Format("When transformer is on water :{0} Max Speed: {1}", transfomer.Wheels, transfomer.Speed));
            }
            Console.ReadLine();
        }
    }
}

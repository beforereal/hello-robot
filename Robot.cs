using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hello_robot
{
    public class Robot
    {
        private const double SPEED = 0.25;

        private string currentLocation = "";

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Alpha1 { get; private set; }
        public double Aplha2 { get; private set; }

        public double TargetX { get; private set;}

        public double TargetY { get; private set;}

        public void SetDirection(double newTargetX, double newTargetY) {
            TargetX = newTargetX;
            TargetY = newTargetY;
        }

        public void Move()
        {
            while(X < TargetX || Y < TargetY)
            {
                if (X < TargetX)
                {
                    X += SPEED;
                    currentLocation += " ";
                }
                if (Y < TargetY)
                {
                     Y += SPEED;
                    currentLocation += " ";
                }

                PrintLocation();
            }

           
        }

        public void PrintLocation () {
            
            if (X < TargetX || Y < TargetY)
            {
                Console.WriteLine(currentLocation += "."); 
            }
            else
            {
                Console.WriteLine("*");
            }
            var simulationSpeed = SPEED * 1_000.00;
            Thread.Sleep(Convert.ToInt32(simulationSpeed));
        }
    }
}
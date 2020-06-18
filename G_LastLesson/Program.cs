using System;

namespace Home.Learning.DelegateLessons
{
    class Car
    {
        int speed = 0;


        public event Action<int> TooFastDriving;
        public event Action StopoDriving;
        public event Action AccelerateCar;

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;

            if (AccelerateCar != null)
                AccelerateCar();

            if (speed > 80)
            {
                if (TooFastDriving != null)
                    TooFastDriving(speed);
            }
        }

        public void Stop()
        {
            speed = 0;
            if (StopoDriving != null)
                StopoDriving();
        }

    }

    class Program
    {
        static Car car;
        static void Main(string[] args)
        {
            car = new Car();
            car.TooFastDriving += HandleOnTooFast;
            car.StopoDriving += HandleOnStopDriving;
            car.AccelerateCar += HandleOnAccelerateCar;


            car.Start();

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate();
            }
        }

        private static void HandleOnTooFast(int currentSpeed)
        {
            Console.WriteLine($"Delegate message! You move too fast! Your speed is {currentSpeed}");
            car.Stop();
        }

        private static void HandleOnStopDriving()
        {
            Console.WriteLine($"Car is stopped! Current speed is 0");
        }

        private static void HandleOnAccelerateCar()
        {
            Console.WriteLine($"Let GO faster!!!");
        }
    }
}

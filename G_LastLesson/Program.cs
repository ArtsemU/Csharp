namespace G_LastLesson
{
    public class Car
    {
        int speed = 0;

        public delegate void TooFast();

        public void Start()
        {
            speed = 10;
        }

        public void Accelerate()
        {
            speed += 10;
        }

        public void Stop()
        {
            speed = 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Start();

            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
            car.Accelerate();
        }
    }
}

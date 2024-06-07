namespace ThorsCars
{
    internal class Engine
    {
        private double carEngine;

        public Engine(double carEngine)
        {
            this.carEngine = carEngine;
        }

        public double GetCarEngine()
        {
            return carEngine;
        }
    }
}

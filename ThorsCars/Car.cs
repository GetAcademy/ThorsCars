namespace ThorsCars
{
    internal class Car
    {
        public Model Model { get; set; }
        public Engine Engine { get; set; }
        public int Year { get; set; }

        private string _regNo;
        private int _kilometers;

        public Car(Model model, Engine engine, int year)
        {
            Model = model;
            Engine = engine;
            Year = year;
        }
        public void DisplayCarInfo()
        {
            Model.DisplayInfo();
            Console.WriteLine("Car Engine: " + Engine.GetCarEngine());
            Console.WriteLine("Car Year: " + Year);
        }
    }
}

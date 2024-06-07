namespace ThorsCars
{
    internal class Model
    {
        private string _carModel;
        private Brand _brand;

        public Model(string carModel, Brand brand)
        {
            _carModel = carModel;
            _brand = brand;
            brand.AddModel(this);
        }

        public string GetCarModel()
        {
            return _carModel;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Car Brand: " + _brand.GetCarBrand());
            Console.WriteLine("Car Model: " +_carModel);
        }
    }
}

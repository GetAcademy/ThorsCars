namespace ThorsCars
{
    internal class Brand
    {
        private string carBrand;
        List<Model> _models;

        public Brand(string carBrand)
        {
            this.carBrand = carBrand;
            _models = new List<Model>();
        }

        public string GetCarBrand()
        {
            return carBrand;
        }

        public void AddModel(Model model) {
            _models.Add(model);
        }

        public void ListAllModels()
        {
            foreach (var model in _models)
            {
                model.DisplayInfo();
            }
        }
    }
}

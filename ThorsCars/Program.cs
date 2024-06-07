using ThorsCars;

List<Car> cars = new List<Car>();

var toyotaBrand = new Brand("Toyota");
var mercedesBrand = new Brand("Mercedes");

var modelCorolla = new Model("Corolla", toyotaBrand);
cars.Add(new Car( modelCorolla,new Engine(1.6), 2020));
cars.Add(new Car( new Model("Benz", mercedesBrand),new Engine(2.0), 2018));
cars.Add(new Car( new Model("Camri", toyotaBrand), new Engine(1.8), 2018));

toyotaBrand.ListAllModels();

//foreach (Car car in cars)
//{
//    car.DisplayCarInfo();
//    Console.WriteLine();
//}
Console.ReadKey();
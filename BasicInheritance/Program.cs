using BasicInheritance;

Console.WriteLine("******Herança básica********\n");
//Fazendo um objeto carro 

Car myCar = new Car(80) { Speed = 50 };

Console.WriteLine($"Carro está a {myCar.Speed} km/h");

MiniVan myVan = new MiniVan();
myVan.Speed = 50;
Console.WriteLine(myVan.Speed);

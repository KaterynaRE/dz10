using cl1;
using cl2;
using cl3;
using cl4;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz10
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Завдання 
			//Створіть клас «Океанаріум» з інформацією про «мешканців» Океанаріуму
			//Створіть клас для кожної істоти Океанаріуму
			//.Вони мають містити інформацію про кожну морську істоту.
			//Реалізуйте підтримку ітератора для класу «Океанаріум».
			//Протестуйте можливість використання foreach для Океанаріуму

			//Sirenes sirenes = new Sirenes("Sirenes", "half-fish, half-woman", "lived on fairy islands", "silver");
			//BlueWhale blueWhale = new BlueWhale("BlueWhale", "chordal", "tropical seas", "blue");

			//Oceanarium oceanarium = new Oceanarium("Oceanarium", "Various", "Marine");

			//oceanarium.AddResident(sirenes);
			//oceanarium.AddResident(blueWhale);

			//foreach (var resident in oceanarium)
			//{
			//	Console.WriteLine($"Name: {resident.Name}, Species: {resident.Species}, Habitat: {resident.Habitat}");
			//	if (resident is Sirenes sirenesResident)
			//	{
			//		Console.WriteLine($"Color: {sirenesResident.GetColor()}\n");
			//	}
			//	else
			//	{
			//		BlueWhale blueWhaleResident = (BlueWhale)resident;
			//		Console.WriteLine($"Color: {blueWhaleResident.GetColor()}\n");
			//	}
			//}

			//Завдання 2 (Такий підхід підходе для простих списків, а той що вище для складніших колекцій)
			//Створіть клас «Футбольна Команда». Клас має містити нформацію про гравців футбольної команди.
			//Реалізуйте підтримку ітератора для класу «Футбольна Команда».
			//Протестуйте можливість використання foreach для класу
			//«Футбольна Команда»

			//FootballTeam FootballTeam1 = new FootballTeam();
			//int countP = 1;
			//foreach (PlayerFootball player in FootballTeam1)
			//{
			//	Console.WriteLine($"\nPlayer:{countP++} {player}");
			//}


			//Завдання 3
			//Створіть клас «Кафе» з інформацією про працівників кафе.
			//Реалізуйте підтримку ітератора для класу «Кафе».
			//Протестуйте можливість використання foreach для «Кафе»

			// Створення працівників
			CafeEmployee employee1 = new CafeEmployee("John", "Doe", 123456);
			CafeEmployee employee2 = new CafeEmployee("Jane", "Smith", 2323243);

			// Створення інформації про кафе
			CafeInfo cafe1 = new CafeInfo("Viktoria", "Kushugum");

			// Створення об'єкту CafeData і додавання працівників до нього
			CafeData cafeData1 = new CafeData(cafe1);
			cafeData1.AddPersonal(employee1);
			cafeData1.AddPersonal(employee2);

			// Створення кафе та додавання інформації про кафе до нього
			Cafe Vikttoria = new Cafe();
			Vikttoria.AddCafeData(cafeData1);

			foreach (var cafeData in Vikttoria)
			{
				Console.WriteLine($"Cafe: {cafeData.CafeInfo.NameCafe}, Location: {cafeData.CafeInfo.Location}");

				foreach (var employee in cafeData.Employees)
				{
					Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, INN: {employee.INN}");
				}
			}


			//Додаткове завдання 4
			//Создайте класс «Автомобиль».
			//Создайте коллекцию-список для хранения определённого количества автомобилей.
			//Выполните сортировку автомобилей по стоимости.
			//Для этого разработайте класс class Comp : IComparer where T : Car, который будет реализовывать	
			//интерфейс IComparer и будет иметь единственный метод для сравнения цен 2-х автомобилей.

			List<Car> cars = new List<Car>
			{
				new Car("Toyota", "auto", "Gasoline", "Red", 65000),
				new Car("BMW", "auto", "Diesel", "Black", 45000),
				new Car("Mercedes", "mehanick", "Gasoline", "White", 55000)
			};

			foreach (var car in cars)
			{
				Console.WriteLine($"Car brand: {car.BrandName}, BoxType: {car.BoxType}, " +
					$"FuelType: {car.FuelType},Color: {car.Color}, Price: {car.Price} ");
			}

			Comp<Car> comparer = new Comp<Car>();
			cars.Sort(comparer);
			Console.WriteLine("\nCars after sort:\n");

			foreach (var car in cars)
			{
				Console.WriteLine($"Car brand: {car.BrandName}, BoxType: {car.BoxType}, " +
					$"FuelType: {car.FuelType},Color: {car.Color}, Price: {car.Price} ");
			}


		}
	}
}

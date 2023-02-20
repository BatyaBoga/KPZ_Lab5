using PrototypeBilder;

namespace KPZ_Lab5 { 
public class Program
    {
    static void Main(string[] args)
    {
    // Створюємо прототип будівлі
    ConcreteBuildingPrototype prototype = new ConcreteBuildingPrototype();

    // Створюємо директора будівельника з використанням прототипу
    BuildingDirector director = new BuildingDirector(prototype);

    // Задаємо параметри будівлі через директора
    director.SetName("Будинок 1");
    director.SetFloors(10);
    director.SetArea(500);

    // Створюємо перший будинок шляхом клонування прототипу через директора
    BuildingPrototype building1 = director.GetBuilding();

    // Задаємо параметри для другого будинку
    director.SetName("Будинок 2");
    director.SetFloors(5);
    director.SetArea(250);

    // Створюємо другий будинок шляхом клонування прототипу через директора
    BuildingPrototype building2 = director.GetBuilding();

    // Виводимо інформацію про створені будинки
    Console.WriteLine("Перший будинок: {0}, {1} поверхів, {2} кв. м", building1.Name, building1.Floors, building1.Area);
    Console.WriteLine("Другий будинок: {0}, {1} поверхів, {2} кв. м", building2.Name, building2.Floors, building2.Area);

    // Перевіряємо, що дві створені будівлі - це різні об'єкти
    if (building1 != building2)
    {
        Console.WriteLine("Обидві будівлі - різні об'єкти");
    }

    }
  }
}
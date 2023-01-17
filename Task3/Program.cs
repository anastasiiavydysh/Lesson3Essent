//Завдання 3

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден 
//    (ціна, швидкість, рік випуску).
//    Створіть 3 похідні класи Plane, Саг і Ship. 
//    Для класу Plane має бути визначена висота та кількість пасажирів. 
//    Для класу Ship – кількість пасажирів та порт приписки. 
//    Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(2, 2, 20000, 250, 2010, 100, 300);
            Car car = new Car(2, 2, 20000, 250, 2010);
            Ship ship = new Ship(2, 2, 20000, 250, 2010, 200, "A123");

            plane.Print();
            Console.WriteLine("______________");
            car.Print();
            Console.WriteLine("______________");
            ship.Print();
        }
    }
}
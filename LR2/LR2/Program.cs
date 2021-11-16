using System;
using LR2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Завдання 1
            Address my_address = new Address(index: 1234, country: "Ukraine", city: "Kyiv", street: "Kubanskoy Ukrainy", house: "24-A", apartment: 123);

            Console.WriteLine($"Index: {my_address._index}. Country: {my_address._country}. City: {my_address._city}. Street: {my_address._street}. House: {my_address._house}. Apartment: {my_address._apartment}.");

            //Завдання 2
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Rectangle rec = new Rectangle(side1: a, side2: b);

            rec.AreaCalculator();
            rec.PerimeterCalculator();

            //Завдання 3
            Console.WriteLine("Назва:");
            Title titl1 = new Title(title: Console.ReadLine());
            Console.WriteLine("Автор:");
            Author au1 = new Author(author: Console.ReadLine());
            Console.WriteLine("Зміст:");
            Content con1 = new Content(cont: Console.ReadLine());

            titl1.Show();
            au1.Show();
            con1.Show();

            //Завдання 4
            Figure fig1 = new Figure(pointA: 1, pointB: 2, pointC: 3, figname: "Triangle");
            fig1.LengthSide(pointA: 1, pointB: 2);
            fig1.PerimeterCalculator(pointA: 1, pointB: 2, pointC: 3, figname: "Triangle");
            Console.ReadKey();

        }
    }
}
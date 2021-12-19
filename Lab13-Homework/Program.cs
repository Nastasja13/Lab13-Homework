using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задан класс Building, который описывает здание.Класс содержит следующие элементы:
             * адрес здания; длина здания; ширина здания; высота здания.
             
            В классе Building нужно реализовать следующие методы:
            конструктор с 4 параметрами; свойства get/ set для доступа к полям класса;
            метод Print(), который выводит информацию о здании.
            
            Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность.
            В классе MultiBuilding реализовать следующие элементы:
            конструктор с 5 параметрами – реализует вызов конструктора базового класса; 
            свойство get/ set доступа к внутреннему полю класса; 
            метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
            
            Класс MultiBuilding сделать таким, что не может быть унаследован.*/

            
            Console.Write("Введите адрес здания: ");
            string address = Console.ReadLine();

            Console.Write("Введите длину здания: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ширину здания: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту здания: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите количество этажей: ");
            int numberFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Building building = new Building(address, length, width, height);
            Console.Write("Вывод данных класса Building: \n");
            building.Print();
            Console.WriteLine();

            MultiBuilding multiBuilding = new MultiBuilding(address, length, width, height, numberFloor);
            Console.Write("Вывод данных класса MultiBuilding: \n");
            multiBuilding.Print();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
    /*Задан класс Building, который описывает здание.Класс содержит следующие элементы:
     адрес здания; длина здания; ширина здания; высота здания.*/
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building()
        {

        }

        public Building(string address, double length, double width, double height)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
        }

        public void Print()
        {
            Console.WriteLine($"Адрес: {Address}\nДлина: {Length}\nШирина: {Width}\nВысота: {Height}");
        }
    }

    sealed class MultiBuilding : Building
    {
        public int NumberFloor { get; set; }
        public MultiBuilding(string address, double length, double width, double height, int numberFloor)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = height;
            NumberFloor = numberFloor;
        }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Количество этажей: {NumberFloor}");
        }
    }
}

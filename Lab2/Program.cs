using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // содаем объект-распорядителя
            Director HouseDirector = new Director();
            // создаем строителя 1
            SmartHouseBuilder Builder1 = new SmartHouseBuilder1();
            // строим дом
            SmartHouse House1 = HouseDirector.Construct(Builder1);

            Console.WriteLine("1-й сконструированный умный дом:");
            Console.WriteLine(House1.ToString());
            
            Console.ReadLine();
        }
    }
}

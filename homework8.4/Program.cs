using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
            XElement Person = new XElement("Person");
            Console.Write("Введите ФИО: ");
            XAttribute xperson = new XAttribute($"name", Console.ReadLine());
            Person.Add(xperson);

            Console.Write("Введите название улицы: ");
            string street = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            string house = Console.ReadLine();
            Console.Write("Введите номер квартиры: ");
            string flat = Console.ReadLine();

            XElement AddressTree = new XElement("Address",
                            new XElement("Street", street),
                            new XElement("House", house),
                            new XElement("Flat", flat));

            Person.Add(AddressTree);

            Console.Write("Введите мобильный телефон: ");
            string mobilenumber = Console.ReadLine();
            Console.Write("Введите домашний телефон: ");
            string flatnumber = Console.ReadLine();

            XElement PhonesTree = new XElement("Phones",
                            new XElement("MobilePhone", mobilenumber),
                            new XElement("FlatPhone", flatnumber));

            Person.Add(PhonesTree);

            Person.Save("Person.xml");
        }
    }
}

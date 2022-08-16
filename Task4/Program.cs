using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement person = new XElement("Person");

            Console.Write("Введите ФИО человека: ");
            XAttribute XAttributeName = new XAttribute("name", Console.ReadLine());
            person.Add(XAttributeName);
            XElement address = new XElement("Address");
            person.Add(address);

            XElement street = new XElement("Street");
            Console.Write("Введите название улицы: ");
            XAttribute XAttributeStreetName = new XAttribute("street", Console.ReadLine());
            street.Add(XAttributeStreetName);
            address.Add(street);

            XElement house = new XElement("HouseNumber");
            Console.Write("Введите номер дома: ");
            XAttribute XAttributeHouseNumber = new XAttribute("number", Console.ReadLine());
            house.Add(XAttributeHouseNumber);
            address.Add(house);

            XElement flat = new XElement("FlatNumber");
            Console.Write("Введите номер квартиры: ");
            XAttribute XAttributeFlatNumber = new XAttribute("number", Console.ReadLine());
            flat.Add(XAttributeFlatNumber);
            address.Add(flat);

            XElement phones = new XElement("Phones");
            XElement mobilePhone = new XElement("MobilePhone");
            Console.Write("Введите номер мобильного телефона: ");
            XAttribute XAttributeMobilePhone = new XAttribute("phone", Console.ReadLine());
            mobilePhone.Add(XAttributeMobilePhone);
            phones.Add(mobilePhone);

            XElement flatPhone = new XElement("MobilePhone");
            Console.Write("Введите номер стационарного телефона: ");
            XAttribute XAttributeFlatPhone = new XAttribute("phone", Console.ReadLine());
            flatPhone.Add(XAttributeFlatPhone);
            phones.Add(flatPhone);
            person.Add(phones);

            person.Save("person.xml");
        }
    }
}

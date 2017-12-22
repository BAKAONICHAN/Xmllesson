using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML_LESSON
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"cars.xml");

            var rootElement = document.LastChild;

            XmlElement newCar = document.CreateElement("car");
            rootElement.AppendChild(newCar);
            document.Save("cars.xml");

            //foreach (XmlElement element in rootElement)
            //{
            //    Car car = new Car();
            //    car.Id = Guid.Parse(element.ChildNodes[0].InnerText);
            //    car.Mark = element.ChildNodes[1].InnerText;
            //    car.MadeDate = DateTime.Parse(element.ChildNodes[2].InnerText);
            //    car.Rating = int.Parse(element.ChildNodes[3].Attributes["value"].InnerText);

            //    //Car car2 = new Car()
            //    //{
            //    //    Id = Guid.Parse(element.ChildNodes[0].InnerText),
            //    //    Mark = element.ChildNodes[1].InnerText,
            //    //    MadeDate = DateTime.Parse(element.ChildNodes[2].InnerText),
            //    //    Rating = int.Parse(element.ChildNodes[3].InnerText),
            //    //};
            //}

        }
    }
}

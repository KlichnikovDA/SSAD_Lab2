using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SmartHouseBuilder1: SmartHouseBuilder
    {
        public SmartHouseBuilder1()
        {
            this.House = new SmartHouse();
        }

        public override void BuildSensors()
        {
            this.House.Sensors = new Sensor("Комплект сенсоров 1");
        }

        public override void BuildExecutives()
        {
            this.House.Executives = new Executive("Исполнительный механизм 1");
        }

        public override void BuildPanels()
        {
            this.House.Panels = new Panel("Простая панель оператора");
        }

        public override void BuildMultimedia()
        {
            this.House.Multimedia = new Multimedia("Навороченные мультимедиа");
        }

        public override void BuildControllers()
        {
            this.House.Controllers = new Controller("Набор контроллеров 1");
        }

        public override void BuildNetworks()
        {
            this.House.Networks = new Network("Немногочисленные сетевые устройства");
        }

        public override SmartHouse GetResult()
        {
            return this.House;
        }
    }
}

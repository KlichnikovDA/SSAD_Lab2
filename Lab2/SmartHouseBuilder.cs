using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Интерфейс строителя
    abstract class SmartHouseBuilder
    {
        // Создаваемый объект
        protected SmartHouse House { get; set; }

        // Создание пустого объекта
        public void StartBuilding()
        {
            House = new SmartHouse(); 
        }

        // Конструирование частей объекта
        public abstract void BuildSensors();
        public abstract void BuildExecutives();
        public abstract void BuildPanels();
        public abstract void BuildMultimedia();
        public abstract void BuildControllers();
        public abstract void BuildNetworks();
        public abstract SmartHouse GetResult();
    }
}

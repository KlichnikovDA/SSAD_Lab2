using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Распорядитель работ
    class Director
    {
        // Используемый строитель
        SmartHouseBuilder Builder;

        // Конструктор
        public Director(SmartHouseBuilder Builder)
        {
            this.Builder = Builder;
        }

        public Director()
        {

        }

        // Конструирование объекта
        public void Construct()
        {
            if (this.Builder != null)
            {
                Builder.BuildSensors();
                Builder.BuildExecutives();
                Builder.BuildPanels();
                Builder.BuildMultimedia();
                Builder.BuildControllers();
                Builder.BuildNetworks();
            }
        }

        public SmartHouse Construct(SmartHouseBuilder Builder)
        {
            this.Builder = Builder;
            Builder.BuildSensors();
            Builder.BuildExecutives();
            Builder.BuildPanels();
            Builder.BuildMultimedia();
            Builder.BuildControllers();
            Builder.BuildNetworks();
            return Builder.GetResult();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    // Продукт
    class SmartHouse
    {
        // Аттрибуты умного дома
        public Sensor Sensors { get; set; }
        public Executive Executives { get; set; }
        public Panel Panels { get; set; }
        public Multimedia Multimedia { get; set; }
        public Controller Controllers { get; set; }
        public Network Networks { get; set; }

        // Конструктор
        public SmartHouse()
        {
            Sensors = null;
            Executives = null;
            Panels = null;
            Multimedia = null;
            Controllers = null;
            Networks = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Sensors != null)
                sb.Append(Sensors.SensorInfo + "\n");
            if (Executives != null)
                sb.Append(Executives.ExecutiveInfo + "\n");
            if (Panels != null)
                sb.Append(Panels.PanelInfo + "\n");
            if (Multimedia != null)
                sb.Append(Multimedia.MultimediaInfo + "\n");
            if (Controllers != null)
                sb.Append(Controllers.ControllerInfo + "\n");
            if (Networks != null)
                sb.Append(Networks.NetworkInfo + "\n");
            return sb.ToString();
        }
    }

    class Sensor
    {
        public string SensorInfo { get; set; }

        public Sensor(string param)
        {
            SensorInfo = param;
        }
    }

    class Executive
    {
        public string ExecutiveInfo { get; set; }

        public Executive(string param)
        {
            ExecutiveInfo = param;
        }
    }

    class Panel
    {
        public string PanelInfo { get; set; }

        public Panel(string param)
        {
            PanelInfo = param;
        }
    }

    class Multimedia
    {
        public string MultimediaInfo { get; set; }

        public Multimedia(string param)
        {
            MultimediaInfo = param;
        }
    }

    class Controller
    {
        public string ControllerInfo { get; set; }

        public Controller(string param)
        {
            ControllerInfo = param;
        }
    }

    class Network
    {
        public string NetworkInfo { get; set; }

        public Network(string param)
        {
            NetworkInfo = param;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeOOPOrnek.Abstracts
{
    public abstract class Device //Base class
    {
        public string deviceBrand { get; set; } 
        public string deviceModel { get; set; } 
        private string _deviceName;
        public string deviceName
        {
            get
            {
                return _deviceName;

            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("tanimsiz");
                }
                else
                {
                    _deviceName = value;
                }

            }
        }

        public bool isOn { get; protected set; }  
        public abstract void TurnOn();
        public abstract void TurnOff();
        public string situation
        {
            get
            {
                if(isOn == true)
                {
                    return "Cihaz acik";
                }
                else
                {
                    return "Cihaz kapali";
                }   
            }
        }
        public virtual string deviceInfo()
        {
            return $"Cihaz Markasi: {deviceBrand}\nCihaz Modeli: {deviceModel}\nCihaz Adi: {deviceName}\nCihaz Durumu: {situation}";
        }
        public override string ToString()
        {
            return deviceInfo();
        }



    }
}

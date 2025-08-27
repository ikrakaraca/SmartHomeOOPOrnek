using SmartHomeOOPOrnek.Abstracts;

namespace SmartHomeOOPOrnek.Concretes
{
    internal class Thermostat : Device, IConnectable, IControllable
    {
        private int _temperature;
        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                if(10 <= value && value <= 30)
                {
                    _temperature = value;
                }
                else
                {
                    Console.WriteLine("Sicaklik 10 ve 30 arasinda olmali");
                }
            }
        }
        public bool IsConnected { get; set; }

        public void Connect()
        {
            IsConnected = true;
        }

        public void Decrease()
        {
            Temperature--;
            if(Temperature < 10)
            {
                Temperature = 10;
            }
        }

        public void Disconnect()
        {
            IsConnected = false;
        }

        public void Increase()
        {
            Temperature++;
            if(Temperature > 30)
            {
                Temperature = 30;
            }
        }

        public override void TurnOff()
        {
            isOn = false;
        }

        public override void TurnOn()
        {
            isOn = true;
        }
        public override string deviceInfo()
        {
            return base.deviceInfo() + $"\nCihaz Sicakligi: {Temperature}\nCihaz Baglanti Durumu: {(IsConnected ? "Bagli" : "Bagli Degil")}";
        }
    }
    
}

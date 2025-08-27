using SmartHomeOOPOrnek.Abstracts;

namespace SmartHomeOOPOrnek.Concretes
{
    internal class Lamp : Device, IConnectable, IControllable
    {
        private int _brightness;
        public int Brightness
        {
            get
            {
                return _brightness;
            }
            set
            {
                if(0 <= value && value <= 100)
                {
                    _brightness = value;
                }
                else
                {
                    Console.WriteLine("Parlaklik 0 ve 100 arasinda olmali");
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
            Brightness--;
            if(Brightness < 0)
            {
                Brightness = 0;
            }


        }

        public void Disconnect()
        {
            IsConnected = false;
        }

        public void Increase()
        {
            Brightness++;
            if(Brightness > 100)
            {
                Brightness = 100;
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
            return base.deviceInfo() + $"\nParlaklik: %{Brightness}\nBaglanti Durumu: {(IsConnected ? "Bagli" : "Bagli degil")}";
        }
        public Lamp()
        {
            Brightness = 0;
        }
        public Lamp(int brightness )
        {
            Brightness = brightness;
        }
    }
}

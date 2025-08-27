using SmartHomeOOPOrnek.Abstracts;

namespace SmartHomeOOPOrnek.Concretes
{
    internal class Camera : Device, IConnectable
    {

        private bool _record;
        public bool record
        {
            get
            {
                return _record;
            }
            set { 
            }
        }
        public bool IsConnected { get;  set; }

        public void Connect()
        {
            IsConnected = true; 
        }


        public void Disconnect()
        {
            IsConnected = false;
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
            return base.deviceInfo() + $"\nKamera Kayit Durumu: {record}";
        }
    }
}

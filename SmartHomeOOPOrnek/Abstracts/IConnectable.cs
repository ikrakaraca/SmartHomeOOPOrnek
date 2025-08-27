using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeOOPOrnek.Abstracts
{
    internal interface IConnectable
    {
        public bool IsConnected { get; set; }
        void Connect();
        void Disconnect();


    }
}

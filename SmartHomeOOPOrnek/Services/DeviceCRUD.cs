using SmartHomeOOPOrnek.Abstracts;
using SmartHomeOOPOrnek.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeOOPOrnek.Services
{
    internal class DeviceCRUD 
    {
        // Create
        // Read
        // Update
        // Delete
        public void AddDevice(Device device)
        {
            DeviceData.devices.Add(device);
        }
        public void GetAllDevices()
        {
            foreach (var d in DeviceData.devices)
            {
                Console.WriteLine(d);
            }
        }
        public void UpdateDevice( string newName, string incomingName)
        {
            Console.WriteLine("Guncellemek istediginiz cihaz adi: ");
            incomingName = Console.ReadLine();
            Console.WriteLine("Yeni cihaz adi: ");
            newName = Console.ReadLine();
            foreach (var d in DeviceData.devices)
            {
                if(d.deviceName == incomingName)
                {
                    d.deviceName = newName;
                    Console.WriteLine("Cihaz adi guncellendi");
                    return;
                }
                else
                {
                    Console.WriteLine("Boyle bir cihaz bulunamadi");
                }
            }
        }
        public void DeleteDevice(string incomingName)
        {
            Console.WriteLine("Silmek istediginiz cihaz adi: ");    
            incomingName = Console.ReadLine();
            foreach (var d in DeviceData.devices)
            {
                if(d.deviceName == incomingName)
                {
                    DeviceData.devices.Remove(d);
                    Console.WriteLine("Cihaz silindi");
                }
                else
                {
                    Console.WriteLine("Boyle bir cihaz bulunamadi");
                }
            }
        }
        public void GetDeviceInfoByName(string incomingName)
        {
            Console.WriteLine("Bilgilerini gormek istediginiz cihaz adi: ");
            incomingName = Console.ReadLine();
            foreach (var d in DeviceData.devices)
            {
                if(d.deviceName == incomingName)
                {
                    Console.WriteLine(d);
                    return;
                }
                else
                {
                    Console.WriteLine("Boyle bir cihaz bulunamadi");
                }
            }
        }
        public void TurnAllDevicesOn()
        {
            foreach(var d in DeviceData.devices)
            {
                d.TurnOn();
            }
        }
        public void TurnAllDevicesOff()
        {
            foreach(var d in DeviceData.devices)
            {
                d.TurnOff();
            }
        }
        public void ListByType(string type) 
        {
            if (type.ToLower() == "lamp")
            {
                foreach (var d in DeviceData.devices)
                {
                    if (d is Concretes.Lamp)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
            else if (type.ToLower() == "thermostat")
            {
                foreach (var d in DeviceData.devices)
                {
                    if (d is Concretes.Thermostat)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
            else if (type.ToLower() == "camera")
            {
                foreach (var d in DeviceData.devices)
                {
                    if (d is Concretes.Camera)
                    {
                        Console.WriteLine(d);
                    }
                }
            }
            else
            {
                Console.WriteLine("Gecersiz cihaz turu");
            }


        }
        public void ListByConnectionStatus(bool isConnected)
        {
            foreach (var d in DeviceData.devices)
            {
                if (d is IConnectable connectableDevice && connectableDevice.IsConnected == isConnected)
                {
                    Console.WriteLine(d);
                }
            }
        }
        public void ListByControllableStatus(bool isControllable)
        {
            foreach (var d in DeviceData.devices)
            {
                if (d is IControllable controllableDevice && isControllable)
                {
                    Console.WriteLine(d);
                }
            }
        }

    }
}

using SmartHomeOOPOrnek.Concretes;
using SmartHomeOOPOrnek.Abstracts;
using System.Collections.Generic;
using SmartHomeOOPOrnek.Services;
using SmartHomeOOPOrnek.Data;
using System;
using System.Transactions;

Lamp lamp1= new Lamp();
lamp1.deviceBrand = "Philips";
lamp1.deviceModel = "Hue White";
lamp1.deviceName = "Salon Lambasi";
lamp1.Brightness = 75;
lamp1.Connect();
lamp1.TurnOn();
Console.WriteLine(lamp1);
DeviceData.devices.Add(lamp1);

Thermostat thermostat1 = new Thermostat();
thermostat1.deviceBrand = "Nest";
thermostat1.deviceModel = "Learning Thermostat";
thermostat1.deviceName = "Yatak Odasi Termostati";
thermostat1.Temperature = 22;
thermostat1.Connect();
thermostat1.TurnOn();
Console.WriteLine(thermostat1);
DeviceData.devices.Add(thermostat1);

Camera camera1 = new Camera();
camera1.deviceBrand = "Arlo";
camera1.deviceModel = "Pro 3";
camera1.deviceName = "Giris Kamerasi";
camera1.record = true;
camera1.Connect();
camera1.TurnOn();
Console.WriteLine(camera1);
DeviceData.devices.Add(camera1);

Console.WriteLine("Menu:\n1. Cihazlari Listele\n2. Cihaz Ekle\n3. Tum Cihaz sil\n4. Cihaz adi guncelle\n5. Tum cihazlari ac/kapat\n6. Ture gore listele\n7.Baglanabilir cihazlari listele\n8.Kontrol edilebilir cihazlari listele\n9.Toplam cihaz sayisini goster");
Console.WriteLine("Seciminiz: ");
string choice = Console.ReadLine();
if (choice == "1")
{
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.GetAllDevices();
}
else if (choice == "2")
{
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.AddDevice(lamp1);
    deviceCRUD.AddDevice(thermostat1);
    deviceCRUD.AddDevice(camera1);
}
else if (choice == "3")
{
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.DeleteDevice("");
}
else if (choice == "4")
{
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.UpdateDevice("", "");
}
else if (choice == "5")
{
    foreach (var d in DeviceData.devices)
    {
        if (d.isOn)
        {
            d.TurnOff();
        }
        else
        {
            d.TurnOn();
        }
    }
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.GetAllDevices();
}
else if (choice == "6")
{
    DeviceCRUD deviceCRUD = new DeviceCRUD();
    Console.WriteLine("Hangi ture gore listeleme yapmak istersiniz? (Lamp, Thermostat, Camera)");
    string typeChoice = Console.ReadLine();
    deviceCRUD.ListByType(typeChoice);
}
else if (choice == "7")
{
   DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.ListByConnectionStatus(true);
}
else if (choice == "8")
{
   DeviceCRUD deviceCRUD = new DeviceCRUD();
    deviceCRUD.ListByControllableStatus(true);
}
else if (choice == "9")
{
    Console.WriteLine($"Toplam cihaz sayisi: {DeviceData.devices.Count}");
}



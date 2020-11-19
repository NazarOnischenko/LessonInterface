using System;

namespace LessonInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Lenovo lenovo = new Lenovo("Lenovo", "IdeaPad 320", "Intel I3", "NVidea GeForce 920", "Easy Camera", 0.3, 6, 1000000, 160000);
            PersonalComputer personalComputer = new PersonalComputer("Ryzen", "5", "Ryzen 5", "Radeon Sapphire 420", 8, 1000000, 100000);
            lenovo.OpenLaptop();
            lenovo.TurnOn();
            personalComputer.TurnOn();
            lenovo.Connecting(personalComputer);
            personalComputer.Connecting(lenovo);
            personalComputer.DisConnecting(lenovo);
            lenovo.DisConnecting(personalComputer);
            personalComputer.TurnOff();
            lenovo.TurnOff();
            lenovo.CloseLaptop();
        }
    }
}
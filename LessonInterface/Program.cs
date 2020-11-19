using System;

namespace LessonInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Write name:");
                var name = Console.ReadLine();
                Console.WriteLine("Write model:");
                var model = Console.ReadLine();
                Console.WriteLine("Write processor:");
                var processor = Console.ReadLine();
                Console.WriteLine("Write video adapter:");
                var videaAdapter = Console.ReadLine();
                Console.WriteLine("Write RAM:");
                var ram = int.Parse(Console.ReadLine());
                Console.WriteLine("Write capacity of hard disc:");
                var hddCapacity = int.Parse(Console.ReadLine());
                Console.WriteLine("Write price:");
                var price = int.Parse(Console.ReadLine());
                Lenovo lenovo = new Lenovo(name, model, processor, videaAdapter, "Easy Camera", 0.3, ram, hddCapacity, price);
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
            catch (LessThanZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finish!");
            }
        }
    }
}
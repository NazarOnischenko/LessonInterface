using System;
using System.Collections.Generic;
using System.Text;

namespace LessonInterface
{
    class PersonalComputer : IComputer
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string GraphicAdapter { get; set; }
        public int Price { get; set; }
        public int RAM { get; set; }
        public int HDDCapacity { get; set; }
        public PersonalComputer(string name, string model, string processor, string graphicAdapter, int ram, int hddCapacity, int price)
        {
            if (name == string.Empty || name == null)
            {
                throw new ArgumentNullException("Name must not be null or empty!");
            }
            if (model == string.Empty || model == null)
            {
                throw new ArgumentNullException("Model must not be null or empty!");
            }
            if (processor == string.Empty || processor == null)
            {
                throw new ArgumentNullException("Processor must not be null or empty!");
            }
            if (graphicAdapter == string.Empty || graphicAdapter == null)
            {
                throw new ArgumentNullException("Graphic Adapter must not be null or empty!");
            }
            if (ram <= 0)
            {
                throw new LessThanZeroException("RAM must be bigger than 0!");
            }
            if (hddCapacity <= 0)
            {
                throw new LessThanZeroException("Capacity of HDD must be bigger than 0!");
            }
            if (price <= 0)
            {
                throw new LessThanZeroException("Price of laptop must be bigger than 0!");
            }
            Name = name;
            Model = model;
            Processor = processor;
            GraphicAdapter = graphicAdapter;
            RAM = ram;
            HDDCapacity = hddCapacity;
            Price = price;
        }
        public void Connecting(IComputer computer)
        {
            Console.WriteLine($"This computer {this.Name} {this.Model} connecting with {computer.Name} {computer.Model}");
        }

        public void DisConnecting(IComputer computer)
        {
            Console.WriteLine($"This computer {this.Name} {this.Model} was disconnected from {computer.Name} {computer.Model}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"Good buy! It was {this.Name} {this.Model}");
        }

        public void TurnOn()
        {
            Console.WriteLine($"Hello! It`s {this.Name} {this.Model}!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LessonInterface
{
    class Lenovo : ILaptop
    {
        public string NameCamera { get; set; }
        public double MpxCamera { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Processor { get; set; }
        public string GraphicAdapter { get; set; }
        public int Price { get; set; }
        public int RAM { get; set; }
        public int HDDCapacity { get; set; }
        public Lenovo(string name, string model, string processor, string graphicAdapter,string nameCamera,double mpxCamera, int ram, int hddCapacity,int price)
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
            if (nameCamera == string.Empty || nameCamera == null)
            {
                throw new ArgumentNullException("Name camera must not be null or empty!");
            }
            if (mpxCamera <= 0)
            {
                throw new LessThanZeroException("Mega px of camera must be bigger than 0!");
            }
            if (ram <= 0)
            {
                throw new LessThanZeroException("RAM must be bigger than 0!");
            }
            if ( hddCapacity <= 0)
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
            NameCamera = nameCamera;
            MpxCamera = mpxCamera;
            RAM = ram;
            HDDCapacity = hddCapacity;
            Price = price;
        }
        public void CloseLaptop()
        {
            Console.WriteLine($"{this.Name} {this.Model} is closed!");
        }
        public void OpenLaptop()
        {
            Console.WriteLine($"{this.Name} {this.Model} is opened!");
        }
        public void TurnOn()
        {
            Console.WriteLine($"Hello! It`s {Name} {Model}!");
        }
        public void Connecting(IComputer computer)
        {
            Console.WriteLine($"This laptop {this.Name} {this.Model} connecting with {computer.Name} {computer.Model}");
        }
        public void DisConnecting(IComputer computer)
        {
            Console.WriteLine($"This laptop {this.Name} {this.Model} was disconnected from {computer.Name} {computer.Model}");
        }
        public void TurnOff()
        {
            Console.WriteLine($"Good buy! It was {this.Name} {this.Model}!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LessonInterface
{
    interface IComputer
    {
        string Name { get; set; }
        string Model { get; set; }
        string Processor { get; set; }
        string GraphicAdapter { get; set; }
        int Price { get; set; }
        int RAM { get; set; }
        int HDDCapacity { get; set; }
        void TurnOn();
        void TurnOff();
        void Connecting(IComputer computer);
        void DisConnecting(IComputer computer);
    }
}

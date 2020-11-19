using System;

namespace LessonInterface
{
    interface ILaptop:IComputer
    {
        string NameCamera { get; set; }
        double MpxCamera { get; set; }
        void CloseLaptop();
        void OpenLaptop();
    }
}

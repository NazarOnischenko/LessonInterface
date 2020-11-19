using System;
using System.Collections.Generic;
using System.Text;

namespace LessonInterface
{
    class LessThanZeroException:Exception
    {
        public LessThanZeroException() : base("Значение меньше нуля")
        {

        }
        public LessThanZeroException(string message) : base(message)
        {

        }
    }
}

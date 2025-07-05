using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment01
{
    internal enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday

    }


    internal enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    internal enum Permissions
    {
        None = 0,
        Read = 1 << 0,  // 1
        Write = 1 << 1,  // 2
        Delete = 1 << 2,  // 4
        Execute = 1 << 3   // 8
    }


    internal enum Colors
    {
        Red,
        Green,
        Blue
    }


}

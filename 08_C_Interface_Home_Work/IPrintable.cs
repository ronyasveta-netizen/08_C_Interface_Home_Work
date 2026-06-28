using System;
using System.Collections.Generic;
using System.Text;

namespace _08_C_Interface_Home_Work
{
    interface IPrintable
    {
        char Symbol { get; set; }
        void Print();
    }
}

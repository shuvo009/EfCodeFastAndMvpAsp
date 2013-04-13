using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCodeFastAndMvpAsp
{
    public interface IView
    {
        string Name { get; set; }
        String Address { get; set; }
        String PhoneNumbet { get; set; }
        DateTime DateofBirth { get; set; }
        bool IsAlive { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCodeFastAndMvpAsp
{
    public interface IModel
    {
        List<PersonalInfo> PersonalInfos { get; set; }
    }
}

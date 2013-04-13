using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EfCodeFastAndMvpAsp
{
    public class Model :IModel
    {
        public List<PersonalInfo> PersonalInfos
        {
            get
            {
                return new PersoalInfoDbContext().PersonalInfos.ToList();
            }
            set { }
        }

        public void Add(PersonalInfo personalInfo)
        {
            using (var pInfo = new PersoalInfoDbContext())
            {
                pInfo.PersonalInfos.Add(personalInfo);
                pInfo.SaveChanges();
            }
        }
    }
}
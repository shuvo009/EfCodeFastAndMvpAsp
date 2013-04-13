using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EfCodeFastAndMvpAsp
{

    public class PersoalInfoDbContext : DbContext
    {
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
    }



    public class PersonalInfo
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public String Address { get; set; }
        public String PhoneNumbet { get; set; }
        public DateTime DateofBirth { get; set; }
        public bool IsAlive { get; set; }
    }
}
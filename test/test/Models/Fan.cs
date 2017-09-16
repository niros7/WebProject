using System;
using System.Data.Entity;

namespace test.Models
{
    public class Fan
    {
        public int Id { get; set; }
        public string PrivateName { get; set; }
        public string LastName { get; set; }
        public bool IsFemale { get; set; }
        public DateTime BirthDate { get; set; }
        public int Seniority { get; set; }
    }

    public class FansClubDBContext : DbContext
    {
        public DbSet<Fan> Fans { get; set; }
    }
}

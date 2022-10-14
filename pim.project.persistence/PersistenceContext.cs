using Microsoft.EntityFrameworkCore;
using pim.project.domain;

namespace pim.project.persistence
{
    public class PersistenceContext : DbContext
    {
        public PersistenceContext(DbContextOptions<PersistenceContext> options)
          : base(options)
        {}
        public DbSet<People> People { get; set; }

        public DbSet<PeopleAddress> PeopleAddress { get; set; }

        public DbSet<PeoplePhone> PeoplePhone { get; set; }

        public DbSet<PeoplePhoneType> PeoplePhoneType { get; set; }

    }
}
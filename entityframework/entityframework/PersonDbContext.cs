using System;
using System.Collections.Generic;
using System.Text;

namespace entityframework
{
    using System.Data.Entity;

    public class PersonDbContext : DbContext
    {
        public PersonDbContext() : base("name=PersonContext")
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}

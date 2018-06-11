using System;
using System.Data.Entity;

namespace entityframework
{

    public class Program
    {
        public static void Main(string[] args)
        {
            PerformDatabaseOperations();
            Console.Write("Person saved !");
            Console.ReadLine();
        }

        /// <summary>
        ///     The perform database operations.
        /// </summary>
        public static void PerformDatabaseOperations()
        {
            using (var db = new PersonDbContext())
            {
                var person = new Person
                {
                    FirstName = "Nadege",
                    LastName = "Deroussen",
                    BirthDate = DateTime.Now
                };

                db.Persons.Add(person);
                db.SaveChanges();
            }
        }
    }
}

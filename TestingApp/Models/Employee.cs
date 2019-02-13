using System;
using TestingApp.Interfaces;

namespace TestingApp.Models
{
    public class Employee : IEntity
    {
        public int DbId { get; set; }
        public DateTime UpdatedLocallyOn { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}

using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Data
{
    internal class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person
                {
                    Id = 1,
                    FullName = "Foo",
                    Age = 1,
                },
                new Person
                {
                    Id = 2,
                    FullName = "Bar",
                    Age = 2,  
                },
                new Person 
                { 
                    Id = 10,
                    FullName= "Foo2",
                    Age = 3,
                }
            };
        }
    }
}

using Practical.Services;
using Practical.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Controller
{
    internal class PersonController
    {
        private readonly IPersonService _personService;
        public PersonController()
        {
            _personService = new PersonService();
        }

        public void GetById()
        {
            try
            {
                Console.WriteLine("Add perspn id:");
                int id = int.Parse(Console.ReadLine());

                var response = _personService.GetById(id);

                var result = $"{response.Id} + {response.FullName} + {response.Age}";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

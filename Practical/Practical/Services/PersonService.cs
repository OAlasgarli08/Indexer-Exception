using Practical.Data;
using Practical.Models;
using Practical.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Services
{
    internal class PersonService : IPersonService
    {
        private readonly AppDbContext _context;
        public PersonService()
        {
            _context = new AppDbContext();
        }
        public Person GetById(int? id)
        {
            if(id is null) throw new ArgumentNullException();

            Person? existPerson = _context.People().FirstOrDefault(m => m.Id == id);
            return existPerson;
        }
    }
}

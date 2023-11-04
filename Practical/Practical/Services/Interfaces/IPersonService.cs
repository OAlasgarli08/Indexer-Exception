using Practical.Data;
using Practical.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical.Services.Interfaces
{
    internal interface IPersonService
    {
        
        Person GetById(int id);
    }
}

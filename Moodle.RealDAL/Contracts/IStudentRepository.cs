using Moodle.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Dal.Contracts
{
    public interface IStudentRepository : IRepository<StudentDTO, string>
    {
        
    }
}

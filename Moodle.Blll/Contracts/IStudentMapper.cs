using Moodle.Bll.Models;
using Moodle.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Blll.Contracts
{
    public interface IStudentMapper
    {
        StudentModel Map(StudentDTO studentDTO);
        StudentDTO Map(StudentModel studentModel);
    }
}

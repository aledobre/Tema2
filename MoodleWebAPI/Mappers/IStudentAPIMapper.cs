using Moodle.Bll.Models;
using MoodleWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoodleWebAPI.Mappers
{
    public interface IStudentAPIMapper
    {
        StudentModel Map(StudentAPIModel StudentAPIModel);
        StudentAPIModel Map(StudentModel studentModel);
    }
}
using Moodle.Bll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Contracts
{
    public interface IStudentService
    {
        void AddStudent(StudentModel studentModel);

        void DeleteStudent(StudentModel studentModel);

        List<StudentModel> GetAll();

        StudentModel GetByUsername(string username);

        void UpdateStudent(StudentModel studentModel);

        bool CheckIsStudentExists(string username);
    }
}

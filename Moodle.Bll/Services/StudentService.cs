using Moodle.Bll.Contracts;
using Moodle.Bll.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _iStudentRepository;

        public StudentService(IStudentRepository iStudentRepository)
        {
            _iStudentRepository = iStudentRepository;
        }

        public void AddStudent(StudentModel studentModel)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(StudentModel studentModel)
        {
            throw new NotImplementedException();
        }

        public List<StudentModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public StudentModel GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            throw new NotImplementedException();
        }
    }
}

using Moodle.Bll.Contracts;
using Moodle.Bll.Models;
using Moodle.Blll.Contracts;
using Moodle.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moodle.Bll.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _iStudentRepository;
        private readonly IStudentMapper _iStudentMapper;

        public StudentService(IStudentRepository iStudentRepository, IStudentMapper iStudentMapper)
        {
            _iStudentRepository = iStudentRepository;
            _iStudentMapper = iStudentMapper;
        }

        public void AddStudent(StudentModel studentModel)
        {
            _iStudentRepository.Add(_iStudentMapper.Map(studentModel));
            _iStudentRepository.SaveChanges();
        }

        public void DeleteStudent(StudentModel studentModel)
        {
            _iStudentRepository.Delete(_iStudentMapper.Map(studentModel).Username);
            _iStudentRepository.SaveChanges();
        }

        public List<StudentModel> GetAll()
        {
            return _iStudentRepository.GetAll()
                .Select(s => _iStudentMapper.Map(s))
                .OrderBy(u => u.Username)
                .ToList();
        }

        public StudentModel GetByUsername(string username)
        {
            return _iStudentMapper.Map((_iStudentRepository.GetByKey(username)));
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            _iStudentRepository.Update(_iStudentMapper.Map(studentModel));
            _iStudentRepository.SaveChanges();
        }

        public bool CheckIsStudentExists(string username)
        {
            bool exists = false;
            foreach (StudentModel student in GetAll())
            {

                if (student.Username == username)
                    exists = true;
            }
            return exists;
        }
    }
}

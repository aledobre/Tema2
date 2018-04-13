using Moodle.Bll.Models;
using Moodle.Blll.Contracts;
using Moodle.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Blll.Mappers
{
    public class StudentMapper : IStudentMapper
    {
        public StudentModel Map(StudentDTO studentDTO)
        {
            if(studentDTO == null)
            {
                return null;
            }

            return new StudentModel
            {
                StudentId = studentDTO.StudentId,
                Token = studentDTO.Token,
                Username = studentDTO.Username,
                EncPassword = studentDTO.EncPassword,
                Name = studentDTO.Name,
                Email = studentDTO.Email,
                GroupNo = studentDTO.GroupNo,
                Hobby = studentDTO.Hobby
            };
        }

        public StudentDTO Map(StudentModel studentModel)
        {
            if (studentModel == null)
            {
                return null;
            }
            return new StudentDTO
            {
                StudentId = studentModel.StudentId,
                Token = studentModel.Token,
                Username = studentModel.Username,
                EncPassword = studentModel.EncPassword,
                Name = studentModel.Name,
                Email = studentModel.Email,
                GroupNo = studentModel.GroupNo,
                Hobby = studentModel.Hobby
            };
        }
    }
}

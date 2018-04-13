using Moodle.Dal.Contexts;
using Moodle.Dal.Models;
using Moodle.Dal.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodle.Dal.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        protected MoodleContext _dbContext;
        protected DbSet<StudentDTO> _dbSet;

        public StudentRepository(MoodleContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<StudentDTO>();
        }
             
        public void Add(StudentDTO student)
        {
            _dbSet.Add(student);
        }

        public void Delete(string key) //delete dupa username
        {
            StudentDTO studentToDelete = _dbSet.Find(key);
            Delete(studentToDelete);
        }

        public void Delete(StudentDTO student)
        {
            if (_dbContext.Entry(student).State == EntityState.Detached)
            {
                _dbSet.Attach(student);
            }

            _dbSet.Remove(student);
        }

        public IQueryable<StudentDTO> GetAll()
        {
            return _dbSet;
        }

        public StudentDTO GetByKey(string key) //get by username
        {
            var student = _dbSet.Where(b => b.Username == key).FirstOrDefault();

            return student;
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Update(StudentDTO student)
        {
            var newStudent = _dbSet.FirstOrDefault();
            newStudent = student;
            _dbSet.Attach(newStudent);
            _dbContext.Entry(newStudent).State = EntityState.Modified;
            
        }
    }
}

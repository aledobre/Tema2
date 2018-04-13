using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int GroupNo { get; set; }
        public string Hobby { get; set; }

        public IEnumerable<SubmissionModel> Submissions { get; set; }

        public StudentModel()
        {
            Submissions = new HashSet<SubmissionModel>();
        }
    }
}

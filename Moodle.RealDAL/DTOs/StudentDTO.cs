using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Moodle.Dal.Models
{
    [Table("Students")]
    public class StudentDTO
    {
        [Key]
        public int StudentId { get; set; }
        public string Token { get; set; }
        public string Username { get; set; }
        public string EncPassword { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int GroupNo { get; set; }
        public string Hobby { get; set; }

        public IEnumerable<SubmissionDTO> Submissions { get; set; }

        public StudentDTO()
        {
            Submissions = new HashSet<SubmissionDTO>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Moodle.Dal.Models
{
    [Table("Submissions")]
    public class SubmissionDTO
    {
        [Key]
        public int Id { get; set; }
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public StudentDTO Student { get; set; }

        public int AssignmentId { get; set; }

        [ForeignKey("AssignmentId")]
        public AssignmentDTO Assignment { get; set; }

        public string Link { get; set; }
        public string Remark { get; set; }
        public float Grade { get; set; }
    }
}

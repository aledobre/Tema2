using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Models
{
    public class SubmissionModel
    {
        public int SubmissionId { get; set; }
        public int StudentId { get; set; }        
        public StudentModel Student { get; set; }
        public int AssignmentId { get; set; }
        public AssignmentModel Assignment { get; set; }
        public string Link { get; set; }
        public string Remark { get; set; }
        public float Grade { get; set; }
    }
}

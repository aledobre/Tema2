using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Moodle.Dal.Models
{
    [Table("Assignments")]
    public class AssignmentDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public int LabId { get; set; }

        [ForeignKey("LabId")]
        public LaboratoryDTO Laboratory { get; set; }

        public IEnumerable<SubmissionDTO> Submissions { get; set; }

        public AssignmentDTO()
        {
            Submissions = new HashSet<SubmissionDTO>();
        }
    }
}

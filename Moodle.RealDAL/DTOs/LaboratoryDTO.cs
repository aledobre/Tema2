using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Moodle.Dal.Models
{
    [Table("Laboratories")]
    public class LaboratoryDTO
    {
        [Key]
        public int Id { get; set; }
        public int LabNumber { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Curricula { get; set; }
        public string Description { get; set; }

        public IEnumerable<AssignmentDTO> Assignments { get; set; }
       
        public LaboratoryDTO()
        {
            Assignments = new HashSet<AssignmentDTO>();
        }
    }
}

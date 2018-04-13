using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Models
{
    public class LaboratoryModel
    {
        public int LabId { get; set; }
        public int LabNumber { get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Curricula { get; set; }
        public string Description { get; set; }

        public IEnumerable<AssignmentModel> Assignments { get; set; }
    }
}

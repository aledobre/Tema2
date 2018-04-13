﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Models
{
    public class AssignmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public int LabId { get; set; }
        public LaboratoryModel Laboratory { get; set; }

        public IEnumerable<SubmissionModel> Submissions { get; set; }

        
    }
}

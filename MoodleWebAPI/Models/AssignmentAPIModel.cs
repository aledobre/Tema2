﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoodleWebAPI.Models
{
    public class AssignmentAPIModel
    {
        public string Name { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
        public int LabId { get; set; }
        public LaboratoryAPIModel Laboratory { get; set; }

        public IEnumerable<SubmissionAPIModel> Submissions { get; set; }

    }
}
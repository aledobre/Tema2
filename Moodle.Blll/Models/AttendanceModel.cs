using System;
using System.Collections.Generic;
using System.Text;

namespace Moodle.Bll.Models
{
    public class AttendanceModel
    {
        public int AttendanceId { get; set; }
        public int StudentId { get; set; }
        public int LabId { get; set; }
        public bool AttendanceStatus { get; set; }
        public StudentModel Student { get; set; }
        public LaboratoryModel Laboratory { get; set; }
    }
}

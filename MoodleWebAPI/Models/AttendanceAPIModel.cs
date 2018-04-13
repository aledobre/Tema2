using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoodleWebAPI.Models
{
    public class AttendanceAPIModel
    {
        public bool AttendanceStatus { get; set; }
        public StudentAPIModel Student { get; set; }
        public LaboratoryAPIModel Laboratory { get; set; }
    }
}
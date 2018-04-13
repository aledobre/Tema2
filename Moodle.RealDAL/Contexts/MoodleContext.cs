using Moodle.Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Moodle.Dal.Contexts
{
    public class MoodleContext : DbContext
    {
        public MoodleContext() : base(WebConfigurationManager.AppSettings["ConnectionString"])
        {
        }

        public DbSet<StudentDTO> Students { get; set; }
        public DbSet<AssignmentDTO> Assignments { get; set; }
        public DbSet<LaboratoryDTO> Laboratory { get; set; }
        public DbSet<AttendanceDTO> Attendance { get; set; }
        public DbSet<SubmissionDTO> Submission { get; set; }
    }
}

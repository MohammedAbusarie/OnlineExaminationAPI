﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace FinalYearProject.Models
{
    public partial class Schedule
    {
        public int Id { get; set; }
        public bool Is_set { get; set; }
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<ScheduleWithCourse> ScheduleWithCourses { get; set; }
    }
}

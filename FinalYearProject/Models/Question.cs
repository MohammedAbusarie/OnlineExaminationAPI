﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FinalYearProject.Models
{
    public partial class Question
    {
      

        public int Id { get; set; }
        public string Questionx { get; set; }
        public string Answer { get; set; }
        public Char Qtype { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string Goal { get; set; }
        
        public int CourseId { get; set; }
        public string Difficulty { get; set; }

        public virtual Course Course { get; set; }
        
    }
}

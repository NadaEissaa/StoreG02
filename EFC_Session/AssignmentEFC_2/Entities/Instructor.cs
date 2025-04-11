﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFC_2.Entities
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        public string? Address { get; set; }
        public decimal HourRateBonus { get; set; }
        public int Dept_ID { get; set; }
        public Department? Department { get; set; }
        public List<Course_Inst> Course_Instructors { get; set; } = new List<Course_Inst>();
    }
}

﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WPFPersonnelTracking.DB
{
    public partial class Month
    {
        public Month()
        {
            Salaries = new HashSet<Salary>();
        }

        public int Id { get; set; }
        public string MonthName { get; set; }

        public virtual ICollection<Salary> Salaries { get; set; }
    }
}

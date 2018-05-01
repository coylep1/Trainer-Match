﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Exercise
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string VideoLink { get; set; }
        public char DayAlternation { get; set; } // exercise happens on A day or B day or C day 
    }
}
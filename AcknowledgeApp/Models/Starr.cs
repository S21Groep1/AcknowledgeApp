﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Starr 
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime LastEdit { get; set; }
        public String Situation { get; set; }
        public String Task { get; set; }
        public String Action { get; set; }
        public String Result { get; set; }
        public String Reflection { get; set; }
        public Emotions Feeling { get; set; }
        public String Coach { get; set; }

        public Starr()
        {


        }

        public void CopyFrom(Starr other)
        {
            Id = other.Id;
            Name = other.Name;
            LastEdit = DateTime.Now;
            Situation = other.Situation;
            Task = other.Task;
            Action = other.Task;
            Result = other.Result;
            Reflection = other.Reflection;
            Coach = other.Coach;
        }

    }
}

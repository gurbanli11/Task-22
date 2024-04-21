﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GenericType.Models
{
    public abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public Gender Gender { get; set; }
        public string Breed { get; set; }
        public int HP { get; set; }


        public enum Gender
        {
            Male,
            Female
        }

    }
}

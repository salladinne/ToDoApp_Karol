﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp_Karol.Domain.Common
{
    public abstract class Persons
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Tasks> Duties { get; set; }
        //czemu nie moze byc List od T? bo to jest abstrakcyjna klasa a nie interfejs?

    }
}

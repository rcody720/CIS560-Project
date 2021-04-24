﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560Project.Models
{
    public class Director
    {
        public int DirectorId { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Director(int directorid, string firstName, string lastName)
        {
            this.DirectorId = directorid;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}

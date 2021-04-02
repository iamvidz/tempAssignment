using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssignmentService.Models
{
    public class Student : User
    {
        string teacher = string.Empty;

        public string Teacher
        {
            get { return teacher; }
            set { teacher = value; }
        }
    }
}
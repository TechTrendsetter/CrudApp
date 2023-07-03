using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Abdullah.Models
{
    public class StudentVM
    {
        public Student Student { get; set; }

        public IEnumerable<Student> Students { get; set; }

    }
}
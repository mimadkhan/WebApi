using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class Student
    {
        public long StudentId { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public long GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}

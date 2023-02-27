using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppApi.Models
{
    public class Group
    {
        public long GroupId { get; set; }
        public string GroupName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}

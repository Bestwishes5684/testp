using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student
    {
        public string? FullName { get; set; }
        public Guid Id { get; set; } 
        public string Datarod { get; set; }

        public string Gender { get; set; }

        public string FormOB { get; set; }

        public decimal Russ { get; set; }

        public decimal Math { get; set; }
        public decimal inf { get; set; }
        
       public decimal total { get; set; }

        internal void Remove(Student data)
        {
            throw new NotImplementedException();
        }
    }
}

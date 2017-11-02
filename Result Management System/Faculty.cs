using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Result_Management_System
{
    class Faculty
    {
        public int Id { get; }
        public string Name { get; }
        public string Initial { get; }
        public string Department { get; }

        public Faculty(int id, string name, string initial, string department)
        {
            Id = id;
            Name = name;
            Initial = initial;
            Department = department;
        }
    }
}

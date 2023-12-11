using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10120651_PROG3B_POE_PART_1
{
    internal class Employee
    {
       
            public int EmpNo { get; set; }
            public string Name { get; set; }
            public Employee(int empNo, string name) => (EmpNo, Name) = (empNo, name);
        
    }
}

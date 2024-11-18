using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazdeUsuario.models
{
    internal class Student
    {
        public string Name { get; set; }    
        public string Email { get; set; }   
        public string Cif { get; set; } 

        public Student(string name, string email, string cif)
        {
            Name = name;
            Email = email;
            Cif = cif;
        }   
    }
}

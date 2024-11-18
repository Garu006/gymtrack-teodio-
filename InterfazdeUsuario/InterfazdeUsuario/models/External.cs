using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.DocumentStructures;

namespace InterfazdeUsuario.models
{
    internal class External
    {
        public string Name { get; set; }   
        public string Email { get; set; }   
        public string Cedula { get; set; }    

        public External(string name, string email, string cedula)
        {
            Name = name;
            Email = email;
            Cedula = cedula;
        }
    }
}

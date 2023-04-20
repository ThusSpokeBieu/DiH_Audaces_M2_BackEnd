using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carros
{
    public class Owner
    {
       private string Name { get; set; }
       private string CPF { get; set; }
       private string Telephone { get; set; }

       public Owner(    string name, 
                        string cpf, 
                        string telephone ) {
            Name = name;
            CPF = cpf;
            Telephone = telephone;
                        }
    }
}
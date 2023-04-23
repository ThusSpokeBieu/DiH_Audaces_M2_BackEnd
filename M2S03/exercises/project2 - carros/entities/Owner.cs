using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace carros.entities
{
    public class Owner
    {
       public string Name { get; private set; }
       public string CPF { get; private set; }
       public string Telephone { get; private set; }
       public string Birthday { get; private set; }
       public string Gender { get; private set; }

       public Owner(    string name, 
                        string cpf, 
                        string telephone,
                        string birthday,
                        string gender ) 
        {
            
            if (!ValidateCPF(cpf)) {
                throw new Exception("CPF inválido.");
            }

            if (!ValidatePhone(telephone)) {
                throw new Exception("Telefone inválido.");
            }

            if (!ValidateBirthday(birthday)) {
                throw new Exception("Data de nascimento inválida");
            }

            if (!ValidateGender(gender)) {
                throw new Exception("Gênero inválido.");
            }

            Name = name;
            CPF = cpf;
            Telephone = telephone;
            Birthday = birthday;
            Gender = gender;
        }

        public static bool ValidateCPF(string cpf) {
            string pattern = @"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})";
            if (!Regex.IsMatch(cpf, pattern))
            {
                return false;
            }
            
            return true;
        }

        public static bool ValidatePhone(string phone) {
            string pattern = @"^\(\d{2}\)\s\d{4,5}-\d{4}$";
            if (!Regex.IsMatch(phone, pattern))
            {
                return false;
            }

            return true;
        }

        public static bool ValidateBirthday(string birthday) {
            string pattern = @"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$";
            if (!Regex.IsMatch(birthday, pattern))
            {
                return false;
            }

            return true;
        }

        public static bool ValidateGender(string gender) {

            if (gender.ToUpper() == "MASCULINO") {
                return true;
            }

            if (gender.ToUpper() == "FEMININO") {
                return true;
            }

            if (gender.ToUpper() == "OUTRO") {
                return true;
            }

            return false;
        }
    }
}
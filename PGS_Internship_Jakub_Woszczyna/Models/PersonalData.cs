using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PGS_Internship_Jakub_Woszczyna.Models
{
    public class PersonalData
    {
        public string Name { get; set; } = "Wpisz imię...";
        public string Surname { get; set; } = "Wpisz nazwisko...";
        public string HomeAddress { get; set; } = "Wpisz adres...";
        public string PhoneNumber { get; set; } = "Wpisz numer telefonu...";

        public override string ToString()
        {
            string result = $@"
Twoje dane osobiste to:
Imię: {Name}
Nazwisko: {Surname}
Adres zamieszkania: {HomeAddress}
Numer telefonu: {PhoneNumber}
";
            return result;
        }
    }
}

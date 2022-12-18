using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class DoctorInformation
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public DateTime Birthday { get; set; }

        public DoctorInformation(string name, string surname, string address, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Address = address;
            Birthday = birthday;
        }

        public DoctorInformation()
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class dc
    {
        public string id;
        public string name;
        public string specialty;
        public dc()
        {
            id = "";
            name = specialty = "";
        }
    }
    public class patient
    {
        public string id;
        public string disease;
        public string name;
        public string appointment_date;
        public string doctor_id;
        public patient()
        {
            id = doctor_id = "";
            name = disease = appointment_date = "";
        }
    }
}

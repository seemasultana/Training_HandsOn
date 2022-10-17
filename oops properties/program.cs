
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Program
    {

        static void Main(string[] args)
        {
            Patient1 patient1 = new Patient1();
            patient1.patientappoint();
            patient1.patientage();
            patient1.patientname();

            Patient2 patient2 = new Patient2();
            patient2.patientappoint();
            patient2.patientage();
            patient2.patientname();

            Doctor doctor = new Doctor();
            doctor.checkup();
        }
    }
}



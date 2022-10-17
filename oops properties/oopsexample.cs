using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oops
{
    public class HospitalManagement
    {
        public string name;
        public int age;
        public string appointdate;


        public virtual void patientappoint()
        {
            Console.WriteLine(appointdate);
        }

        public virtual void patientname()
        {
            Console.WriteLine(name);
        }

        public virtual void patientage()
        {
            Console.WriteLine(age);
        }
    }


    public class Patient1 : HospitalManagement
    {

        public string appointdate = "11-10-2022";

        public override void patientappoint()
        {
            Console.WriteLine("The appoint date of patient1 is " +appointdate);
        }

        public string name = "Ramakrishna";

        public override void patientname()
        {
            Console.WriteLine("The name of the patient1 is " +name);
        }

        public int age = 44;

        public override void patientage()
        {
            Console.WriteLine("The age of patient1 is " +age);
        }
    }
    public class Patient2 : HospitalManagement
    {

        public string appointdate = "12-10-2022";

        public override void patientappoint()
        {
            Console.WriteLine("The appoint date of patient2 is " +appointdate);
        }
        public string name = "Satish";

        public override void patientname()
        {

            Console.WriteLine("The name of patient2 is " +name);
        }

        public int age = 32;

        public override void patientage()
        {
            Console.WriteLine("The age of patient2 is " +age);
        }

    }
    interface IHospitalManagement
    {
        void checkup();
    }
    class Doctor : IHospitalManagement
    {
        public void checkup()
        {
            Console.WriteLine("doctor needs to checkup the patients");
        }

    }

   
}









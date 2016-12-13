using System;
using System.Collections.Generic;
namespace WindowsFormsApplication1
{
    public class AllPatients
    {
        private List<Patient> patients;

        public AllPatients()
        {
            patients = new List<Patient>();
        }

        public void add(Patient newP)
        {
            patients.add(newP);
        }
    }
}
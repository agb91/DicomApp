using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class AllPatients
    {
        private List<Patient> patients;
        private string path;
        public AllPatients(string path)
        {
            this.path = path;
            patients = new List<Patient>();
            buildPatient();
        }
        public void add(Patient newP)
        {
            patients.Add(newP);
        }

        public List<Patient> getPatients()
        {
            return patients;
        }


        //create a grid with all the patients, and each patient all the visits
        public void fillIndexFile()
        {

            for (int i = 0; i < patients.Count; i++)
            {
                Patient thisPatient = patients[i];
                string toAdd = thisPatient.getSurname() + " --> ";
                List<Visit> visitsThisPatient = thisPatient.getVisits();
                for(int a = 0; a < visitsThisPatient.Count; a++)
                {
                    Visit v = visitsThisPatient[a];
                    toAdd = toAdd + "  visit: " + v.getDate() + ";";
                }
                toAdd = toAdd + "\n";
                Global.addIndex(toAdd);
            }
            //Global.writeToFile();
        }

        //in patients there are all the information related to the fileindex
        public List<Patient> getIndexFile()
        {
            return patients;
        }

        private void buildPatient()
        {
            FoldersHandler fh = new FoldersHandler(path);
            List<String> lsf = fh.getSubFolders();
            for (int i = 0; i < lsf.Count; i++)
            {
                Patient p = new Patient(path + "\\" + lsf[i]);
                patients.Add(p);
            }
        }
    }
}
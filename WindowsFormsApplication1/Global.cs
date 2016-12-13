using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace WindowsFormsApplication1
{
    internal static class Global
    {
        private static String indexFile;

        public static AllPatients buildAllData()
        {
            //read al the folders in ROOT (each folder is a patient)
            FoldersHandler fh = new FoldersHandler("ROOT");
            List<String> lsf = fh.getSubFolders();
          
            //get all the patient in their objects
            AllPatients ap = new AllPatients("ROOT");
            List<Patient> lp = ap.getPatients();

            //for each patient show all the visits
            for (int i = 0; i < lp.Count; i++)
            {
                Patient p = lp[i];
                List<Visit> lv = p.getVisits();
            }

            //create in Global a structure with all the initial info about
            //patient and visitis
            ap.fillIndexFile();
            return ap;
        }
        public static void Initialize()
        {
            indexFile = "";
        }

        public static void addIndex( String newIndex )
        {
            indexFile = indexFile + newIndex;
        }

        public static String getIndex()
        {
            return indexFile;
        }

        public static void writeToFile()
        {
            var text = new textParser("indexFile.txt", "second passphrase test");
            text.Write(indexFile);
        }

        private static String[] toggleEmpty(String[] before)
        {
            List<String> resultL = new List<String>();
            for (int i = 0; i < before.Length; i++)
            {
                String word = before[i];
                if (!String.IsNullOrEmpty(word))
                {
                    resultL.Add(word);
                }
            }
            string[] result = new string[resultL.Count];
            for (int i = 0; i < resultL.Count; i++)
            {
                result[i] = resultL[i];
            }
            return result;
        }
            
        public static String[] splitter( String whole , Char delimiter )
        {
            String[] substrings = whole.Split(delimiter);
            substrings = toggleEmpty(substrings);
            return substrings;
        }
            
        public static String rightEqual(String doubleString)
        {
            //MessageBox.Show(doubleString);
            Char delimiter = '=';
            String ris = "";
            ris = doubleString.Split(delimiter)[1];
            //MessageBox.Show(ris);
            return ris;
        }
        public static String leftEqual(String doubleString)
        {
            Char delimiter = '=';
            return doubleString.Split(delimiter)[0];
        }

        public static String nextFreePatient()
        {
            string[] subdirectoryEntries = Directory.GetDirectories("ROOT\\");
            string last = subdirectoryEntries[ subdirectoryEntries.Length - 1 ];
            last = splitter(last, '\\')[1];
            int intLast = int.Parse( last );
            intLast++;
            string ris = intLast.ToString();
            int toAdd = 4-ris.Length;
            for( int i = 0; i < toAdd; i++)
            {
                ris = "0" + ris;
            }
            return ris;
        }

    }
}
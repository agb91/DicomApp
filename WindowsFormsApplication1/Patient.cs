using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static WindowsFormsApplication1.Global;

namespace WindowsFormsApplication1
{
    public class Patient
    {
        private string path;
        private string name;
        private string surname;
        private string id;
        private string CF;
        private string date;
        private string sex;
        private string notes;
        private string infoFile;
        private List<Visit> visits;
        private List<OptionalInfo> listOfOptionalInfo;
        private textParser text;
        private textParser baseTags;

        public Patient(string path)
        {
            this.path = path;
            visits = new List<Visit>();
            listOfOptionalInfo = new List<OptionalInfo>();
            infoFile = getInfoFile();
            text = new textParser(path + "\\" + infoFile, "first passphrase test");
            buildPatient();
        }

        public string getPath()
        {
            return path;
        }

        public string getId()
        {
            return id;
        }

        public string getCF()
        {
            return CF;
        }

        public List<Visit> getVisits()
        {
            return visits;
        }

        public void addVisit(Visit v)
        {
            visits.Add(v);
        }

        public String getName()
        {
            return name;
        }

        public String getSurname()
        {
            return surname;
        }

        public String getSex()
        {
            return sex;
        }

        public String getNotes()
        {
            return notes;
        }

        public String getDate()
        {
            return date;
        }
        public List<OptionalInfo> getOptionals()
        {
            return listOfOptionalInfo;
        }

        public String nextFreeVisit()
        {
            string ris = path + "\\0001"; 
            string[] subdirectoryEntries = Directory.GetDirectories( path );
            if (subdirectoryEntries.Length != 0)
            {
                string last = subdirectoryEntries[subdirectoryEntries.Length - 1];
                last = splitter(last, '\\')[2];
                int intLast = int.Parse(last);
                intLast++;
                ris = intLast.ToString();
                int toAdd = 4 - ris.Length;
                for (int i = 0; i < toAdd; i++)
                {
                    ris = "0" + ris;
                }
                ris = path + "\\" + ris;
            }
            return ris;
        }

        private string getInfoFile()
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            var files = dir.GetFiles("*.*");
            string risp = "";
            foreach (var file in files)
            {
                risp = risp + file.Name;
            }
            return risp;
        }

        private String extractId()
        {
            String ris = "";
            Char delimiter = '\\';
            String[] substrings = splitter(path , delimiter);
            ris = substrings[substrings.Length - 1];
            return ris;
        }

        private void buildOptionalFirst()
        {
            Char delimiterEqual = '=';
            baseTags = new textParser("patientTemplate.txt", "");
            String readText = baseTags.Read();
            Char delimiterSemicolon = ';';
            String [] bricks = readText.Split(delimiterSemicolon);
            for (int i = 0; i < bricks.Length; i++)
            {
                OptionalInfo newOI = new OptionalInfo( leftEqual(bricks[i]), rightEqual(bricks[i]) );
                listOfOptionalInfo.Add(newOI);
            }
        }

        private void buildOptionalNormal( String[] bricks )
        {
            Char delimiterEqual = '=';
            for (int i = 6; i < bricks.Length; i++)
            {
                OptionalInfo newOI = new OptionalInfo(leftEqual(bricks[i]), rightEqual(bricks[i]));
                listOfOptionalInfo.Add(newOI);
            }
        }

        private void buildOptionalInfo( String[] bricks)
        {
            if(bricks.Length<5)//so if this is a new patient
            {
                buildOptionalFirst();
            }
            else//this patient already exist, his file already has information
            {
                buildOptionalNormal(bricks);
            }            
        }


        private void buildPatient()
        {
            String readText = text.Read();
            Char delimiter = ';';
            String[] substrings = splitter( readText , delimiter);
            CF = rightEqual( substrings[0] );
            name = rightEqual( substrings[1] );
            surname = rightEqual( substrings[2] );
            date = rightEqual(substrings[3]);
            sex = rightEqual(substrings[4]);
            notes = rightEqual(substrings[5]);
            buildOptionalInfo(substrings);
            id = extractId();
            buildVisits();
        }

        private void buildVisits()
        {
            FoldersHandler fh = new FoldersHandler(path);
            List<String> lsf = fh.getSubFolders();
            for (int i = 0; i < lsf.Count; i++)
            {
                Visit v = new Visit(path + "\\" + lsf[i]);
                visits.Add(v);
            }
        }

    }
}
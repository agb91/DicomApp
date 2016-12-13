using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using static WindowsFormsApplication1.Global;

namespace WindowsFormsApplication1
{
    public class Visit
    {
        private string date;
        private string result;
        private string path;
        private string infoFile;
        private textParser text;
        private textParser baseTags;
        private List<OptionalInfo> listOfOptionalInfo;

        public Visit (string path)
        {
            this.path = path;
            listOfOptionalInfo = new List<OptionalInfo>();
            infoFile = readInfoFile();
            text = new textParser(path + "\\" + infoFile, "first passphrase test");
            buildVisit();
        }

        public string getPath()
        {
            return path;
        }

        public string getResult()
        {
            return result;
        }

        /*public void writeDate( string newText)
        {
            text.Write(newText);
        }*/

        public string getDate()
        {
            return date;
        }

        private void buildOptionalFirst()
        {
            baseTags = new textParser("visitTemplate.txt", "");
            String readText = baseTags.Read();
            String[] bricks = splitter(readText, ';');
            for (int i = 0; i < bricks.Length; i++)
            {
                OptionalInfo newOI = new OptionalInfo( leftEqual( bricks[i] ) , rightEqual( bricks[i] ) );
                listOfOptionalInfo.Add(newOI);
            }
        }

        private void buildOptionalNormal(String[] bricks)
        {
            for (int i = 2; i < bricks.Length; i++)
            {
                OptionalInfo newOI = new OptionalInfo( leftEqual( bricks[i] ), rightEqual( bricks[i] ) );
                listOfOptionalInfo.Add(newOI);
            }
        }

        private void buildOptionals(String[] bricks)
        {
            if (bricks.Length < 3)//so if this is a new visit
            {
                buildOptionalFirst();
            }
            else//this visit already exist, his file already has information
            {
                buildOptionalNormal(bricks);
            }
        }

        private void buildVisit()
        {
            string read = text.Read();
            //MessageBox.Show(read);
            String[] substrings = splitter(read, ';');
            date = rightEqual(substrings[0] );
            result = rightEqual(substrings[1]);
            buildOptionals(substrings);
        }

        public List<OptionalInfo> getOptionals()
        {
            return listOfOptionalInfo;
        }

        private string readInfoFile()
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
    }
}
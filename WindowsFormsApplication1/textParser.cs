using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class textParser
    {
        string Path;
        string password;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;
        FileStream fileStream;
        StreamReader sr;
        StreamWriter sw;

        public textParser( string file , string password)
        {
            Path = new FileInfo( file ?? EXE + ".txt" ).FullName.ToString();
            this.password = password;
        }

        public void Touch ()
        {
            File.Create(Path);
        }

        public string Read()
        {
            string line;
            sr = new StreamReader(Path);
            string result = "";
            line = sr.ReadLine();

            //Continue to read until you reach end of file
            while (line != null)
            {
                //write the lie to console window
                result += line + "\n";
                //Read the next line
                line = sr.ReadLine();
            }

            //close the file
            sr.Close();
            if( password != "")
            {
                result = StringCipher.Decrypt(result, password);
            }
            return result;
        }

        public void Write(string text)
        {
            text = StringCipher.Encrypt(text, password);
            StreamWriter sw = new StreamWriter(Path, false, Encoding.UTF8);
            sw.WriteLine(text);
            sw.Close();
        }

    }
}
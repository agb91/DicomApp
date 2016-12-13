using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using DicomObjects;
using DicomObjects.EventArguments;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            //the login form just for test (user=abs pass=a) 
            //Application.Run( new Form1() );

            //just to test: read an ini file
            //var inifile = new IniFile( "inifile.ini" );
            //inifile.Write( "aValue" , "100" );
            //var result = inifile.Read( "aValue" );
            //MessageBox.Show( result );

            //just to test: read a txt file
            var text = new textParser( "info.txt" , "first passphrase test");
            //var idRidden = text.Read();
            //MessageBox.Show(idRidden);

            //just to text: write a txt file
            var toWrite = "date= 3/4/5; result = nothing particular ; tag1=visitTag1; tag2=visitTag2; tag3=visitTag3;";
            text.Write(toWrite);
            
            //read al the folders in ROOT (each folder is a patient)
            FoldersHandler fh = new FoldersHandler("ROOT");
            List<String> lsf = fh.getSubFolders();
            //MessageBox.Show( lsf[0] );

            //Application.Run( new GridIndex( ap.getIndexFile() ) );
            Application.Run(new GridIndex() );

        }

    }

}

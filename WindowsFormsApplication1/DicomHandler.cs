using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    internal class DicomHandler
    {
        string dicomPath;

        public DicomHandler( String dicomPath)
        {
            this.dicomPath = dicomPath;
            viewerStart();
        }

        private void viewerStart()
        {
            Application.Run(new DicomViewer(dicomPath) );
        }        

    }
}
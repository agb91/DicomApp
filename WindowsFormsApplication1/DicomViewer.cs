using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DicomObjects;
using DicomObjects.EventArguments;

namespace WindowsFormsApplication1
{
    public partial class DicomViewer : Form
    {
        private String path;
        public DicomViewer(String path)
        {
            this.path = path;
            InitializeComponent();
            DicomDataSet dDSet = readDicom();
            writeDicom( dDSet );
            newDicom();
        }

        private void writeDicom( DicomDataSet dDSet )
        {
            dDSet.Write( path + "\\00010001Modified" , "1.2.840.10008.1.2.1");
        }

        private void newDicom()
        {
            DicomImage image = new DicomImage();
            image.Import("ROOT\\0001\\0001\\Dicom\\koala.jpg");
            image.Name = "Koala";
            image.PatientID = "0001";
            image.DateOfBirth = DateTime.Now;
            image.Sex = "M";
            //Add General Study Module
            image.StudyUID = DicomGlobal.NewUID();
            image.DataSet.Add(0x008, 0x0020, DateTime.Now);
            image.DataSet.Add(0x008, 0x0030, DateTime.Now);
            image.DataSet.Add(0x008, 0x0090, "foo");//referring physicians name
            image.DataSet.Add(0x0020, 0x0010, "1");//study ID
            image.AccessionNumber = "1";
            //Add General Series Module
            image.DataSet.Add(0x008, 0x0060, "OTnuovo");//Modality
            image.SeriesUID = DicomGlobal.NewUID();
            image.DataSet.Add(0x0020, 0x0011, "");
            //Add SC Equipment Module
            image.DataSet.Add(0x008, 0x0064, "SI");
            //Add General Image Module
            image.DataSet.Add(0x0020, 0x0013, "");
            image.DataSet.Add(0x0020, 0x0020, "");
            //Add SOP Common Module
            image.DataSet.Add(0x008, 0x0016, DicomObjects.DicomUIDs.SOPClasses.SecondaryCapture);
            image.DataSet.Add(0x008, 0x0018, DicomGlobal.NewUID());
            image.Write(path + "\\00010001Added", "1.2.840.10008.1.2.1");

        }

        private DicomDataSet readDicom()
        {
            DicomImage dImage = Viewer.Images.Read( path + "\\00010001" );
            DicomDataSet dDSet = Viewer.Images.Read( path + "\\00010001" );
            List<DicomAttribute> allAttributes = dDSet.ToList();
            String toShow = "";
            for (int i = 0; i < allAttributes.Count; i++)
            {
                string group = allAttributes[i].Group.ToString("X4");//first 4 numbers
                string element = allAttributes[i].Element.ToString("X4");//second 4 numbers
                string key = allAttributes[i].Keyword;//textual 
                string value = allAttributes[i].ToString();
                toShow = toShow + group + "-" + element + ";  " + key
                    + "--->" + value + "\n";
            }
            MessageBox.Show(toShow);
            return dDSet;
        }

        private void dicomViewer1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DicomObjects;
using DicomObjects.EventArguments;

using static WindowsFormsApplication1.Global;

namespace WindowsFormsApplication1
{
    public partial class VisitsScreen : Form
    {
        private Visit thisV;
        private Patient thisP;
        List<OptionalInfo> allOptionals;
        private textParser baseTags;
        private String path;
        private List<Image> allImages;
        
        public VisitsScreen( Visit thisV, String path , Patient thisP)
        {
            this.thisP = thisP;
            InitializeComponent();
            this.thisV = thisV;
            if (thisV == null)
            {
                MessageBox.Show("New visit. Insert each information in the relative field and Save");
                Directory.CreateDirectory(path + "\\images\\" );
                Directory.CreateDirectory(path + "\\Dicom\\");
                
            }
            this.path = path;
            fillStandard();
            initializeImages();
            fillPatient();
        }

        private void fillPatient()
        {
            nameText.Text = thisP.getName();
            surnameText.Text = thisP.getSurname();
            dateText.Text = thisP.getDate();
            sexText.Text = thisP.getSex();
        }

        private void initializeImages()
        {
            allImages = new List<Image>();
            List<String> names = getImageNames();
            for( var i = 0; i< names.Count; i++)
            {
                addImageToArray(names[i]);
            }
            printImages();
        }

        private void addImageToArray(string imageName)
        {
            Image thisImage = Image.FromFile(imageName);
            allImages.Add(thisImage);
            //MessageBox.Show( allImages.Count.ToString() );
        }

        private List<String> getImageNames()
        {
            List<String> ris = new List<String>();
            string imagesPath = path + "\\images\\";
            DirectoryInfo dir = new DirectoryInfo( imagesPath );
            if( dir.Exists )
            {
                var files = dir.GetFiles("*.*");
                foreach (var file in files)
                {
                    ris.Add(imagesPath + file);
                }
            }            
            return ris;
        }

        private void printImages()
        {
            this.imagesPanel.Controls.Clear();
            for (var i = 0; i < allImages.Count; i++)
            {
                // Assume pic is the type of PictureBox and the image property is assigned
                PictureBox pic = new PictureBox();
                int dim = 150;
                pic.Size = new Size(dim, dim);
                pic.Location = new Point( (dim + 10) * i , 0 );
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Image = allImages[i];
                pic.Click += (s, e) => { clickPic(pic,e); };
                // And that the picturebox is embedded in the Panel variable p.
                this.imagesPanel.Controls.Add(pic);
             }            
        }

        private void clickPic(PictureBox sender, EventArgs e)
        {
            ImageViewer vs = new ImageViewer( sender.Image );
            vs.Show();
        }


        private void writeDicom(DicomDataSet dDSet, string newName)
        {
            dDSet.Write(path + "\\Dicom\\" + newName, "1.2.840.10008.1.2.1");
        }

        private void writeImage( string imagePath , string imageName)
        {
            System.IO.File.Copy( imagePath , path + "\\images\\" + imageName + ".jpg", true);
        }

        private void newDicom(string newName, string sourceImage, string destDicom)
        {
            DicomImage image = new DicomImage();
            image.Import(sourceImage);
            image.Name = newName;
            //image.PatientID = "0001";
            //image.DateOfBirth = DateTime.Now;
            //image.Sex = "M";
            //Add General Study Module
            //image.StudyUID = DicomGlobal.NewUID();
            //image.DataSet.Add(0x008, 0x0020, DateTime.Now);
            //image.DataSet.Add(0x008, 0x0030, DateTime.Now);
            //image.DataSet.Add(0x008, 0x0090, "foo");//referring physicians name
            //image.DataSet.Add(0x0020, 0x0010, "1");//study ID
            //image.AccessionNumber = "1";
            //Add General Series Module
            //image.DataSet.Add(0x008, 0x0060, "OTnuovo");//Modality
            //image.SeriesUID = DicomGlobal.NewUID();
            //image.DataSet.Add(0x0020, 0x0011, "");
            //Add SC Equipment Module
            //image.DataSet.Add(0x008, 0x0064, "SI");
            //Add General Image Module
            //image.DataSet.Add(0x0020, 0x0013, "");
            //image.DataSet.Add(0x0020, 0x0020, "");
            //Add SOP Common Module
            //image.DataSet.Add(0x008, 0x0016, DicomObjects.DicomUIDs.SOPClasses.SecondaryCapture);
            image.DataSet.Add(0x008, 0x0018, DicomGlobal.NewUID());
            image.Write(destDicom, "1.2.840.10008.1.2.1");
        }

        
      /*  private DicomDataSet readDicom(string name)
        {
            string dicomPath = path + "\\Dicom\\" + name;
            //DicomImage dImage = dicomViewer1.Images.Read(dicomPath);
            DicomDataSet dDSet = dicomViewer1.Images.Read(dicomPath);
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
            //MessageBox.Show(toShow);
            return dDSet;
        }
    */
        private void fillStandard()
        {
            this.Visits.Rows.Clear();
            this.Visits.Rows.Add();
            this.Visits.Rows[0].Cells[0].Value = "Date";
            this.Visits.Rows.Add();
            this.Visits.Rows[1].Cells[0].Value = "Result";
            if( thisV != null )
            {
                this.Visits.Rows[1].Cells[1].Value = thisV.getResult();
                this.Visits.Rows[0].Cells[1].Value = thisV.getDate();
            }
            fillOptionals();
        }

        private void addOptionalStandard()
        {
            allOptionals = thisV.getOptionals();
            for (int i = 0; i < allOptionals.Count; i++)
            {
                OptionalInfo thisOption = allOptionals[i];
                this.Visits.Rows.Add();
                this.Visits.Rows[i + 2].Cells[0].Value = thisOption.getTag();
                this.Visits.Rows[i + 2].Cells[1].Value = thisOption.getValue();
            }
        }

        private void addOptionalNew()
        {
            int indexRow = 2;
            baseTags = new textParser("visitTemplate.txt", "");
            String readText = baseTags.Read();
            Char delimiterSemicolon = ';';
            String[] bricks = splitter(readText, delimiterSemicolon);
            for (int i = 0; i < bricks.Length; i++)
            {
                this.Visits.Rows.Add();
                this.Visits.Rows[indexRow].Cells[0].Value = leftEqual(bricks[i]);
                indexRow++;
            }
        }

        private void fillOptionals()
        {
            if (thisV != null)
            {
                addOptionalStandard();
            }
            else
            {
                addOptionalNew();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string newDirectory = path;
            Directory.CreateDirectory(newDirectory);

            string toInsert = "";
            for (int i = 0; i < this.Visits.Rows.Count; i++)
            {
                toInsert += this.Visits.Rows[i].Cells[0].Value + " = " + this.Visits.Rows[i].Cells[1].Value + ";";
            }
            textParser tp = new textParser(newDirectory + "\\info.txt", "first passphrase test");
            tp.Write(toInsert);
            MessageBox.Show( "inserted in:" + newDirectory + "\\info.txt");
            this.Refresh();
        }

        private void dicomViewer1_Click(object sender, EventArgs e)
        {

        }

        private string findImage()
        {
            //MessageBox.Show("before path: " + path);
            openFileDialogImages.InitialDirectory = path + "\\imagesDefault";
            String selectedFile = "";
            if (openFileDialogImages.ShowDialog() == DialogResult.OK)
            {
                selectedFile = openFileDialogImages.FileName;
            }
            addImageToArray(selectedFile);
            return selectedFile;
        }

        private string getNextFreeNumber()
        {
            string ris = "1";
            DirectoryInfo dir = new DirectoryInfo( path + "\\images\\" );
            if( dir.Exists )
            {
                var files = dir.GetFiles("*.*");
                foreach (var file in files)
                {
                    ris = "" + file;
                    ris = ris.Substring(ris.Length - 5, 1);//because I wanna cut the .png...
                    int intLast = int.Parse(ris);
                    intLast++;
                    ris = intLast.ToString();
                }
            }            
            return ris;
        }

        private string getNextImageName()
        {
            return "image" + getNextFreeNumber();
        }

        private string getNextDicomName()
        {
            return "dicom" + getNextFreeNumber();
        }

        private void AddImage_Click(object sender, EventArgs e)
        {
            string newImagePath = findImage();
            string imageName = getNextImageName();
            string dicomName = getNextDicomName();
            printImages();
            writeImage(newImagePath, imageName);
            newDicom( imageName , newImagePath, path + "\\Dicom\\" + dicomName);
            this.Refresh();
        }

        private void Visits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelPatientMain_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            AnalyzePatient ap = new AnalyzePatient( thisP );
            ap.Show();
            this.Close();
        }
    }
}

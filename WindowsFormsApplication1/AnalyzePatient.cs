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

using static WindowsFormsApplication1.Global;

namespace WindowsFormsApplication1
{
    public partial class AnalyzePatient : Form
    {
        private Patient thisP;
        private textParser baseTags;
        private List<Visit> allVisits;
        public AnalyzePatient(Patient thisP)
        {
            InitializeComponent();
            this.thisP = thisP;
            fillCommons();
            addOptionals();
            fillVisits();
            if (thisP == null)
            {
                MessageBox.Show("New patient. Insert each information in the relative field and Save");
            }
        }

        private void fillVisits()
        {
            if(thisP!=null)
            {
                allVisits = thisP.getVisits();
                this.Visits.Rows.Clear();
                this.Visits.AllowUserToAddRows = false;
                int indexRow = 0;
                for (int i = 0; i < allVisits.Count; i++)
                {
                    Visit thisV = allVisits[i];
                    this.Visits.Rows.Add();
                    this.Visits.Rows[indexRow].Cells[1].Value = thisV.getDate();
                    this.Visits.Rows[indexRow].Cells[2].Value = thisV.getResult();
                    indexRow++;
                }
            }
            else
            {
                this.Visits.Hide();
                this.AddVisit.Hide();
            }
        }

        private void fillCommons()
        {
            if(thisP != null)//if the patient is already existent
            {
                String thisName = thisP.getName();
                nameText.Text = thisName;
                String thisSurname = thisP.getSurname();
                surnameText.Text = thisSurname;
                String thisDate = thisP.getDate();
                dateText.Text = thisDate;
                String thisSex = thisP.getSex();
                sexText.Text = thisSex;
                String thisNotes = thisP.getNotes();
                notesText.Text = thisNotes;
            }
        }

        private void addOptionalStandard()
        {
            int indexRow = 0;
            this.optionalsGrid.Rows.Clear();
            List<OptionalInfo> optionalInfo = thisP.getOptionals();
            for (int i = 0; i < optionalInfo.Count; i++)
            {
                OptionalInfo thisOp = optionalInfo[i];
                this.optionalsGrid.Rows.Add();
                this.optionalsGrid.Rows[indexRow].Cells[0].Value = thisOp.getTag();
                this.optionalsGrid.Rows[indexRow].Cells[1].Value = thisOp.getValue();
                indexRow++;
            }
        }

        private void addOptionalNew()// if the patient is new..
        {
            int indexRow = 0;
            baseTags = new textParser("patientTemplate.txt", "");
            String readText = baseTags.Read();
            Char delimiterSemicolon = ';';
            String[] bricks = splitter( readText , delimiterSemicolon );
            for (int i = 0; i < bricks.Length; i++)
            {
                this.optionalsGrid.Rows.Add();
                this.optionalsGrid.Rows[indexRow].Cells[0].Value = leftEqual(bricks[i]);
                indexRow++;
            }
        }

        private void addOptionals()
        {
            if (thisP != null) //if the patient is already existent
            {
                addOptionalStandard();
            }
            else // if the patient still doesn't exist
            {
                addOptionalNew();
            }            
        }

        private void Save_Click(object sender, EventArgs e)//create a directory with a new patient and all the
            //possible related information
        {
            string newDirectory = "";
            if(thisP != null) // if you are simply going to modify this patient
            {
                newDirectory = thisP.getPath();
            }
            else // if this patient is new
            {
                newDirectory = "ROOT\\" + nextFreePatient();
            }            
            Directory.CreateDirectory( newDirectory );

            string toInsert = "cd = 12345 ;name = " + nameText.Text.Trim() + "; surname = " + surnameText.Text.Trim() + "; date = " 
                    + dateText.Text.Trim() + "; sex = " + sexText.Text.Trim() + "; notes = " + notesText.Text.Trim();

            int options = this.optionalsGrid.RowCount;
            for ( int i = 0; i < options; i++ )
            {
                toInsert += "; " + this.optionalsGrid.Rows[ i ].Cells[ 0 ].Value + " = ";
                toInsert += this.optionalsGrid.Rows[ i ].Cells[ 1 ].Value;
            }
            
            textParser tp = new textParser(newDirectory + "\\info.txt", "first passphrase test");
            tp.Write( toInsert );
            this.Refresh();
        }


        private void Visits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            //MessageBox.Show("Click; visit result. " + allVisits[ e.RowIndex ].getResult() );
            VisitsScreen vs = new VisitsScreen(allVisits[e.RowIndex], allVisits[e.RowIndex].getPath() , thisP );
            vs.Show();
        }

        private void AddVisit_Click(object sender, EventArgs e)
        {
            VisitsScreen vs = new VisitsScreen(null, thisP.nextFreeVisit(), thisP);
            vs.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(1);
        }

        private void back_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(1);
        }
    }
}

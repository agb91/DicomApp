using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication1
{
    public partial class GridIndex : Form
    {
        List<Patient> ps;
        public GridIndex()
        {
            AllPatients ap = Global.buildAllData();
            ps = ap.getIndexFile();
            InitializeComponent();
            fillCells("" , "");
        }

        private bool strContains( String needle, String haystack)
        {
            if(needle == "")
            {
                return false;//or it would be too easy..
            }
            if( haystack.Contains(needle) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void fillCells(String nameQueryS, String cfQueryS)
        {
            int indexRow = 0;//just to know at which row we must write
            this.Patients.Rows.Clear();
            //for each patient, for each visit, write information
            for (int i = 0; i < ps.Count; i++)
            {
                Patient thisP = ps[i];
                String thisName = thisP.getName() + " " + thisP.getSurname();
                String thisCf = thisP.getCF();
                //MessageBox.Show("thisName: |" + thisName + "| vs |" + nameQueryS + "|" );
                if( cfQueryS.ToUpper() == thisCf.ToUpper() || 
                    strContains(nameQueryS.ToUpper(), thisName.ToUpper()) || 
                    strContains(thisName.ToUpper(), nameQueryS.ToUpper()) ||
                    (nameQueryS == "" && cfQueryS == "") )
                {
                    this.Patients.Rows.Add();//add a row
                    this.Patients.Rows[indexRow].Cells[1].Value = thisP.getId();
                    this.Patients.Rows[indexRow].Cells[2].Value = thisName;
                    this.Patients.Rows[indexRow].Cells[3].Value = thisCf;
                    indexRow++;
                }
             }
        }

        private void GridIndex_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.RowIndex
            int indexRow = e.RowIndex;
            //MessageBox.Show("Click; patient id: " + this.Patients.Rows[indexRow].Cells[3].Value);
            Patient thisPatientToSend = null;
            for ( var i = 0; i < ps.Count; i++)
            {
                Patient check = ps[i];
                if ( check.getCF() == this.Patients.Rows[indexRow].Cells[3].Value )
                {
                    thisPatientToSend = ps[i];
                }
            }
            AnalyzePatient ap = new AnalyzePatient( thisPatientToSend );
            ap.Show();
            this.Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            String name = nameQuery.Text.Trim();
            String cf = cfQuery.Text.Trim();
            //MessageBox.Show("name: " + name + ";   cf : " + cf);
            fillCells(name, cf);
        }

        private void Nuovo_Click(object sender, EventArgs e)
        {
            AnalyzePatient ap = new AnalyzePatient( null );
            ap.Show();
            this.Refresh();
        }

        private void nameQuery_TextChanged(object sender, EventArgs e)
        {

        }

        private void cfQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Search_Click(sender, e);
            }
        }

        private void nameQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                Search_Click(sender, e);
            }
        }
    }
}

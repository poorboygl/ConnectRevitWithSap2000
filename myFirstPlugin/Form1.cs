using System;
using ARB=Autodesk.Revit.DB;
using Form = System.Windows.Forms.Form;
using Sap2000;

namespace myFirstPlugin
{
    public partial class Form1 : Form
    {
        ARB.Document _doc;
  
      

        public Form1(ARB.Document doc)
        {
            InitializeComponent();
            _doc = doc;

        }

        private void wall_count_Click(object sender, EventArgs e)
        {
            Sap2000.SapObject sapObject = new Sap2000.SapObject();
            sapObject.ApplicationStart(eUnits.kN_mm_C, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

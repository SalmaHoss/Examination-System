using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmShowGrade
{
    public partial class InsCrsStdReportViewer : Form
    {
        public InsCrsStdReportViewer()
        {
            InitializeComponent();
        }

     

          public void ShowReport(int X)
          {
            // TODO: This line of code loads data into the 'ExaminationSystemDataSet.gradeInEachCourse' table. You can move, or remove it, as needed.
            this.getInsCourseDetailsTableAdapter.Fill(this.ExaminationSystemDataSet.getInsCourseDetails,X);

            this.reportViewer1.RefreshReport();
        }
    }
}

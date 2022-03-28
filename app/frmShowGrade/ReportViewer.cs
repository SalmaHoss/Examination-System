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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }

      

        public void ShowReport(int X)
        {
            // TODO: This line of code loads data into the 'ExaminationSystemDataSet.gradeInEachCourse' table. You can move, or remove it, as needed.
            this.gradeInEachCourseTableAdapter.Fill(this.ExaminationSystemDataSet.gradeInEachCourse,X);

            this.reportViewer1.RefreshReport();
        }

      
    }
}

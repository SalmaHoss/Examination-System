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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void Execute_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtID.Text);
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ShowReport(x);
            reportViewer.Show();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtID2.Text);
            InsCrsStdReportViewer reportViewer = new InsCrsStdReportViewer();
            reportViewer.ShowReport(x);
            reportViewer.Show();
        }


        private void ShowExam_Click(object sender, EventArgs e)
        {
            int x = int.Parse(this.txtExamID.Text);
           ExamQuestions reportViewer = new ExamQuestions();
           reportViewer.ShowExam(x);
           reportViewer.Show();
        }
    }
}

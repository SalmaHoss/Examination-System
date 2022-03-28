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
    public partial class ExamQuestions : Form
    {
        public ExamQuestions()
        {
            InitializeComponent();
        }

      

        public void ShowExam(int X)
        {
            // TODO: This line of code loads data into the 'ExaminationSystemDataSet.examQuesions' table. You can move, or remove it, as needed.
            this.examQuesionsTableAdapter.Fill(this.ExaminationSystemDataSet.examQuesions,X);

            this.reportViewer1.RefreshReport();
        }
    }
}

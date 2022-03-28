using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamCorrection
{
    public partial class CorrectExam : Form
    {
        SqlConnection SC;
        SqlCommand SCmd;
        public CorrectExam()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SC = new SqlConnection();                                                                   //1


            SC.ConnectionString = "Data Source=.;Initial Catalog=ExaminationSystem; " +                         //2
              "Integrated Security = true ; TrustServerCertificate=true";

            SCmd = new SqlCommand("ExamCorrection", SC);
            SCmd.CommandType = CommandType.StoredProcedure;

            //this.lblResult.Hide();
         
        }


        private void CalcGrade_Click(object sender, EventArgs e)
        {
            bool vaild1 = int.TryParse(this.txtExam.Text, out int ExamID);
            bool vaild2 = int.TryParse(this.txtStud.Text, out int StudID);

            if (vaild1 && vaild2)
            {
                SC.Open();
                SCmd.Parameters.AddWithValue("@ID", StudID);
                SCmd.Parameters.AddWithValue("@ExamID", ExamID);

                var permission = (System.Int32)SCmd.ExecuteScalar();
                this.lblResult.Text = permission.ToString();
                SC.Close();
                this.mess.Text = "";
            }
            else this.mess.Text = "not vaild input";
        }
    }
}

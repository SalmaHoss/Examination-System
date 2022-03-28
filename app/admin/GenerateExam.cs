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

namespace WindowsFormsApp1
{
    public partial class GenerateExam : Form
    {
        int SSN;
        public GenerateExam(int _SSN)
        {
            InitializeComponent();
            SSN = _SSN;
        }

        SqlConnection sqlCn = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;

        private void Form3_Load(object sender, EventArgs e)
        {

            sqlCmd = new SqlCommand("InstructorCourse", sqlCn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            DT = new DataTable();

            sqlCmd.Parameters.Add(new SqlParameter("@insID", SSN));
            DA = new SqlDataAdapter(sqlCmd);
            DA.Fill(DT);

            CBC.DataSource = DT;
            CBC.DisplayMember = "Name";
            CBC.ValueMember = "CrsID";

   

        }

        public List<string> /*string[]*/ questionExam()
        {
            sqlCmd = new SqlCommand("select * from QuestionExam", sqlCn);
            sqlCmd.CommandType = CommandType.Text;
            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();
            DA.Fill(DT);
            List<string> list = new List<string>();
            //String[] list = new String[100];
            int i = 0;
            int index = 0;
            while (i < DT.Rows.Count)
            {
                list.Add(DT.Rows[i]["ExamID"].ToString());
                i += 10;
                index++;
            }
            sqlCn.Close();

            return list;
        }
        public List<string> newLt = new List<string>();

        public List<string> filterQuestinOnly31()
        {
            List<string> lt = questionExam();
            for (int i = 0; i < lt.Count; i++)
            {
                sqlCmd = new SqlCommand();
                sqlCmd.Connection = sqlCn;

                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.CommandText = "examQuesions";
                sqlCmd.Parameters.AddWithValue("@ExamID", lt[i]);
                DA = new SqlDataAdapter(sqlCmd);
                DT = new DataTable();
                DA.Fill(DT);
                if (DT.Rows.Count == 31)
                {
                    //lt.RemoveAt(i);
                    newLt.Add(DT.Rows[i]["ExamID"].ToString());
                }
            }
            sqlCn.Close();
            return newLt;
        }

        public string randomGenerateExam()
        {
            List<string> lt = filterQuestinOnly31();
            Random rnd = new Random();
            int index = rnd.Next(lt.Count);//0 count-1
            sqlCn.Close();

            return newLt[index];
        }

        string selectedItem;

        private void comboCrsName_SelectionChangeCommitted(object sender, EventArgs e)
        {

            selectedItem = CBC.GetItemText(CBC.SelectedItem);

        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;

            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "Sp_GenerateExam";
            sqlCmd.Parameters.Add("@crsName", SqlDbType.NVarChar, 15);
            sqlCmd.Parameters.Add("@numOfQuesTrueFalse", SqlDbType.Int);
            sqlCmd.Parameters.Add("@numOfQuesMCQ", SqlDbType.Int);

            sqlCn.Open();

            sqlCmd.Parameters["@crsName"].Value = CBC.Text;
            sqlCmd.Parameters["@numOfQuesTrueFalse"].Value = 3;
            sqlCmd.Parameters["@numOfQuesMCQ"].Value = 7;


            int r = sqlCmd.ExecuteNonQuery();
            this.Text = $"{r} row affected";

            sqlCn.Close();

   


        }

    }
}

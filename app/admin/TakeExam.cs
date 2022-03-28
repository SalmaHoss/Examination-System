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
    public partial class TakeExam : Form
    {
        public TakeExam(int eid,int sid)
        {
            InitializeComponent();
            
            refreshGrid(eid,sid);
        }

        SqlConnection sqlCn = new SqlConnection("Data Source=.;Initial Catalog=ExaminationSystem;Integrated Security=true");
        SqlCommand sqlCmd;
        SqlDataAdapter DA;
        DataTable DT;
        int examId, stuSSN;

        public void refreshGrid(int examID=3,int studentID=0)
        {
            //Form3 f3 = new Form3();
            //string randomExamID;
            //randomExamID = f3.randomGenerateExam();
            
            sqlCmd = new SqlCommand();
            sqlCmd.Connection = sqlCn;
            sqlCmd.Parameters.Clear();
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "examQuesions";
            //var @eid = 6;
            //sqlCmd.Parameters.Add("@ExamID", SqlDbType.Int);
            //sqlCmd.Parameters["@ExamID"].Value = 6;

            //this.Text = randomExamID;
            //exiamID.Text = randomExamID;

            this.Text = examID.ToString();
            examId = examID;
            stuSSN = studentID;

            sqlCmd.Parameters.AddWithValue("@ExamID",examID);
            DA = new SqlDataAdapter(sqlCmd);
            DT = new DataTable();
            DA.Fill(DT);

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //refreshGrid();
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.CommandText = "examAnswer";
            sqlCmd.Parameters.Add("@eid", SqlDbType.Int);
            sqlCmd.Parameters.Add("@sid", SqlDbType.Int);
            sqlCmd.Parameters.Add("@a1", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a2", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a3", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a4", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a5", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a6", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a7", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a8", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a9", SqlDbType.Char, 10);
            sqlCmd.Parameters.Add("@a10", SqlDbType.Char, 10);

        }

        

        public string[] allQuestion()
        {
            //refreshGrid();
            String[] list = new String[10];
            int i = 0;
            int index = 0;
            while (i < DT.Rows.Count)
            {
                list[index] = DT.Rows[i]["QuesStmt"].ToString();
                if (i < 28)
                {
                    i += 4;
                }
                else
                {
                    i++;
                }
                index++;
            }
            return list;
        }

        public String[] allChoice()
        {
            //refreshGrid();
            String[] list2 = new String[29];//all mcq
            int i = 0;
            int index = 0;
            while (i < 29)
            {
                list2[index] = DT.Rows[i]["ChoiceNum"].ToString();
                i++;
                index++;
            }
            return list2;
        }

        public String[] allChoiceStmt()
        {
            //refreshGrid();
            String[] list3 = new String[29];//all mcq
            int i = 0;
            int index = 0;
            while (i <= 28)
            {
                list3[index] = DT.Rows[i]["ChoicStmt"].ToString();
                i++;
                index++;
            }
            return list3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl1.Show();
            userControl1.BringToFront();
        }

        //answer for student must be provided in each user control
        public char[] answersStudent = new char[10];
        public int index;
        public void enterAnswer(char n, int i)
        {
            //refreshGrid();
            index = i;
            answersStudent[index] = n;
            //index++;
            //this.Text = n;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl2.Show();
            userControl2.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl3.Show();
            userControl3.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl4.Show();
            userControl4.BringToFront();

        }

        private void btnQt5_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl5.Show();
            userControl5.BringToFront();

        }

        private void btnQt6_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl6.Show();
            userControl6.BringToFront();
        }

        private void btnQt7_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl8.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl7.Show();
            userControl7.BringToFront();
        }

        private void btnQt8_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl9.Hide();
            userControl10.Hide();

            userControl8.Show();
            userControl8.BringToFront();
        }

        private void btnQt9_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl10.Hide();

            userControl9.Show();
            userControl9.BringToFront();
        }

        private void btnQt10_Click(object sender, EventArgs e)
        {
            userControl1.Hide();
            userControl2.Hide();
            userControl3.Hide();
            userControl4.Hide();
            userControl5.Hide();
            userControl6.Hide();
            userControl7.Hide();
            userControl8.Hide();
            userControl9.Hide();

            userControl10.Show();
            userControl10.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            sqlCn.Open();
            sqlCmd.Parameters.RemoveAt(0);

            sqlCmd.Parameters["@eid"].Value = examId;
            sqlCmd.Parameters["@sid"].Value = stuSSN;
            sqlCmd.Parameters["@a1"].Value = answersStudent[0].ToString();
            sqlCmd.Parameters["@a2"].Value = answersStudent[1].ToString();
            sqlCmd.Parameters["@a3"].Value = answersStudent[2].ToString();
            sqlCmd.Parameters["@a4"].Value = answersStudent[3].ToString();
            sqlCmd.Parameters["@a5"].Value = answersStudent[4].ToString();
            sqlCmd.Parameters["@a6"].Value = answersStudent[5].ToString();
            sqlCmd.Parameters["@a7"].Value = answersStudent[6].ToString();
            sqlCmd.Parameters["@a8"].Value = answersStudent[7].ToString();
            sqlCmd.Parameters["@a9"].Value = answersStudent[8].ToString();
            sqlCmd.Parameters["@a10"].Value = answersStudent[9].ToString();

            int r = sqlCmd.ExecuteNonQuery();
            this.Text = $"{r} row affected";

            sqlCn.Close();
        }

    }
}

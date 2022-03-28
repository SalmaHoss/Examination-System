
using personal;
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

namespace Login
{
    public partial class Form1 : Form
    {
        SqlConnection SqlCN;
        public Form1()
        {
            InitializeComponent();
            SqlCN = new SqlConnection();

            SqlCN.ConnectionString = "Data Source=.;Initial Catalog=ExaminationSystem; " +
                "Integrated Security = true ; TrustServerCertificate=true";
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panEmail_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCmd = new SqlCommand("Sp_CheckUser", SqlCN);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            bool vaild = int.TryParse(txtUserName.Text, out int SSN);
            sqlCmd.Parameters.AddWithValue("@SSN", SqlDbType.Int).Value = SSN;
            sqlCmd.Parameters.AddWithValue("@Pass", SqlDbType.VarChar).Value = txtPassword.Text;



            if (vaild)
            {
                SqlCN.Open();
                int returnProc = Convert.ToInt32(sqlCmd.ExecuteScalar());
                SqlCN.Close();

                if (returnProc == 1)
                {


                    if (SSN == 0)
                    {
                        Admin a = new Admin(0);
                        a.ShowDialog();
                    }
                    else
                    {
                        inst a = new inst(SSN);
                        a.ShowDialog();
                    }

                }
                else if (returnProc == 0)
                {
                    Student s = new Student(SSN);
                    s.ShowDialog();
                }

                else
                    MessageBox.Show("UserName or Password InCorrect");
            }

            else MessageBox.Show("not vaild input");




        }
    

        private void panPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void picPassword_Click(object sender, EventArgs e)
        {

        }

        private void panUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

     
    }
}

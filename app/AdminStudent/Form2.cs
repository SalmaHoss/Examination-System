using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

namespace AdminPerson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        SqlConnection SC;

        SqlCommand SCmd;
        SqlCommand StudCmd;
        SqlCommand DeptCmd;

        DataTable SDTable;
        SqlDataAdapter SDA;


        BindingNavigator InstNav;
        BindingSource InstBinding;
        DataRow Dr;


        private void Form2_Load(object sender, EventArgs e)
        {

            SC = new SqlConnection();

            SC.ConnectionString = "Data Source=.;Initial Catalog=ExaminationSystem; " +
               "Integrated Security = true ; TrustServerCertificate=true";
            StudCmd = new SqlCommand("", SC);
            StudCmd.CommandType = CommandType.StoredProcedure;
            StudCmd.CommandText = "SP_Show_instructorsInfo";

            SDA = new SqlDataAdapter(StudCmd);
            SDTable = new DataTable();

         
            InstBinding = new BindingSource(SDTable, "");
            InstNav = new BindingNavigator(InstBinding);

            this.InstBinding.AddingNew += (obj, s) =>
            {
                Dr = SDTable.NewRow();
                txtID.Text = "";

            };



            this.InstNav.Click += (obj, s) =>
            {
                this.Warning.Text = "";
            };
            InstNav.Dock = DockStyle.Top;
            this.Controls.Add(InstNav);

            //Filling tales wiz data
            SDA.Fill(SDTable);


            //Binding
            txtID.DataBindings.Add("Text", InstBinding, "InsID");
            txtSSN.DataBindings.Add("Text", InstBinding, "SSN");
            txtFirstName.DataBindings.Add("Text", InstBinding, "firstName");
            txtLastName.DataBindings.Add("Text", InstBinding, "lastName");
            dateOfBirth.DataBindings.Add("Text", InstBinding, "dateOfBirth");
            txtStreet.DataBindings.Add("Text", InstBinding, "Street");
            txtCity.DataBindings.Add("Text", InstBinding, "City");
            txtEmail.DataBindings.Add("Text", InstBinding, "Email");
            txtSalary.DataBindings.Add("Text", InstBinding, "Salary");
            txtDeg.DataBindings.Add("Text", InstBinding, "Degeree");
            label9.Visible = false;
            txtPhone.Visible = false;


            //Displaying Genders  
            txtGender.DataBindings.Add("Text", InstBinding, "Gender");
            txtGender.Enabled = true;
            txtGender.Items.Add("M");
            txtGender.Items.Add("F");


        }


        //Delete
        private void button1_Click_1(object sender, EventArgs e)
          {

            SC.Open();
            SqlCommand SCmd2 = new SqlCommand("Sp_deleteInstructor", SC);
            SCmd2.CommandType = CommandType.StoredProcedure;
            SCmd2.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            if (SCmd2.ExecuteScalar() != null)
                this.Warning.Text = SCmd2.ExecuteScalar().ToString();
            else
                this.Warning.Text = "Instructor With SSN: " + this.txtSSN.Text + " is  deleted";
            SCmd2.ExecuteNonQuery().ToString();
            SC.Close();
            //ReFill the table with updates of deleting  :>  Better?
            SDTable.Clear();
            SDA.Fill(SDTable);


        }
        string s;


        //Insertion
        private void button3_Click_1(object sender, EventArgs e)
        {

            SC.Open();
            Warning.Text = "";
            SCmd = new SqlCommand("Sp_InsertInto_tblInstructor", SC);
            SCmd.CommandType = CommandType.StoredProcedure;
            SCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(this.txtID.Text));
            SCmd.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            SCmd.Parameters.AddWithValue("@FName", this.txtFirstName.Text);
            SCmd.Parameters.AddWithValue("@LName", this.txtLastName.Text);
            SCmd.Parameters.AddWithValue("@dateOfBirth", this.dateOfBirth.Value);
            SCmd.Parameters.AddWithValue("@street", this.txtStreet.Text);
            SCmd.Parameters.AddWithValue("@city", this.txtCity.Text);
            SCmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
            SCmd.Parameters.AddWithValue("@ins_Degree", this.txtDeg.Text);
            int.TryParse(this.txtSalary?.Text ?? "12345", out int Salary);
            SCmd.Parameters.AddWithValue("@Salary",Salary);
            int.TryParse(this.txtPhone?.Text ?? "012345", out int phone);
            SCmd.Parameters.AddWithValue("@phoneNum", phone);
            SCmd.Parameters.AddWithValue("@gen", this.txtGender.Text);
            //this.Warning.Text = SCmd.ExecuteScalar().ToString();
            int a = SCmd.ExecuteNonQuery();
            if (a == 0 || a == -1)
            {
                Warning.Text = "Insertion Failed Enter Valid data.";
                SDTable.Clear();
                SDA.Fill(SDTable);
            }
            else
            {
                Warning.Text = "Inserted";

            }
            SC.Close();


        }

        //Update
        private void button2_Click_1(object sender, EventArgs e)
        {
            Warning.Text = "";

            SC.Open();
            SqlCommand sqlCommand;
            sqlCommand = new SqlCommand("Sp_UpdateInfoInstructor", SC);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            sqlCommand.Parameters.AddWithValue("@FName", this.txtFirstName.Text);
            sqlCommand.Parameters.AddWithValue("@LName", this.txtLastName.Text);
            sqlCommand.Parameters.AddWithValue("@insStreetadd", this.txtStreet.Text);
            sqlCommand.Parameters.AddWithValue("@insCityadd", this.txtCity.Text);
            sqlCommand.Parameters.AddWithValue("@insEmail", this.txtEmail.Text);
            int.TryParse(this.txtPhone?.Text ?? "012345", out int phone);
            sqlCommand.Parameters.AddWithValue("@insPhone", phone);
            sqlCommand.Parameters.AddWithValue("@insSalary", Convert.ToInt32(this.txtSalary.Text));
            sqlCommand.Parameters.AddWithValue("@insDegree", this.txtDeg.Text);
            int a = sqlCommand.ExecuteNonQuery();
            if (a == 0)
                Warning.Text = "Upadate Failed Enter Valid data.";
            else
                Warning.Text = "Upadated";



            SC.Close();

        }

    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection SC;

        SqlCommand SCmd;
        SqlCommand StudCmd;
        SqlCommand DeptCmd;

        DataTable SDTable;
        SqlDataAdapter SDA;

        DataTable DDTable;
        SqlDataAdapter DDA;

        BindingNavigator StudNav;
        BindingSource StudBinding;
        BindingSource DeptBinding;
        DataRow Dr;


        private void Form1_Load(object sender, EventArgs e)
        {

            SC = new SqlConnection();

            SC.ConnectionString = "Data Source=.;Initial Catalog=ExaminationSystem; " +
               "Integrated Security = true ; TrustServerCertificate=true";
            StudCmd = new SqlCommand("", SC);
            StudCmd.CommandType = CommandType.StoredProcedure;
            StudCmd.CommandText = "SP_Show_studentsInfo";


            SDA = new SqlDataAdapter(StudCmd);                          
            SDTable = new DataTable();

            //Command and Conn for Dept
            DeptCmd = new SqlCommand("", SC);
            DeptCmd.CommandType = CommandType.StoredProcedure;
            DeptCmd.CommandText = "SelectAllDept";


            DDA = new SqlDataAdapter(DeptCmd);
            DDTable = new DataTable();

            StudBinding = new BindingSource(SDTable, "");
            StudNav = new BindingNavigator(StudBinding); 
            DeptBinding = new BindingSource(DDTable, "");

            this.StudBinding.AddingNew += (obj,s) => {
                Dr = SDTable.NewRow();
                txtID.Text = "";

            };
            /*
            this.StudBinding. += (obj, s) =>
            {
                //Warning.Text = "";
            };
            */


            this.StudNav.Click += (obj, s) =>
            {
                Warning.Text = "";
            };
            StudNav.Dock = DockStyle.Top;
            this.Controls.Add(StudNav);


            //Filling tales wiz data
            SDA.Fill(SDTable);
            DDA.Fill(DDTable);


            //Binding
            txtID.DataBindings.Add("Text", StudBinding, "StudID"); 
            txtSSN.DataBindings.Add("Text", StudBinding, "SSN");
            txtFirstName.DataBindings.Add("Text", StudBinding, "firstName");
            txtLastName.DataBindings.Add("Text", StudBinding, "lastName");
            dateOfBirth.DataBindings.Add("Text", StudBinding, "dateOfBirth");
            txtStreet.DataBindings.Add("Text", StudBinding, "Street");
            txtCity.DataBindings.Add("Text", StudBinding, "City");
            txtEmail.DataBindings.Add("Text", StudBinding, "Email");

            //  txtPhone.DataBindings.Add("Text", StudBinding, "Phone");
            label9.Visible = false;
            txtPhone.Visible = false;


            //Displaying Genders  
            txtGender.DataBindings.Add("Text", StudBinding, "Gender");
            txtGender.Enabled = true;
            txtGender.Items.Add("M");
            txtGender.Items.Add("F");
            
            // Department names retrieval
            comboDept.Enabled = true;
            comboDept.DataSource = DeptBinding;
            comboDept.DisplayMember = "DeptName";
            comboDept.ValueMember = "DepID";                           
            comboDept.DataBindings.Add(new Binding("SelectedValue", StudBinding, "DepID"));

           
        
        }

      


        //Delete
        private void button1_Click(object sender, EventArgs e)
        {
            // SDA.Update(SDTable);
            SC.Open();
            SqlCommand SCmd2 = new SqlCommand("Sp_deleteStudent", SC);
            SCmd2.CommandType = CommandType.StoredProcedure;
            SCmd2.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            if (SCmd2.ExecuteScalar() != null)
                this.Warning.Text = SCmd2.ExecuteScalar().ToString();
            else 
                this.Warning.Text = "Student With SSN: "+ this.txtSSN.Text+" is  deleted";
            SCmd2.ExecuteNonQuery().ToString();


            SC.Close();
            //ReFill the table with updates of deleting  :>  Better?
            SDTable.Clear();
            SDA.Fill(SDTable);


        }
        string s;
        

        //Insertion
        private void button3_Click(object sender, EventArgs e)
        {

            SC.Open();
            Warning.Text = "";


            SCmd = new SqlCommand("Sp_InsertInto_tblStudent", SC);
            SCmd.CommandType = CommandType.StoredProcedure;

            SCmd.Parameters.AddWithValue("@ID", Convert.ToInt32(this.txtID.Text));
            SCmd.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            SCmd.Parameters.AddWithValue("@FName", this.txtFirstName.Text);
            SCmd.Parameters.AddWithValue("@LName", this.txtLastName.Text);
            SCmd.Parameters.AddWithValue("@dateOfBirth",this.dateOfBirth.Value);
            SCmd.Parameters.AddWithValue("@street", this.txtStreet.Text);
            SCmd.Parameters.AddWithValue("@city", this.txtCity.Text);
            SCmd.Parameters.AddWithValue("@Email", this.txtEmail.Text);
            SCmd.Parameters.AddWithValue("@DepID", Convert.ToInt32(this.comboDept.SelectedValue));
            int.TryParse(this.txtPhone?.Text ?? "012345", out int phone);
            SCmd.Parameters.AddWithValue("@phoneNum", phone);
            SCmd.Parameters.AddWithValue("@gen", this.txtGender.Text);
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
            SC.Close();


        }

        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            Warning.Text = "";

            SC.Open();

            SCmd = new SqlCommand("Sp_UpdateInfoStudent", SC);
            SCmd.CommandType = CommandType.StoredProcedure;

            SCmd.Parameters.AddWithValue("@SSN", Convert.ToInt32(this.txtSSN.Text));
            SCmd.Parameters.AddWithValue("@FName", this.txtFirstName.Text);
            SCmd.Parameters.AddWithValue("@LName", this.txtLastName.Text);
            SCmd.Parameters.AddWithValue("@st_Streetadd", this.txtStreet.Text);
            SCmd.Parameters.AddWithValue("@St_cityadd", this.txtCity.Text);
            SCmd.Parameters.AddWithValue("@St_email", this.txtEmail.Text);
            int.TryParse(this.txtPhone?.Text ?? "012345", out int phone);
            SCmd.Parameters.AddWithValue("@St_Phone",  phone  );
            SCmd.Parameters.AddWithValue("@DepID", Convert.ToInt32(this.comboDept.SelectedValue));
            int a = SCmd.ExecuteNonQuery();
            if (a == 0)
                Warning.Text = "Upadate Failed Enter Valid data.";
            else
                Warning.Text = "Upadated";
            SC.Close();

        }

      
    }
}

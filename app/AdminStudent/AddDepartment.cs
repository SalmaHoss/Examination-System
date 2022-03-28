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

namespace AdminStudent
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }
        SqlConnection SC;

        SqlCommand DCmd;
        SqlDataAdapter DDA;
        DataTable DDT;
        BindingNavigator DNav;
        BindingSource DBinding;      //any thing U retrieve U need to bind for it
        DataRow Dr;
        private void AddDepartment_Load(object sender, EventArgs e)
        {
            SC = new SqlConnection();

            SC.ConnectionString = "Data Source=.;Initial Catalog=ExaminationSystem; " +
               "Integrated Security = true ; TrustServerCertificate=true";
            DCmd = new SqlCommand("", SC);
            DCmd.CommandType = CommandType.StoredProcedure;
            DCmd.CommandText = "SelectAllDept";


            DDA = new SqlDataAdapter(DCmd);
            DDT = new DataTable();
            DDA.Fill(DDT);

            DBinding = new BindingSource(DDT, "");
            DNav = new BindingNavigator(DBinding);
            this.Controls.Add(DNav);

            this.DBinding.AddingNew += (obj, s) =>
            {
                Dr = DDT.NewRow();
                txtID.Text = "";

            };
            txtID.DataBindings.Add("Text", DBinding, "DepID");
            txtName.DataBindings.Add("Text", DBinding, "DeptName");

            txtMgr.Enabled = true;
           
            txtMgr.DataBindings.Add("Text", DBinding, "MgrSSN");

            this.DNav.Click += (obj, s) =>
            {
                Warning.Text = "";
            };

        }

        //Delete
        private void button1_Click(object sender, EventArgs e)
        {
            SC.Open();
            SqlCommand SCmd2 = new SqlCommand("deleteDepartment", SC);
            SCmd2.CommandType = CommandType.StoredProcedure;
            SCmd2.Parameters.AddWithValue("@id", Convert.ToInt32(this.txtID.Text));
            if (SCmd2.ExecuteScalar() != null)
                  Warning.Text = "Department Cannot be Deleted.";
              else
                  Warning.Text = "Department Deleted.";
            SCmd2.ExecuteNonQuery();
            SC.Close();
            //ReFill the table with updates of deleting  :>  Better?
            DDT.Clear();
            DDA.Fill(DDT);
        }
        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            SC.Open();
            Warning.Text = "";
            DCmd = new SqlCommand("updateDepartment", SC);

            DCmd.CommandType = CommandType.StoredProcedure;

            DCmd.Parameters.AddWithValue("@id", Convert.ToInt32(this.txtID.Text));
            DCmd.Parameters.AddWithValue("@mgrid", Convert.ToInt32(this.txtMgr.Text));
            DCmd.Parameters.AddWithValue("@name", this.txtName.Text);
            if(DCmd.ExecuteNonQuery() != 0)
                Warning.Text = "Department Updated.";

            else
                Warning.Text = "Department cannot be Updated.";

            DCmd.ExecuteScalar();
            SC.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Warning.Text = "";

            SC.Open();

            DCmd = new SqlCommand("insertDepartment", SC);
            DCmd.CommandType = CommandType.StoredProcedure;
            DCmd.Parameters.AddWithValue("@id", Convert.ToInt32(this.txtID.Text));
            DCmd.Parameters.AddWithValue("@mgrid", Convert.ToInt32(this.txtMgr.Text));
            DCmd.Parameters.AddWithValue("@name", this.txtName.Text);
            if (DCmd.ExecuteNonQuery() != 0)
                Warning.Text = "Department Added.";

            else
                Warning.Text = "Department Cannot be Added ID is repeated OR Instructor doesnot exist.";

            SC.Close();
        }
    }
}
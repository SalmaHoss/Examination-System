using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt1.Text = f.allQuestion()[0];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox1.Items.Add(choice[0] + ") " + stmt[0]);
            comboBox1.Items.Add(choice[1] + ") " + stmt[1]);
            comboBox1.Items.Add(choice[2] + ") " + stmt[2]);
            comboBox1.Items.Add(choice[3] + ") " + stmt[3]);

        }
        
       
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox1.GetItemText(comboBox1.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 0);
            
        }
        
    }
}

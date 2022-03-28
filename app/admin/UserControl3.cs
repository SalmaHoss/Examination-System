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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {
            // Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt3.Text = f.allQuestion()[2];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox3.Items.Add(choice[8] + ") " + stmt[8]);
            comboBox3.Items.Add(choice[9] + ") " + stmt[9]);
            comboBox3.Items.Add(choice[10] + ") " + stmt[10]);
            comboBox3.Items.Add(choice[11] + ") " + stmt[11]);
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox3.GetItemText(comboBox3.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 2);
        }
    }
}

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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt2.Text = f.allQuestion()[1];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox2.Items.Add(choice[4] + ") " + stmt[4]);
            comboBox2.Items.Add(choice[5] + ") " + stmt[5]);
            comboBox2.Items.Add(choice[6] + ") " + stmt[6]);
            comboBox2.Items.Add(choice[7] + ") " + stmt[7]);
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox2.GetItemText(comboBox2.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 1);
        }
    }
}

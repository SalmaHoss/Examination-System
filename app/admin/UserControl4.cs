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
    public partial class UserControl4 : UserControl
    {

        public UserControl4()
        {
            InitializeComponent();
        }

        private void UserControl4_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt4.Text = f.allQuestion()[3];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox4.Items.Add(choice[12] + ") " + stmt[12]);
            comboBox4.Items.Add(choice[13] + ") " + stmt[13]);
            comboBox4.Items.Add(choice[14] + ") " + stmt[14]);
            comboBox4.Items.Add(choice[15] + ") " + stmt[15]);
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox4.GetItemText(comboBox4.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 3);
        }
    }
}

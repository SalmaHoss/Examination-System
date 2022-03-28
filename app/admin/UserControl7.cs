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
    public partial class UserControl7 : UserControl
    {
        public UserControl7()
        {
            InitializeComponent();
        }

        private void UserControl7_Load_1(object sender, EventArgs e)
        {
            // Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt7.Text = f.allQuestion()[6];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox7.Items.Add(choice[24] + ") " + stmt[24]);
            comboBox7.Items.Add(choice[25] + ") " + stmt[25]);
            comboBox7.Items.Add(choice[26] + ") " + stmt[26]);
            comboBox7.Items.Add(choice[27] + ") " + stmt[27]);
        }

        private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox7.GetItemText(comboBox7.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 6);
        }

    }
}

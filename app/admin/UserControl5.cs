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
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
        }

        private void UserControl5_Load(object sender, EventArgs e)
        {
            // Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt5.Text = f.allQuestion()[4];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox5.Items.Add(choice[16] + ") " + stmt[16]);
            comboBox5.Items.Add(choice[17] + ") " + stmt[17]);
            comboBox5.Items.Add(choice[18] + ") " + stmt[18]);
            comboBox5.Items.Add(choice[19] + ") " + stmt[19]);
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox5.GetItemText(comboBox5.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 4);
        }
    }
}

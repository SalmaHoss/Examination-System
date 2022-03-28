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
    public partial class UserControl6 : UserControl
    {
        public UserControl6()
        {
            InitializeComponent();
        }

        private void UserControl6_Load(object sender, EventArgs e)
        {
            // Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt6.Text = f.allQuestion()[5];
            string[] choice = f.allChoice();
            string[] stmt = f.allChoiceStmt();
            comboBox6.Items.Add(choice[20] + ") " + stmt[20]);
            comboBox6.Items.Add(choice[21] + ") " + stmt[21]);
            comboBox6.Items.Add(choice[22] + ") " + stmt[22]);
            comboBox6.Items.Add(choice[23] + ") " + stmt[23]);
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox6.GetItemText(comboBox6.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 5);
        }

    }
}

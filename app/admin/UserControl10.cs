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
    public partial class UserControl10 : UserControl
    {
        public UserControl10()
        {
            InitializeComponent();
        }

        private void UserControl10_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt10.Text = f.allQuestion()[9];
            comboBox10.Items.Add("True");
            comboBox10.Items.Add("False");
        }

        private void labQt10_Click(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            //labQt10.Text = f.allQuestion()[9];
        }

        private void comboBox10_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox10.GetItemText(comboBox10.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 9);
        }
    }
}

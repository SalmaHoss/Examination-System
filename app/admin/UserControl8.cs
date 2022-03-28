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
    public partial class UserControl8 : UserControl
    {
        public UserControl8()
        {
            InitializeComponent();
        }
        private void UserControl8_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt8.Text = f.allQuestion()[7];
            comboBox8.Items.Add("True");
            comboBox8.Items.Add("False");
        }

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox8.GetItemText(comboBox8.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 7);
        }

    }
}

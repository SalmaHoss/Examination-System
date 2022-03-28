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
    public partial class UserControl9 : UserControl
    {
        public UserControl9()
        {
            InitializeComponent();
        }

        private void UserControl9_Load(object sender, EventArgs e)
        {
            //Form2 f = new Form2();
            var f = this.Parent as TakeExam;

            labQt9.Text = f.allQuestion()[8];       
            comboBox9.Items.Add("True");
            comboBox9.Items.Add("False");
            
        }

        private void comboBox9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string selectedItem;
            char ans;
            selectedItem = comboBox9.GetItemText(comboBox9.SelectedItem);
            ans = selectedItem[0];
            var parent = this.Parent as TakeExam;
            parent.enterAnswer(ans, 8);
        }

    }
}

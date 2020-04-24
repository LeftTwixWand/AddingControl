using System;
using System.Windows.Forms;

namespace AddingControl
{
    public partial class MyControl : UserControl
    {
        public MyControl()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }
    }
}
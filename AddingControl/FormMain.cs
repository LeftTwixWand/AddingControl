using System;
using System.Windows.Forms;

namespace AddingControl
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Controls.Add(new MyControl() { Name = "myControl", Dock = DockStyle.Fill });
            Controls["myControl"].BringToFront();
        }
    }
}

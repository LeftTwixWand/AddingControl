using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AddingControl
{
    public partial class FormMain : Form
    {

        Stopwatch stopwatch = new Stopwatch();
        public FormMain()
        {
            InitializeComponent();
        }

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        base.CreateParams.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
        //        return base.CreateParams;
        //    }
        //}

        private void ButtonShow_Click(object sender, EventArgs e)
        {  
            stopwatch.Restart();
            
            myControl1.BringToFront();
            myControl1.Visible = !myControl1.Visible;
            
            stopwatch.Stop();

            labelResult.Text = $"Elapsed time = {stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds / 10 }";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
 
            Controls.Add(new MyControl() { Dock = DockStyle.Fill, Name = "myControl" });
            Controls["myControl"].BringToFront();
            
            stopwatch.Stop();

            labelResult.Text = $"Elapsed time = {stopwatch.Elapsed.Hours}:{stopwatch.Elapsed.Minutes}:{stopwatch.Elapsed.Seconds}.{stopwatch.Elapsed.Milliseconds / 10 }";

        }
    }
}
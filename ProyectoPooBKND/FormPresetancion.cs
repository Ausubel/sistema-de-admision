using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoPooBKND
{
    public partial class FormPresetancion : Form
    {
        public FormPresetancion()
        {
            InitializeComponent();
        }

        private void FormPresetancion_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FormPresetancion_Deactivate(object sender, EventArgs e)
        {


        }

        private void FormPresetancion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 welcome = new Form1();
            welcome.ShowDialog();
        }
    }
}

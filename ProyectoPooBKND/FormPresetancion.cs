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
            Opacity = 0;
            CenterToScreen();
        }

        private void FormPresetancion_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1) Opacity += 0.02;
            progressBar1.Value += 2;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Opacity -= 0.03;
            if (Opacity == 0)
            {
                timer2.Stop();
                Close();
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
            Hide();
            Form1 bienvenido = new Form1();
            bienvenido.ShowDialog();
        }
    }
}

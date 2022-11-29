using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPooBKND
{
    public partial class Form1 : Form
    {
        //ARREGLO PARA ALMACENAR LAS RESPUESTAS
        private static string[] RESPUESTAS;
        //PARA GUARDAR LAS CARTILLAS
        private static string outputAExportar = "";
        //RUTA DEL ARCHIVO .TXT
        private static string RUTA = @"";
        //RUTA DEL ARCHIVO .MD
        private static string RUTAEXPORTAR = @"";
        private void rutas(int aux)
        {
            if (aux == 0)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RESPUESTAS = File.ReadAllLines(openFileDialog.FileName).ToArray();
                    //linkRuta.Text = openFileDialog.FileName;
                    RUTA = @"" + openFileDialog.FileName + "";
                }
            }
            else
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    RUTAEXPORTAR = @"" + openFileDialog.FileName + "";
                }
            }


        }
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            //rutas(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openchildForm(new FormResultados());
        }

        private void button3_Click(object sender, EventArgs e)
        {
  
            openchildForm(new FormInformacion());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;

        private void openchildForm(Form childform)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel3.Controls.Add(childform);
            panel3.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildForm(new FormPostulante());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new FormCalificar());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openchildForm(new FormCalificar());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            timerExit.Enabled = true;

            


        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.03;
            if (this.Opacity == 0)
            {
                timerExit.Stop();
                this.Close();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            openchildForm(new FormResultados());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class FormInformacion : Form
    {
        public FormInformacion()
        {
            InitializeComponent();
            cbbIngenierias.Visible = false;
            cbbHumanidades.Visible = false;
            cbbSalud.Visible = false;
        }

        private void bttnIngenierias_Click(object sender, EventArgs e)
        {
            cbbIngenierias.Visible = true;
            cbbHumanidades.Visible = false;
            cbbSalud.Visible = false;
        }

        private void bttnSalud_Click(object sender, EventArgs e)
        {
            cbbIngenierias.Visible = false;
            cbbHumanidades.Visible = false;
            cbbSalud.Visible = true;
        }

        private void FormInformacion_Load(object sender, EventArgs e)
        {

        }

        private void bttnHumanidades_Click(object sender, EventArgs e)
        {
            cbbIngenierias.Visible = false;
            cbbHumanidades.Visible = true;
            cbbSalud.Visible = false;
        }

        private void cbbIngenierias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbIngenierias.Visible = false;
        }

        private void cbbSalud_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbbSalud.Visible = false;
            if (cbbSalud.SelectedIndex == 0)
            {
                label1.Visible = true;
                label1.Text = "Tiene conocimientos básicos a un nivel medio superior en las áreas de las ciencias naturales." + "\r\n" + "Es creativo e innovador en el estudio de procesos y técnicas biológicas." + "\r\n" + "Tiene habilidades, destrezas y actitudes para la investigación en el campo de las ciencias biológicas." + "\r\n" + "Tiene disponibilidad para el trabajo en equipo mostrando principios y valores éticos." + "\r\n" + "Es observador, proactivo y con capacidad de liderazgo para fomentar el cuidado del ambiente, salud pública y agroindustria." + "\r\n" + "Muestra compromiso e identificación con la universidad, sociedad y ambiente." + "\r\n" + "Evalúa sistemas biológicos y su entorno, aplicando técnicas de análisis clínicos, biológicos, epidemiológicos y forenses, en la determinación de metabolitos, identificación celular, de agentes etiológicos,\r\n vectores en enfermedades metaxénicas, evidencias biológicas en la escena del crimen, de acuerdo con marcos teóricos, avances científicos, política nacional de salud y nuevo código \r\n procesal penal, con actitud ética." + "\r\n" + "Promueve la conservación del medio ambiente y la biodiversidad según marcos teóricos actuales que le permite proponer acciones de desarrollo sostenible y bienestar de la comunidad, en el marco de la \r\n normativa nacional e internacional, mostrando una actitud de respeto al ser humano y su entorno." + "\r\n" + "Gestiona procesos de producción acuícola y agroindustrial, de acuerdo con marcos teóricos interdisciplinarios que contribuyen al desarrollo del sector y responden a la demanda del mercado nacional e\r\n internacional, según normas de calidad sanitaria e inocuidad, con eficacia, eficiencia, actitud ética y responsabilidad social." + "\r\n" + "Gestionar proyectos de investigación, emprendimiento e innovación tecnológica en las áreas de salud, conservación, acuícola y agroindustrial, respondiendo a la demanda del mercado nacional e \r\n internacional, según marcos teóricos interdisciplinarios y avances científicos, con responsabilidadsocial." + "\r\n" + "GRADO ACADÉMICO: Bachiller en Ciencias Biológicas" + "\r\n" + "TÍTULO PROFESIONAL: Biólogo" + "\r\n" + "DURACIÓN DE ESTUDIOS: 5 años y 10 semestres";
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void cbbHumanidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHumanidades.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
               
        }
    }
}

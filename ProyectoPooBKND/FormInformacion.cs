using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

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

        //Iniciamos la conexion
        private static SqlConnection conn = new SqlConnection("SERVER = LAPTOP-6KL9OJU4; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");
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

        private string consultaInsana(int aux) {
            conn.Open();
            string men = "";
            string query = $"SELECT nombre_escuela, perfil_estudiante, competencias_profesionales, datos_adicionales FROM Escuela WHERE id_escuela = {aux+1}";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                men = reg["nombre_escuela"].ToString() + reg["perfil_estudiante"].ToString() + reg["competencias_profesionales"].ToString() + reg["datos_adicionales"].ToString();
            }
            else
            {
                men = "null";
            }
            
            conn.Close();
            return men;
        }

        private void cbbIngenierias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            cbbIngenierias.Visible = false;
            if (cbbIngenierias.SelectedIndex == 0)
            {

                label1.Visible = true;
                label1.Text = consultaInsana(24);
            }
            else if (cbbIngenierias.SelectedIndex == 1)
            {

                label1.Visible = true;
                label1.Text = consultaInsana(25);
            }
            else if (cbbIngenierias.SelectedIndex == 2)
            {

                label1.Visible = true;
                label1.Text = consultaInsana(26);
            }
            else if (cbbIngenierias.SelectedIndex == 3)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(27);
            }
            else if (cbbIngenierias.SelectedIndex == 4)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(28);
            }
            else if (cbbIngenierias.SelectedIndex == 5)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(29);
            }
            else if (cbbIngenierias.SelectedIndex == 6)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(30);
            }
            else if (cbbIngenierias.SelectedIndex == 7)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(31);
            }
            else if (cbbIngenierias.SelectedIndex == 8)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(32);
            }
            else if (cbbIngenierias.SelectedIndex == 9)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(33);
            }
            else if (cbbIngenierias.SelectedIndex == 10)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(34);
            }
            else if (cbbIngenierias.SelectedIndex == 11)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(35);
            }
            else if (cbbIngenierias.SelectedIndex == 12)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(36);
            }
            else if (cbbIngenierias.SelectedIndex == 13)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(37);
            }
            else if (cbbIngenierias.SelectedIndex == 14)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(38);
            }
            else {
                label1.Visible = false;
            }


        }

        private void cbbSalud_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSalud.Visible = false;
            if (cbbSalud.SelectedIndex == 0)
            {

                label1.Visible = true;
                label1.Text = consultaInsana(0);
            }
            else if (cbbSalud.SelectedIndex == 1) {

                label1.Visible = true;
                label1.Text = consultaInsana(1);
            }
            else if (cbbSalud.SelectedIndex == 2)
            {

                label1.Visible = true;
                label1.Text = consultaInsana(2);
            }
            else if (cbbSalud.SelectedIndex == 3)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(3);
            }
            else if (cbbSalud.SelectedIndex == 4)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(4);
            }
            else if (cbbSalud.SelectedIndex == 5)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(5);
            }
            else if (cbbSalud.SelectedIndex == 6)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(6);
            }

            else
            {
                label1.Visible = false;
            }
        }

        private void cbbHumanidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbHumanidades.Visible = false;
            if (cbbHumanidades.SelectedIndex == 0)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(7);
            }
            else if (cbbHumanidades.SelectedIndex == 1)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(8);
            }
            else if (cbbHumanidades.SelectedIndex == 2)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(9);
            }
            else if (cbbHumanidades.SelectedIndex == 3)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(10);
            }
            else if (cbbHumanidades.SelectedIndex == 4)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(11);
            }
            else if (cbbHumanidades.SelectedIndex == 5)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(12);
            }
            else if (cbbHumanidades.SelectedIndex == 6)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(13);
            }
            else if (cbbHumanidades.SelectedIndex == 7)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(14);
            }
            else if (cbbHumanidades.SelectedIndex == 8)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(15);
            }
            else if (cbbHumanidades.SelectedIndex == 9)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(16);
            }
            else if (cbbHumanidades.SelectedIndex == 10)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(17);
            }
            else if (cbbHumanidades.SelectedIndex == 11)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(18);
            }
            else if (cbbHumanidades.SelectedIndex == 12)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(19);
            }
            else if (cbbHumanidades.SelectedIndex == 13)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(20);
            }
            else if (cbbHumanidades.SelectedIndex == 14)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(21);
            }
            else if (cbbHumanidades.SelectedIndex == 15)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(22);
            }
            else if (cbbHumanidades.SelectedIndex == 16)
            {
                label1.Visible = true;
                label1.Text = consultaInsana(23);
            }
            else {
                label1.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
               
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoPooBKND
{
    public partial class FormPostulante : Form
    {
        public FormPostulante()
        {
            InitializeComponent();
            llenarTabla();
        }
        //BRUNNER
        //private static SqlConnection conn = new SqlConnection("SERVER = DESKTOP-UU53QVS; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");
        //ALDAHIR
        private static SqlConnection conn = new SqlConnection("SERVER = LAPTOP-6KL9OJU4; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");

        //METODOS DE LA BASE DE DATOS
        public void consultaInput(string consulta)
        {
            conn.Open();
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void llenarTabla()
        {
            string consulta = "SELECT P.id_postulante AS 'Codigo', CONCAT(P.apellido_paterno,' ',P.apellido_materno,' ',P.nombre) AS 'Postulante', E.nombre_escuela AS 'Carrera', CASE WHEN P.nota IS NULL THEN 'No tiene nota' ELSE CAST(P.nota AS VARCHAR) END AS 'Nota' FROM Postulante P INNER JOIN Escuela E ON P.id_escuela=E.id_escuela; ";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;
        }


        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void label137_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCodigoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void prueba_Click(object sender, EventArgs e)
        {

        }

        private void FormPostulante_Load(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

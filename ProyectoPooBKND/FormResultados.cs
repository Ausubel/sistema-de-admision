using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPooBKND
{
    public partial class FormResultados : Form
    {
        public FormResultados()
        {
            InitializeComponent();

        }
        //BRUNNER
        //private static SqlConnection conn = new SqlConnection("SERVER = DESKTOP-UU53QVS; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");
        //ALDAHIR
        private static SqlConnection conn = new SqlConnection("SERVER = LAPTOP-6KL9OJU4; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");

        private void FormResultados_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT P.id_postulante AS 'Codigo', CONCAT(P.apellido_paterno,' ',P.apellido_materno,' ',P.nombre) AS 'Postulante', E.nombre_escuela AS 'Carrera', CASE WHEN P.nota IS NULL THEN 'No tiene nota' ELSE CAST(P.nota AS VARCHAR) END AS 'Nota' FROM Postulante P INNER JOIN Escuela E ON P.id_escuela=E.id_escuela; ";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dtgResultados.DataSource = dt;
        }

        private void dtgResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblResultados_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
        private static SqlConnection conn = new SqlConnection($"SERVER = {Environment.MachineName}; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");

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
            string consulta = $"SELECT P.[id_postulante] AS 'CODIGO', P.[nombre] AS 'NOMBRE' , P.[apellido_paterno] AS 'A. PATERNO', P.[apellido_materno] AS 'A. MATERNO' ,P.edad AS 'EDAD' , E.nombre_escuela AS 'CARRERA' FROM [Admission].[dbo].[Postulante] P INNER JOIN Escuela E ON P.id_escuela = E.id_escuela inner join Facultad F on F.id_facultad = E.id_facultad";
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
            consultaInput("Delete from postulante where id_postulante = ' " + textBoxCodigoM.Text + "';");
            MessageBox.Show("REGISTRO ELIMINADO");
            llenarTabla();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            consultaInput($"UPDATE postulante SET nombre = '{textBoxNombreM.Text}', apellido_paterno = '{textBoxPatM.Text}', apellido_materno = '{textBoxMatM.Text}',edad = {textBoxEdadM.Text} where id_postulante = {textBoxCodigoM.Text}");
            llenarTabla();
            vaciarTextboxes();
            MessageBox.Show("POSTULANTE MODIFICADO CORRECTAMENTE");
        }
        public void vaciarTextboxes()
        {
            textBoxNombreM.Clear();
            textBoxPatM.Clear();
            textBoxMatM.Clear();
            textBoxEdadM.Clear();
            textBoxCarreraM.Clear();
            textBoxCodigoM.Clear();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigoM.Text = dataGridView3.SelectedCells[0].Value.ToString();
            textBoxNombreM.Text = dataGridView3.SelectedCells[1].Value.ToString();
            textBoxPatM.Text = dataGridView3.SelectedCells[2].Value.ToString();
            textBoxMatM.Text = dataGridView3.SelectedCells[3].Value.ToString();
            textBoxEdadM.Text = dataGridView3.SelectedCells[4].Value.ToString();
            textBoxCarreraM.Text = dataGridView3.SelectedCells[5].Value.ToString();

            //Deshabilito caja de texto carrera
            textBoxCarreraM.Enabled = false;
        }

        private void groupBox10_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

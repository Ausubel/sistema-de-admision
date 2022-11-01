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

namespace funcionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("SERVER = DESKTOP-IJAK7HK; DATABASE=RRHH3; USER ID=sa; PASSWORD=intelectus135");
        public void llenarTabla()
        {
            string consulta = "select NUMRUT,NOM_NOMBRE,NOM_APEPAT,NOM_APEMAT,SUELDO from FUNCIONARIOS";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public void vaciarTextboxes()
        {
            textPaterno.Clear();
            textCodigo.Clear();
            textMaterno.Clear();
            textNombre.Clear();
            textSueldo.Clear();
        }
        public void inputConsulta(string consulta)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           llenarTabla();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCodigo.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textNombre.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textPaterno.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textMaterno.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textSueldo.Text = dataGridView1.SelectedCells[4].Value.ToString();
        }

        private void buttonAgr_Click(object sender, EventArgs e)
        {
            try
            {
                inputConsulta("insert into FUNCIONARIOS (NUMRUT,NOM_NOMBRE,NOM_APEPAT,NOM_APEMAT,SUELDO) values (" + textCodigo.Text + ",'" + textNombre.Text + "','" + textPaterno.Text + "','" + textMaterno.Text + "'," + int.Parse(textSueldo.Text) + ")");
                MessageBox.Show("Registro agregado correctamente");               
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal, considere revisar los tipos de variables asignados");
            }
            llenarTabla();
            vaciarTextboxes();

        }

        private void buttonMo_Click(object sender, EventArgs e)
        {
            try
            {
                inputConsulta("update FUNCIONARIOS set numrut = " + int.Parse(textCodigo.Text) + " ,nom_nombre = '" + textNombre.Text + "',nom_apepat = '" + textPaterno.Text + "',nom_apemat = '" + textMaterno.Text + "',sueldo = '" + int.Parse(textSueldo.Text) + "' where NUMRUT = '" + textCodigo.Text + "'");
                MessageBox.Show("Registro modificado");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal, considere revisar los tipos de variables asignados");
            }
            llenarTabla();
            vaciarTextboxes();
        }

        private void buttonEli_Click(object sender, EventArgs e)
        {
            try
            {
                inputConsulta("delete from FUNCIONARIOS where NUMRUT = " + int.Parse(textCodigo.Text) + " ");
                MessageBox.Show("Registro eliminado");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo salio mal, considere revisar los tipos de variables asignados");
            }
            llenarTabla();
            vaciarTextboxes();
        }
    }
}

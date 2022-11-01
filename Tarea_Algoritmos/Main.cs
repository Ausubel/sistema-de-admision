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

namespace Tarea_Algoritmos
{
    public partial class Main : Form
    {
        //RUTA DEL ARCHIVO RESPUESTAS
        private static string filePath = @"C:\Users\intel\Desktop\respuestas.txt";

        //VARIABLE PARA SU POSTERIOR USO
        private static string CLAVES;

        public Main()
        {
            //Verificando
            if (filePath != null)
            {
                InitializeComponent();
            }
            else
            {
                //ingrese el la ruta
            }
            
        }

        //CONEXION A LA BASE DE DATOS
        private static SqlConnection conn = new SqlConnection("SERVER = AUSUBEL; DATABASE = Admission; USER ID=sa;PASSWORD=intelectus135");

        //METODOS DE LA BASE DE DATOS
        public void consultaInput(string consulta)//mausquerramienta
        {
            conn.Open();
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        //array para guardar las respuestas
        private static string[] RESPUESTAS = File.ReadAllLines(filePath).ToArray();
            
        public void llenarTabla()
        {
            string consulta = "select codigo_postulante as CODIGO,nombre as NOMBRE, apellido_paterno as APE_PATERNO, apellido_materno as APE_MATERNO,nombre_carrera AS CARRERA,nota AS NOTA from postulante p, carrera c where p.codigo_carrera = c.codigo_carrera;";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            llenarTabla();
            textBoxNombre.Enabled = false;
            textBoxCarrera.Enabled = false;
            textBoxMaterno.Enabled = false;
            textBoxPaterno.Enabled = false;
            dataGridView2.DefaultCellStyle.Font = new Font("Comic Sans", 14);
        }

        private void buttonVista_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            for (int i = 0; i < dataGridView2.Columns.Count - 1; i++)
            {
                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView2.Columns[dataGridView2.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                int colw = dataGridView2.Columns[i].Width;
                dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView2.Columns[i].Width = colw;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
        }

        private void buttonBuscarCalificar_Click(object sender, EventArgs e)//PAGCALCULAR
        {
            try
            {
                string consulta = $"select codigo_postulante as CODIGO,nombre as NOMBRE, apellido_paterno as APE_PATERNO, apellido_materno as APE_MATERNO,nombre_carrera AS CARRERA,nota AS NOTA from postulante p, carrera c where p.codigo_carrera = c.codigo_carrera and p.codigo_postulante = {textBoxCodigo.Text};";
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
                for (int i = 0; i < dataGridView2.Columns.Count - 1; i++)
                {
                    dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dataGridView2.Columns[dataGridView2.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    int colw = dataGridView2.Columns[i].Width;
                    dataGridView2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dataGridView2.Columns[i].Width = colw;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Considere revisar el la caja de texto del codigo");
            }
        }
        private void buttonGuardarCalificar_Click(object sender, EventArgs e)
        {
            try
            {
                //contructores
                Calificacion calificacion = new Calificacion(comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem), comboBox3.GetItemText(comboBox3.SelectedItem), comboBox4.GetItemText(comboBox4.SelectedItem), comboBox5.GetItemText(comboBox5.SelectedItem), comboBox6.GetItemText(comboBox6.SelectedItem), comboBox7.GetItemText(comboBox7.SelectedItem), comboBox8.GetItemText(comboBox8.SelectedItem), comboBox9.GetItemText(comboBox9.SelectedItem), comboBox10.GetItemText(comboBox10.SelectedItem));

                calificacion.Calificacion11_20(comboBox11.GetItemText(comboBox11.SelectedItem), comboBox12.GetItemText(comboBox12.SelectedItem), comboBox13.GetItemText(comboBox13.SelectedItem), comboBox14.GetItemText(comboBox14.SelectedItem), comboBox15.GetItemText(comboBox15.SelectedItem), comboBox16.GetItemText(comboBox16.SelectedItem), comboBox17.GetItemText(comboBox17.SelectedItem), comboBox18.GetItemText(comboBox18.SelectedItem), comboBox19.GetItemText(comboBox19.SelectedItem), comboBox20.GetItemText(comboBox20.SelectedItem));

                calificacion.Calificacion21_30(comboBox21.GetItemText(comboBox21.SelectedItem), comboBox22.GetItemText(comboBox22.SelectedItem), comboBox23.GetItemText(comboBox23.SelectedItem), comboBox24.GetItemText(comboBox24.SelectedItem), comboBox25.GetItemText(comboBox25.SelectedItem), comboBox26.GetItemText(comboBox26.SelectedItem), comboBox27.GetItemText(comboBox27.SelectedItem), comboBox28.GetItemText(comboBox28.SelectedItem), comboBox29.GetItemText(comboBox29.SelectedItem), comboBox30.GetItemText(comboBox30.SelectedItem));

                calificacion.Calificacion31_40(comboBox31.GetItemText(comboBox31.SelectedItem), comboBox32.GetItemText(comboBox32.SelectedItem), comboBox33.GetItemText(comboBox33.SelectedItem), comboBox34.GetItemText(comboBox34.SelectedItem), comboBox35.GetItemText(comboBox35.SelectedItem), comboBox36.GetItemText(comboBox36.SelectedItem), comboBox37.GetItemText(comboBox37.SelectedItem), comboBox38.GetItemText(comboBox38.SelectedItem), comboBox39.GetItemText(comboBox39.SelectedItem), comboBox40.GetItemText(comboBox40.SelectedItem));

                calificacion.Calificacion41_50(comboBox41.GetItemText(comboBox41.SelectedItem), comboBox42.GetItemText(comboBox42.SelectedItem), comboBox43.GetItemText(comboBox43.SelectedItem), comboBox44.GetItemText(comboBox44.SelectedItem), comboBox45.GetItemText(comboBox45.SelectedItem), comboBox461.GetItemText(comboBox461.SelectedItem), comboBox47.GetItemText(comboBox47.SelectedItem), comboBox48.GetItemText(comboBox48.SelectedItem), comboBox49.GetItemText(comboBox49.SelectedItem), comboBox50.GetItemText(comboBox50.SelectedItem));

                calificacion.Calificacion51_60(comboBox51.GetItemText(comboBox51.SelectedItem), comboBox52.GetItemText(comboBox52.SelectedItem), comboBox53.GetItemText(comboBox53.SelectedItem), comboBox54.GetItemText(comboBox54.SelectedItem), comboBox55.GetItemText(comboBox55.SelectedItem), comboBox56.GetItemText(comboBox56.SelectedItem), comboBox57.GetItemText(comboBox57.SelectedItem), comboBox58.GetItemText(comboBox58.SelectedItem), comboBox59.GetItemText(comboBox59.SelectedItem), comboBox60.GetItemText(comboBox60.SelectedItem));

                calificacion.Calificacion61_70(comboBox61.GetItemText(comboBox61.SelectedItem), comboBox62.GetItemText(comboBox62.SelectedItem), comboBox63.GetItemText(comboBox63.SelectedItem), comboBox64.GetItemText(comboBox64.SelectedItem), comboBox65.GetItemText(comboBox65.SelectedItem), comboBox66.GetItemText(comboBox66.SelectedItem), comboBox67.GetItemText(comboBox67.SelectedItem), comboBox68.GetItemText(comboBox68.SelectedItem), comboBox69.GetItemText(comboBox69.SelectedItem), comboBox70.GetItemText(comboBox70.SelectedItem));

                calificacion.Calificacion71_80(comboBox71.GetItemText(comboBox71.SelectedItem), comboBox72.GetItemText(comboBox72.SelectedItem), comboBox73.GetItemText(comboBox73.SelectedItem), comboBox74.GetItemText(comboBox74.SelectedItem), comboBox75.GetItemText(comboBox75.SelectedItem), comboBox76.GetItemText(comboBox76.SelectedItem), comboBox77.GetItemText(comboBox77.SelectedItem), comboBox78.GetItemText(comboBox78.SelectedItem), comboBox79.GetItemText(comboBox79.SelectedItem), comboBox80.GetItemText(comboBox80.SelectedItem));

                calificacion.Calificacion81_90(comboBox81.GetItemText(comboBox81.SelectedItem), comboBox82.GetItemText(comboBox82.SelectedItem), comboBox83.GetItemText(comboBox83.SelectedItem), comboBox84.GetItemText(comboBox84.SelectedItem), comboBox85.GetItemText(comboBox85.SelectedItem), comboBox86.GetItemText(comboBox86.SelectedItem), comboBox87.GetItemText(comboBox87.SelectedItem), comboBox88.GetItemText(comboBox88.SelectedItem), comboBox89.GetItemText(comboBox89.SelectedItem), comboBox90.GetItemText(comboBox90.SelectedItem));

                calificacion.Calificacion91_100(comboBox91.GetItemText(comboBox91.SelectedItem), comboBox92.GetItemText(comboBox92.SelectedItem), comboBox93.GetItemText(comboBox93.SelectedItem), comboBox94.GetItemText(comboBox94.SelectedItem), comboBox95.GetItemText(comboBox95.SelectedItem), comboBox96.GetItemText(comboBox96.SelectedItem), comboBox97.GetItemText(comboBox97.SelectedItem), comboBox98.GetItemText(comboBox98.SelectedItem), comboBox99.GetItemText(comboBox99.SelectedItem), comboBox100.GetItemText(comboBox100.SelectedItem));
                //Generando machote
                //calificacion.getRandom();

                //obteniendo datos para evaluar
                CLAVES = calificacion.getMachote();

                textBoxOutput.Text = CLAVES.ToString();
            }
            catch (FormatException es)
            {
                
            }
            

            
        }
        /*PARA SELECCIONAR DATOS DE LA TABLA Y UBICAR EN CAJAS DE TEXTO*/
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigo.Text = dataGridView2.SelectedCells[0].Value.ToString();
            textBoxNombre.Text = dataGridView2.SelectedCells[1].Value.ToString();
            textBoxPaterno.Text = dataGridView2.SelectedCells[2].Value.ToString();
            textBoxMaterno.Text = dataGridView2.SelectedCells[3].Value.ToString();
            textBoxCarrera.Text = dataGridView2.SelectedCells[4].Value.ToString();            
        }
        private int cont = 0;
        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            char[] linea = RESPUESTAS[cont].ToArray();//109
            cont++;

            //Obteniendo codigo de la linea
            int codigo = int.Parse($"{linea[0]}{linea[1]}{linea[2]}{linea[3]}{linea[4]}{linea[5]}{linea[6]}{linea[7]}");
            
            //Obteniendo 
            char[] respuesta = new char[linea.Length - 9];//100

            for (int i = 0; i < linea.Length; i++)
            {
                if (i >= 9)
                {
                    respuesta[i - 9] = linea[i];//respuesta[0] = linea[9] (alt+255)
                }
            }
        }

        private void txtp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
        /*foreach (char c in respuesta) textBoxOutput.Text += c.ToString();
textBoxOutput.Text += "\r\n";*/
        //foreach (char c in CLAVES) textBoxOutput.Text += c.ToString();

    }
}

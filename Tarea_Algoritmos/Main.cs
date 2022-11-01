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
        private double CORRECTO, INCORRECTO, NULO;
        private double[] NOTAS = new double[RESPUESTAS.Length];
        private int LINEASARCHIVO = 0;        

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
            //lee la cantidad de lineas que hay en el txt
            StreamReader sr = new StreamReader(filePath);
            while (sr.ReadLine() != null) { LINEASARCHIVO++; }
            sr.Close();
            comboBoxInicializa();
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
                textBoxCodigo.Text = dataGridView2.SelectedCells[0].Value.ToString();
                textBoxNombre.Text = dataGridView2.SelectedCells[1].Value.ToString();
                textBoxPaterno.Text = dataGridView2.SelectedCells[2].Value.ToString();
                textBoxMaterno.Text = dataGridView2.SelectedCells[3].Value.ToString();
                textBoxCarrera.Text = dataGridView2.SelectedCells[4].Value.ToString();
                textBoxNota.Text = dataGridView2.SelectedCells[5].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Considere revisar el la caja de texto del codigo");
            }
        }
        //CREO OBJETO 
        private static Calificacion calificacion;
        private void constructor()
        {
            //contructores
            calificacion = new Calificacion(comboBox1.GetItemText(comboBox1.SelectedItem), comboBox2.GetItemText(comboBox2.SelectedItem), comboBox3.GetItemText(comboBox3.SelectedItem), comboBox4.GetItemText(comboBox4.SelectedItem), comboBox5.GetItemText(comboBox5.SelectedItem), comboBox6.GetItemText(comboBox6.SelectedItem), comboBox7.GetItemText(comboBox7.SelectedItem), comboBox8.GetItemText(comboBox8.SelectedItem), comboBox9.GetItemText(comboBox9.SelectedItem), comboBox10.GetItemText(comboBox10.SelectedItem));

            calificacion.Calificacion11_20(comboBox11.GetItemText(comboBox11.SelectedItem), comboBox12.GetItemText(comboBox12.SelectedItem), comboBox13.GetItemText(comboBox13.SelectedItem), comboBox14.GetItemText(comboBox14.SelectedItem), comboBox15.GetItemText(comboBox15.SelectedItem), comboBox16.GetItemText(comboBox16.SelectedItem), comboBox17.GetItemText(comboBox17.SelectedItem), comboBox18.GetItemText(comboBox18.SelectedItem), comboBox19.GetItemText(comboBox19.SelectedItem), comboBox20.GetItemText(comboBox20.SelectedItem));

            calificacion.Calificacion21_30(comboBox21.GetItemText(comboBox21.SelectedItem), comboBox22.GetItemText(comboBox22.SelectedItem), comboBox23.GetItemText(comboBox23.SelectedItem), comboBox24.GetItemText(comboBox24.SelectedItem), comboBox25.GetItemText(comboBox25.SelectedItem), comboBox26.GetItemText(comboBox26.SelectedItem), comboBox27.GetItemText(comboBox27.SelectedItem), comboBox28.GetItemText(comboBox28.SelectedItem), comboBox29.GetItemText(comboBox29.SelectedItem), comboBox30.GetItemText(comboBox30.SelectedItem));

            calificacion.Calificacion31_40(comboBox31.GetItemText(comboBox31.SelectedItem), comboBox32.GetItemText(comboBox32.SelectedItem), comboBox33.GetItemText(comboBox33.SelectedItem), comboBox34.GetItemText(comboBox34.SelectedItem), comboBox35.GetItemText(comboBox35.SelectedItem), comboBox36.GetItemText(comboBox36.SelectedItem), comboBox37.GetItemText(comboBox37.SelectedItem), comboBox38.GetItemText(comboBox38.SelectedItem), comboBox39.GetItemText(comboBox39.SelectedItem), comboBox40.GetItemText(comboBox40.SelectedItem));

            calificacion.Calificacion41_50(comboBox41.GetItemText(comboBox41.SelectedItem), comboBox42.GetItemText(comboBox42.SelectedItem), comboBox43.GetItemText(comboBox43.SelectedItem), comboBox44.GetItemText(comboBox44.SelectedItem), comboBox45.GetItemText(comboBox45.SelectedItem), comboBox461.GetItemText(comboBox461.SelectedItem), comboBox47.GetItemText(comboBox47.SelectedItem), comboBox48.GetItemText(comboBox48.SelectedItem), comboBox49.GetItemText(comboBox49.SelectedItem), comboBox50.GetItemText(comboBox50.SelectedItem));

            calificacion.Calificacion51_60(comboBox51.GetItemText(comboBox51.SelectedItem), comboBox52.GetItemText(comboBox52.SelectedItem), comboBox53.GetItemText(comboBox53.SelectedItem), comboBox54.GetItemText(comboBox54.SelectedItem), comboBox55.GetItemText(comboBox55.SelectedItem), comboBox56.GetItemText(comboBox56.SelectedItem), comboBox57.GetItemText(comboBox57.SelectedItem), comboBox58.GetItemText(comboBox58.SelectedItem), comboBox59.GetItemText(comboBox59.SelectedItem), comboBox60.GetItemText(comboBox60.SelectedItem));

            calificacion.Calificacion61_70(comboBox61.GetItemText(comboBox61.SelectedItem), comboBox62.GetItemText(comboBox62.SelectedItem), comboBox63.GetItemText(comboBox63.SelectedItem), comboBox64.GetItemText(comboBox64.SelectedItem), comboBox65.GetItemText(comboBox65.SelectedItem), comboBox66.GetItemText(comboBox66.SelectedItem), comboBox67.GetItemText(comboBox67.SelectedItem), comboBox68.GetItemText(comboBox68.SelectedItem), comboBox69.GetItemText(comboBox69.SelectedItem), comboBox70.GetItemText(comboBox70.SelectedItem));

            calificacion.Calificacion71_80(comboBox71.GetItemText(comboBox71.SelectedItem), comboBox72.GetItemText(comboBox72.SelectedItem), comboBox73.GetItemText(comboBox73.SelectedItem), comboBox74.GetItemText(comboBox74.SelectedItem), comboBox75.GetItemText(comboBox75.SelectedItem), comboBox76.GetItemText(comboBox76.SelectedItem), comboBox77.GetItemText(comboBox77.SelectedItem), comboBox78.GetItemText(comboBox78.SelectedItem), comboBox79.GetItemText(comboBox79.SelectedItem), comboBox80.GetItemText(comboBox80.SelectedItem));

            calificacion.Calificacion81_90(comboBox81.GetItemText(comboBox81.SelectedItem), comboBox82.GetItemText(comboBox82.SelectedItem), comboBox83.GetItemText(comboBox83.SelectedItem), comboBox84.GetItemText(comboBox84.SelectedItem), comboBox85.GetItemText(comboBox85.SelectedItem), comboBox86.GetItemText(comboBox86.SelectedItem), comboBox87.GetItemText(comboBox87.SelectedItem), comboBox88.GetItemText(comboBox88.SelectedItem), comboBox89.GetItemText(comboBox89.SelectedItem), comboBox90.GetItemText(comboBox90.SelectedItem));

            calificacion.Calificacion91_100(comboBox91.GetItemText(comboBox91.SelectedItem), comboBox92.GetItemText(comboBox92.SelectedItem), comboBox93.GetItemText(comboBox93.SelectedItem), comboBox94.GetItemText(comboBox94.SelectedItem), comboBox95.GetItemText(comboBox95.SelectedItem), comboBox96.GetItemText(comboBox96.SelectedItem), comboBox97.GetItemText(comboBox97.SelectedItem), comboBox98.GetItemText(comboBox98.SelectedItem), comboBox99.GetItemText(comboBox99.SelectedItem), comboBox100.GetItemText(comboBox100.SelectedItem));
        }
        private void buttonGuardarCalificar_Click(object sender, EventArgs e)
        {

            constructor();
            try
            {
                if (double.Parse(textBoxCorrecta.Text) > 0 && double.Parse(textBoxIncorrecta.Text) <= 0)
                {
                    CORRECTO = double.Parse(textBoxCorrecta.Text);
                    INCORRECTO = double.Parse(textBoxIncorrecta.Text);
                    NULO = double.Parse(textBoxBlanco.Text);
                }
                else
                {
                    MessageBox.Show("Considere poner los puntajes correctos","",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Considere poner los puntajes correctos", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
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
            char[] linea = RESPUESTAS[cont].ToArray();
            
            
            NOTAS[cont] = 0;
            
            //Obteniendo codigo de la linea
            int codigo = int.Parse($"{linea[0]}{linea[1]}{linea[2]}{linea[3]}{linea[4]}{linea[5]}{linea[6]}{linea[7]}");

            //Obteniendo 
            char[] respuesta = new char[linea.Length - 9];//100
            for (int i = 0; i < linea.Length; i++)
            {
                if (i >= 9)
                {
                    respuesta[i - 9] = linea[i];//respuesta[0] = linea[9] (alt+255)
                    if (CLAVES[i - 9] == respuesta[i - 9] && respuesta[i - 9] != ' ')
                    {
                        textBoxOutput.Text += "1";
                        NOTAS[cont] = NOTAS[cont] + CORRECTO;
                    }
                    if (CLAVES[i - 9] != respuesta[i - 9] && respuesta[i - 9] != ' ')
                    {
                        textBoxOutput.Text += "0";
                        NOTAS[cont] = NOTAS[cont] + INCORRECTO;
                    }
                    if(respuesta[i - 9] == ' ')
                    {
                        textBoxOutput.Text += "N";
                        NOTAS[cont] = NOTAS[cont] + NULO;
                    }
                }
            }
            textBoxNota.Text = NOTAS[cont].ToString(); 
            cont++;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtp1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardarNota_Click(object sender, EventArgs e)
        {
            
            try
            {
                string estonoesnota = textBoxNota.Text.Replace(",", ".");
                consultaInput($"UPDATE postulante SET nota = {estonoesnota} where codigo_postulante = {textBoxCodigo.Text};");
                llenarTabla();
            }
            catch (Exception)
            {
                MessageBox.Show("TE CREES BOBY?");
            }
            buttonBuscarCalificar_Click(sender, e);
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            constructor();
            //Generando machote
            calificacion.getRandom();
            //Obteniendo datos para evaluar
            CLAVES = calificacion.getMachote();
            char[] clavesitas = CLAVES.ToCharArray();
            comboBox1.SelectedText= clavesitas[0].ToString();
            comboBox2.SelectedText = clavesitas[1].ToString();
            comboBox3.SelectedText = clavesitas[2].ToString();
            comboBox4.SelectedText = clavesitas[3].ToString();
            comboBox5.SelectedText = clavesitas[4].ToString();
            comboBox6.SelectedText = clavesitas[5].ToString();
            comboBox7.SelectedText = clavesitas[6].ToString();
            comboBox8.SelectedText = clavesitas[7].ToString();
            comboBox9.SelectedText = clavesitas[8].ToString();
            comboBox10.SelectedText = clavesitas[9].ToString();
            comboBox11.SelectedText = clavesitas[10].ToString();
            comboBox12.SelectedText = clavesitas[11].ToString();
            comboBox13.SelectedText = clavesitas[12].ToString();
            comboBox14.SelectedText = clavesitas[13].ToString();
            comboBox15.SelectedText = clavesitas[14].ToString();
            comboBox16.SelectedText = clavesitas[15].ToString();
            comboBox17.SelectedText = clavesitas[16].ToString();
            comboBox18.SelectedText = clavesitas[17].ToString();
            comboBox19.SelectedText = clavesitas[18].ToString();
            comboBox20.SelectedText = clavesitas[19].ToString();
            comboBox21.SelectedText = clavesitas[20].ToString();
            comboBox22.SelectedText = clavesitas[21].ToString();
            comboBox23.SelectedText = clavesitas[22].ToString();
            comboBox24.SelectedText = clavesitas[23].ToString();
            comboBox25.SelectedText = clavesitas[24].ToString();
            comboBox26.SelectedText = clavesitas[25].ToString();
            comboBox27.SelectedText = clavesitas[26].ToString();
            comboBox28.SelectedText = clavesitas[27].ToString();
            comboBox29.SelectedText = clavesitas[28].ToString();
            comboBox30.SelectedText = clavesitas[29].ToString();
            comboBox31.SelectedText = clavesitas[30].ToString();
            comboBox32.SelectedText = clavesitas[31].ToString();
            comboBox33.SelectedText = clavesitas[32].ToString();
            comboBox34.SelectedText = clavesitas[33].ToString();
            comboBox35.SelectedText = clavesitas[34].ToString();
            comboBox36.SelectedText = clavesitas[35].ToString();
            comboBox37.SelectedText = clavesitas[36].ToString();
            comboBox38.SelectedText = clavesitas[37].ToString();
            comboBox39.SelectedText = clavesitas[38].ToString();
            comboBox40.SelectedText = clavesitas[39].ToString();
            comboBox41.SelectedText = clavesitas[40].ToString();
            comboBox42.SelectedText = clavesitas[41].ToString();
            comboBox43.SelectedText = clavesitas[42].ToString();
            comboBox44.SelectedText = clavesitas[43].ToString();
            comboBox45.SelectedText = clavesitas[44].ToString();
            comboBox461.SelectedText = clavesitas[45].ToString();
            comboBox47.SelectedText = clavesitas[46].ToString();
            comboBox48.SelectedText = clavesitas[47].ToString();
            comboBox49.SelectedText = clavesitas[48].ToString();
            comboBox50.SelectedText = clavesitas[49].ToString();
            comboBox51.SelectedText = clavesitas[50].ToString();
            comboBox52.SelectedText = clavesitas[51].ToString();
            comboBox53.SelectedText = clavesitas[52].ToString();
            comboBox54.SelectedText = clavesitas[53].ToString();
            comboBox55.SelectedText = clavesitas[54].ToString();
            comboBox56.SelectedText = clavesitas[55].ToString();
            comboBox57.SelectedText = clavesitas[56].ToString();
            comboBox58.SelectedText = clavesitas[57].ToString();
            comboBox59.SelectedText = clavesitas[58].ToString();
            comboBox60.SelectedText = clavesitas[59].ToString();
            comboBox61.SelectedText = clavesitas[60].ToString();
            comboBox62.SelectedText = clavesitas[61].ToString();
            comboBox63.SelectedText = clavesitas[62].ToString();
            comboBox64.SelectedText = clavesitas[63].ToString();
            comboBox65.SelectedText = clavesitas[64].ToString();
            comboBox66.SelectedText = clavesitas[65].ToString();
            comboBox67.SelectedText = clavesitas[66].ToString();
            comboBox68.SelectedText = clavesitas[67].ToString();
            comboBox69.SelectedText = clavesitas[68].ToString();
            comboBox70.SelectedText = clavesitas[69].ToString();
            comboBox71.SelectedText = clavesitas[70].ToString();
            comboBox72.SelectedText = clavesitas[71].ToString();
            comboBox73.SelectedText = clavesitas[72].ToString();
            comboBox74.SelectedText = clavesitas[73].ToString();
            comboBox75.SelectedText = clavesitas[74].ToString();
            comboBox76.SelectedText = clavesitas[75].ToString();
            comboBox77.SelectedText = clavesitas[76].ToString();
            comboBox78.SelectedText = clavesitas[77].ToString();
            comboBox79.SelectedText = clavesitas[78].ToString();
            comboBox80.SelectedText = clavesitas[79].ToString();
            comboBox81.SelectedText = clavesitas[80].ToString();
            comboBox82.SelectedText = clavesitas[81].ToString();
            comboBox83.SelectedText = clavesitas[82].ToString();
            comboBox84.SelectedText = clavesitas[83].ToString();
            comboBox85.SelectedText = clavesitas[84].ToString();
            comboBox86.SelectedText = clavesitas[85].ToString();
            comboBox87.SelectedText = clavesitas[86].ToString();
            comboBox88.SelectedText = clavesitas[87].ToString();
            comboBox89.SelectedText = clavesitas[88].ToString();
            comboBox90.SelectedText = clavesitas[89].ToString();
            comboBox91.SelectedText = clavesitas[90].ToString();
            comboBox92.SelectedText = clavesitas[91].ToString();
            comboBox93.SelectedText = clavesitas[92].ToString();
            comboBox94.SelectedText = clavesitas[93].ToString();
            comboBox95.SelectedText = clavesitas[94].ToString();
            comboBox96.SelectedText = clavesitas[95].ToString();
            comboBox97.SelectedText = clavesitas[96].ToString();
            comboBox98.SelectedText = clavesitas[97].ToString();
            comboBox99.SelectedText = clavesitas[98].ToString();
            comboBox100.SelectedText = clavesitas[99].ToString();
            

        }

        /*foreach (char c in respuesta) textBoxOutput.Text += c.ToString();
textBoxOutput.Text += "\r\n";*/
        //foreach (char c in CLAVES) textBoxOutput.Text += c.ToString();
        public void comboBoxInicializa()
        {
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 4;
            comboBox3.SelectedIndex = 4;
            comboBox4.SelectedIndex = 4;
            comboBox5.SelectedIndex = 4;
            comboBox6.SelectedIndex = 4;
            comboBox7.SelectedIndex = 4;
            comboBox8.SelectedIndex = 4;
            comboBox9.SelectedIndex = 4;
            comboBox10.SelectedIndex = 4;
            comboBox11.SelectedIndex = 4;
            comboBox12.SelectedIndex = 4;
            comboBox13.SelectedIndex = 4;
            comboBox14.SelectedIndex = 4;
            comboBox15.SelectedIndex = 4;
            comboBox16.SelectedIndex = 4;
            comboBox17.SelectedIndex = 4;
            comboBox18.SelectedIndex = 4;
            comboBox19.SelectedIndex = 4;
            comboBox20.SelectedIndex = 4;
            comboBox21.SelectedIndex = 4;
            comboBox22.SelectedIndex = 4;
            comboBox23.SelectedIndex = 4;
            comboBox24.SelectedIndex = 4;
            comboBox25.SelectedIndex = 4;
            comboBox26.SelectedIndex = 4;
            comboBox27.SelectedIndex = 4;
            comboBox28.SelectedIndex = 4;
            comboBox29.SelectedIndex = 4;
            comboBox30.SelectedIndex = 4;
            comboBox31.SelectedIndex = 4;
            comboBox32.SelectedIndex = 4;
            comboBox33.SelectedIndex = 4;
            comboBox34.SelectedIndex = 4;
            comboBox35.SelectedIndex = 4;
            comboBox36.SelectedIndex = 4;
            comboBox37.SelectedIndex = 4;
            comboBox38.SelectedIndex = 4;
            comboBox39.SelectedIndex = 4;
            comboBox40.SelectedIndex = 4;
            comboBox41.SelectedIndex = 4;
            comboBox42.SelectedIndex = 4;
            comboBox43.SelectedIndex = 4;
            comboBox44.SelectedIndex = 4;
            comboBox45.SelectedIndex = 4;
            comboBox461.SelectedIndex = 4;
            comboBox47.SelectedIndex = 4;
            comboBox48.SelectedIndex = 4;
            comboBox49.SelectedIndex = 4;
            comboBox50.SelectedIndex = 4;
            comboBox51.SelectedIndex = 4;
            comboBox52.SelectedIndex = 4;
            comboBox53.SelectedIndex = 4;
            comboBox54.SelectedIndex = 4;
            comboBox55.SelectedIndex = 4;
            comboBox56.SelectedIndex = 4;
            comboBox57.SelectedIndex = 4;
            comboBox58.SelectedIndex = 4;
            comboBox59.SelectedIndex = 4;
            comboBox60.SelectedIndex = 4;
            comboBox61.SelectedIndex = 4;
            comboBox62.SelectedIndex = 4;
            comboBox63.SelectedIndex = 4;
            comboBox64.SelectedIndex = 4;
            comboBox65.SelectedIndex = 4;
            comboBox66.SelectedIndex = 4;
            comboBox67.SelectedIndex = 4;
            comboBox68.SelectedIndex = 4;
            comboBox69.SelectedIndex = 4;
            comboBox70.SelectedIndex = 4;
            comboBox71.SelectedIndex = 4;
            comboBox72.SelectedIndex = 4;
            comboBox73.SelectedIndex = 4;
            comboBox74.SelectedIndex = 4;
            comboBox75.SelectedIndex = 4;
            comboBox76.SelectedIndex = 4;
            comboBox77.SelectedIndex = 4;
            comboBox78.SelectedIndex = 4;
            comboBox79.SelectedIndex = 4;
            comboBox80.SelectedIndex = 4;
            comboBox81.SelectedIndex = 4;
            comboBox82.SelectedIndex = 4;
            comboBox83.SelectedIndex = 4;
            comboBox84.SelectedIndex = 4;
            comboBox85.SelectedIndex = 4;
            comboBox86.SelectedIndex = 4;
            comboBox87.SelectedIndex = 4;
            comboBox88.SelectedIndex = 4;
            comboBox89.SelectedIndex = 4;
            comboBox90.SelectedIndex = 4;
            comboBox91.SelectedIndex = 4;
            comboBox92.SelectedIndex = 4;
            comboBox93.SelectedIndex = 4;
            comboBox94.SelectedIndex = 4;
            comboBox95.SelectedIndex = 4;
            comboBox96.SelectedIndex = 4;
            comboBox97.SelectedIndex = 4;
            comboBox98.SelectedIndex = 4;
            comboBox99.SelectedIndex = 4;
            comboBox100.SelectedIndex = 4;
        }
    }
    
}

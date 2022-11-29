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
    public partial class FormCalificar : Form
    {
        public FormCalificar()
        {
            InitializeComponent();
        }

        private void FormCalificar_Load(object sender, EventArgs e)
        {
            rutas(0);
            llenarTabla();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //ARREGLO PARA ALMACENAR LAS RESPUESTAS
        private static string[] RESPUESTAS;
        //PARA GUARDAR LAS CARTILLAS
        private static string outputAExportar = "";
        //RUTA DEL ARCHIVO .TXT
        private static string RUTA = @"";
        //RUTA DEL ARCHIVO .MD
        private static string RUTAEXPORTAR = @"";

        private static SqlConnection conn = new SqlConnection("SERVER = DESKTOP-UU53QVS; DATABASE = Admission ;INTEGRATED SECURITY = TRUE  ");


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

        //UTILIZAMOS LA CLASE DICCIONARIO
        Dictionary<string, string> dicCodigo = new Dictionary<string, string>();
        //Creamos diccionario para obtener los codigos de los alumnos. 
        private void cargarDiccionario()
        {
            // CODIGO STRING, ALTERNATIVAS STRING 
            char[] linea;

            for (int i = 0; i < RESPUESTAS.Length; i++)
            {
                linea = RESPUESTAS[i].ToArray();
                string codigo = $"{linea[0]}{linea[1]}{linea[2]}{linea[3]}{linea[4]}{linea[5]}{linea[6]}{linea[7]}";
                string respuesta = "";
                for (int j = 9; j < 109; j++) respuesta += linea[j].ToString();
                //AGREGANDO LLAVES CON SUS VALORES
                dicCodigo[codigo] = respuesta;
            }
        }
            

        private static string CLAVES;

        //TERCER PASO PARA CALIFICAR
        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            string codigoBus = textBoxCodigo.Text;

            string val;

            if (dicCodigo.TryGetValue(codigoBus, out val))
            {
                double notas = 0;

                char[] chars = dicCodigo[codigoBus].ToCharArray();

                outputAExportar += $"\r\n# {textBoxCodigo.Text}: {textBoxNombre.Text} {textBoxPaterno.Text} {textBoxMaterno.Text}\r\n" +
                    "| CURSO           | NOTA  | CORRECTOS ✅ | INCORRECTOS ❌ | NULOS ⚪ |\r\n" +
                    "| --------------- | ---- | --------- | ----------- | ----- |\r\n";

                double notaParcial = 0;

                int correctoParcial = 0, incorrectoParcial = 0, nuloParcial = 0;

                for (int i = 0; i < 100; i++)
                {
                    if (chars[i] == CLAVES[i] && CLAVES[i] != ' ')
                    {
                        notas += CORRECTO;
                        notaParcial += CORRECTO;
                        correctoParcial++;
                    }
                    if (chars[i] != CLAVES[i] && CLAVES[i] != ' ')
                    {
                        notas += INCORRECTO;
                        notaParcial += INCORRECTO;
                        incorrectoParcial++;
                    }
                    if (chars[i] == ' ')
                    {
                        notas += NULO;
                        notaParcial += NULO;
                        nuloParcial++;
                    }

                    switch (i)
                    {
                        case 6:
                            outputAExportar += $"| FISICA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 13:
                            outputAExportar += $"| GEOGRAFIA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 20:
                            outputAExportar += $"| LITERATURA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 27:
                            outputAExportar += $"| QUIMICA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 34:
                            outputAExportar += $"| ALGEBRA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 41:
                            outputAExportar += $"| TRIGONOMETRIA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 48:
                            outputAExportar += $"| ARITMETICA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 55:
                            outputAExportar += $"| GEOMETRIA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 62:
                            outputAExportar += $"| HISTORIA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 69:
                            outputAExportar += $"| CIVICA |{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 76:
                            outputAExportar += $"| ECONOMIA|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 87:
                            outputAExportar += $"| RAZ. MATEMATICO|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            notaParcial = 0;
                            correctoParcial = 0;
                            incorrectoParcial = 0;
                            nuloParcial = 0;
                            break;
                        case 99:
                            outputAExportar += $"| RAZ. VERBAL|{notaParcial}|{correctoParcial}|{incorrectoParcial}|{nuloParcial}|\r\n";
                            break;
                    }
                }
                textBoxNota.Text = notas.ToString();

                outputAExportar += $"### PUNTAJE TOTAL: {notas}\r\n";

                //ACTUALIZANDO TABLA 
                string consulta = $"SELECT P.[id_postulante] , P.[nombre] , P.[apellido_paterno] , P.[apellido_materno] ,E.nombre_escuela , P.[nota]  FROM [Admission].[dbo].[Postulante] P INNER JOIN Escuela E ON P.id_escuela = E.id_escuela inner join Facultad F on F.id_facultad = E.id_facultad";
                    SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                MessageBox.Show("CALIFICADO CORRECTAMENTE");
            }
            //SE AUTODESHABILITA
            buttonCalificar.Enabled = false;
            buttonGuardarNota.Enabled = true;
        }

        //PRIMER PASO PARA EL FORM CALIFICAR
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            //AQUI
            constructor();
            //Generando machote
            calificacion.getRandom();
            //Obteniendo datos para evaluar
            CLAVES = calificacion.getMachote();//CLAVES VERDADERAS

            char[] clavesitas = CLAVES.ToCharArray();
            comboBox1.SelectedText = clavesitas[0].ToString();
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
            //DESHABILITA EL BOTON RANDOM
            buttonRandom.Enabled = false;

            MessageBox.Show("A continuación, guarde los puntajes.", "Paso 2");
        }

        private void ocultarComboBoxes()
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;
            comboBox7.Enabled = false;
            comboBox8.Enabled = false;
            comboBox9.Enabled = false;
            comboBox10.Enabled = false;
            comboBox11.Enabled = false;
            comboBox12.Enabled = false;
            comboBox13.Enabled = false;
            comboBox14.Enabled = false;
            comboBox15.Enabled = false;
            comboBox16.Enabled = false;
            comboBox17.Enabled = false;
            comboBox18.Enabled = false;
            comboBox19.Enabled = false;
            comboBox20.Enabled = false;
            comboBox21.Enabled = false;
            comboBox22.Enabled = false;
            comboBox23.Enabled = false;
            comboBox24.Enabled = false;
            comboBox25.Enabled = false;
            comboBox26.Enabled = false;
            comboBox27.Enabled = false;
            comboBox28.Enabled = false;
            comboBox29.Enabled = false;
            comboBox30.Enabled = false;
            comboBox31.Enabled = false;
            comboBox32.Enabled = false;
            comboBox33.Enabled = false;
            comboBox34.Enabled = false;
            comboBox35.Enabled = false;
            comboBox36.Enabled = false;
            comboBox37.Enabled = false;
            comboBox38.Enabled = false;
            comboBox39.Enabled = false;
            comboBox40.Enabled = false;
            comboBox41.Enabled = false;
            comboBox42.Enabled = false;
            comboBox43.Enabled = false;
            comboBox44.Enabled = false;
            comboBox45.Enabled = false;
            comboBox461.Enabled = false;
            comboBox47.Enabled = false;
            comboBox48.Enabled = false;
            comboBox49.Enabled = false;
            comboBox50.Enabled = false;
            comboBox51.Enabled = false;
            comboBox52.Enabled = false;
            comboBox53.Enabled = false;
            comboBox54.Enabled = false;
            comboBox55.Enabled = false;
            comboBox56.Enabled = false;
            comboBox57.Enabled = false;
            comboBox58.Enabled = false;
            comboBox59.Enabled = false;
            comboBox60.Enabled = false;
            comboBox61.Enabled = false;
            comboBox62.Enabled = false;
            comboBox63.Enabled = false;
            comboBox64.Enabled = false;
            comboBox65.Enabled = false;
            comboBox66.Enabled = false;
            comboBox67.Enabled = false;
            comboBox68.Enabled = false;
            comboBox69.Enabled = false;
            comboBox70.Enabled = false;
            comboBox71.Enabled = false;
            comboBox72.Enabled = false;
            comboBox73.Enabled = false;
            comboBox74.Enabled = false;
            comboBox75.Enabled = false;
            comboBox76.Enabled = false;
            comboBox77.Enabled = false;
            comboBox78.Enabled = false;
            comboBox79.Enabled = false;
            comboBox80.Enabled = false;
            comboBox81.Enabled = false;
            comboBox82.Enabled = false;
            comboBox83.Enabled = false;
            comboBox84.Enabled = false;
            comboBox85.Enabled = false;
            comboBox86.Enabled = false;
            comboBox87.Enabled = false;
            comboBox88.Enabled = false;
            comboBox89.Enabled = false;
            comboBox90.Enabled = false;
            comboBox91.Enabled = false;
            comboBox92.Enabled = false;
            comboBox93.Enabled = false;
            comboBox94.Enabled = false;
            comboBox95.Enabled = false;
            comboBox96.Enabled = false;
            comboBox97.Enabled = false;
            comboBox98.Enabled = false;
            comboBox99.Enabled = false;
            comboBox100.Enabled = false;
        }

        public void consultaInput(string consulta)
        {
            conn.Open();
            SqlCommand comando = new SqlCommand(consulta, conn);
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void llenarTabla()
        {
            string consulta = "SELECT P.[id_postulante] , P.[nombre] , P.[apellido_paterno] , P.[apellido_materno] ,E.nombre_escuela , P.[nota]  FROM [Admission].[dbo].[Postulante] P INNER JOIN Escuela E ON P.id_escuela = E.id_escuela inner join Facultad F on F.id_facultad = E.id_facultad";


                SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
        }

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

        private void buttonGuardarNota_Click(object sender, EventArgs e)
        {

                string estonoesnota = textBoxNota.Text.Replace(",", ".");
                consultaInput($"UPDATE postulante set nota = {estonoesnota} where id_postulante = {textBoxCodigo.Text};");
                //consultaInput($"UPDATE postulante SET nota = {estonoesnota} where id_postulante = {textBoxCodigo.Text}");
                
                llenarTabla();

                buttonBuscarCalificar_Click(sender, e);
                //SE AUTODESHABILITA
                buttonGuardarNota.Enabled = false;
                buttonCalificar.Enabled = false;

                //Conectando al data griedview

            
        }


        //VARIABLES PARA EL CALIFICAR
        private static double CORRECTO, INCORRECTO, NULO;

        //EVENTO DATA GRID VIEW2
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxCodigo.Text = dataGridView2.SelectedCells[0].Value.ToString();
            textBoxNombre.Text = dataGridView2.SelectedCells[1].Value.ToString();
            textBoxPaterno.Text = dataGridView2.SelectedCells[2].Value.ToString();
            textBoxMaterno.Text = dataGridView2.SelectedCells[3].Value.ToString();
            textBoxCarrera.Text = dataGridView2.SelectedCells[4].Value.ToString();
            textBoxNota.Text = dataGridView2.SelectedCells[5].Value.ToString();
        }

        private void buttonBuscarCalificar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = $"SELECT P.[id_postulante] , P.[nombre] , P.[apellido_paterno] , P.[apellido_materno] ,E.nombre_escuela , P.[nota]  FROM Postulante P INNER JOIN Escuela E ON P.id_escuela = E.id_escuela inner join Facultad F on F.id_facultad = E.id_facultad where id_postulante={textBoxCodigo.Text}";
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

                if (!buttonBuscarCalificar.Enabled)

                    MessageBox.Show("Rellene datos correspondientes.", "Paso 1");

                buttonCalificar.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Revise el código introducido.");
            }
        }


        //SEGUNDO PASO
        private void buttonGuardarcalificar_Click(object sender, EventArgs e)
        {
            constructor();
            try
            {
                if (double.Parse(textBoxCorrecta.Text) > 0 && double.Parse(textBoxIncorrecta.Text) <= 0)
                {
                    CORRECTO = double.Parse(textBoxCorrecta.Text);
                    INCORRECTO = double.Parse(textBoxIncorrecta.Text);
                    NULO = double.Parse(textBoxBlanco.Text);

                    ocultarComboBoxes();

                    buttonCalificar.Enabled = true;
                    buttonGuardarNota.Enabled = true;
                    buttonExportar.Enabled = true;

                    textBoxCorrecta.Enabled = false;
                    textBoxIncorrecta.Enabled = false;
                    textBoxBlanco.Enabled = false;
                    //SE AUTODESHABILITA
                    buttonGuardarCalificar.Enabled = false;

                    MessageBox.Show("¡Hora de calificar!", "Paso 3");
                }
                else
                {
                    MessageBox.Show("Considere poner los puntajes correctos", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }



            }
            catch (Exception)
            {
                MessageBox.Show("Considere revisar las entradas de datos", "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
        }
    }
}

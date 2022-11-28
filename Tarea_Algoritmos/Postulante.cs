using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_Algoritmos
{
    internal class Postulante
    {
        //Atributos 
        private string nombre;
        private string apellido_p;
        private string apellido_m;
        private int edad;
        private int codigo;
        private int carrera;
        private double nota;

        public Postulante(string nombre, string apellido_p, string apellido_m, int edad, int codigo, int carrera, double nota)
        {
            this.nombre = nombre;
            this.apellido_p = apellido_p;
            this.apellido_m = apellido_m;
            this.edad = edad;
            this.codigo = codigo;
            this.carrera = carrera;
            this.nota = nota;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }



        public string getApellidoM ()
        {
            return apellido_m;
        }


        public int getEdad()
        {
            return edad;
        }

        public int getCodigo()
        {
            return codigo;
        }

        public int getCarrera()
        {
            return carrera;
        }

        public double getNota()
        {
            return carrera;
        }
    }
}

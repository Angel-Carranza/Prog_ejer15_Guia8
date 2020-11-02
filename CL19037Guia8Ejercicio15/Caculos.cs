using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL19037Guia8Ejercicio15
{
    // Guia: 8
    // Ejercicio: 15
    // Fecha: 26/10/2020 - 1/11/2020
    // Autor: Carranza López, Angel Adan
    // Carnet: CL19037
    // GL: 11
    // Instructor: Ing. Ruben Asencio

    class Caculos
    {
        //atributo
        float[] notasA = new float[6];
        float[] notasN = new float[25];

        //propiedades
        public float[] NotasA
        {
            get
            {
                return notasA;
            }

            set
            {
                notasA = value;
            }
        }
        public float[] NotasN
        {
            get
            {
                return notasN;
            }

            set
            {
                notasN = value;
            }
        }

        //metodo para calcular el promedio por alumno
        public float CalculoPromedioXAlumno()
        {
            float promedio;
            float sumaNotas = 0;
            for (int i = 0; i < notasA.Length; i++)
            {
                sumaNotas += notasA[i];
            }
            promedio = sumaNotas / 6;
            return promedio;
        }
        //metodo para calcular el promedio por examen
        public float CalculoPromedioXNota()
        {
            float promedio, sumaNotas = 0;
            for (int j = 0; j < NotasN.Length; j++)
            {
                sumaNotas += NotasN[j];
            }
            promedio = sumaNotas / 25;
            return promedio;
        }
        //metodo para encontrar el mayor promedio por alumno
        public float PromedioMayor()
        {
            float promedioMay = 0;
            for (int i = 0; i < notasN.Length; i++)
            {
                if (notasN[i] >= promedioMay)
                    promedioMay = notasN[i];
            }
            return promedioMay;
        }
    }
}

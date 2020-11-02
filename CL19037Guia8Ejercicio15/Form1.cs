using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CL19037Guia8Ejercicio15
{
    public partial class Form1 : Form
    {
        //creacion global del objeto de la clase Calculos
        Caculos Prom = new Caculos();
        public Form1()
        {
            InitializeComponent();
        }
        //evento para agregar notas y calcular el promedio 
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //declaracion de variables y vectores locales
            float[] notas = new float[6];
            float[] notasN = new float[25];
            bool valido;
            float nota;
            string nombre;
            int alumno = 0, note = 0;
            //ingreso de notas y calculo del promedio de notas por alumno
            do
            {
                nombre = Microsoft.VisualBasic.Interaction.InputBox("ingrese el nombre del alumno N° " + (alumno + 1));
                note = 0;
                if (nombre != string.Empty)
                {
                    dgvNotas.Rows.Add();
                    dgvNotas.Rows[alumno].Cells[note].Value = nombre;
                    do
                    {
                        valido = float.TryParse(Microsoft.VisualBasic.Interaction.InputBox("ingrese la nota N° " + (note + 1) + " de " + nombre), out nota);
                        if (valido == true && nota >= 0 && nota <= 10)
                        {
                            dgvNotas.Rows[alumno].Cells[note + 1].Value = nota.ToString();
                            notas[note] = nota;
                            note++;
                        }
                    } while (note != 6);
                    //asignacion de los atributos
                    Prom.NotasA = notas;
                    //salida
                    dgvNotas.Rows[alumno].Cells[note + 1].Value = Prom.CalculoPromedioXAlumno().ToString();
                    alumno++;
                }
            } while (alumno != 25);
            //calculo del promedio de notas por examen
            dgvNotas.Rows[25].Cells[0].Value = "PROMEDIO DE NOTAS POR EXAMEN";
            for (int i = 0; i < 6; i++) 
            {
                for (int j = 0; j < 25; j++)
                {
                    notasN[j] = float.Parse(dgvNotas.Rows[j].Cells[i + 1].Value.ToString());
                }
                //asignacion de atributos
                Prom.NotasN = notasN;
                //salida
                dgvNotas.Rows[25].Cells[i+1].Value = Prom.CalculoPromedioXNota().ToString();
            }
            //identificacion del mayor promedio de notas por alumno
            for (int o = 0; o < 25; o++)
            {
                notasN[o] = float.Parse(dgvNotas.Rows[o].Cells[7].Value.ToString());
            }
            //asignacion de los atributos
            Prom.NotasN = notasN;
            //salida
            lblMayProm.Text = Prom.PromedioMayor().ToString();
        }
        //evento para limpiar la pantalla
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvNotas.Rows.Clear();
            lblMayProm.Text = "-";
        }
    }
}

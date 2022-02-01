using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo5GuiaLabPED
{
    public partial class Form1 : Form
    {

        enum Posicion //define un set de constantes que pueden ser asignados a una variable
        {
        izquierda, derecha, arriba, abajo
        }

        private int x; //coordenada en x
        private int y; //coordenada en y
        private Posicion objposicion; //variable del enum Posicion


        public Form1()
        {
            InitializeComponent();
            x = 50; //inicializada en x=50
            y = 50; //inicializada en y=50
            objposicion = Posicion.abajo; //por defecto definimos que se mueve hacia abajo
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("birrete.png"), x, y, 65, 65);
            //Se dibuja la imagen agregada al proyecto y se establece el punto inicial y tamaño
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha)
            { x += 10; } //desplazarse 10 pixeles a la derecha
            else if (objposicion == Posicion.izquierda)
            { x -= 10; } //desplazarse 10 pixeles a la izquierda
            else if (objposicion == Posicion.arriba)
            { y -= 10; } //10 pixeles hacia arriba
            else if (objposicion == Posicion.abajo)
            { y += 10; } //10 pixeles hacia abajo

            Invalidate(); //invalida la superficie del control y hace que se vuelva a dibujar el control.
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //si se presiona la tecla flecha izquierda
            {
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode == Keys.Right) //si se presiona la tecla flecha derecha
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up) //si se presiona la tecla de la flecha arriba
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down) //si se presiona la tecla flecha abajo
            {
                objposicion = Posicion.abajo;
            }
        }        
    }
}

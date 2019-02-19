using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DDAvsBresenham
{
    public partial class Form1 : Form
    {
        //Linea linea;
        Point Punto_I;
        Point Punto_F;
        Bitmap bmp = new Bitmap(370, 360);

        int xi, yi;
        int xf, yf;


        public Form1()
        {
            InitializeComponent();
        }

        
        //dibujado de cordenadas
        private void crearCoordenada()
        {
            int xi, yi, xf, yf;
            Pen pen = new Pen(Color.Tomato, 3);
            Graphics Gfx = Graphics.FromImage(bmp);

            xi = Punto_I.X;
            yi = Punto_I.Y;

            xf = Punto_F.X;
            yf = Punto_F.Y;
                       
            Gfx.FillRectangle(Brushes.Tomato, xi-1, yi-1, 2, 2);
            Gfx.FillRectangle(Brushes.Tomato, xf-1, yf-1, 2, 2);
            //linea_DDA();
            pictureBox1.Image = bmp;

        }

 
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (xi == 0)
            {
                xi = e.X;
                yi = e.Y;

                Punto_I = new Point((int)xi, (int)yi);
            }
            else
            {

                xf = e.X;
                yf = e.Y;

                Punto_F = new Point((int)xf, (int)yf);
                
                Console.WriteLine("------------- captura de coordenadas ------------------");
                Console.WriteLine("punto x inicial: (" + xi + ", " + yi + ")");
                Console.WriteLine("punto y final: (" + xf + ", " + yf + ")");

                linea_DDA(xi, yi, xf, yf);
                linea_Bres(xi, yi, xf, yf);
                crearCoordenada();
                xi = 0;

            }

        }


        private void bresenhamX(int xi, int yi, int xf, int yf, int dx, int dy)
        {
            int i, j, k,aux;

            i = (2 * dy) - dx;
            j = 2 * dy;
            k = 2 * (dy - dx);

            if (!(xi < xf))
            {
                aux = xi;
                xi = xf;
                xf = aux;

                aux = yi;
                yi = yf;
                yf = aux;
            }

            bmp.SetPixel(xi, yi, Color.Red);

            while (xi < xf)
            {
                if (i < 0)
                {
                    i += j;
                }
                else
                {
                    if (yi < yf)
                    {
                        ++yi;
                    }
                    else
                    {
                        --yi;
                    }
                    i += k;
                }
                ++xi;
                bmp.SetPixel(xi, yi, Color.Red); 
            }
        }
        private void bresenhamY(int xi, int yi, int xf, int yf, int dx, int dy)
        {
            int i, j, k, aux;
            i = (2 * dx) - dy;
            j = 2 * dx;
            k = 2 * (dx - dy);

            if (!(yi<yf))
            {
                aux = xf;
                xf = xi;
                xi = aux;

                aux = yi;
                yi = yf;
                yf = aux;
            }

            bmp.SetPixel(xi, yi, Color.Red);

            while (yi < yf)
            {
                if (i < 0)
                {
                    i += j;
                }
                else
                {
                    if (xi > xf)
                    {
                        --xi;
                    }
                    else
                    {
                        ++xi;
                    }
                    i += k;
                }
                ++yi;
                bmp.SetPixel(xi, yi, Color.Red);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics g = Graphics.FromImage(bmp);
            g.FillRectangle(Brushes.White , 0, 0, 370, 350);
            pictureBox1.Image = bmp;
        }

        private void linea_DDA(int xi, int yi, int xf, int yf)
        {
            Stopwatch sw = new Stopwatch();        
            sw.Start();

            double dx = (xf - xi);
            double dy = (yf - yi);

            double steps;

            float x_inc, y_inc;
            float x = xi;
            float y = yi;


            if (Math.Abs(dx) > Math.Abs(dy))
            {
                steps = Math.Abs(dx);
                
            }
            else
            {
                steps = Math.Abs(dy);
            }

             x_inc = (float)dx/(float)steps;
             y_inc = (float)dy / (float)steps;

            
            bmp.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Blue);

            for ( int k = 0; k < steps; k++)
            {
                x += x_inc;
                y += y_inc;

                bmp.SetPixel((int)Math.Round(x), (int)Math.Round(y), Color.Blue);
            }
           
            timedda.Text = String.Format("{0}",sw.Elapsed.TotalMilliseconds);
        }

        private void linea_Bres(int xi, int yi, int xf, int yf)
        {

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();

            int dx = Math.Abs(xf - xi);
            int dy = Math.Abs(yf - yi);

            if (dx >= dy)
            {
                bresenhamX(xi, yi, xf, yf, dx, dy);
            }
            else
            {
                bresenhamY(xi, yi, xf, yf, dx, dy);
            }
            timebresenham.Text = String.Format("{0}", sw2.Elapsed.TotalMilliseconds);
        }
    }
}

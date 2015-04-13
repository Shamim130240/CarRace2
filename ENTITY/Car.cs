using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ENTITY
{
    public class Car
    {
        
        private int speed= 10;
        private char side='s';
        private double x = 40;
        private double y = 40;
        public int angle = 90;

        Pen bluepen = new Pen(Color.Blue, 3);
        Pen ypen = new Pen(Color.Blue, 27);
        Pen ypen2 = new Pen(Color.BlueViolet, 7);
        Pen bpen = new Pen(Color.Blue, 17);
        
        public void setspeed(int s)
        {
            speed = s;
        }
        public int getspeed()
        {
            return speed;
        }

        public void setX(double a)
        {
            x = a;
        }
        public double getX()
        {
            return x;
        }

        public void setY(double b)
        {
            y = b;
        }
        public double getY()
        {
            return y;
        }

        public void setview(char c)
        {
            side = c;
        }
        public int getview()
        {
            return side;
        }

        

        public void drawCar(Graphics g)
        {

            g.Clear(Color.LightSeaGreen);
            Pen p = new Pen(Color.Blue, 2);
            Pen q = new Pen(Color.Red, 4);
            Pen x = new Pen(Color.Red, 3);
            Pen y = new Pen(Color.Red, 19);
            Pen w = new Pen(Color.Red, 2);
            Pen k = new Pen(Color.Red, 5);
            Pen n = new Pen(Color.Red, 1);

            Point[] p1 = { new Point(3, 30), new Point(11, 28), new Point(20, 27) };
            g.DrawCurve(p, p1);
            g.DrawLine(new Pen(Color.Red, 5), 7, 32, 7, 41);
            g.DrawLine(new Pen(Color.Red, 5), 22, 33, 22, 36);
            Point[] p2 = { new Point(20, 27), new Point(25, 29) };
            g.DrawCurve(p, p2);
            g.DrawLine(p, 25, 29, 42, 29);
            g.DrawLine(p, 42, 29, 38, 22);
            g.DrawLine(new Pen(Color.Red, 8), 44, 28, 44, 36);
            Point[] p3 = { new Point(38, 22), new Point(39, 19), new Point(44, 23), new Point(46, 29) };
            g.DrawCurve(p, p3);
            g.DrawLine(p, 46, 29, 55, 29);
            g.DrawLine(new Pen(Color.Red, 1), 46, 30, 55, 30);
            Point[] p4 = { new Point(55, 29), new Point(70, 27), new Point(82, 31) };
            g.DrawCurve(p, p4);
            g.DrawLine(new Pen(Color.Red, 5), 72, 30, 78, 35);
            Point[] p5 = { new Point(82, 31), new Point(87, 39), new Point(87, 52) };
            g.DrawCurve(p, p5);
            Point[] p6 = { new Point(87, 52), new Point(82, 61), new Point(74, 65) };
            g.DrawCurve(p, p6);

            //...........Drawing Light...................
            Point[] p7 = { new Point(82, 31), new Point(79, 34), new Point(87, 39) };
            g.DrawCurve(p, p7);
            Point[] p8 = { new Point(82, 61), new Point(80, 57), new Point(87, 52) };
            g.DrawCurve(p, p8);

            //..................Right Main Side.....................
            g.DrawLine(p, 74, 65, 63, 64);
            g.DrawLine(p, 63, 64, 48, 63);
            Point[] p9 = { new Point(48, 63), new Point(45, 69), new Point(40, 73), new Point(44, 63) };
            g.DrawCurve(p, p9);
            g.DrawLine(p, 44, 63, 23, 62);
            Point[] p10 = { new Point(23, 63), new Point(13, 65), new Point(3, 63) };
            g.DrawLine(new Pen(Color.Red, 2), 23, 64, 3, 64);
            g.DrawLine(new Pen(Color.Red, 7), 6, 64, 6, 58);
            g.DrawLine(new Pen(Color.Red, 5), 6, 58, 6, 51);
            g.DrawCurve(new Pen(Color.Blue, 2), p10);
            Point[] p11 = { new Point(3, 63), new Point(0, 46), new Point(3, 30) };
            g.DrawCurve(p, p11);

            //.......Back Side Color............

            Point[] c = { new Point(6, 31), new Point(3, 46), new Point(6, 62) };
            g.DrawCurve(q, c);
            Point[] c1 = { new Point(6, 32), new Point(21, 30), new Point(20, 35) };
            g.DrawCurve(q, c1);
            Point[] c2 = { new Point(5, 37), new Point(20, 32) };
            g.DrawCurve(q, c2);
            g.DrawLine(q, 5, 37, 3, 45);
            g.DrawLine(x, 24, 31, 48, 31);
            Point[] c3 = { new Point(7, 60), new Point(8, 61), new Point(20, 61) };
            g.DrawCurve(q, c3);
            g.DrawLine(q, 4, 55, 24, 62);
            g.DrawLine(x, 23, 62, 23, 35);
            g.DrawLine(y, 30, 55, 30, 38);
            g.DrawLine(x, 34, 40, 48, 31);
            g.DrawLine(x, 24, 60, 50, 60);
            g.DrawLine(q, 38, 54, 41, 61);

            //......Left Side Mirror color.......
            g.DrawLine(x, 44, 29, 40, 20);
            g.DrawLine(k, 47, 33, 65, 31);
            g.DrawLine(q, 65, 31, 75, 31);
            g.DrawLine(q, 75, 33, 80, 33);
            g.DrawLine(w, 77, 34, 86, 41);


            //...........Front Side Color...........
            g.DrawLine(new Pen(Color.Red, 4), 62, 59, 62, 35);
            g.DrawLine(new Pen(Color.Red, 3), 65, 57, 65, 38);
            g.DrawLine(new Pen(Color.Red, 10), 67, 55, 67, 37);
            g.DrawLine(new Pen(Color.Red, 3), 73, 53, 73, 39);
            g.DrawLine(new Pen(Color.Red, 10), 78, 53, 78, 39);

            //...........right Side Mirror Color........
            g.DrawLine(w, 46, 61, 43, 71);
            g.DrawLine(x, 46, 61, 66, 61);
            g.DrawLine(q, 63, 62, 77, 62);
            g.DrawLine(new Pen(Color.Red, 1), 60, 59, 70, 59);
            g.DrawLine(x, 77, 62, 80, 60);
            g.DrawLine(x, 79, 60, 72, 57);
            g.DrawLine(w, 75, 58, 85, 52);
            g.DrawLine(new Pen(Color.Red, 4), 84, 52, 85, 40);
            g.DrawLine(new Pen(Color.Red, 1), 83, 52, 83, 40);


            //....... Back Side .......
            g.DrawLine(p, 21, 37, 21, 57);
            Point[] b1 = { new Point(21, 37), new Point(17, 35) };
            g.DrawCurve(p, b1);
            Point[] b2 = { new Point(21, 57), new Point(17, 59) };
            g.DrawCurve(p, b2);
            g.DrawLine(p, 17, 59, 8, 54);
            g.DrawLine(p, 17, 35, 8, 40);
            Point[] b3 = { new Point(8, 54), new Point(6, 46), new Point(8, 40) };
            g.DrawCurve(p, b3);

            //..........Front Side.......
            g.DrawLine(p, 41, 37, 41, 57);
            Point[] f1 = { new Point(41, 37), new Point(43, 36), new Point(45, 36) };
            g.DrawCurve(p, f1);
            g.DrawLine(p, 45, 36, 57, 33);
            Point[] f2 = { new Point(41, 57), new Point(43, 58), new Point(43, 58) };
            g.DrawCurve(p, f2);
            g.DrawLine(p, 43, 58, 57, 60);
            Point[] f3 = { new Point(57, 60), new Point(60, 57) };
            g.DrawCurve(p, f3);
            Point[] f4 = { new Point(57, 33), new Point(59, 35) };
            g.DrawCurve(p, f4);
            g.DrawLine(p, 60, 57, 59, 35);

            //..........Left Side Door..........
            Point[] l = { new Point(23, 36), new Point(30, 38), new Point(42, 33) };
            g.DrawCurve(p, l);
            Point[] l2 = { new Point(23, 36), new Point(25, 33), new Point(42, 33) };
            g.DrawCurve(p, l2);

            //..........Right Side Door.............
            Point[] r = { new Point(23, 56), new Point(30, 54), new Point(37, 56) };
            g.DrawCurve(p, r);
            Point[] r2 = { new Point(23, 56), new Point(30, 60), new Point(37, 56) };
            g.DrawCurve(p, r2);

            //.............Front Mark.............
            // g.DrawLine(p, 63, 33, 80, 38);
            Point[] a = { new Point(61, 33), new Point(73, 34), new Point(82, 41) };
            g.DrawCurve(p, a);
            g.DrawLine(p, 82, 41, 64, 36);

            //.......Front Right..........
            Point[] s = { new Point(63, 57), new Point(73, 58), new Point(82, 51) };
            g.DrawCurve(p, s);
            g.DrawLine(p, 82, 51, 66, 55);

           /* //topfill................
            g.DrawLine(ypen, 43, 70, 97, 70);
            g.DrawLine(ypen2, 45, 81, 95, 83);
            g.DrawLine(ypen2, 45, 59, 95, 57);

            //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            //left side........
            g.DrawLine(new Pen(Color.Blue, 4), 45, 45, 95, 45);
            g.DrawLine(new Pen(Color.Blue, 4), 10, 48, 47, 45);
            g.DrawLine(new Pen(Color.Blue, 4), 93, 45, 135, 48);

            //right side........
            g.DrawLine(new Pen(Color.Blue, 4), 45, 95, 95, 95);
            g.DrawLine(new Pen(Color.Blue, 4), 10, 92, 47, 95);
            g.DrawLine(new Pen(Color.Blue, 4), 93, 95, 135, 92);

            //fornt...............
            g.DrawLine(bluepen, 135, 48, 144, 53);
            g.DrawLine(bluepen, 135, 92, 144, 87);
            g.DrawLine(bpen, 137, 53, 142, 72);
            g.DrawLine(bpen, 137, 87, 142, 68);

            g.DrawLine(new Pen(Color.Blue, 7), 130, 50, 144, 55);
            g.DrawLine(new Pen(Color.Blue, 7), 130, 90, 144, 85);
            //back................
            g.DrawLine(bpen, 12, 72, 16, 48);
            g.DrawLine(bpen, 12, 68, 16, 92);

            

            //top.............
            g.DrawLine(bluepen, 45, 55, 95, 53);
            g.DrawLine(bluepen, 93, 53, 115, 47);
            g.DrawLine(bluepen, 45, 55, 25, 47);
            

            g.DrawLine(bluepen, 45, 85, 95, 87);
            g.DrawLine(bluepen, 93, 87, 115, 93);
            g.DrawLine(bluepen, 45, 85, 25, 93);


            //top fornt...............
            g.DrawLine(bluepen, 97, 71, 95, 53);
            g.DrawLine(bluepen,  95, 87, 97, 69);

            g.DrawLine(bpen, 125, 72, 122, 47);
            g.DrawLine(bpen, 122, 93, 125, 68);


            //top back..............
            g.DrawLine(bluepen, 43, 70, 45, 53);
            g.DrawLine(bluepen, 45, 87, 43, 70);

            g.DrawLine(bluepen, 22, 70, 25, 47);
            g.DrawLine(bluepen, 25, 93, 22, 70);*/

            
            



            //drawing angle...........
            Matrix matrix = new Matrix();
            matrix.Translate(0, 0);
            matrix.RotateAt(360-angle+90, new PointF(80, 80));

            g.Transform = matrix;

            if(angle>=360)
            {
                angle = angle % 360;
            }
            if(angle<0)
            {
                angle = 360 - (-1)*angle;
            }
            
        }




        public void clearcar(Graphics g)
        {
            g.Clear(Color.LightSeaGreen);
        }
    }
}

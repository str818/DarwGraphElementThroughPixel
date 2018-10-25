using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace CGHomework
{
    public class GraphicsLibrary
    {
        public IntPtr hDC;
        public GraphicsLibrary(IntPtr hDC)
        {
            this.hDC = hDC;
        }
        
        //绘制线段_DDA算法
        public void DrawLineDDA(int xStart, int yStart, int xEnd, int yEnd, int lineWidth)
        {
            int dx = xEnd - xStart, dy = yEnd - yStart;
           
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;

            float x = xStart, y = yStart;
            //setPixel((int)Math.Round(x), (int)Math.Round(y));
            DrawLinePixel((int)Math.Round(x), (int)Math.Round(y), lineWidth);
            for (int i = 0; i < steps; i++)
            {
                x += xIncrement;
                y += yIncrement;
                //setPixel((int)Math.Round(x), (int)Math.Round(y));
                DrawLinePixel((int)Math.Round(x), (int)Math.Round(y), lineWidth);
            }
        }

        //绘制线宽
        public void DrawLinePixel(int x, int y, int lineWidth)
        {
            for(int i = 0; i < lineWidth; i++)
            {
                setPixel(x + i, y);
                setPixel(x - i, y);
            }
        }

        //绘制圆_Bresenham算法
        public void DrawCircleBresenham(int centerX, int centerY, int r)
        {
            //int[][] array = new int[][] {() };
            setPixel(centerX, centerY);

            int x = 0;
            int y = r;
            int d = 3 - 2 * r;

            while (x < y)
            {
                if (d < 0)
                {
                    d = d + 4 * x + 6;
                }else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;

                CirclePlot(centerX, centerY, x, y);
            }
        }

        //画圆时对称绘制
        public void CirclePlot(int centerX, int centerY, int x, int y)
        {
            
            setPixel(x + centerX, y + centerY); // 4
            setPixel(-x + centerX, y + centerY);// 5
            setPixel(-x + centerX, -y + centerY);// 8
            setPixel(x + centerX, -y + centerY); // 1
            setPixel(y + centerX, x + centerY);// 3
            setPixel(-y + centerX, x + centerY);// 6
            setPixel(-y + centerX, -x + centerY);// 7
            setPixel(y + centerX, -x + centerY);// 2
        }

        //绘制圆弧
        public void DrawArc(int centerX, int centerY, int startAngle, int sweepAngle, int r)
        {
            double startA = startAngle * Math.PI / 180;
            double sweepA = sweepAngle * Math.PI / 180;

            double span = 0.3 * Math.PI / 180;
            for(double i = startA; i <= startA + sweepA; i += span)
            {
                int x = (int)(centerX + r * Math.Cos(i - Math.PI / 2));
                int y = (int)(centerY + r * Math.Sin(i - Math.PI / 2));
                setPixel(x, y);
            }
        }

        //绘制椭圆
        public void DrawEllipseMP(int xc, int yc, int a, int b)
        {
            double sqa = a * a;
            double sqb = b * b;

            double d = sqb + sqa * (-b + 0.25);
            int x = 0;
            int y = b;
            EllipsePlot(xc, yc, x, y);

            while( sqb * (x + 1) < sqa * (y - 0.5))
            {
                if (d < 0)
                {
                    d += sqb * (2 * x + 3);
                }else
                {
                    d += (sqb * (2 * x + 3) + sqa * (-2 * y + 2));
                    y--;
                }
                x++;
                EllipsePlot(xc, yc, x, y);
            }
            d = (b * (x + 0.5)) * 2 + (a * (y - 1)) * 2 - (a * b) * 2;

            while (y > 0)
            {
                if (d < 0)
                {
                    d += sqb * (2 * x + 2) + sqa * (-2 * y + 3);
                    x++;
                }else
                {
                    d += sqa * (-2 * y + 3);
                }
                y--;
                EllipsePlot(xc, yc, x, y);
            }
        }

        //画椭圆时绘制对称点
        public void EllipsePlot(int xc,int yc,int x,int y)
        {
            setPixel(xc + x, yc + y);
            setPixel(xc - x, yc + y);
            setPixel(xc + x, yc - y);
            setPixel(xc - x, yc - y);
        }

        //绘制像素点
        public void setPixel(int x, int y)
        {
            SetPixel(hDC, x, y, 0);
        }

        //绘制字符
        public void DrawString()
        {

        }

        [DllImport("Gdi32.dll ")]
        public static extern int SetPixel(IntPtr hDC, int x, int y, int color);

    }
}

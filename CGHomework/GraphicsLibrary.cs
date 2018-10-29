using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;

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
        public void DrawLineDDA(int xStart, int yStart, int xEnd, int yEnd, int lineWidth,int color)
        {
            int dx = xEnd - xStart, dy = yEnd - yStart;
           
            int steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            float xIncrement = dx / (float)steps;
            float yIncrement = dy / (float)steps;

            float x = xStart, y = yStart;
            //setPixel((int)Math.Round(x), (int)Math.Round(y));
            DrawLinePixel((int)Math.Round(x), (int)Math.Round(y), lineWidth,color);
            for (int i = 0; i < steps; i++)
            {
                x += xIncrement;
                y += yIncrement;
                //setPixel((int)Math.Round(x), (int)Math.Round(y));
                DrawLinePixel((int)Math.Round(x), (int)Math.Round(y), lineWidth,color);
            }
        }

        //绘制线宽
        public void DrawLinePixel(int x, int y, int lineWidth,int color)
        {
            for(int i = 0; i < lineWidth; i++)
            {
                setPixel(x + i, y,color);
                setPixel(x - i, y,color);
            }
        }

        //绘制圆_Bresenham算法
        public void DrawCircleBresenham(int centerX, int centerY, int r)
        {
            setPixel(centerX, centerY,0);

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
            
            setPixel(x + centerX, y + centerY,0); // 4
            setPixel(-x + centerX, y + centerY,0);// 5
            setPixel(-x + centerX, -y + centerY,0);// 8
            setPixel(x + centerX, -y + centerY,0); // 1
            setPixel(y + centerX, x + centerY,0);// 3
            setPixel(-y + centerX, x + centerY,0);// 6
            setPixel(-y + centerX, -x + centerY,0);// 7
            setPixel(y + centerX, -x + centerY,0);// 2
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
                setPixel(x, y,0);
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
            setPixel(xc + x, yc + y,0);
            setPixel(xc - x, yc + y,0);
            setPixel(xc + x, yc - y,0);
            setPixel(xc - x, yc - y,0);
        }

        //绘制椭圆弧
        public void DrawEllipseArc(int centerX, int centerY, int a, int b, int startAngle, int sweepAngle)
        {
            double startA = startAngle * Math.PI / 180;
            double sweepA = sweepAngle * Math.PI / 180;

            double span = 0.3 * Math.PI / 180;
            for (double i = startA; i <= startA + sweepA; i += span)
            {
                int x = (int)(centerX + a * Math.Cos(i - Math.PI / 2));
                int y = (int)(centerY + b * Math.Sin(i - Math.PI / 2));
                setPixel(x, y,0);
            }

        }

        //绘制文字
        public void DrawString(String massage,int x, int y)
        {
            FileStream fsHzk16 = new FileStream("hzk16h", FileMode.Open);

            for(int i = 0; i < massage.Length; i++)
            {
                string s = massage.Substring(i, 1);
                int[] key = { 0x80, 0x40, 0x20, 0x10, 0x08, 0x04, 0x02, 0x01 };
                byte[] bMsg = new byte[32];
                byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(s.ToCharArray());
                int offset = 32 * (94 * (bytes[0] - 0xA1) + bytes[1] - 0xA1);
                fsHzk16.Seek(offset, SeekOrigin.Begin);
                fsHzk16.Read(bMsg, 0, 32);

                for(int k = 0; k < 16; k++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        for(int d = 0; d < 8; d++)
                        {
                            int flag = bMsg[k * 2 + j] & key[d%8];
                            if (flag != 0)
                            {
                                setPixel((j * 8) + d + i * 16 + x, k + y,0);
                            }  
                        }
                    }
                }
            }
            fsHzk16.Close();
        }

        //绘制多边形阴影线
        public void DrawShadowLine(Point[] OuterPoint, Point[] InnerPoint, int angle, int h)
        {
            //绘制多边形外环与内环轮廓
            DrawPolygon(OuterPoint);
            DrawPolygon(InnerPoint);

            //各棱两边端点按阴影线斜率引线产生的截距数组
            Point[] outerIntercept = new Point[OuterPoint.Length];
            Point[] innerIntercept = new Point[InnerPoint.Length];

            //初始化外环每条棱边的截距
            double k = Math.Tan(angle * Math.PI / 180);//阴影线斜率
            initIntercept(OuterPoint, outerIntercept, k);
            initIntercept(InnerPoint, innerIntercept, k);

            //计算出最大截距与最小截距
            double minIntercept = double.MaxValue;
            double maxIntercept = double.MinValue;
            for(int i = 0; i< outerIntercept.Length; i++)
            {
                if (outerIntercept[i].x < minIntercept) minIntercept = outerIntercept[i].x;
                if (outerIntercept[i].y > maxIntercept) maxIntercept = outerIntercept[i].y; 
            }

            //计算第一条阴影线的截距
            double deltaB = h / Math.Abs(Math.Cos(angle * Math.PI / 180));
            double firstLineIntercept = minIntercept + deltaB;

            for(double i = firstLineIntercept; i < maxIntercept; i += deltaB)
            {
                //交点数组
                List<Point> intersection = new List<Point>();

                //计算与外环的交点
                for(int j = 0; j < outerIntercept.Length; j++)
                {
                    double x = outerIntercept[j].x;
                    double y = outerIntercept[j].y;
                    if(i >= x && i < y)
                    {
                        //两个端点的位置
                        double pX = OuterPoint[j].x;
                        double pY = OuterPoint[j].y;
                        double qX = OuterPoint[(j + 1) % OuterPoint.Length].x;
                        double qY = OuterPoint[(j + 1) % OuterPoint.Length].y;

                        double ix = (pX * qY - pY * qX + i * (qX - pX)) / ((qY - pY) - k * (qX - pX));
                        double iy = k * ix + i;

                        intersection.Add(new Point(ix,iy));
                    }
                }

                //计算与内环的交点
                for (int j = 0; j < innerIntercept.Length; j++)
                {
                    double x = innerIntercept[j].x;
                    double y = innerIntercept[j].y;
                    if (i >= x && i < y)
                    {
                        //两个端点的位置
                        double pX = InnerPoint[j].x;
                        double pY = InnerPoint[j].y;
                        double qX = InnerPoint[(j + 1) % InnerPoint.Length].x;
                        double qY = InnerPoint[(j + 1) % InnerPoint.Length].y;

                        double ix = (pX * qY - pY * qX + i * (qX - pX)) / ((qY - pY) - k * (qX - pX));
                        double iy = k * ix + i;

                        intersection.Add(new Point(ix, iy));
                    }
                }

                //将交点列表按X值升序排列
                for(int j = 0; j < intersection.Count; j++)
                {
                    for(int q = j + 1; q < intersection.Count; q++ )
                    {
                        if (intersection[j].x > intersection[q].x)
                        {
                            Point temp = intersection[j];
                            intersection[j] = intersection[q];
                            intersection[q] = temp;
                        }
                    }
                }

                //产生从偶数点到奇数点的线段
                for(int j = 0; j < intersection.Count; j += 2)
                {
                    DrawLineDDA((int)intersection[j].x, (int)intersection[j].y, (int)intersection[j + 1].x, (int)intersection[j + 1].y, 1,0);
                }
            }

        }

        //多边形区域颜色填充
        public void DrawPolygonColorFilling(Point[] pointArray,int color)
        {
            //-----建立边表-ET-----

            //计算多边形边的Y值范围
            int minY = int.MaxValue;
            int maxY = int.MinValue;
            for(int i = 0; i < pointArray.Length; i++)
            {
                Point sP = pointArray[i];
                if (sP.y > maxY) maxY = (int)sP.y;
                if (sP.y < minY) minY = (int)sP.y;
            }

            //初始化边表
            Table[] ET = new Table[maxY - minY + 1];
            for(int i = 0; i < pointArray.Length; i++)
            {
                Point sP = pointArray[i];
                Point eP = pointArray[(i + 1) % pointArray.Length];
                Table temp = new Table();
                //边的最大Y值与下端点X坐标
                int downY;//下端点纵坐标
                if (sP.y < eP.y)
                {
                    temp.yMax = (int)eP.y;
                    temp.x = (int)sP.x;
                    downY = (int)sP.y;
                } else if (sP.y > eP.y)
                {
                    temp.yMax = (int)sP.y;
                    temp.x = (int)eP.x;
                    downY = (int)eP.y;
                } else continue;

                //斜率
                double k = (sP.y - eP.y) / (sP.x - eP.x);
                temp.deltaX = 1 / k;
                temp.next = null;

                //放入边表
                Table index = ET[downY - minY];
                if (index == null)
                {
                    ET[downY - minY] = temp;
                    //Console.WriteLine("放入边表：" + i);
                }
                else
                {
                    while (index.next != null) index = index.next;
                    index.next = temp;
                    //Console.WriteLine("加入边表：" + i);
                }
            }


            //活动边链表AET
            Table[] AET = new Table[maxY - minY + 1];
            //-----循环迭代-----
            for (int i = 0; i < maxY - minY +1; i++)
            {

                //若扫描线对应的ET中非空，从ET中取出复制到AET中
                
                if (ET[i] != null)
                {
                    Table tempET = ET[i];
                    if (AET[i] == null)//当AET[i]为空（第一次）
                    {
                        AET[i] = new Table(tempET);
                    }else
                    {   //将ET[i]中的边链接到AET[i]后
                        
                        Table tempAET = AET[i];
                        while (tempAET.next != null) tempAET = tempAET.next;
                        while (tempET != null)
                        {
                            tempAET.next = new Table(tempET);
                            tempAET = tempAET.next;
                            tempET = tempET.next;
                        }
                    }           
                    
                    //根据x对各边增序排列
                    Table p = AET[i];
                    Table q = AET[i];
                    if(p.next != null)
                    {
                        while (p.next != null)
                        {
                            for(;q.next != null; q = q.next)
                            {
                                if (q.x > q.next.x)
                                {
                                    //交换结点
                                    Table temp = new Table(q);
                                    q.x = q.next.x;
                                    q.yMax = q.next.yMax;
                                    q.deltaX = q.next.deltaX;
                                    q.next.x = temp.x;
                                    q.next.yMax = temp.yMax;
                                    q.next.deltaX = temp.deltaX;
                                }
                            }
                            p = p.next;
                        }
                        
                    }
                }

                if (AET[i] != null)
                {
                    //对交点之间的区域进行着色
                    Table temp = AET[i];
                    while (temp != null && temp.next != null)
                    {
                        DrawLineDDA((int)temp.x, i + minY, (int)temp.next.x, i + minY, 1,color);
                        temp = temp.next.next;
                    }

                    //超过界限退出循环
                    if (i + 1 >= maxY - minY + 1) break;
                    //若首条边完成任务，则删除
                    while (AET[i] != null && AET[i].yMax == i + minY + 1)
                    {
                        Console.WriteLine("首边删除:" + AET[i].yMax + " " + i);
                        AET[i] = AET[i].next;
                    }

                    if (AET[i] == null) break;
                    else AET[i].x += AET[i].deltaX;
                    
                    //后面的边完成任务，则删除
                    temp = AET[i].next;
                    Table last = AET[i];
                    while (temp != null)
                    {
                       
                        if (temp.yMax == i + minY)
                        {
                            Console.WriteLine("删除:" + temp.yMax + " " + i);
                            last.next = temp.next;
                            temp = temp.next;
                            continue;
                        }
                        else
                        {
                            temp.x += temp.deltaX;
                        }
                        temp = temp.next;
                        last = temp;
                    }
                    AET[i + 1] = AET[i];
                }
            }

            DrawPolygon(pointArray);

        }

        //初始化截距
        public void initIntercept(Point[] orignialArray,Point[] intercept,double k)
        {
            for (int i = 0; i < orignialArray.Length; i++)
            {
                Point startP = orignialArray[i];       //起始点
                Point endP = orignialArray[(i + 1) % orignialArray.Length];//终止点

                double bs = startP.y - k * startP.x;
                double bq = endP.y - k * endP.x;

                //小值作为x
                if (bs >= bq)
                {
                    intercept[i] = new Point(bq, bs);
                }
                else
                {
                    intercept[i] = new Point(bs, bq);
                }
            }
        }

        //绘制多边形
        public void DrawPolygon(Point[] ArrayPoint)
        {
            for (int i = 0; i < ArrayPoint.Length; i++)
            {
                Point startPoint = ArrayPoint[i];
                Point endPoint = ArrayPoint[(i + 1) % ArrayPoint.Length];
                DrawLineDDA((int)startPoint.x, (int)startPoint.y, (int)endPoint.x, (int)endPoint.y, 1, 0);
            }
        }

        //绘制像素点
        public void setPixel(int x, int y,int color)
        {
            SetPixel(hDC, x, y, color);
        }

        [DllImport("Gdi32.dll ")]
        public static extern int SetPixel(IntPtr hDC, int x, int y, int color);

    }


    //点
    public class Point
    {
        public double x, y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
    
    //链表结点-用于表示边的分类表ET 与 边的活动边链表AEL
    public class Table
    {
        public int yMax;//该棱边的上端点的y坐标
        public double x;//ET-该棱边的下端点x坐标   AEL-该棱边与当前扫描线交点的x坐标
        public double deltaX;//该棱边斜率的倒数
        public Table next;//指向下一条棱边

        public Table(Table temp)
        {
            yMax = temp.yMax;
            x = temp.x;
            deltaX = temp.deltaX;
            next = temp.next;
        }
        public Table() { }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CGHomework
{
    public partial class MyForm : Form
    {

        //图形库
        public GraphicsLibrary gl;

        //填充多边形的颜色
        public Color color;

        //绘制列表
        List<Option> optionList = new List<Option>();

        public MyForm()
        {
            InitializeComponent();
            Graphics g = PaintPanel.CreateGraphics();
            gl = new GraphicsLibrary(g.GetHdc());//new GraphicsLibrary(e.Graphics.GetHdc());

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for(int i = 0; i<optionList.Count; i++)
            {
                Option option = optionList[i];
                switch (option.option)
                {
                    //绘制直线
                    case Option.DrawOption.DrawLine:
                        gl.DrawLineDDA((int)option.ParameterList[0], (int)option.ParameterList[1],
                            (int)option.ParameterList[2], (int)option.ParameterList[3], 1, 0);
                        break;
                    //绘制圆弧
                    case Option.DrawOption.DrawCirArc:
                        gl.DrawArc((int)option.ParameterList[0], (int)option.ParameterList[1],
                            (int)option.ParameterList[2], (int)option.ParameterList[3], (int)option.ParameterList[4]);
                        break;
                    //绘制椭圆弧
                    case Option.DrawOption.DrawEllispArc:
                        gl.DrawEllipseArc((int)option.ParameterList[0], (int)option.ParameterList[1],
                            (int)option.ParameterList[2], (int)option.ParameterList[3], (int)option.ParameterList[4], 
                            (int)option.ParameterList[5]);
                        break;
                    //绘制文字
                    case Option.DrawOption.DrawString:
                        gl.DrawString(option.ParameterList[0].ToString(), (int)option.ParameterList[1],
                            (int)option.ParameterList[2]);
                        break;
                    //绘制多边形阴影
                    case Option.DrawOption.DrawShadowLine:
                        gl.DrawShadowLine((Point[])option.ParameterList[0], (Point[])option.ParameterList[1],
                            (int)option.ParameterList[2], (int)option.ParameterList[3]);
                        break;
                    //绘制多边形颜色填充
                    case Option.DrawOption.DrawFillingColor:
                        gl.DrawPolygonColorFilling((Point[])option.ParameterList[0], (int)option.ParameterList[1]);
                        break;

                }
            }
        }

        //直线绘制按钮
        public void button1_Click(object sender, EventArgs e)
        {
            //输入检测
            if (LineSX.Text.ToString().Equals("") ||
               LineSY.Text.ToString().Equals("") ||
               LineEX.Text.ToString().Equals("") ||
               LineEY.Text.ToString().Equals("")) return;

            //获取直线两端端点
            int xStart = int.Parse(LineSX.Text.ToString());
            int yStart = int.Parse(LineSY.Text.ToString());
            int xEnd = int.Parse(LineEX.Text.ToString());
            int yEnd = int.Parse(LineEY.Text.ToString());

            //绘制直线
            gl.DrawLineDDA(xStart, yStart, xEnd, yEnd, 1, 0);

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawLine, new List<Object> { xStart, yStart, xEnd, yEnd }));

            //清空输入框
            LineSY.Text = "";
            LineSX.Text = "";
            LineEY.Text = "";
            LineEX.Text = "";
        }

        //圆弧绘制按钮
        private void DrawArcButton_Click(object sender, EventArgs e)
        {
            //输入检测
            if (ArcX.Text.ToString().Equals("") ||
               ArcY.Text.ToString().Equals("") ||
               StartAngle.Text.ToString().Equals("") ||
               SweepAngle.Text.ToString().Equals("") ||
               Radius.Text.ToString().Equals("")) return;

            //获取圆弧数据
            int xCenter = int.Parse(ArcX.Text.ToString());
            int yCenter = int.Parse(ArcY.Text.ToString());
            int startAngle = int.Parse(StartAngle.Text.ToString());
            int sweepAngle = int.Parse(SweepAngle.Text.ToString());
            int r = int.Parse(Radius.Text.ToString());

            //绘制圆弧
            gl.DrawArc(xCenter, yCenter, startAngle, sweepAngle, r);

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawCirArc, new List<Object> { xCenter, yCenter, startAngle, sweepAngle, r}));

            //清空输入框
            ArcX.Text = "";
            ArcY.Text = "";
            StartAngle.Text = "";
            SweepAngle.Text = "";
            Radius.Text = "";
        }

        //椭圆弧绘制按钮
        private void DrawEllispArc_Click(object sender, EventArgs e)
        {
            //输入检测
            if (CenterX.Text.ToString().Equals("") ||
               CenterY.Text.ToString().Equals("") ||
               EStartAngle.Text.ToString().Equals("") ||
               ESweepAngle.Text.ToString().Equals("") ||
               A.Text.ToString().Equals("") ||
               B.Text.ToString().Equals("")) return;

            //获取椭圆弧数据
            int xCenter = int.Parse(CenterX.Text.ToString());
            int yCenter = int.Parse(CenterY.Text.ToString());
            int startAngle = int.Parse(EStartAngle.Text.ToString());
            int sweepAngle = int.Parse(ESweepAngle.Text.ToString());
            int a = int.Parse(A.Text.ToString());
            int b = int.Parse(B.Text.ToString());

            //绘制椭圆弧
            gl.DrawEllipseArc(xCenter, yCenter, a, b, startAngle, sweepAngle);

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawEllispArc, new List<Object> { xCenter, yCenter, startAngle, sweepAngle, a, b }));

            //清空输入框
            CenterX.Text = "";
            CenterY.Text = "";
            EStartAngle.Text = "";
            ESweepAngle.Text = "";
            A.Text = "";
            B.Text = "";
        }

        //文字绘制
        private void DrawStr_Click(object sender, EventArgs e)
        {
            //输入检测
            if (Str.Text.ToString().Equals("") ||
               StrX.Text.ToString().Equals("") ||
               StrY.Text.ToString().Equals("")) return;

            //获取文字数据
            String s = Str.Text;
            int x = int.Parse(StrX.Text.ToString());
            int y = int.Parse(StrY.Text.ToString());

            //绘制文字
            gl.DrawString(s, x, y);

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawString, new List<Object> { s, x, y }));

            //清空输入框
            Str.Text = "";
            StrX.Text = "";
            StrY.Text = "";
        }

        //绘制多边形阴影填充
        private void DrawShadowLine_Click(object sender, EventArgs e)
        {
            //输入检测
            if (OuterRing.Text.ToString().Equals("") ||
               ShadowLineAngle.Text.ToString().Equals("") ||
               VerticalH.Text.ToString().Equals("")) return;

            //获取外环点集
            String[] outerPointString = OuterRing.Text.ToString().Split(',');
            Point[] outerPoint = new Point[outerPointString.Length];
            for (int i = 0;i < outerPointString.Length; i++)
            {
                String[] temp = outerPointString[i].Split(' ');
                outerPoint[i] = new Point(int.Parse(temp[0]), int.Parse(temp[1]));
            }

            //获取内环点集
            String[] innerPointString = InnerRing.Text.ToString().Split(',');
            Point[] innerPoint = new Point[innerPointString.Length];
            if (InnerRing.Text.Equals("")) innerPoint = new Point[0];
            for (int i = 0; i < innerPoint.Length; i++)
            {
                String[] temp = innerPointString[i].Split(' ');
                innerPoint[i] = new Point(int.Parse(temp[0]), int.Parse(temp[1]));
            }

            //获取阴影线角度
            int angle = int.Parse(ShadowLineAngle.Text);

            //获取垂直间距
            int h = int.Parse(VerticalH.Text);

            //绘制多边形阴影线
            gl.DrawShadowLine(outerPoint, innerPoint, angle, h);

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawShadowLine, new List<Object> { outerPoint, innerPoint, angle, h }));

            //清空输入框
            OuterRing.Text = "";
            InnerRing.Text = "";
            ShadowLineAngle.Text = "";
            VerticalH.Text = "";
        }

        //多边形区域颜色填充
        private void DrawPolygonFillingColor_Click(object sender, EventArgs e)
        {
            //输入检测
            if (PolygonPoints.Text.ToString().Equals("")) return;

            //获取多边形点集
            String[] pointString = PolygonPoints.Text.ToString().Split(',');
            Point[] point = new Point[pointString.Length];
            for (int i = 0; i < pointString.Length; i++)
            {
                String[] temp = pointString[i].Split(' ');
                point[i] = new Point(int.Parse(temp[0]), int.Parse(temp[1]));
            }

            //绘制多边形颜色填充
            gl.DrawPolygonColorFilling(point,ColorTranslator.ToWin32(Color.Green));

            //加入操作List
            optionList.Add(new Option(Option.DrawOption.DrawFillingColor, new List<Object> { point, ColorTranslator.ToWin32(Color.Green) }));

            PolygonPoints.Text = "";

        }

        //选择颜色
        private void SelectColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
        }
    }

    //操作类
    public class Option
    {
        //绘制操作类型
        public enum DrawOption{
            None,
            DrawLine,
            DrawCirArc,
            DrawEllispArc,
            DrawString,
            DrawShadowLine,
            DrawFillingColor
        }

        //操作类型
        public DrawOption option = DrawOption.None;

        //参数类型
        public List<Object> ParameterList;

        public Option(DrawOption option, List<Object> tempParmeterList)
        {
            this.option = option;
            this.ParameterList = tempParmeterList;
        }

    }
}

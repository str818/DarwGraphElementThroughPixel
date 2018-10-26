﻿using System;
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

        public MyForm()
        {
            InitializeComponent();
            Graphics g = PaintPanel.CreateGraphics();
            gl = new GraphicsLibrary(g.GetHdc());//new GraphicsLibrary(e.Graphics.GetHdc());
 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

        }

        //直线绘制按钮
        public void button1_Click(object sender, EventArgs e)
        {
            //获取直线两端端点
            int xStart = int.Parse(LineSX.Text.ToString());
            int yStart = int.Parse(LineSY.Text.ToString());
            int xEnd = int.Parse(LineEX.Text.ToString());
            int yEnd = int.Parse(LineEY.Text.ToString());

            //绘制直线
            gl.DrawLineDDA(xStart, yStart, xEnd, yEnd, 1);

            //清空输入框
            LineSY.Text = "";
            LineSX.Text = "";
            LineEY.Text = "";
            LineEX.Text = "";
        }

        //圆弧绘制按钮
        private void DrawArcButton_Click(object sender, EventArgs e)
        {
            //获取圆弧数据
            int xCenter = int.Parse(ArcX.Text.ToString());
            int yCenter = int.Parse(ArcY.Text.ToString());
            int startAngle = int.Parse(StartAngle.Text.ToString());
            int sweepAngle = int.Parse(SweepAngle.Text.ToString());
            int r = int.Parse(Radius.Text.ToString());

            //绘制圆弧
            gl.DrawArc(xCenter, yCenter, startAngle, sweepAngle, r);

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
            //获取椭圆弧数据
            int xCenter = int.Parse(CenterX.Text.ToString());
            int yCenter = int.Parse(CenterY.Text.ToString());
            int startAngle = int.Parse(EStartAngle.Text.ToString());
            int sweepAngle = int.Parse(ESweepAngle.Text.ToString());
            int a = int.Parse(A.Text.ToString());
            int b = int.Parse(B.Text.ToString());

            //绘制椭圆弧
            gl.DrawEllipseArc(xCenter, yCenter, a, b, startAngle, sweepAngle);

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
            //获取文字数据
            String s = Str.Text;
            int x = int.Parse(StrX.Text.ToString());
            int y = int.Parse(StrY.Text.ToString());

            //绘制文字
            gl.DrawString(s, x, y);

            //清空输入框
            Str.Text = "";
            StrX.Text = "";
            StrY.Text = "";

        }
    }
}

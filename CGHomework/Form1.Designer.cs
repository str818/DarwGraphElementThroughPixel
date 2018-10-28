namespace CGHomework
{
    partial class MyForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabLine = new System.Windows.Forms.TabPage();
            this.DrwaLineButton = new System.Windows.Forms.Button();
            this.LineEY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LineEX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LineSY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LineSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCircleArc = new System.Windows.Forms.TabPage();
            this.Radius = new System.Windows.Forms.TextBox();
            this.RadiusLable = new System.Windows.Forms.Label();
            this.DrawArcButton = new System.Windows.Forms.Button();
            this.SweepAngle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StartAngle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ArcY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ArcX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabEllipseArc = new System.Windows.Forms.TabPage();
            this.ESweepAngle = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.EStartAngle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.DrawEllispArc = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabStr = new System.Windows.Forms.TabPage();
            this.StrY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.StrX = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.DrawStr = new System.Windows.Forms.Button();
            this.Str = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabShadowLine = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.OuterRing = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.InnerRing = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.ShadowLineAngle = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.VerticalH = new System.Windows.Forms.TextBox();
            this.DrawShadowLine = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.tabLine.SuspendLayout();
            this.tabCircleArc.SuspendLayout();
            this.tabEllipseArc.SuspendLayout();
            this.tabStr.SuspendLayout();
            this.tabShadowLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TabControl.Controls.Add(this.tabLine);
            this.TabControl.Controls.Add(this.tabCircleArc);
            this.TabControl.Controls.Add(this.tabEllipseArc);
            this.TabControl.Controls.Add(this.tabStr);
            this.TabControl.Controls.Add(this.tabShadowLine);
            this.TabControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(667, 80);
            this.TabControl.TabIndex = 2;
            // 
            // tabLine
            // 
            this.tabLine.BackColor = System.Drawing.Color.Silver;
            this.tabLine.Controls.Add(this.DrwaLineButton);
            this.tabLine.Controls.Add(this.LineEY);
            this.tabLine.Controls.Add(this.label4);
            this.tabLine.Controls.Add(this.label5);
            this.tabLine.Controls.Add(this.LineEX);
            this.tabLine.Controls.Add(this.label6);
            this.tabLine.Controls.Add(this.LineSY);
            this.tabLine.Controls.Add(this.label2);
            this.tabLine.Controls.Add(this.label3);
            this.tabLine.Controls.Add(this.LineSX);
            this.tabLine.Controls.Add(this.label1);
            this.tabLine.Location = new System.Drawing.Point(4, 22);
            this.tabLine.Name = "tabLine";
            this.tabLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabLine.Size = new System.Drawing.Size(659, 54);
            this.tabLine.TabIndex = 0;
            this.tabLine.Text = " 直线";
            // 
            // DrwaLineButton
            // 
            this.DrwaLineButton.Location = new System.Drawing.Point(540, 12);
            this.DrwaLineButton.Name = "DrwaLineButton";
            this.DrwaLineButton.Size = new System.Drawing.Size(70, 30);
            this.DrwaLineButton.TabIndex = 11;
            this.DrwaLineButton.Text = "绘 制";
            this.DrwaLineButton.UseVisualStyleBackColor = true;
            this.DrwaLineButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LineEY
            // 
            this.LineEY.Location = new System.Drawing.Point(291, 16);
            this.LineEY.Name = "LineEY";
            this.LineEY.Size = new System.Drawing.Size(27, 21);
            this.LineEY.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "x";
            // 
            // LineEX
            // 
            this.LineEX.Location = new System.Drawing.Point(241, 16);
            this.LineEX.Name = "LineEX";
            this.LineEX.Size = new System.Drawing.Size(27, 21);
            this.LineEX.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "终止位置：";
            // 
            // LineSY
            // 
            this.LineSY.Location = new System.Drawing.Point(131, 16);
            this.LineSY.Name = "LineSY";
            this.LineSY.Size = new System.Drawing.Size(27, 21);
            this.LineSY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // LineSX
            // 
            this.LineSX.Location = new System.Drawing.Point(81, 16);
            this.LineSX.Name = "LineSX";
            this.LineSX.Size = new System.Drawing.Size(27, 21);
            this.LineSX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始位置：";
            // 
            // tabCircleArc
            // 
            this.tabCircleArc.BackColor = System.Drawing.Color.Silver;
            this.tabCircleArc.Controls.Add(this.Radius);
            this.tabCircleArc.Controls.Add(this.RadiusLable);
            this.tabCircleArc.Controls.Add(this.DrawArcButton);
            this.tabCircleArc.Controls.Add(this.SweepAngle);
            this.tabCircleArc.Controls.Add(this.label11);
            this.tabCircleArc.Controls.Add(this.StartAngle);
            this.tabCircleArc.Controls.Add(this.label10);
            this.tabCircleArc.Controls.Add(this.ArcY);
            this.tabCircleArc.Controls.Add(this.label8);
            this.tabCircleArc.Controls.Add(this.label9);
            this.tabCircleArc.Controls.Add(this.ArcX);
            this.tabCircleArc.Controls.Add(this.label7);
            this.tabCircleArc.Location = new System.Drawing.Point(4, 22);
            this.tabCircleArc.Name = "tabCircleArc";
            this.tabCircleArc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCircleArc.Size = new System.Drawing.Size(659, 54);
            this.tabCircleArc.TabIndex = 1;
            this.tabCircleArc.Text = " 圆弧";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(471, 17);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(27, 21);
            this.Radius.TabIndex = 17;
            // 
            // RadiusLable
            // 
            this.RadiusLable.AutoSize = true;
            this.RadiusLable.Location = new System.Drawing.Point(424, 19);
            this.RadiusLable.Name = "RadiusLable";
            this.RadiusLable.Size = new System.Drawing.Size(41, 12);
            this.RadiusLable.TabIndex = 16;
            this.RadiusLable.Text = "半径：";
            // 
            // DrawArcButton
            // 
            this.DrawArcButton.Location = new System.Drawing.Point(540, 12);
            this.DrawArcButton.Name = "DrawArcButton";
            this.DrawArcButton.Size = new System.Drawing.Size(70, 30);
            this.DrawArcButton.TabIndex = 15;
            this.DrawArcButton.Text = "绘 制";
            this.DrawArcButton.UseVisualStyleBackColor = true;
            this.DrawArcButton.Click += new System.EventHandler(this.DrawArcButton_Click);
            // 
            // SweepAngle
            // 
            this.SweepAngle.Location = new System.Drawing.Point(379, 17);
            this.SweepAngle.Name = "SweepAngle";
            this.SweepAngle.Size = new System.Drawing.Size(27, 21);
            this.SweepAngle.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "跨越角度：";
            // 
            // StartAngle
            // 
            this.StartAngle.Location = new System.Drawing.Point(266, 17);
            this.StartAngle.Name = "StartAngle";
            this.StartAngle.Size = new System.Drawing.Size(27, 21);
            this.StartAngle.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "起始角度：";
            // 
            // ArcY
            // 
            this.ArcY.Location = new System.Drawing.Point(151, 16);
            this.ArcY.Name = "ArcY";
            this.ArcY.Size = new System.Drawing.Size(27, 21);
            this.ArcY.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 9;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "x";
            // 
            // ArcX
            // 
            this.ArcX.Location = new System.Drawing.Point(91, 16);
            this.ArcX.Name = "ArcX";
            this.ArcX.Size = new System.Drawing.Size(27, 21);
            this.ArcX.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "弧心位置：";
            // 
            // tabEllipseArc
            // 
            this.tabEllipseArc.BackColor = System.Drawing.Color.Silver;
            this.tabEllipseArc.Controls.Add(this.ESweepAngle);
            this.tabEllipseArc.Controls.Add(this.label17);
            this.tabEllipseArc.Controls.Add(this.EStartAngle);
            this.tabEllipseArc.Controls.Add(this.label18);
            this.tabEllipseArc.Controls.Add(this.DrawEllispArc);
            this.tabEllipseArc.Controls.Add(this.B);
            this.tabEllipseArc.Controls.Add(this.label16);
            this.tabEllipseArc.Controls.Add(this.A);
            this.tabEllipseArc.Controls.Add(this.label15);
            this.tabEllipseArc.Controls.Add(this.CenterY);
            this.tabEllipseArc.Controls.Add(this.label12);
            this.tabEllipseArc.Controls.Add(this.label13);
            this.tabEllipseArc.Controls.Add(this.CenterX);
            this.tabEllipseArc.Controls.Add(this.label14);
            this.tabEllipseArc.Location = new System.Drawing.Point(4, 22);
            this.tabEllipseArc.Name = "tabEllipseArc";
            this.tabEllipseArc.Size = new System.Drawing.Size(659, 54);
            this.tabEllipseArc.TabIndex = 2;
            this.tabEllipseArc.Text = "椭圆弧";
            // 
            // ESweepAngle
            // 
            this.ESweepAngle.Location = new System.Drawing.Point(492, 17);
            this.ESweepAngle.Name = "ESweepAngle";
            this.ESweepAngle.Size = new System.Drawing.Size(27, 21);
            this.ESweepAngle.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(428, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 23;
            this.label17.Text = "跨越角度：";
            // 
            // EStartAngle
            // 
            this.EStartAngle.Location = new System.Drawing.Point(395, 17);
            this.EStartAngle.Name = "EStartAngle";
            this.EStartAngle.Size = new System.Drawing.Size(27, 21);
            this.EStartAngle.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(332, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "起始角度：";
            // 
            // DrawEllispArc
            // 
            this.DrawEllispArc.Location = new System.Drawing.Point(540, 12);
            this.DrawEllispArc.Name = "DrawEllispArc";
            this.DrawEllispArc.Size = new System.Drawing.Size(70, 30);
            this.DrawEllispArc.TabIndex = 20;
            this.DrawEllispArc.Text = "绘 制";
            this.DrawEllispArc.UseVisualStyleBackColor = true;
            this.DrawEllispArc.Click += new System.EventHandler(this.DrawEllispArc_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(298, 17);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(27, 21);
            this.B.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(245, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 18;
            this.label16.Text = "短半轴：";
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(212, 17);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(27, 21);
            this.A.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(160, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 16;
            this.label15.Text = "长半轴：";
            // 
            // CenterY
            // 
            this.CenterY.Location = new System.Drawing.Point(125, 16);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(27, 21);
            this.CenterY.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(64, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "x";
            // 
            // CenterX
            // 
            this.CenterX.Location = new System.Drawing.Point(75, 16);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(27, 21);
            this.CenterX.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 11;
            this.label14.Text = "中心位置：";
            // 
            // tabStr
            // 
            this.tabStr.BackColor = System.Drawing.Color.Silver;
            this.tabStr.Controls.Add(this.StrY);
            this.tabStr.Controls.Add(this.label20);
            this.tabStr.Controls.Add(this.label21);
            this.tabStr.Controls.Add(this.StrX);
            this.tabStr.Controls.Add(this.label22);
            this.tabStr.Controls.Add(this.DrawStr);
            this.tabStr.Controls.Add(this.Str);
            this.tabStr.Controls.Add(this.label19);
            this.tabStr.Location = new System.Drawing.Point(4, 22);
            this.tabStr.Name = "tabStr";
            this.tabStr.Padding = new System.Windows.Forms.Padding(3);
            this.tabStr.Size = new System.Drawing.Size(659, 54);
            this.tabStr.TabIndex = 3;
            this.tabStr.Text = " 文字";
            // 
            // StrY
            // 
            this.StrY.Location = new System.Drawing.Point(311, 17);
            this.StrY.Name = "StrY";
            this.StrY.Size = new System.Drawing.Size(27, 21);
            this.StrY.TabIndex = 19;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(294, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 18;
            this.label20.Text = "y";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(248, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(11, 12);
            this.label21.TabIndex = 17;
            this.label21.Text = "x";
            // 
            // StrX
            // 
            this.StrX.Location = new System.Drawing.Point(261, 17);
            this.StrX.Name = "StrX";
            this.StrX.Size = new System.Drawing.Size(27, 21);
            this.StrX.TabIndex = 16;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(188, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 12);
            this.label22.TabIndex = 15;
            this.label22.Text = "文字位置：";
            // 
            // DrawStr
            // 
            this.DrawStr.Location = new System.Drawing.Point(540, 12);
            this.DrawStr.Name = "DrawStr";
            this.DrawStr.Size = new System.Drawing.Size(70, 30);
            this.DrawStr.TabIndex = 14;
            this.DrawStr.Text = "绘 制";
            this.DrawStr.UseVisualStyleBackColor = true;
            this.DrawStr.Click += new System.EventHandler(this.DrawStr_Click);
            // 
            // Str
            // 
            this.Str.Location = new System.Drawing.Point(84, 17);
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(90, 21);
            this.Str.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(18, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 12;
            this.label19.Text = "输入文字：";
            // 
            // tabShadowLine
            // 
            this.tabShadowLine.BackColor = System.Drawing.Color.Silver;
            this.tabShadowLine.Controls.Add(this.DrawShadowLine);
            this.tabShadowLine.Controls.Add(this.VerticalH);
            this.tabShadowLine.Controls.Add(this.label26);
            this.tabShadowLine.Controls.Add(this.ShadowLineAngle);
            this.tabShadowLine.Controls.Add(this.label25);
            this.tabShadowLine.Controls.Add(this.InnerRing);
            this.tabShadowLine.Controls.Add(this.label24);
            this.tabShadowLine.Controls.Add(this.OuterRing);
            this.tabShadowLine.Controls.Add(this.label23);
            this.tabShadowLine.Location = new System.Drawing.Point(4, 22);
            this.tabShadowLine.Name = "tabShadowLine";
            this.tabShadowLine.Padding = new System.Windows.Forms.Padding(3);
            this.tabShadowLine.Size = new System.Drawing.Size(659, 54);
            this.tabShadowLine.TabIndex = 4;
            this.tabShadowLine.Text = "多边形阴影线填充";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(165, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 15;
            this.label24.Text = "内环点集：";
            // 
            // OuterRing
            // 
            this.OuterRing.Location = new System.Drawing.Point(69, 16);
            this.OuterRing.Name = "OuterRing";
            this.OuterRing.Size = new System.Drawing.Size(90, 21);
            this.OuterRing.TabIndex = 14;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "外环点集：";
            // 
            // PaintPanel
            // 
            this.PaintPanel.BackColor = System.Drawing.SystemColors.Window;
            this.PaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintPanel.Location = new System.Drawing.Point(4, 83);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(659, 353);
            this.PaintPanel.TabIndex = 3;
            // 
            // InnerRing
            // 
            this.InnerRing.Location = new System.Drawing.Point(225, 16);
            this.InnerRing.Name = "InnerRing";
            this.InnerRing.Size = new System.Drawing.Size(90, 21);
            this.InnerRing.TabIndex = 16;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(321, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 12);
            this.label25.TabIndex = 17;
            this.label25.Text = "夹角：";
            // 
            // ShadowLineAngle
            // 
            this.ShadowLineAngle.Location = new System.Drawing.Point(359, 17);
            this.ShadowLineAngle.Name = "ShadowLineAngle";
            this.ShadowLineAngle.Size = new System.Drawing.Size(27, 21);
            this.ShadowLineAngle.TabIndex = 18;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(392, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 19;
            this.label26.Text = "垂直间距：";
            // 
            // VerticalH
            // 
            this.VerticalH.Location = new System.Drawing.Point(455, 17);
            this.VerticalH.Name = "VerticalH";
            this.VerticalH.Size = new System.Drawing.Size(27, 21);
            this.VerticalH.TabIndex = 20;
            // 
            // DrawShadowLine
            // 
            this.DrawShadowLine.Location = new System.Drawing.Point(540, 12);
            this.DrawShadowLine.Name = "DrawShadowLine";
            this.DrawShadowLine.Size = new System.Drawing.Size(70, 30);
            this.DrawShadowLine.TabIndex = 21;
            this.DrawShadowLine.Text = "绘 制";
            this.DrawShadowLine.UseVisualStyleBackColor = true;
            this.DrawShadowLine.Click += new System.EventHandler(this.DrawShadowLine_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 441);
            this.Controls.Add(this.PaintPanel);
            this.Controls.Add(this.TabControl);
            this.Name = "MyForm";
            this.Text = "计算机图形学_图元绘制";
            this.TabControl.ResumeLayout(false);
            this.tabLine.ResumeLayout(false);
            this.tabLine.PerformLayout();
            this.tabCircleArc.ResumeLayout(false);
            this.tabCircleArc.PerformLayout();
            this.tabEllipseArc.ResumeLayout(false);
            this.tabEllipseArc.PerformLayout();
            this.tabStr.ResumeLayout(false);
            this.tabStr.PerformLayout();
            this.tabShadowLine.ResumeLayout(false);
            this.tabShadowLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabLine;
        private System.Windows.Forms.TabPage tabCircleArc;
        private System.Windows.Forms.TabPage tabEllipseArc;
        private System.Windows.Forms.TextBox LineSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LineSY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LineEY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LineEX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DrwaLineButton;
        private System.Windows.Forms.Panel PaintPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ArcY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ArcX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button DrawArcButton;
        private System.Windows.Forms.TextBox SweepAngle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox StartAngle;
        private System.Windows.Forms.TextBox Radius;
        private System.Windows.Forms.Label RadiusLable;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button DrawEllispArc;
        private System.Windows.Forms.TextBox ESweepAngle;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox EStartAngle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabStr;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox StrY;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox StrX;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button DrawStr;
        private System.Windows.Forms.TextBox Str;
        private System.Windows.Forms.TabPage tabShadowLine;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox OuterRing;
        private System.Windows.Forms.TextBox InnerRing;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox ShadowLineAngle;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox VerticalH;
        private System.Windows.Forms.Button DrawShadowLine;
    }
}


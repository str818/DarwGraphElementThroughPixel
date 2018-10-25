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
            this.tabArc = new System.Windows.Forms.TabPage();
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
            this.tab = new System.Windows.Forms.TabPage();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TabControl.SuspendLayout();
            this.tabLine.SuspendLayout();
            this.tabArc.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TabControl.Controls.Add(this.tabLine);
            this.TabControl.Controls.Add(this.tabArc);
            this.TabControl.Controls.Add(this.tab);
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
            this.LineEY.Location = new System.Drawing.Point(343, 16);
            this.LineEY.Name = "LineEY";
            this.LineEY.Size = new System.Drawing.Size(27, 21);
            this.LineEY.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "x";
            // 
            // LineEX
            // 
            this.LineEX.Location = new System.Drawing.Point(283, 16);
            this.LineEX.Name = "LineEX";
            this.LineEX.Size = new System.Drawing.Size(27, 21);
            this.LineEX.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "终止位置：";
            // 
            // LineSY
            // 
            this.LineSY.Location = new System.Drawing.Point(151, 16);
            this.LineSY.Name = "LineSY";
            this.LineSY.Size = new System.Drawing.Size(27, 21);
            this.LineSY.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "x";
            // 
            // LineSX
            // 
            this.LineSX.Location = new System.Drawing.Point(91, 16);
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
            // tabArc
            // 
            this.tabArc.BackColor = System.Drawing.Color.Silver;
            this.tabArc.Controls.Add(this.Radius);
            this.tabArc.Controls.Add(this.RadiusLable);
            this.tabArc.Controls.Add(this.DrawArcButton);
            this.tabArc.Controls.Add(this.SweepAngle);
            this.tabArc.Controls.Add(this.label11);
            this.tabArc.Controls.Add(this.StartAngle);
            this.tabArc.Controls.Add(this.label10);
            this.tabArc.Controls.Add(this.ArcY);
            this.tabArc.Controls.Add(this.label8);
            this.tabArc.Controls.Add(this.label9);
            this.tabArc.Controls.Add(this.ArcX);
            this.tabArc.Controls.Add(this.label7);
            this.tabArc.Location = new System.Drawing.Point(4, 22);
            this.tabArc.Name = "tabArc";
            this.tabArc.Padding = new System.Windows.Forms.Padding(3);
            this.tabArc.Size = new System.Drawing.Size(659, 54);
            this.tabArc.TabIndex = 1;
            this.tabArc.Text = " 圆弧";
            // 
            // Radius
            // 
            this.Radius.Location = new System.Drawing.Point(471, 17);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(27, 21);
            this.Radius.TabIndex = 17;
            this.Radius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // tab
            // 
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Size = new System.Drawing.Size(659, 54);
            this.tab.TabIndex = 2;
            this.tab.Text = "tabPage1";
            this.tab.UseVisualStyleBackColor = true;
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
            this.tabArc.ResumeLayout(false);
            this.tabArc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabLine;
        private System.Windows.Forms.TabPage tabArc;
        private System.Windows.Forms.TabPage tab;
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
        private System.Windows.Forms.ColorDialog colorDialog1;
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
    }
}


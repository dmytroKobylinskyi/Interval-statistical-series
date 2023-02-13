namespace Lab1
{
    partial class Grafics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_Empirychna = new System.Windows.Forms.RadioButton();
            this.radioButton_KumZaWidnChast = new System.Windows.Forms.RadioButton();
            this.radioButton_KumZaChast = new System.Windows.Forms.RadioButton();
            this.radioButton_polgonWidnosChastotamy = new System.Windows.Forms.RadioButton();
            this.radioButton_polgonChastotamy = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.побудуватиГрафікиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видалитиГрафікToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вихідToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 21);
            this.chart1.Name = "chart1";
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series6.BorderColor = System.Drawing.Color.Red;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series6.Color = System.Drawing.Color.Red;
            series6.EmptyPointStyle.BorderWidth = 3;
            series6.Legend = "Legend1";
            series6.Name = "Series2";
            series6.ShadowColor = System.Drawing.Color.AliceBlue;
            series6.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(996, 439);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart2);
            this.groupBox1.Controls.Add(this.chart1);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1001, 501);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Графік";
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(6, 21);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Legend = "Legend1";
            series8.Name = "Series2";
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(989, 453);
            this.chart2.TabIndex = 4;
            this.chart2.Text = "chart2";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton_Empirychna);
            this.groupBox2.Controls.Add(this.radioButton_KumZaWidnChast);
            this.groupBox2.Controls.Add(this.radioButton_KumZaChast);
            this.groupBox2.Controls.Add(this.radioButton_polgonWidnosChastotamy);
            this.groupBox2.Controls.Add(this.radioButton_polgonChastotamy);
            this.groupBox2.Location = new System.Drawing.Point(1019, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Графіки";
            // 
            // radioButton_Empirychna
            // 
            this.radioButton_Empirychna.AutoSize = true;
            this.radioButton_Empirychna.Location = new System.Drawing.Point(6, 142);
            this.radioButton_Empirychna.Name = "radioButton_Empirychna";
            this.radioButton_Empirychna.Size = new System.Drawing.Size(223, 21);
            this.radioButton_Empirychna.TabIndex = 9;
            this.radioButton_Empirychna.TabStop = true;
            this.radioButton_Empirychna.Text = "Емпірична функція розподілу";
            this.radioButton_Empirychna.UseVisualStyleBackColor = true;
            // 
            // radioButton_KumZaWidnChast
            // 
            this.radioButton_KumZaWidnChast.AutoSize = true;
            this.radioButton_KumZaWidnChast.Location = new System.Drawing.Point(6, 114);
            this.radioButton_KumZaWidnChast.Name = "radioButton_KumZaWidnChast";
            this.radioButton_KumZaWidnChast.Size = new System.Drawing.Size(328, 21);
            this.radioButton_KumZaWidnChast.TabIndex = 8;
            this.radioButton_KumZaWidnChast.TabStop = true;
            this.radioButton_KumZaWidnChast.Text = "Кумулятивна крива за відносними частотами";
            this.radioButton_KumZaWidnChast.UseVisualStyleBackColor = true;
            // 
            // radioButton_KumZaChast
            // 
            this.radioButton_KumZaChast.AutoSize = true;
            this.radioButton_KumZaChast.Location = new System.Drawing.Point(6, 86);
            this.radioButton_KumZaChast.Name = "radioButton_KumZaChast";
            this.radioButton_KumZaChast.Size = new System.Drawing.Size(250, 21);
            this.radioButton_KumZaChast.TabIndex = 7;
            this.radioButton_KumZaChast.TabStop = true;
            this.radioButton_KumZaChast.Text = "Кумулятивна крива за частотами";
            this.radioButton_KumZaChast.UseVisualStyleBackColor = true;
            // 
            // radioButton_polgonWidnosChastotamy
            // 
            this.radioButton_polgonWidnosChastotamy.AutoSize = true;
            this.radioButton_polgonWidnosChastotamy.Location = new System.Drawing.Point(6, 58);
            this.radioButton_polgonWidnosChastotamy.Name = "radioButton_polgonWidnosChastotamy";
            this.radioButton_polgonWidnosChastotamy.Size = new System.Drawing.Size(250, 21);
            this.radioButton_polgonWidnosChastotamy.TabIndex = 6;
            this.radioButton_polgonWidnosChastotamy.TabStop = true;
            this.radioButton_polgonWidnosChastotamy.Text = "Полігон за відносними частотами";
            this.radioButton_polgonWidnosChastotamy.UseVisualStyleBackColor = true;
            // 
            // radioButton_polgonChastotamy
            // 
            this.radioButton_polgonChastotamy.AutoSize = true;
            this.radioButton_polgonChastotamy.Location = new System.Drawing.Point(6, 30);
            this.radioButton_polgonChastotamy.Name = "radioButton_polgonChastotamy";
            this.radioButton_polgonChastotamy.Size = new System.Drawing.Size(172, 21);
            this.radioButton_polgonChastotamy.TabIndex = 5;
            this.radioButton_polgonChastotamy.TabStop = true;
            this.radioButton_polgonChastotamy.Text = "Полігон за частотами";
            this.radioButton_polgonChastotamy.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.вихідToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1402, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.побудуватиГрафікиToolStripMenuItem,
            this.видалитиГрафікToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // побудуватиГрафікиToolStripMenuItem
            // 
            this.побудуватиГрафікиToolStripMenuItem.Name = "побудуватиГрафікиToolStripMenuItem";
            this.побудуватиГрафікиToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.побудуватиГрафікиToolStripMenuItem.Text = "Побудувати графік";
            this.побудуватиГрафікиToolStripMenuItem.Click += new System.EventHandler(this.побудуватиГрафікиToolStripMenuItem_Click);
            // 
            // видалитиГрафікToolStripMenuItem
            // 
            this.видалитиГрафікToolStripMenuItem.Name = "видалитиГрафікToolStripMenuItem";
            this.видалитиГрафікToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.видалитиГрафікToolStripMenuItem.Text = "Видалити графік";
            this.видалитиГрафікToolStripMenuItem.Click += new System.EventHandler(this.видалитиГрафікToolStripMenuItem_Click);
            // 
            // вихідToolStripMenuItem
            // 
            this.вихідToolStripMenuItem.Name = "вихідToolStripMenuItem";
            this.вихідToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.вихідToolStripMenuItem.Text = "Вихід";
            this.вихідToolStripMenuItem.Click += new System.EventHandler(this.вихідToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1157, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
          
            // 
            // Grafics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 682);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grafics";
            this.Text = "Grafics";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem побудуватиГрафікиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видалитиГрафікToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вихідToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton_polgonWidnosChastotamy;
        private System.Windows.Forms.RadioButton radioButton_polgonChastotamy;
        private System.Windows.Forms.RadioButton radioButton_Empirychna;
        private System.Windows.Forms.RadioButton radioButton_KumZaWidnChast;
        private System.Windows.Forms.RadioButton radioButton_KumZaChast;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button1;
    }
}
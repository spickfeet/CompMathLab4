namespace CompMathLab3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewCoordinates = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddCoordinate = new System.Windows.Forms.Button();
            this.buttonDeleteCoordinate = new System.Windows.Forms.Button();
            this.comboBoxMethods = new System.Windows.Forms.ComboBox();
            this.labelMethod = new System.Windows.Forms.Label();
            this.buttonUseMethod = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.numericUpDownDegree = new System.Windows.Forms.NumericUpDown();
            this.labelDegree = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMeme = new System.Windows.Forms.Label();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.textBoxA3 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA4 = new System.Windows.Forms.TextBox();
            this.textBoxA0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericStepDegree = new System.Windows.Forms.NumericUpDown();
            this.labelStepBase10 = new System.Windows.Forms.Label();
            this.labelStep = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelFirstDev = new System.Windows.Forms.Label();
            this.numericUpDownAccuracy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepDegree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea3.AxisX.Maximum = 10D;
            chartArea3.AxisX.Minimum = -1D;
            chartArea3.AxisY.Maximum = 20D;
            chartArea3.AxisY.Minimum = -5D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Location = new System.Drawing.Point(24, 12);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series27.BorderWidth = 10;
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series27.Color = System.Drawing.Color.Violet;
            series27.Name = "Series1";
            series28.BorderWidth = 4;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series28.Name = "Series2";
            series29.BorderWidth = 4;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series29.Name = "Series3";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series30.Name = "Series4";
            series31.BorderWidth = 2;
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series31.Color = System.Drawing.Color.Lime;
            series31.Name = "Series5";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series32.Color = System.Drawing.Color.Indigo;
            series32.MarkerSize = 2;
            series32.Name = "Series6";
            series33.BorderWidth = 3;
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series33.Name = "Series7";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series34.Name = "Series8";
            series35.BorderWidth = 3;
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series35.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series35.Name = "Series9";
            series36.BorderWidth = 5;
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series36.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            series36.Name = "Series10";
            series37.BorderWidth = 6;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series37.Color = System.Drawing.Color.Black;
            series37.Name = "Series11";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series38.Color = System.Drawing.Color.Black;
            series38.MarkerSize = 2;
            series38.Name = "Series13";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series39.Color = System.Drawing.Color.Red;
            series39.Name = "Series14";
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
            this.chart1.Series.Add(series31);
            this.chart1.Series.Add(series32);
            this.chart1.Series.Add(series33);
            this.chart1.Series.Add(series34);
            this.chart1.Series.Add(series35);
            this.chart1.Series.Add(series36);
            this.chart1.Series.Add(series37);
            this.chart1.Series.Add(series38);
            this.chart1.Series.Add(series39);
            this.chart1.Size = new System.Drawing.Size(1066, 752);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Графики";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // dataGridViewCoordinates
            // 
            this.dataGridViewCoordinates.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewCoordinates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoordinates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y});
            this.dataGridViewCoordinates.Location = new System.Drawing.Point(1116, 18);
            this.dataGridViewCoordinates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCoordinates.Name = "dataGridViewCoordinates";
            this.dataGridViewCoordinates.RowHeadersWidth = 51;
            this.dataGridViewCoordinates.Size = new System.Drawing.Size(369, 305);
            this.dataGridViewCoordinates.TabIndex = 5;
            // 
            // x
            // 
            this.x.Frozen = true;
            this.x.HeaderText = "x";
            this.x.MinimumWidth = 6;
            this.x.Name = "x";
            this.x.Width = 125;
            // 
            // y
            // 
            this.y.Frozen = true;
            this.y.HeaderText = "y";
            this.y.MinimumWidth = 6;
            this.y.Name = "y";
            this.y.Width = 125;
            // 
            // buttonAddCoordinate
            // 
            this.buttonAddCoordinate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCoordinate.Location = new System.Drawing.Point(1116, 344);
            this.buttonAddCoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCoordinate.Name = "buttonAddCoordinate";
            this.buttonAddCoordinate.Size = new System.Drawing.Size(372, 44);
            this.buttonAddCoordinate.TabIndex = 6;
            this.buttonAddCoordinate.Text = "Добавить точку";
            this.buttonAddCoordinate.UseVisualStyleBackColor = true;
            this.buttonAddCoordinate.Click += new System.EventHandler(this.buttonAddCoordinate_Click);
            // 
            // buttonDeleteCoordinate
            // 
            this.buttonDeleteCoordinate.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteCoordinate.Location = new System.Drawing.Point(1116, 396);
            this.buttonDeleteCoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDeleteCoordinate.Name = "buttonDeleteCoordinate";
            this.buttonDeleteCoordinate.Size = new System.Drawing.Size(372, 44);
            this.buttonDeleteCoordinate.TabIndex = 7;
            this.buttonDeleteCoordinate.Text = "Удалить точку";
            this.buttonDeleteCoordinate.UseVisualStyleBackColor = true;
            this.buttonDeleteCoordinate.Click += new System.EventHandler(this.buttonDeleteCoordinate_Click);
            // 
            // comboBoxMethods
            // 
            this.comboBoxMethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMethods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBoxMethods.FormattingEnabled = true;
            this.comboBoxMethods.Items.AddRange(new object[] {
            "Метод Лагранжа",
            "Метод Ньютона",
            "Метод наименьших квадратов",
            "Кубические сплайны",
            "Первая производная"});
            this.comboBoxMethods.Location = new System.Drawing.Point(1498, 50);
            this.comboBoxMethods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMethods.Name = "comboBoxMethods";
            this.comboBoxMethods.Size = new System.Drawing.Size(313, 37);
            this.comboBoxMethods.TabIndex = 8;
            this.comboBoxMethods.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethods_SelectedIndexChanged);
            // 
            // labelMethod
            // 
            this.labelMethod.AutoSize = true;
            this.labelMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMethod.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMethod.ForeColor = System.Drawing.Color.White;
            this.labelMethod.Location = new System.Drawing.Point(1531, 15);
            this.labelMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(222, 34);
            this.labelMethod.TabIndex = 9;
            this.labelMethod.Text = "Выберите метод";
            // 
            // buttonUseMethod
            // 
            this.buttonUseMethod.BackColor = System.Drawing.Color.Transparent;
            this.buttonUseMethod.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUseMethod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUseMethod.Location = new System.Drawing.Point(1498, 98);
            this.buttonUseMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUseMethod.Name = "buttonUseMethod";
            this.buttonUseMethod.Size = new System.Drawing.Size(315, 50);
            this.buttonUseMethod.TabIndex = 10;
            this.buttonUseMethod.Text = "Применить метод";
            this.buttonUseMethod.UseVisualStyleBackColor = false;
            this.buttonUseMethod.Click += new System.EventHandler(this.buttonUseMethod_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(1498, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(315, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // numericUpDownDegree
            // 
            this.numericUpDownDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.numericUpDownDegree.Location = new System.Drawing.Point(1498, 386);
            this.numericUpDownDegree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDegree.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownDegree.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownDegree.Name = "numericUpDownDegree";
            this.numericUpDownDegree.Size = new System.Drawing.Size(315, 34);
            this.numericUpDownDegree.TabIndex = 11;
            this.numericUpDownDegree.Visible = false;
            this.numericUpDownDegree.ValueChanged += new System.EventHandler(this.numericUpDownDegree_ValueChanged);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDegree.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDegree.ForeColor = System.Drawing.Color.White;
            this.labelDegree.Location = new System.Drawing.Point(1490, 349);
            this.labelDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(116, 34);
            this.labelDegree.TabIndex = 12;
            this.labelDegree.Text = "Степень";
            this.labelDegree.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1552, 451);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelMeme
            // 
            this.labelMeme.AutoSize = true;
            this.labelMeme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelMeme.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMeme.ForeColor = System.Drawing.Color.White;
            this.labelMeme.Location = new System.Drawing.Point(1599, 468);
            this.labelMeme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMeme.Name = "labelMeme";
            this.labelMeme.Size = new System.Drawing.Size(201, 34);
            this.labelMeme.TabIndex = 14;
            this.labelMeme.Text = "Я программист";
            // 
            // textBoxA1
            // 
            this.textBoxA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA1.Location = new System.Drawing.Point(1695, 222);
            this.textBoxA1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(105, 28);
            this.textBoxA1.TabIndex = 15;
            this.textBoxA1.Visible = false;
            // 
            // textBoxA3
            // 
            this.textBoxA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA3.Location = new System.Drawing.Point(1534, 258);
            this.textBoxA3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA3.Name = "textBoxA3";
            this.textBoxA3.Size = new System.Drawing.Size(105, 28);
            this.textBoxA3.TabIndex = 16;
            this.textBoxA3.Visible = false;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA2.Location = new System.Drawing.Point(1532, 294);
            this.textBoxA2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(105, 28);
            this.textBoxA2.TabIndex = 17;
            this.textBoxA2.Visible = false;
            // 
            // textBoxA4
            // 
            this.textBoxA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA4.Location = new System.Drawing.Point(1534, 222);
            this.textBoxA4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA4.Name = "textBoxA4";
            this.textBoxA4.Size = new System.Drawing.Size(103, 28);
            this.textBoxA4.TabIndex = 18;
            this.textBoxA4.Visible = false;
            // 
            // textBoxA0
            // 
            this.textBoxA0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxA0.Location = new System.Drawing.Point(1692, 258);
            this.textBoxA0.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA0.Name = "textBoxA0";
            this.textBoxA0.Size = new System.Drawing.Size(106, 28);
            this.textBoxA0.TabIndex = 19;
            this.textBoxA0.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1659, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "a0";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1659, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "a1";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1494, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "a2";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1492, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "a3";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1494, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "a4";
            this.label5.Visible = false;
            // 
            // numericStepDegree
            // 
            this.numericStepDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericStepDegree.Location = new System.Drawing.Point(1742, 361);
            this.numericStepDegree.Margin = new System.Windows.Forms.Padding(2);
            this.numericStepDegree.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Name = "numericStepDegree";
            this.numericStepDegree.Size = new System.Drawing.Size(70, 30);
            this.numericStepDegree.TabIndex = 25;
            this.numericStepDegree.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericStepDegree.Visible = false;
            // 
            // labelStepBase10
            // 
            this.labelStepBase10.AutoSize = true;
            this.labelStepBase10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelStepBase10.ForeColor = System.Drawing.Color.White;
            this.labelStepBase10.Location = new System.Drawing.Point(1692, 388);
            this.labelStepBase10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStepBase10.Name = "labelStepBase10";
            this.labelStepBase10.Size = new System.Drawing.Size(44, 31);
            this.labelStepBase10.TabIndex = 26;
            this.labelStepBase10.Text = "10";
            this.labelStepBase10.Visible = false;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelStep.ForeColor = System.Drawing.Color.White;
            this.labelStep.Location = new System.Drawing.Point(1622, 388);
            this.labelStep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(70, 31);
            this.labelStep.TabIndex = 27;
            this.labelStep.Text = "Шаг:";
            this.labelStep.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(1116, 472);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(430, 292);
            this.richTextBox1.TabIndex = 28;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // labelFirstDev
            // 
            this.labelFirstDev.AutoSize = true;
            this.labelFirstDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstDev.ForeColor = System.Drawing.Color.White;
            this.labelFirstDev.Location = new System.Drawing.Point(1111, 444);
            this.labelFirstDev.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstDev.Name = "labelFirstDev";
            this.labelFirstDev.Size = new System.Drawing.Size(359, 25);
            this.labelFirstDev.TabIndex = 29;
            this.labelFirstDev.Text = "Приближ. знач. первой производной:";
            this.labelFirstDev.Visible = false;
            // 
            // numericUpDownAccuracy
            // 
            this.numericUpDownAccuracy.DecimalPlaces = 3;
            this.numericUpDownAccuracy.Location = new System.Drawing.Point(1178, 783);
            this.numericUpDownAccuracy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownAccuracy.Name = "numericUpDownAccuracy";
            this.numericUpDownAccuracy.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownAccuracy.TabIndex = 30;
            this.numericUpDownAccuracy.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1825, 845);
            this.Controls.Add(this.numericUpDownAccuracy);
            this.Controls.Add(this.labelFirstDev);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.labelStepBase10);
            this.Controls.Add(this.numericStepDegree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA0);
            this.Controls.Add(this.textBoxA4);
            this.Controls.Add(this.textBoxA2);
            this.Controls.Add(this.textBoxA3);
            this.Controls.Add(this.textBoxA1);
            this.Controls.Add(this.labelMeme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.numericUpDownDegree);
            this.Controls.Add(this.buttonUseMethod);
            this.Controls.Add(this.labelMethod);
            this.Controls.Add(this.comboBoxMethods);
            this.Controls.Add(this.buttonDeleteCoordinate);
            this.Controls.Add(this.buttonAddCoordinate);
            this.Controls.Add(this.dataGridViewCoordinates);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.chart1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStepDegree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAccuracy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridViewCoordinates;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.Button buttonAddCoordinate;
        private System.Windows.Forms.Button buttonDeleteCoordinate;
        private System.Windows.Forms.ComboBox comboBoxMethods;
        private System.Windows.Forms.Label labelMethod;
        private System.Windows.Forms.Button buttonUseMethod;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown numericUpDownDegree;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMeme;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.TextBox textBoxA3;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA4;
        private System.Windows.Forms.TextBox textBoxA0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericStepDegree;
        private System.Windows.Forms.Label labelStepBase10;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelFirstDev;
        private System.Windows.Forms.NumericUpDown numericUpDownAccuracy;
    }
}


using System;
using System.Windows.Forms;

namespace CompMathLab3
{
    public partial class Form1 : Form
    {
        //private double[,] _numbers = new double[,] { { 2, 4, 5 ,6,7}, { 6,6,1,-1,11 } };

        private Lagrange _lagrange = new Lagrange();
        private NewtonForm _newtonForm = new NewtonForm();
        private LeastSquares _leastSquares = new LeastSquares();
        private CubeSpline _cubeSpline = new CubeSpline();


        private double MaxX
        {
            get
            {
                double maxValue = double.MinValue;
                for (int i = 0; i < Numbers.GetLength(1); i++)
                    if (Numbers[0, i]> maxValue)
                        maxValue = Numbers[0, i];
                    
                return maxValue;
            }
        }
        private double[,] _numbers;
        private double[,] Numbers
        {
            get
            {
                if (_numbers == null)
                {
                    _numbers = new double[dataGridViewCoordinates.Columns.Count, dataGridViewCoordinates.Rows.Count];
                    for (int i = 0; i < dataGridViewCoordinates.Columns.Count; i++)
                    {
                        for (int j = 0; j < (dataGridViewCoordinates.Rows.Count); j++)
                        {
                            _numbers[i, j] = double.Parse(dataGridViewCoordinates[i, j].Value.ToString());
                        }
                    }

                }
                return _numbers;
            }
        }
        public Form1()
        {
            InitializeComponent();
            dataGridViewCoordinates.AllowUserToAddRows = false;
        }

        private void DrawByLagrange()
        {
            chart1.Series[1].Points.Clear();
            double x = -1, y;
            while (x < MaxX + 1)
            {
                y = _lagrange.Interpolate(Numbers, x);
                chart1.Series[1].Points.AddXY(x, y);
                x += 0.01; 
            }
        }
        private void DrawByCubeSpline()
        {
            chart1.Series[5].Points.Clear();
            double x = Numbers[0,0], y;
            while (x <= MaxX)
            {
                y = _cubeSpline.Interpolate(Numbers, _cubeSpline.GetSplineSystem(Numbers),x);
                chart1.Series[5].Points.AddXY(x, y);
                x += 0.01;
            }
        }

        private void DrawByLeastSquares()
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[4].Points.Clear();
            if (numericUpDownDegree.Value == 4)
            {
                if (textBoxA4.Text == string.Empty || textBoxA3.Text == string.Empty || textBoxA2.Text == string.Empty 
                    || textBoxA1.Text == string.Empty || textBoxA0.Text == string.Empty)
                {
                    MessageBox.Show("Введите коэффициенты а4, а3, а2, а1 и а0");
                }
                else 
                { 
                    double[] y = _leastSquares.ApplySmoothing(Numbers, (int)numericUpDownDegree.Value, new double[]
                    {
                        double.Parse(textBoxA4.Text),
                        double.Parse(textBoxA3.Text),
                        double.Parse(textBoxA2.Text),
                        double.Parse(textBoxA1.Text),
                        double.Parse(textBoxA0.Text)
                    });
                    double[] y1 = _leastSquares.ApplySmoothing(Numbers, (int)(numericUpDownDegree.Value));
                    for (int i = 0; i < y.Length; i++)
                    {
                        chart1.Series[0].Points.AddXY(Numbers[0, i], y[i]);
                    }
                    for (int i = 0; i < y1.Length; i++)
                    {
                        chart1.Series[4].Points.AddXY(Numbers[0, i], y1[i]);
                    }
                }
            }
            else
            {
                double[] y = _leastSquares.ApplySmoothing(Numbers, (int)numericUpDownDegree.Value);
                for (int i = 0; i < y.Length; i++)
                {
                    chart1.Series[0].Points.AddXY(Numbers[0, i], y[i]);
                }
            }
        }

        private void DrawByNewton()
        {
            chart1.Series[2].Points.Clear();

            double[] _numbersX = new double[5];
            double[] _numbersY = new double[5];

            for (int i = 0; i < Numbers.GetLength(1); i++)
                _numbersX[i] = Numbers[0, i];

            for (int i = 0; i < Numbers.GetLength(1); i++)
                _numbersY[i] = Numbers[1, i];

            double x = -1, y;
            while (x < MaxX + 1)
            {
                y = _newtonForm.MainFunction(x, _numbersX, _numbersY);
                chart1.Series[2].Points.AddXY(x, y);
                x+=0.01;
            }
        }
        private void DrawPoints()
        {
            chart1.Series[3].Points.Clear();
            chart1.Series[3].MarkerSize = 8;
            chart1.Series[3].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            for (int i = 0; i < Numbers.GetLength(1); i++)
            {
                chart1.Series[3].Points.AddXY(Numbers[0, i], Numbers[1, i]);
            }
        }
        
        private void buttonClear_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < chart1.Series.Count;i++)
                chart1.Series[i].Points.Clear();
        }

        private void buttonAddCoordinate_Click(object sender, EventArgs e)
        {
            _numbers = null;
            dataGridViewCoordinates.Rows.Add();
        }

        private void buttonDeleteCoordinate_Click(object sender, EventArgs e)
        {
            _numbers = null;
            dataGridViewCoordinates.Rows.RemoveAt(dataGridViewCoordinates.CurrentCell.RowIndex);
        }

        private void buttonUseMethod_Click(object sender, EventArgs e)
        {
            _numbers = null;
            for (int j = Numbers.GetLength(1) - 1; j > 0; j--)
            {
                // основной цикл внутри каждого прогона
                // перебираем все элементы от первого до последнего в прогоне, который мы определили выше
                for (int i = 0; i < j; i++)
                {
                    // если текущий элемент больше следующего
                    if (Numbers[0,i] > Numbers[0,i + 1])
                    {
                        // запоминаем значение текущего элемента
                        double temp = Numbers[0, i];
                        // записываем на его место значение следующего
                        Numbers[0, i] = Numbers[0, i + 1];
                        // а на место следующего ставим значение текущего, тем самым меняем их местами
                        Numbers[0, i + 1] = temp;

                        temp = Numbers[1, i];
                        Numbers[1, i] = Numbers[1, i + 1];
                        Numbers[1, i + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < Numbers.GetLength(1) - 1; i++)
            {
                if(Numbers[0,i] == Numbers[0, i + 1])
                {
                    if (Numbers[1, i] != Numbers[1, i + 1])
                    {
                        MessageBox.Show("Некорректные координаты точек");
                        return;
                    }
                    if (Numbers[1, i] == Numbers[1, i + 1])
                    {
                        MessageBox.Show("Удалите дублирование");
                        return;
                    }
                }
            }




            DrawPoints();
            switch (comboBoxMethods.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("Выберите метод");
                    break;
                case 0:
                    DrawByLagrange();
                    break;
                case 1: 
                    DrawByNewton();
                    break;
                case 2:
                    DrawByLeastSquares();
                    break;
                case 3:
                    DrawByCubeSpline();
                    break;

            }
        }

        private void comboBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMethods.SelectedIndex == 2)
            {

                labelDegree.Visible = true;
                numericUpDownDegree.Visible = true;
            }
            else
            {
                numericUpDownDegree.Value = 0;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBoxA4.Visible = false;
                textBoxA3.Visible = false;
                textBoxA2.Visible = false;
                textBoxA1.Visible = false;
                textBoxA0.Visible = false;
                labelDegree.Visible = false;
                numericUpDownDegree.Visible = false;
            }
        }

        private void numericUpDownDegree_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDownDegree.Value == 4) 
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBoxA4.Visible = true;
                textBoxA3.Visible = true;
                textBoxA2.Visible = true;
                textBoxA1.Visible = true;
                textBoxA0.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBoxA4.Visible = false;
                textBoxA3.Visible = false;
                textBoxA2.Visible = false;
                textBoxA1.Visible = false;
                textBoxA0.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

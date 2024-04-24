using System;
using System.Linq;
using System.Windows.Forms;
using Testing;

namespace CompMathLab3
{
    public partial class Form1 : Form
    {
        private bool _isPointsExist = false;
        private double[,] _numbersFirstDeriv = new double[2, 5] { { 0.01, 0.1, 1, 10, 100 }, { 0.02, 0.2, 2, 20, 200 } };
        private Lagrange _lagrange = new Lagrange();
        private NewtonForm _newtonForm = new NewtonForm();
        private LeastSquares _leastSquares = new LeastSquares();
        private CubeSpline _cubeSpline;
        private Derivative _derivative = new Derivative();

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
            chart1.ChartAreas[0].Axes[0].Maximum = 4;
            chart1.ChartAreas[0].Axes[0].Minimum = -4;
            chart1.ChartAreas[0].Axes[1].Maximum = 4;
            chart1.ChartAreas[0].Axes[1].Minimum = -4;

            chart1.Series[5].Points.Clear();
            chart1.Series[8].Points.Clear();
            chart1.Series[9].Points.Clear();

            double x = Numbers[0,0], y, yPlusStep, yMinusStep, derivFirst = 0, derivSecond = 0, derivSecondY2 = 0,
                yPlusTwoSteps, yMinusTwoSteps;
            double step = (double)numericUpDownAccuracy.Value;
            _cubeSpline = new CubeSpline(Numbers);
            double y2;
            while (x <= MaxX)
            {
                y = _cubeSpline.Interpolate(x);
                y2 = Math.Pow(x, 2);
                chart1.Series[5].Points.AddXY(x, y);    //кубич. сплайн
                chart1.Series[12].Points.AddXY(x, y2);   
                if (x >= Numbers[0, 0] + 2 * step && x <= MaxX - 2 * step)
                {
                    //if (x <= (Numbers[0, pointIndex] + 2 * step) + step / 2 && x >= (Numbers[0, pointIndex] - 2 * step) - step / 2)
                    //{
                    //    if (x >= (Numbers[0, pointIndex] + 2 * step) - step / 2 && x <= (Numbers[0, pointIndex] + 2 * step) + step / 2)
                    //    {
                    //        pointIndex++;
                    //    }
                    //    x += step;
                    //    continue;
                    //}

                    yPlusStep = _cubeSpline.Interpolate(x + step);
                    yMinusStep = _cubeSpline.Interpolate(x - step);
                    derivFirst = _derivative.CalculateFirstDerivativeTwoSteps(yPlusStep, yMinusStep, step);

                    yPlusTwoSteps = _cubeSpline.Interpolate(x + 2 * step);
                    yMinusTwoSteps = _cubeSpline.Interpolate(x - 2 * step);
                    derivSecond = _derivative.CalculateSecondDerivative(yPlusTwoSteps, yMinusTwoSteps, y, step);

                    derivSecondY2 = _derivative.CalculateSecondDerivative(Math.Pow(x + 2 * step, 2), Math.Pow(x - 2 * step, 2), Math.Pow(x, 2), step);

                    chart1.Series[8].Points.AddXY(x, derivFirst);    //первые производные
                    chart1.Series[9].Points.AddXY(x, derivSecond);    //вторые производные
                    chart1.Series[11].Points.AddXY(x, derivSecondY2);    //вторые производные
                }
                x += step;
            }

        }

        private void DrawByFirstDerivative()
        {
            chart1.ChartAreas[0].Axes[0].Maximum = 1.1;
            chart1.ChartAreas[0].Axes[0].Minimum = 0;
            chart1.ChartAreas[0].Axes[1].Maximum = 2.1;
            chart1.ChartAreas[0].Axes[1].Minimum = 0;

            _derivative = new Derivative();
            richTextBox1.Text = $"\nШаг: 10^{(double)numericStepDegree.Value}\n";
            chart1.Series[6].Points.Clear();
            
            double step = Math.Pow(10,(double) numericStepDegree.Value);
            double derivative = 0;

            for (int i = 0; i < Numbers.GetLength(1); i++)
            {
                derivative = _derivative.CalculateFirstDerivative(Numbers[0, i], step);
                chart1.Series[6].Points.AddXY(Numbers[0, i],derivative );
                richTextBox1.Text += $"\nx = {Numbers[0, i]}, f ' (x) = {derivative}\n";
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
                chart1.Series[3].Points.AddXY(Numbers[0, i], Numbers[1, i]);
            
        }
        private void DrawPointsFirstDerivative()
        {
            
            if(!_isPointsExist)
            {
                chart1.Series[7].Points.Clear();
                chart1.Series[7].MarkerSize = 8;
                chart1.Series[7].MarkerColor = System.Drawing.Color.Red;
                chart1.Series[7].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                for (int i = 0; i < _numbersFirstDeriv.GetLength(1); i++)
                    chart1.Series[7].Points.AddXY(_numbersFirstDeriv[0, i], _numbersFirstDeriv[1, i]);
                
                _isPointsExist = true;
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



            if (comboBoxMethods.SelectedIndex != 4)
                DrawPoints();
            else
                DrawPointsFirstDerivative();

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
                case 4:
                    DrawByFirstDerivative();
                    break;

            }
        }

        private void comboBoxMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxMethods.SelectedIndex == 2)
            {

                labelDegree.Visible = true;
                numericUpDownDegree.Visible = true;
                labelStep.Visible = false;
                labelStepBase10.Visible = false;
                numericStepDegree.Visible = false;
                labelFirstDev.Visible = false;
                richTextBox1.Visible = false;
            }
            else if(comboBoxMethods.SelectedIndex == 4)
            {
                labelDegree.Visible = false;
                numericUpDownDegree.Visible = false;
                labelStep.Visible = true;
                labelStepBase10.Visible = true;
                numericStepDegree.Visible = true;
                labelFirstDev.Visible = true;
                richTextBox1.Visible = true;
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

            else
            {
                labelFirstDev.Visible = false;
                richTextBox1.Visible = false;
                labelStep.Visible = false;
                labelStepBase10.Visible = false;
                numericStepDegree.Visible = false;
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

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}

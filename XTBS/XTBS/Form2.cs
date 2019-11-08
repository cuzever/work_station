using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinearAlgebra;

namespace XTBS
{
    
    public partial class Form2 : Form
    {
        private Queue<double> dataQueue0 = new Queue<double>();
        private Queue<double> dataQueue1 = new Queue<double>();
        private Queue<double> dataQueue2 = new Queue<double>();
        private Queue<double> dataQueue3 = new Queue<double>();
        public Form2()
        {
            InitializeComponent();
            comboBox1.Items.Add("z(k)+a1z(k-1)+a2z(k-2)=b1u(k-1)+b2u(k-2)+v(k)");
        }

    

        //一般最小二乘辨识方法
        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string z1, z2, z3, z4;
            z1 = textBox1.Text;
            z2 = textBox2.Text;
            z3 = textBox3.Text;
            z4 = textBox4.Text;
            a = Convert.ToDouble(z1);
            b = Convert.ToDouble(z2);
            c = Convert.ToDouble(z3);
            d = Convert.ToDouble(z4);

            Matrix v = new double[1, 15];
            double A = Math.Pow(5, 17), x0 = 1, G = Math.Pow(2, 42), y2 = 0, y1 = 0, v1 = 0, v0 = 0;
            for (int i = 0; i < 15; i++)
            {
                y2 = A * x0;
                y1 = y2 % G;
                v1 = y1 / G;
                v[0, i] = v1;
                x0 = y1;
                v0 = v1;
            }

            Matrix u = new double[2, 15];
            int x1, x2, x3, x4;
            int[] y = new int[4] { 1, 1, 1, 0 };
            for (int i = 0; i < 15; i++)
            {
                x1 = y[2] ^ y[3];
                x2 = y[0];
                x3 = y[1];
                x4 = y[2];

                if (y[3] > 0.5)
                    u[1, i] = -5;
                else
                    u[1, i] = 5;

                u[0, i] = i + 1;
                y[0] = x1;
                y[1] = x2;
                y[2] = x3;
                y[3] = x4;
            }


            Matrix Z = new double[16, 1];
            Matrix H = new double[14, 4];
            Matrix C = new double[4, 1];
            Matrix M = new double[14, 1];

            for (int k = 2; k < 16; k++)
            {
                Z[k, 0] = -a * Z[k - 1, 0] - b * Z[k - 2, 0] + c * u[1, k - 1] + d * u[1, k - 2] + v[0, k - 2];
            }

            for (int i = 0, j = 2, k = 2; i < 14; i++)
            {

                H[i, j - 2] = -Z[k - 1, 0];
                H[i, j - 1] = -Z[k - 2, 0];
                H[i, j] = u[1, k - 1];
                H[i, j + 1] = u[1, k - 2];
                k = k + 1;

            }

            for (int k = 2; k < 16; k++)
            {
                M[k - 2, 0] = Z[k, 0];
            }

            Matrix N = new double[4, 14];
            Matrix E = new double[14, 14];
            Matrix F = new double[4, 4];
            N = H.Transpose();
            E = N * H;
            F = E.Inverse();
            C = F * N * M;

            double a1, a2, b1, b2;
            a1 = C[0, 0];
            a2 = C[1, 0];
            b1 = C[2, 0];
            b2 = C[3, 0];
            textBox5.Text = a1.ToString("0.000");
            textBox6.Text = a2.ToString("0.000");
            textBox7.Text = b1.ToString("0.000");
            textBox8.Text = b2.ToString("0.000");           
        }

        //递推最小二乘法
        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string z1, z2, z3, z4;
            z1 = textBox1.Text;
            z2 = textBox2.Text;
            z3 = textBox3.Text;
            z4 = textBox4.Text;
            a = Convert.ToDouble(z1);
            b = Convert.ToDouble(z2);
            c = Convert.ToDouble(z3);
            d = Convert.ToDouble(z4);

            Matrix v = new double[1, 60];
            double A = Math.Pow(5, 17), x0 = 1, G = Math.Pow(2, 42), y2 = 0, y1 = 0, v1 = 0, v0 = 0;
            for (int i = 0; i < 60; i++)
            {
                y2 = A * x0;
                y1 = y2 % G;
                v1 = y1 / G;
                v[0, i] = v1;
                x0 = y1;
                v0 = v1;
            }

            int[,] u = new int[2, 60];
            int x1, x2, x3, x4;
            int[] y = new int[4] { 1, 1, 1, 0 };
            for (int i = 0; i < 60; i++)
            {
                x1 = y[2] ^ y[3];
                x2 = y[0];
                x3 = y[1];
                x4 = y[2];
                if (y[3] > 0.5)
                    u[1, i] = -5;
                else
                    u[1, i] = 5;

                u[0, i] = i + 1;
                y[0] = x1;
                y[1] = x2;
                y[2] = x3;
                y[3] = x4;
                dataQueue0.Enqueue(u[1, i]);

            }
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[0].Color = Color.Blue;
            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart2.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
            }
            for (int i = 0; i < 60; i++)
            {
                dataQueue0.Dequeue();
            }


            Matrix Z = new double[60, 1];
            Matrix q = new double[4, 4];
            Matrix p0 = new double[4, 4];
            Matrix c2 = new double[4, 60];
            Matrix e2 = new double[4, 60];
            double E = 0.000000005;
            Z[1, 0] = 0; Z[0, 0] = 0;

            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (k == j)
                    { q[k, j] = 1; }
                    else
                        q[k, j] = 0;
                }
            }

            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (j == 0)
                    { c2[k, j] = 0.001; }
                    else
                        c2[k, j] = 0;
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int j = 0; j < 60; j++)
                {
                    e2[k, j] = 0;
                }
            }
            p0 = 1000 * q;

            for (int k = 2; k < 60; k++)
            {
                Z[k, 0] = -a * Z[k - 1, 0] - b * Z[k - 2, 0] + c * u[1, k - 1] + d * u[1, k - 2] + v[0, k - 2];
            }

            Matrix h1 = new double[4, 1];
            Matrix k1 = new double[4, 1];
            Matrix c1 = new double[4, 1];
            Matrix p1 = new double[4, 1];
            Matrix cc = new double[4, 1] { { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 } };
            Matrix e1 = new double[4, 1];
            Matrix n = new double[1, 1];
            Matrix m = new double[1, 1];
            int l = 1;
            double h;

            for (int k = 2; k < 60; k++)
            {
                h1[0, 0] = -Z[k - 1, 0]; h1[1, 0] = -Z[k - 2, 0]; h1[2, 0] = u[1, k - 1]; h1[3, 0] = u[1, k - 2];
                k1 = p0 * h1 * ((h1.Transpose() * p0 * h1 + 1 * l).Inverse());
                n = h1.Transpose() * cc;
                h = Z[k, 0] - n[0, 0];
                m[0, 0] = h;
                c1 = cc + k1 * m;
                p1 = 1 / l * (q - k1 * h1.Transpose()) * p0;
                for (int i = 0; i < 4; i++)
                {
                    e1[i, 0] = (c1[i, 0] - cc[i, 0]) / cc[i, 0];
                    e2[i, k - 2] = e1[i, 0];
                    c2[i, k - 1] = c1[i, 0];
                }
                cc = c1;
                p0 = p1;
                if ((System.Math.Sqrt(e1[0, 0] * e1[0, 0] + e1[1, 0] * e1[1, 0] + e1[2, 0] * e1[2, 0] + e1[3, 0] * e1[3, 0])) <= E)
                {
                    break;
                }
            }       
            Matrix a1 = new double[60, 1];
            Matrix a2 = new double[60, 1];
            Matrix b1 = new double[60, 1];
            Matrix b2 = new double[60, 1];
            Matrix ea1 = new double[60, 1];
            Matrix ea2 = new double[60, 1];
            Matrix eb1 = new double[60, 1];
            Matrix eb2 = new double[60, 1];
            for (int i = 0; i < 59; i++)
            {
                a1[i, 0] = c2[0, i];
                a2[i, 0] = c2[1, i];
                b1[i, 0] = c2[2, i];
                b2[i, 0] = c2[3, i];
                ea1[i, 0] = e2[0, i];
                ea2[i, 0] = e2[1, i];
                eb1[i, 0] = e2[2, i];
                eb2[i, 0] = e2[3, i];

            }    
            textBox5.Text = a1[50,0].ToString("0.000");
            textBox6.Text = a2[50,0].ToString("0.000");
            textBox7.Text = b1[50,0].ToString("0.000");
            textBox8.Text = b2[50,0].ToString("0.000");


            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Green;
            this.chart1.Series[2].Color = Color.Blue;
            this.chart1.Series[3].Color = Color.Yellow;
            for (int i = 0; i < 59; i++)
            {
                dataQueue0.Enqueue(a1[i,0]);
                dataQueue1.Enqueue(a2[i, 0]);
                dataQueue2.Enqueue(b1[i, 0]);
                dataQueue3.Enqueue(b2[i, 0]);
            }
           
            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
                this.chart1.Series[1].Points.AddXY((i + 1), dataQueue1.ElementAt(i));
                this.chart1.Series[2].Points.AddXY((i + 1), dataQueue2.ElementAt(i));
                this.chart1.Series[3].Points.AddXY((i + 1), dataQueue3.ElementAt(i));
            }
            for (int i = 0; i < 59; i++)
            {
                dataQueue0.Dequeue();
                dataQueue1.Dequeue();
                dataQueue2.Dequeue();
                dataQueue3.Dequeue();
            }

        }
        //递推阻尼最小二乘法

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string z1, z2, z3, z4;
            z1 = textBox1.Text;
            z2 = textBox2.Text;
            z3 = textBox3.Text;
            z4 = textBox4.Text;
            a = Convert.ToDouble(z1);
            b = Convert.ToDouble(z2);
            c = Convert.ToDouble(z3);
            d = Convert.ToDouble(z4);

            double[,] u = new double[1, 1000];
            Matrix y = new double[1, 1000];
            double[,] time = new double[1, 1000];
            double u_1 = 0, u_2 = 0, y_1 = 0, y_2 = 0;

            Matrix v = new double[1, 1000];
            Matrix v3 = new double[1, 1000];
            double A = Math.Pow(5, 17), x0 = 1, G = Math.Pow(2, 42), y2 = 0, y1 = 0, v1 = 0, v0 = 0;
            for (int i = 0; i < 1000; i++)
            {
                y2 = A * x0;
                y1 = y2 % G;
                v1 = y1 / G;
                v3[0,i]= v[0, i] = v1;
                x0 = y1;
                v0 = v1;
            }


            for (int i = 0; i < 1000; i++)
            {
                time[0, i] = i;
                u[0, i] = v3[0, i];
                double kesi = 0.5 * v[0, i];
                y[0, i] = -a * y_1 -b * y_2 + c * u_1 + d * u_2 + kesi;
                u_2 = u_1; u_1 = u[0, i]; y_2 = y_1; y_1 = y[0, i];
                dataQueue0.Enqueue(u[0,i]);
            }
            this.chart2.Series[0].Points.Clear();
            this.chart2.Series[0].Color = Color.Blue;
            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart2.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
            }
            for (int i = 0; i < 1000; i++)
            {
                dataQueue0.Dequeue();
            }


            double beta = 0.95, alfa = 10000, miu = 0.0000001;
            Matrix t = new double[4, 1];
            Matrix t1 = new double[4, 1];
            Matrix t2 = new double[4, 1];
            Matrix g = new double[4, 4];
            Matrix p1 = new double[4, 4];
            Matrix P = new double[4, 4];
            Matrix fai = new double[4, 1];
            for (int i = 0; i < 4; i++)
            {
                t1[i, 0] = t2[i, 0] = 0;
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        g[i, j] = 1;
                    }
                    else
                        g[i, j] = 0;
                }

            }
            Matrix m = new double[4, 1];
            Matrix a0 = new double[1000, 1];
            Matrix a1 = new double[1000, 1];
            Matrix b0 = new double[1000, 1];
            Matrix b1 = new double[1000, 1];
            p1 = alfa * g;
            for (int i = 2; i < 1000; i++)
            {
                time[0, i] = i;
                fai[0, 0] = -y[0, i - 1]; fai[1, 0] = -y[0, i - 2]; fai[2, 0] = u[0, i - 1]; fai[3, 0] = u[0, i - 2];
                try
                {
                    P = (miu * g - beta * miu * g + beta * p1.Inverse() + fai * fai.Transpose()).Inverse();
                }
                catch
                {

                }
                
                m = fai.Transpose() * t1;
                t = t1 + beta * miu * P * (t1 - t2) + P * fai * (y[0, i] - m[0, 0]);
                a0[i - 2, 0] = t[0, 0]; a1[i - 2, 0] = t[1, 0]; b0[i - 2, 0] = t[2, 0]; b1[i - 2, 0] = t[3, 0];
                t2 = t1;
                t1 = t;
                p1 = P;
            }
            textBox5.Text = a0[900, 0].ToString("0.000");
            textBox6.Text = a1[900, 0].ToString("0.000");
            textBox7.Text = b0[900, 0].ToString("0.000");
            textBox8.Text = b1[900, 0].ToString("0.000");

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Green;
            this.chart1.Series[2].Color = Color.Blue;
            this.chart1.Series[3].Color = Color.Yellow;

            for (int i = 0; i < 999; i++)
            {
                dataQueue0.Enqueue(a0[i, 0]);
                dataQueue1.Enqueue(a1[i, 0]);
                dataQueue2.Enqueue(b0[i, 0]);
                dataQueue3.Enqueue(b1[i, 0]);
            }
           
            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
                this.chart1.Series[1].Points.AddXY((i + 1), dataQueue1.ElementAt(i));
                this.chart1.Series[2].Points.AddXY((i + 1), dataQueue2.ElementAt(i));
                this.chart1.Series[3].Points.AddXY((i + 1), dataQueue3.ElementAt(i));
            }
            for (int i = 0; i < 999; i++)
            {
                dataQueue0.Dequeue();
                dataQueue1.Dequeue();
                dataQueue2.Dequeue();
                dataQueue3.Dequeue();
            }
        }
        //增广最小二乘算法
        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string z1, z2, z3, z4;
            z1 = textBox1.Text;
            z2 = textBox2.Text;
            z3 = textBox3.Text;
            z4 = textBox4.Text;
            a = Convert.ToDouble(z1);
            b = Convert.ToDouble(z2);
            c = Convert.ToDouble(z3);
            d = Convert.ToDouble(z4);

            Matrix v = new double[1, 60];
            double A = Math.Pow(5, 17), x0 = 1, G = Math.Pow(2, 42), y2 = 0, y1 = 0, v1 = 0, v0 = 0;
            for (int i = 0; i < 60; i++)
            {
                y2 = A * x0;
                y1 = y2 % G;
                v1 = y1 / G;
                v[0, i] = v1;
                x0 = y1;
                v0 = v1;
            }

            int[,] u = new int[2, 60];
            int x1, x2, x3, x4;
            int[] y = new int[4] { 1, 1, 1, 0 };
            for (int i = 0; i < 60; i++)
            {
                x1 = y[2] ^ y[3];
                x2 = y[0];
                x3 = y[1];
                x4 = y[2];

                if (y[3] > 0.5)
                    u[1, i] = -5;
                else
                    u[1, i] = 5;

                u[0, i] = i + 1;
                y[0] = x1;
                y[1] = x2;
                y[2] = x3;
                y[3] = x4;
            }

            Matrix Z = new double[60, 1];
            Matrix q = new double[7, 7];
            Matrix p0 = new double[7, 7];
            Matrix p1 = new double[7, 7];
            Matrix t = new double[7, 60];
            Matrix t1 = new double[7, 1];
            Matrix h1 = new double[7, 1];
            Matrix g = new double[1, 1];
            Matrix g1 = new double[1, 1];
            Matrix k1 = new double[7, 1];            
            Matrix m = new double[1, 1];
            Matrix m1 = new double[1, 1];
            Matrix d1 = new double[1, 1];
            Matrix t0 = new double[7, 1] { { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 } };
            Z[1, 0] = 0; Z[0, 0] = 0;

            for (int k = 0; k < 7; k++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (k == j)
                    { q[k, j] = 1; }
                    else
                        q[k, j] = 0;
                }
            }

            for (int k = 0; k < 7; k++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (j == 0)
                    { t[k, j] = 0.001; }
                    else
                        t[k, j] = 0;
                }
            }

            p0 = 10000 * q;
            for (int k = 2; k < 60; k++)
            {
                Z[k, 0] = -a * Z[k - 1, 0] - b * Z[k - 2, 0] + c * u[1, k - 1] + d * u[1, k - 2] + 1.2 * v[0, k] - v[0, k - 1] - 0.2 * v[0, k - 2];
                h1[0, 0] = -Z[k - 1, 0]; h1[1, 0] = -Z[k - 2, 0]; h1[2, 0] = u[1, k - 1]; h1[3, 0] = u[1, k - 2]; h1[4, 0] = v[0, k - 2]; h1[5, 0] = v[0, k - 1]; h1[6, 0] = v[0, k];
                g = (h1.Transpose()) * p0 * h1 + 1;
                g1 = g.Inverse();
                k1 = p0 * h1 * g1;
                m = h1.Transpose() * t0;
                d1[0, 0] = Z[k, 0] - m[0, 0];
                t1 = t0 + k1 * d1;
                t0 = t1;
                for (int i = 0; i < 7; i++)
                {
                    t[i, k - 1] = t1[i, 0];
                }
                m1 = h1.Transpose() * p0 * h1;
                p1 = p0 - k1 * k1.Transpose() * (m1[0, 0] + 1);
                p0 = p1;
            }
            Matrix a1 = new double[59, 1];
            Matrix a2 = new double[59, 1];
            Matrix b1 = new double[59, 1];
            Matrix b2 = new double[59, 1];
            Matrix c1 = new double[59, 1];
            Matrix c2 = new double[59, 1];
            Matrix c3 = new double[59, 1];
            for (int i = 0; i < 59; i++)
            {
                a1[i, 0] = t[0, i];
                a2[i, 0] = t[1, i];
                b1[i, 0] = t[2, i];
                b2[i, 0] = t[3, i];
                c1[i, 0] = t[4, i];
                c2[i, 0] = t[5, i];
                c3[i, 0] = t[6, i];
            }
            textBox5.Text = a1[50, 0].ToString("0.000");
            textBox6.Text = a2[50, 0].ToString("0.000");
            textBox7.Text = b1[50, 0].ToString("0.000");
            textBox8.Text = b2[50, 0].ToString("0.000");

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Green;
            this.chart1.Series[2].Color = Color.Blue;
            this.chart1.Series[3].Color = Color.Yellow;
           
            for (int i = 0; i < 59; i++)
            {
                dataQueue0.Enqueue(a1[i, 0]);
                dataQueue1.Enqueue(a2[i, 0]);
                dataQueue2.Enqueue(b1[i, 0]);
                dataQueue3.Enqueue(b2[i, 0]);
            }

            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
                this.chart1.Series[1].Points.AddXY((i + 1), dataQueue1.ElementAt(i));
                this.chart1.Series[2].Points.AddXY((i + 1), dataQueue2.ElementAt(i));
                this.chart1.Series[3].Points.AddXY((i + 1), dataQueue3.ElementAt(i));
            }
            for (int i = 0; i < 59; i++)
            {
                dataQueue0.Dequeue();
                dataQueue1.Dequeue();
                dataQueue2.Dequeue();
                dataQueue3.Dequeue();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var frm = new Form4();
            frm.ShowDialog();

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "辨识结构1")
            {

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("辨识结构1");
            comboBox1.Items.Add("辨识结构2");
            comboBox1.Items.Add("辨识结构3");

            chart2.ChartAreas[0].Axes[0].MajorGrid.Enabled = false;
            chart2.ChartAreas[0].Axes[1].MajorGrid.Enabled = false;
            chart2.ChartAreas[0].Axes[0].MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart2.ChartAreas[0].Axes[0].MajorGrid.LineColor = Color.Gray;
            chart2.ChartAreas[0].Axes[0].MajorTickMark.Enabled = false;
            chart2.ChartAreas[0].Axes[1].MajorTickMark.Enabled = false;
            chart2.ChartAreas[0].Axes[1].IsInterlaced = false;
            chart2.ChartAreas[0].Axes[0].LabelStyle.Format = "#";
            chart2.ChartAreas[0].Axes[1].MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chart2.ChartAreas[0].Axes[1].MajorGrid.LineColor = Color.Gray;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            string z1, z2, z3, z4;
            z1 = textBox1.Text;
            z2 = textBox2.Text;
            z3 = textBox3.Text;
            z4 = textBox4.Text;
            a = Convert.ToDouble(z1);
            b = Convert.ToDouble(z2);
            c = Convert.ToDouble(z3);
            d = Convert.ToDouble(z4);

            //M序列作为输入
            int[,] u = new int[2, 1000];
            int x1, x2, x3, x4;
            int[] y = new int[4] { 1, 1, 1, 0 };
            for (int i = 0; i < 1000; i++)
            {
                x1 = y[2] ^ y[3];
                x2 = y[0];
                x3 = y[1];
                x4 = y[2];
                if (y[3] > 0.5)
                    u[1, i] = -1;
                else
                    u[1, i] = 1;

                u[0, i] = i + 1;
                y[0] = x1;
                y[1] = x2;
                y[2] = x3;
                y[3] = x4;
            }

            Matrix v = new double[1, 1000];
            double A = Math.Pow(5, 17), x0 = 1, G = Math.Pow(2, 42), y2 = 0, y1 = 0, v1 = 0, v0 = 0;
            for (int i = 0; i < 60; i++)
            {
                y2 = A * x0;
                y1 = y2 % G;
                v1 = y1 / G;
                v[0, i] = v1;
                x0 = y1;
                v0 = v1;
            }

            Matrix Z = new double[1000, 1];
            Z[1, 0] = 0; Z[0, 0] = 0;
            for (int k = 2; k < 1000; k++)
            {
                Z[k, 0] = -a * Z[k - 1, 0] - b * Z[k - 2, 0] + c * u[1, k-1] + d * u[1, k-2] + v[0, k] - 0.8 * v[0, k - 1] + 0.3 * v[0, k - 2];
            }

            //初始化
            Matrix t0 = new double[6, 1] { { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 }, { 0.001 } };
            Matrix a0 = new double[1000, 1];
            Matrix a1 = new double[1000, 1];
            Matrix b0 = new double[1000, 1];
            Matrix b1 = new double[1000, 1];
            Matrix e1 = new double[1000, 1];
            Matrix e2 = new double[1000, 1];
            Matrix e3 = new double[1000, 1];
            Matrix e4 = new double[1000, 1];
            Matrix e5 = new double[1000, 1];
            Matrix e6 = new double[1000, 1];
            Matrix a_hat = new double[2, 1];
            Matrix b_hat = new double[2, 1];
            Matrix c_hat = new double[2, 1];
            Matrix p0 = new double[6, 6];
            Matrix yf = new double[2, 1];
            Matrix uf = new double[2, 1];
            Matrix vf = new double[2, 1];
            Matrix fai0 = new double[6, 1];
            Matrix _e = new double[1000, 1];

            a0[0, 0] = t0[0, 0];
            a0[1, 0] = t0[0, 0];
            a1[0, 0] = t0[1, 0];
            a1[1, 0] = t0[1, 0];
            b0[0, 0] = t0[2, 0];
            b0[1, 0] = t0[2, 0];
            b1[0, 0] = t0[3, 0];
            b1[1, 0] = t0[3, 0];
            e1[0, 0] = a - t0[0, 0];
            e2[0, 0] = b - t0[1, 0];
            e3[0, 0] = c - t0[2, 0];
            e4[0, 0] = d - t0[3, 0];
            e5[0, 0] = -0.8 - t0[4, 0];
            e6[0, 0] = 0.3 - t0[5, 0];

            a_hat[0, 0] = t0[0, 0];
            a_hat[1, 0] = t0[1, 0];
            b_hat[0, 0] = t0[2, 0];
            b_hat[1, 0] = t0[3, 0];
            c_hat[0, 0] = t0[4, 0];
            c_hat[1, 0] = t0[5, 0];

            for (int k = 0; k < 6; k++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (k == j)
                    { p0[k, j] = 1; }
                    else
                        p0[k, j] = 0;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                yf[i, 0] = 0.1;
                uf[i, 0] = 0.1;
                vf[i, 0] = 0.1;
                fai0[i, 0] = -yf[i, 0];
                fai0[2 + i, 0] = uf[i, 0];
                fai0[4 + i, 0] = vf[i, 0];
            }
            _e[0, 0] = 1;
            _e[1, 0] = 1;

            //递推算法
            Matrix C = new double[6, 6];
            Matrix Q = new double[6, 1] { { 0 }, { 0 }, { 0 }, { 0 }, { 0 }, { 0 } };
            Matrix fai = new double[6, 1];
            Matrix K = new double[6, 1];
            Matrix t = new double[6, 6];
            Matrix P = new double[6, 6];
            Matrix theta = new double[6, 1];
            for (int k = 0; k < 6; k++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (k == j)
                    { t[k, j] = 1; }
                    else
                        t[k, j] = 0;
                }
            }
            for (int k = 0; k < 6; k++)
            {
                for (int j = 0; j < 6; j++)
                {
                    C[k, j] = 0;
                }
            }
            for (int i = 2; i < 1000; i++)
            {
                Matrix pusai = new double[6, 1] { { -Z[i - 1, 0] }, { -Z[i - 2, 0] }, { u[1, i-1] }, { u[1, i-2] }, { _e[i - 1, 0] }, { _e[i - 2, 0] } };
                Q[0, 0] = -Z[i - 1, 0];
                Q[2, 0] = u[1, i - 1];
                Q[4, 0] = _e[i - 1, 0];
                for (int j = 0; j < 2; j++)
                {
                    C[0, j] = -c_hat[j, 0];
                    C[2, 2 + j] = -c_hat[j, 0];
                    C[4, 4 + j] = -c_hat[j, 0];
                    if (j > 0)
                    {
                        C[j, j - 1] = 1;
                        C[2 + j, 1 + j] = 1;
                        C[4 + j, 3 + j] = 1;
                    }
                }
                fai = C * fai0 + Q;
                K = p0 * fai * (((fai.Transpose()) * p0 * fai + 1).Inverse());
                P = (t - K * (fai.Transpose())) * p0;

                _e[i,0] = Z[i, 0] - ((pusai.Transpose()) * t0)[0, 0];
                theta = t0 + K * _e[i,0];

                p0 = P;
                t0 = theta;
                fai0 = fai;
                a_hat[0, 0] = theta[0, 0];
                a0[i, 0] = a_hat[0, 0];
                a_hat[1, 0] = theta[1, 0];
                a1[i, 0] = a_hat[1, 0];
                b_hat[0, 0] = theta[2, 0];
                b0[i, 0] = b_hat[0, 0];
                b_hat[1, 0] = theta[3, 0];
                b1[i, 0] = b_hat[1, 0];
                c_hat[0, 0] = theta[4, 0];
                c_hat[1, 0] = theta[5, 0];
                e1[i, 0] = a - a_hat[0, 0];
                e2[i, 0] = b - a_hat[1, 0];
                e3[i, 0] = c - b_hat[0, 0];
                e4[i, 0] = d - b_hat[1, 0];
                e5[i, 0] = -0.8 - c_hat[0, 0];
                e6[i, 0] = 0.3 - c_hat[1, 0];
            }
            textBox5.Text = a0[900, 0].ToString("0.000");
            textBox6.Text = a1[900, 0].ToString("0.000");
            textBox7.Text = b0[900, 0].ToString("0.000");
            textBox8.Text = b1[900, 0].ToString("0.000");

            this.chart1.Series[0].Points.Clear();
            this.chart1.Series[1].Points.Clear();
            this.chart1.Series[2].Points.Clear();
            this.chart1.Series[3].Points.Clear();
            this.chart1.Series[0].Color = Color.Red;
            this.chart1.Series[1].Color = Color.Green;
            this.chart1.Series[2].Color = Color.Blue;
            this.chart1.Series[3].Color = Color.Yellow;

            for (int i = 0; i < 999; i++)
            {
                dataQueue0.Enqueue(a0[i, 0]);
                dataQueue1.Enqueue(a1[i, 0]);
                dataQueue2.Enqueue(b0[i, 0]);
                dataQueue3.Enqueue(b1[i, 0]);
            }

            for (int i = 0; i < dataQueue0.Count; i++)
            {
                this.chart1.Series[0].Points.AddXY((i + 1), dataQueue0.ElementAt(i));
                this.chart1.Series[1].Points.AddXY((i + 1), dataQueue1.ElementAt(i));
                this.chart1.Series[2].Points.AddXY((i + 1), dataQueue2.ElementAt(i));
                this.chart1.Series[3].Points.AddXY((i + 1), dataQueue3.ElementAt(i));
            }
            for (int i = 0; i < 999; i++)
            {
                dataQueue0.Dequeue();
                dataQueue1.Dequeue();
                dataQueue2.Dequeue();
                dataQueue3.Dequeue();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBoxSender = (TextBox)sender;

            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {//输入的值是否在合理的范围内，如果不是，则标记为处理过，程序不在处理，为true时表示此次输入无效              
                e.Handled = true;
            }
            //小数点的处理。
            if ((int)e.KeyChar == 46)
            { //小数点               
                if (textBoxSender.Text.Length <= 0)
                { //小数点不能在第一位
                    e.Handled = true;
                }
                else
                {
                    float fOriginalAndInput;
                    float fOriginal;
                    bool bCovOriginalAndInput = false, bCovOriginal = false;
                    bCovOriginal = float.TryParse(textBoxSender.Text, out fOriginal);
                    bCovOriginalAndInput = float.TryParse(textBoxSender.Text + e.KeyChar.ToString(), out fOriginalAndInput);
                    if (bCovOriginalAndInput == false)
                    { //输入小数点时，如果输入框内容加上输入的内容不是浮点数
                        if (bCovOriginal == true)
                        {//输入框内容是浮点数，则此次不输入，即限制一个小数输入
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                    }
                }
            }
        }
    }
}

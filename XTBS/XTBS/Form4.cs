using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.Data.Matlab;

namespace XTBS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            

        }

        private void txtku_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }

        private void txtt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntlpi_Click(object sender, EventArgs e)
        {
            string x, y, z, ku, wu, P, I, D;
            double p, h, a, ku1, wu1, P1, I1, D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
            // ku1 = Convert.ToDouble(ku);
            // wu1 = Convert.ToDouble(wu);
            // P1 = Convert.ToDouble(P);
            // I1 = Convert.ToDouble(I);
            // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 3.22;
            I1 = 2.2/wu1;
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = "0";
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");
        }

        private void btnzn_Click(object sender, EventArgs e)
        {
            string x, y, z,ku,wu,P,I,D;
            double p, h, a,ku1,wu1,P1,I1,D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
           // ku1 = Convert.ToDouble(ku);
           // wu1 = Convert.ToDouble(wu);
           // P1 = Convert.ToDouble(P);
           // I1 = Convert.ToDouble(I);
           // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 1.7;
            I1 = 1 / (2 * wu1);
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = D1.ToString("0.000");
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");











        }

        private void btnsdct_Click(object sender, EventArgs e)
        {
            string x, y, z, ku, wu, P, I, D;
            double p, h, a, ku1, wu1, P1, I1, D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
            // ku1 = Convert.ToDouble(ku);
            // wu1 = Convert.ToDouble(wu);
            // P1 = Convert.ToDouble(P);
            // I1 = Convert.ToDouble(I);
            // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 3;
            I1 = 1 / (2 * wu1);
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = D1.ToString("0.000");
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");
        }

        private void btnwct_Click(object sender, EventArgs e)
        {
            string x, y, z, ku, wu, P, I, D;
            double p, h, a, ku1, wu1, P1, I1, D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
            // ku1 = Convert.ToDouble(ku);
            // wu1 = Convert.ToDouble(wu);
            // P1 = Convert.ToDouble(P);
            // I1 = Convert.ToDouble(I);
            // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 5;
            I1 = 1 / (2 * wu1);
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = D1.ToString("0.000");
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");
        }

        private void btnznpi_Click(object sender, EventArgs e)
        {
            string x, y, z, ku, wu, P, I, D;
            double p, h, a, ku1, wu1, P1, I1, D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
            // ku1 = Convert.ToDouble(ku);
            // wu1 = Convert.ToDouble(wu);
            // P1 = Convert.ToDouble(P);
            // I1 = Convert.ToDouble(I);
            // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 2.2;
            I1 = 1 / (1.2 * wu1);
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = "0";
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");
        }

        private void btnsypi_Click(object sender, EventArgs e)
        {
            string x, y, z, ku, wu, P, I, D;
            double p, h, a, ku1, wu1, P1, I1, D1;
            x = txtt.Text;
            y = txth.Text;
            z = txta.Text;
            ku = txtku.Text;
            wu = txtwu.Text;
            P = txtP.Text;
            I = txtI.Text;
            D = txtD.Text;


            p = Convert.ToDouble(x);
            h = Convert.ToDouble(y);
            a = Convert.ToDouble(z);
            // ku1 = Convert.ToDouble(ku);
            // wu1 = Convert.ToDouble(wu);
            // P1 = Convert.ToDouble(P);
            // I1 = Convert.ToDouble(I);
            // D1 = Convert.ToDouble(D);

            ku1 = 4 * h / (3.1415 * a);
            wu1 = 2 * 3.1415 / p;
            P1 = ku1 / 3;
            I1 = 2 /  wu1;
            D1 = 1 / (8 * wu1);

            txtP.Text = P1.ToString("0.000");
            txtI.Text = I1.ToString("0.000");
            txtD.Text = "0";
            txtku.Text = ku1.ToString("0.000");
            txtwu.Text = wu1.ToString("0.000");

        }

        private void 帮助LToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("201b版权所有" );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i=0 ;
            double x,h,a,wu;
            Matrix<double> data = MatlabReader.Read<double>("data.mat");
            Matrix<double> time = MatlabReader.Read<double>("time.mat");
            Matrix<double> kp = MatlabReader.Read<double>("kp.mat");

            while (data[i, 0] == 0 )
            {
                i += 1;
            }
            txtdelay.Text = time[i, 0].ToString();//计算延时
            
            txtkp.Text = kp[10, 0].ToString();
            x = Convert.ToDouble(txtkp.Text);
            h = Convert.ToDouble(txth.Text);
            a = Convert.ToDouble(txta.Text);
            wu = Convert.ToDouble(txtwu.Text);
            txttime.Text = (System.Math.Sqrt((x*4*h/3.1415/a)* (x * 4 * h / 3.1415 / a)-1)/wu).ToString();//计算时间常数
            
       
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

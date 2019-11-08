using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;
namespace XTBS
{
    public partial class Form5 : Form
    {
        ////(1).声明结构,只记录窗体和其控件的初始位置和大小。  
        //public struct controlRect
        //{
        //    public int Left;
        //    public int Top;
        //    public int Width;
        //    public int Height;
        //}
        //public List<controlRect> oldCtrl;

        //public void controllInitializeSize(Form mForm)
        //{
        //    // if (ctrl_first == 0)  
        //    {
        //        //  ctrl_first = 1;  
        //        oldCtrl = new List<controlRect>();
        //        controlRect cR;
        //        cR.Left = mForm.Left; cR.Top = mForm.Top; cR.Width = mForm.Width; cR.Height = mForm.Height;
        //        oldCtrl.Add(cR);
        //        foreach (Control c in mForm.Controls)
        //        {
        //            controlRect objCtrl;
        //            objCtrl.Left = c.Left; objCtrl.Top = c.Top; objCtrl.Width = c.Width; objCtrl.Height = c.Height;
        //            oldCtrl.Add(objCtrl);
        //        }
        //    }
        //    // this.WindowState = (System.Windows.Forms.FormWindowState)(2);//记录完控件的初始位置和大小后，再最大化  
        //    //0 - Normalize , 1 - Minimize,2- Maximize  
        //}
        //public void controlAutoSize(Form mForm)
        //{
        //    //int wLeft0 = oldCtrl[0].Left; ;//窗体最初的位置  
        //    //int wTop0 = oldCtrl[0].Top;  
        //    ////int wLeft1 = this.Left;//窗体当前的位置  
        //    //int wTop1 = this.Top;  
        //    float wScale = (float)mForm.Width / (float)oldCtrl[0].Width;//新旧窗体之间的比例，与最早的旧窗体  
        //    float hScale = (float)mForm.Height / (float)oldCtrl[0].Height;//.Height;  
        //    int ctrLeft0, ctrTop0, ctrWidth0, ctrHeight0;
        //    int ctrlNo = 1;//第1个是窗体自身的 Left,Top,Width,Height，所以窗体控件从ctrlNo=1开始  
        //    foreach (Control c in mForm.Controls)
        //    {
        //        ctrLeft0 = oldCtrl[ctrlNo].Left;
        //        ctrTop0 = oldCtrl[ctrlNo].Top;
        //        ctrWidth0 = oldCtrl[ctrlNo].Width;
        //        ctrHeight0 = oldCtrl[ctrlNo].Height;
        //        //c.Left = (int)((ctrLeft0 - wLeft0) * wScale) + wLeft1;//新旧控件之间的线性比例  
        //        //c.Top = (int)((ctrTop0 - wTop0) * h) + wTop1;  
        //        c.Left = (int)((ctrLeft0) * wScale);//新旧控件之间的线性比例。控件位置只相对于窗体，所以不能加 + wLeft1  
        //        c.Top = (int)((ctrTop0) * hScale);//  
        //        c.Width = (int)(ctrWidth0 * wScale);//只与最初的大小相关，所以不能与现在的宽度相乘 (int)(c.Width * w);  
        //        c.Height = (int)(ctrHeight0 * hScale);//  
        //        ctrlNo += 1;
        //    }
        //}
        private Queue<double> dataQueuea = new Queue<double>();
        private Queue<double> dataQueueb = new Queue<double>();
        private Queue<double> dataQueuec = new Queue<double>();
        private Queue<double> dataQueued = new Queue<double>();
        private Queue<double> dataQueuet = new Queue<double>();
        private Queue<double> dataQueueu = new Queue<double>();
        public Form5()
        {
            InitializeComponent();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.skinEngine1.SkinFile = Application.StartupPath + "//Silver.ssk";

        }
        private Double[] model(double step, double u)
        {
            Double[] state = new double[6];

            double C_PA = 75.31;
            double C_PB = 167.36;
            double C_PC = 217.57;
            double C_PD = 334.73;
            double MW_A = 30;
            double MW_B = 100;
            double MW_C = 130;
            double MW_D = 160;
            double H1 = -41840;
            double H2 = -25105;
            double k_11 = 20.9057;
            double k_12 = 10000;
            double k_21 = 38.9057;
            double k_22 = 17000;
            double raw = 1000;
            double raw_j = 1000;
            double U = 0.6807;
            double C_pj = 1.8828;
            double V_j = 0.6917;
            double r = 0.5;
            double F_j = 0.0058;

            double M_A = Convert.ToDouble(textBox7.Text);
            double M_B = Convert.ToDouble(textBox8.Text);
            double M_C = Convert.ToDouble(textBox9.Text);
            double M_D = Convert.ToDouble(textBox10.Text);
            double T_r = Convert.ToDouble(textBox5.Text);
            double T_j = Convert.ToDouble(textBox6.Text);
            textBox12.Text = textBox6.Text;

            //textBox7.Text = textBox1.Text;
            //textBox8.Text = textBox2.Text;
            //textBox9.Text = textBox3.Text;
            //textBox10.Text = textBox4.Text;



            double k1 = Math.Exp(k_11 - k_12 / (T_r + 273.15));
            double k2 = Math.Exp(k_21 - k_22 / (T_r + 273.15));
            double W = MW_A * M_A + MW_B * M_B + MW_C * M_C + MW_D * M_D;
            double M_r = M_A + M_B + M_C + M_D;
            double C_pr = (C_PA * M_A + C_PB * M_B + C_PC * M_C + C_PD * M_D) / M_r;
            double Q_r = -H1 * k1 * M_A * M_B - H2 * k2 * M_A * M_C;
            double A = 2 * W / (raw * r);
            double Q_j = U * A * (T_j - T_r);

            double dM_A = -k1 * M_A * M_B - k2 * M_A * M_C;
            double dM_B = -k1 * M_A * M_B;
            double dM_C = k1 * M_A * M_B - k2 * M_A * M_C;
            double dM_D = k2 * M_A * M_C;
            double dT_r = (Q_r + Q_j) / (M_r * C_pr);
            double dT_j = (F_j * raw_j * C_pj * (u - T_r) - Q_j) / (V_j * raw_j * C_pj);
            state[0] = M_A + dM_A * step;
            state[1] = M_B + dM_B * step;
            state[2] = M_C + dM_C * step;
            state[3] = M_D + dM_D * step;
            state[4] = T_r + dT_r * step;
            state[5] = T_j + dT_j * step;
            textBox7.Text = state[0].ToString();
            textBox8.Text = state[1].ToString();
            textBox9.Text = state[2].ToString();
            textBox10.Text = state[3].ToString();
            textBox5.Text = state[4].ToString();
            textBox6.Text = state[5].ToString();
            Application.DoEvents();
            return state;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Boolean isContinue = false;//是否停止
        Boolean isDraw = false;//是否作图
        private void button1_Click(object sender, EventArgs e)
        {
            //Double[,] state_all = new Double[10000, 6];

            //for(int i=0; i<100; i++)
            //{
            //    state_all[i, 0] = model(0.1, 60)[0];
            //    state_all[i, 1] = model(0.1, 60)[1];
            //    state_all[i, 2] = model(0.1, 60)[2];
            //    state_all[i, 3] = model(0.1, 60)[3];
            //    state_all[i, 4] = model(0.1, 60)[4];
            //    state_all[i, 5] = model(0.1, 60)[5];
            //}
            while (model(0.1, 60)[0] > 0.1)
            {
                model(0.1, 60);
                if (isContinue == true)
                {
                    isContinue = false;
                    break;
                }

            }
            //for(int i = 0; i < 500; i++)
            //{

            //}



        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "12";
            textBox2.Text = "12";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "20";
            textBox6.Text = "20";
            textBox7.Text = textBox1.Text;
            textBox8.Text = textBox2.Text;
            textBox9.Text = textBox3.Text;
            textBox10.Text = textBox4.Text;
            chart1.Hide();
            chart2.Hide();
            chart3.Hide();
            chart4.Hide();
            chart5.Hide();
            chart6.Hide();
            //asc.controllInitializeSize(this);
            //string query = "select * from model_basef order by id desc limit 1";
            //MySqlConnection myConnection = new MySqlConnection("server=192.168.203.165;user id=root;password=Ecust-201b;database=model");
            //MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            //myConnection.Open();
            //myCommand.ExecuteNonQuery();
            //MySqlDataReader myDataReader = myCommand.ExecuteReader();
            ////string bookres = "";
            ////while (myDataReader.Read() == true)
            ////{
            ////    bookres += myDataReader["id"];
            ////}
            //while(myDataReader.Read() == true)
            //{

            //    textBox11.Text = myDataReader["id"].ToString();
            //    Application.DoEvents();

            //}

            //myDataReader.Close();
            //myConnection.Close();
        }
        //public void getdata(object source, System.Timers.ElapsedEventArgs e)
        public void getdata()
        {
            string query = "select * from model_basef order by id desc limit 1";
            MySqlConnection myConnection = new MySqlConnection("server=192.168.203.165;user id=root;password=Ecust-201b;database=model");
            MySqlCommand myCommand = new MySqlCommand(query, myConnection);
            myConnection.Open();
            myCommand.ExecuteNonQuery();
            MySqlDataReader myDataReader = myCommand.ExecuteReader();
            //string bookres = "";
            //while (myDataReader.Read() == true)
            //{
            //    bookres += myDataReader["id"];
            //}
            while (myDataReader.Read() == true)
            {
                textBox7.Text = myDataReader["a_quantity"].ToString();
                textBox8.Text = myDataReader["b_quantity"].ToString();
                textBox9.Text = myDataReader["c_quantity"].ToString();
                textBox10.Text = myDataReader["d_quantity"].ToString();
                textBox12.Text = myDataReader["t2"].ToString();
                textBox11.Text = myDataReader["u"].ToString();
                dataQueuea.Enqueue(Convert.ToDouble(myDataReader["a_quantity"]));
                dataQueueb.Enqueue(Convert.ToDouble(myDataReader["b_quantity"]));
                dataQueuec.Enqueue(Convert.ToDouble(myDataReader["c_quantity"]));
                dataQueued.Enqueue(Convert.ToDouble(myDataReader["d_quantity"]));
                dataQueuet.Enqueue(Convert.ToDouble(myDataReader["t2"]));
                dataQueueu.Enqueue(Convert.ToDouble(myDataReader["u"]));
                Thread.Sleep(100);
                Application.DoEvents();
            }
            myDataReader.Close();
            myConnection.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                getdata();
                if (isContinue == true)
                {
                    isContinue = false;
                    break;
                }
            }
            //System.Timers.Timer t = new System.Timers.Timer(1000);
            //t.Elapsed += new System.Timers.ElapsedEventHandler(getdata);
            //t.AutoReset = true;
            //t.Enabled = true;
            //while (true)
            //{
            //    Thread.Sleep(1000);
            //}
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isContinue = true;
            isDraw = true;
        }

        private void textBox7_MouseHover(object sender, EventArgs e)
        {
            if(isDraw == true)
            {
                chart1.Show();
                this.chart1.Series[0].Points.Clear();
                this.chart1.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueuea.Count; i++)
                {
                    this.chart1.Series[0].Points.AddXY((i + 1), dataQueuea.ElementAt(i));
                }
                while (dataQueuea.Count > 5000)
                {
                    dataQueuea.Dequeue();
                }
            }
            else
            {
                chart1.Hide();
            }


            //private void Form5_MouseDown(object sender, MouseEventArgs e)
            //{
            //    int x = e.X; //相对form窗口的坐标，客户区坐标  
            //    int y = e.Y;
            //    int x1 = Control.MousePosition.X;//相对显示器，屏幕的坐标  
            //    int y1 = Control.MousePosition.Y;
            //}
        }

        private void textBox7_MouseLeave(object sender, EventArgs e)
        {
            chart1.Hide();
        }

        private void textBox8_MouseHover(object sender, EventArgs e)
        {
            if (isDraw == true)
            {
                chart2.Show();
                this.chart2.Series[0].Points.Clear();
                this.chart2.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueueb.Count; i++)
                {
                    this.chart2.Series[0].Points.AddXY((i + 1), dataQueueb.ElementAt(i));
                }
                while (dataQueueb.Count > 5000)
                {
                    dataQueueb.Dequeue();
                }
            }
            else
            {
                chart2.Hide();
            }
        }

        private void textBox8_MouseLeave(object sender, EventArgs e)
        {
            chart2.Hide();
        }
        private void textBox9_MouseHover(object sender, EventArgs e)
        {
            if (isDraw == true)
            {
                chart3.Show();
                this.chart3.Series[0].Points.Clear();
                this.chart3.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueuec.Count; i++)
                {
                    this.chart3.Series[0].Points.AddXY((i + 1), dataQueuec.ElementAt(i));
                }
                while (dataQueuec.Count > 5000)
                {
                    dataQueuec.Dequeue();
                }
            }
            else
            {
                chart3.Hide();
            }
        }

        private void textBox9_MouseLeave(object sender, EventArgs e)
        {
            chart3.Hide();
        }
        private void textBox10_MouseHover(object sender, EventArgs e)
        {
            if (isDraw == true)
            {
                chart4.Show();
                this.chart4.Series[0].Points.Clear();
                this.chart4.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueued.Count; i++)
                {
                    this.chart4.Series[0].Points.AddXY((i + 1), dataQueued.ElementAt(i));
                }
                while (dataQueued.Count > 5000)
                {
                    dataQueued.Dequeue();
                }
            }
            else
            {
                chart4.Hide();
            }
        }

        private void textBox10_MouseLeave(object sender, EventArgs e)
        {
            chart4.Hide();
        }
        private void textBox11_MouseHover(object sender, EventArgs e)
        {
            if (isDraw == true)
            {
                chart5.Show();
                this.chart5.Series[0].Points.Clear();
                this.chart5.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueueu.Count; i++)
                {
                    this.chart5.Series[0].Points.AddXY((i + 1), dataQueueu.ElementAt(i));
                }
                while (dataQueueu.Count > 5000)
                {
                    dataQueueu.Dequeue();
                }
            }
            else
            {
                chart5.Hide();
            }
        }

        private void textBox11_MouseLeave(object sender, EventArgs e)
        {
            chart5.Hide();
        }
        private void textBox12_MouseHover(object sender, EventArgs e)
        {
            if (isDraw == true)
            {
                chart6.Show();
                this.chart6.Series[0].Points.Clear();
                this.chart6.Series[0].Color = Color.Blue;
                for (int i = 0; i < dataQueuet.Count; i++)
                {
                    this.chart6.Series[0].Points.AddXY((i + 1), dataQueuet.ElementAt(i));
                }
                while (dataQueuet.Count > 5000)
                {
                    dataQueuet.Dequeue();
                }
            }
            else
            {
                chart6.Hide();
            }
        }

        private void textBox12_MouseLeave(object sender, EventArgs e)
        {
            chart6.Hide();
        }
    }
}

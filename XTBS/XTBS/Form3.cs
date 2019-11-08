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

namespace XTBS
{
    public partial class Form3 : Form
    {
        private Queue<int> dataQueue = new Queue<int>(15);
        public Form3()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            myTest.S = "abc";


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            myTest.SChanging += new EventHandler(myTest_Changing);
        }
        private test myTest = new test();
        class test
        {
            public EventHandler SChanging;
            string s;
            public string S
            {
                get { return s; }
                set { s = value; SChanging(this, new EventArgs()); }
            }
        }
        private void myTest_Changing(object sender, EventArgs e)
        {
            textBox1.Text = myTest.S;
        }
    }
}
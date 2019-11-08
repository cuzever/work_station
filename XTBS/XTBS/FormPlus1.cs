using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XTBS
{
    public partial class FormPlus1 : Form
    {
        public FormPlus1()
        {
            InitializeComponent();
        }

        private void FormPlus1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("辨识结构1");
            comboBox1.Items.Add("辨识结构2");
            comboBox1.Items.Add("辨识结构3");
            label11.Text = "";
            label12.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "辨识结构1")
            {
                label11.Text = "结构特征1";
            }
            if (comboBox1.Text == "辨识结构2")
            {
                label11.Text = "结构特征2";
            }
            if (comboBox1.Text == "辨识结构3")
            {
                label11.Text = "结构特征3";
            }
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }
    }
}

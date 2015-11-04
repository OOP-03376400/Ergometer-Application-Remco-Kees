using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ErgometerLibrary;
using System.Collections;

namespace ErgometerApplication
{
    public partial class SelectTest : Form
    {
        private ComPort Com;
        private ArrayList tests = new ArrayList();
        private int counter;
        public SelectTest(ComPort com)
        {
            Com = com;
            int[] t1 = { 50, 100, 150, 150, 100, 50 };
            Test test1 = new Test(300,t1,"longTest");
            Test test2 = new Test(60, t1,"shortTest");
            tests.Add(test1);
            tests.Add(test2);
            InitializeComponent();
            listBox_Tests.DataSource = tests;
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Comport.Write(string message);
        }

        private void listBox_Tests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if(listBox_Tests.SelectedIndex >= 0)
            {
                timer1.Start();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Test t =(Test)tests[listBox_Tests.SelectedIndex];
            t.update(counter);
            counter++;
        }
    }
}

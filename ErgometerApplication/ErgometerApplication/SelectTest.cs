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
        private int counter = 0;
        private ClientApplicatie clientApplicatie;

        public SelectTest(ComPort com, ClientApplicatie client)
        {
            Com = com;
            int[] t1 = { 50, 100, 150, 150, 100, 50 };
            int[] t2 = { 100, 200, 300, 400,200,100,50};
            Test test1 = new Test(300,t1,"longTest");
            Test test2 = new Test(60, t1,"shortTest");
            Test test3 = new Test(20, t1, "very Short Test");
            Test test4 = new Test(10, t2, "powerTest");
            tests.Add(test1);
            tests.Add(test2);
            tests.Add(test3);
            tests.Add(test4);
            InitializeComponent();
            listBox_Tests.DataSource = tests;
            timer1.Stop();
            this.clientApplicatie = client;
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
            int power = t.update(counter);
            if(power>-1)
            {
                Com.Write("PW " + power);
            }
            counter++;
            if (counter > t.powerStack.Length*t.timeCounter)
            {
                Form testdialog = new TestDialog(this, clientApplicatie);
                testdialog.BringToFront();
                testdialog.Show();
                testdialog.BringToFront();
                timer1.Stop();
            }
        }
    }
}

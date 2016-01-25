using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErgometerApplication
{
    public partial class TestDialog : Form
    {
        private SelectTest testform;
        private ClientApplicatie clientapp;

        public TestDialog(SelectTest testform, ClientApplicatie client)
        {
            InitializeComponent();
            this.testform = testform;
            this.clientapp = client;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Form olddataform = new OldData(clientapp);
        //    olddataform.Show();
        //    this.Close();
        //}

        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            this.Close();
            clientapp.logout("U bent uitgelogd", Color.Blue);
        }
    }
}

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

namespace ErgometerApplication
{
    public partial class OldData : Form
    {
        private ClientApplicatie clientapp;

        public OldData(ClientApplicatie clientapp)
        {
            InitializeComponent();
            MainClient.SendNetCommand(new NetCommand(NetCommand.RequestType.ALLSESSIONS, MainClient.Session));
            this.clientapp = clientapp;
            timer1.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (MainClient.oldSessionsData != null)
            {
                foreach (Tuple<string, double, int> item in MainClient.oldSessionsData)
                {
                    if (item.Item1 == MainClient.Name)
                    {
                        listBox1.Items.Add(item.Item3);
                    }
                }
            }
            else
            {
                listBox1.Items.Add("No old sessions available");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;

namespace Ping_Test
{
    public partial class Form1 : Form
    {
        List<String> alleAdressen = null;
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            alleAdressen = new List<string>();
            StreamReader sr = new StreamReader(@"H:\Eigene Dateien\C# 2017_2018\Ping-Test\Ping-Test\bin\Debug\ip.txt", Encoding.UTF8);
            while(sr.EndOfStream == false)
            {
                String z = sr.ReadLine();
                alleAdressen.Add(z);
                listBox_adressen.Items.Add(z);
                
            }
        }

        private void button_ping_Click(object sender, EventArgs e)
        {
            send();
               

        }
        public void send()
        {
            try
            {
                Ping Sender = new Ping();
                for (int i = 0; i < alleAdressen.Count; i++)
                {
                    PingReply Result = Sender.Send(alleAdressen[i]);
                    if (Result.Status == IPStatus.Success)
                    {
                        listBox_OK.Items.Add(alleAdressen[i]);
                    }
                    else
                    {
                        listBox_NichtOK.Items.Add(alleAdressen[i]);
                    }
                }
            }
            catch(Exception e)
            {

            }
            
        }
    }
}

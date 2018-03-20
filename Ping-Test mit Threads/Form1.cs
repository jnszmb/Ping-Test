using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading;

namespace Ping_Test_mit_Threads
{
    // HI
    public partial class Form1 : Form
    {
        List<String> alleAdressen = null;
        delegate void SetListBoxCallback(String text);
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            alleAdressen = new List<string>();
            StreamReader sr = new StreamReader(@"H:\Eigene Dateien\C# 2017_2018\Ping-Test\Ping-Test mit Threads\bin\Debug\ip.txt", Encoding.UTF8);
            while (sr.EndOfStream == false)
            {
                String z = sr.ReadLine();
                alleAdressen.Add(z);
                listBox_adressen.Items.Add(z);
            }
        }
        
        private void button_ping_Click(object sender, EventArgs e)
        {
            ThreadStart ts = new ThreadStart(startMethode);
            Thread th = new Thread(ts);
            th.Start();
            
        }

        private void startMethode()
        {
            send();
        }

        private void SetListBoxOK(string v)
        {
            if(listBox_OK.InvokeRequired)
            {
                SetListBoxCallback del = new SetListBoxCallback(SetListBoxOK);
                this.Invoke(del, new object[] { v });
            }
            else
            {
                listBox_OK.Items.Add(v);
            }
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
                        SetListBoxOK(alleAdressen[i]);
                    }
                    else
                    {
                        SetListBoxTextNotOK(alleAdressen[i]);
                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        private void SetListBoxTextNotOK(string v)
        {
            if (listBox_NichtOK.InvokeRequired)
            {
                SetListBoxCallback del2 = new SetListBoxCallback(SetListBoxTextNotOK);
                this.Invoke(del2, new object[] { v });
            }
            else
            {
                listBox_NichtOK.Items.Add(v);
            }
        }
    }
}

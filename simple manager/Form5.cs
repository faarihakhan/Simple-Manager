using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
namespace simple_manager
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            p = new Processes();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Processes p;
        private void timer1_Tick(object sender, EventArgs e)
        {
          //  Form5 obj = new Form5();
            timer1.Stop();
            p.allprocesses(listBox1);
            p.running(listBox2);
            p.notrunningprocess(listBox3);
            timer1.Start();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            //AutoKill();
            timer1.Stop();
            if (listBox1.SelectedItem != null)
            {
                p.Killmanual(listBox1.SelectedItem.ToString());
            }
            else if (listBox3.SelectedItem != null)
            {
                p.Killmanual(listBox3.SelectedItem.ToString());
            }
            else if (listBox2.SelectedItem != null)
            {
                p.Killmanual(listBox2.SelectedItem.ToString());
            }
            timer1.Start();
        }

     
        class Processes
        {
            Process[] processes;
            int count = 0;

            public void allprocesses(ListBox listBox1)
            {
                processes = Process.GetProcesses();
                if (processes.Length > count || processes.Length < count)
                {
                    listBox1.Items.Clear();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        listBox1.Items.Add(processes[i].ProcessName);
                    }
                }
            }

            public void running(ListBox listBox2)
            {
                if (processes.Length > count || processes.Length < count)
                {
                    listBox2.Items.Clear();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        try
                        {
                            if (processes[i].MainWindowHandle != IntPtr.Zero)
                            {
                                processes[i].Refresh();
                                listBox2.Items.Add(processes[i].MainWindowTitle + " " + processes[i].ProcessName);
                                Thread.Sleep(10);
                            }
                        }
                        catch
                        { // The process has probably exited,
                          // so accessing MainWindowHandle threw an exception
                        }
                    }
                }
            }


            public void notrunningprocess(ListBox listBox3)
            {
                if (processes.Length > count || processes.Length < count)
                {
                    listBox3.Items.Clear();
                    for (int i = 0; i < processes.Length; i++)
                    {
                        try
                        {
                            if (processes[i].MainWindowHandle == IntPtr.Zero)
                            {
                                processes[i].Refresh();
                                listBox3.Items.Add(processes[i].ProcessName);
                                Thread.Sleep(10);
                            }
                        }
                        catch
                        {
                            // The process has probably exited,
                            // so accessing MainWindowHandle threw an exception }
                        }
                    }
                }
                count = processes.Length;
            }


            public void Killmanual(string NameofProcess)
            {
                for (int i = 0; i < processes.Length; i++)
                {
                    if (NameofProcess == processes[i].ProcessName || NameofProcess.Contains(processes[i].ProcessName))
                    {
                        processes[i].Refresh();
                        processes[i].Kill();
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

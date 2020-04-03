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
using System.Management;
namespace simple_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        Process[] proc;
        public void GetAllProcess()
        {
            proc = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process p in proc)           
                listBox1.Items.Add(p.ProcessName);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            GetAllProcess();
            
           
        }

        private void btnendtaask_Click(object sender, EventArgs e)
        {
            try
            {
                proc[listBox1.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (forRUnTask f = new forRUnTask())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    GetAllProcess();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            obj.Show();
        }
    }
}

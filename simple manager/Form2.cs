using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_manager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {

            float pcpu = pCpu.NextValue();
            float pram = pRAM.NextValue();
            progressBar1.Value = (int)pcpu;
            progressBar2.Value = (int)pram;
            labelcpu.Text = string.Format("{0:0.00}%", pcpu);
            labelRAM.Text = string.Format("{0:0.00}%", pram);
            chart1.Series["CPU"].Points.AddY(pcpu);
            chart2.Series["MEMORY"].Points.AddY(pram);
            float pdisk = pDisk.NextValue();

            progressBar3.Value = (int)pdisk;
            labeldisk.Text = string.Format("{0:0.00}%", pdisk);
            chart3.Series["DISK"].Points.AddY(pdisk);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

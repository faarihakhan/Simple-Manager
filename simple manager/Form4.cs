using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace simple_manager
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Services();
        }

        public void Services()
        {

            ServiceController[] services;
            services = ServiceController.GetServices();
            //Process[] processList = Process.GetProcesses();

           // ImageList Imagelist = new ImageList();


            foreach (ServiceController process in services)
            {

          
                string status = process.Status.ToString();
                string Description = process.DisplayName.ToString();
                string[] row = { process.ServiceName,  status,Description };

                ListViewItem item = new ListViewItem(row)
                {                 
                };
                listView1.Items.Add(item);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

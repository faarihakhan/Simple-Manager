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
namespace simple_manager
{
    public partial class forRUnTask : Form
    {
        public forRUnTask()
        {
            InitializeComponent();
        }

        private void btnrun_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(Opentxt.Text))
            {
                try
                {
                    Process proc = new Process();
                    proc.StartInfo.FileName = Opentxt.Text;
                    proc.Start();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void forRUnTask_Load(object sender, EventArgs e)
        {

        }
    }
}

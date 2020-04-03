using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.Dynamic;

namespace simple_manager
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Process[] proc;
        private void Form3_Load(object sender, EventArgs e)
        {
            renderProcessesOnListView();
        }
        // Returns an Expando object with the description and username of a process from the process ID.
         public ExpandoObject GetProcessExtraInformation(int processId)
        {
           
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Create a dynamic object to store some properties on it
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            foreach (ManagementObject obj in processList)
            {
                // Retrieve username 
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // return Username
                    response.Username = argList[0];
                }

                // Retrieve process description if exists
                if (obj["ExecutablePath"] != null)
                {
                    try
                    {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    }
                    catch { }
                }
            }

            return response;
        }
        //for size of process
        public string Bytestoreadvalue(long num)
        {
            List<string> suff = new List<string> { "B", "KB", "MB", "GB", "TB", "PB" };
            for (int i = 0; i < suff.Count; i++)
            {
                long temp = num / (int)Math.Pow(1024, i + 1);
                if (temp == 0)
                {
                    return (num / (int)Math.Pow(1024, i)) + suff[i];
                }
            }
            return num.ToString();
        }


        // This method renders all the processes of Windows on a ListView with some values and icons.

        public void renderProcessesOnListView()
        {
            // Create an array to store the processes
            Process[] processList = Process.GetProcesses();

            // Create an Imagelist that will store the icons of every process
            ImageList Imagelist = new ImageList();

            // Loop through the array of processes to show information of every process in your console
            foreach (Process process in processList)
            {
                // Define the status from a boolean to a simple string
                string status = (process.Responding == true ? "Responding" : "Not responding");

                // Retrieve the object of extra information of the process (to retrieve Username and Description)
                dynamic extraProcessInfo = GetProcessExtraInformation(process.Id);


                string[] row = { process.ProcessName,process.Id.ToString(),  status, extraProcessInfo.Username, Bytestoreadvalue(process.PrivateMemorySize64), extraProcessInfo.Description };
                                                                                
                //for not every process has icon
                try
                {
                    Imagelist.Images.Add(
                        // Add an unique Key as identifier for the icon 
                        process.Id.ToString(),
                        // Add Icon to the List 
                        Icon.ExtractAssociatedIcon(process.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }
                // Create a new Item to add into the list view that expects the row of information as first argument
                ListViewItem item = new ListViewItem(row)
                {

                    ImageIndex = Imagelist.Images.IndexOfKey(process.Id.ToString())
                };
                listView1.Items.Add(item);
            }
            listView1.LargeImageList = Imagelist;
            listView1.SmallImageList = Imagelist;
        }

        private void btnendtaask_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var itsem in Process.GetProcessesByName(s))
                {
                    itsem.Kill();
                }
                listView1.Items[d].Remove();
            }
            catch (Exception ex)
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int d = 0;
        string s = string.Empty;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            s= listView1.SelectedItems[0].SubItems[0].Text;
            d = listView1.SelectedIndices[0];
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

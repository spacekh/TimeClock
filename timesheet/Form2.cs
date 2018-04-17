using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolderSweeper
{
    public partial class Form2 : Form
    {
        DateTime timein, timeout;
        string dir = "C:\\Users\\Public\\TestFolder\\";
        string path;
        public Form2()
        {
            path = dir + "timesheet.txt";
            InitializeComponent();
            Text = "Time Clock App";
            Icon = timesheet.Properties.Resources.ClockIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeout = DateTime.Now;
            label2.Text = timeout.ToShortTimeString();
            string s = $"date: {DateTime.Today.ToShortDateString()}; \tin: {timein.ToShortTimeString()}; \tout: {timeout.ToShortTimeString()}; \telapsed: {(timeout - timein).TotalHours}{Environment.NewLine}";
            if (File.Exists(path)) File.AppendAllText(path, s);
            else
            {
                Directory.CreateDirectory(dir);
                File.WriteAllText(path, s);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timein = DateTime.Now;
            label1.Text = timein.ToShortTimeString();
        }
    }
}

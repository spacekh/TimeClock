using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string path = "C:\\Users\\Public\\TestFolder\\timesheet.txt";
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timeout = DateTime.Now;
            label2.Text = timeout.ToShortTimeString();
            string s = $"date: {DateTime.Today.ToShortDateString()}; \tin: {timein.ToShortTimeString()}; \tout: {timeout.ToShortTimeString()}; \telapsed: {(timeout - timein).TotalHours}";
            if (File.Exists(path)) File.AppendAllText(path, s);
            else File.WriteAllText(path, s);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timein = DateTime.Now;
            label1.Text = timein.ToShortTimeString();
        }
    }
}

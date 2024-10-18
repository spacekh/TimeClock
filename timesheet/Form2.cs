using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
#pragma warning disable CA1416

namespace timesheet
{
    public partial class Form2 : Form
    {
        private DateTime _timeIn, _timeOut;
        private readonly List<string> _jobs= [];
        private const string _dir = "C:\\dev\\timesheet";
        private readonly string _file = Path.Combine(_dir, "timesheet.csv");
        private readonly string _jobsPath = Path.Combine(_dir, "jobs.txt");

        public Form2()
        {
            try
            {
                var reader = new StreamReader(File.OpenRead(_jobsPath));
                var line = reader.ReadLine();
                while (line != null)
                {
                    _jobs.Add(line);
                    line = reader.ReadLine();
                }

                reader.Close();
            }
            catch (FileNotFoundException)
            {
                File.Create(_jobsPath).Close();
            }

            InitializeComponent();
            jobDropDown.Items.AddRange(_jobs.ToArray());
            Text = "Time Clock App";
            Icon = Properties.Resources.ClockIcon;
        }

        private void clockOut_Click(object sender, EventArgs e)
        {
            _timeOut = DateTime.Now;
            var s = $"{_timeOut:M'/'dd'/'yyyy};{_timeIn.ToShortTimeString()};{_timeOut.ToShortTimeString()};{(_timeOut - _timeIn).TotalHours};{jobDropDown.SelectedItem}{Environment.NewLine}";
            if (File.Exists(_file)) File.AppendAllText(_file, s);
            else
            {
                Directory.CreateDirectory(_dir);
                File.WriteAllText(_file, s);
            }
        }

        private void openTimesheetButton_Click(object sender, EventArgs e)
        {
            Process.Start(_file);
        }

        private void clockInButton_Click(object sender, EventArgs e)
        {
            _timeIn = DateTime.Now;
            timeIn.Text = _timeIn.ToShortTimeString();
        }

        private void openJobSheetButton_Click(object sender, EventArgs e)
        {
            Process.Start(_jobsPath);
        }

        private void timeIn_Click(object sender, EventArgs e)
        {
            var f = new TimePicker(_timeIn);
            if (f.ShowDialog() == DialogResult.OK)
            {
                _timeIn = f.dateTimePicker.Value;
                timeIn.Text = _timeIn.ToShortTimeString();
            }
        }
    }
}

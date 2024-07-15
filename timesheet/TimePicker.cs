using System;
using System.Windows.Forms;

namespace timesheet;

public partial class TimePicker : Form
{
    public TimePicker(DateTime initialValue = default)
    {
        InitializeComponent();
        if (initialValue != default) dateTimePicker.Value = initialValue;
    }
}
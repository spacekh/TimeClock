namespace timesheet
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            clockInButton = new System.Windows.Forms.Button();
            clockOutButton = new System.Windows.Forms.Button();
            openTimesheetButton = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            timeInLabel = new System.Windows.Forms.Label();
            timeIn = new System.Windows.Forms.Label();
            openJobSheetButton = new System.Windows.Forms.Button();
            jobDropDown = new System.Windows.Forms.ComboBox();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // clockInButton
            // 
            clockInButton.Location = new System.Drawing.Point(14, 14);
            clockInButton.Margin = new System.Windows.Forms.Padding(2);
            clockInButton.Name = "clockInButton";
            clockInButton.Size = new System.Drawing.Size(130, 30);
            clockInButton.TabIndex = 0;
            clockInButton.Text = "Clock In";
            clockInButton.UseVisualStyleBackColor = true;
            clockInButton.Click += clockInButton_Click;
            // 
            // clockOutButton
            // 
            flowLayoutPanel1.SetFlowBreak(clockOutButton, true);
            clockOutButton.Location = new System.Drawing.Point(148, 14);
            clockOutButton.Margin = new System.Windows.Forms.Padding(2);
            clockOutButton.Name = "clockOutButton";
            clockOutButton.Size = new System.Drawing.Size(130, 30);
            clockOutButton.TabIndex = 1;
            clockOutButton.Text = "Clock Out";
            clockOutButton.UseVisualStyleBackColor = true;
            clockOutButton.Click += clockOut_Click;
            // 
            // openTimesheetButton
            // 
            openTimesheetButton.Location = new System.Drawing.Point(14, 91);
            openTimesheetButton.Margin = new System.Windows.Forms.Padding(2);
            openTimesheetButton.Name = "openTimesheetButton";
            openTimesheetButton.Size = new System.Drawing.Size(130, 30);
            openTimesheetButton.TabIndex = 4;
            openTimesheetButton.Text = "Open Timesheet";
            openTimesheetButton.UseVisualStyleBackColor = true;
            openTimesheetButton.Click += openTimesheetButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(clockInButton);
            flowLayoutPanel1.Controls.Add(clockOutButton);
            flowLayoutPanel1.Controls.Add(timeInLabel);
            flowLayoutPanel1.Controls.Add(timeIn);
            flowLayoutPanel1.Controls.Add(openTimesheetButton);
            flowLayoutPanel1.Controls.Add(openJobSheetButton);
            flowLayoutPanel1.Controls.Add(jobDropDown);
            flowLayoutPanel1.Location = new System.Drawing.Point(10, 12);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 12, 12, 12);
            flowLayoutPanel1.Size = new System.Drawing.Size(294, 207);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // timeInLabel
            // 
            timeInLabel.Location = new System.Drawing.Point(14, 46);
            timeInLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeInLabel.Name = "timeInLabel";
            timeInLabel.Size = new System.Drawing.Size(93, 43);
            timeInLabel.TabIndex = 5;
            timeInLabel.Text = "Time In:";
            // 
            // timeIn
            // 
            timeIn.Location = new System.Drawing.Point(111, 46);
            timeIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            timeIn.Name = "timeIn";
            timeIn.Size = new System.Drawing.Size(112, 37);
            timeIn.TabIndex = 7;
            timeIn.Click += timeIn_Click;
            // 
            // openJobSheetButton
            // 
            flowLayoutPanel1.SetFlowBreak(openJobSheetButton, true);
            openJobSheetButton.Location = new System.Drawing.Point(148, 91);
            openJobSheetButton.Margin = new System.Windows.Forms.Padding(2);
            openJobSheetButton.Name = "openJobSheetButton";
            openJobSheetButton.Size = new System.Drawing.Size(130, 30);
            openJobSheetButton.TabIndex = 9;
            openJobSheetButton.Text = "Open Jobs List";
            openJobSheetButton.UseVisualStyleBackColor = true;
            openJobSheetButton.Click += openJobSheetButton_Click;
            // 
            // jobDropDown
            // 
            jobDropDown.AllowDrop = true;
            jobDropDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            jobDropDown.FormattingEnabled = true;
            jobDropDown.Location = new System.Drawing.Point(14, 125);
            jobDropDown.Margin = new System.Windows.Forms.Padding(2);
            jobDropDown.Name = "jobDropDown";
            jobDropDown.Size = new System.Drawing.Size(264, 23);
            jobDropDown.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(314, 228);
            Controls.Add(flowLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "Form2";
            Text = "Form2";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button openJobSheetButton;

        private System.Windows.Forms.ComboBox jobDropDown;

        private System.Windows.Forms.Label timeIn;

        private System.Windows.Forms.Label timeInLabel;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        #endregion

        private System.Windows.Forms.Button clockInButton;
        private System.Windows.Forms.Button clockOutButton;
        private System.Windows.Forms.Button openTimesheetButton;
    }
}
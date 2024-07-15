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
            this.clockInButton = new System.Windows.Forms.Button();
            this.clockOutButton = new System.Windows.Forms.Button();
            this.openTimesheetButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timeInLabel = new System.Windows.Forms.Label();
            this.timeIn = new System.Windows.Forms.Label();
            this.openJobSheetButton = new System.Windows.Forms.Button();
            this.jobDropDown = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clockInButton
            // 
            this.clockInButton.Location = new System.Drawing.Point(3, 3);
            this.clockInButton.Name = "clockInButton";
            this.clockInButton.Size = new System.Drawing.Size(94, 34);
            this.clockInButton.TabIndex = 0;
            this.clockInButton.Text = "Clock In";
            this.clockInButton.UseVisualStyleBackColor = true;
            this.clockInButton.Click += new System.EventHandler(this.clockInButton_Click);
            // 
            // clockOutButton
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.clockOutButton, true);
            this.clockOutButton.Location = new System.Drawing.Point(103, 3);
            this.clockOutButton.Name = "clockOutButton";
            this.clockOutButton.Size = new System.Drawing.Size(100, 34);
            this.clockOutButton.TabIndex = 1;
            this.clockOutButton.Text = "Clock Out";
            this.clockOutButton.UseVisualStyleBackColor = true;
            this.clockOutButton.Click += new System.EventHandler(this.clockOut_Click);
            // 
            // openTimesheetButton
            // 
            this.openTimesheetButton.Location = new System.Drawing.Point(3, 88);
            this.openTimesheetButton.Name = "openTimesheetButton";
            this.openTimesheetButton.Size = new System.Drawing.Size(151, 36);
            this.openTimesheetButton.TabIndex = 4;
            this.openTimesheetButton.Text = "Open Timesheet";
            this.openTimesheetButton.UseVisualStyleBackColor = true;
            this.openTimesheetButton.Click += new System.EventHandler(this.openTimesheetButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.clockInButton);
            this.flowLayoutPanel1.Controls.Add(this.clockOutButton);
            this.flowLayoutPanel1.Controls.Add(this.timeInLabel);
            this.flowLayoutPanel1.Controls.Add(this.timeIn);
            this.flowLayoutPanel1.Controls.Add(this.openTimesheetButton);
            this.flowLayoutPanel1.Controls.Add(this.openJobSheetButton);
            this.flowLayoutPanel1.Controls.Add(this.jobDropDown);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(385, 220);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // timeInLabel
            // 
            this.timeInLabel.Location = new System.Drawing.Point(3, 40);
            this.timeInLabel.Name = "timeInLabel";
            this.timeInLabel.Size = new System.Drawing.Size(106, 45);
            this.timeInLabel.TabIndex = 5;
            this.timeInLabel.Text = "Time In:";
            // 
            // timeIn
            // 
            this.timeIn.Location = new System.Drawing.Point(115, 40);
            this.timeIn.Name = "timeIn";
            this.timeIn.Size = new System.Drawing.Size(128, 40);
            this.timeIn.TabIndex = 7;
            // 
            // openJobSheetButton
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.openJobSheetButton, true);
            this.openJobSheetButton.Location = new System.Drawing.Point(160, 88);
            this.openJobSheetButton.Name = "openJobSheetButton";
            this.openJobSheetButton.Size = new System.Drawing.Size(134, 31);
            this.openJobSheetButton.TabIndex = 9;
            this.openJobSheetButton.Text = "Open Jobs List";
            this.openJobSheetButton.UseVisualStyleBackColor = true;
            this.openJobSheetButton.Click += new System.EventHandler(this.openJobSheetButton_Click);
            // 
            // jobDropDown
            // 
            this.jobDropDown.AllowDrop = true;
            this.jobDropDown.FormattingEnabled = true;
            this.jobDropDown.Location = new System.Drawing.Point(3, 130);
            this.jobDropDown.Name = "jobDropDown";
            this.jobDropDown.Size = new System.Drawing.Size(141, 24);
            this.jobDropDown.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 244);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
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
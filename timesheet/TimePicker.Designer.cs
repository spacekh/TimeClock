using System.ComponentModel;

namespace timesheet;

partial class TimePicker
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.saveButton = new System.Windows.Forms.Button();
        this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
        this.cancelButton = new System.Windows.Forms.Button();
        this.flowLayoutPanel1.SuspendLayout();
        this.SuspendLayout();
        // 
        // dateTimePicker
        // 
        this.dateTimePicker.CustomFormat = "HH:mm";
        this.flowLayoutPanel1.SetFlowBreak(this.dateTimePicker, true);
        this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dateTimePicker.Location = new System.Drawing.Point(18, 18);
        this.dateTimePicker.Name = "dateTimePicker";
        this.dateTimePicker.ShowUpDown = true;
        this.dateTimePicker.Size = new System.Drawing.Size(116, 22);
        this.dateTimePicker.TabIndex = 0;
        // 
        // saveButton
        // 
        this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.saveButton.AutoSize = true;
        this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
        this.saveButton.Location = new System.Drawing.Point(18, 46);
        this.saveButton.Name = "saveButton";
        this.saveButton.Size = new System.Drawing.Size(50, 26);
        this.saveButton.TabIndex = 1;
        this.saveButton.Text = "Save";
        this.saveButton.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanel1
        // 
        this.flowLayoutPanel1.AutoSize = true;
        this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.flowLayoutPanel1.Controls.Add(this.dateTimePicker);
        this.flowLayoutPanel1.Controls.Add(this.saveButton);
        this.flowLayoutPanel1.Controls.Add(this.cancelButton);
        this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
        this.flowLayoutPanel1.Name = "flowLayoutPanel1";
        this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
        this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 88);
        this.flowLayoutPanel1.TabIndex = 2;
        // 
        // cancelButton
        // 
        this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        this.cancelButton.AutoSize = true;
        this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.cancelButton.Location = new System.Drawing.Point(74, 46);
        this.cancelButton.Name = "cancelButton";
        this.cancelButton.Size = new System.Drawing.Size(60, 26);
        this.cancelButton.TabIndex = 2;
        this.cancelButton.Text = "Cancel";
        this.cancelButton.UseVisualStyleBackColor = true;
        // 
        // TimePicker
        // 
        this.AcceptButton = this.saveButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.AutoSize = true;
        this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.CancelButton = this.cancelButton;
        this.ClientSize = new System.Drawing.Size(162, 88);
        this.Controls.Add(this.flowLayoutPanel1);
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "TimePicker";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.flowLayoutPanel1.ResumeLayout(false);
        this.flowLayoutPanel1.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button saveButton;

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

    public System.Windows.Forms.DateTimePicker dateTimePicker;

    #endregion
}
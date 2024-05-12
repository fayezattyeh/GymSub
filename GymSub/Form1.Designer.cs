
namespace GymSub
{
    partial class GymForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trainingCalendar = new System.Windows.Forms.MonthCalendar();
            this.label4 = new System.Windows.Forms.Label();
            this.startingDateTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.MonthsNumTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeekNumTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DaysNumTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endDateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            this.TimeButton = new System.Windows.Forms.Button();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.AgeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(276, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 74);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 28);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mobile no,";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Date:";
            // 
            // trainingCalendar
            // 
            this.trainingCalendar.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.trainingCalendar.Location = new System.Drawing.Point(295, 49);
            this.trainingCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.trainingCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.trainingCalendar.MaxSelectionCount = 60;
            this.trainingCalendar.MinDate = new System.DateTime(2021, 4, 18, 0, 0, 0, 0);
            this.trainingCalendar.MonthlyBoldedDates = new System.DateTime[] {
        new System.DateTime(2021, 5, 1, 0, 0, 0, 0)};
            this.trainingCalendar.Name = "trainingCalendar";
            this.trainingCalendar.TabIndex = 2;
            this.trainingCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.trainingCalendar_DateChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stat Date:";
            // 
            // startingDateTextBox
            // 
            this.startingDateTextBox.Location = new System.Drawing.Point(112, 14);
            this.startingDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.startingDateTextBox.Name = "startingDateTextBox";
            this.startingDateTextBox.ReadOnly = true;
            this.startingDateTextBox.Size = new System.Drawing.Size(261, 22);
            this.startingDateTextBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.MonthsNumTextBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.WeekNumTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DaysNumTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.endDateTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.startingDateTextBox);
            this.panel1.Location = new System.Drawing.Point(295, 430);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 194);
            this.panel1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Month #:";
            // 
            // MonthsNumTextBox
            // 
            this.MonthsNumTextBox.Location = new System.Drawing.Point(116, 159);
            this.MonthsNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MonthsNumTextBox.Name = "MonthsNumTextBox";
            this.MonthsNumTextBox.ReadOnly = true;
            this.MonthsNumTextBox.Size = new System.Drawing.Size(261, 22);
            this.MonthsNumTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Day in Week:";
            // 
            // WeekNumTextBox
            // 
            this.WeekNumTextBox.Location = new System.Drawing.Point(115, 123);
            this.WeekNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WeekNumTextBox.Name = "WeekNumTextBox";
            this.WeekNumTextBox.ReadOnly = true;
            this.WeekNumTextBox.Size = new System.Drawing.Size(261, 22);
            this.WeekNumTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "No. of Days:";
            // 
            // DaysNumTextBox
            // 
            this.DaysNumTextBox.Location = new System.Drawing.Point(112, 89);
            this.DaysNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DaysNumTextBox.Name = "DaysNumTextBox";
            this.DaysNumTextBox.ReadOnly = true;
            this.DaysNumTextBox.Size = new System.Drawing.Size(261, 22);
            this.DaysNumTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "End Date:";
            // 
            // endDateTextBox
            // 
            this.endDateTextBox.Location = new System.Drawing.Point(112, 53);
            this.endDateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.endDateTextBox.Name = "endDateTextBox";
            this.endDateTextBox.ReadOnly = true;
            this.endDateTextBox.Size = new System.Drawing.Size(261, 22);
            this.endDateTextBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 443);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Add Days:";
            // 
            // DaysNumeric
            // 
            this.DaysNumeric.Location = new System.Drawing.Point(789, 442);
            this.DaysNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.DaysNumeric.Name = "DaysNumeric";
            this.DaysNumeric.Size = new System.Drawing.Size(88, 22);
            this.DaysNumeric.TabIndex = 7;
            this.DaysNumeric.ValueChanged += new System.EventHandler(this.DaysNumeric_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(707, 494);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Time:";
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(761, 490);
            this.TimeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(115, 22);
            this.TimeTextBox.TabIndex = 9;
            // 
            // TimeButton
            // 
            this.TimeButton.Location = new System.Drawing.Point(763, 545);
            this.TimeButton.Margin = new System.Windows.Forms.Padding(4);
            this.TimeButton.Name = "TimeButton";
            this.TimeButton.Size = new System.Drawing.Size(87, 48);
            this.TimeButton.TabIndex = 10;
            this.TimeButton.Text = "Display Time";
            this.TimeButton.UseVisualStyleBackColor = true;
            this.TimeButton.Click += new System.EventHandler(this.TimeButton_Click);
            // 
            // DOBPicker
            // 
            this.DOBPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DOBPicker.Location = new System.Drawing.Point(8, 241);
            this.DOBPicker.Margin = new System.Windows.Forms.Padding(4);
            this.DOBPicker.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.DOBPicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.ShowCheckBox = true;
            this.DOBPicker.ShowUpDown = true;
            this.DOBPicker.Size = new System.Drawing.Size(265, 22);
            this.DOBPicker.TabIndex = 11;
            this.DOBPicker.Value = new System.DateTime(2021, 12, 5, 0, 0, 0, 0);
            this.DOBPicker.ValueChanged += new System.EventHandler(this.DOBPicker_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 202);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 12;
            this.label11.Text = "Date  of Birth:";
            // 
            // AgeButton
            // 
            this.AgeButton.Location = new System.Drawing.Point(72, 318);
            this.AgeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AgeButton.Name = "AgeButton";
            this.AgeButton.Size = new System.Drawing.Size(120, 75);
            this.AgeButton.TabIndex = 13;
            this.AgeButton.Text = "Compute Age";
            this.AgeButton.UseVisualStyleBackColor = true;
            this.AgeButton.Click += new System.EventHandler(this.AgeButton_Click);
            // 
            // GymForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 664);
            this.Controls.Add(this.AgeButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.TimeButton);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DaysNumeric);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trainingCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GymForm";
            this.Text = "Gym Subscription";
            this.Load += new System.EventHandler(this.GymForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar trainingCalendar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox startingDateTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MonthsNumTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeekNumTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DaysNumTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox endDateTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown DaysNumeric;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TimeTextBox;
        private System.Windows.Forms.Button TimeButton;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AgeButton;
    }
}


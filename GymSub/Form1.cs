using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSub
{
    public partial class GymForm : Form
    {
        public GymForm()
        {
            InitializeComponent();
        }

        private void trainingCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            startingDateTextBox.Text = trainingCalendar.SelectionStart.ToShortDateString();
            endDateTextBox.Text = trainingCalendar.SelectionEnd.ToLongDateString();

            TimeSpan t = trainingCalendar.SelectionEnd.Subtract(trainingCalendar.SelectionStart);
            DaysNumTextBox.Text = t.Days.ToString();

            WeekNumTextBox.Text = trainingCalendar.SelectionStart.DayOfWeek.ToString();
            MonthsNumTextBox.Text = trainingCalendar.SelectionStart.Month.ToString();

        }

        private void GymForm_Load(object sender, EventArgs e)
        {
            trainingCalendar.MinDate = DateTime.Today;
            trainingCalendar.MaxDate = DateTime.Today.AddYears(1);

            DOBPicker.Value = DateTime.Today.AddYears(-25);
            // min date before 100
            DOBPicker.MinDate = DateTime.Today.AddYears(0);
            MessageBox.Show(DOBPicker.MinDate.ToString());
        }

        private void DaysNumeric_ValueChanged(object sender, EventArgs e)
        {
            int daysToAdd = (int)DaysNumeric.Value;
             DateTime d = trainingCalendar.SelectionStart.AddDays(daysToAdd);
            endDateTextBox.Text = d.ToString();
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            TimeTextBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void AgeButton_Click(object sender, EventArgs e)
        {
            int age = DateTime.Now.Year - DOBPicker.Value.Year;
            MessageBox.Show($"You have {age} years old", "Your Age", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOBPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

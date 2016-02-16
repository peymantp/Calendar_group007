using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJCalender
{
    public partial class Menus : Form
    {

        public Menus()
        {
            InitializeComponent();
            dateTimePicker.Value = DateTime.Now;
            labelDay.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            global::PJCalender.Program.Exit();
        }

        private void buttonPickDay_Click(object sender, EventArgs e)
        {
            dayPickerDialog d = new dayPickerDialog();
            d.Show();
        }

        private void dateTimePicker_DatePicked(object sender, EventArgs e)
        {
            DateTime t = dateTimePicker.Value;
            labelDay.Text = t.ToLongDateString();
            monthDayNumber(t);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="date"></param>
        /// <returns>Number of days within each month</returns>
        private int monthDayNumber(DateTime date)
        {
            //adding days to month view HARD CODED
            /*
            int day = 27;
            for(int row = 1; row < 7; row++)
            {
                for(int column = 0; column < 7; column++, day++)
                {
                    if (day == 32)
                        day = 1;
                    Label label = new Label();
                    label.Name = "label" + day + "ofMonth";
                    label.Text = ""+day;
                    tableLayoutPanelMonth.Controls.Add(label, column, row);
                }
            }
            */
            switch (date.Month)
            {
                case 1: //January
                    return 31;
                case 2: // Februrary
                    if (DateTime.IsLeapYear(date.Year))
                        return 29;
                    return 28;
                case 3:     //March
                    return 31;
                case 4:     //April
                    return 30;
                case 5:     //May
                    return 31;
                case 6:     //June
                    return 30;
                case 7:     //July
                    return 31;
                case 8:     //Augest
                    return 31;
                case 9:     //September
                    return 30;
                case 10:    //October
                    return 31;
                case 11:    //November
                    return 30;
                case 12:    //December
                    return 31;
            }
            return 0;
        }
        
    }
}

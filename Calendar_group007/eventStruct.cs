using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCalender
{
    /// <summary>
    /// Format of events that are stored locally from google 
    /// </summary>
    public struct eventStruct
    {
        public string startDate;
        public string startTime;
        public string Summary;
        public string Location;
        public string Description;
        public string html;
        public string endDate;
        public string endTime;
        /// <summary>
        /// easy way of returning the value inside the object
        /// </summary>
        /// <param name="i">location of the value</param>
        /// <returns>string for the index</returns>
        public string getItemByIndex(int i)
        {
            switch (i)
            {
                case 0:
                    return startDate;
                case 1:
                    if (!String.IsNullOrEmpty(startTime)) return startTime;
                    else return "";
                case 2:
                    if (!String.IsNullOrEmpty(Summary)) return Summary;
                    else return "";
                case 3:
                    if (!String.IsNullOrEmpty(Location)) return Location;
                    else return "";
                case 4:
                    if (!String.IsNullOrEmpty(Description)) return Description;
                    else return "";
                case 7:
                    return html;
                case 5:
                    return endDate;
                case 6:
                    if (!String.IsNullOrEmpty(endTime)) return endTime;
                    else return "";
                default:
                    break;
            }
            return " ";
        }
        /// <summary>
        /// Returns a string with all the values of the object
        /// format: start date, start time, summary, location, description, html link, end date, end time
        /// </summary>
        /// <returns>All the none null values the object has in a string</returns>
        public override string ToString()
        {
            string value = startDate;
            if (!String.IsNullOrEmpty(startTime))
                value += ", " + startTime;
            if (!String.IsNullOrEmpty(Summary))
                value += ", " + Summary;
            if (!String.IsNullOrEmpty(Location))
                value += ", " + Location;
            if (!String.IsNullOrEmpty(Description))
                value += ", " + Description;

            value += ", " + html + ", " + endDate;
            if (!String.IsNullOrEmpty(endTime))
                value += ", " + endTime;

            return value;

        }
    }
}

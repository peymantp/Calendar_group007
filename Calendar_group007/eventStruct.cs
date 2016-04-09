﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJCalender
{
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

        public string getItemByIndex(int i)
        {
            switch (i)
            {
                case 0:
                    return startDate;
                    break;
                case 1:
                    if (!String.IsNullOrEmpty(startTime)) return startTime;
                    else return "";
                    break;
                case 2:
                    if (!String.IsNullOrEmpty(Summary)) return Summary;
                    else return "";
                    break;
                case 3:
                    if (!String.IsNullOrEmpty(Location)) return Location;
                    else return "";
                    break;
                case 4:
                    if (!String.IsNullOrEmpty(Description)) return Description;
                    else return "";
                    break;
                case 5:
                    return html;
                    break;
                case 6:
                    return endDate;
                    break;
                case 7:
                    if (!String.IsNullOrEmpty(endTime)) return endTime;
                    else return "";
                    break;
                default:
                    break;
            }
            return " ";
        }
        public override string ToString()
        {
            string value = startDate;
            if (!String.IsNullOrEmpty(startTime))
                value += " " + startTime;
            if (!String.IsNullOrEmpty(Summary))
                value += " " + Summary;
            if (!String.IsNullOrEmpty(Location))
                value += " " + Location;
            if (!String.IsNullOrEmpty(Description))
                value += " " + Description;

            value += " " + html + " " + endDate;
            if (!String.IsNullOrEmpty(endTime))
                value += " " + endTime;

            return value;

        }
    }
}
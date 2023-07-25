using System;
using System.Globalization;

namespace HtmlToPdf.WebApplication.Models
{

    public class MonthViewModel
    {
        public int Year { get; set; }
        public DateTime TempDate { get; set; }
        public GregorianCalendar Calendar { get; set; }
    }
}
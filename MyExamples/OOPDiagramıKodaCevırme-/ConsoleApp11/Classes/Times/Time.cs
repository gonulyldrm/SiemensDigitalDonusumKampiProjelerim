using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Times
{
    internal class Time : Sales
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public int Day { get; set; }
        public int DayNumber { get; set; }
        public int Working { get; set; }
        public int Qty { get; set; }
        public Month Month { get; set; }

        public Time() { }
        public Time(string description, int iD, int day, int dayNumber, int working, int qty, Month month)
        {
            Description = description;
            ID = iD;
            Day = day;
            DayNumber = dayNumber;
            Working = working;
            Qty = qty;
            Month = month;
        }

        public virtual int GetID() { return ID; }
        public virtual int GetDay() { return Day; }
        public virtual int GetDayNumber() { return DayNumber; }
        public virtual int GetWorking() { return Working; }
        public virtual int GetQty() { return Qty; }
        public virtual Month GetMonth() { return Month; }
        public virtual string Getdescription() { return Description; }
    }
}

using ConsoleApp11.Classes.Time.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes
{
    internal class Month
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public Quarter Quarter { get; set; }
        public Semester Semester { get; set; }

        public Month() { }
        public Month(string description, int iD, Quarter quarter, Semester semester)
        {
            Description = description;
            ID = iD;
            Quarter = quarter;
            Semester = semester;
        }

        public virtual int GetId() { return ID; }
        public virtual Quarter GetQuarter() { return Quarter; }
        public virtual Semester GetSemester() { return Semester; }
    }
}

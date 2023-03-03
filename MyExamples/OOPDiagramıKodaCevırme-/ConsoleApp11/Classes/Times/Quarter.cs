using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Time.Time
{
    internal class Quarter
    {
        public string Description { get; set; }
        public int ID { get; set; }
        public Year Year { get; set; }

        public Quarter() { }
        public Quarter(string description, int iD, Year year)
        {
            Description = description;
            ID = iD;
            Year = year;
        }

        public virtual int GetId() { return ID; }
        public virtual Year GetYear() { return Year; }
        public virtual string GetDescription() { return Description; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11.Classes.Time.Time
{
    internal class Year
    {
        public string Description { get; set; }
        public int ID { get; set; }

        public Year() { }
        public Year(string description, int iD)
        {
            ID = iD;
            Description = description;
        }
        
        public virtual int GetID() { return ID; }
        public virtual string GetDescription() { return Description; }

    }
}

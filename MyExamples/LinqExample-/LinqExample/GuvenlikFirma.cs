using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    internal class GuvenlikFirma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Gorevli> Gorevlis { get; set; }
        public GuvenlikFirma() { }
    }
}
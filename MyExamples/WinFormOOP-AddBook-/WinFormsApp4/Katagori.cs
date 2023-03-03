using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Katagori
    {
        public int ID { get; set; }
        public enum Katagoriler
        {
            aksiyon=0,
            romantik=1,
            dram=3
        }
        public Katagori() { }   
        public Katagori(string katagori){
            
            Katagoriler kata=new Katagoriler();
        
            switch (katagori)
            {

                case "aksiyon":
                    kata= Katagoriler.aksiyon;
                    this.ID = (int)Katagoriler.aksiyon;
                    break;
                case "romantik":
                    kata = Katagoriler.romantik;
                    this.ID = (int)Katagoriler.romantik;    
                    break;
                case "dram":
                    kata = Katagoriler.dram;
                    this.ID = (int)Katagoriler.dram;
                    break;
                default:
                    break;

            }
        
        
           
        
        }

    }
}

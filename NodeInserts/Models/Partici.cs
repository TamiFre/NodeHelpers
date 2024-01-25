using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Partici
    {
        private string name;
        private double beforeWeight;
        private double afterWeight;

        public double GetBefore()
        { return beforeWeight; }
        public double GetAfter() 
        { return afterWeight;}
        public string GetName()
        { return name; }

        //פעולה שמחשבת את השיעור ירידה באחוזים
        public double DowmInPrecent()
        {
            return (this.beforeWeight-this.afterWeight)/beforeWeight*100;
        }


    }
}

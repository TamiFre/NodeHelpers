using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class TavimAndNum
    {
        private int num;
        private char tav;

        public int GetNum()
        { return num; }

        public char GetTav() 
        {  return tav; }

        public void SetTav(char tav)
        { this.tav = tav; }

        public void SetNum(int num) 
        {  this.num = num; }
    }
}

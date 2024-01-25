using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Dominos
    {
        private int firstStone;//0-6
        private int secondStone;

        public int GetFirstStone()
        { return firstStone; }

        public int GetSecondStone()     
        {  return secondStone; }

        public void SetFirstStone(int num)
        { 
            if (num >= 0 && num <= 6)
                this.firstStone = num;
        }

        public void SetSecondStone(int num)
        {
            if(num >=0 && num <= 6)
                this.secondStone = num;
        }

        public Dominos () 
        {
            this.firstStone = 0;
            this.secondStone = 0;
        }

        public bool IsExists(int num)
        {
            if(this.firstStone==num|| this.secondStone==num)
                return true;
            return false;
        }

    }

}

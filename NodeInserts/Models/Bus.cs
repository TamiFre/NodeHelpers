using NodeClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeInserts.Models
{
    public class Station
    {
        private string street;
        private int num;

        public Station() 
        { }

        public int GetNUm()
        { return num; }
        public string GetStreet() { return street;}

        //bool equals
    }

    public class Bus
    {
        private int lineNum;
        private int pricePerStation;
        Node<Station> listAllStations;

        public double Riding(Station start, Station end)
        {
            bool isStart = false;
            double total = 0;
            Node<Station> node = listAllStations;
            while (node != null && node.GetValue().Equals(end))
            {
                if (!isStart && node.GetValue().Equals(start))
                {
                    total += this.pricePerStation;
                    isStart = true;
                }
                else if (isStart)
                {
                    total += this.pricePerStation;
                }
                node

            }
        }
    }

    public class CityBusses
    {
        private string nameCity;
        Node<Bus> listAllLines;
        public Node<Bus> GetList() { return listAllLines; }
    }
}

using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        //שאלה 48
        public static int NumCanPutDominoTogether(Dominos dmn, Node<Dominos> lst)
        {
            Dominos s = lst.GetValue();
            int counter = 0;
            while (lst != null)
            {
                if (s.IsExists(dmn.GetSecondStone())|| s.IsExists(dmn.GetFirstStone()))
                    counter++;
                lst = lst.GetNext();
            }
            return counter;
        }


        //שאלה 50
        public static string NameOfWinner(Node<Partici> lst)
        {
            Partici p = lst.GetValue();
            string nameWinner = "";
            double max = -1;
            while(lst!=null)
            {
                if (p.DowmInPrecent() > max)
                {
                    max = p.DowmInPrecent();
                    nameWinner = p.GetName();   
                }
                lst = lst.GetNext();
            }
            return nameWinner;
        }

        //שאלה 57 
        //א
        public static void PrintAverage(Node<Students> s)
        {
            Students n = s.GetValue();  
            if (s==null)
                return;
            while (s != null)
            {
                Console.WriteLine($"{n.Average()}+{n.GetName()}");
                s = s.GetNext();
            }
        }



        //123 תרגיל 59
        //includes Bus.cs and all the other classes there
        public static int Cheapest(CityBusses cb, Station first, Station destination)
        {
            int totalEnd = -1;
            Node<Bus> dummy = cb.GetList();
            while (dummy != null)
            {
                
            }
        }





    

        static void Main(string[] args)
        {
            Node<ShabatRecievers> shabatShalom = new Node<ShabatRecievers>(new ShabatRecievers("Shiri","Shira",18,1,2024));
            Node<ShabatRecievers> nextShabat = new Node<ShabatRecievers>(new ShabatRecievers("Ofek", "Aviv", 25, 1, 2024));
            shabatShalom.SetNext(nextShabat);

            ShabatRecievers sh = shabatShalom.GetValue();
            string p1 = sh.GetParent1();


        }
    }
}
using NodeClass;
using NodeInserts.Models;

namespace NodeInserts
{
    internal class Program
    {
        public static Node<char> NewNodeWithChar(Node<TavimAndNum> lst)
        {
            if (lst == null)
                return null;
            Node<char> finale = new Node<char>(lst.GetValue().GetTav());

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
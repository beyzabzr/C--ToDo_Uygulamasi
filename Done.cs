using System;

namespace ToDoApplication
{
    public class Done : CartMenager
    {
        public static List<Done> Carts = new List<Done>();

        public Done(string title, string contents, Person appointedPerson)
            : base("Done Listesi", title, contents, appointedPerson, Size.S)
        {
            Carts.Add(this);
        }
        public static void listToCarts()
        {
            for (int i = 0; i < Carts.Count; i++)
            {
                Console.WriteLine("Kart adi: " + Carts[i].Title);
                Console.WriteLine("Kart icerigi: " + Carts[i].Contents);
                Console.WriteLine("Atanan kisi:  " + Carts[i].AppointedPerson.Name + " " + Carts[i].AppointedPerson.SurName);
                Console.WriteLine("Kart buyuklugu: " + Carts[i].Size);
                Console.WriteLine("************************************");
            }
        }
    }
}
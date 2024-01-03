using System;


namespace ToDoApplication
{

    public class ToDoCart : CartMenager
    {


        public static List<ToDoCart> Carts = new List<ToDoCart>();

        public ToDoCart(string title, string contents, Person appointedPerson) :
            base("To-Do Listesi", title, contents, appointedPerson, Size.L)
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
                Console.WriteLine("****************************************");
            }
        }

    }
}
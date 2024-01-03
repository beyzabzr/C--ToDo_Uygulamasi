using System;

namespace ToDoApplication
{
    public static class OurDefaultAccount
    {
        private static Dictionary<int, Person> ourPerson = new Dictionary<int, Person>();
        public static Dictionary<int, Person> ourDefaultPerson()
        {
            ourPerson.Add(1, new Person("Ayse", "BIRINCIOGLU", 1));
            ourPerson.Add(2, new Person("Eren", "IKINCIOGLU", 2));
            ourPerson.Add(3, new Person("Beyza", "UCUNCUOGLU", 3));
            ourPerson.Add(4, new Person("Fatih", "DORDUNCUOGLU", 4));
            ourPerson.Add(5, new Person("Tugba", "BESINCIOGLU", 5));
            ourPerson.Add(6, new Person("Kerem", "ALTINCIOGLU", 6));
            ourPerson.Add(7, new Person("Fatma", "YEDINCIOGLU", 7));
            ourPerson.Add(8, new Person("Cem", "SEKIZINCIOGLU", 8));
            ourPerson.Add(9, new Person("Asli", "DOKUZUNCUOGLU", 9));
            ourPerson.Add(10, new Person("Can", "ONUNCUOGLU", 10));
            return ourPerson;
        }
    }
}
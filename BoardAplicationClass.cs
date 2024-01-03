using System;

namespace ToDoApplication
{
    public class BoardApplicationClass
    {
        static Dictionary<int, Person> people = OurDefaultAccount.ourDefaultPerson();

        public void run()
        {
            CartMenager toDoCart = new ToDoCart("Ingilizce", "Ingilizce dersine calismalisin", people[1]);
            CartMenager inProgressCart = new InProgress("Web development", "Web development alaninda gelismelisin", people[1]);
            CartMenager DoneCart = new Done("Java", "Java alaninda gelismelisin", people[1]);

            bool status = true;
            while (status)
            {
                Console.WriteLine("Lutfen yapacaginiz islemi seciniz: \n" + "1-Kart Ekleme\n" + "2-Kart Cikarma\n" + "3-Kart Guncelle\n" + "4-Kart Tasi\n" + "5-Board Listeleme\n" + "6-Kisileri Goruntule\n" + "0-Cikis");
                int choose = int.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Ekle();
                        break;
                    case 2:
                        Sil();
                        break;
                    case 3:
                        Guncelle();
                        break;
                    case 4:
                        Degistir();
                        break;
                    case 5:
                        Listele();
                        break;
                    case 6:
                        Goruntule();
                        break;
                    case 0:
                        status = false;
                        break;

                }
            }
        }

        public void Ekle()
        {
            Console.Write("Lutfen kart basligini giriniz: "); string title = Console.ReadLine();
            Console.Write("Lutfen kart icerigini giriniz: "); string contents = Console.ReadLine();
            Goruntule();
            Console.WriteLine("Lutfen yukaridaki id numaralarina sahip kisilerden birini atayiniz:  "); int id = int.Parse(Console.ReadLine());

            while (!people.Keys.Contains(id))
            {
                Console.WriteLine("Lutfen yukaridaki id numaralarina sahip kisilerden birini atayiniz:  "); id = int.Parse(Console.ReadLine());
            }
            Person selectedPerson = people[id];
            Console.WriteLine("Lutfen ekleyeceginiz kartin hangi kolona eklenecegini giriniz \n(1) ToDo-(L)\n(2) InProgress-(M)\n(3) Done-(S)");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("ToDo Listesine Kart Eklendi");
                CartMenager newToDoCart = new ToDoCart(title, contents, selectedPerson);
            }
            else if (choose == 2)
            {
                Console.WriteLine("InProgress Listesine Kart Eklendi");
                CartMenager newInProgressCart = new InProgress(title, contents, selectedPerson);
            }
            else if (choose == 3)
            {
                Console.WriteLine("Done Listesine Kart Eklendi");
                CartMenager newDoneCart = new Done(title, contents, selectedPerson);
            }

        }

        public void Sil()
        {
            Console.WriteLine("Hangi bolumdeki karti sileceksiniz\n(1) ToDo\n(2) InProgress\n(3) Done");
            int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Konu basligini giriniz: "); string title = Console.ReadLine();

            if (choose == 1)
            {
                for (int i = 0; i < ToDoCart.Carts.Count; i++)
                {
                    if (ToDoCart.Carts[i].Title == title)
                    {
                        ToDoCart.Carts.Remove(ToDoCart.Carts[i]);
                    }
                    else if (i == ToDoCart.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }
            else if (choose == 2)
            {
                for (int i = 0; i < InProgress.Carts.Count; i++)
                {
                    if (InProgress.Carts[i].Title == title)
                    {
                        InProgress.Carts.Remove(InProgress.Carts[i]);
                    }
                    else if (i == InProgress.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }
            else if (choose == 3)
            {
                for (int i = 0; i < Done.Carts.Count; i++)
                {
                    if (Done.Carts[i].Title == title)
                    {
                        Done.Carts.Remove(Done.Carts[i]);
                    }
                    else if (i == Done.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;

                    }

                }

            }
            else
            {
                Console.WriteLine("Lutfen gecerli bir islem giriniz");
            }
        }

        public void Guncelle()
        {
            Console.Write("Lutfen kart basligini giriniz: "); String newTitle = Console.ReadLine();
            Console.Write("Lutfen kart icerigini giriniz: "); String newContents = Console.ReadLine();
            Goruntule();
            Console.WriteLine("Lutfen yukaridaki id numaralarina sahip kisilerden birini atayiniz:  "); int id = int.Parse(Console.ReadLine());
            while (!people.Keys.Contains(id))
            {
                Console.WriteLine("Lutfen yukaridaki id numaralarina sahip kisilerden birini atayiniz:  "); id = int.Parse(Console.ReadLine());
            }
            Person newSelectedPerson = people[id];
            Console.WriteLine("Lutfen guncellemek istediginiz Kartin hangi bolumde oldugunu giriniz\n(1) ToDo\n(2) InProgress\n(3) Done");
            int choose = int.Parse(Console.ReadLine());

            if (choose == 1)
            {
                Console.WriteLine("Eski basligi giriniz: "); string oldTitle = Console.ReadLine();
                for (int i = 0; i < ToDoCart.Carts.Count; i++)
                {
                    if (ToDoCart.Carts[i].Title == oldTitle)
                    {
                        ToDoCart.Carts[i].Title = newTitle;
                        ToDoCart.Carts[i].Contents = newContents;
                        ToDoCart.Carts[i].AppointedPerson = newSelectedPerson;
                        break;
                    }
                    else if (i == ToDoCart.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }

            }
            else if (choose == 2)
            {
                Console.WriteLine("Eski basligi giriniz: "); string oldTitle = Console.ReadLine();
                for (int i = 0; i < InProgress.Carts.Count; i++)
                {
                    if (InProgress.Carts[i].Title == oldTitle)
                    {
                        InProgress.Carts[i].Title = newTitle;
                        InProgress.Carts[i].Contents = newContents;
                        InProgress.Carts[i].AppointedPerson = newSelectedPerson;
                        break;
                    }
                    else if (i == InProgress.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }

            else if (choose == 3)
            {
                Console.WriteLine("Eski basligi giriniz: "); string oldTitle = Console.ReadLine();
                for (int i = 0; i < Done.Carts.Count; i++)
                {
                    if (Done.Carts[i].Title == oldTitle)
                    {
                        Done.Carts[i].Title = newTitle;
                        Done.Carts[i].Contents = newContents;
                        Done.Carts[i].AppointedPerson = newSelectedPerson;
                        break;
                    }
                    else if (i == Done.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }

            else
            {
                Console.WriteLine("Lutfen gecerli bir secim yapiniz");
            }

        }

        public void Degistir()
        {
            Console.WriteLine("Lutfen hangi kolondaki karti secmek istediginizi belirtiniz\n(1) ToDo\n(2) InProgress\n(3) Done"); int choose = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen karti hangi kolona tasımak istediginizi belirtiniz\n(1) ToDo\n(2) InProgress\n(3) Done"); int newLocationChoose = int.Parse(Console.ReadLine());
            Console.WriteLine("Lutfen kart basligini giriniz: "); string title = Console.ReadLine();

            if (choose == 1)
            {
                for (int i = 0; i < ToDoCart.Carts.Count; i++)
                {
                    if (ToDoCart.Carts[i].Title == title)
                    {
                        if (newLocationChoose == 1)
                            break;
                        else if (newLocationChoose == 2)
                        {
                            InProgress newCart = new InProgress(ToDoCart.Carts[i].Title, ToDoCart.Carts[i].Contents, ToDoCart.Carts[i].AppointedPerson);
                            ToDoCart.Carts.Remove(ToDoCart.Carts[i]);
                            break;
                        }
                        else if (newLocationChoose == 3)
                        {
                            Done newCart = new Done(ToDoCart.Carts[i].Title, ToDoCart.Carts[i].Contents, ToDoCart.Carts[i].AppointedPerson);
                            ToDoCart.Carts.Remove(ToDoCart.Carts[i]);
                            break;
                        }

                    }
                    else if (i == ToDoCart.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }
            else if (choose == 2)
            {
                for (int i = 0; i < InProgress.Carts.Count; i++)
                {
                    if (InProgress.Carts[i].Title == title)
                    {
                        if (newLocationChoose == 1)
                        {
                            ToDoCart newCart = new ToDoCart(InProgress.Carts[i].Title, InProgress.Carts[i].Contents, InProgress.Carts[i].AppointedPerson);
                            InProgress.Carts.Remove(InProgress.Carts[i]);
                            break;
                        }

                        else if (newLocationChoose == 2)
                            break;
                        else if (newLocationChoose == 3)
                        {
                            Done newCart = new Done(InProgress.Carts[i].Title, InProgress.Carts[i].Contents, InProgress.Carts[i].AppointedPerson);
                            InProgress.Carts.Remove(InProgress.Carts[i]);
                            break;
                        }

                    }
                    else if (i == InProgress.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }
            if (choose == 3)
            {
                for (int i = 0; i < Done.Carts.Count; i++)
                {
                    if (Done.Carts[i].Title == title)
                    {
                        if (newLocationChoose == 1)
                        {
                            ToDoCart newCart = new ToDoCart(Done.Carts[i].Title, Done.Carts[i].Contents, Done.Carts[i].AppointedPerson);
                            Done.Carts.Remove(Done.Carts[i]);
                            break;
                        }
                        else if (newLocationChoose == 2)
                        {
                            InProgress newCart = new InProgress(Done.Carts[i].Title, Done.Carts[i].Contents, Done.Carts[i].AppointedPerson);
                            Done.Carts.Remove(Done.Carts[i]);
                            break;
                        }
                        else if (newLocationChoose == 3)
                            break;
                    }
                    else if (i == ToDoCart.Carts.Count - 1)
                    {
                        Console.WriteLine("Aranilan baslikta bir kart bulunamadi");
                        break;
                    }
                }
            }
            Console.WriteLine("Kart tasima islemi tamamlandi");
        }

        public void Listele()
        {
            Console.WriteLine("**********************ToDo Listesi**********************");
            ToDoCart.listToCarts();
            Console.WriteLine("**********************InProgress Listesi*****************");
            InProgress.listToCarts();
            Console.WriteLine("**********************Done Listesi***********************");
            Done.listToCarts();
        }
        public void Goruntule()
        {
            Console.WriteLine("------Kisiler------");
            foreach (Person person in people.Values)
            {
                Console.WriteLine("Ad: " + person.Name);
                Console.WriteLine("Soyad:  " + person.SurName);
                Console.WriteLine("ID:  " + person.ID);
                Console.WriteLine("-------------------");
            }
        }
    }
}
using System;


namespace SortApp
{
    class Test
    {
        public Test ()
        {
            User kirill = new User("CHIKKA", "kirill", "mazik", 20);
            kirill.GetInfo();

            User mom = new User("Tanya");
            mom.GetInfo();

            //kirill.mail = "CHIKKA";
            //kirill.name = "kirill";
            //kirill.surname = "mazik";
            //kirill.age = 20;
            //kirill.GetInfo();

        }

    }

    class User
    {
        public string name, surname, mail;
        public int age;

        public User() : this("Pull info pls"){}

        public User(string name) : this(name, "Pull info pls"){}
        public User(string name, string surname) : this(name, surname, "Pull info pls") { }

        public User(string name, string surname, string mail) : this(name, surname, mail, 0) { }
        
        public User(string name, string surname, string mail, int age)
        {
            this.mail = mail;
            this.surname = surname;
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{name} Surname:{surname} Mail:{mail} Age:{age}");
        }

    }

}

//class User
//{
//    public string name, surname, mail;
//    public int age;

//    public void GetInfo()
//    {
//        Console.WriteLine($"Name:{name} Surname:{surname} Mail:{mail} Age:{age}");
//    }

//}

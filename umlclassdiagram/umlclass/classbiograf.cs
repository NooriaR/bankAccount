using System;
using System.Collections.Generic;
using System.Text;

namespace umlclass
{
    public class classbiograf
        //Huvudklass
    {
        public class cinema
        {
            //atrributer
            public string movies { get; set; }
            public string salons { get; set; }

            //metod
            public void show()
            {
                Console.WriteLine("Movies: " + movies);
                Console.WriteLine("Salons: " + salons);
            }
        }
    }
    //subklass
    public class movies: classbiograf
    {
        //atrributer
        public string title { get; set; }
        public int duration { get; set; }
        public int age { get; set; }

        //metod
        public void show()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Duration: " + duration);
            Console.WriteLine("Age: " + age);
        }
    }
}

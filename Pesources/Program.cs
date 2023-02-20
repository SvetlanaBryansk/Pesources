using System;
using System.IO;

namespace Pesources
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Human human = null;

            //try
            //{
            //    human = new Human(name: "John");
            //}
            //finally
            //{
            //    human?.Dispose();// это тоже самоу, что и это: if (human!= null)  human.Dispose(); 
            //}
                 
            using (Human human = new Human (name:"John"))
            {
                // работа с ресурсом
            }
            Console.WriteLine("Какой-то код");

        }

        private static void GreateHumanTokill(string name)
        {
            Human human = new Human(name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Singleton
{
    public sealed class Singleton
    { 
        private static int counter = 0; 

        //Egar Loading
        private static Singleton instance = new Singleton();

        //Lazy Loading
        //private static Lazy<Singleton> instance = new Lazy<Singleton>(() => new Singleton());
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value "+  counter);
        }
        public static Singleton GetInstance()
        {
            //Egar Loading
            return instance;

            //Lazy Loading
            //return instance.value;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }


    }
}

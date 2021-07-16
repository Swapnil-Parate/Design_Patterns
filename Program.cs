using DesignPatterns.Memento;
using DesignPatterns.SimpleFactory;
using System;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            #region MementoDesign Pattern
            //program.MementoDemo();
            #endregion

            #region Singleton Pattern
            // program.SingletonDemo();
            #endregion

            #region Simple Factory Pattern
            program.SimpleFactoryDemo();
            #endregion




        }

        #region MementoDemo
        public void MementoDemo()
        {
            
            /*
             Memento in C# Memento is a behavioral design pattern that
             allows making snapshots of an object's state and restoring 
             it in future. The Memento doesn't compromise the internal 
             structure of the object it works with, as well as data kept 
             inside the snapshots.
             */
            Editor editor = new Editor();
            History history = new History();

            editor.content = "a";
            history.Push(editor.CreateState());

            editor.content = "b";
            history.Push(editor.CreateState());

            editor.content = "c";
            editor.Restore(history.Pop());

            Console.WriteLine(editor.content);
            Console.ReadLine();
            
        }

        #endregion

        #region SingletonDemo
        public void SingletonDemo()
        {
            Parallel.Invoke(
                () => S1PrintDetails(),
                () => S2PrintDetails()
                );

            Console.ReadLine();


        }

        private static void S2PrintDetails()
        {
            Singleton.Singleton s2 = Singleton.Singleton.GetInstance();
            s2.PrintDetails("This is s2 calling printDetails");
        }

        private static void S1PrintDetails()
        {
            Singleton.Singleton s1 = Singleton.Singleton.GetInstance();
            s1.PrintDetails("This is s1 calling printDetails");
        }
        #endregion

        # region SimpleFactoryDemo
        void SimpleFactoryDemo()
        {
            IFanFactory simpleFactory = new FanFactory();
            IFan fan = simpleFactory.CreateFan(FanType.tableFan);
            fan.SwitchOn();
            fan.SwitchOff();
            Console.ReadLine();
        }
        #endregion
    }
}

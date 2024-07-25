using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private Singleton()
        {

        }

       private  static Singleton Instance;

        public static Singleton GetInstance()
        {
            if(Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }


        //public void SomebusinessLogic()
        //{

        //}

        class Program
        {
            static void Main(string[] args)
            {

                //Singleton s1 = Singleton.GetInstance();

                Singleton s1 = Singleton.GetInstance();
                Singleton s2 = Singleton.GetInstance();

                if (s1 == s2)
                {
                    Console.WriteLine("singleton Works, both variables contains same instance");
                }
                else
                {
                    Console.WriteLine("singleton Failed, both vairables contains diffrent insatnce");
                }

                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP213_S2016_Lesson3
{
    /**
     * this class is the "driver" class for our program
     */
   public class Program
    {
        /**
         * the main method for driver class
         * 
         * @method main
         * @parm {string[]} args
         */
       public static void Main(string[] args)
        {
            // Create a new instance(object) of the person class

            Person Inder = new Person();
            Inder.Name = "Inder";
            Inder.Age = 49;
            Inder._sayHello();
            Inder.ShowAge();

            Console.WriteLine();


            Person Abhinav = new Person("Abhinav");
            Abhinav.Age = 19;
           Abhinav._sayHello();
           Abhinav.ShowAge();

            Console.WriteLine();

            Person Preet = new Person(74);
            Preet.Name = "Preet";
            Preet._sayHello();
            Preet.ShowAge();

            Console.WriteLine();

            Person Iqbal = new Person("Iqbal", 3);
           
            Iqbal._sayHello();
            Iqbal.ShowAge();

        }
    }
}
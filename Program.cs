using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample
{
    public interface strategy
    {
        int doOperation(int num1,int num2);
    }
    public class addOperations:strategy
    {
        public int doOperation(int num1,int num2)
        {
            return num1 + num2;
        }
    }
    public class subOperation : strategy
    {
        public int doOperation(int num1,int num2)
        {
            return num1 - num2;
        }
    }
    public class mulOperation : strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    public class divOperation : strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 / num2;
        }
    }

    class context
    {
        private strategy str;
        public context(strategy str)
        {
            this.str = str;
        }
        public int executeStrategy(int num1,int num2)
        {
            return str.doOperation(num1,num2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            context cnt = new context(new addOperations());
            Console.WriteLine("Addition: " + cnt.executeStrategy(4,6));

            cnt = new context(new subOperation());
            Console.WriteLine("Subtraction: " + cnt.executeStrategy(4, 6));


            Console.ReadKey();
            
        }
    }
}

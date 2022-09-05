using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btApp
{
    internal class Program
    {
        static ConditionObject condition;
        static LoopObject loop;
        static void Main(string[] args)
        {
            condition = new ConditionObject();
            loop = new LoopObject();
            Console.ReadKey();
        }
        
    }
}

using System;
using System.Threading.Tasks;
namespace ToyCSharp {
    class Program {
        [STAThread]
        public static void Main(string[] args)
        {
            var lib = new ToyLib();
            lib.ToyFunction();

            for(var i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"arg[{i}]: {args[i]}");
            }
        }
    }
}

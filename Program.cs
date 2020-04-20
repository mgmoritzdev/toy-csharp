using System;
using System.Threading.Tasks;
namespace ToyCSharp {
    class Program {
        [STAThread]
        public static void Main(string[] args)
        {
            var lib = new ToyLib();
            lib.ToyFunction();

            foreach (var arg in args)
            {
                Console.WriteLine($"arg: {arg}");
            }
        }
    }
}

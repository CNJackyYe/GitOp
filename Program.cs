using System;

namespace GitOp
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new GitOperation();
            op.GetList("");
            //Console.WriteLine("Hello World!");
        }
    }
}

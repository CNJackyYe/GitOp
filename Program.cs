using System;
using Newtonsoft.Json;

namespace GitOp
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = new GitOperation();
            var commits = op.GetList(Environment.CurrentDirectory);
            Console.WriteLine(JsonConvert.SerializeObject(commits));
            var commitid = commits[0].Id;

            //Console.WriteLine("Hello World!");
        }
    }
}

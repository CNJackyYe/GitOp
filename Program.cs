using System;
using Newtonsoft.Json;

namespace GitOp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            var op = new GitOperation();
            var reposCommits = op.GetReposCommits(Environment.CurrentDirectory);
            var fileCommits = op.GetFileCommits(Environment.CurrentDirectory,@"\oxml.xml");
            Console.WriteLine(JsonConvert.SerializeObject(fileCommits));
            var commitid = reposCommits[0].Id;
            // var filecontent = 
            // Console.WriteLine("Hello World!");
        }
    }
}

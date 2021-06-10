using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibGit2Sharp;
namespace GitOp
{
    public class GitOperation : IGitOperation
    {
        public string GetHisFile(string path, string commitSHA)
        {
            throw new System.NotImplementedException();
        }

        public string GetList(string path)
        {
            using (var repo = new Repository(Environment.CurrentDirectory))
            {
                var branches = repo.Branches;
                foreach (var b in branches)
                {
                    Console.WriteLine(b.FriendlyName);
                }
                var res =new List<Commit>();
                var fistCommitId = string.Empty;
                foreach (var commit in repo.Commits)
                {
                    if(fistCommitId == string.Empty){
                        fistCommitId = commit.Id.ToString();
                    }
                    Console.WriteLine(
                        $"{commit.Id.ToString().Substring(0, 7)} " +
                        $"{commit.Author.When.ToLocalTime()} " +
                        $"{commit.MessageShort} " +
                        $"{commit.Author.Name}");
                }

                var commits = repo.Lookup<Commit>(fistCommitId);
                Console.WriteLine($"Commit Full ID: {commits.Id}");
                Console.WriteLine($"Message: {commits.MessageShort}");
                Console.WriteLine($"Author: {commits.Author.Name}");
                Console.WriteLine($"Time: {commits.Author.When.ToLocalTime()}");
            }


            return "";
        }

        public string InitRepository(string path)
        {
            return Repository.Init(path);
        }

        public string UpFileToGit(string opath, string npath)
        {
            throw new System.NotImplementedException();
        }
    }
}
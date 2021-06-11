using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitOp.Models;
using LibGit2Sharp;
namespace GitOp
{
    public class GitOperation : IGitOperation
    {

        public string GetHisFile(string path, string commitSHA)
        {
            throw new System.NotImplementedException();
        }

        public List<CommitMsg> GetList(string path)
        {
            using (var repo = new Repository(path))
            {
                var branches = repo.Branches;
                foreach (var b in branches)
                {
                    Console.WriteLine(b.FriendlyName);
                }
                var res = new List<CommitMsg>();
                var fistCommitId = string.Empty;
                foreach (var commit in repo.Commits)
                {
                    res.Add(new CommitMsg
                    {
                        Id = commit.Id.ToString(),
                        Message = commit.Message,
                        MessageShort = commit.MessageShort,
                        Author = commit.Author.Name,
                        Time = commit.Author.When.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss")
                    });
                }
                return res;
            }
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
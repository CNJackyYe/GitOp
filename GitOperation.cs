using System;
using System.Collections.Generic;
using System.IO;
using GitOp.Models;
using LibGit2Sharp;
using Walterlv.GitDemo;

namespace GitOp
{
    public class GitOperation : IGitOperation
    {

        public string GetHisFile(string path, string ofile,string nfile, string commitSHA)
        {
            ExcuceGitComind(path,ofile,nfile,commitSHA);
            var content = ReadFile(path,nfile);
            return content;
        }

        private void ExcuceGitComind(string path, string ofile,string nfile, string commitSHA){
            var git = new CommandRunner("git", path);
            var result = git.Run($"cat-file -p {commitSHA}:./{ofile} > {nfile}");
        }

        private string ReadFile(string path,string nfile){
            var content = File.ReadAllText(path+nfile);
            return content;
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
using System.Threading.Tasks;
using System.Collections.Generic;
using GitOp.Models;

namespace GitOp{
    public interface IGitOperation
    {
        string InitRepository(string path);
        List<CommitMsg> GetReposCommits(string path);
        List<CommitMsg> GetFileCommits(string path,string file);
        string GetHisFile(string path, string ofile,string nfile, string commitSHA);
        string UpFileToGit(string opath,string npath);
    }
}
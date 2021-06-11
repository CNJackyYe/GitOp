using System.Threading.Tasks;
using System.Collections.Generic;
using GitOp.Models;

namespace GitOp{
    public interface IGitOperation{
        string InitRepository(string path);
        List<CommitMsg> GetList(string path);
        string GetHisFile(string path,string commitSHA);
        string UpFileToGit(string opath,string npath);

    }
}
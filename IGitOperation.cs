using System.Threading.Tasks;

namespace GitOp{
    public interface IGitOperation{
        string InitRepository(string path);
        string GetList(string path);
        string GetHisFile(string path,string commitSHA);
        string UpFileToGit(string opath,string npath);

    }
}
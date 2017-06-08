using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpSvn;

namespace TestExerciser.Tools.SVN
{
    class SVNManager
    {
        public void CheckOut(string repositoryURL,string localPath)
        {
            using (SvnClient client = new SvnClient())
            {
                SvnCheckOutArgs args = new SvnCheckOutArgs();
                SvnUriTarget target = new SvnUriTarget(repositoryURL);
                client.CheckOut(target, localPath, args);
            }
        }

        public void Commit(string localPath)
        {
            using (SvnClient client = new SvnClient())
            {
                client.Commit(localPath);
            }
        }
    }
}

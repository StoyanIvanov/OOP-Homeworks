using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Executor
{
    public  class SessionData
    {
        public  string currentPath = Directory.GetCurrentDirectory();
        public  HashSet<Task> taskPool = new HashSet<Task>();
    }
}

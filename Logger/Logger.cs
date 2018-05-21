using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        public Logger()
        {

        }
        public void WriteLogg(string message)
        {
            TextWriter tw = new StreamWriter(@"logger.txt", true);
            tw.WriteLine(String.Format("{0}: {1}", DateTime.Now, message));
            tw.Close();
        }
    }
}

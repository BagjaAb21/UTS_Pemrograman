using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static filetext.textoutput;

namespace filetext
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mylist1 = new List<string>(new string[] { });
            PrintUtility printutilitya = new PrintUtility();
            bool read = printutilitya.ReadToFile(mylist1);
            bool write = printutilitya.WriteToFile(mylist1);
        }
    }
}

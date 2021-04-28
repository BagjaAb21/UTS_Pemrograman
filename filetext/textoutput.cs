using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;


namespace filetext
{
    class textoutput
    {

        public class PrintUtility
        {
            private static PrintUtility print;
            private readonly string path;
            public PrintUtility()
            {
                path = @"D:\AMIKOM\file file materi dan tugas\Semester 2\Soal Dan Jawaban\UTS\Jawaban\Pemrograman\project\UTS_Pemrograman\201113351.txt";
            }
            public static PrintUtility Instance
            {
                get
                {
                    if (print == null)
                    {
                        print = new PrintUtility();
                    }
                    return print;
                }
            }
            public bool WriteToFile(List<string> list)
            {
                try
                {
                    using (var output = new StreamWriter(path))
                    {
                        output.WriteLine("# Pemrograman C#");
                        output.WriteLine("---------------------------");
                        output.WriteLine("Name  : Bagja Abdul Basith");
                        output.WriteLine("NIM   : 20.11.3351");
                        output.WriteLine("Prodi : S1-Informatika");
                        foreach (var line in list)
                        {
                            output.WriteLine(line);
                        }
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            public bool ReadToFile(List<string> list)
            {
                try
                {
                    if (!File.Exists(path))
                    {
                        return false;
                    }
                    else
                    {
                        if (list == null)
                        {
                            list = new List<string>();
                        }
                    }
                    var input = File.OpenText(path);
                    var scanner = string.Empty;
                    while ((scanner = input.ReadLine()) != null)
                    {
                        list.Add(scanner.ToString());
                        Console.WriteLine(scanner);
                    }
                    return true;
                }
                catch
                {
                    return false;
                }
            }

        }
    }
}

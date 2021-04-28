using System;
using System.Collections.Generic;
using System.Text;

namespace Supplier
{
    class supplier
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string gambar { get; set; }
        public string gender { get; set; }
        public int status1 { get; set; }
        public string cid { get; set; }
        public string status2 { get; set; }

        public void isidata()
        {
            Console.Write("Masukkan id anda         : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nama anda       : ");
            nama    = Console.ReadLine();
            Console.Write("Masukkan gambar anda     : ");
            gambar = Console.ReadLine();
            Console.Write("Masukkan gender anda     : ");
            gender = Console.ReadLine();
            Console.Write("Masukkan no status anda  : ");
            status1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
        }
        public void data()
        {
            cid = Convert.ToString(id);
            status2 = Convert.ToString(status1);

            Console.WriteLine("Id       : {0}", cid);
            Console.WriteLine("Nama     : {0}", nama);
            Console.WriteLine("Gambar   : {0}", gambar);
            if (gender != "perempuan" && gender != "laki-laki")
            {
            Console.WriteLine("Gender   : Gender Tidak Valid!");
            }
            else
            {
                Console.WriteLine("Gender   : {0}", this.gender);
            }
            if (status1 <= 0)
            {
                Console.WriteLine("Status Anda Tidak Valid!");
            }
            else
            {
                Console.WriteLine("Status   : {0}", this.status1);
            }
        }

        public bool kondisi(int status1)
        {
            if (status1 < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_C_Sharp
{
    internal interface IReadable
    {
        void Read();
    }
    internal interface IWritable
    {
        void Write();
    }
    class File : IReadable, IWritable
    {
        public string FileName { get; set; }

        public File(string _FileName)
        {
            FileName = _FileName;
        }
        public void Write()
        {
            Console.WriteLine($"write to {FileName}");
        }
        public void Read()
        {
            Console.WriteLine($"read from {FileName}");
        }
    }
}

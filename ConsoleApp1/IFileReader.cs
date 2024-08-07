using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public interface IFileReader
    {
        void ReadFile(string filePath);
    }
}

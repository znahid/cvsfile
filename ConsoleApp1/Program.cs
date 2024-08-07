using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFileReader pdfReader = new PDFReader();
            pdfReader.ReadFile("example.pdf");

            IFileReader csvReader = new CSVReaders();
            csvReader.ReadFile("data.csv");
        }
    }
}

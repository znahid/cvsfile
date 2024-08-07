using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace ConsoleApp1
{
    public class PDFReader : IFileReader
    {
        
        public void ReadFile(string filePath)
        {
            using (PdfDocument document = PdfReader.Open(filePath, PdfDocumentOpenMode.Import))
            {
                for (int i = 0; i < document.PageCount; i++)
                {
                    var page = document.Pages[i];
                    Console.Write(page);
                }
                Console.WriteLine();

            }
        }
    }
}

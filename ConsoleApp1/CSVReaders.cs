using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using CsvHelper;
namespace ConsoleApp1
{
    public class CSVReaders : IFileReader
    {
        public void ReadFile(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                using (var csv = new CsvHelper.CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    using (var dr = new CsvDataReader(csv))
                    {
                        var dataTable = new DataTable();
                        dataTable.Load(dr);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn col in dataTable.Columns)
                            {
                                Console.Write(row[col] + " ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}

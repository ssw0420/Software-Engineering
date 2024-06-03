using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class CsvHelperUtility
    {
        public static List<T> ReadCsv<T>(string filePath, ClassMap<T> map)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap(map);
                return new List<T>(csv.GetRecords<T>());
            }
        }
    }
}

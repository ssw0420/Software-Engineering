using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;
using CsvHelper;

namespace Kiosk
{
    public class CsvHelperUtility
    {
        public static List<T> ReadCsv<T>(string filePath, ClassMap<T> map)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap(map);
                return new List<T>(csv.GetRecords<T>());
            }
        }


        public static void WriteCsv<T>(string filePath, List<T> records)
        {
            // 디렉터리 확인 및 생성
            var directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var fileExists = File.Exists(filePath);
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                ShouldQuote = args => true,
                HasHeaderRecord = !fileExists // 파일이 존재하지 않을 때만 헤더를 추가
            };

            using (var writer = new StreamWriter(filePath, append: fileExists)) // 파일이 존재할 때 추가 기록
            using (var csv = new CsvWriter(writer, config))
            {
                if (!fileExists)
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord(); // 헤더와 데이터 사이의 줄바꿈
                }
                csv.WriteRecords(records);
            }
        }
    }
}

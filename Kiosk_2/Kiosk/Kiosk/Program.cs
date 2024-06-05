using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeCsvFiles();
            Application.Run(new CustomerMainForm());
        }
        /*        private static void InitializeCsvFiles()
                {
                    string orderFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv";
                    string orderItemFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv";

                    if (!System.IO.File.Exists(orderFilePath))
                    {
                        CsvHelperUtility.WriteCsv(orderFilePath, new List<Order>());
                    }

                    if (!System.IO.File.Exists(orderItemFilePath))
                    {
                        CsvHelperUtility.WriteCsv(orderItemFilePath, new List<OrderItem>());
                    }
                }*/


        private static void InitializeCsvFiles()
        {
            string orderFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv";
            string orderItemFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv";

            InitializeCsvFile<Order>(orderFilePath);
            InitializeCsvFile<OrderItem>(orderItemFilePath);
        }

        private static void InitializeCsvFile<T>(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                ShouldQuote = args => true,
                HasHeaderRecord = true
            };

            if (!System.IO.File.Exists(filePath))
            {
                // 파일이 없으면 파일을 생성하고 헤더를 작성
                using (var writer = new StreamWriter(filePath, false))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord(); // 헤더와 데이터 사이의 줄바꿈
                }
            }
            else
            {
                // 파일이 존재하면 내용을 초기화
                using (var writer = new StreamWriter(filePath, false))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord(); // 헤더와 데이터 사이의 줄바꿈
                }
            }
        }
    }
}


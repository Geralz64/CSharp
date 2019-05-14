﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibility
{
    public class CreateCSV<T>
    {

        public void CreateCSVFile(CSVFileInformation<T> csvFileInfo)
        {

            string fileFullPath =  csvFileInfo.FileLocation+ csvFileInfo.FileName;

            using (var writer = new StreamWriter(fileFullPath))
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.Configuration.HasHeaderRecord = csvFileInfo.HasHeader;
                    csv.Configuration.Delimiter = csvFileInfo.Delimiter;

                    csv.WriteRecords(csvFileInfo.Records);
                }
            }
        }

    }
}

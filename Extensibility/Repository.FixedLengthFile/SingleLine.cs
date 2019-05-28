﻿using Extensibility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

public class SingleLine<T>
{

    public static void CreateFile(FileInformation<T> fileInfo, List<string> records, List<Layout> layout)
    {
        List<string> formatedRecords = Utilities.Utilities.FormatRecords(records, layout);

        WriteFile(fileInfo, formatedRecords);

    }

    private static void WriteFile(FileInformation<T> fileInfo, List<string> formatedRecords)
    {
        using (var writer = new StreamWriter(fileInfo.FileLocation + fileInfo.FileName))
        {
            string finalLine = String.Empty;

            foreach (var record in formatedRecords)
            {
                finalLine += record;
            }

            writer.WriteLine(finalLine);
            writer.Close();
        }
    }





}

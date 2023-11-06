using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ExcelDataReader;
using UnityEngine;

namespace Code.Scripts.XLSX
{
    public static class XLSXReader
    {
        private const string Path = @"C:\Users\BIGPC_02\Documents\My Irkutsk\atlas_content-1.xlsx";

        public static List<T> ReadFile<T>(IExcelWritable<T> excelWritable)
        {
            using (FileStream stream = File.Open(Path, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var professions = new List<T>();

                    for (int i = 0; i < excelWritable.PageNumber; i++)
                    {
                        reader.NextResult();
                    }
                    
                    reader.Read();

                    while (reader.Read())
                    {
                        try
                        {
                            if (reader.GetValue(0) == null) continue;

                            professions.Add(excelWritable.Create(reader));
                        }
                        catch (Exception e)
                        {
                            Debug.Log(e);
                        }
                    }

                    return professions;
                }
            }
        }
    }
}
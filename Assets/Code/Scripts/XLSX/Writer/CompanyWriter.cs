using System.Collections.Generic;
using ExcelDataReader;
using UnityEngine;

namespace Code.Scripts.XLSX
{
    public class CompanyWriter : IExcelWritable<Company>
    {
        public int PageNumber => 5;

        public Company Create(IExcelDataReader reader)
        {
            var company = new Company()
            {
                name = reader.GetValue(1).ToString(),
                activity = reader.GetValue(2).ToString(),
                description = reader.GetValue(3).ToString(),
                wages = new Wages() { number = (int)reader.GetValue(5), prefix = reader.GetValue(4).ToString() },
                vacancy = new List<string>() { GetStringValue(6) },
                logoName = reader.GetValue(7).ToString(),
                website = reader.GetValue(8).ToString(),
                location = new Location(reader.GetValue(9).ToString(), 
                    new Vector2((float)reader.GetValue(10), (float)reader.GetValue(11))),
                advantages = new List<string>() {GetStringValue(12)},
                socialPackage = new List<string>() {GetStringValue(13)},
                isLeadingCompany = GetStringValue(14) == "1",
            };

            
            
            return company;
            string GetStringValue(int id)
            {
                return reader.GetValue(id).ToString();
            }
        }
        
    }
}